using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("1.0.0.0")]
namespace DG.Tweening
{
	[Token(Token = "0x2000002")]
	public enum AutoPlay
	{
		[Token(Token = "0x4000002")]
		None,
		[Token(Token = "0x4000003")]
		AutoPlaySequences,
		[Token(Token = "0x4000004")]
		AutoPlayTweeners,
		[Token(Token = "0x4000005")]
		All
	}
	[Token(Token = "0x2000003")]
	[Flags]
	public enum AxisConstraint
	{
		[Token(Token = "0x4000007")]
		None = 0,
		[Token(Token = "0x4000008")]
		X = 2,
		[Token(Token = "0x4000009")]
		Y = 4,
		[Token(Token = "0x400000A")]
		Z = 8,
		[Token(Token = "0x400000B")]
		W = 0x10
	}
	[Token(Token = "0x2000004")]
	public struct Color2
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color ca;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color cb;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x17A1FB4", Offset = "0x179DFB4", VA = "0x17A1FB4")]
		public Color2(Color ca, Color cb)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x17A1FC8", Offset = "0x179DFC8", VA = "0x17A1FC8")]
		public static Color2 operator +(Color2 c1, Color2 c2)
		{
			return default(Color2);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17A1FE0", Offset = "0x179DFE0", VA = "0x17A1FE0")]
		public static Color2 operator -(Color2 c1, Color2 c2)
		{
			return default(Color2);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17A1FF8", Offset = "0x179DFF8", VA = "0x17A1FF8")]
		public static Color2 operator *(Color2 c1, float f)
		{
			return default(Color2);
		}
	}
	[Token(Token = "0x2000005")]
	public delegate void TweenCallback();
	[Token(Token = "0x2000006")]
	public delegate void TweenCallback<in T>(T value);
	[Token(Token = "0x2000007")]
	public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period);
	[Token(Token = "0x2000008")]
	public class DOTween
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string Version;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool useSafeMode;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public static bool showUnityEditorReport;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float timeScale;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool useSmoothDeltaTime;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float maxSmoothUnscaledTime;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static LogBehaviour _logBehaviour;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static bool drawGizmos;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static UpdateType defaultUpdateType;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static bool defaultTimeScaleIndependent;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static AutoPlay defaultAutoPlay;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static bool defaultAutoKill;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static LoopType defaultLoopType;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static bool defaultRecyclable;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Ease defaultEaseType;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float defaultEaseOvershootOrAmplitude;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static float defaultEasePeriod;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static DOTweenComponent instance;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal static bool isUnityEditor;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		internal static bool isDebugBuild;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal static int maxActiveTweenersReached;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal static int maxActiveSequencesReached;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal static readonly List<TweenCallback> GizmosDelegates;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal static bool initialized;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		internal static bool isQuitting;

		[Token(Token = "0x17000001")]
		public static LogBehaviour logBehaviour
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17A2260", Offset = "0x179E260", VA = "0x17A2260")]
			get
			{
				return default(LogBehaviour);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x17A22B8", Offset = "0x179E2B8", VA = "0x17A22B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17A231C", Offset = "0x179E31C", VA = "0x17A231C")]
		static DOTween()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17A2468", Offset = "0x179E468", VA = "0x17A2468")]
		public static IDOTweenInit Init([Optional] bool? recycleAllByDefault, [Optional] bool? useSafeMode, [Optional] LogBehaviour? logBehaviour)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17A2C00", Offset = "0x179EC00", VA = "0x17A2C00")]
		private static void AutoInit()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17A25F0", Offset = "0x179E5F0", VA = "0x17A25F0")]
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17A2CD4", Offset = "0x179ECD4", VA = "0x17A2CD4")]
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17A2D3C", Offset = "0x179ED3C", VA = "0x17A2D3C")]
		public static void Clear(bool destroy = false)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17A2E3C", Offset = "0x179EE3C", VA = "0x17A2E3C")]
		public static void ClearCachedTweens()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17A2E8C", Offset = "0x179EE8C", VA = "0x17A2E8C")]
		public static int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17A2EDC", Offset = "0x179EEDC", VA = "0x17A2EDC")]
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17A3020", Offset = "0x179F020", VA = "0x17A3020")]
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x17A30B8", Offset = "0x179F0B8", VA = "0x17A30B8")]
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x17A3150", Offset = "0x179F150", VA = "0x17A3150")]
		public static Tweener To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17A31E8", Offset = "0x179F1E8", VA = "0x17A31E8")]
		public static Tweener To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x17A3280", Offset = "0x179F280", VA = "0x17A3280")]
		public static Tweener To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17A3318", Offset = "0x179F318", VA = "0x17A3318")]
		public static Tweener To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17A33B0", Offset = "0x179F3B0", VA = "0x17A33B0")]
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x17A3448", Offset = "0x179F448", VA = "0x17A3448")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17A34F0", Offset = "0x179F4F0", VA = "0x17A34F0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17A35A0", Offset = "0x179F5A0", VA = "0x17A35A0")]
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17A3660", Offset = "0x179F660", VA = "0x17A3660")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17A3710", Offset = "0x179F710", VA = "0x17A3710")]
		public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x17A37D0", Offset = "0x179F7D0", VA = "0x17A37D0")]
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x17A3890", Offset = "0x179F890", VA = "0x17A3890")]
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17A3928", Offset = "0x179F928", VA = "0x17A3928")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x17A39DC", Offset = "0x179F9DC", VA = "0x17A39DC")]
		public static Tweener ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x17A3AB0", Offset = "0x179FAB0", VA = "0x17A3AB0")]
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x17A3C20", Offset = "0x179FC20", VA = "0x17A3C20")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17A4234", Offset = "0x17A0234", VA = "0x17A4234")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17A4988", Offset = "0x17A0988", VA = "0x17A4988")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17A42EC", Offset = "0x17A02EC", VA = "0x17A42EC")]
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17A4010", Offset = "0x17A0010", VA = "0x17A4010")]
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17A4A4C", Offset = "0x17A0A4C", VA = "0x17A4A4C")]
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x17A4B00", Offset = "0x17A0B00", VA = "0x17A4B00")]
		public static Sequence Sequence()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x17A4C5C", Offset = "0x17A0C5C", VA = "0x17A4C5C")]
		public static int CompleteAll(bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x17A4CD8", Offset = "0x17A0CD8", VA = "0x17A4CD8")]
		public static int Complete(object targetOrId, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x17A4D7C", Offset = "0x17A0D7C", VA = "0x17A4D7C")]
		internal static int CompleteAndReturnKilledTot()
		{
			return default(int);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x17A4DE8", Offset = "0x17A0DE8", VA = "0x17A4DE8")]
		internal static int CompleteAndReturnKilledTot(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x17A4E6C", Offset = "0x17A0E6C", VA = "0x17A4E6C")]
		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds)
		{
			return default(int);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x17A4EDC", Offset = "0x17A0EDC", VA = "0x17A4EDC")]
		public static int FlipAll()
		{
			return default(int);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x17A4F48", Offset = "0x17A0F48", VA = "0x17A4F48")]
		public static int Flip(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x17A4FCC", Offset = "0x17A0FCC", VA = "0x17A4FCC")]
		public static int GotoAll(float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x17A5048", Offset = "0x17A1048", VA = "0x17A5048")]
		public static int Goto(object targetOrId, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x17A50E0", Offset = "0x17A10E0", VA = "0x17A50E0")]
		public static int KillAll(bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x17A5174", Offset = "0x17A1174", VA = "0x17A5174")]
		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude)
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x17A527C", Offset = "0x17A127C", VA = "0x17A527C")]
		public static int Kill(object targetOrId, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x17A5340", Offset = "0x17A1340", VA = "0x17A5340")]
		public static int PauseAll()
		{
			return default(int);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x17A53AC", Offset = "0x17A13AC", VA = "0x17A53AC")]
		public static int Pause(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x17A5430", Offset = "0x17A1430", VA = "0x17A5430")]
		public static int PlayAll()
		{
			return default(int);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17A549C", Offset = "0x17A149C", VA = "0x17A549C")]
		public static int Play(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x17A5520", Offset = "0x17A1520", VA = "0x17A5520")]
		public static int Play(object target, object id)
		{
			return default(int);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x17A55AC", Offset = "0x17A15AC", VA = "0x17A55AC")]
		public static int PlayBackwardsAll()
		{
			return default(int);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x17A5618", Offset = "0x17A1618", VA = "0x17A5618")]
		public static int PlayBackwards(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x17A569C", Offset = "0x17A169C", VA = "0x17A569C")]
		public static int PlayBackwards(object target, object id)
		{
			return default(int);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17A5728", Offset = "0x17A1728", VA = "0x17A5728")]
		public static int PlayForwardAll()
		{
			return default(int);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x17A5794", Offset = "0x17A1794", VA = "0x17A5794")]
		public static int PlayForward(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x17A5818", Offset = "0x17A1818", VA = "0x17A5818")]
		public static int PlayForward(object target, object id)
		{
			return default(int);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x17A58A4", Offset = "0x17A18A4", VA = "0x17A58A4")]
		public static int RestartAll(bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x17A5914", Offset = "0x17A1914", VA = "0x17A5914")]
		public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return default(int);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x17A59AC", Offset = "0x17A19AC", VA = "0x17A59AC")]
		public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return default(int);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x17A5A58", Offset = "0x17A1A58", VA = "0x17A5A58")]
		public static int RewindAll(bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x17A5AC8", Offset = "0x17A1AC8", VA = "0x17A5AC8")]
		public static int Rewind(object targetOrId, bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x17A5B50", Offset = "0x17A1B50", VA = "0x17A5B50")]
		public static int SmoothRewindAll()
		{
			return default(int);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x17A5BBC", Offset = "0x17A1BBC", VA = "0x17A5BBC")]
		public static int SmoothRewind(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x17A5C40", Offset = "0x17A1C40", VA = "0x17A5C40")]
		public static int TogglePauseAll()
		{
			return default(int);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17A5CAC", Offset = "0x17A1CAC", VA = "0x17A5CAC")]
		public static int TogglePause(object targetOrId)
		{
			return default(int);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x17A5D30", Offset = "0x17A1D30", VA = "0x17A5D30")]
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x17A5DB8", Offset = "0x17A1DB8", VA = "0x17A5DB8")]
		public static int TotalPlayingTweens()
		{
			return default(int);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17A5E08", Offset = "0x17A1E08", VA = "0x17A5E08")]
		public static List<Tween> PlayingTweens()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x17A5E5C", Offset = "0x17A1E5C", VA = "0x17A5E5C")]
		public static List<Tween> PausedTweens()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x17A5EB0", Offset = "0x17A1EB0", VA = "0x17A5EB0")]
		public static List<Tween> TweensById(object id, bool playingOnly = false)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17A5F24", Offset = "0x17A1F24", VA = "0x17A5F24")]
		public static List<Tween> TweensByTarget(object target, bool playingOnly = false)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x17A2F5C", Offset = "0x179EF5C", VA = "0x17A2F5C")]
		private static void InitCheck()
		{
		}

		[Token(Token = "0x600005C")]
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, [Optional] ABSTweenPlugin<T1, T2, TPlugOptions> plugin) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x17A5F8C", Offset = "0x17A1F8C", VA = "0x17A5F8C")]
		public DOTween()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public static class DOVirtual
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x17A5FC0", Offset = "0x17A1FC0", VA = "0x17A5FC0")]
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x17A6188", Offset = "0x17A2188", VA = "0x17A6188")]
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x17A6224", Offset = "0x17A2224", VA = "0x17A6224")]
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x17A62C8", Offset = "0x17A22C8", VA = "0x17A62C8")]
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x17A630C", Offset = "0x17A230C", VA = "0x17A630C")]
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x17A6424", Offset = "0x17A2424", VA = "0x17A6424")]
		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true)
		{
			return null;
		}
	}
	[Token(Token = "0x200000C")]
	public enum Ease
	{
		[Token(Token = "0x400002C")]
		Unset,
		[Token(Token = "0x400002D")]
		Linear,
		[Token(Token = "0x400002E")]
		InSine,
		[Token(Token = "0x400002F")]
		OutSine,
		[Token(Token = "0x4000030")]
		InOutSine,
		[Token(Token = "0x4000031")]
		InQuad,
		[Token(Token = "0x4000032")]
		OutQuad,
		[Token(Token = "0x4000033")]
		InOutQuad,
		[Token(Token = "0x4000034")]
		InCubic,
		[Token(Token = "0x4000035")]
		OutCubic,
		[Token(Token = "0x4000036")]
		InOutCubic,
		[Token(Token = "0x4000037")]
		InQuart,
		[Token(Token = "0x4000038")]
		OutQuart,
		[Token(Token = "0x4000039")]
		InOutQuart,
		[Token(Token = "0x400003A")]
		InQuint,
		[Token(Token = "0x400003B")]
		OutQuint,
		[Token(Token = "0x400003C")]
		InOutQuint,
		[Token(Token = "0x400003D")]
		InExpo,
		[Token(Token = "0x400003E")]
		OutExpo,
		[Token(Token = "0x400003F")]
		InOutExpo,
		[Token(Token = "0x4000040")]
		InCirc,
		[Token(Token = "0x4000041")]
		OutCirc,
		[Token(Token = "0x4000042")]
		InOutCirc,
		[Token(Token = "0x4000043")]
		InElastic,
		[Token(Token = "0x4000044")]
		OutElastic,
		[Token(Token = "0x4000045")]
		InOutElastic,
		[Token(Token = "0x4000046")]
		InBack,
		[Token(Token = "0x4000047")]
		OutBack,
		[Token(Token = "0x4000048")]
		InOutBack,
		[Token(Token = "0x4000049")]
		InBounce,
		[Token(Token = "0x400004A")]
		OutBounce,
		[Token(Token = "0x400004B")]
		InOutBounce,
		[Token(Token = "0x400004C")]
		Flash,
		[Token(Token = "0x400004D")]
		InFlash,
		[Token(Token = "0x400004E")]
		OutFlash,
		[Token(Token = "0x400004F")]
		InOutFlash,
		[Token(Token = "0x4000050")]
		INTERNAL_Zero,
		[Token(Token = "0x4000051")]
		INTERNAL_Custom
	}
	[Token(Token = "0x200000D")]
	public class EaseFactory
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x17A6574", Offset = "0x17A2574", VA = "0x17A6574")]
		public static EaseFunction StopMotion(int motionFps, [Optional] Ease? ease)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x17A66EC", Offset = "0x17A26EC", VA = "0x17A66EC")]
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x17A662C", Offset = "0x17A262C", VA = "0x17A662C")]
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x17A67A8", Offset = "0x17A27A8", VA = "0x17A67A8")]
		public EaseFactory()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public interface IDOTweenInit
	{
		[Token(Token = "0x6000071")]
		IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
	}
	[Token(Token = "0x2000010")]
	public enum PathMode
	{
		[Token(Token = "0x4000055")]
		Ignore,
		[Token(Token = "0x4000056")]
		Full3D,
		[Token(Token = "0x4000057")]
		TopDown2D,
		[Token(Token = "0x4000058")]
		Sidescroller2D
	}
	[Token(Token = "0x2000011")]
	public enum PathType
	{
		[Token(Token = "0x400005A")]
		Linear,
		[Token(Token = "0x400005B")]
		CatmullRom
	}
	[Token(Token = "0x2000012")]
	public enum RotateMode
	{
		[Token(Token = "0x400005D")]
		Fast,
		[Token(Token = "0x400005E")]
		FastBeyond360,
		[Token(Token = "0x400005F")]
		WorldAxisAdd,
		[Token(Token = "0x4000060")]
		LocalAxisAdd
	}
	[Token(Token = "0x2000013")]
	public enum ScrambleMode
	{
		[Token(Token = "0x4000062")]
		None,
		[Token(Token = "0x4000063")]
		All,
		[Token(Token = "0x4000064")]
		Uppercase,
		[Token(Token = "0x4000065")]
		Lowercase,
		[Token(Token = "0x4000066")]
		Numerals,
		[Token(Token = "0x4000067")]
		Custom
	}
	[Token(Token = "0x2000014")]
	public static class TweenExtensions
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x17A6820", Offset = "0x17A2820", VA = "0x17A6820")]
		public static void Complete(this Tween t)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x17A6828", Offset = "0x17A2828", VA = "0x17A6828")]
		public static void Complete(this Tween t, bool withCallbacks)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x17A694C", Offset = "0x17A294C", VA = "0x17A694C")]
		public static void Flip(this Tween t)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x17A6A60", Offset = "0x17A2A60", VA = "0x17A6A60")]
		public static void ForceInit(this Tween t)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x17A6B78", Offset = "0x17A2B78", VA = "0x17A6B78")]
		public static void Goto(this Tween t, float to, bool andPlay = false)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x17A6CC4", Offset = "0x17A2CC4", VA = "0x17A6CC4")]
		public static void Kill(this Tween t, bool complete = false)
		{
		}

		[Token(Token = "0x6000078")]
		public static T Pause<T>(this T t) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		public static T Play<T>(this T t) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x17A6E40", Offset = "0x17A2E40", VA = "0x17A6E40")]
		public static void PlayBackwards(this Tween t)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x17A6F54", Offset = "0x17A2F54", VA = "0x17A6F54")]
		public static void PlayForward(this Tween t)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x17A7068", Offset = "0x17A3068", VA = "0x17A7068")]
		public static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x17A71A4", Offset = "0x17A31A4", VA = "0x17A71A4")]
		public static void Rewind(this Tween t, bool includeDelay = true)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x17A72C0", Offset = "0x17A32C0", VA = "0x17A72C0")]
		public static void SmoothRewind(this Tween t)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x17A73D4", Offset = "0x17A33D4", VA = "0x17A73D4")]
		public static void TogglePause(this Tween t)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x17A74E8", Offset = "0x17A34E8", VA = "0x17A74E8")]
		public static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x17A77DC", Offset = "0x17A37DC", VA = "0x17A77DC")]
		public static YieldInstruction WaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x17A78AC", Offset = "0x17A38AC", VA = "0x17A78AC")]
		public static YieldInstruction WaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x17A797C", Offset = "0x17A397C", VA = "0x17A797C")]
		public static YieldInstruction WaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x17A7A4C", Offset = "0x17A3A4C", VA = "0x17A7A4C")]
		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x17A7B24", Offset = "0x17A3B24", VA = "0x17A7B24")]
		public static YieldInstruction WaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x17A7C08", Offset = "0x17A3C08", VA = "0x17A7C08")]
		public static Coroutine WaitForStart(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x17A7CD8", Offset = "0x17A3CD8", VA = "0x17A7CD8")]
		public static int CompletedLoops(this Tween t)
		{
			return default(int);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x17A7D54", Offset = "0x17A3D54", VA = "0x17A7D54")]
		public static float Delay(this Tween t)
		{
			return default(float);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x17A7DDC", Offset = "0x17A3DDC", VA = "0x17A7DDC")]
		public static float Duration(this Tween t, bool includeLoops = true)
		{
			return default(float);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x17A7E94", Offset = "0x17A3E94", VA = "0x17A7E94")]
		public static float Elapsed(this Tween t, bool includeLoops = true)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x17A7F44", Offset = "0x17A3F44", VA = "0x17A7F44")]
		public static float ElapsedPercentage(this Tween t, bool includeLoops = true)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x17A7FFC", Offset = "0x17A3FFC", VA = "0x17A7FFC")]
		public static float ElapsedDirectionalPercentage(this Tween t)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x17A80C0", Offset = "0x17A40C0", VA = "0x17A80C0")]
		public static bool IsActive(this Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x17A80D4", Offset = "0x17A40D4", VA = "0x17A80D4")]
		public static bool IsBackwards(this Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x17A8150", Offset = "0x17A4150", VA = "0x17A8150")]
		public static bool IsComplete(this Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x17A81CC", Offset = "0x17A41CC", VA = "0x17A81CC")]
		public static bool IsInitialized(this Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x17A8248", Offset = "0x17A4248", VA = "0x17A8248")]
		public static bool IsPlaying(this Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x17A82C4", Offset = "0x17A42C4", VA = "0x17A82C4")]
		public static int Loops(this Tween t)
		{
			return default(int);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x17A8340", Offset = "0x17A4340", VA = "0x17A8340")]
		public static Vector3 PathGetPoint(this Tween t, float pathPercentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x17A8544", Offset = "0x17A4544", VA = "0x17A8544")]
		public static Vector3[] PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x17A86EC", Offset = "0x17A46EC", VA = "0x17A86EC")]
		public static float PathLength(this Tween t)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000015")]
	public enum LoopType
	{
		[Token(Token = "0x4000069")]
		Restart,
		[Token(Token = "0x400006A")]
		Yoyo,
		[Token(Token = "0x400006B")]
		Incremental
	}
	[Token(Token = "0x2000016")]
	public sealed class Sequence : Tween
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal readonly List<Tween> sequencedTweens;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly List<ABSSequentiable> _sequencedObjs;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal float lastTweenInsertTime;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x17A88A0", Offset = "0x17A48A0", VA = "0x17A88A0")]
		internal Sequence()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x17A89A8", Offset = "0x17A49A8", VA = "0x17A89A8")]
		internal static Sequence DoPrepend(Sequence inSequence, Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x17A8AA0", Offset = "0x17A4AA0", VA = "0x17A8AA0")]
		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x17A8C60", Offset = "0x17A4C60", VA = "0x17A8C60")]
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x17A8C80", Offset = "0x17A4C80", VA = "0x17A8C80")]
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x17A8D54", Offset = "0x17A4D54", VA = "0x17A8D54")]
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x17A8E54", Offset = "0x17A4E54", VA = "0x17A8E54", Slot = "4")]
		internal override void Reset()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x17A8FE4", Offset = "0x17A4FE4", VA = "0x17A8FE4", Slot = "5")]
		internal override bool Validate()
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x17A90A0", Offset = "0x17A50A0", VA = "0x17A90A0", Slot = "7")]
		internal override bool Startup()
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x17A9280", Offset = "0x17A5280", VA = "0x17A9280", Slot = "8")]
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x17A4B88", Offset = "0x17A0B88", VA = "0x17A4B88")]
		internal static void Setup(Sequence s)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x17A90A4", Offset = "0x17A50A4", VA = "0x17A90A4")]
		internal static bool DoStartup(Sequence s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x17A9284", Offset = "0x17A5284", VA = "0x17A9284")]
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x17A954C", Offset = "0x17A554C", VA = "0x17A954C")]
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x17A9BB8", Offset = "0x17A5BB8", VA = "0x17A9BB8")]
		private static int SortSequencedObjs(ABSSequentiable a, ABSSequentiable b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000017")]
	public static class ShortcutExtensions
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x17A9BF8", Offset = "0x17A5BF8", VA = "0x17A9BF8")]
		public static Tweener DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x17A9D84", Offset = "0x17A5D84", VA = "0x17A9D84")]
		public static Tweener DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x17A9EE8", Offset = "0x17A5EE8", VA = "0x17A9EE8")]
		public static Tweener DOAspect(this Camera target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x17AA04C", Offset = "0x17A604C", VA = "0x17AA04C")]
		public static Tweener DOColor(this Camera target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17AA1D8", Offset = "0x17A61D8", VA = "0x17AA1D8")]
		public static Tweener DOFarClipPlane(this Camera target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17AA33C", Offset = "0x17A633C", VA = "0x17AA33C")]
		public static Tweener DOFieldOfView(this Camera target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17AA4A0", Offset = "0x17A64A0", VA = "0x17AA4A0")]
		public static Tweener DONearClipPlane(this Camera target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x17AA604", Offset = "0x17A6604", VA = "0x17AA604")]
		public static Tweener DOOrthoSize(this Camera target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x17AA768", Offset = "0x17A6768", VA = "0x17AA768")]
		public static Tweener DOPixelRect(this Camera target, Rect endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x17AA8F4", Offset = "0x17A68F4", VA = "0x17AA8F4")]
		public static Tweener DORect(this Camera target, Rect endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x17AAA80", Offset = "0x17A6A80", VA = "0x17AAA80")]
		public static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x17AACB0", Offset = "0x17A6CB0", VA = "0x17AACB0")]
		public static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x17AAEF8", Offset = "0x17A6EF8", VA = "0x17AAEF8")]
		public static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x17AB128", Offset = "0x17A7128", VA = "0x17AB128")]
		public static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x17AB370", Offset = "0x17A7370", VA = "0x17AB370")]
		public static Tweener DOColor(this Light target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x17AB4FC", Offset = "0x17A74FC", VA = "0x17AB4FC")]
		public static Tweener DOIntensity(this Light target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x17AB660", Offset = "0x17A7660", VA = "0x17AB660")]
		public static Tweener DOShadowStrength(this Light target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x17AB7C4", Offset = "0x17A77C4", VA = "0x17AB7C4")]
		public static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x17AB94C", Offset = "0x17A794C", VA = "0x17AB94C")]
		public static Tweener DOColor(this Material target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x17ABAD8", Offset = "0x17A7AD8", VA = "0x17ABAD8")]
		public static Tweener DOColor(this Material target, Color endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x17ABCCC", Offset = "0x17A7CCC", VA = "0x17ABCCC")]
		public static Tweener DOFade(this Material target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x17ABE30", Offset = "0x17A7E30", VA = "0x17ABE30")]
		public static Tweener DOFade(this Material target, float endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x17ABFF4", Offset = "0x17A7FF4", VA = "0x17ABFF4")]
		public static Tweener DOFloat(this Material target, float endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x17AC1B8", Offset = "0x17A81B8", VA = "0x17AC1B8")]
		public static Tweener DOOffset(this Material target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x17AC32C", Offset = "0x17A832C", VA = "0x17AC32C")]
		public static Tweener DOOffset(this Material target, Vector2 endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x17AC504", Offset = "0x17A8504", VA = "0x17AC504")]
		public static Tweener DOTiling(this Material target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x17AC678", Offset = "0x17A8678", VA = "0x17AC678")]
		public static Tweener DOTiling(this Material target, Vector2 endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x17AC850", Offset = "0x17A8850", VA = "0x17AC850")]
		public static Tweener DOVector(this Material target, Vector4 endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x17ACA44", Offset = "0x17A8A44", VA = "0x17ACA44")]
		public static Tweener DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x17ACBFC", Offset = "0x17A8BFC", VA = "0x17ACBFC")]
		public static Tweener DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x17ACDB0", Offset = "0x17A8DB0", VA = "0x17ACDB0")]
		public static Tweener DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x17ACF48", Offset = "0x17A8F48", VA = "0x17ACF48")]
		public static Tweener DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x17AD0E0", Offset = "0x17A90E0", VA = "0x17AD0E0")]
		public static Tweener DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x17AD280", Offset = "0x17A9280", VA = "0x17AD280")]
		public static Tweener DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x17AD4D4", Offset = "0x17A94D4", VA = "0x17AD4D4")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x17AD9C8", Offset = "0x17A99C8", VA = "0x17AD9C8")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x17ADC08", Offset = "0x17A9C08", VA = "0x17ADC08")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17ADE64", Offset = "0x17A9E64", VA = "0x17ADE64")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x17AE020", Offset = "0x17AA020", VA = "0x17AE020")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x17AE1F0", Offset = "0x17AA1F0", VA = "0x17AE1F0")]
		public static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x17AE364", Offset = "0x17AA364", VA = "0x17AE364")]
		public static Tweener DOTime(this TrailRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x17AE4C8", Offset = "0x17AA4C8", VA = "0x17AE4C8")]
		public static Tweener DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x17AE65C", Offset = "0x17AA65C", VA = "0x17AE65C")]
		public static Tweener DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17AE7E8", Offset = "0x17AA7E8", VA = "0x17AE7E8")]
		public static Tweener DOMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x17AE974", Offset = "0x17AA974", VA = "0x17AE974")]
		public static Tweener DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17AEB00", Offset = "0x17AAB00", VA = "0x17AEB00")]
		public static Tweener DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x17AEC94", Offset = "0x17AAC94", VA = "0x17AEC94")]
		public static Tweener DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x17AEE20", Offset = "0x17AAE20", VA = "0x17AEE20")]
		public static Tweener DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x17AEFAC", Offset = "0x17AAFAC", VA = "0x17AEFAC")]
		public static Tweener DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x17AF138", Offset = "0x17AB138", VA = "0x17AF138")]
		public static Tweener DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x17AF2D4", Offset = "0x17AB2D4", VA = "0x17AF2D4")]
		public static Tweener DORotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x17AF4A0", Offset = "0x17AB4A0", VA = "0x17AF4A0")]
		public static Tweener DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x17AF63C", Offset = "0x17AB63C", VA = "0x17AF63C")]
		public static Tweener DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x17AF808", Offset = "0x17AB808", VA = "0x17AF808")]
		public static Tweener DOScale(this Transform target, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x17AF984", Offset = "0x17AB984", VA = "0x17AF984")]
		public static Tweener DOScale(this Transform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x17AFAF0", Offset = "0x17ABAF0", VA = "0x17AFAF0")]
		public static Tweener DOScaleX(this Transform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x17AFC74", Offset = "0x17ABC74", VA = "0x17AFC74")]
		public static Tweener DOScaleY(this Transform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x17AFDF8", Offset = "0x17ABDF8", VA = "0x17AFDF8")]
		public static Tweener DOScaleZ(this Transform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x17AFF7C", Offset = "0x17ABF7C", VA = "0x17AFF7C")]
		public static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17B01CC", Offset = "0x17AC1CC", VA = "0x17B01CC")]
		public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x17B0408", Offset = "0x17AC408", VA = "0x17B0408")]
		public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x17B0628", Offset = "0x17AC628", VA = "0x17B0628")]
		public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17B0848", Offset = "0x17AC848", VA = "0x17B0848")]
		public static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x17B0A88", Offset = "0x17ACA88", VA = "0x17B0A88")]
		public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17B0CDC", Offset = "0x17ACCDC", VA = "0x17B0CDC")]
		public static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x17B0F0C", Offset = "0x17ACF0C", VA = "0x17B0F0C")]
		public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17B1154", Offset = "0x17AD154", VA = "0x17B1154")]
		public static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17B13D8", Offset = "0x17AD3D8", VA = "0x17B13D8")]
		public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x17B1620", Offset = "0x17AD620", VA = "0x17B1620")]
		public static Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x17B1AA0", Offset = "0x17ADAA0", VA = "0x17B1AA0")]
		public static Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x17B1F20", Offset = "0x17ADF20", VA = "0x17B1F20")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x17B2134", Offset = "0x17AE134", VA = "0x17B2134")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x17B2350", Offset = "0x17AE350", VA = "0x17B2350")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x17B2500", Offset = "0x17AE500", VA = "0x17B2500")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x17B26B8", Offset = "0x17AE6B8", VA = "0x17B26B8")]
		public static Tweener DOTimeScale(this Tween target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x17B281C", Offset = "0x17AE81C", VA = "0x17B281C")]
		public static Tweener DOBlendableColor(this Light target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x17B2A08", Offset = "0x17AEA08", VA = "0x17B2A08")]
		public static Tweener DOBlendableColor(this Material target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x17B2BF4", Offset = "0x17AEBF4", VA = "0x17B2BF4")]
		public static Tweener DOBlendableColor(this Material target, Color endValue, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x17B2E2C", Offset = "0x17AEE2C", VA = "0x17B2E2C")]
		public static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17B3024", Offset = "0x17AF024", VA = "0x17B3024")]
		public static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x17B321C", Offset = "0x17AF21C", VA = "0x17B321C")]
		public static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x17B340C", Offset = "0x17AF40C", VA = "0x17B340C")]
		public static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17B35FC", Offset = "0x17AF5FC", VA = "0x17B35FC")]
		public static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x17B37DC", Offset = "0x17AF7DC", VA = "0x17B37DC")]
		public static int DOComplete(this Component target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x17B3840", Offset = "0x17AF840", VA = "0x17B3840")]
		public static int DOComplete(this Material target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x17B38A4", Offset = "0x17AF8A4", VA = "0x17B38A4")]
		public static int DOKill(this Component target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x17B3908", Offset = "0x17AF908", VA = "0x17B3908")]
		public static int DOKill(this Material target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x17B396C", Offset = "0x17AF96C", VA = "0x17B396C")]
		public static int DOFlip(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x17B39C0", Offset = "0x17AF9C0", VA = "0x17B39C0")]
		public static int DOFlip(this Material target)
		{
			return default(int);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x17B3A14", Offset = "0x17AFA14", VA = "0x17B3A14")]
		public static int DOGoto(this Component target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x17B3A88", Offset = "0x17AFA88", VA = "0x17B3A88")]
		public static int DOGoto(this Material target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x17B3AFC", Offset = "0x17AFAFC", VA = "0x17B3AFC")]
		public static int DOPause(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17B3B50", Offset = "0x17AFB50", VA = "0x17B3B50")]
		public static int DOPause(this Material target)
		{
			return default(int);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17B3BA4", Offset = "0x17AFBA4", VA = "0x17B3BA4")]
		public static int DOPlay(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x17B3BF8", Offset = "0x17AFBF8", VA = "0x17B3BF8")]
		public static int DOPlay(this Material target)
		{
			return default(int);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x17B3C4C", Offset = "0x17AFC4C", VA = "0x17B3C4C")]
		public static int DOPlayBackwards(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x17B3CA0", Offset = "0x17AFCA0", VA = "0x17B3CA0")]
		public static int DOPlayBackwards(this Material target)
		{
			return default(int);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17B3CF4", Offset = "0x17AFCF4", VA = "0x17B3CF4")]
		public static int DOPlayForward(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x17B3D48", Offset = "0x17AFD48", VA = "0x17B3D48")]
		public static int DOPlayForward(this Material target)
		{
			return default(int);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x17B3D9C", Offset = "0x17AFD9C", VA = "0x17B3D9C")]
		public static int DORestart(this Component target, bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17B3E04", Offset = "0x17AFE04", VA = "0x17B3E04")]
		public static int DORestart(this Material target, bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x17B3E6C", Offset = "0x17AFE6C", VA = "0x17B3E6C")]
		public static int DORewind(this Component target, bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x17B3ED0", Offset = "0x17AFED0", VA = "0x17B3ED0")]
		public static int DORewind(this Material target, bool includeDelay = true)
		{
			return default(int);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17B3F34", Offset = "0x17AFF34", VA = "0x17B3F34")]
		public static int DOSmoothRewind(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17B3F88", Offset = "0x17AFF88", VA = "0x17B3F88")]
		public static int DOSmoothRewind(this Material target)
		{
			return default(int);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17B3FDC", Offset = "0x17AFFDC", VA = "0x17B3FDC")]
		public static int DOTogglePause(this Component target)
		{
			return default(int);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x17B4030", Offset = "0x17B0030", VA = "0x17B4030")]
		public static int DOTogglePause(this Material target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200006B")]
	public class TweenParams
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TweenParams Params;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object id;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object target;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal UpdateType updateType;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool isIndependentUpdate;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal TweenCallback onStart;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal TweenCallback onPlay;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal TweenCallback onRewind;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal TweenCallback onUpdate;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal TweenCallback onStepComplete;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal TweenCallback onComplete;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal TweenCallback onKill;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal TweenCallback<int> onWaypointChange;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal bool isRecyclable;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		internal bool isSpeedBased;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		internal bool autoKill;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int loops;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal LoopType loopType;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal float delay;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal bool isRelative;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		internal Ease easeType;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal EaseFunction customEase;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal float easeOvershootOrAmplitude;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal float easePeriod;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x17B5DB8", Offset = "0x17B1DB8", VA = "0x17B5DB8")]
		public TweenParams()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x17B5DD4", Offset = "0x17B1DD4", VA = "0x17B5DD4")]
		public TweenParams Clear()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x17B5E90", Offset = "0x17B1E90", VA = "0x17B5E90")]
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x17B5E98", Offset = "0x17B1E98", VA = "0x17B5E98")]
		public TweenParams SetId(object id)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x17B5EA0", Offset = "0x17B1EA0", VA = "0x17B5EA0")]
		public TweenParams SetTarget(object target)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x17B5EA8", Offset = "0x17B1EA8", VA = "0x17B5EA8")]
		public TweenParams SetLoops(int loops, [Optional] LoopType? loopType)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x17B5F38", Offset = "0x17B1F38", VA = "0x17B5F38")]
		public TweenParams SetEase(Ease ease, [Optional] float? overshootOrAmplitude, [Optional] float? period)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x17B603C", Offset = "0x17B203C", VA = "0x17B603C")]
		public TweenParams SetEase(AnimationCurve animCurve)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x17B60F8", Offset = "0x17B20F8", VA = "0x17B60F8")]
		public TweenParams SetEase(EaseFunction customEase)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x17B6108", Offset = "0x17B2108", VA = "0x17B6108")]
		public TweenParams SetRecyclable(bool recyclable = true)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x17B6110", Offset = "0x17B2110", VA = "0x17B6110")]
		public TweenParams SetUpdate(bool isIndependentUpdate)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x17B6188", Offset = "0x17B2188", VA = "0x17B6188")]
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x17B6194", Offset = "0x17B2194", VA = "0x17B6194")]
		public TweenParams OnStart(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x17B619C", Offset = "0x17B219C", VA = "0x17B619C")]
		public TweenParams OnPlay(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x17B61A4", Offset = "0x17B21A4", VA = "0x17B61A4")]
		public TweenParams OnRewind(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x17B61AC", Offset = "0x17B21AC", VA = "0x17B61AC")]
		public TweenParams OnUpdate(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x17B61B4", Offset = "0x17B21B4", VA = "0x17B61B4")]
		public TweenParams OnStepComplete(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x17B61BC", Offset = "0x17B21BC", VA = "0x17B61BC")]
		public TweenParams OnComplete(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x17B61C4", Offset = "0x17B21C4", VA = "0x17B61C4")]
		public TweenParams OnKill(TweenCallback action)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x17B61CC", Offset = "0x17B21CC", VA = "0x17B61CC")]
		public TweenParams OnWaypointChange(TweenCallback<int> action)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x17B61D4", Offset = "0x17B21D4", VA = "0x17B61D4")]
		public TweenParams SetDelay(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x17B61DC", Offset = "0x17B21DC", VA = "0x17B61DC")]
		public TweenParams SetRelative(bool isRelative = true)
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x17B61E4", Offset = "0x17B21E4", VA = "0x17B61E4")]
		public TweenParams SetSpeedBased(bool isSpeedBased = true)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public static class TweenSettingsExtensions
	{
		[Token(Token = "0x6000225")]
		public static T SetAutoKill<T>(this T t) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		public static T SetId<T>(this T t, object id) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		public static T SetTarget<T>(this T t, object target) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		public static T SetLoops<T>(this T t, int loops) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		public static T SetLoops<T>(this T t, int loops, LoopType loopType) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		public static T SetEase<T>(this T t, Ease ease) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		public static T SetEase<T>(this T t, Ease ease, float overshoot) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		public static T SetEase<T>(this T t, AnimationCurve animCurve) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		public static T SetEase<T>(this T t, EaseFunction customEase) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		public static T SetRecyclable<T>(this T t) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		public static T SetRecyclable<T>(this T t, bool recyclable) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		public static T SetUpdate<T>(this T t, UpdateType updateType) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		public static T OnStart<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		public static T OnPlay<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		public static T OnPause<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		public static T OnRewind<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		public static T OnUpdate<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		public static T OnStepComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		public static T OnComplete<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		public static T OnKill<T>(this T t, TweenCallback action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		public static T SetAs<T>(this T t, Tween asTween) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		public static T SetAs<T>(this T t, TweenParams tweenParams) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x17AD948", Offset = "0x17A9948", VA = "0x17AD948")]
		public static Sequence Append(this Sequence s, Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x17B6250", Offset = "0x17B2250", VA = "0x17B6250")]
		public static Sequence Prepend(this Sequence s, Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x17AD988", Offset = "0x17A9988", VA = "0x17AD988")]
		public static Sequence Join(this Sequence s, Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x17B628C", Offset = "0x17B228C", VA = "0x17B628C")]
		public static Sequence Insert(this Sequence s, float atPosition, Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x17A6514", Offset = "0x17A2514", VA = "0x17A6514")]
		public static Sequence AppendInterval(this Sequence s, float interval)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x17B62C8", Offset = "0x17B22C8", VA = "0x17B62C8")]
		public static Sequence PrependInterval(this Sequence s, float interval)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x17B62F0", Offset = "0x17B22F0", VA = "0x17B62F0")]
		public static Sequence AppendCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x17B631C", Offset = "0x17B231C", VA = "0x17B631C")]
		public static Sequence PrependCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x17B6348", Offset = "0x17B2348", VA = "0x17B6348")]
		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		public static T From<T>(this T t) where T : Tweener
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		public static T From<T>(this T t, bool isRelative) where T : Tweener
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		public static T SetDelay<T>(this T t, float delay) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		public static T SetRelative<T>(this T t) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		public static T SetRelative<T>(this T t, bool isRelative) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		public static T SetSpeedBased<T>(this T t) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x17B6370", Offset = "0x17B2370", VA = "0x17B6370")]
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x17B6388", Offset = "0x17B2388", VA = "0x17B6388")]
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x17B63A0", Offset = "0x17B23A0", VA = "0x17B63A0")]
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x17ACBE4", Offset = "0x17A8BE4", VA = "0x17ACBE4")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x17ACD94", Offset = "0x17A8D94", VA = "0x17ACD94")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x17B63BC", Offset = "0x17B23BC", VA = "0x17B63BC")]
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x17B63D4", Offset = "0x17B23D4", VA = "0x17B63D4")]
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x17B63F0", Offset = "0x17B23F0", VA = "0x17B63F0")]
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x17A3A98", Offset = "0x179FA98", VA = "0x17A3A98")]
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x17B640C", Offset = "0x17B240C", VA = "0x17B640C")]
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x17B6424", Offset = "0x17B2424", VA = "0x17B6424")]
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x17B03F0", Offset = "0x17AC3F0", VA = "0x17B03F0")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x17B6504", Offset = "0x17B2504", VA = "0x17B6504")]
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x17B6520", Offset = "0x17B2520", VA = "0x17B6520")]
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x17B653C", Offset = "0x17B253C", VA = "0x17B653C")]
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x17B655C", Offset = "0x17B255C", VA = "0x17B655C")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x17B68AC", Offset = "0x17B28AC", VA = "0x17B68AC")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x17B68F0", Offset = "0x17B28F0", VA = "0x17B68F0")]
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x17B6598", Offset = "0x17B2598", VA = "0x17B6598")]
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, [Optional] Vector3? forwardDirection, [Optional] Vector3? up)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public enum LogBehaviour
	{
		[Token(Token = "0x40000FC")]
		Default,
		[Token(Token = "0x40000FD")]
		Verbose,
		[Token(Token = "0x40000FE")]
		ErrorsOnly
	}
	[Token(Token = "0x200006E")]
	public abstract class Tween : ABSSequentiable
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float timeScale;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isBackwards;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object id;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object target;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal UpdateType updateType;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal bool isIndependentUpdate;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TweenCallback onPlay;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TweenCallback onPause;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TweenCallback onRewind;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TweenCallback onUpdate;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TweenCallback onStepComplete;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TweenCallback onComplete;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TweenCallback onKill;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TweenCallback<int> onWaypointChange;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal bool isFrom;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		internal bool isBlendable;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		internal bool isRecyclable;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		internal bool isSpeedBased;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal bool autoKill;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal float duration;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		internal int loops;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal LoopType loopType;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal float delay;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal bool isRelative;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		internal Ease easeType;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal EaseFunction customEase;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float easeOvershootOrAmplitude;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float easePeriod;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal Type typeofT1;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal Type typeofT2;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal Type typeofTPlugOptions;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal bool active;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		internal bool isSequenced;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal Sequence sequenceParent;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal int activeId;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		internal SpecialStartupMode specialStartupMode;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal bool creationLocked;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		internal bool startupDone;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		internal bool playedOnce;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		internal float position;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal float fullDuration;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		internal int completedLoops;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal bool isPlaying;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		internal bool isComplete;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		internal float elapsedDelay;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal bool delayComplete;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		internal int miscInt;

		[Token(Token = "0x17000002")]
		public float fullPosition
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x17B6934", Offset = "0x17B2934", VA = "0x17B6934")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x17B693C", Offset = "0x17B293C", VA = "0x17B693C")]
			set
			{
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17A8F6C", Offset = "0x17A4F6C", VA = "0x17A8F6C", Slot = "4")]
		internal virtual void Reset()
		{
		}

		[Token(Token = "0x6000266")]
		internal abstract bool Validate();

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x17B6944", Offset = "0x17B2944", VA = "0x17B6944", Slot = "6")]
		internal virtual float UpdateDelay(float elapsed)
		{
			return default(float);
		}

		[Token(Token = "0x6000268")]
		internal abstract bool Startup();

		[Token(Token = "0x6000269")]
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x17B694C", Offset = "0x17B294C", VA = "0x17B694C")]
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x17A99E0", Offset = "0x17A59E0", VA = "0x17A99E0")]
		internal static bool OnTweenCallback(TweenCallback callback)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, T param)
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x17A898C", Offset = "0x17A498C", VA = "0x17A898C")]
		protected Tween()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class Tweener : Tween
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal bool hasManuallySetStartValue;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		internal bool isFromAllowed;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x17B6C18", Offset = "0x17B2C18", VA = "0x17B6C18")]
		internal Tweener()
		{
		}

		[Token(Token = "0x600026F")]
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f);

		[Token(Token = "0x6000270")]
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false);

		[Token(Token = "0x6000271")]
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);

		[Token(Token = "0x6000272")]
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f);

		[Token(Token = "0x6000273")]
		internal abstract Tweener SetFrom(bool relative);

		[Token(Token = "0x6000274")]
		internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, [Optional] ABSTweenPlugin<T1, T2, TPlugOptions> plugin) where TPlugOptions : struct, IPlugOptions
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) where TPlugOptions : struct, IPlugOptions
		{
			return default(float);
		}

		[Token(Token = "0x6000276")]
		internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		internal static Tweener DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		internal static Tweener DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		internal static Tweener DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
		}
	}
	[Token(Token = "0x2000070")]
	public enum TweenType
	{
		[Token(Token = "0x4000131")]
		Tweener,
		[Token(Token = "0x4000132")]
		Sequence,
		[Token(Token = "0x4000133")]
		Callback
	}
	[Token(Token = "0x2000071")]
	public enum UpdateType
	{
		[Token(Token = "0x4000135")]
		Normal,
		[Token(Token = "0x4000136")]
		Late,
		[Token(Token = "0x4000137")]
		Fixed,
		[Token(Token = "0x4000138")]
		Manual
	}
}
namespace DG.Tweening.Plugins
{
	[Token(Token = "0x2000072")]
	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions>
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x17B6C38", Offset = "0x17B2C38", VA = "0x17B6C38", Slot = "4")]
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x17B6C3C", Offset = "0x17B2C3C", VA = "0x17B6C3C", Slot = "5")]
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x17B6D78", Offset = "0x17B2D78", VA = "0x17B6D78", Slot = "6")]
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value)
		{
			return default(Color2);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x17B6D84", Offset = "0x17B2D84", VA = "0x17B6D84", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x17B6DAC", Offset = "0x17B2DAC", VA = "0x17B6DAC", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x17B6DD4", Offset = "0x17B2DD4", VA = "0x17B6DD4", Slot = "9")]
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x17B6DE0", Offset = "0x17B2DE0", VA = "0x17B6DE0", Slot = "10")]
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x17B7024", Offset = "0x17B3024", VA = "0x17B7024")]
		public Color2Plugin()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions>
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x17B706C", Offset = "0x17B306C", VA = "0x17B706C", Slot = "4")]
		public override void Reset(TweenerCore<double, double, NoOptions> t)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x17B7070", Offset = "0x17B3070", VA = "0x17B7070", Slot = "5")]
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x17B70E8", Offset = "0x17B30E8", VA = "0x17B70E8", Slot = "6")]
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value)
		{
			return default(double);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x17B70EC", Offset = "0x17B30EC", VA = "0x17B70EC", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x17B7108", Offset = "0x17B3108", VA = "0x17B7108", Slot = "8")]
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x17B7124", Offset = "0x17B3124", VA = "0x17B7124", Slot = "9")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x17B713C", Offset = "0x17B313C", VA = "0x17B713C", Slot = "10")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x17B720C", Offset = "0x17B320C", VA = "0x17B720C")]
		public DoublePlugin()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions>
	{
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x17B7254", Offset = "0x17B3254", VA = "0x17B7254", Slot = "4")]
		public override void Reset(TweenerCore<long, long, NoOptions> t)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x17B7258", Offset = "0x17B3258", VA = "0x17B7258", Slot = "5")]
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x17B72BC", Offset = "0x17B32BC", VA = "0x17B72BC", Slot = "6")]
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value)
		{
			return default(long);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x17B72C4", Offset = "0x17B32C4", VA = "0x17B72C4", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x17B72E0", Offset = "0x17B32E0", VA = "0x17B72E0", Slot = "8")]
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x17B72FC", Offset = "0x17B32FC", VA = "0x17B72FC", Slot = "9")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x17B7314", Offset = "0x17B3314", VA = "0x17B7314", Slot = "10")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x17B74C4", Offset = "0x17B34C4", VA = "0x17B74C4")]
		public LongPlugin()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions>
	{
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x17B750C", Offset = "0x17B350C", VA = "0x17B750C", Slot = "4")]
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x17B7510", Offset = "0x17B3510", VA = "0x17B7510", Slot = "5")]
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x17B7574", Offset = "0x17B3574", VA = "0x17B7574", Slot = "6")]
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x17B757C", Offset = "0x17B357C", VA = "0x17B757C", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x17B7598", Offset = "0x17B3598", VA = "0x17B7598", Slot = "8")]
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x17B75B4", Offset = "0x17B35B4", VA = "0x17B75B4", Slot = "9")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x17B75D0", Offset = "0x17B35D0", VA = "0x17B75D0", Slot = "10")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x17B7748", Offset = "0x17B3748", VA = "0x17B7748")]
		public UlongPlugin()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions>
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x17B7790", Offset = "0x17B3790", VA = "0x17B7790", Slot = "4")]
		public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x17B77A8", Offset = "0x17B37A8", VA = "0x17B77A8", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x17B77AC", Offset = "0x17B37AC", VA = "0x17B77AC", Slot = "6")]
		public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x17B78AC", Offset = "0x17B38AC", VA = "0x17B78AC", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x17B795C", Offset = "0x17B395C", VA = "0x17B795C", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x17B7A5C", Offset = "0x17B3A5C", VA = "0x17B7A5C", Slot = "9")]
		public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x17B7B68", Offset = "0x17B3B68", VA = "0x17B7B68", Slot = "10")]
		public override void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x17B8354", Offset = "0x17B4354", VA = "0x17B8354")]
		public Vector3ArrayPlugin()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
	{
		[Token(Token = "0x4000139")]
		public const float MinLookAhead = 0.0001f;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x17B8BE8", Offset = "0x17B4BE8", VA = "0x17B8BE8", Slot = "4")]
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x17B8D18", Offset = "0x17B4D18", VA = "0x17B8D18", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x17B8D1C", Offset = "0x17B4D1C", VA = "0x17B8D1C")]
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get()
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x17B8D5C", Offset = "0x17B4D5C", VA = "0x17B8D5C", Slot = "6")]
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x17B8D70", Offset = "0x17B4D70", VA = "0x17B8D70", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x17B8DF8", Offset = "0x17B4DF8", VA = "0x17B8DF8", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x17B929C", Offset = "0x17B529C", VA = "0x17B929C", Slot = "9")]
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x17B92B4", Offset = "0x17B52B4", VA = "0x17B92B4", Slot = "10")]
		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x17BA4B4", Offset = "0x17B64B4", VA = "0x17BA4B4")]
		public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x17BAF80", Offset = "0x17B6F80", VA = "0x17BAF80")]
		public PathPlugin()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x17BAFC8", Offset = "0x17B6FC8", VA = "0x17BAFC8", Slot = "4")]
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x17BAFCC", Offset = "0x17B6FCC", VA = "0x17BAFCC", Slot = "5")]
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x17BB0A8", Offset = "0x17B70A8", VA = "0x17BB0A8", Slot = "6")]
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value)
		{
			return default(Color);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x17BB0AC", Offset = "0x17B70AC", VA = "0x17BB0AC", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x17BB0CC", Offset = "0x17B70CC", VA = "0x17BB0CC", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x17BB0EC", Offset = "0x17B70EC", VA = "0x17BB0EC", Slot = "9")]
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x17BB0F8", Offset = "0x17B70F8", VA = "0x17BB0F8", Slot = "10")]
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x17BB298", Offset = "0x17B7298", VA = "0x17BB298")]
		public ColorPlugin()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions>
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x17BB2E0", Offset = "0x17B72E0", VA = "0x17BB2E0", Slot = "4")]
		public override void Reset(TweenerCore<int, int, NoOptions> t)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x17BB2E4", Offset = "0x17B72E4", VA = "0x17BB2E4", Slot = "5")]
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x17BB34C", Offset = "0x17B734C", VA = "0x17BB34C", Slot = "6")]
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value)
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x17BB354", Offset = "0x17B7354", VA = "0x17BB354", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x17BB374", Offset = "0x17B7374", VA = "0x17BB374", Slot = "8")]
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x17BB394", Offset = "0x17B7394", VA = "0x17BB394", Slot = "9")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x17BB3AC", Offset = "0x17B73AC", VA = "0x17BB3AC", Slot = "10")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x17BB550", Offset = "0x17B7550", VA = "0x17BB550")]
		public IntPlugin()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x17BB598", Offset = "0x17B7598", VA = "0x17BB598", Slot = "4")]
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x17BB59C", Offset = "0x17B759C", VA = "0x17BB59C", Slot = "5")]
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x17BB9AC", Offset = "0x17B79AC", VA = "0x17BB9AC", Slot = "6")]
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x17BB9D8", Offset = "0x17B79D8", VA = "0x17BB9D8", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x17BBA0C", Offset = "0x17B7A0C", VA = "0x17BBA0C", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x17BBB70", Offset = "0x17B7B70", VA = "0x17BBB70", Slot = "9")]
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x17BBBF0", Offset = "0x17B7BF0", VA = "0x17BBBF0", Slot = "10")]
		public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x17BBFE8", Offset = "0x17B7FE8", VA = "0x17BBFE8")]
		public QuaternionPlugin()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RectOffset _r;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x17BC030", Offset = "0x17B8030", VA = "0x17BC030", Slot = "4")]
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x17BC048", Offset = "0x17B8048", VA = "0x17BC048", Slot = "5")]
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x17BC194", Offset = "0x17B8194", VA = "0x17BC194", Slot = "6")]
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x17BC250", Offset = "0x17B8250", VA = "0x17BC250", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x17BC360", Offset = "0x17B8360", VA = "0x17BC360", Slot = "8")]
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x17BC4B0", Offset = "0x17B84B0", VA = "0x17BC4B0", Slot = "9")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x17BC56C", Offset = "0x17B856C", VA = "0x17BC56C", Slot = "10")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x17BCC84", Offset = "0x17B8C84", VA = "0x17BCC84")]
		public RectOffsetPlugin()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x17BCD3C", Offset = "0x17B8D3C", VA = "0x17BCD3C", Slot = "4")]
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x17BCD40", Offset = "0x17B8D40", VA = "0x17BCD40", Slot = "5")]
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x17BD034", Offset = "0x17B9034", VA = "0x17BD034", Slot = "6")]
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value)
		{
			return default(Rect);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x17BD038", Offset = "0x17B9038", VA = "0x17BD038", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x17BD058", Offset = "0x17B9058", VA = "0x17BD058", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x17BD078", Offset = "0x17B9078", VA = "0x17BD078", Slot = "9")]
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x17BD0F4", Offset = "0x17B90F4", VA = "0x17BD0F4", Slot = "10")]
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x17BD49C", Offset = "0x17B949C", VA = "0x17BD49C")]
		public RectPlugin()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions>
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x17BD4E4", Offset = "0x17B94E4", VA = "0x17BD4E4", Slot = "4")]
		public override void Reset(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x17BD4E8", Offset = "0x17B94E8", VA = "0x17BD4E8", Slot = "5")]
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x17BD550", Offset = "0x17B9550", VA = "0x17BD550", Slot = "6")]
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x17BD558", Offset = "0x17B9558", VA = "0x17BD558", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x17BD578", Offset = "0x17B9578", VA = "0x17BD578", Slot = "8")]
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x17BD5A8", Offset = "0x17B95A8", VA = "0x17BD5A8", Slot = "9")]
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x17BD5C0", Offset = "0x17B95C0", VA = "0x17BD5C0", Slot = "10")]
		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x17BD78C", Offset = "0x17B978C", VA = "0x17BD78C")]
		public UintPlugin()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions>
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x17BD7D4", Offset = "0x17B97D4", VA = "0x17BD7D4", Slot = "4")]
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x17BD7D8", Offset = "0x17B97D8", VA = "0x17BD7D8", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x17BD9A8", Offset = "0x17B99A8", VA = "0x17BD9A8", Slot = "6")]
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x17BD9AC", Offset = "0x17B99AC", VA = "0x17BD9AC", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x17BD9CC", Offset = "0x17B99CC", VA = "0x17BD9CC", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x17BDA30", Offset = "0x17B9A30", VA = "0x17BDA30", Slot = "9")]
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x17BDAA4", Offset = "0x17B9AA4", VA = "0x17BDAA4", Slot = "10")]
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x17BDE64", Offset = "0x17B9E64", VA = "0x17BDE64")]
		public Vector2Plugin()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions>
	{
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x17BDEAC", Offset = "0x17B9EAC", VA = "0x17BDEAC", Slot = "4")]
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x17BDEB0", Offset = "0x17B9EB0", VA = "0x17BDEB0", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x17BE1D0", Offset = "0x17BA1D0", VA = "0x17BE1D0", Slot = "6")]
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x17BE1D4", Offset = "0x17BA1D4", VA = "0x17BE1D4", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x17BE1F4", Offset = "0x17BA1F4", VA = "0x17BE1F4", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x17BE2A0", Offset = "0x17BA2A0", VA = "0x17BE2A0", Slot = "9")]
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17BE334", Offset = "0x17BA334", VA = "0x17BE334", Slot = "10")]
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17BE9D4", Offset = "0x17BA9D4", VA = "0x17BE9D4")]
		public Vector4Plugin()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions>
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly StringBuilder _Buffer;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<char> _OpenedTags;

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x17BEA1C", Offset = "0x17BAA1C", VA = "0x17BEA1C", Slot = "5")]
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x17BEA74", Offset = "0x17BAA74", VA = "0x17BEA74", Slot = "4")]
		public override void Reset(TweenerCore<string, string, StringOptions> t)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x17BEA8C", Offset = "0x17BAA8C", VA = "0x17BEA8C", Slot = "6")]
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x17BEA94", Offset = "0x17BAA94", VA = "0x17BEA94", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x17BEA98", Offset = "0x17BAA98", VA = "0x17BEA98", Slot = "8")]
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x17BEB68", Offset = "0x17BAB68", VA = "0x17BEB68", Slot = "9")]
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x17BEBA4", Offset = "0x17BABA4", VA = "0x17BEBA4", Slot = "10")]
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x17BF034", Offset = "0x17BB034", VA = "0x17BF034")]
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x17BF734", Offset = "0x17BB734", VA = "0x17BF734")]
		private char[] ScrambledCharsToUse(StringOptions options)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x17BF96C", Offset = "0x17BB96C", VA = "0x17BF96C")]
		public StringPlugin()
		{
		}
	}
	[Token(Token = "0x2000081")]
	internal static class StringPluginExtensions
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly char[] ScrambledCharsAll;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly char[] ScrambledCharsUppercase;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly char[] ScrambledCharsLowercase;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly char[] ScrambledCharsNumerals;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int _lastRndSeed;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x17BFA74", Offset = "0x17BBA74", VA = "0x17BFA74")]
		static StringPluginExtensions()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x17BFBF8", Offset = "0x17BBBF8", VA = "0x17BFBF8")]
		internal static void ScrambleChars(this char[] chars)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x17BF83C", Offset = "0x17BB83C", VA = "0x17BF83C")]
		internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions>
	{
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x17BFC94", Offset = "0x17BBC94", VA = "0x17BFC94", Slot = "4")]
		public override void Reset(TweenerCore<float, float, FloatOptions> t)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x17BFC98", Offset = "0x17BBC98", VA = "0x17BFC98", Slot = "5")]
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x17BFDC8", Offset = "0x17BBDC8", VA = "0x17BFDC8", Slot = "6")]
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x17BFDCC", Offset = "0x17BBDCC", VA = "0x17BFDCC", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x17BFDEC", Offset = "0x17BBDEC", VA = "0x17BFDEC", Slot = "8")]
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x17BFE0C", Offset = "0x17BBE0C", VA = "0x17BFE0C", Slot = "9")]
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x17BFE20", Offset = "0x17BBE20", VA = "0x17BFE20", Slot = "10")]
		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x17BFFCC", Offset = "0x17BBFCC", VA = "0x17BFFCC")]
		public FloatPlugin()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions>
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x17C0014", Offset = "0x17BC014", VA = "0x17C0014", Slot = "4")]
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x17C0018", Offset = "0x17BC018", VA = "0x17C0018", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x17C0290", Offset = "0x17BC290", VA = "0x17C0290", Slot = "6")]
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x17C0294", Offset = "0x17BC294", VA = "0x17C0294", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x17C02C8", Offset = "0x17BC2C8", VA = "0x17C02C8", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x17C0360", Offset = "0x17BC360", VA = "0x17C0360", Slot = "9")]
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x17C03E0", Offset = "0x17BC3E0", VA = "0x17C03E0", Slot = "10")]
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x17C0904", Offset = "0x17BC904", VA = "0x17C0904")]
		public Vector3Plugin()
		{
		}
	}
}
namespace DG.Tweening.Plugins.Options
{
	[Token(Token = "0x2000084")]
	public interface IPlugOptions
	{
		[Token(Token = "0x600030D")]
		void Reset();
	}
	[Token(Token = "0x2000085")]
	public enum OrientType
	{
		[Token(Token = "0x4000143")]
		None,
		[Token(Token = "0x4000144")]
		ToPath,
		[Token(Token = "0x4000145")]
		LookAtTransform,
		[Token(Token = "0x4000146")]
		LookAtPosition
	}
	[Token(Token = "0x2000086")]
	public struct PathOptions : IPlugOptions
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PathMode mode;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public OrientType orientType;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AxisConstraint lockPositionAxis;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AxisConstraint lockRotationAxis;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isClosedPath;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 lookAtPosition;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform lookAtTransform;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lookAhead;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool hasCustomForwardDirection;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion forward;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useLocalPosition;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform parent;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isRigidbody;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal Quaternion startupRot;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		internal float startupZRot;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x17C094C", Offset = "0x17BC94C", VA = "0x17C094C", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public struct QuaternionOptions : IPlugOptions
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal RotateMode rotateMode;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal AxisConstraint axisConstraint;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector3 up;

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x17C0A04", Offset = "0x17BCA04", VA = "0x17C0A04", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public struct UintOptions : IPlugOptions
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool isNegativeChangeValue;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x17C0A60", Offset = "0x17BCA60", VA = "0x17C0A60", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public struct Vector3ArrayOptions : IPlugOptions
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AxisConstraint axisConstraint;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool snapping;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float[] durations;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x17C0A68", Offset = "0x17BCA68", VA = "0x17C0A68", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public struct NoOptions : IPlugOptions
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x17C0A78", Offset = "0x17BCA78", VA = "0x17C0A78", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public struct ColorOptions : IPlugOptions
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool alphaOnly;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x17C0A7C", Offset = "0x17BCA7C", VA = "0x17C0A7C", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public struct FloatOptions : IPlugOptions
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool snapping;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x17C0A84", Offset = "0x17BCA84", VA = "0x17C0A84", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public struct RectOptions : IPlugOptions
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool snapping;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x17C0A8C", Offset = "0x17BCA8C", VA = "0x17C0A8C", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public struct StringOptions : IPlugOptions
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool richTextEnabled;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ScrambleMode scrambleMode;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] scrambledChars;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int startValueStrippedLength;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int changeValueStrippedLength;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x17C0A94", Offset = "0x17BCA94", VA = "0x17C0A94", Slot = "4")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public struct VectorOptions : IPlugOptions
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AxisConstraint axisConstraint;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool snapping;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x17C0AA8", Offset = "0x17BCAA8", VA = "0x17C0AA8", Slot = "4")]
		public void Reset()
		{
		}
	}
}
namespace DG.Tweening.Plugins.Core
{
	[Token(Token = "0x2000090")]
	public interface ITPlugin<T1, out T2, out TPlugOptions, TPlugin>
	{
	}
	[Token(Token = "0x2000091")]
	internal static class SpecialPluginsUtils
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x17C0AB4", Offset = "0x17BCAB4", VA = "0x17C0AB4")]
		internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x17C0BD8", Offset = "0x17BCBD8", VA = "0x17C0BD8")]
		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x17C0CE4", Offset = "0x17BCCE4", VA = "0x17C0CE4")]
		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x17C0D10", Offset = "0x17BCD10", VA = "0x17C0D10")]
		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000092")]
	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions>
	{
		[Token(Token = "0x600031C")]
		DOGetter<T1> Getter();

		[Token(Token = "0x600031D")]
		DOSetter<T1> Setter();

		[Token(Token = "0x600031E")]
		T2 EndValue();

		[Token(Token = "0x600031F")]
		TPlugOptions GetOptions();
	}
	[Token(Token = "0x2000093")]
	public interface ITweenPlugin
	{
	}
	[Token(Token = "0x2000094")]
	public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin where TPlugOptions : struct, IPlugOptions
	{
		[Token(Token = "0x6000320")]
		public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t);

		[Token(Token = "0x6000321")]
		public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);

		[Token(Token = "0x6000322")]
		public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value);

		[Token(Token = "0x6000323")]
		public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t);

		[Token(Token = "0x6000324")]
		public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t);

		[Token(Token = "0x6000325")]
		public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);

		[Token(Token = "0x6000326")]
		public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);

		[Token(Token = "0x6000327")]
		protected ABSTweenPlugin()
		{
		}
	}
	[Token(Token = "0x2000095")]
	internal static class PluginsManager
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ITweenPlugin _floatPlugin;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ITweenPlugin _doublePlugin;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ITweenPlugin _intPlugin;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static ITweenPlugin _uintPlugin;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static ITweenPlugin _longPlugin;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static ITweenPlugin _ulongPlugin;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static ITweenPlugin _vector2Plugin;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static ITweenPlugin _vector3Plugin;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static ITweenPlugin _vector4Plugin;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static ITweenPlugin _quaternionPlugin;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static ITweenPlugin _colorPlugin;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static ITweenPlugin _rectPlugin;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static ITweenPlugin _rectOffsetPlugin;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static ITweenPlugin _stringPlugin;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static ITweenPlugin _vector3ArrayPlugin;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static ITweenPlugin _color2Plugin;

		[Token(Token = "0x4000177")]
		private const int _MaxCustomPlugins = 20;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static Dictionary<Type, ITweenPlugin> _customPlugins;

		[Token(Token = "0x6000328")]
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() where TPlugin : ITweenPlugin, new() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x17C0EC0", Offset = "0x17BCEC0", VA = "0x17C0EC0")]
		internal static void PurgeAll()
		{
		}
	}
}
namespace DG.Tweening.Plugins.Core.PathCore
{
	[Serializable]
	[Token(Token = "0x2000096")]
	public struct ControlPoint
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 a;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 b;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x17C0F50", Offset = "0x17BCF50", VA = "0x17C0F50")]
		public ControlPoint(Vector3 a, Vector3 b)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x17C0F60", Offset = "0x17BCF60", VA = "0x17C0F60")]
		public static ControlPoint operator +(ControlPoint cp, Vector3 v)
		{
			return default(ControlPoint);
		}
	}
	[Token(Token = "0x2000097")]
	internal abstract class ABSPathDecoder
	{
		[Token(Token = "0x600032D")]
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);

		[Token(Token = "0x600032E")]
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x17C0F90", Offset = "0x17BCF90", VA = "0x17C0F90")]
		protected ABSPathDecoder()
		{
		}
	}
	[Token(Token = "0x2000098")]
	internal class CatmullRomDecoder : ABSPathDecoder
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17C0F98", Offset = "0x17BCF98", VA = "0x17C0F98", Slot = "4")]
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17C1760", Offset = "0x17BD760", VA = "0x17C1760", Slot = "5")]
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x17C11E0", Offset = "0x17BD1E0", VA = "0x17C11E0")]
		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x17C13CC", Offset = "0x17BD3CC", VA = "0x17C13CC")]
		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x17C19C8", Offset = "0x17BD9C8", VA = "0x17C19C8")]
		public CatmullRomDecoder()
		{
		}
	}
	[Token(Token = "0x2000099")]
	internal class LinearDecoder : ABSPathDecoder
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x17C19D0", Offset = "0x17BD9D0", VA = "0x17C19D0", Slot = "4")]
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x17C1C14", Offset = "0x17BDC14", VA = "0x17C1C14", Slot = "5")]
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17C19FC", Offset = "0x17BD9FC", VA = "0x17C19FC")]
		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x17C1DBC", Offset = "0x17BDDBC", VA = "0x17C1DBC")]
		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x17C1DC0", Offset = "0x17BDDC0", VA = "0x17C1DC0")]
		public LinearDecoder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class Path
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CatmullRomDecoder _catmullRomDecoder;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static LinearDecoder _linearDecoder;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] wpLengths;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal PathType type;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal int subdivisionsXSegment;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal int subdivisions;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal Vector3[] wps;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal ControlPoint[] controlPoints;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal float length;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		internal bool isFinalized;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal float[] timesTable;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal float[] lengthsTable;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int linearWPIndex;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Path _incrementalClone;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _incrementalIndex;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ABSPathDecoder _decoder;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _changed;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal Vector3[] nonLinearDrawWps;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal Vector3 targetPosition;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal Vector3? lookAtPosition;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal Color gizmoColor;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x17C1DC8", Offset = "0x17BDDC8", VA = "0x17C1DC8")]
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, [Optional] Color? gizmoColor)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x17C2150", Offset = "0x17BE150", VA = "0x17C2150")]
		internal Path()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x17B91F0", Offset = "0x17B51F0", VA = "0x17B91F0")]
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x17BA47C", Offset = "0x17B647C", VA = "0x17BA47C")]
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x17BA334", Offset = "0x17B6334", VA = "0x17BA334")]
		internal float ConvertToConstantPathPerc(float perc)
		{
			return default(float);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17BAD88", Offset = "0x17B6D88", VA = "0x17BAD88")]
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward)
		{
			return default(int);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x17C216C", Offset = "0x17BE16C", VA = "0x17C216C")]
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x17C2250", Offset = "0x17BE250", VA = "0x17C2250")]
		internal static void RefreshNonLinearDrawWps(Path p)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17B8C14", Offset = "0x17B4C14", VA = "0x17B8C14")]
		internal void Destroy()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x17B94C4", Offset = "0x17B54C4", VA = "0x17B94C4")]
		internal Path CloneIncremental(int loopIncrement)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x17C1F9C", Offset = "0x17BDF9C", VA = "0x17C1F9C")]
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x17C2068", Offset = "0x17BE068", VA = "0x17C2068")]
		internal void AssignDecoder(PathType pathType)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x17C2348", Offset = "0x17BE348", VA = "0x17C2348")]
		internal void Draw()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x17C234C", Offset = "0x17BE34C", VA = "0x17C234C")]
		private static void Draw(Path p)
		{
		}
	}
}
namespace DG.Tweening.CustomPlugins
{
	[Token(Token = "0x200009B")]
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PureQuaternionPlugin _plug;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x17C264C", Offset = "0x17BE64C", VA = "0x17C264C")]
		public static PureQuaternionPlugin Plug()
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x17C2708", Offset = "0x17BE708", VA = "0x17C2708", Slot = "4")]
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x17C270C", Offset = "0x17BE70C", VA = "0x17C270C", Slot = "5")]
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x17C2810", Offset = "0x17BE810", VA = "0x17C2810", Slot = "6")]
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x17C2814", Offset = "0x17BE814", VA = "0x17C2814", Slot = "7")]
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x17C28B4", Offset = "0x17BE8B4", VA = "0x17C28B4", Slot = "8")]
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x17C28D4", Offset = "0x17BE8D4", VA = "0x17C28D4", Slot = "9")]
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue)
		{
			return default(float);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x17C2988", Offset = "0x17BE988", VA = "0x17C2988", Slot = "10")]
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17C26C0", Offset = "0x17BE6C0", VA = "0x17C26C0")]
		public PureQuaternionPlugin()
		{
		}
	}
}
namespace DG.Tweening.Core
{
	[Token(Token = "0x200009C")]
	public abstract class ABSSequentiable
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal TweenType tweenType;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal float sequencedPosition;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float sequencedEndPosition;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal TweenCallback onStart;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x17C2A1C", Offset = "0x17BEA1C", VA = "0x17C2A1C")]
		protected ABSSequentiable()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public delegate T DOGetter<out T>();
	[Token(Token = "0x200009E")]
	public delegate void DOSetter<in T>(T pNewValue);
	[Token(Token = "0x200009F")]
	public static class Debugger
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int logPriority;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x17C2A24", Offset = "0x17BEA24", VA = "0x17C2A24")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x17C2AB0", Offset = "0x17BEAB0", VA = "0x17C2AB0")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x17C2B3C", Offset = "0x17BEB3C", VA = "0x17C2B3C")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x17C2BC8", Offset = "0x17BEBC8", VA = "0x17C2BC8")]
		public static void LogReport(object message)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x17C2C6C", Offset = "0x17BEC6C", VA = "0x17C2C6C")]
		public static void LogInvalidTween(Tween t)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x17C2CAC", Offset = "0x17BECAC", VA = "0x17C2CAC")]
		public static void LogNestedTween(Tween t)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17C2CEC", Offset = "0x17BECEC", VA = "0x17C2CEC")]
		public static void LogNullTween(Tween t)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17C2D2C", Offset = "0x17BED2C", VA = "0x17C2D2C")]
		public static void LogNonPathTween(Tween t)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x17C2D6C", Offset = "0x17BED6C", VA = "0x17C2D6C")]
		public static void LogMissingMaterialProperty(string propertyName)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x17C2DBC", Offset = "0x17BEDBC", VA = "0x17C2DBC")]
		public static void LogRemoveActiveTweenError(string propertyName)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x17C2E0C", Offset = "0x17BEE0C", VA = "0x17C2E0C")]
		public static void SetLogPriority(LogBehaviour logBehaviour)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("")]
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int inspectorUpdater;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _unscaledTime;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _unscaledDeltaTime;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _duplicateToDestroy;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x17C2E6C", Offset = "0x17BEE6C", VA = "0x17C2E6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x17C2E8C", Offset = "0x17BEE8C", VA = "0x17C2E8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x17C2F64", Offset = "0x17BEF64", VA = "0x17C2F64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x17C35EC", Offset = "0x17BF5EC", VA = "0x17C35EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x17C36FC", Offset = "0x17BF6FC", VA = "0x17C36FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x17C3860", Offset = "0x17BF860", VA = "0x17C3860")]
		internal void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x17C3938", Offset = "0x17BF938", VA = "0x17C3938")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x17C3A58", Offset = "0x17BFA58", VA = "0x17C3A58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x17C3CC0", Offset = "0x17BFCC0", VA = "0x17C3CC0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x17C3D1C", Offset = "0x17BFD1C", VA = "0x17C3D1C", Slot = "4")]
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x17C3E6C", Offset = "0x17BFE6C", VA = "0x17C3E6C")]
		internal IEnumerator WaitForCompletion(Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x17C3EF4", Offset = "0x17BFEF4", VA = "0x17C3EF4")]
		internal IEnumerator WaitForRewind(Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x17C3F7C", Offset = "0x17BFF7C", VA = "0x17C3F7C")]
		internal IEnumerator WaitForKill(Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x17C4004", Offset = "0x17C0004", VA = "0x17C4004")]
		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x17C409C", Offset = "0x17C009C", VA = "0x17C409C")]
		internal IEnumerator WaitForPosition(Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x17C4134", Offset = "0x17C0134", VA = "0x17C4134")]
		internal IEnumerator WaitForStart(Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17C41BC", Offset = "0x17C01BC", VA = "0x17C41BC")]
		internal static void Create()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x17C42F8", Offset = "0x17C02F8", VA = "0x17C42F8")]
		internal static void DestroyInstance()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x17C43F8", Offset = "0x17C03F8", VA = "0x17C43F8")]
		public DOTweenComponent()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class DOTweenSettings : ScriptableObject
	{
		[Token(Token = "0x20000A8")]
		public enum SettingsLocation
		{
			[Token(Token = "0x40001C1")]
			AssetsDirectory,
			[Token(Token = "0x40001C2")]
			DOTweenDirectory,
			[Token(Token = "0x40001C3")]
			DemigiantDirectory
		}

		[Token(Token = "0x40001AE")]
		public const string AssetName = "DOTweenSettings";

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useSafeMode;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float timeScale;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useSmoothDeltaTime;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxSmoothUnscaledTime;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showUnityEditorReport;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LogBehaviour logBehaviour;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool drawGizmos;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool defaultRecyclable;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public AutoPlay defaultAutoPlay;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateType defaultUpdateType;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool defaultTimeScaleIndependent;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Ease defaultEaseType;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float defaultEaseOvershootOrAmplitude;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float defaultEasePeriod;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool defaultAutoKill;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LoopType defaultLoopType;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SettingsLocation storeSettingsLocation;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x17C47DC", Offset = "0x17C07DC", VA = "0x17C47DC")]
		public DOTweenSettings()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public static class Extensions
	{
		[Token(Token = "0x600039D")]
		internal static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode) where T : Tween
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		internal static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		internal static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}
	}
	[Token(Token = "0x20000AA")]
	internal class SequenceCallback : ABSSequentiable
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x17C4828", Offset = "0x17C0828", VA = "0x17C4828")]
		public SequenceCallback(float sequencedPosition, TweenCallback callback)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	internal static class TweenManager
	{
		[Token(Token = "0x20000AC")]
		internal enum CapacityIncreaseMode
		{
			[Token(Token = "0x40001E6")]
			TweenersAndSequences,
			[Token(Token = "0x40001E7")]
			TweenersOnly,
			[Token(Token = "0x40001E8")]
			SequencesOnly
		}

		[Token(Token = "0x40001C4")]
		private const int _DefaultMaxTweeners = 200;

		[Token(Token = "0x40001C5")]
		private const int _DefaultMaxSequences = 50;

		[Token(Token = "0x40001C6")]
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static int maxActive;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal static int maxTweeners;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static int maxSequences;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal static bool hasActiveTweens;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		internal static bool hasActiveDefaultTweens;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		internal static bool hasActiveLateTweens;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		internal static bool hasActiveFixedTweens;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static bool hasActiveManualTweens;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal static int totActiveTweens;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static int totActiveDefaultTweens;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal static int totActiveLateTweens;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static int totActiveFixedTweens;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal static int totActiveManualTweens;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static int totActiveTweeners;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal static int totActiveSequences;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static int totPooledTweeners;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal static int totPooledSequences;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static int totTweeners;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal static int totSequences;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static bool isUpdateLoop;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal static Tween[] _activeTweens;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Tween[] _pooledTweeners;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly Stack<Tween> _PooledSequences;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly List<Tween> _KillList;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static int _maxActiveLookupId;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static bool _requiresActiveReorganization;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static int _reorganizeFromId;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static int _minPooledTweenerId;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static int _maxPooledTweenerId;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private static bool _despawnAllCalledFromUpdateLoopCallback;

		[Token(Token = "0x60003A1")]
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x17C4868", Offset = "0x17C0868", VA = "0x17C4868")]
		internal static Sequence GetSequence()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x17C4FCC", Offset = "0x17C0FCC", VA = "0x17C4FCC")]
		internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x17C51CC", Offset = "0x17C11CC", VA = "0x17C51CC")]
		internal static void AddActiveTweenToSequence(Tween t)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x17C563C", Offset = "0x17C163C", VA = "0x17C563C")]
		internal static int DespawnAll()
		{
			return default(int);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x17C57C4", Offset = "0x17C17C4", VA = "0x17C57C4")]
		internal static void Despawn(Tween t, bool modifyActiveLists = true)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17C5CD0", Offset = "0x17C1CD0", VA = "0x17C5CD0")]
		internal static void PurgeAll()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x17C5E10", Offset = "0x17C1E10", VA = "0x17C5E10")]
		internal static void PurgePools()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x17C5ED8", Offset = "0x17C1ED8", VA = "0x17C5ED8")]
		internal static void ResetCapacities()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x17C3D8C", Offset = "0x17BFD8C", VA = "0x17C3D8C")]
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x17C5F2C", Offset = "0x17C1F2C", VA = "0x17C5F2C")]
		internal static int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x17C324C", Offset = "0x17BF24C", VA = "0x17C324C")]
		internal static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x17C6454", Offset = "0x17C2454", VA = "0x17C6454")]
		internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, [Optional] object optionalObj, [Optional] object[] optionalArray)
		{
			return default(int);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x17C6A58", Offset = "0x17C2A58", VA = "0x17C6A58")]
		internal static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = UpdateMode.Goto)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x17C6B30", Offset = "0x17C2B30", VA = "0x17C6B30")]
		internal static bool Flip(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x17C7114", Offset = "0x17C3114", VA = "0x17C7114")]
		internal static void ForceInit(Tween t, bool isSequenced = false)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x17C6B54", Offset = "0x17C2B54", VA = "0x17C6B54")]
		internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x17C6C88", Offset = "0x17C2C88", VA = "0x17C6C88")]
		internal static bool Pause(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x17C6CC0", Offset = "0x17C2CC0", VA = "0x17C6CC0")]
		internal static bool Play(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x17C6D40", Offset = "0x17C2D40", VA = "0x17C6D40")]
		internal static bool PlayBackwards(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x17C6DD4", Offset = "0x17C2DD4", VA = "0x17C6DD4")]
		internal static bool PlayForward(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x17C6E64", Offset = "0x17C2E64", VA = "0x17C6E64")]
		internal static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x17C6F20", Offset = "0x17C2F20", VA = "0x17C6F20")]
		internal static bool Rewind(Tween t, bool includeDelay = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x17C6FEC", Offset = "0x17C2FEC", VA = "0x17C6FEC")]
		internal static bool SmoothRewind(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x17C7098", Offset = "0x17C3098", VA = "0x17C7098")]
		internal static bool TogglePause(Tween t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x17C71C4", Offset = "0x17C31C4", VA = "0x17C71C4")]
		internal static int TotalPooledTweens()
		{
			return default(int);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x17C7220", Offset = "0x17C3220", VA = "0x17C7220")]
		internal static int TotalPlayingTweens()
		{
			return default(int);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x17C732C", Offset = "0x17C332C", VA = "0x17C732C")]
		internal static List<Tween> GetActiveTweens(bool playing)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x17C7520", Offset = "0x17C3520", VA = "0x17C7520")]
		internal static List<Tween> GetTweensById(object id, bool playingOnly)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x17C7734", Offset = "0x17C3734", VA = "0x17C7734")]
		internal static List<Tween> GetTweensByTarget(object target, bool playingOnly)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x17C62C4", Offset = "0x17C22C4", VA = "0x17C62C4")]
		private static void MarkForKilling(Tween t)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x17C4B60", Offset = "0x17C0B60", VA = "0x17C4B60")]
		private static void AddActiveTween(Tween t)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x17C60AC", Offset = "0x17C20AC", VA = "0x17C60AC")]
		private static void ReorganizeActiveTweens()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x17C6398", Offset = "0x17C2398", VA = "0x17C6398")]
		private static void DespawnActiveTweens(List<Tween> tweens)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x17C5220", Offset = "0x17C1220", VA = "0x17C5220")]
		private static void RemoveActiveTween(Tween t)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x17C5C9C", Offset = "0x17C1C9C", VA = "0x17C5C9C")]
		private static void ClearTweenArray(Tween[] tweens)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x17C4DC8", Offset = "0x17C0DC8", VA = "0x17C4DC8")]
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	internal static class Utils
	{
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x17C7A98", Offset = "0x17C3A98", VA = "0x17C7A98")]
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x17BAE30", Offset = "0x17B6E30", VA = "0x17BAE30")]
		internal static float Angle2D(Vector3 from, Vector3 to)
		{
			return default(float);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x17B90F0", Offset = "0x17B50F0", VA = "0x17B90F0")]
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AE")]
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct, IPlugOptions
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 startValue;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 endValue;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 changeValue;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TPlugOptions plugOptions;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DOGetter<T1> getter;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DOSetter<T1> setter;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;

		[Token(Token = "0x40001F0")]
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

		[Token(Token = "0x60003CA")]
		internal TweenerCore()
		{
		}

		[Token(Token = "0x60003CB")]
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		internal override Tweener SetFrom(bool relative)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		internal sealed override void Reset()
		{
		}

		[Token(Token = "0x60003D1")]
		internal override bool Validate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		internal override float UpdateDelay(float elapsed)
		{
			return default(float);
		}

		[Token(Token = "0x60003D3")]
		internal override bool Startup()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			return default(bool);
		}
	}
}
namespace DG.Tweening.Core.Enums
{
	[Token(Token = "0x20000AF")]
	internal enum FilterType
	{
		[Token(Token = "0x40001F2")]
		All,
		[Token(Token = "0x40001F3")]
		TargetOrId,
		[Token(Token = "0x40001F4")]
		TargetAndId,
		[Token(Token = "0x40001F5")]
		AllExceptTargetsOrIds,
		[Token(Token = "0x40001F6")]
		DOGetter
	}
	[Token(Token = "0x20000B0")]
	internal enum OperationType
	{
		[Token(Token = "0x40001F8")]
		Complete,
		[Token(Token = "0x40001F9")]
		Despawn,
		[Token(Token = "0x40001FA")]
		Flip,
		[Token(Token = "0x40001FB")]
		Goto,
		[Token(Token = "0x40001FC")]
		Pause,
		[Token(Token = "0x40001FD")]
		Play,
		[Token(Token = "0x40001FE")]
		PlayForward,
		[Token(Token = "0x40001FF")]
		PlayBackwards,
		[Token(Token = "0x4000200")]
		Rewind,
		[Token(Token = "0x4000201")]
		SmoothRewind,
		[Token(Token = "0x4000202")]
		Restart,
		[Token(Token = "0x4000203")]
		TogglePause,
		[Token(Token = "0x4000204")]
		IsTweening
	}
	[Token(Token = "0x20000B1")]
	internal enum SpecialStartupMode
	{
		[Token(Token = "0x4000206")]
		None,
		[Token(Token = "0x4000207")]
		SetLookAt,
		[Token(Token = "0x4000208")]
		SetShake,
		[Token(Token = "0x4000209")]
		SetPunch,
		[Token(Token = "0x400020A")]
		SetCameraShakePosition
	}
	[Token(Token = "0x20000B2")]
	public enum UpdateNotice
	{
		[Token(Token = "0x400020C")]
		None,
		[Token(Token = "0x400020D")]
		RewindStep
	}
	[Token(Token = "0x20000B3")]
	internal enum UpdateMode
	{
		[Token(Token = "0x400020F")]
		Update,
		[Token(Token = "0x4000210")]
		Goto,
		[Token(Token = "0x4000211")]
		IgnoreOnUpdate
	}
}
namespace DG.Tweening.Core.Easing
{
	[Token(Token = "0x20000B4")]
	public static class Bounce
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x17C7AE0", Offset = "0x17C3AE0", VA = "0x17C7AE0")]
		public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			return default(float);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x17C7AFC", Offset = "0x17C3AFC", VA = "0x17C7AFC")]
		public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			return default(float);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x17C7BB8", Offset = "0x17C3BB8", VA = "0x17C7BB8")]
		public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B5")]
	public static class EaseManager
	{
		[Token(Token = "0x4000212")]
		private const float _PiOver2 = (float)Math.PI / 2f;

		[Token(Token = "0x4000213")]
		private const float _TwoPi = (float)Math.PI * 2f;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x17C7C08", Offset = "0x17C3C08", VA = "0x17C7C08")]
		public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x17B9904", Offset = "0x17B5904", VA = "0x17B9904")]
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x17C7C24", Offset = "0x17C3C24", VA = "0x17C7C24")]
		public static EaseFunction ToEaseFunction(Ease ease)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x17C8C68", Offset = "0x17C4C68", VA = "0x17C8C68")]
		internal static bool IsFlashEase(Ease ease)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B7")]
	public class EaseCurve
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly AnimationCurve _animCurve;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x17C9D14", Offset = "0x17C5D14", VA = "0x17C9D14")]
		public EaseCurve(AnimationCurve animCurve)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x17C9D3C", Offset = "0x17C5D3C", VA = "0x17C9D3C")]
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B8")]
	public static class Flash
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x17C9988", Offset = "0x17C5988", VA = "0x17C9988")]
		public static float Ease(float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x17C9A54", Offset = "0x17C5A54", VA = "0x17C9A54")]
		public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x17C9B24", Offset = "0x17C5B24", VA = "0x17C9B24")]
		public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x17C9BFC", Offset = "0x17C5BFC", VA = "0x17C9BFC")]
		public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period)
		{
			return default(float);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x17C9DCC", Offset = "0x17C5DCC", VA = "0x17C9DCC")]
		private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res)
		{
			return default(float);
		}
	}
}
