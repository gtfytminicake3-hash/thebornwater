using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.ProBuilder.Poly2Tri;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
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
	[Address(RVA = "0x2B77C88", Offset = "0x2B73C88", VA = "0x2B77C88")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2B77D44", Offset = "0x2B73D44", VA = "0x2B77D44")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000004")]
	public sealed class ActionResult
	{
		[Token(Token = "0x2000005")]
		public enum Status
		{
			[Token(Token = "0x4000009")]
			Success,
			[Token(Token = "0x400000A")]
			Failure,
			[Token(Token = "0x400000B")]
			Canceled,
			[Token(Token = "0x400000C")]
			NoChange
		}

		[Token(Token = "0x17000001")]
		public Status status
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2B77D4C", Offset = "0x2B73D4C", VA = "0x2B77D4C")]
			[CompilerGenerated]
			get
			{
				return default(Status);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2B77D54", Offset = "0x2B73D54", VA = "0x2B77D54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string notification
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2B77D5C", Offset = "0x2B73D5C", VA = "0x2B77D5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2B77D64", Offset = "0x2B73D64", VA = "0x2B77D64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public static ActionResult Success
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2B77E58", Offset = "0x2B73E58", VA = "0x2B77E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static ActionResult NoSelection
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2B77ECC", Offset = "0x2B73ECC", VA = "0x2B77ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static ActionResult UserCanceled
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2B77F44", Offset = "0x2B73F44", VA = "0x2B77F44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2B77D6C", Offset = "0x2B73D6C", VA = "0x2B77D6C")]
		public ActionResult(Status status, string notification)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2B77D9C", Offset = "0x2B73D9C", VA = "0x2B77D9C")]
		public static implicit operator bool(ActionResult res)
		{
			return default(bool);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2B77DB0", Offset = "0x2B73DB0", VA = "0x2B77DB0")]
		public bool ToBool()
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2B77DC0", Offset = "0x2B73DC0", VA = "0x2B77DC0")]
		public static bool FromBool(bool success)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000006")]
	internal static class ArrayUtility
	{
		[Token(Token = "0x2000007")]
		private struct SearchRange
		{
			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int begin;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int end;

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2B77FBC", Offset = "0x2B73FBC", VA = "0x2B77FBC")]
			public SearchRange(int begin, int end)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2B77FC4", Offset = "0x2B73FC4", VA = "0x2B77FC4")]
			public bool Valid()
			{
				return default(bool);
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2B77FD8", Offset = "0x2B73FD8", VA = "0x2B77FD8")]
			public int Center()
			{
				return default(int);
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2B77FF0", Offset = "0x2B73FF0", VA = "0x2B77FF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x600000E")]
		public static T[] ValuesWithIndexes<T>(this T[] arr, int[] indexes)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		public static List<T> ValuesWithIndexes<T>(this List<T> arr, IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		public static IEnumerable<int> AllIndexesOf<T>(this IList<T> list, Func<T, bool> lambda)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		public static T[] Add<T>(this T[] arr, T val)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		public static T[] AddRange<T>(this T[] arr, T[] val)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		public static T[] Remove<T>(this T[] arr, T val)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value) where T : IComparable<T>
		{
			return default(int);
		}

		[Token(Token = "0x6000019")]
		public static List<T> Fill<T>(Func<int, T> ctor, int length)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		public static T[] Fill<T>(T val, int length)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		public static bool ContainsMatch<T>(this T[] a, T[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		public static T[] Concat<T>(this T[] x, T[] y)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		public static int IndexOf<T>(this List<List<T>> InList, T InValue)
		{
			return default(int);
		}

		[Token(Token = "0x600001F")]
		public static T[] Fill<T>(int count, Func<int, T> ctor)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
		}

		[Token(Token = "0x6000021")]
		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value)
		{
		}

		[Token(Token = "0x6000022")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public struct AutoUnwrapSettings
	{
		[Token(Token = "0x200000B")]
		public enum Anchor
		{
			[Token(Token = "0x400001D")]
			UpperLeft,
			[Token(Token = "0x400001E")]
			UpperCenter,
			[Token(Token = "0x400001F")]
			UpperRight,
			[Token(Token = "0x4000020")]
			MiddleLeft,
			[Token(Token = "0x4000021")]
			MiddleCenter,
			[Token(Token = "0x4000022")]
			MiddleRight,
			[Token(Token = "0x4000023")]
			LowerLeft,
			[Token(Token = "0x4000024")]
			LowerCenter,
			[Token(Token = "0x4000025")]
			LowerRight,
			[Token(Token = "0x4000026")]
			None
		}

		[Token(Token = "0x200000C")]
		public enum Fill
		{
			[Token(Token = "0x4000028")]
			Fit,
			[Token(Token = "0x4000029")]
			Tile,
			[Token(Token = "0x400002A")]
			Stretch
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[FormerlySerializedAs("useWorldSpace")]
		private bool m_UseWorldSpace;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		[FormerlySerializedAs("flipU")]
		[SerializeField]
		private bool m_FlipU;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[SerializeField]
		[FormerlySerializedAs("flipV")]
		private bool m_FlipV;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		[FormerlySerializedAs("swapUV")]
		[SerializeField]
		private bool m_SwapUV;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[FormerlySerializedAs("fill")]
		private Fill m_Fill;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("scale")]
		[SerializeField]
		private Vector2 m_Scale;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("offset")]
		[SerializeField]
		private Vector2 m_Offset;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("rotation")]
		private float m_Rotation;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FormerlySerializedAs("anchor")]
		private Anchor m_Anchor;

		[Token(Token = "0x17000006")]
		public static AutoUnwrapSettings defaultAutoUnwrapSettings
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2B78138", Offset = "0x2B74138", VA = "0x2B78138")]
			get
			{
				return default(AutoUnwrapSettings);
			}
		}

		[Token(Token = "0x17000007")]
		public bool useWorldSpace
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2B78168", Offset = "0x2B74168", VA = "0x2B78168")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2B78170", Offset = "0x2B74170", VA = "0x2B78170")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool flipU
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2B78178", Offset = "0x2B74178", VA = "0x2B78178")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2B78180", Offset = "0x2B74180", VA = "0x2B78180")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool flipV
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2B78188", Offset = "0x2B74188", VA = "0x2B78188")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2B78190", Offset = "0x2B74190", VA = "0x2B78190")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool swapUV
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2B78198", Offset = "0x2B74198", VA = "0x2B78198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2B781A0", Offset = "0x2B741A0", VA = "0x2B781A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Fill fill
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2B781A8", Offset = "0x2B741A8", VA = "0x2B781A8")]
			get
			{
				return default(Fill);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2B781B0", Offset = "0x2B741B0", VA = "0x2B781B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector2 scale
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2B781B8", Offset = "0x2B741B8", VA = "0x2B781B8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2B781C0", Offset = "0x2B741C0", VA = "0x2B781C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector2 offset
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2B781C8", Offset = "0x2B741C8", VA = "0x2B781C8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2B781D0", Offset = "0x2B741D0", VA = "0x2B781D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float rotation
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2B781D8", Offset = "0x2B741D8", VA = "0x2B781D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2B781E0", Offset = "0x2B741E0", VA = "0x2B781E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Anchor anchor
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2B781E8", Offset = "0x2B741E8", VA = "0x2B781E8")]
			get
			{
				return default(Anchor);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2B781F0", Offset = "0x2B741F0", VA = "0x2B781F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public static AutoUnwrapSettings tile
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2B78254", Offset = "0x2B74254", VA = "0x2B78254")]
			get
			{
				return default(AutoUnwrapSettings);
			}
		}

		[Token(Token = "0x17000011")]
		public static AutoUnwrapSettings fit
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2B7826C", Offset = "0x2B7426C", VA = "0x2B7826C")]
			get
			{
				return default(AutoUnwrapSettings);
			}
		}

		[Token(Token = "0x17000012")]
		public static AutoUnwrapSettings stretch
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2B78284", Offset = "0x2B74284", VA = "0x2B78284")]
			get
			{
				return default(AutoUnwrapSettings);
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2B781F8", Offset = "0x2B741F8", VA = "0x2B781F8")]
		public AutoUnwrapSettings(AutoUnwrapSettings unwrapSettings)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2B78150", Offset = "0x2B74150", VA = "0x2B78150")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2B7829C", Offset = "0x2B7429C", VA = "0x2B7829C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200000D")]
	internal enum BezierTangentMode
	{
		[Token(Token = "0x400002C")]
		Free,
		[Token(Token = "0x400002D")]
		Aligned,
		[Token(Token = "0x400002E")]
		Mirrored
	}
	[Token(Token = "0x200000E")]
	internal enum BezierTangentDirection
	{
		[Token(Token = "0x4000030")]
		In,
		[Token(Token = "0x4000031")]
		Out
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	internal struct BezierPoint
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 tangentIn;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 tangentOut;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2B78610", Offset = "0x2B74610", VA = "0x2B78610")]
		public BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2B7863C", Offset = "0x2B7463C", VA = "0x2B7863C")]
		public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2B78920", Offset = "0x2B74920", VA = "0x2B78920")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2B78968", Offset = "0x2B74968", VA = "0x2B78968")]
		public void SetTangentIn(Vector3 tangent, BezierTangentMode mode)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2B7897C", Offset = "0x2B7497C", VA = "0x2B7897C")]
		public void SetTangentOut(Vector3 tangent, BezierTangentMode mode)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2B78990", Offset = "0x2B74990", VA = "0x2B78990")]
		public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2B789F0", Offset = "0x2B749F0", VA = "0x2B789F0")]
		public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2B78A94", Offset = "0x2B74A94", VA = "0x2B78A94")]
		public static Vector3 GetLookDirection(IList<BezierPoint> points, int index, int previous, int next)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(ProBuilderMesh))]
	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	[AddComponentMenu("")]
	internal sealed class BezierShape : MonoBehaviour
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<BezierPoint> points;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool closeLoop;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int rows;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int columns;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool smooth;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool m_IsEditing;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ProBuilderMesh m_Mesh;

		[Token(Token = "0x17000013")]
		public bool isEditing
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2B794A0", Offset = "0x2B754A0", VA = "0x2B794A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2B794A8", Offset = "0x2B754A8", VA = "0x2B794A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public ProBuilderMesh mesh
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2B794B0", Offset = "0x2B754B0", VA = "0x2B794B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2B79544", Offset = "0x2B75544", VA = "0x2B79544")]
			set
			{
			}
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2B7954C", Offset = "0x2B7554C", VA = "0x2B7954C")]
		public void Init()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2B797A0", Offset = "0x2B757A0", VA = "0x2B797A0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2B79864", Offset = "0x2B75864", VA = "0x2B79864")]
		public BezierShape()
		{
		}
	}
	[Token(Token = "0x2000011")]
	internal sealed class Bounds2D
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 center;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 m_Size;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 m_Extents;

		[Token(Token = "0x17000015")]
		public Vector2 size
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2B798FC", Offset = "0x2B758FC", VA = "0x2B798FC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2B79904", Offset = "0x2B75904", VA = "0x2B79904")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector2 extents
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2B7991C", Offset = "0x2B7591C", VA = "0x2B7991C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000017")]
		public Vector2[] corners
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2B79924", Offset = "0x2B75924", VA = "0x2B79924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2B799EC", Offset = "0x2B759EC", VA = "0x2B799EC")]
		public Bounds2D()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2B79A54", Offset = "0x2B75A54", VA = "0x2B79A54")]
		public Bounds2D(Vector2 center, Vector2 size)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2B79AFC", Offset = "0x2B75AFC", VA = "0x2B79AFC")]
		public Bounds2D(IList<Vector2> points)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2B79E70", Offset = "0x2B75E70", VA = "0x2B79E70")]
		public Bounds2D(IList<Vector2> points, IList<int> indexes)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2B7A458", Offset = "0x2B76458", VA = "0x2B7A458")]
		internal Bounds2D(Vector3[] points, Edge[] edges)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2B7A5B0", Offset = "0x2B765B0", VA = "0x2B7A5B0")]
		public Bounds2D(Vector2[] points, int length)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2B7A6B8", Offset = "0x2B766B8", VA = "0x2B7A6B8")]
		public bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2B7A700", Offset = "0x2B76700", VA = "0x2B7A700")]
		public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2B7A8FC", Offset = "0x2B768FC", VA = "0x2B7A8FC")]
		public bool Intersects(Bounds2D bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2B7A934", Offset = "0x2B76934", VA = "0x2B7A934")]
		public bool Intersects(Rect rect)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2B79B74", Offset = "0x2B75B74", VA = "0x2B79B74")]
		public void SetWithPoints(IList<Vector2> points)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2B79EF8", Offset = "0x2B75EF8", VA = "0x2B79EF8")]
		public void SetWithPoints(IList<Vector2> points, IList<int> indexes)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2B7A970", Offset = "0x2B76970", VA = "0x2B7A970")]
		public static Vector2 Center(IList<Vector2> points)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2B7AC10", Offset = "0x2B76C10", VA = "0x2B7AC10")]
		public static Vector2 Center(IList<Vector2> points, IList<int> indexes)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2B7B054", Offset = "0x2B77054", VA = "0x2B7B054")]
		public static Vector2 Size(IList<Vector2> points, IList<int> indexes)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2B7B4A0", Offset = "0x2B774A0", VA = "0x2B7B4A0")]
		internal static Vector2 Center(IList<Vector4> points, IEnumerable<int> indexes)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2B7B974", Offset = "0x2B77974", VA = "0x2B7B974", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000012")]
	public static class BuiltinMaterials
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_IsInitialized;

		[Token(Token = "0x4000042")]
		public const string faceShader = "Hidden/ProBuilder/FaceHighlight";

		[Token(Token = "0x4000043")]
		public const string lineShader = "Hidden/ProBuilder/LineBillboard";

		[Token(Token = "0x4000044")]
		public const string lineShaderMetal = "Hidden/ProBuilder/LineBillboardMetal";

		[Token(Token = "0x4000045")]
		public const string pointShader = "Hidden/ProBuilder/PointBillboard";

		[Token(Token = "0x4000046")]
		public const string wireShader = "Hidden/ProBuilder/FaceHighlight";

		[Token(Token = "0x4000047")]
		public const string dotShader = "Hidden/ProBuilder/VertexShader";

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal static readonly Color previewColor;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Shader s_SelectionPickerShader;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool s_GeometryShadersSupported;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Material s_DefaultMaterial;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Material s_FacePickerMaterial;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Material s_VertexPickerMaterial;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Material s_EdgePickerMaterial;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Material s_UnityDefaultDiffuse;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Material s_UnlitVertexColorMaterial;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Material s_ShapePreviewMaterial;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static string k_EdgePickerMaterial;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static string k_FacePickerMaterial;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static string k_VertexPickerMaterial;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static string k_EdgePickerShader;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static string k_FacePickerShader;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static string k_VertexPickerShader;

		[Token(Token = "0x17000018")]
		public static bool geometryShadersSupported
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2B7C3E0", Offset = "0x2B783E0", VA = "0x2B7C3E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public static Material defaultMaterial
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2B7C43C", Offset = "0x2B7843C", VA = "0x2B7C43C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		internal static Shader selectionPickerShader
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x2B7C498", Offset = "0x2B78498", VA = "0x2B7C498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		internal static Material facePickerMaterial
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2B7C4F4", Offset = "0x2B784F4", VA = "0x2B7C4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		internal static Material vertexPickerMaterial
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2B7C550", Offset = "0x2B78550", VA = "0x2B7C550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		internal static Material edgePickerMaterial
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2B7C5AC", Offset = "0x2B785AC", VA = "0x2B7C5AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		internal static Material triggerMaterial
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2B7C608", Offset = "0x2B78608", VA = "0x2B7C608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		internal static Material colliderMaterial
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2B7C710", Offset = "0x2B78710", VA = "0x2B7C710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		[Obsolete("NoDraw is no longer supported.")]
		internal static Material noDrawMaterial
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2B7C818", Offset = "0x2B78818", VA = "0x2B7C818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		internal static Material unlitVertexColor
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2B7CBC0", Offset = "0x2B78BC0", VA = "0x2B7CBC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		internal static Material ShapePreviewMaterial
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2B7CC1C", Offset = "0x2B78C1C", VA = "0x2B7CC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2B7BAA8", Offset = "0x2B77AA8", VA = "0x2B7BAA8")]
		private static void Init()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2B7C920", Offset = "0x2B78920", VA = "0x2B7C920")]
		internal static Material GetLegacyDiffuse()
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2B7C170", Offset = "0x2B78170", VA = "0x2B7C170")]
		internal static Material GetDefaultMaterial()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	internal class ChangelogEntry
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SemVer m_VersionInfo;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_ReleaseNotes;

		[Token(Token = "0x17000023")]
		public SemVer versionInfo
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2B7CD7C", Offset = "0x2B78D7C", VA = "0x2B7CD7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string releaseNotes
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2B7CD84", Offset = "0x2B78D84", VA = "0x2B7CD84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2B7CD8C", Offset = "0x2B78D8C", VA = "0x2B7CD8C")]
		public ChangelogEntry(SemVer version, string releaseNotes)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2B7CDB8", Offset = "0x2B78DB8", VA = "0x2B7CDB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	internal class Changelog
	{
		[Token(Token = "0x400005A")]
		private const string k_ChangelogEntryPattern = "(##\\s\\[[0-9]+\\.[0-9]+\\.[0-9]+(\\-[a-zA-Z]+(\\.[0-9]+)*)*\\])";

		[Token(Token = "0x400005B")]
		private const string k_VersionInfoPattern = "(?<=##\\s\\[).*(?=\\])";

		[Token(Token = "0x400005C")]
		private const string k_VersionDatePattern = "(?<=##\\s\\[.*\\]\\s-\\s)[0-9-]*";

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<ChangelogEntry> m_Entries;

		[Token(Token = "0x17000025")]
		public ReadOnlyCollection<ChangelogEntry> entries
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2B7CE1C", Offset = "0x2B78E1C", VA = "0x2B7CE1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2B7CE98", Offset = "0x2B78E98", VA = "0x2B7CE98")]
		public Changelog(string log)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2B7D1A0", Offset = "0x2B791A0", VA = "0x2B7D1A0")]
		private ChangelogEntry CreateEntry(string version, string contents)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	internal static class Clipping
	{
		[Token(Token = "0x2000016")]
		[Flags]
		private enum OutCode
		{
			[Token(Token = "0x400005F")]
			Inside = 0,
			[Token(Token = "0x4000060")]
			Left = 1,
			[Token(Token = "0x4000061")]
			Right = 2,
			[Token(Token = "0x4000062")]
			Bottom = 4,
			[Token(Token = "0x4000063")]
			Top = 8
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2B7D308", Offset = "0x2B79308", VA = "0x2B7D308")]
		private static OutCode ComputeOutCode(Rect rect, float x, float y)
		{
			return default(OutCode);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2B7D344", Offset = "0x2B79344", VA = "0x2B7D344")]
		internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	internal sealed class ColliderBehaviour : EntityBehaviour
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2B7D554", Offset = "0x2B79554", VA = "0x2B7D554", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2B7D744", Offset = "0x2B79744", VA = "0x2B7D744", Slot = "5")]
		public override void OnEnterPlayMode()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2B7D7FC", Offset = "0x2B797FC", VA = "0x2B7D7FC", Slot = "6")]
		public override void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2B7D8B4", Offset = "0x2B798B4", VA = "0x2B7D8B4")]
		public ColliderBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	internal sealed class ColorPalette : ScriptableObject, IHasDefault
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("colors")]
		private List<Color> m_Colors;

		[Token(Token = "0x17000026")]
		public Color current
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2B7D8D4", Offset = "0x2B798D4", VA = "0x2B7D8D4")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2B7D8E0", Offset = "0x2B798E0", VA = "0x2B7D8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public ReadOnlyCollection<Color> colors
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2B7D8EC", Offset = "0x2B798EC", VA = "0x2B7D8EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public Color this[int i]
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2B7E19C", Offset = "0x2B7A19C", VA = "0x2B7E19C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2B7E1F4", Offset = "0x2B7A1F4", VA = "0x2B7E1F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public int Count
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2B7E27C", Offset = "0x2B7A27C", VA = "0x2B7E27C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2B7D968", Offset = "0x2B79968", VA = "0x2B7D968")]
		public void SetColors(IEnumerable<Color> colors)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2B7DA08", Offset = "0x2B79A08", VA = "0x2B7DA08", Slot = "4")]
		public void SetDefaultValues()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2B7E2C4", Offset = "0x2B7A2C4", VA = "0x2B7E2C4")]
		public ColorPalette()
		{
		}
	}
	[Token(Token = "0x2000019")]
	internal sealed class HSVColor
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float h;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float s;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float v;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2B7E2CC", Offset = "0x2B7A2CC", VA = "0x2B7E2CC")]
		public HSVColor(float h, float s, float v)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2B7E308", Offset = "0x2B7A308", VA = "0x2B7E308")]
		public HSVColor(float h, float s, float v, float sv_modifier)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2B7E350", Offset = "0x2B7A350", VA = "0x2B7E350")]
		public static HSVColor FromRGB(Color col)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2B7E59C", Offset = "0x2B7A59C", VA = "0x2B7E59C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2B7E660", Offset = "0x2B7A660", VA = "0x2B7E660")]
		public float SqrDistance(HSVColor InColor)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001A")]
	internal sealed class XYZColor
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float z;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2B7E6A4", Offset = "0x2B7A6A4", VA = "0x2B7E6A4")]
		public XYZColor(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2B7E6E0", Offset = "0x2B7A6E0", VA = "0x2B7E6E0")]
		public static XYZColor FromRGB(Color col)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2B7E7D0", Offset = "0x2B7A7D0", VA = "0x2B7E7D0")]
		public static XYZColor FromRGB(float R, float G, float B)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2B7E9F8", Offset = "0x2B7A9F8", VA = "0x2B7E9F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	internal sealed class CIELabColor
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float L;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float a;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float b;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2B7EABC", Offset = "0x2B7AABC", VA = "0x2B7EABC")]
		public CIELabColor(float L, float a, float b)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2B7EAF8", Offset = "0x2B7AAF8", VA = "0x2B7EAF8")]
		public static CIELabColor FromXYZ(XYZColor xyz)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2B7ECC4", Offset = "0x2B7ACC4", VA = "0x2B7ECC4")]
		public static CIELabColor FromRGB(Color col)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2B7ED50", Offset = "0x2B7AD50", VA = "0x2B7ED50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	internal static class ColorUtility
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, CIELabColor> ColorNameLookup;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2B7EE14", Offset = "0x2B7AE14", VA = "0x2B7EE14")]
		private static bool approx(float lhs, float rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2B7EE78", Offset = "0x2B7AE78", VA = "0x2B7EE78")]
		public static Color GetColor(Vector3 vec)
		{
			return default(Color);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2B7E75C", Offset = "0x2B7A75C", VA = "0x2B7E75C")]
		public static XYZColor RGBToXYZ(Color col)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2B7E844", Offset = "0x2B7A844", VA = "0x2B7E844")]
		public static XYZColor RGBToXYZ(float r, float g, float b)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2B7EB4C", Offset = "0x2B7AB4C", VA = "0x2B7EB4C")]
		public static CIELabColor XYZToCIE_Lab(XYZColor xyz)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2B7EF58", Offset = "0x2B7AF58", VA = "0x2B7EF58")]
		public static float DeltaE(CIELabColor lhs, CIELabColor rhs)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2B7EF9C", Offset = "0x2B7AF9C", VA = "0x2B7EF9C")]
		public static Color HSVtoRGB(HSVColor hsv)
		{
			return default(Color);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2B7F018", Offset = "0x2B7B018", VA = "0x2B7F018")]
		public static Color HSVtoRGB(float h, float s, float v)
		{
			return default(Color);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2B7E3CC", Offset = "0x2B7A3CC", VA = "0x2B7E3CC")]
		public static HSVColor RGBtoHSV(Color color)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2B7F10C", Offset = "0x2B7B10C", VA = "0x2B7F10C")]
		public static string GetColorName(Color InColor)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2B7F310", Offset = "0x2B7B310", VA = "0x2B7F310")]
		private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public struct Edge : IEquatable<Edge>
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int a;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int b;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Edge Empty;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2B7F334", Offset = "0x2B7B334", VA = "0x2B7F334")]
		public Edge(int a, int b)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2B7F33C", Offset = "0x2B7B33C", VA = "0x2B7F33C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2B7F360", Offset = "0x2B7B360", VA = "0x2B7F360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2B7F468", Offset = "0x2B7B468", VA = "0x2B7F468", Slot = "4")]
		public bool Equals(Edge other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2B7F4AC", Offset = "0x2B7B4AC", VA = "0x2B7F4AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2B7F57C", Offset = "0x2B7B57C", VA = "0x2B7F57C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2B7F5A0", Offset = "0x2B7B5A0", VA = "0x2B7F5A0")]
		public static Edge operator +(Edge a, Edge b)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2B7F5B8", Offset = "0x2B7B5B8", VA = "0x2B7F5B8")]
		public static Edge operator -(Edge a, Edge b)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2B7F5D0", Offset = "0x2B7B5D0", VA = "0x2B7F5D0")]
		public static Edge operator +(Edge a, int b)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2B7F5E4", Offset = "0x2B7B5E4", VA = "0x2B7F5E4")]
		public static Edge operator -(Edge a, int b)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2B7F5F8", Offset = "0x2B7B5F8", VA = "0x2B7F5F8")]
		public static bool operator ==(Edge a, Edge b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2B7F680", Offset = "0x2B7B680", VA = "0x2B7F680")]
		public static bool operator !=(Edge a, Edge b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2B7F6F0", Offset = "0x2B7B6F0", VA = "0x2B7F6F0")]
		public static Edge Add(Edge a, Edge b)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2B7F760", Offset = "0x2B7B760", VA = "0x2B7F760")]
		public static Edge Subtract(Edge a, Edge b)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2B7F7D0", Offset = "0x2B7B7D0", VA = "0x2B7F7D0")]
		public bool Equals(Edge other, Dictionary<int, int> lookup)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2B7F8F8", Offset = "0x2B7B8F8", VA = "0x2B7F8F8")]
		public bool Contains(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2B7F91C", Offset = "0x2B7B91C", VA = "0x2B7F91C")]
		public bool Contains(Edge other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2B7F948", Offset = "0x2B7B948", VA = "0x2B7F948")]
		internal bool Contains(int index, Dictionary<int, int> lookup)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2B7F9EC", Offset = "0x2B7B9EC", VA = "0x2B7F9EC")]
		internal static void GetIndices(IEnumerable<Edge> edges, List<int> indices)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public struct EdgeLookup : IEquatable<EdgeLookup>
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Edge m_Local;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Edge m_Common;

		[Token(Token = "0x1700002A")]
		public Edge local
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2B7FDCC", Offset = "0x2B7BDCC", VA = "0x2B7FDCC")]
			get
			{
				return default(Edge);
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2B7FDD4", Offset = "0x2B7BDD4", VA = "0x2B7FDD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Edge common
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2B7FDDC", Offset = "0x2B7BDDC", VA = "0x2B7FDDC")]
			get
			{
				return default(Edge);
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2B7FDE4", Offset = "0x2B7BDE4", VA = "0x2B7FDE4")]
			set
			{
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2B7FDEC", Offset = "0x2B7BDEC", VA = "0x2B7FDEC")]
		public EdgeLookup(Edge common, Edge local)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2B7FDF4", Offset = "0x2B7BDF4", VA = "0x2B7FDF4")]
		public EdgeLookup(int cx, int cy, int x, int y)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2B7FE0C", Offset = "0x2B7BE0C", VA = "0x2B7FE0C", Slot = "4")]
		public bool Equals(EdgeLookup other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2B7FE98", Offset = "0x2B7BE98", VA = "0x2B7FE98", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2B7FF20", Offset = "0x2B7BF20", VA = "0x2B7FF20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2B7FF94", Offset = "0x2B7BF94", VA = "0x2B7FF94")]
		public static bool operator ==(EdgeLookup a, EdgeLookup b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2B80030", Offset = "0x2B7C030", VA = "0x2B80030")]
		public static bool operator !=(EdgeLookup a, EdgeLookup b)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2B800D0", Offset = "0x2B7C0D0", VA = "0x2B800D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2B8027C", Offset = "0x2B7C27C", VA = "0x2B8027C")]
		public static IEnumerable<EdgeLookup> GetEdgeLookup(IEnumerable<Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2B80354", Offset = "0x2B7C354", VA = "0x2B80354")]
		public static HashSet<EdgeLookup> GetEdgeLookupHashSet(IEnumerable<Edge> edges, Dictionary<int, int> lookup)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	internal static class EdgeUtility
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2B8073C", Offset = "0x2B7C73C", VA = "0x2B8073C")]
		public static IEnumerable<Edge> GetSharedVertexHandleEdges(this ProBuilderMesh mesh, IEnumerable<Edge> edges)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2B80814", Offset = "0x2B7C814", VA = "0x2B80814")]
		public static Edge GetSharedVertexHandleEdge(this ProBuilderMesh mesh, Edge edge)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2B808AC", Offset = "0x2B7C8AC", VA = "0x2B808AC")]
		internal static Edge GetEdgeWithSharedVertexHandles(this ProBuilderMesh mesh, Edge edge)
		{
			return default(Edge);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2B8093C", Offset = "0x2B7C93C", VA = "0x2B8093C")]
		public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, out SimpleTuple<Face, Edge> validEdge)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2B80B98", Offset = "0x2B7CB98", VA = "0x2B80B98")]
		internal static bool Contains(this Edge[] edges, Edge edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2B80C7C", Offset = "0x2B7CC7C", VA = "0x2B80C7C")]
		internal static bool Contains(this Edge[] edges, int x, int y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2B80CF8", Offset = "0x2B7CCF8", VA = "0x2B80CF8")]
		internal static int IndexOf(this ProBuilderMesh mesh, IList<Edge> edges, Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2B80E98", Offset = "0x2B7CE98", VA = "0x2B80E98")]
		internal static int[] AllTriangles(this Edge[] edges)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2B80F4C", Offset = "0x2B7CF4C", VA = "0x2B80F4C")]
		internal static Face GetFace(this ProBuilderMesh mesh, Edge edge)
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	internal sealed class Entity : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_entityType")]
		[HideInInspector]
		private EntityType m_EntityType;

		[Token(Token = "0x1700002C")]
		public EntityType entityType
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2B810E0", Offset = "0x2B7D0E0", VA = "0x2B810E0")]
			get
			{
				return default(EntityType);
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2B810E8", Offset = "0x2B7D0E8", VA = "0x2B810E8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2B811B0", Offset = "0x2B7D1B0", VA = "0x2B811B0")]
		public void SetEntity(EntityType t)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2B811B8", Offset = "0x2B7D1B8", VA = "0x2B811B8")]
		public Entity()
		{
		}
	}
	[Token(Token = "0x2000023")]
	internal abstract class EntityBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Allow ProBuilder to automatically hide and show this object when entering or exiting play mode.")]
		public bool manageVisibility;

		[Token(Token = "0x60000DC")]
		public abstract void Initialize();

		[Token(Token = "0x60000DD")]
		public abstract void OnEnterPlayMode();

		[Token(Token = "0x60000DE")]
		public abstract void OnSceneLoaded(Scene scene, LoadSceneMode mode);

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2B7D660", Offset = "0x2B79660", VA = "0x2B7D660")]
		protected void SetMaterial(Material material)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2B7D8C4", Offset = "0x2B798C4", VA = "0x2B7D8C4")]
		protected EntityBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public sealed class Face
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("_indices")]
		private int[] m_Indexes;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_smoothingGroup")]
		[SerializeField]
		private int m_SmoothingGroup;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FormerlySerializedAs("_uv")]
		private AutoUnwrapSettings m_Uv;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_mat")]
		private Material m_Material;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int m_SubmeshIndex;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("manualUV")]
		[SerializeField]
		private bool m_ManualUV;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal int elementGroup;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int m_TextureGroup;

		[NonSerialized]
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] m_DistinctIndexes;

		[NonSerialized]
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Edge[] m_Edges;

		[Token(Token = "0x1700002D")]
		public bool manualUV
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2B811C0", Offset = "0x2B7D1C0", VA = "0x2B811C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2B811C8", Offset = "0x2B7D1C8", VA = "0x2B811C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int textureGroup
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2B811D0", Offset = "0x2B7D1D0", VA = "0x2B811D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2B811D8", Offset = "0x2B7D1D8", VA = "0x2B811D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		internal int[] indexesInternal
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2B811E0", Offset = "0x2B7D1E0", VA = "0x2B811E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2B811E8", Offset = "0x2B7D1E8", VA = "0x2B811E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public ReadOnlyCollection<int> indexes
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2B812AC", Offset = "0x2B7D2AC", VA = "0x2B812AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		internal int[] distinctIndexesInternal
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2B80B84", Offset = "0x2B7CB84", VA = "0x2B80B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public ReadOnlyCollection<int> distinctIndexes
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2B814A0", Offset = "0x2B7D4A0", VA = "0x2B814A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		internal Edge[] edgesInternal
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2B810C4", Offset = "0x2B7D0C4", VA = "0x2B810C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public ReadOnlyCollection<Edge> edges
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x2B81880", Offset = "0x2B7D880", VA = "0x2B81880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public int smoothingGroup
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x2B8190C", Offset = "0x2B7D90C", VA = "0x2B8190C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x2B81914", Offset = "0x2B7D914", VA = "0x2B81914")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		[Obsolete("Face.material is deprecated. Please use submeshIndex instead.")]
		public Material material
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x2B8191C", Offset = "0x2B7D91C", VA = "0x2B8191C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x2B81924", Offset = "0x2B7D924", VA = "0x2B81924")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int submeshIndex
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2B8192C", Offset = "0x2B7D92C", VA = "0x2B8192C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x2B81934", Offset = "0x2B7D934", VA = "0x2B81934")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public AutoUnwrapSettings uv
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x2B8193C", Offset = "0x2B7D93C", VA = "0x2B8193C")]
			get
			{
				return default(AutoUnwrapSettings);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2B8194C", Offset = "0x2B7D94C", VA = "0x2B8194C")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int this[int i]
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2B8195C", Offset = "0x2B7D95C", VA = "0x2B8195C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2B81328", Offset = "0x2B7D328", VA = "0x2B81328")]
		public void SetIndexes(IEnumerable<int> indices)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2B8198C", Offset = "0x2B7D98C", VA = "0x2B8198C")]
		public Face()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2B819A8", Offset = "0x2B7D9A8", VA = "0x2B819A8")]
		public Face(IEnumerable<int> indices)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2B81A4C", Offset = "0x2B7DA4C", VA = "0x2B81A4C")]
		[Obsolete("Face.material is deprecated. Please use \"submeshIndex\" instead.")]
		internal Face(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2B81AF4", Offset = "0x2B7DAF4", VA = "0x2B81AF4")]
		internal Face(IEnumerable<int> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2B81B98", Offset = "0x2B7DB98", VA = "0x2B81B98")]
		public Face(Face other)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2B81BC4", Offset = "0x2B7DBC4", VA = "0x2B81BC4")]
		public void CopyFrom(Face other)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2B812A4", Offset = "0x2B7D2A4", VA = "0x2B812A4")]
		internal void InvalidateCache()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2B8152C", Offset = "0x2B7D52C", VA = "0x2B8152C")]
		private Edge[] CacheEdges()
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2B8142C", Offset = "0x2B7D42C", VA = "0x2B8142C")]
		private int[] CacheDistinctIndexes()
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2B81CE8", Offset = "0x2B7DCE8", VA = "0x2B81CE8")]
		public bool Contains(int a, int b, int c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2B81D74", Offset = "0x2B7DD74", VA = "0x2B81D74")]
		public bool IsQuad()
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2B81DBC", Offset = "0x2B7DDBC", VA = "0x2B81DBC")]
		public int[] ToQuad()
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2B82184", Offset = "0x2B7E184", VA = "0x2B82184", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2B82354", Offset = "0x2B7E354", VA = "0x2B82354")]
		public void ShiftIndexes(int offset)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2B82398", Offset = "0x2B7E398", VA = "0x2B82398")]
		private int SmallestIndexValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2B823E8", Offset = "0x2B7E3E8", VA = "0x2B823E8")]
		public void ShiftIndexesToZero()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2B82444", Offset = "0x2B7E444", VA = "0x2B82444")]
		public void Reverse()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2B82494", Offset = "0x2B7E494", VA = "0x2B82494")]
		internal static void GetIndices(IEnumerable<Face> faces, List<int> indices)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2B82824", Offset = "0x2B7E824", VA = "0x2B82824")]
		internal static void GetDistinctIndices(IEnumerable<Face> faces, List<int> indices)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2B82BD4", Offset = "0x2B7EBD4", VA = "0x2B82BD4")]
		internal bool TryGetNextEdge(Edge source, int index, ref Edge nextEdge, ref int nextIndex)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	internal sealed class FaceRebuildData
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Face face;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Vertex> vertices;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<int> sharedIndexes;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int> sharedIndexesUV;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _appliedOffset;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2B82D4C", Offset = "0x2B7ED4C", VA = "0x2B82D4C")]
		public int Offset()
		{
			return default(int);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2B82D54", Offset = "0x2B7ED54", VA = "0x2B82D54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2B82E1C", Offset = "0x2B7EE1C", VA = "0x2B82E1C")]
		public static void Apply(IEnumerable<FaceRebuildData> newFaces, ProBuilderMesh mesh, [Optional] List<Vertex> vertices, [Optional] List<Face> faces)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2B82F98", Offset = "0x2B7EF98", VA = "0x2B82F98")]
		public static void Apply(IEnumerable<FaceRebuildData> newFaces, List<Vertex> vertices, List<Face> faces, Dictionary<int, int> sharedVertexLookup, [Optional] Dictionary<int, int> sharedTextureLookup)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2B834B8", Offset = "0x2B7F4B8", VA = "0x2B834B8")]
		public FaceRebuildData()
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal sealed class HandleConstraint2D
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int x;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int y;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HandleConstraint2D None;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2B834C0", Offset = "0x2B7F4C0", VA = "0x2B834C0")]
		public HandleConstraint2D(int x, int y)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2B834EC", Offset = "0x2B7F4EC", VA = "0x2B834EC")]
		public HandleConstraint2D Inverse()
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2B83560", Offset = "0x2B7F560", VA = "0x2B83560")]
		public Vector2 Mask(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2B83578", Offset = "0x2B7F578", VA = "0x2B83578")]
		public Vector2 InverseMask(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2B8359C", Offset = "0x2B7F59C", VA = "0x2B8359C")]
		public static bool operator ==(HandleConstraint2D a, HandleConstraint2D b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2B835DC", Offset = "0x2B7F5DC", VA = "0x2B835DC")]
		public static bool operator !=(HandleConstraint2D a, HandleConstraint2D b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2B8361C", Offset = "0x2B7F61C", VA = "0x2B8361C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2B83624", Offset = "0x2B7F624", VA = "0x2B83624", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2B836A4", Offset = "0x2B7F6A4", VA = "0x2B836A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000027")]
	public enum HandleOrientation
	{
		[Token(Token = "0x400008C")]
		World,
		[Token(Token = "0x400008D")]
		ActiveObject,
		[Token(Token = "0x400008E")]
		ActiveElement
	}
	[Token(Token = "0x2000028")]
	public static class HandleUtility
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2B83810", Offset = "0x2B7F810", VA = "0x2B83810")]
		internal static Vector3 ScreenToGuiPoint(this Camera camera, Vector3 point, float pixelsPerPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2B83860", Offset = "0x2B7F860", VA = "0x2B83860")]
		internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, [Optional] HashSet<Face> ignore)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2B838A0", Offset = "0x2B7F8A0", VA = "0x2B838A0")]
		internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, out RaycastHit hit, float distance, CullingMode cullingMode, [Optional] HashSet<Face> ignore)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2B84048", Offset = "0x2B80048", VA = "0x2B84048")]
		internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, ref SimpleTuple<Face, Vector3> back, ref SimpleTuple<Face, Vector3> front)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2B84530", Offset = "0x2B80530", VA = "0x2B84530")]
		internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, out List<RaycastHit> hits, CullingMode cullingMode, [Optional] HashSet<Face> ignore)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2B84AC8", Offset = "0x2B80AC8", VA = "0x2B84AC8")]
		internal static Ray InverseTransformRay(this Transform transform, Ray InWorldRay)
		{
			return default(Ray);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2B84C78", Offset = "0x2B80C78", VA = "0x2B84C78")]
		internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, out RaycastHit hit, float distance = float.PositiveInfinity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2B84DF0", Offset = "0x2B80DF0", VA = "0x2B84DF0")]
		internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, out RaycastHit hit, float distance = float.PositiveInfinity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2B852B0", Offset = "0x2B812B0", VA = "0x2B852B0")]
		internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2B85550", Offset = "0x2B81550", VA = "0x2B85550")]
		public static Quaternion GetRotation(ProBuilderMesh mesh, IEnumerable<int> indices)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2B85BEC", Offset = "0x2B81BEC", VA = "0x2B85BEC")]
		public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Face> faces)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2B85D0C", Offset = "0x2B81D0C", VA = "0x2B85D0C")]
		public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2B86390", Offset = "0x2B82390", VA = "0x2B86390")]
		public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<Edge> edges)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2B864B0", Offset = "0x2B824B0", VA = "0x2B864B0")]
		public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2B8657C", Offset = "0x2B8257C", VA = "0x2B8657C")]
		public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, IEnumerable<int> vertices)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2B86694", Offset = "0x2B82694", VA = "0x2B86694")]
		public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2B867B8", Offset = "0x2B827B8", VA = "0x2B867B8")]
		internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2B86E58", Offset = "0x2B82E58", VA = "0x2B86E58")]
		internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<Edge> edges)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2B86F44", Offset = "0x2B82F44", VA = "0x2B86F44")]
		internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, IEnumerable<int> vertices)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000029")]
	internal interface IHasDefault
	{
		[Token(Token = "0x600012C")]
		void SetDefaultValues();
	}
	[Token(Token = "0x200002A")]
	internal static class InternalUtility
	{
		[Token(Token = "0x600012D")]
		public static T[] GetComponents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		public static T[] GetComponents<T>(this IEnumerable<Transform> transforms) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2B86FE8", Offset = "0x2B82FE8", VA = "0x2B86FE8")]
		public static GameObject EmptyGameObjectWithTransform(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2B870D0", Offset = "0x2B830D0", VA = "0x2B870D0")]
		public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		public static T NextEnumValue<T>(this T current) where T : IConvertible
		{
			return (T)null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2B871EC", Offset = "0x2B831EC", VA = "0x2B871EC")]
		public static string ControlKeyString(char character)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2B872FC", Offset = "0x2B832FC", VA = "0x2B872FC")]
		public static bool TryParseColor(string value, ref Color col)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		public static T DemandComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		public static T DemandComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	internal struct IntVec2 : IEquatable<IntVec2>
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector2 value;

		[Token(Token = "0x1700003A")]
		public float x
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2B87578", Offset = "0x2B83578", VA = "0x2B87578")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public float y
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2B87580", Offset = "0x2B83580", VA = "0x2B87580")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2B87588", Offset = "0x2B83588", VA = "0x2B87588")]
		public IntVec2(Vector2 vector)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2B87590", Offset = "0x2B83590", VA = "0x2B87590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2B87630", Offset = "0x2B83630", VA = "0x2B87630")]
		public static bool operator ==(IntVec2 a, IntVec2 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2B876C0", Offset = "0x2B836C0", VA = "0x2B876C0")]
		public static bool operator !=(IntVec2 a, IntVec2 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2B87654", Offset = "0x2B83654", VA = "0x2B87654", Slot = "4")]
		public bool Equals(IntVec2 p)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2B87750", Offset = "0x2B83750", VA = "0x2B87750")]
		public bool Equals(Vector2 p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2B877BC", Offset = "0x2B837BC", VA = "0x2B877BC", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2B8787C", Offset = "0x2B8387C", VA = "0x2B8787C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2B876E8", Offset = "0x2B836E8", VA = "0x2B876E8")]
		private static int round(float v)
		{
			return default(int);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2B8788C", Offset = "0x2B8388C", VA = "0x2B8788C")]
		public static implicit operator Vector2(IntVec2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2B87890", Offset = "0x2B83890", VA = "0x2B87890")]
		public static implicit operator IntVec2(Vector2 p)
		{
			return default(IntVec2);
		}
	}
	[Token(Token = "0x200002D")]
	internal struct IntVec3 : IEquatable<IntVec3>
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 value;

		[Token(Token = "0x1700003C")]
		public float x
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2B87894", Offset = "0x2B83894", VA = "0x2B87894")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003D")]
		public float y
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2B8789C", Offset = "0x2B8389C", VA = "0x2B8789C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003E")]
		public float z
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2B878A4", Offset = "0x2B838A4", VA = "0x2B878A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2B878AC", Offset = "0x2B838AC", VA = "0x2B878AC")]
		public IntVec3(Vector3 vector)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2B878B8", Offset = "0x2B838B8", VA = "0x2B878B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2B8797C", Offset = "0x2B8397C", VA = "0x2B8797C")]
		public static bool operator ==(IntVec3 a, IntVec3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2B87A44", Offset = "0x2B83A44", VA = "0x2B87A44")]
		public static bool operator !=(IntVec3 a, IntVec3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2B879B0", Offset = "0x2B839B0", VA = "0x2B879B0", Slot = "4")]
		public bool Equals(IntVec3 p)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2B87AE4", Offset = "0x2B83AE4", VA = "0x2B87AE4")]
		public bool Equals(Vector3 p)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2B87B78", Offset = "0x2B83B78", VA = "0x2B87B78", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2B87C40", Offset = "0x2B83C40", VA = "0x2B87C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2B87A7C", Offset = "0x2B83A7C", VA = "0x2B87A7C")]
		private static int round(float v)
		{
			return default(int);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2B87C54", Offset = "0x2B83C54", VA = "0x2B87C54")]
		public static implicit operator Vector3(IntVec3 p)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2B87C58", Offset = "0x2B83C58", VA = "0x2B87C58")]
		public static implicit operator IntVec3(Vector3 p)
		{
			return default(IntVec3);
		}
	}
	[Token(Token = "0x200002E")]
	internal struct IntVec4 : IEquatable<IntVec4>
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4 value;

		[Token(Token = "0x1700003F")]
		public float x
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2B87C5C", Offset = "0x2B83C5C", VA = "0x2B87C5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000040")]
		public float y
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2B87C64", Offset = "0x2B83C64", VA = "0x2B87C64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000041")]
		public float z
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2B87C6C", Offset = "0x2B83C6C", VA = "0x2B87C6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000042")]
		public float w
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2B87C74", Offset = "0x2B83C74", VA = "0x2B87C74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2B87C7C", Offset = "0x2B83C7C", VA = "0x2B87C7C")]
		public IntVec4(Vector4 vector)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2B87C88", Offset = "0x2B83C88", VA = "0x2B87C88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2B87E34", Offset = "0x2B83E34", VA = "0x2B87E34")]
		public static bool operator ==(IntVec4 a, IntVec4 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2B87F24", Offset = "0x2B83F24", VA = "0x2B87F24")]
		public static bool operator !=(IntVec4 a, IntVec4 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2B87E70", Offset = "0x2B83E70", VA = "0x2B87E70", Slot = "4")]
		public bool Equals(IntVec4 p)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2B87FCC", Offset = "0x2B83FCC", VA = "0x2B87FCC")]
		public bool Equals(Vector4 p)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2B88080", Offset = "0x2B84080", VA = "0x2B88080", Slot = "0")]
		public override bool Equals(object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2B88148", Offset = "0x2B84148", VA = "0x2B88148", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2B87F64", Offset = "0x2B83F64", VA = "0x2B87F64")]
		private static int round(float v)
		{
			return default(int);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2B8815C", Offset = "0x2B8415C", VA = "0x2B8815C")]
		public static implicit operator Vector4(IntVec4 p)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2B88160", Offset = "0x2B84160", VA = "0x2B88160")]
		public static implicit operator IntVec4(Vector4 p)
		{
			return default(IntVec4);
		}
	}
	[Token(Token = "0x200002F")]
	[Flags]
	internal enum LogLevel
	{
		[Token(Token = "0x4000094")]
		None = 0,
		[Token(Token = "0x4000095")]
		Error = 1,
		[Token(Token = "0x4000096")]
		Warning = 2,
		[Token(Token = "0x4000097")]
		Info = 4,
		[Token(Token = "0x4000098")]
		Default = 3,
		[Token(Token = "0x4000099")]
		All = 0xFF
	}
	[Token(Token = "0x2000030")]
	[Flags]
	internal enum LogOutput
	{
		[Token(Token = "0x400009B")]
		None = 0,
		[Token(Token = "0x400009C")]
		Console = 1,
		[Token(Token = "0x400009D")]
		File = 2
	}
	[Token(Token = "0x2000031")]
	internal static class Log
	{
		[Token(Token = "0x400009E")]
		public const string k_ProBuilderLogFileName = "ProBuilderLog.txt";

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<LogLevel> s_logStack;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static LogLevel s_LogLevel;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static LogOutput s_Output;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string s_LogFilePath;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2B88164", Offset = "0x2B84164", VA = "0x2B88164")]
		public static void PushLogLevel(LogLevel level)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2B881F4", Offset = "0x2B841F4", VA = "0x2B881F4")]
		public static void PopLogLevel()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2B8827C", Offset = "0x2B8427C", VA = "0x2B8827C")]
		public static void SetLogLevel(LogLevel level)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2B882D8", Offset = "0x2B842D8", VA = "0x2B882D8")]
		public static void SetOutput(LogOutput output)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2B88334", Offset = "0x2B84334", VA = "0x2B88334")]
		public static void SetLogFile(string path)
		{
		}

		[Token(Token = "0x6000167")]
		[Conditional("DEBUG")]
		public static void Debug<T>(T value)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2B88390", Offset = "0x2B84390", VA = "0x2B88390")]
		[Conditional("DEBUG")]
		public static void Debug(string message)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2B884B8", Offset = "0x2B844B8", VA = "0x2B884B8")]
		[Conditional("DEBUG")]
		public static void Debug(string format, params object[] values)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2B884BC", Offset = "0x2B844BC", VA = "0x2B884BC")]
		public static void Info(string format, params object[] values)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2B88534", Offset = "0x2B84534", VA = "0x2B88534")]
		public static void Info(string message)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2B885B4", Offset = "0x2B845B4", VA = "0x2B885B4")]
		public static void Warning(string format, params object[] values)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2B8862C", Offset = "0x2B8462C", VA = "0x2B8862C")]
		public static void Warning(string message)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2B886AC", Offset = "0x2B846AC", VA = "0x2B886AC")]
		public static void Error(string format, params object[] values)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2B7C360", Offset = "0x2B78360", VA = "0x2B7C360")]
		public static void Error(string message)
		{
		}

		[Token(Token = "0x6000170")]
		[Conditional("CONSOLE_PRO_ENABLED")]
		internal static void Watch<T, K>(T key, K value)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2B883E8", Offset = "0x2B843E8", VA = "0x2B883E8")]
		private static void DoPrint(string message, LogType type)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2B88804", Offset = "0x2B84804", VA = "0x2B88804")]
		private static void PrintToFile(string message, string path)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2B88B40", Offset = "0x2B84B40", VA = "0x2B88B40")]
		public static void ClearLogFile()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2B88724", Offset = "0x2B84724", VA = "0x2B88724")]
		private static void PrintToConsole(string message, LogType type = LogType.Log)
		{
		}

		[Token(Token = "0x6000175")]
		internal static void NotNull<T>(T obj, string message)
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal static class MaterialUtility
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static List<Material> s_MaterialArray;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2B88C8C", Offset = "0x2B84C8C", VA = "0x2B88C8C")]
		internal static int GetMaterialCount(Renderer renderer)
		{
			return default(int);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2B88D5C", Offset = "0x2B84D5C", VA = "0x2B88D5C")]
		internal static Material GetSharedMaterial(Renderer renderer, int index)
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	public static class Math
	{
		[Token(Token = "0x40000A4")]
		public const float phi = 1.618034f;

		[Token(Token = "0x40000A5")]
		private const float k_FltEpsilon = float.Epsilon;

		[Token(Token = "0x40000A6")]
		private const float k_FltCompareEpsilon = 0.0001f;

		[Token(Token = "0x40000A7")]
		internal const float handleEpsilon = 0.0001f;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 tv1;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Vector3 tv2;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Vector3 tv3;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static Vector3 tv4;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2B88F3C", Offset = "0x2B84F3C", VA = "0x2B88F3C")]
		internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2B88F9C", Offset = "0x2B84F9C", VA = "0x2B88F9C")]
		internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, out Vector2 tangent)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2B890C8", Offset = "0x2B850C8", VA = "0x2B890C8")]
		internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, out Vector2 tangent)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2B89234", Offset = "0x2B85234", VA = "0x2B89234")]
		internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2B892A8", Offset = "0x2B852A8", VA = "0x2B892A8")]
		internal static float SignedAngle(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2B893B0", Offset = "0x2B853B0", VA = "0x2B893B0")]
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2B893D4", Offset = "0x2B853D4", VA = "0x2B893D4")]
		public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2B8948C", Offset = "0x2B8548C", VA = "0x2B8948C")]
		internal static float PolygonArea(Vector3[] vertices, int[] indexes)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2B89594", Offset = "0x2B85594", VA = "0x2B89594")]
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2B89608", Offset = "0x2B85608", VA = "0x2B89608")]
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2B89624", Offset = "0x2B85624", VA = "0x2B89624")]
		internal static Vector2 Perpendicular(Vector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2B89638", Offset = "0x2B85638", VA = "0x2B89638")]
		public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2B897B8", Offset = "0x2B857B8", VA = "0x2B897B8")]
		internal static float SqrDistanceRayPoint(Ray ray, Vector3 point)
		{
			return default(float);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2B89820", Offset = "0x2B85820", VA = "0x2B89820")]
		public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd)
		{
			return default(float);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2B899C8", Offset = "0x2B859C8", VA = "0x2B899C8")]
		public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
		{
			return default(float);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2B89C30", Offset = "0x2B85C30", VA = "0x2B89C30")]
		public static Vector3 GetNearestPointRayRay(Ray a, Ray b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2B89C74", Offset = "0x2B85C74", VA = "0x2B89C74")]
		internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2B89DD4", Offset = "0x2B85DD4", VA = "0x2B89DD4")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector2 intersect)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2B7A888", Offset = "0x2B76888", VA = "0x2B7A888")]
		internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2B89EE8", Offset = "0x2B85EE8", VA = "0x2B89EE8")]
		internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, [Optional] int[] indexes)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2B8A144", Offset = "0x2B86144", VA = "0x2B8A144")]
		internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2B8A264", Offset = "0x2B86264", VA = "0x2B8A264")]
		internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2B8A384", Offset = "0x2B86384", VA = "0x2B8A384")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2B8A388", Offset = "0x2B86388", VA = "0x2B8A388")]
		internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2B83DB4", Offset = "0x2B7FDB4", VA = "0x2B83DB4")]
		public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, out float OutDistance, out Vector3 OutPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2B85074", Offset = "0x2B81074", VA = "0x2B85074")]
		internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, ref float distance, ref Vector3 normal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2B8A3D8", Offset = "0x2B863D8", VA = "0x2B8A3D8")]
		public static float Secant(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2B8A3F0", Offset = "0x2B863F0", VA = "0x2B8A3F0")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2B8A5A4", Offset = "0x2B865A4", VA = "0x2B8A5A4")]
		internal static Vector3 Normal(IList<Vertex> vertices, [Optional] IList<int> indexes)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2B8AD50", Offset = "0x2B86D50", VA = "0x2B8AD50")]
		public static Vector3 Normal(ProBuilderMesh mesh, Face face)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2B85F78", Offset = "0x2B81F78", VA = "0x2B85F78")]
		public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face)
		{
			return default(Normal);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2B8AF44", Offset = "0x2B86F44", VA = "0x2B8AF44")]
		internal static bool IsCardinalAxis(Vector3 v, float epsilon = float.Epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2B8B18C", Offset = "0x2B8718C", VA = "0x2B8B18C")]
		internal static Vector2 DivideBy(this Vector2 v, Vector2 o)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2B8B198", Offset = "0x2B87198", VA = "0x2B8B198")]
		internal static Vector3 DivideBy(this Vector3 v, Vector3 o)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019C")]
		internal static T Max<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Token(Token = "0x600019D")]
		internal static T Min<T>(T[] array) where T : IComparable<T>
		{
			return (T)null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2B8B1A8", Offset = "0x2B871A8", VA = "0x2B8B1A8")]
		internal static float LargestValue(Vector3 v)
		{
			return default(float);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2B8B1C4", Offset = "0x2B871C4", VA = "0x2B8B1C4")]
		internal static float LargestValue(Vector2 v)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2B8B1D0", Offset = "0x2B871D0", VA = "0x2B8B1D0")]
		internal static Vector2 SmallestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2B8B218", Offset = "0x2B87218", VA = "0x2B8B218")]
		internal static Vector2 SmallestVector2(Vector2[] v, IList<int> indexes)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2B8B558", Offset = "0x2B87558", VA = "0x2B8B558")]
		internal static Vector2 LargestVector2(Vector2[] v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2B8B5A0", Offset = "0x2B875A0", VA = "0x2B8B5A0")]
		internal static Vector2 LargestVector2(Vector2[] v, IList<int> indexes)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2B86868", Offset = "0x2B82868", VA = "0x2B86868")]
		internal static Bounds GetBounds(Vector3[] positions, [Optional] IList<int> indices)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2B8B8E0", Offset = "0x2B878E0", VA = "0x2B8B8E0")]
		public static Vector2 Average(IList<Vector2> array, [Optional] IList<int> indexes)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2B8BC30", Offset = "0x2B87C30", VA = "0x2B8BC30")]
		public static Vector3 Average(IList<Vector3> array, [Optional] IList<int> indexes)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2B8C1D8", Offset = "0x2B881D8", VA = "0x2B8C1D8")]
		public static Vector4 Average(IList<Vector4> array, [Optional] IList<int> indexes)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2B8C788", Offset = "0x2B88788", VA = "0x2B8C788")]
		internal static Vector3 InvertScaleVector(Vector3 scaleVector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2B8C7B8", Offset = "0x2B887B8", VA = "0x2B8C7B8")]
		internal static bool Approx2(this Vector2 a, Vector2 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2B8C7D0", Offset = "0x2B887D0", VA = "0x2B8C7D0")]
		internal static bool Approx3(this Vector3 a, Vector3 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2B8C800", Offset = "0x2B88800", VA = "0x2B8C800")]
		internal static bool Approx4(this Vector4 a, Vector4 b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2B8C840", Offset = "0x2B88840", VA = "0x2B8C840")]
		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2B8C880", Offset = "0x2B88880", VA = "0x2B8C880")]
		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2B88E9C", Offset = "0x2B84E9C", VA = "0x2B88E9C")]
		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return default(int);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2B8C894", Offset = "0x2B88894", VA = "0x2B8C894")]
		internal static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2B8C8A4", Offset = "0x2B888A4", VA = "0x2B8C8A4")]
		internal static Vector3 Sign(this Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2B8C8C8", Offset = "0x2B888C8", VA = "0x2B8C8C8")]
		internal static float Sum(this Vector3 v)
		{
			return default(float);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2B8A3A8", Offset = "0x2B863A8", VA = "0x2B8A3A8")]
		internal static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2B8A390", Offset = "0x2B86390", VA = "0x2B8A390")]
		internal static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2B8C8E0", Offset = "0x2B888E0", VA = "0x2B8C8E0")]
		internal static bool IsNumber(float value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2B8C908", Offset = "0x2B88908", VA = "0x2B8C908")]
		internal static bool IsNumber(Vector2 value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2B8C958", Offset = "0x2B88958", VA = "0x2B8C958")]
		internal static bool IsNumber(Vector3 value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2B8C9C4", Offset = "0x2B889C4", VA = "0x2B8C9C4")]
		internal static bool IsNumber(Vector4 value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2B8CA54", Offset = "0x2B88A54", VA = "0x2B8CA54")]
		internal static float MakeNonZero(float value, float min = 0.0001f)
		{
			return default(float);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2B8CA88", Offset = "0x2B88A88", VA = "0x2B8CA88")]
		internal static Vector4 FixNaN(Vector4 value)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2B8CAF0", Offset = "0x2B88AF0", VA = "0x2B8CAF0")]
		internal static Vector2 EnsureUnitVector(Vector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2B8CBF8", Offset = "0x2B88BF8", VA = "0x2B8CBF8")]
		internal static Vector3 EnsureUnitVector(Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2B8CD18", Offset = "0x2B88D18", VA = "0x2B8CD18")]
		internal static Vector4 EnsureUnitVector(Vector4 value)
		{
			return default(Vector4);
		}
	}
	[Token(Token = "0x2000034")]
	internal sealed class MeshHandle
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform m_Transform;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh m_Mesh;

		[Token(Token = "0x17000043")]
		public Mesh mesh
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2B8CD6C", Offset = "0x2B88D6C", VA = "0x2B8CD6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2B8CD74", Offset = "0x2B88D74", VA = "0x2B8CD74")]
		public MeshHandle(Transform transform, Mesh mesh)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2B8CDA0", Offset = "0x2B88DA0", VA = "0x2B8CDA0")]
		public void DrawMeshNow(int submeshIndex)
		{
		}
	}
	[Token(Token = "0x2000035")]
	internal static class MeshHandles
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Vector3> s_Vector2List;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Vector3> s_Vector3List;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Vector4> s_Vector4List;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<int> s_IndexList;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<int> s_SharedVertexIndexList;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Vector2 k_Billboard0;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Vector2 k_Billboard1;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly Vector2 k_Billboard2;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Vector2 k_Billboard3;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2B8CEA8", Offset = "0x2B88EA8", VA = "0x2B8CEA8")]
		internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2B8D010", Offset = "0x2B89010", VA = "0x2B8D010")]
		internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, IList<Face> faces, Mesh target)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2B8D164", Offset = "0x2B89164", VA = "0x2B8D164")]
		internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2B8D540", Offset = "0x2B89540", VA = "0x2B8D540")]
		internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2B8D808", Offset = "0x2B89808", VA = "0x2B8D808")]
		internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2B8D9C0", Offset = "0x2B899C0", VA = "0x2B8D9C0")]
		internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, IList<int> indexes)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2B8DAA0", Offset = "0x2B89AA0", VA = "0x2B8DAA0")]
		private static void CreatePointMesh(Vector3[] positions, IList<int> indexes, Mesh target)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2B8E5D0", Offset = "0x2B8A5D0", VA = "0x2B8E5D0")]
		internal static void CreatePointBillboardMesh(IList<Vector3> positions, Mesh target)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2B8DC54", Offset = "0x2B89C54", VA = "0x2B8DC54")]
		private static void CreatePointBillboardMesh(IList<Vector3> positions, IList<int> indexes, Mesh target)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2B8EED8", Offset = "0x2B8AED8", VA = "0x2B8EED8")]
		internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2B8F76C", Offset = "0x2B8B76C", VA = "0x2B8F76C")]
		internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, ICollection<Edge> edges)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public static class MeshUtility
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2B904E8", Offset = "0x2B8C4E8", VA = "0x2B904E8")]
		internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2B90D48", Offset = "0x2B8CD48", VA = "0x2B90D48")]
		public static void GenerateTangent(Mesh mesh)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2B9125C", Offset = "0x2B8D25C", VA = "0x2B9125C")]
		public static Mesh DeepCopy(Mesh source)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2B912C0", Offset = "0x2B8D2C0", VA = "0x2B912C0")]
		public static void CopyTo(Mesh source, Mesh destination)
		{
		}

		[Token(Token = "0x60001D4")]
		internal static T GetMeshChannel<T>(GameObject gameObject, Func<Mesh, T> attributeGetter) where T : IList
		{
			return (T)null;
		}

		[Token(Token = "0x60001D5")]
		private static void PrintAttribute<T>(StringBuilder sb, string title, IEnumerable<T> attrib, string fmt)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2B91718", Offset = "0x2B8D718", VA = "0x2B91718")]
		public static string Print(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2B922C0", Offset = "0x2B8E2C0", VA = "0x2B922C0")]
		public static uint GetIndexCount(Mesh mesh)
		{
			return default(uint);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2B92380", Offset = "0x2B8E380", VA = "0x2B92380")]
		public static uint GetPrimitiveCount(Mesh mesh)
		{
			return default(uint);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2B92494", Offset = "0x2B8E494", VA = "0x2B92494")]
		public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2B907F8", Offset = "0x2B8C7F8", VA = "0x2B907F8")]
		public static Vertex[] GetVertices(this Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2B92DAC", Offset = "0x2B8EDAC", VA = "0x2B92DAC")]
		public static void CollapseSharedVertices(Mesh mesh, [Optional] Vertex[] vertices)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2B93298", Offset = "0x2B8F298", VA = "0x2B93298")]
		public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2B935E0", Offset = "0x2B8F5E0", VA = "0x2B935E0")]
		internal static string SanityCheck(ProBuilderMesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2B922B0", Offset = "0x2B8E2B0", VA = "0x2B922B0")]
		internal static string SanityCheck(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2B93C58", Offset = "0x2B8FC58", VA = "0x2B93C58")]
		internal static string SanityCheck(IList<Vertex> vertices)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2B93EE8", Offset = "0x2B8FEE8", VA = "0x2B93EE8")]
		internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2B94048", Offset = "0x2B90048", VA = "0x2B94048")]
		internal static void RestoreParticleSystem(ProBuilderMesh pbmesh)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2B940DC", Offset = "0x2B900DC", VA = "0x2B940DC")]
		internal static Bounds GetBounds(this ProBuilderMesh mesh)
		{
			return default(Bounds);
		}
	}
	[Token(Token = "0x2000039")]
	public struct Normal : IEquatable<Normal>
	{
		[Token(Token = "0x17000044")]
		public Vector3 normal
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2B942FC", Offset = "0x2B902FC", VA = "0x2B942FC")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x2B94308", Offset = "0x2B90308", VA = "0x2B94308")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Vector4 tangent
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x2B94314", Offset = "0x2B90314", VA = "0x2B94314")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x2B94320", Offset = "0x2B90320", VA = "0x2B94320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 bitangent
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2B9432C", Offset = "0x2B9032C", VA = "0x2B9432C")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2B94338", Offset = "0x2B90338", VA = "0x2B94338")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2B94344", Offset = "0x2B90344", VA = "0x2B94344", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2B9446C", Offset = "0x2B9046C", VA = "0x2B9446C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2B943D4", Offset = "0x2B903D4", VA = "0x2B943D4", Slot = "4")]
		public bool Equals(Normal other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2B944D0", Offset = "0x2B904D0", VA = "0x2B944D0")]
		public static bool operator ==(Normal a, Normal b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2B94500", Offset = "0x2B90500", VA = "0x2B94500")]
		public static bool operator !=(Normal a, Normal b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003A")]
	public static class Normals
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] s_SmoothAvg;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float[] s_SmoothAvgCount;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int[] s_CachedIntArray;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2B94548", Offset = "0x2B90548", VA = "0x2B94548")]
		private static void ClearIntArray(int count)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2B94644", Offset = "0x2B90644", VA = "0x2B94644")]
		public static void CalculateTangents(ProBuilderMesh mesh)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2B94B24", Offset = "0x2B90B24", VA = "0x2B94B24")]
		private static void CalculateHardNormals(ProBuilderMesh mesh)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2B94FDC", Offset = "0x2B90FDC", VA = "0x2B94FDC")]
		public static void CalculateNormals(ProBuilderMesh mesh)
		{
		}
	}
	[Token(Token = "0x200003B")]
	internal sealed class ObjectPool<T> : IDisposable
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_IsDisposed;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> m_Pool;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int desiredSize;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T> constructor;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> destructor;

		[Token(Token = "0x60001F6")]
		public ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor, bool lazyInitialization = false)
		{
		}

		[Token(Token = "0x60001F7")]
		public T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x60001F8")]
		public void Enqueue(T obj)
		{
		}

		[Token(Token = "0x60001F9")]
		public void Empty()
		{
		}

		[Token(Token = "0x60001FA")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001FB")]
		private void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public enum PivotPoint
	{
		[Token(Token = "0x40000C8")]
		Center,
		[Token(Token = "0x40000C9")]
		IndividualOrigins,
		[Token(Token = "0x40000CA")]
		ActiveElement
	}
	[Token(Token = "0x200003D")]
	[ExcludeFromObjectFactory]
	[ProGridsConditionalSnap]
	[ExcludeFromPreset]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public sealed class PolyShape : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		internal enum PolyEditMode
		{
			[Token(Token = "0x40000D2")]
			None,
			[Token(Token = "0x40000D3")]
			Path,
			[Token(Token = "0x40000D4")]
			Height,
			[Token(Token = "0x40000D5")]
			Edit
		}

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProBuilderMesh m_Mesh;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("points")]
		[SerializeField]
		internal List<Vector3> m_Points;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("extrude")]
		private float m_Extrude;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[FormerlySerializedAs("polyEditMode")]
		private PolyEditMode m_EditMode;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("flipNormals")]
		[SerializeField]
		private bool m_FlipNormals;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		internal bool isOnGrid;

		[Token(Token = "0x17000047")]
		public ReadOnlyCollection<Vector3> controlPoints
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x2B95648", Offset = "0x2B91648", VA = "0x2B95648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public float extrude
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x2B95720", Offset = "0x2B91720", VA = "0x2B95720")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x2B95728", Offset = "0x2B91728", VA = "0x2B95728")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		internal PolyEditMode polyEditMode
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x2B95730", Offset = "0x2B91730", VA = "0x2B95730")]
			get
			{
				return default(PolyEditMode);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x2B95738", Offset = "0x2B91738", VA = "0x2B95738")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool flipNormals
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x2B95740", Offset = "0x2B91740", VA = "0x2B95740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2B95748", Offset = "0x2B91748", VA = "0x2B95748")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		internal ProBuilderMesh mesh
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x2B95750", Offset = "0x2B91750", VA = "0x2B95750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2B957E4", Offset = "0x2B917E4", VA = "0x2B957E4")]
			set
			{
			}
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2B956C4", Offset = "0x2B916C4", VA = "0x2B956C4")]
		public void SetControlPoints(IList<Vector3> points)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2B957EC", Offset = "0x2B917EC", VA = "0x2B957EC")]
		private bool IsSnapEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2B957F4", Offset = "0x2B917F4", VA = "0x2B957F4")]
		public PolyShape()
		{
		}
	}
	[Token(Token = "0x200003F")]
	internal sealed class PreferenceDictionary : ScriptableObject, ISerializationCallbackReceiver, IHasDefault
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, bool> m_Bool;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, int> m_Int;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, float> m_Float;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> m_String;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, Color> m_Color;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Material> m_Material;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<string> m_Bool_keys;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<string> m_Int_keys;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<string> m_Float_keys;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<string> m_String_keys;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<string> m_Color_keys;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<string> m_Material_keys;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<bool> m_Bool_values;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<int> m_Int_values;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<float> m_Float_values;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<string> m_String_values;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<Color> m_Color_values;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<Material> m_Material_values;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2B95878", Offset = "0x2B91878", VA = "0x2B95878", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2B95B8C", Offset = "0x2B91B8C", VA = "0x2B95B8C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2B95F54", Offset = "0x2B91F54", VA = "0x2B95F54", Slot = "6")]
		public void SetDefaultValues()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2B96058", Offset = "0x2B92058", VA = "0x2B96058")]
		public bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		public bool HasKey<T>(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2B9619C", Offset = "0x2B9219C", VA = "0x2B9619C")]
		public void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600020E")]
		public T Get<T>(string key, [Optional] T fallback)
		{
			return (T)null;
		}

		[Token(Token = "0x600020F")]
		public void Set<T>(string key, T value)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2B963D0", Offset = "0x2B923D0", VA = "0x2B963D0")]
		public bool GetBool(string key, bool fallback = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2B96458", Offset = "0x2B92458", VA = "0x2B96458")]
		public int GetInt(string key, int fallback = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2B964D4", Offset = "0x2B924D4", VA = "0x2B964D4")]
		public float GetFloat(string key, float fallback = 0f)
		{
			return default(float);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2B96550", Offset = "0x2B92550", VA = "0x2B96550")]
		public string GetString(string key, [Optional] string fallback)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2B965CC", Offset = "0x2B925CC", VA = "0x2B965CC")]
		public Color GetColor(string key, [Optional] Color fallback)
		{
			return default(Color);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2B96674", Offset = "0x2B92674", VA = "0x2B96674")]
		public Material GetMaterial(string key, [Optional] Material fallback)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2B966F0", Offset = "0x2B926F0", VA = "0x2B966F0")]
		public void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2B96758", Offset = "0x2B92758", VA = "0x2B96758")]
		public void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2B967C0", Offset = "0x2B927C0", VA = "0x2B967C0")]
		public void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2B96828", Offset = "0x2B92828", VA = "0x2B96828")]
		public void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2B96890", Offset = "0x2B92890", VA = "0x2B96890")]
		public void SetColor(string key, Color value)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2B96918", Offset = "0x2B92918", VA = "0x2B96918")]
		public void SetMaterial(string key, Material value)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2B96980", Offset = "0x2B92980", VA = "0x2B96980")]
		public Dictionary<string, bool> GetBoolDictionary()
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2B96988", Offset = "0x2B92988", VA = "0x2B96988")]
		public Dictionary<string, int> GetIntDictionary()
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2B96990", Offset = "0x2B92990", VA = "0x2B96990")]
		public Dictionary<string, float> GetFloatDictionary()
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2B96998", Offset = "0x2B92998", VA = "0x2B96998")]
		public Dictionary<string, string> GetStringDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2B969A0", Offset = "0x2B929A0", VA = "0x2B969A0")]
		public Dictionary<string, Color> GetColorDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2B969A8", Offset = "0x2B929A8", VA = "0x2B969A8")]
		public Dictionary<string, Material> GetMaterialDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2B969B0", Offset = "0x2B929B0", VA = "0x2B969B0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2B96A90", Offset = "0x2B92A90", VA = "0x2B96A90")]
		public PreferenceDictionary()
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal static class PreferenceKeys
	{
		[Token(Token = "0x40000E8")]
		public const string pluginTitle = "ProBuilder";

		[Token(Token = "0x40000E9")]
		internal const float k_MaxPointDistanceFromControl = 20f;

		[Token(Token = "0x40000EA")]
		internal const char DEGREE_SYMBOL = '°';

		[Token(Token = "0x40000EB")]
		internal const char CMD_SUPER = '⌘';

		[Token(Token = "0x40000EC")]
		internal const char CMD_SHIFT = '⇧';

		[Token(Token = "0x40000ED")]
		internal const char CMD_OPTION = '⌥';

		[Token(Token = "0x40000EE")]
		internal const char CMD_ALT = '⎇';

		[Token(Token = "0x40000EF")]
		internal const char CMD_DELETE = '⌫';

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Color proBuilderBlue;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly Color proBuilderLightGray;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly Color proBuilderDarkGray;

		[Token(Token = "0x40000F3")]
		public const int menuEditor = 100;

		[Token(Token = "0x40000F4")]
		public const int menuSelection = 200;

		[Token(Token = "0x40000F5")]
		public const int menuGeometry = 200;

		[Token(Token = "0x40000F6")]
		public const int menuActions = 300;

		[Token(Token = "0x40000F7")]
		public const int menuMaterialColors = 400;

		[Token(Token = "0x40000F8")]
		public const int menuVertexColors = 400;

		[Token(Token = "0x40000F9")]
		public const int menuRepair = 600;

		[Token(Token = "0x40000FA")]
		public const int menuMisc = 600;

		[Token(Token = "0x40000FB")]
		public const int menuExport = 800;

		[Token(Token = "0x40000FC")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultEditLevel = "pbDefaultEditLevel";

		[Token(Token = "0x40000FD")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultSelectionMode = "pbDefaultSelectionMode";

		[Token(Token = "0x40000FE")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbHandleAlignment = "pbHandleAlignment";

		[Token(Token = "0x40000FF")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbVertexColorTool = "pbVertexColorTool";

		[Token(Token = "0x4000100")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbToolbarLocation = "pbToolbarLocation";

		[Token(Token = "0x4000101")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultEntity = "pbDefaultEntity";

		[Token(Token = "0x4000102")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbExtrudeMethod = "pbExtrudeMethod";

		[Token(Token = "0x4000103")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultStaticFlags = "pbDefaultStaticFlags";

		[Token(Token = "0x4000104")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbSelectedFaceColor = "pbDefaultFaceColor";

		[Token(Token = "0x4000105")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbWireframeColor = "pbDefaultEdgeColor";

		[Token(Token = "0x4000106")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUnselectedEdgeColor = "pbUnselectedEdgeColor";

		[Token(Token = "0x4000107")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbSelectedEdgeColor = "pbSelectedEdgeColor";

		[Token(Token = "0x4000108")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbSelectedVertexColor = "pbDefaultSelectedVertexColor";

		[Token(Token = "0x4000109")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUnselectedVertexColor = "pbDefaultVertexColor";

		[Token(Token = "0x400010A")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbPreselectionColor = "pbPreselectionColor";

		[Token(Token = "0x400010B")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultOpenInDockableWindow = "pbDefaultOpenInDockableWindow";

		[Token(Token = "0x400010C")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbEditorPrefVersion = "pbEditorPrefVersion";

		[Token(Token = "0x400010D")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbEditorShortcutsVersion = "pbEditorShortcutsVersion";

		[Token(Token = "0x400010E")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultCollider = "pbDefaultCollider";

		[Token(Token = "0x400010F")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbForceConvex = "pbForceConvex";

		[Token(Token = "0x4000110")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbVertexColorPrefs = "pbVertexColorPrefs";

		[Token(Token = "0x4000111")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowEditorNotifications = "pbShowEditorNotifications";

		[Token(Token = "0x4000112")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDragCheckLimit = "pbDragCheckLimit";

		[Token(Token = "0x4000113")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbForceVertexPivot = "pbForceVertexPivot";

		[Token(Token = "0x4000114")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbForceGridPivot = "pbForceGridPivot";

		[Token(Token = "0x4000115")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbManifoldEdgeExtrusion = "pbManifoldEdgeExtrusion";

		[Token(Token = "0x4000116")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbPerimeterEdgeBridgeOnly = "pbPerimeterEdgeBridgeOnly";

		[Token(Token = "0x4000117")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbPBOSelectionOnly = "pbPBOSelectionOnly";

		[Token(Token = "0x4000118")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbCloseShapeWindow = "pbCloseShapeWindow";

		[Token(Token = "0x4000119")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUVEditorFloating = "pbUVEditorFloating";

		[Token(Token = "0x400011A")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUVMaterialPreview = "pbUVMaterialPreview";

		[Token(Token = "0x400011B")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowSceneToolbar = "pbShowSceneToolbar";

		[Token(Token = "0x400011C")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbNormalizeUVsOnPlanarProjection = "pbNormalizeUVsOnPlanarProjection";

		[Token(Token = "0x400011D")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbStripProBuilderOnBuild = "pbStripProBuilderOnBuild";

		[Token(Token = "0x400011E")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDisableAutoUV2Generation = "pbDisableAutoUV2Generation";

		[Token(Token = "0x400011F")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowSceneInfo = "pbShowSceneInfo";

		[Token(Token = "0x4000120")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbEnableBackfaceSelection = "pbEnableBackfaceSelection";

		[Token(Token = "0x4000121")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbVertexPaletteDockable = "pbVertexPaletteDockable";

		[Token(Token = "0x4000122")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbExtrudeAsGroup = "pbExtrudeAsGroup";

		[Token(Token = "0x4000123")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUniqueModeShortcuts = "pbUniqueModeShortcuts";

		[Token(Token = "0x4000124")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbMaterialEditorFloating = "pbMaterialEditorFloating";

		[Token(Token = "0x4000125")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShapeWindowFloating = "pbShapeWindowFloating";

		[Token(Token = "0x4000126")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbIconGUI = "pbIconGUI";

		[Token(Token = "0x4000127")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShiftOnlyTooltips = "pbShiftOnlyTooltips";

		[Token(Token = "0x4000128")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDrawAxisLines = "pbDrawAxisLines";

		[Token(Token = "0x4000129")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbCollapseVertexToFirst = "pbCollapseVertexToFirst";

		[Token(Token = "0x400012A")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbMeshesAreAssets = "pbMeshesAreAssets";

		[Token(Token = "0x400012B")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbElementSelectIsHamFisted = "pbElementSelectIsHamFisted";

		[Token(Token = "0x400012C")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbFillHoleSelectsEntirePath = "pbFillHoleSelectsEntirePath";

		[Token(Token = "0x400012D")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDetachToNewObject = "pbDetachToNewObject";

		[Token(Token = "0x400012E")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbPreserveFaces = "pbPreserveFaces";

		[Token(Token = "0x400012F")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDragSelectWholeElement = "pbDragSelectWholeElement";

		[Token(Token = "0x4000130")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowPreselectionHighlight = "pbShowPreselectionHighlight";

		[Token(Token = "0x4000131")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbRectSelectMode = "pbRectSelectMode";

		[Token(Token = "0x4000132")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDragSelectMode = "pbDragSelectMode";

		[Token(Token = "0x4000133")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShadowCastingMode = "pbShadowCastingMode";

		[Token(Token = "0x4000134")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbEnableExperimental = "pbEnableExperimental";

		[Token(Token = "0x4000135")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbCheckForProBuilderUpdates = "pbCheckForProBuilderUpdates";

		[Token(Token = "0x4000136")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbManageLightmappingStaticFlag = "pbManageLightmappingStaticFlag";

		[Token(Token = "0x4000137")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowMissingLightmapUvWarning = "pb_Lightmapping::showMissingLightmapUvWarning";

		[Token(Token = "0x4000138")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbSelectedFaceDither = "pbSelectedFaceDither";

		[Token(Token = "0x4000139")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUseUnityColors = "pbUseUnityColors";

		[Token(Token = "0x400013A")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbVertexHandleSize = "pbVertexHandleSize";

		[Token(Token = "0x400013B")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUVGridSnapValue = "pbUVGridSnapValue";

		[Token(Token = "0x400013C")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbUVWeldDistance = "pbUVWeldDistance";

		[Token(Token = "0x400013D")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbLineHandleSize = "pbLineHandleSize";

		[Token(Token = "0x400013E")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbWireframeSize = "pbWireframeSize";

		[Token(Token = "0x400013F")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbWeldDistance = "pbWeldDistance";

		[Token(Token = "0x4000140")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbExtrudeDistance = "pbExtrudeDistance";

		[Token(Token = "0x4000141")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbBevelAmount = "pbBevelAmount";

		[Token(Token = "0x4000142")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbEdgeSubdivisions = "pbEdgeSubdivisions";

		[Token(Token = "0x4000143")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultShortcuts = "pbDefaultShortcuts";

		[Token(Token = "0x4000144")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbDefaultMaterial = "pbDefaultMaterial";

		[Token(Token = "0x4000145")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbCurrentMaterialPalette = "pbCurrentMaterialPalette";

		[Token(Token = "0x4000146")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbGrowSelectionUsingAngle = "pbGrowSelectionUsingAngle";

		[Token(Token = "0x4000147")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbGrowSelectionAngle = "pbGrowSelectionAngle";

		[Token(Token = "0x4000148")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbGrowSelectionAngleIterative = "pbGrowSelectionAngleIterative";

		[Token(Token = "0x4000149")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowDetail = "pbShowDetail";

		[Token(Token = "0x400014A")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowOccluder = "pbShowOccluder";

		[Token(Token = "0x400014B")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowMover = "pbShowMover";

		[Token(Token = "0x400014C")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowCollider = "pbShowCollider";

		[Token(Token = "0x400014D")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowTrigger = "pbShowTrigger";

		[Token(Token = "0x400014E")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string pbShowNoDraw = "pbShowNoDraw";

		[Token(Token = "0x400014F")]
		[Obsolete("Use Pref<T> or Settings class directly.")]
		internal const string defaultUnwrapParameters = "pbDefaultUnwrapParameters";
	}
	[Token(Token = "0x2000041")]
	[Flags]
	public enum SelectMode
	{
		[Token(Token = "0x4000151")]
		None = 0,
		[Token(Token = "0x4000152")]
		Object = 1,
		[Token(Token = "0x4000153")]
		Vertex = 2,
		[Token(Token = "0x4000154")]
		Edge = 4,
		[Token(Token = "0x4000155")]
		Face = 8,
		[Token(Token = "0x4000156")]
		TextureFace = 0x10,
		[Token(Token = "0x4000157")]
		TextureEdge = 0x20,
		[Token(Token = "0x4000158")]
		TextureVertex = 0x40,
		[Token(Token = "0x4000159")]
		InputTool = 0x80,
		[Token(Token = "0x400015A")]
		Any = 0xFFFF
	}
	[Token(Token = "0x2000042")]
	internal enum ComponentMode
	{
		[Token(Token = "0x400015C")]
		Vertex,
		[Token(Token = "0x400015D")]
		Edge,
		[Token(Token = "0x400015E")]
		Face
	}
	[Token(Token = "0x2000043")]
	internal enum EditLevel
	{
		[Token(Token = "0x4000160")]
		Top,
		[Token(Token = "0x4000161")]
		Geometry,
		[Token(Token = "0x4000162")]
		Texture,
		[Token(Token = "0x4000163")]
		Plugin
	}
	[Token(Token = "0x2000044")]
	internal enum EntityType
	{
		[Token(Token = "0x4000165")]
		Detail,
		[Token(Token = "0x4000166")]
		Occluder,
		[Token(Token = "0x4000167")]
		Trigger,
		[Token(Token = "0x4000168")]
		Collider,
		[Token(Token = "0x4000169")]
		Mover
	}
	[Token(Token = "0x2000045")]
	internal enum ColliderType
	{
		[Token(Token = "0x400016B")]
		None,
		[Token(Token = "0x400016C")]
		BoxCollider,
		[Token(Token = "0x400016D")]
		MeshCollider
	}
	[Token(Token = "0x2000046")]
	public enum ProjectionAxis
	{
		[Token(Token = "0x400016F")]
		X,
		[Token(Token = "0x4000170")]
		Y,
		[Token(Token = "0x4000171")]
		Z,
		[Token(Token = "0x4000172")]
		XNegative,
		[Token(Token = "0x4000173")]
		YNegative,
		[Token(Token = "0x4000174")]
		ZNegative
	}
	[Token(Token = "0x2000047")]
	internal enum HandleAxis
	{
		[Token(Token = "0x4000176")]
		X = 1,
		[Token(Token = "0x4000177")]
		Y = 2,
		[Token(Token = "0x4000178")]
		Z = 4,
		[Token(Token = "0x4000179")]
		Free = 8
	}
	[Token(Token = "0x2000048")]
	public enum Axis
	{
		[Token(Token = "0x400017B")]
		Right,
		[Token(Token = "0x400017C")]
		Left,
		[Token(Token = "0x400017D")]
		Up,
		[Token(Token = "0x400017E")]
		Down,
		[Token(Token = "0x400017F")]
		Forward,
		[Token(Token = "0x4000180")]
		Backward
	}
	[Token(Token = "0x2000049")]
	public enum WindingOrder
	{
		[Token(Token = "0x4000182")]
		Unknown,
		[Token(Token = "0x4000183")]
		Clockwise,
		[Token(Token = "0x4000184")]
		CounterClockwise
	}
	[Token(Token = "0x200004A")]
	public enum SortMethod
	{
		[Token(Token = "0x4000186")]
		Clockwise,
		[Token(Token = "0x4000187")]
		CounterClockwise
	}
	[Token(Token = "0x200004B")]
	[Flags]
	public enum CullingMode
	{
		[Token(Token = "0x4000189")]
		None = 0,
		[Token(Token = "0x400018A")]
		Back = 1,
		[Token(Token = "0x400018B")]
		Front = 2,
		[Token(Token = "0x400018C")]
		FrontBack = 3
	}
	[Token(Token = "0x200004C")]
	public enum RectSelectMode
	{
		[Token(Token = "0x400018E")]
		Partial,
		[Token(Token = "0x400018F")]
		Complete
	}
	[Token(Token = "0x200004D")]
	public enum MeshSyncState
	{
		[Token(Token = "0x4000191")]
		Null,
		[Token(Token = "0x4000192")]
		[Obsolete("InstanceIDMismatch is no longer used. Mesh references are not tracked by Instance ID.")]
		InstanceIDMismatch,
		[Token(Token = "0x4000193")]
		Lightmap,
		[Token(Token = "0x4000194")]
		InSync,
		[Token(Token = "0x4000195")]
		NeedsRebuild
	}
	[Token(Token = "0x200004E")]
	[Flags]
	public enum MeshArrays
	{
		[Token(Token = "0x4000197")]
		Position = 1,
		[Token(Token = "0x4000198")]
		Texture0 = 2,
		[Token(Token = "0x4000199")]
		Texture1 = 4,
		[Token(Token = "0x400019A")]
		Lightmap = 4,
		[Token(Token = "0x400019B")]
		Texture2 = 8,
		[Token(Token = "0x400019C")]
		Texture3 = 0x10,
		[Token(Token = "0x400019D")]
		Color = 0x20,
		[Token(Token = "0x400019E")]
		Normal = 0x40,
		[Token(Token = "0x400019F")]
		Tangent = 0x80,
		[Token(Token = "0x40001A0")]
		All = 0xFF
	}
	[Token(Token = "0x200004F")]
	internal enum IndexFormat
	{
		[Token(Token = "0x40001A2")]
		Local,
		[Token(Token = "0x40001A3")]
		Common,
		[Token(Token = "0x40001A4")]
		Both
	}
	[Token(Token = "0x2000050")]
	[Flags]
	public enum RefreshMask
	{
		[Token(Token = "0x40001A6")]
		UV = 1,
		[Token(Token = "0x40001A7")]
		Colors = 2,
		[Token(Token = "0x40001A8")]
		Normals = 4,
		[Token(Token = "0x40001A9")]
		Tangents = 8,
		[Token(Token = "0x40001AA")]
		Collisions = 0x10,
		[Token(Token = "0x40001AB")]
		Bounds = 0x16,
		[Token(Token = "0x40001AC")]
		All = 0x1F
	}
	[Token(Token = "0x2000051")]
	public enum ExtrudeMethod
	{
		[Token(Token = "0x40001AE")]
		IndividualFaces,
		[Token(Token = "0x40001AF")]
		VertexNormal,
		[Token(Token = "0x40001B0")]
		FaceNormal
	}
	[Token(Token = "0x2000052")]
	[ExcludeFromObjectFactory]
	[AddComponentMenu("//ProBuilder MeshFilter")]
	[RequireComponent(typeof(MeshRenderer))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[ExcludeFromPreset]
	public sealed class ProBuilderMesh : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		[Flags]
		private enum CacheValidState : byte
		{
			[Token(Token = "0x40001DF")]
			SharedVertex = 1,
			[Token(Token = "0x40001E0")]
			SharedTexture = 2
		}

		[Token(Token = "0x2000054")]
		internal struct NonVersionedEditScope : IDisposable
		{
			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ProBuilderMesh m_Mesh;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly ushort m_VersionIndex;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly ushort m_InstanceVersionIndex;

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2B9A208", Offset = "0x2B96208", VA = "0x2B9A208")]
			public NonVersionedEditScope(ProBuilderMesh mesh)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2B9F4A0", Offset = "0x2B9B4A0", VA = "0x2B9F4A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		internal const HideFlags k_MeshFilterHideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;

		[Token(Token = "0x40001B2")]
		private const int k_UVChannelCount = 4;

		[Token(Token = "0x40001B3")]
		internal const int k_MeshFormatVersion = 2;

		[Token(Token = "0x40001B4")]
		internal const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;

		[Token(Token = "0x40001B5")]
		internal const int k_MeshFormatVersionAutoUVScaleOffset = 2;

		[Token(Token = "0x40001B6")]
		public const uint maxVertexCount = 65535u;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_MeshFormatVersion;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_quads")]
		private Face[] m_Faces;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_sharedIndices")]
		[FormerlySerializedAs("m_SharedVertexes")]
		[SerializeField]
		private SharedVertex[] m_SharedVertices;

		[NonSerialized]
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CacheValidState m_CacheValid;

		[NonSerialized]
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> m_SharedVertexLookup;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_sharedIndicesUV")]
		private SharedVertex[] m_SharedTextures;

		[NonSerialized]
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, int> m_SharedTextureLookup;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("_vertices")]
		private Vector3[] m_Positions;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_uv")]
		private Vector2[] m_Textures0;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("_uv3")]
		[SerializeField]
		private List<Vector4> m_Textures2;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("_uv4")]
		private List<Vector4> m_Textures3;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_tangents")]
		[SerializeField]
		private Vector4[] m_Tangents;

		[NonSerialized]
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] m_Normals;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("_colors")]
		[SerializeField]
		private Color[] m_Colors;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[FormerlySerializedAs("unwrapParameters")]
		private UnwrapParameters m_UnwrapParameters;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[FormerlySerializedAs("dontDestroyMeshOnDelete")]
		private bool m_PreserveMeshAssetOnDestroy;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		internal string assetGuid;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Mesh m_Mesh;

		[NonSerialized]
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private MeshRenderer m_MeshRenderer;

		[NonSerialized]
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private MeshFilter m_MeshFilter;

		[Token(Token = "0x40001CC")]
		internal const ushort k_UnitializedVersionIndex = 0;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ushort m_VersionIndex;

		[NonSerialized]
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		private ushort m_InstanceVersionIndex;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static HashSet<int> s_CachedHashSet;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_IsSelectable;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int[] m_SelectedFaces;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Edge[] m_SelectedEdges;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int[] m_SelectedVertices;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_SelectedCacheDirty;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int m_SelectedSharedVerticesCount;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int m_SelectedCoincidentVertexCount;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HashSet<int> m_SelectedSharedVertices;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<int> m_SelectedCoincidentVertices;

		[Token(Token = "0x1700004C")]
		public bool userCollisions
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2B96CC8", Offset = "0x2B92CC8", VA = "0x2B96CC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2B96CD0", Offset = "0x2B92CD0", VA = "0x2B96CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public UnwrapParameters unwrapParameters
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2B96CD8", Offset = "0x2B92CD8", VA = "0x2B96CD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2B96CE0", Offset = "0x2B92CE0", VA = "0x2B96CE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		internal MeshRenderer renderer
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2B93FD8", Offset = "0x2B8FFD8", VA = "0x2B93FD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		internal MeshFilter filter
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2B96CE8", Offset = "0x2B92CE8", VA = "0x2B96CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		internal ushort versionIndex
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2B96D98", Offset = "0x2B92D98", VA = "0x2B96D98")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000051")]
		internal ushort nonSerializedVersionIndex
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2B96DA0", Offset = "0x2B92DA0", VA = "0x2B96DA0")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000052")]
		public bool preserveMeshAssetOnDestroy
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2B96DA8", Offset = "0x2B92DA8", VA = "0x2B96DA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2B96DB0", Offset = "0x2B92DB0", VA = "0x2B96DB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		internal Face[] facesInternal
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2B96DB8", Offset = "0x2B92DB8", VA = "0x2B96DB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2B96DC0", Offset = "0x2B92DC0", VA = "0x2B96DC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public IList<Face> faces
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2B96DC8", Offset = "0x2B92DC8", VA = "0x2B96DC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2B96E44", Offset = "0x2B92E44", VA = "0x2B96E44")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		internal SharedVertex[] sharedVerticesInternal
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2B97330", Offset = "0x2B93330", VA = "0x2B97330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2B97338", Offset = "0x2B93338", VA = "0x2B97338")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public IList<SharedVertex> sharedVertices
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2B97340", Offset = "0x2B93340", VA = "0x2B97340")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2B973BC", Offset = "0x2B933BC", VA = "0x2B973BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		internal Dictionary<int, int> sharedVertexLookup
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x2B975D8", Offset = "0x2B935D8", VA = "0x2B975D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		internal SharedVertex[] sharedTextures
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x2B976E8", Offset = "0x2B936E8", VA = "0x2B976E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2B976F0", Offset = "0x2B936F0", VA = "0x2B976F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		internal Dictionary<int, int> sharedTextureLookup
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2B976F8", Offset = "0x2B936F8", VA = "0x2B976F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		internal Vector3[] positionsInternal
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2B97804", Offset = "0x2B93804", VA = "0x2B97804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x2B9780C", Offset = "0x2B9380C", VA = "0x2B9780C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public IList<Vector3> positions
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x2B97814", Offset = "0x2B93814", VA = "0x2B97814")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2B97890", Offset = "0x2B93890", VA = "0x2B97890")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public IList<Vector3> normals
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x2B9859C", Offset = "0x2B9459C", VA = "0x2B9859C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		internal Vector3[] normalsInternal
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x2B9861C", Offset = "0x2B9461C", VA = "0x2B9861C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2B98624", Offset = "0x2B94624", VA = "0x2B98624")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		internal Color[] colorsInternal
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2B9862C", Offset = "0x2B9462C", VA = "0x2B9862C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2B98634", Offset = "0x2B94634", VA = "0x2B98634")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public IList<Color> colors
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2B9863C", Offset = "0x2B9463C", VA = "0x2B9863C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2B986BC", Offset = "0x2B946BC", VA = "0x2B986BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public IList<Vector4> tangents
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2B988F8", Offset = "0x2B948F8", VA = "0x2B988F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2B98990", Offset = "0x2B94990", VA = "0x2B98990")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		internal Vector4[] tangentsInternal
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2B98ACC", Offset = "0x2B94ACC", VA = "0x2B98ACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2B98AD4", Offset = "0x2B94AD4", VA = "0x2B98AD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		internal Vector2[] texturesInternal
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x2B98ADC", Offset = "0x2B94ADC", VA = "0x2B98ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x2B98AE4", Offset = "0x2B94AE4", VA = "0x2B98AE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		internal List<Vector4> textures2Internal
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2B98AEC", Offset = "0x2B94AEC", VA = "0x2B98AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x2B98AF4", Offset = "0x2B94AF4", VA = "0x2B98AF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		internal List<Vector4> textures3Internal
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2B98AFC", Offset = "0x2B94AFC", VA = "0x2B98AFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2B98B04", Offset = "0x2B94B04", VA = "0x2B98B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public IList<Vector2> textures
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2B98B0C", Offset = "0x2B94B0C", VA = "0x2B98B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x2B98B8C", Offset = "0x2B94B8C", VA = "0x2B98B8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int faceCount
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2B95564", Offset = "0x2B91564", VA = "0x2B95564")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000067")]
		public int vertexCount
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2B935A8", Offset = "0x2B8F5A8", VA = "0x2B935A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000068")]
		public int edgeCount
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2B990B8", Offset = "0x2B950B8", VA = "0x2B990B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000069")]
		public int indexCount
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2B99148", Offset = "0x2B95148", VA = "0x2B99148")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006A")]
		public int triangleCount
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2B99254", Offset = "0x2B95254", VA = "0x2B99254")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006B")]
		internal Mesh mesh
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2B9418C", Offset = "0x2B9018C", VA = "0x2B9418C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2B99CF0", Offset = "0x2B95CF0", VA = "0x2B99CF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[Obsolete("InstanceID is not used to track mesh references as of 2023/04/12")]
		internal int id
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x2B99CF8", Offset = "0x2B95CF8", VA = "0x2B99CF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006D")]
		public MeshSyncState meshSyncState
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2B99D18", Offset = "0x2B95D18", VA = "0x2B99D18")]
			get
			{
				return default(MeshSyncState);
			}
		}

		[Token(Token = "0x1700006E")]
		internal int meshFormatVersion
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x2B99DD4", Offset = "0x2B95DD4", VA = "0x2B99DD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006F")]
		public bool selectable
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2B9E40C", Offset = "0x2B9A40C", VA = "0x2B9E40C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2B9E414", Offset = "0x2B9A414", VA = "0x2B9E414")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int selectedFaceCount
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x2B9E41C", Offset = "0x2B9A41C", VA = "0x2B9E41C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public int selectedVertexCount
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2B9E434", Offset = "0x2B9A434", VA = "0x2B9E434")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public int selectedEdgeCount
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x2B9E44C", Offset = "0x2B9A44C", VA = "0x2B9E44C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000073")]
		internal int selectedSharedVerticesCount
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x2B9E464", Offset = "0x2B9A464", VA = "0x2B9E464")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		internal int selectedCoincidentVertexCount
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x2B9E71C", Offset = "0x2B9A71C", VA = "0x2B9E71C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		internal IEnumerable<int> selectedSharedVertices
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x2B9E734", Offset = "0x2B9A734", VA = "0x2B9E734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		internal IEnumerable<int> selectedCoincidentVertices
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2B9E74C", Offset = "0x2B9A74C", VA = "0x2B9E74C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public ReadOnlyCollection<int> selectedFaceIndexes
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x2B9E82C", Offset = "0x2B9A82C", VA = "0x2B9E82C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public ReadOnlyCollection<int> selectedVertices
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x2B9E8A8", Offset = "0x2B9A8A8", VA = "0x2B9E8A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public ReadOnlyCollection<Edge> selectedEdges
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x2B9E924", Offset = "0x2B9A924", VA = "0x2B9E924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		internal Face[] selectedFacesInternal
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2B9E9A0", Offset = "0x2B9A9A0", VA = "0x2B9E9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2B9E9A4", Offset = "0x2B9A9A4", VA = "0x2B9E9A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		internal int[] selectedFaceIndicesInternal
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2B9EA6C", Offset = "0x2B9AA6C", VA = "0x2B9EA6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2B9EA74", Offset = "0x2B9AA74", VA = "0x2B9EA74")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		internal Edge[] selectedEdgesInternal
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2B9EA7C", Offset = "0x2B9AA7C", VA = "0x2B9EA7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2B9EA84", Offset = "0x2B9AA84", VA = "0x2B9EA84")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		internal int[] selectedIndexesInternal
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2B9EA8C", Offset = "0x2B9AA8C", VA = "0x2B9EA8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2B9EA94", Offset = "0x2B9AA94", VA = "0x2B9EA94")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<ProBuilderMesh> meshWillBeDestroyed
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2B99370", Offset = "0x2B95370", VA = "0x2B99370")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x2B99460", Offset = "0x2B95460", VA = "0x2B99460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal static event Action<ProBuilderMesh> meshWasInitialized
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2B99550", Offset = "0x2B95550", VA = "0x2B99550")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2B99644", Offset = "0x2B95644", VA = "0x2B99644")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		internal static event Action<ProBuilderMesh> componentWillBeDestroyed
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2B99738", Offset = "0x2B95738", VA = "0x2B99738")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2B9982C", Offset = "0x2B9582C", VA = "0x2B9982C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		internal static event Action<ProBuilderMesh> componentHasBeenReset
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2B99920", Offset = "0x2B95920", VA = "0x2B99920")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2B99A14", Offset = "0x2B95A14", VA = "0x2B99A14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event Action<ProBuilderMesh> elementSelectionChanged
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2B99B08", Offset = "0x2B95B08", VA = "0x2B99B08")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2B99BFC", Offset = "0x2B95BFC", VA = "0x2B99BFC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2B927A8", Offset = "0x2B8E7A8", VA = "0x2B927A8")]
		public bool HasArrays(MeshArrays channels)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2B96EE4", Offset = "0x2B92EE4", VA = "0x2B96EE4")]
		internal void InvalidateSharedVertexLookup()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2B96F8C", Offset = "0x2B92F8C", VA = "0x2B96F8C")]
		internal void InvalidateSharedTextureLookup()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2B97034", Offset = "0x2B93034", VA = "0x2B97034")]
		internal void InvalidateFaces()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2B97304", Offset = "0x2B93304", VA = "0x2B97304")]
		internal void InvalidateCaches()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2B97674", Offset = "0x2B93674", VA = "0x2B97674")]
		internal void SetSharedVertices(IEnumerable<KeyValuePair<int, int>> indexes)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2B97790", Offset = "0x2B93790", VA = "0x2B97790")]
		internal void SetSharedTextures(IEnumerable<KeyValuePair<int, int>> indexes)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2B935FC", Offset = "0x2B8F5FC", VA = "0x2B935FC")]
		public Vertex[] GetVertices([Optional] IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2B97930", Offset = "0x2B93930", VA = "0x2B97930")]
		internal void GetVerticesInList(IList<Vertex> vertices)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2B98184", Offset = "0x2B94184", VA = "0x2B98184")]
		public void SetVertices(IList<Vertex> vertices, bool applyMesh = false)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2B92C9C", Offset = "0x2B8EC9C", VA = "0x2B92C9C")]
		public Vector3[] GetNormals()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2B98854", Offset = "0x2B94854", VA = "0x2B98854")]
		public Color[] GetColors()
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2B92D24", Offset = "0x2B8ED24", VA = "0x2B92D24")]
		public Vector4[] GetTangents()
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2B92988", Offset = "0x2B8E988", VA = "0x2B92988")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2B98CB4", Offset = "0x2B94CB4", VA = "0x2B98CB4")]
		internal ReadOnlyCollection<Vector2> GetUVs(int channel)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2B98DD8", Offset = "0x2B94DD8", VA = "0x2B98DD8")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2B99DDC", Offset = "0x2B95DDC", VA = "0x2B99DDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2B9A224", Offset = "0x2B96224", VA = "0x2B9A224")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2B9A2E4", Offset = "0x2B962E4", VA = "0x2B9A2E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2B9A468", Offset = "0x2B96468", VA = "0x2B9A468")]
		internal void DestroyUnityMesh()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2B9857C", Offset = "0x2B9457C", VA = "0x2B9857C")]
		private void IncrementVersionIndex()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2B98454", Offset = "0x2B94454", VA = "0x2B98454")]
		public void Clear()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2B99F48", Offset = "0x2B95F48", VA = "0x2B99F48")]
		internal void EnsureMeshFilterIsAssigned()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2B9A574", Offset = "0x2B96574", VA = "0x2B9A574")]
		internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2B9A880", Offset = "0x2B96880", VA = "0x2B9A880")]
		public static ProBuilderMesh Create()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2B9A910", Offset = "0x2B96910", VA = "0x2B9A910")]
		public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2B9AAF0", Offset = "0x2B96AF0", VA = "0x2B9AAF0")]
		public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, [Optional] IList<SharedVertex> sharedVertices, [Optional] IList<SharedVertex> sharedTextures, [Optional] IList<Material> materials)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2B9A68C", Offset = "0x2B9668C", VA = "0x2B9A68C")]
		internal void GeometryWithPoints(Vector3[] points)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2B9A9E0", Offset = "0x2B969E0", VA = "0x2B9A9E0")]
		public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2B935C0", Offset = "0x2B8F5C0", VA = "0x2B935C0")]
		internal void Rebuild()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2B9AC88", Offset = "0x2B96C88", VA = "0x2B9AC88")]
		public void ToMesh(MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2B9B344", Offset = "0x2B97344", VA = "0x2B9B344")]
		private void FinalizeToMesh(bool usedInParticleSystem)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2B9B38C", Offset = "0x2B9738C", VA = "0x2B9B38C")]
		public void MakeUnique()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2B9B548", Offset = "0x2B97548", VA = "0x2B9B548")]
		public void CopyFrom(ProBuilderMesh other)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2B9B234", Offset = "0x2B97234", VA = "0x2B9B234")]
		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2B9A06C", Offset = "0x2B9606C", VA = "0x2B9A06C")]
		internal void EnsureMeshColliderIsAssigned()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2B9BE74", Offset = "0x2B97E74", VA = "0x2B9BE74")]
		internal int GetUnusedTextureGroup(int i = 1)
		{
			return default(int);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2B9BF6C", Offset = "0x2B97F6C", VA = "0x2B9BF6C")]
		private static bool IsValidTextureGroup(int group)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2B9BF78", Offset = "0x2B97F78", VA = "0x2B9BF78")]
		internal int UnusedElementGroup(int i = 1)
		{
			return default(int);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2B9B828", Offset = "0x2B97828", VA = "0x2B9B828")]
		public void RefreshUV(IEnumerable<Face> facesToRefresh)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2B9C070", Offset = "0x2B98070", VA = "0x2B9C070")]
		internal void SetGroupUV(AutoUnwrapSettings settings, int group)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2B9BD64", Offset = "0x2B97D64", VA = "0x2B9BD64")]
		private void RefreshColors()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2B9C134", Offset = "0x2B98134", VA = "0x2B9C134")]
		public void SetFaceColor(Face face, Color color)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2B9C470", Offset = "0x2B98470", VA = "0x2B9C470")]
		public void SetMaterial(IEnumerable<Face> faces, Material material)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2B9BD94", Offset = "0x2B97D94", VA = "0x2B9BD94")]
		private void RefreshNormals()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2B9BE04", Offset = "0x2B97E04", VA = "0x2B9BE04")]
		private void RefreshTangents()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2B9C998", Offset = "0x2B98998", VA = "0x2B9C998")]
		internal int GetSharedVertexHandle(int vertex)
		{
			return default(int);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2B9CAF8", Offset = "0x2B98AF8", VA = "0x2B9CAF8")]
		internal HashSet<int> GetSharedVertexHandles(IEnumerable<int> vertices)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2B9CE50", Offset = "0x2B98E50", VA = "0x2B9CE50")]
		public List<int> GetCoincidentVertices(IEnumerable<int> vertices)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2B9D420", Offset = "0x2B99420", VA = "0x2B9D420")]
		public void GetCoincidentVertices(IEnumerable<Face> faces, List<int> coincident)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2B9D9D8", Offset = "0x2B999D8", VA = "0x2B9D9D8")]
		public void GetCoincidentVertices(IEnumerable<Edge> edges, List<int> coincident)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2B9CF1C", Offset = "0x2B98F1C", VA = "0x2B9CF1C")]
		public void GetCoincidentVertices(IEnumerable<int> vertices, List<int> coincident)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2B9E010", Offset = "0x2B9A010", VA = "0x2B9E010")]
		public void GetCoincidentVertices(int vertex, List<int> coincident)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2B9E1D8", Offset = "0x2B9A1D8", VA = "0x2B9E1D8")]
		public void SetVerticesCoincident(IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2B9E290", Offset = "0x2B9A290", VA = "0x2B9E290")]
		internal void SetTexturesCoincident(IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2B9E2D0", Offset = "0x2B9A2D0", VA = "0x2B9E2D0")]
		internal void AddToSharedVertex(int sharedVertexHandle, int vertex)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2B9E360", Offset = "0x2B9A360", VA = "0x2B9E360")]
		internal void AddSharedVertex(SharedVertex vertex)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2B9E47C", Offset = "0x2B9A47C", VA = "0x2B9E47C")]
		private void CacheSelection()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2B9E764", Offset = "0x2B9A764", VA = "0x2B9E764")]
		public Face[] GetSelectedFaces()
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2B9EA9C", Offset = "0x2B9AA9C", VA = "0x2B9EA9C")]
		internal Face GetActiveFace()
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2B9EAF4", Offset = "0x2B9AAF4", VA = "0x2B9EAF4")]
		internal Edge GetActiveEdge()
		{
			return default(Edge);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2B9EB78", Offset = "0x2B9AB78", VA = "0x2B9EB78")]
		internal int GetActiveVertex()
		{
			return default(int);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2B9EBAC", Offset = "0x2B9ABAC", VA = "0x2B9EBAC")]
		internal void AddToFaceSelection(int index)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2B9EE2C", Offset = "0x2B9AE2C", VA = "0x2B9EE2C")]
		public void SetSelectedFaces(IEnumerable<Face> selected)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2B9EC18", Offset = "0x2B9AC18", VA = "0x2B9EC18")]
		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2B9EEE8", Offset = "0x2B9AEE8", VA = "0x2B9EEE8")]
		public void SetSelectedEdges(IEnumerable<Edge> edges)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2B9F000", Offset = "0x2B9B000", VA = "0x2B9F000")]
		public void SetSelectedVertices(IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2B9F158", Offset = "0x2B9B158", VA = "0x2B9F158")]
		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2B9A16C", Offset = "0x2B9616C", VA = "0x2B9A16C")]
		public void ClearSelection()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2B9F1BC", Offset = "0x2B9B1BC", VA = "0x2B9F1BC")]
		public ProBuilderMesh()
		{
		}
	}
	[Token(Token = "0x2000058")]
	internal static class ProBuilderSnapping
	{
		[Token(Token = "0x40001EC")]
		private const float k_MaxRaySnapDistance = float.PositiveInfinity;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2B9F604", Offset = "0x2B9B604", VA = "0x2B9F604")]
		internal static bool IsCardinalDirection(Vector3 direction)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2B9F7E0", Offset = "0x2B9B7E0", VA = "0x2B9F7E0")]
		public static float Snap(float val, float snap)
		{
			return default(float);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2B9F880", Offset = "0x2B9B880", VA = "0x2B9F880")]
		public static Vector3 Snap(Vector3 val, Vector3 snap)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2B9F920", Offset = "0x2B9B920", VA = "0x2B9F920")]
		public static void SnapVertices(ProBuilderMesh mesh, IEnumerable<int> indexes, Vector3 snap)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2B9FCA0", Offset = "0x2B9BCA0", VA = "0x2B9FCA0")]
		internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2B9FD70", Offset = "0x2B9BD70", VA = "0x2B9FD70")]
		internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal sealed class ProGridsNoSnapAttribute : Attribute
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2BA043C", Offset = "0x2B9C43C", VA = "0x2BA043C")]
		public ProGridsNoSnapAttribute()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal sealed class ProGridsConditionalSnapAttribute : Attribute
	{
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2BA0444", Offset = "0x2B9C444", VA = "0x2BA0444")]
		public ProGridsConditionalSnapAttribute()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public static class Projection
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2BA044C", Offset = "0x2B9C44C", VA = "0x2BA044C")]
		public static Vector2[] PlanarProject(IList<Vector3> positions, [Optional] IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2BA0DE4", Offset = "0x2B9CDE4", VA = "0x2BA0DE4")]
		public static Vector2[] PlanarProject(IList<Vector3> positions, IList<int> indexes, Vector3 direction)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2BA0FA4", Offset = "0x2B9CFA4", VA = "0x2BA0FA4")]
		internal static void PlanarProject(IList<Vector3> positions, IList<int> indexes, Vector3 direction, List<Vector2> results)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2BA191C", Offset = "0x2B9D91C", VA = "0x2BA191C")]
		internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2BA1D94", Offset = "0x2B9DD94", VA = "0x2BA1D94")]
		internal static void PlanarProject(ProBuilderMesh mesh, Face face, [Optional] Vector3 projection)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2BA21A0", Offset = "0x2B9E1A0", VA = "0x2BA21A0")]
		internal static Vector2[] SphericalProject(IList<Vector3> vertices, [Optional] IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2BA256C", Offset = "0x2B9E56C", VA = "0x2BA256C")]
		internal static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2BA1860", Offset = "0x2B9D860", VA = "0x2BA1860")]
		internal static Vector3 GetTangentToAxis(ProjectionAxis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2BA2A44", Offset = "0x2B9EA44", VA = "0x2BA2A44")]
		internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2BA1744", Offset = "0x2B9D744", VA = "0x2BA1744")]
		internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction)
		{
			return default(ProjectionAxis);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2BA0474", Offset = "0x2B9C474", VA = "0x2BA0474")]
		public static Plane FindBestPlane(IList<Vector3> points, [Optional] IList<int> indexes)
		{
			return default(Plane);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2BA2BF4", Offset = "0x2B9EBF4", VA = "0x2BA2BF4")]
		internal static Plane FindBestPlane(ProBuilderMesh mesh, int textureGroup)
		{
			return default(Plane);
		}
	}
	[Token(Token = "0x200005D")]
	internal sealed class RaycastHit
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float distance;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 point;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 normal;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int face;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2BA31C0", Offset = "0x2B9F1C0", VA = "0x2BA31C0")]
		public RaycastHit(float distance, Vector3 point, Vector3 normal, int face)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public enum SelectionModifierBehavior
	{
		[Token(Token = "0x40001F5")]
		Add,
		[Token(Token = "0x40001F6")]
		Subtract,
		[Token(Token = "0x40001F7")]
		Difference
	}
	[Token(Token = "0x200005F")]
	public static class SelectionPicker
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2BA3234", Offset = "0x2B9F234", VA = "0x2BA3234")]
		public static Dictionary<ProBuilderMesh, HashSet<int>> PickVerticesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2BA41B8", Offset = "0x2BA01B8", VA = "0x2BA41B8")]
		public static Dictionary<ProBuilderMesh, HashSet<Face>> PickFacesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2BA569C", Offset = "0x2BA169C", VA = "0x2BA569C")]
		public static Dictionary<ProBuilderMesh, HashSet<Edge>> PickEdgesInRect(Camera cam, Rect rect, IList<ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint = 1f)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2BA66F0", Offset = "0x2BA26F0", VA = "0x2BA66F0")]
		public static Face PickFace(Camera camera, Vector3 mousePosition, ProBuilderMesh pickable)
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	public struct PickerOptions
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly PickerOptions k_Default;

		[Token(Token = "0x1700007E")]
		public bool depthTest
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2BA6790", Offset = "0x2BA2790", VA = "0x2BA6790")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2BA6798", Offset = "0x2BA2798", VA = "0x2BA6798")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public RectSelectMode rectSelectMode
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x2BA67A0", Offset = "0x2BA27A0", VA = "0x2BA67A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(RectSelectMode);
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x2BA67A8", Offset = "0x2BA27A8", VA = "0x2BA67A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public static PickerOptions Default
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x2BA67B0", Offset = "0x2BA27B0", VA = "0x2BA67B0")]
			get
			{
				return default(PickerOptions);
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2BA6808", Offset = "0x2BA2808", VA = "0x2BA6808", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2BA68B4", Offset = "0x2BA28B4", VA = "0x2BA68B4")]
		public bool Equals(PickerOptions other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2BA694C", Offset = "0x2BA294C", VA = "0x2BA694C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2BA69EC", Offset = "0x2BA29EC", VA = "0x2BA69EC")]
		public static bool operator ==(PickerOptions a, PickerOptions b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2BA6A58", Offset = "0x2BA2A58", VA = "0x2BA6A58")]
		public static bool operator !=(PickerOptions a, PickerOptions b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000061")]
	internal static class SelectionPickerRenderer
	{
		[Token(Token = "0x2000062")]
		internal interface ISelectionPickerRenderer
		{
			[Token(Token = "0x600030C")]
			Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height);
		}

		[Token(Token = "0x2000063")]
		internal class SelectionPickerRendererHDRP : ISelectionPickerRenderer
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2BA9018", Offset = "0x2BA5018", VA = "0x2BA9018", Slot = "4")]
			public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width = -1, int height = -1)
			{
				return null;
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2BA9020", Offset = "0x2BA5020", VA = "0x2BA9020")]
			public SelectionPickerRendererHDRP()
			{
			}
		}

		[Token(Token = "0x2000064")]
		internal class SelectionPickerRendererStandard : ISelectionPickerRenderer
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2BA9028", Offset = "0x2BA5028", VA = "0x2BA9028", Slot = "4")]
			public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width = -1, int height = -1)
			{
				return null;
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x2BA93EC", Offset = "0x2BA53EC", VA = "0x2BA93EC")]
			public SelectionPickerRendererStandard()
			{
			}
		}

		[Token(Token = "0x40001FB")]
		private const string k_FacePickerOcclusionTintUniform = "_Tint";

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color k_Blackf;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Color k_Whitef;

		[Token(Token = "0x40001FE")]
		private const uint k_PickerHashNone = 0u;

		[Token(Token = "0x40001FF")]
		private const uint k_PickerHashMin = 1u;

		[Token(Token = "0x4000200")]
		private const uint k_PickerHashMax = 16777215u;

		[Token(Token = "0x4000201")]
		private const uint k_MinEdgePixelsForValidSelection = 1u;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool s_Initialized;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static ISelectionPickerRenderer s_PickerRenderer;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static RenderTextureFormat s_RenderTextureFormat;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static RenderTextureFormat[] s_PreferredFormats;

		[Token(Token = "0x17000081")]
		private static RenderTextureFormat renderTextureFormat
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x2BA6B14", Offset = "0x2BA2B14", VA = "0x2BA6B14")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Token(Token = "0x17000082")]
		private static TextureFormat textureFormat
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x2BA6C5C", Offset = "0x2BA2C5C", VA = "0x2BA6C5C")]
			get
			{
				return default(TextureFormat);
			}
		}

		[Token(Token = "0x17000083")]
		private static ISelectionPickerRenderer pickerRenderer
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x2BA6C64", Offset = "0x2BA2C64", VA = "0x2BA6C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2BA50E8", Offset = "0x2BA10E8", VA = "0x2BA50E8")]
		public static Dictionary<ProBuilderMesh, HashSet<Face>> PickFacesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2BA385C", Offset = "0x2B9F85C", VA = "0x2BA385C")]
		public static Dictionary<ProBuilderMesh, HashSet<int>> PickVerticesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2BA5F70", Offset = "0x2BA1F70", VA = "0x2BA5F70")]
		public static Dictionary<ProBuilderMesh, HashSet<Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, IList<ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth = -1, int renderTextureHeight = -1)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2BA6D3C", Offset = "0x2BA2D3C", VA = "0x2BA6D3C")]
		internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Face>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2BA6FA4", Offset = "0x2BA2FA4", VA = "0x2BA6FA4")]
		internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, int>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2BA7274", Offset = "0x2BA3274", VA = "0x2BA7274")]
		internal static Texture2D RenderSelectionPickerTexture(Camera camera, IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Edge>> map, int width = -1, int height = -1)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2BA7544", Offset = "0x2BA3544", VA = "0x2BA7544")]
		private static GameObject[] GenerateFacePickingObjects(IList<ProBuilderMesh> selection, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Face>> map)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2BA7AC0", Offset = "0x2BA3AC0", VA = "0x2BA7AC0")]
		private static void GenerateVertexPickingObjects(IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, int>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2BA7F04", Offset = "0x2BA3F04", VA = "0x2BA7F04")]
		private static void GenerateEdgePickingObjects(IList<ProBuilderMesh> selection, bool doDepthTest, out Dictionary<uint, SimpleTuple<ProBuilderMesh, Edge>> map, out GameObject[] depthObjects, out GameObject[] pickerObjects)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2BA835C", Offset = "0x2BA435C", VA = "0x2BA835C")]
		private static Mesh BuildVertexMesh(ProBuilderMesh pb, Dictionary<uint, SimpleTuple<ProBuilderMesh, int>> map, ref uint index)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2BA8A80", Offset = "0x2BA4A80", VA = "0x2BA8A80")]
		private static Mesh BuildEdgeMesh(ProBuilderMesh pb, Dictionary<uint, SimpleTuple<ProBuilderMesh, Edge>> map, ref uint index)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2BA6F90", Offset = "0x2BA2F90", VA = "0x2BA6F90")]
		public static uint DecodeRGBA(Color32 color)
		{
			return default(uint);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2BA8348", Offset = "0x2BA4348", VA = "0x2BA8348")]
		public static Color32 EncodeRGBA(uint hash)
		{
			return default(Color32);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2BA6D34", Offset = "0x2BA2D34", VA = "0x2BA6D34")]
		private static bool ShouldUseHDRP()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000067")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SceneSelection : IEquatable<SceneSelection>
	{
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProBuilderMesh mesh;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> m_Vertices;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Edge> m_Edges;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Face> m_Faces;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Obsolete("Use SetSingleVertex")]
		public int vertex;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Obsolete("Use SetSingleEdge")]
		public Edge edge;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Obsolete("Use SetSingleFace")]
		public Face face;

		[Token(Token = "0x17000084")]
		public List<int> vertexes
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2BA95B4", Offset = "0x2BA55B4", VA = "0x2BA95B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2BA95BC", Offset = "0x2BA55BC", VA = "0x2BA95BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public List<Edge> edges
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2BA95C4", Offset = "0x2BA55C4", VA = "0x2BA95C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2BA95CC", Offset = "0x2BA55CC", VA = "0x2BA95CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public List<Face> faces
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2BA95D4", Offset = "0x2BA55D4", VA = "0x2BA95D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x2BA95DC", Offset = "0x2BA55DC", VA = "0x2BA95DC")]
			set
			{
			}
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2BA95E4", Offset = "0x2BA55E4", VA = "0x2BA95E4")]
		public SceneSelection([Optional] GameObject gameObject)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2BA96FC", Offset = "0x2BA56FC", VA = "0x2BA96FC")]
		public SceneSelection(ProBuilderMesh mesh, int vertex)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2BA991C", Offset = "0x2BA591C", VA = "0x2BA991C")]
		public SceneSelection(ProBuilderMesh mesh, Edge edge)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2BA9B3C", Offset = "0x2BA5B3C", VA = "0x2BA9B3C")]
		public SceneSelection(ProBuilderMesh mesh, Face face)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2BA97F8", Offset = "0x2BA57F8", VA = "0x2BA97F8")]
		internal SceneSelection(ProBuilderMesh mesh, List<int> vertexes)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2BA9A18", Offset = "0x2BA5A18", VA = "0x2BA9A18")]
		internal SceneSelection(ProBuilderMesh mesh, List<Edge> edges)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2BA9C38", Offset = "0x2BA5C38", VA = "0x2BA9C38")]
		internal SceneSelection(ProBuilderMesh mesh, List<Face> faces)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2BA9D5C", Offset = "0x2BA5D5C", VA = "0x2BA9D5C")]
		public void SetSingleFace(Face face)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2BA9E38", Offset = "0x2BA5E38", VA = "0x2BA9E38")]
		public void SetSingleVertex(int vertex)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2BA9EDC", Offset = "0x2BA5EDC", VA = "0x2BA9EDC")]
		public void SetSingleEdge(Edge edge)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2BA9F80", Offset = "0x2BA5F80", VA = "0x2BA9F80")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2BAA02C", Offset = "0x2BA602C", VA = "0x2BAA02C")]
		public void CopyTo(SceneSelection dst)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2BAA158", Offset = "0x2BA6158", VA = "0x2BAA158", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2BAA3D0", Offset = "0x2BA63D0", VA = "0x2BAA3D0", Slot = "4")]
		public bool Equals(SceneSelection other)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2BAA4BC", Offset = "0x2BA64BC", VA = "0x2BAA4BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2BAA5C8", Offset = "0x2BA65C8", VA = "0x2BAA5C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2BAA71C", Offset = "0x2BA671C", VA = "0x2BAA71C")]
		public static bool operator ==(SceneSelection left, SceneSelection right)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2BAA724", Offset = "0x2BA6724", VA = "0x2BAA724")]
		public static bool operator !=(SceneSelection left, SceneSelection right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000068")]
	internal struct VertexPickerEntry
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ProBuilderMesh mesh;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int vertex;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float screenDistance;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 worldPosition;
	}
	[Token(Token = "0x2000069")]
	internal static class SelectPathFaces
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] s_cachedPredecessors;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int s_cachedStart;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ProBuilderMesh s_cachedMesh;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int s_cachedFacesCount;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<WingedEdge> s_cachedWings;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Dictionary<Face, int> s_cachedFacesIndex;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2BAA740", Offset = "0x2BA6740", VA = "0x2BAA740")]
		public static List<int> GetPath(ProBuilderMesh mesh, int start, int end)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2BAAB08", Offset = "0x2BA6B08", VA = "0x2BAAB08")]
		private static int[] Dijkstra(ProBuilderMesh mesh, int start)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2BAB1C0", Offset = "0x2BA71C0", VA = "0x2BAB1C0")]
		private static float GetWeight(int face1, int face2, ProBuilderMesh mesh)
		{
			return default(float);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2BAA9E4", Offset = "0x2BA69E4", VA = "0x2BAA9E4")]
		private static List<int> GetMinimalPath(int[] predecessors, int start, int end)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	internal sealed class SemVer : IEquatable<SemVer>, IComparable<SemVer>, IComparable
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_Major;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_Minor;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Patch;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_Build;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_Type;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_Metadata;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Date;

		[Token(Token = "0x4000223")]
		public const string DefaultStringFormat = "M.m.p-t.b";

		[Token(Token = "0x17000087")]
		public int major
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2BAB660", Offset = "0x2BA7660", VA = "0x2BAB660")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		public int minor
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2BAB668", Offset = "0x2BA7668", VA = "0x2BAB668")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public int patch
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2BAB670", Offset = "0x2BA7670", VA = "0x2BAB670")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008A")]
		public int build
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2BAB678", Offset = "0x2BA7678", VA = "0x2BAB678")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008B")]
		public string type
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2BAB680", Offset = "0x2BA7680", VA = "0x2BAB680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public string metadata
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2BAB6D0", Offset = "0x2BA76D0", VA = "0x2BAB6D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public string date
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x2BAB720", Offset = "0x2BA7720", VA = "0x2BAB720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public SemVer MajorMinorPatch
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2BAB770", Offset = "0x2BA7770", VA = "0x2BAB770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2BAB860", Offset = "0x2BA7860", VA = "0x2BAB860")]
		public SemVer()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2BAB894", Offset = "0x2BA7894", VA = "0x2BAB894")]
		public SemVer(string formatted, [Optional] string date)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2BAB7F4", Offset = "0x2BA77F4", VA = "0x2BAB7F4")]
		public SemVer(int major, int minor, int patch, int build = -1, [Optional] string type, [Optional] string date, [Optional] string metadata)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2BABD1C", Offset = "0x2BA7D1C", VA = "0x2BABD1C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2BABD4C", Offset = "0x2BA7D4C", VA = "0x2BABD4C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2BABFC4", Offset = "0x2BA7FC4", VA = "0x2BABFC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2BABDBC", Offset = "0x2BA7DBC", VA = "0x2BABDBC", Slot = "4")]
		public bool Equals(SemVer version)
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2BAC19C", Offset = "0x2BA819C", VA = "0x2BAC19C", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2BAC3BC", Offset = "0x2BA83BC", VA = "0x2BAC3BC")]
		private static int WrapNoValue(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2BAC200", Offset = "0x2BA8200", VA = "0x2BAC200", Slot = "5")]
		public int CompareTo(SemVer version)
		{
			return default(int);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2BAC3CC", Offset = "0x2BA83CC", VA = "0x2BAC3CC")]
		public static bool operator ==(SemVer left, SemVer right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2BAC3E0", Offset = "0x2BA83E0", VA = "0x2BAC3E0")]
		public static bool operator !=(SemVer left, SemVer right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2BAC408", Offset = "0x2BA8408", VA = "0x2BAC408")]
		public static bool operator <(SemVer left, SemVer right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2BAC42C", Offset = "0x2BA842C", VA = "0x2BAC42C")]
		public static bool operator >(SemVer left, SemVer right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2BAC448", Offset = "0x2BA8448", VA = "0x2BAC448")]
		public static bool operator <=(SemVer left, SemVer right)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2BAC490", Offset = "0x2BA8490", VA = "0x2BAC490")]
		public static bool operator >=(SemVer left, SemVer right)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2BAC4E4", Offset = "0x2BA84E4", VA = "0x2BAC4E4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2BAC714", Offset = "0x2BA8714", VA = "0x2BAC714", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2BAB93C", Offset = "0x2BA793C", VA = "0x2BAB93C")]
		public static bool TryGetVersionInfo(string input, out SemVer version)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2BAC944", Offset = "0x2BA8944", VA = "0x2BAC944")]
		private static int GetBuildNumber(string input)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200006B")]
	public enum PivotLocation
	{
		[Token(Token = "0x4000225")]
		Center,
		[Token(Token = "0x4000226")]
		FirstCorner
	}
	[Token(Token = "0x200006C")]
	public static class ShapeFactory
	{
		[Token(Token = "0x600034F")]
		public static ProBuilderMesh Instantiate<T>(PivotLocation pivotType = PivotLocation.Center) where T : Shape, new()
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2BACA08", Offset = "0x2BA8A08", VA = "0x2BACA08")]
		public static ProBuilderMesh Instantiate(Type shapeType, PivotLocation pivotType = PivotLocation.Center)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2BACC94", Offset = "0x2BA8C94", VA = "0x2BACC94")]
		public static ProBuilderMesh Instantiate(Shape shape, PivotLocation pivotType = PivotLocation.Center)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public enum ShapeType
	{
		[Token(Token = "0x4000228")]
		Cube,
		[Token(Token = "0x4000229")]
		Stair,
		[Token(Token = "0x400022A")]
		CurvedStair,
		[Token(Token = "0x400022B")]
		Prism,
		[Token(Token = "0x400022C")]
		Cylinder,
		[Token(Token = "0x400022D")]
		Plane,
		[Token(Token = "0x400022E")]
		Door,
		[Token(Token = "0x400022F")]
		Pipe,
		[Token(Token = "0x4000230")]
		Cone,
		[Token(Token = "0x4000231")]
		Sprite,
		[Token(Token = "0x4000232")]
		Arch,
		[Token(Token = "0x4000233")]
		Sphere,
		[Token(Token = "0x4000234")]
		Torus
	}
	[Token(Token = "0x200006E")]
	public static class ShapeGenerator
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] k_IcosphereVertices;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] k_IcosphereTriangles;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Vector3[] k_CubeVertices;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int[] k_CubeTriangles;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2BACEE4", Offset = "0x2BA8EE4", VA = "0x2BACEE4")]
		public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType = PivotLocation.Center)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2BAD6A8", Offset = "0x2BA96A8", VA = "0x2BAD6A8")]
		public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2BAE014", Offset = "0x2BAA014", VA = "0x2BAE014")]
		public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2BB3E28", Offset = "0x2BAFE28", VA = "0x2BB3E28")]
		internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly)
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2BAD430", Offset = "0x2BA9430", VA = "0x2BAD430")]
		public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x2BAF284", Offset = "0x2BAB284", VA = "0x2BAF284")]
		public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2BAECF4", Offset = "0x2BAACF4", VA = "0x2BAECF4")]
		public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2BB00CC", Offset = "0x2BAC0CC", VA = "0x2BB00CC")]
		public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2BAFAD8", Offset = "0x2BABAD8", VA = "0x2BAFAD8")]
		public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2BB15D4", Offset = "0x2BAD5D4", VA = "0x2BB15D4")]
		public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2BB1CAC", Offset = "0x2BADCAC", VA = "0x2BB1CAC")]
		public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2BB266C", Offset = "0x2BAE66C", VA = "0x2BB266C")]
		public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2BB2D74", Offset = "0x2BAED74", VA = "0x2BB2D74")]
		public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices = true, bool manualUvs = true)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2BB4534", Offset = "0x2BB0534", VA = "0x2BB4534")]
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2BB5018", Offset = "0x2BB1018", VA = "0x2BB5018")]
		private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2BB37D4", Offset = "0x2BAF7D4", VA = "0x2BB37D4")]
		public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs = false)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public sealed class SharedVertex : ICollection<int>, IEnumerable<int>, IEnumerable
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("array")]
		[FormerlySerializedAs("m_Vertexes")]
		private int[] m_Vertices;

		[Token(Token = "0x1700008F")]
		internal int[] arrayInternal
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2BB56AC", Offset = "0x2BB16AC", VA = "0x2BB56AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public int this[int i]
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x2BA94D8", Offset = "0x2BA54D8", VA = "0x2BA94D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x2BB5798", Offset = "0x2BB1798", VA = "0x2BB5798")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public int Count
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x2BB5780", Offset = "0x2BB1780", VA = "0x2BB5780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000092")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x2BB5A94", Offset = "0x2BB1A94", VA = "0x2BB5A94", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2BB49EC", Offset = "0x2BB09EC", VA = "0x2BB49EC")]
		public SharedVertex(IEnumerable<int> indexes)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2BB56B4", Offset = "0x2BB16B4", VA = "0x2BB56B4")]
		public SharedVertex(SharedVertex sharedVertex)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2BB57C8", Offset = "0x2BB17C8", VA = "0x2BB57C8", Slot = "11")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2BB5868", Offset = "0x2BB1868", VA = "0x2BB5868", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2BB58D0", Offset = "0x2BB18D0", VA = "0x2BB58D0", Slot = "12")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2BB58D4", Offset = "0x2BB18D4", VA = "0x2BB58D4", Slot = "6")]
		public void Add(int item)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2BB5934", Offset = "0x2BB1934", VA = "0x2BB5934", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2BB5984", Offset = "0x2BB1984", VA = "0x2BB5984", Slot = "8")]
		public bool Contains(int item)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2BB59E8", Offset = "0x2BB19E8", VA = "0x2BB59E8", Slot = "9")]
		public void CopyTo(int[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2BB5A00", Offset = "0x2BB1A00", VA = "0x2BB5A00", Slot = "10")]
		public bool Remove(int item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2BB5AAC", Offset = "0x2BB1AAC", VA = "0x2BB5AAC")]
		public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<int, int> lookup)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2BB5E8C", Offset = "0x2BB1E8C", VA = "0x2BB5E8C")]
		internal void ShiftIndexes(int offset)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2BB5ECC", Offset = "0x2BB1ECC", VA = "0x2BB5ECC")]
		internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2BB656C", Offset = "0x2BB256C", VA = "0x2BB656C")]
		private static SharedVertex[] ToSharedVertices(List<List<int>> list)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2BB4A98", Offset = "0x2BB0A98", VA = "0x2BB4A98")]
		public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2BB66C0", Offset = "0x2BB26C0", VA = "0x2BB66C0")]
		internal static SharedVertex[] RemoveAndShift(Dictionary<int, int> lookup, IEnumerable<int> remove)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2BB6768", Offset = "0x2BB2768", VA = "0x2BB6768")]
		internal static SharedVertex[] SortedRemoveAndShift(Dictionary<int, int> lookup, List<int> remove)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2BB6AA0", Offset = "0x2BB2AA0", VA = "0x2BB6AA0")]
		internal static void SetCoincident(ref Dictionary<int, int> lookup, IEnumerable<int> vertices)
		{
		}
	}
	[Token(Token = "0x2000071")]
	public struct SimpleTuple<T1, T2>
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 m_Item1;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 m_Item2;

		[Token(Token = "0x17000093")]
		public T1 item1
		{
			[Token(Token = "0x600037D")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x600037E")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public T2 item2
		{
			[Token(Token = "0x600037F")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x6000380")]
			set
			{
			}
		}

		[Token(Token = "0x6000381")]
		public SimpleTuple(T1 item1, T2 item2)
		{
		}

		[Token(Token = "0x6000382")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000072")]
	internal struct SimpleTuple<T1, T2, T3>
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 m_Item1;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 m_Item2;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T3 m_Item3;

		[Token(Token = "0x17000095")]
		public T1 item1
		{
			[Token(Token = "0x6000383")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x6000384")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public T2 item2
		{
			[Token(Token = "0x6000385")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x6000386")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public T3 item3
		{
			[Token(Token = "0x6000387")]
			get
			{
				return (T3)null;
			}
			[Token(Token = "0x6000388")]
			set
			{
			}
		}

		[Token(Token = "0x6000389")]
		public SimpleTuple(T1 item1, T2 item2, T3 item3)
		{
		}

		[Token(Token = "0x600038A")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	public static class Smoothing
	{
		[Token(Token = "0x4000241")]
		internal const int smoothingGroupNone = 0;

		[Token(Token = "0x4000242")]
		internal const int smoothRangeMin = 1;

		[Token(Token = "0x4000243")]
		internal const int smoothRangeMax = 24;

		[Token(Token = "0x4000244")]
		internal const int hardRangeMin = 25;

		[Token(Token = "0x4000245")]
		internal const int hardRangeMax = 42;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2BB6E38", Offset = "0x2BB2E38", VA = "0x2BB6E38")]
		public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh)
		{
			return default(int);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2BB7010", Offset = "0x2BB3010", VA = "0x2BB7010")]
		private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used)
		{
			return default(int);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2BB70C0", Offset = "0x2BB30C0", VA = "0x2BB70C0")]
		public static bool IsSmooth(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2BB70D4", Offset = "0x2BB30D4", VA = "0x2BB70D4")]
		public static void ApplySmoothingGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, float angleThreshold)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2BB70DC", Offset = "0x2BB30DC", VA = "0x2BB70DC")]
		internal static void ApplySmoothingGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, float angleThreshold, Vector3[] normals)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2BB78E8", Offset = "0x2BB38E8", VA = "0x2BB78E8")]
		private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, HashSet<Face> processed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2BB7B84", Offset = "0x2BB3B84", VA = "0x2BB7B84")]
		private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000075")]
	internal static class Spline
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2BB7FA0", Offset = "0x2BB3FA0", VA = "0x2BB7FA0")]
		internal static ProBuilderMesh Extrude(IList<BezierPoint> points, float radius = 0.5f, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2BB7FB8", Offset = "0x2BB3FB8", VA = "0x2BB7FB8")]
		internal static void Extrude(IList<BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref ProBuilderMesh target)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2BB8084", Offset = "0x2BB4084", VA = "0x2BB8084")]
		internal static List<Vector3> GetControlPoints(IList<BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, List<Quaternion> rotations)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2BB85A0", Offset = "0x2BB45A0", VA = "0x2BB85A0")]
		internal static void Extrude(IList<Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ref ProBuilderMesh target, [Optional] IList<Quaternion> pointRotations)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2BB8F10", Offset = "0x2BB4F10", VA = "0x2BB8F10")]
		private static Quaternion GetRingRotation(IList<Vector3> points, int i, bool closeLoop, out float secant)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2BB979C", Offset = "0x2BB579C", VA = "0x2BB979C")]
		private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public sealed class Submesh
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal int[] m_Indexes;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal MeshTopology m_Topology;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal int m_SubmeshIndex;

		[Token(Token = "0x17000098")]
		public IEnumerable<int> indexes
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x2BB9994", Offset = "0x2BB5994", VA = "0x2BB9994")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2BB9A10", Offset = "0x2BB5A10", VA = "0x2BB9A10")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public MeshTopology topology
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2BB9A6C", Offset = "0x2BB5A6C", VA = "0x2BB9A6C")]
			get
			{
				return default(MeshTopology);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x2BB9A74", Offset = "0x2BB5A74", VA = "0x2BB9A74")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int submeshIndex
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x2BB9A7C", Offset = "0x2BB5A7C", VA = "0x2BB9A7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2BB9A84", Offset = "0x2BB5A84", VA = "0x2BB9A84")]
			set
			{
			}
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2BB9A8C", Offset = "0x2BB5A8C", VA = "0x2BB9A8C")]
		public Submesh(int submeshIndex, MeshTopology topology, IEnumerable<int> indexes)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2BB9B4C", Offset = "0x2BB5B4C", VA = "0x2BB9B4C")]
		public Submesh(Mesh mesh, int subMeshIndex)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2BB9C44", Offset = "0x2BB5C44", VA = "0x2BB9C44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2BB9D4C", Offset = "0x2BB5D4C", VA = "0x2BB9D4C")]
		internal static int GetSubmeshCount(ProBuilderMesh mesh)
		{
			return default(int);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2BB9DBC", Offset = "0x2BB5DBC", VA = "0x2BB9DBC")]
		public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2BBA6C4", Offset = "0x2BB66C4", VA = "0x2BBA6C4")]
		internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh)
		{
		}
	}
	[Token(Token = "0x2000077")]
	internal sealed class Transform2D
	{
		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 position;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotation;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 scale;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2BBA7F0", Offset = "0x2BB67F0", VA = "0x2BBA7F0")]
		public Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2BBA840", Offset = "0x2BB6840", VA = "0x2BBA840")]
		public Vector2 TransformPoint(Vector2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2BBA8A4", Offset = "0x2BB68A4", VA = "0x2BBA8A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public static class TransformUtility
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Transform, Transform[]> s_ChildStack;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2BBA9F4", Offset = "0x2BB69F4", VA = "0x2BBA9F4")]
		internal static void UnparentChildren(Transform t)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2BBAB58", Offset = "0x2BB6B58", VA = "0x2BBAB58")]
		internal static void ReparentChildren(Transform t)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2BBAC88", Offset = "0x2BB6C88", VA = "0x2BBAC88")]
		public static Vertex TransformVertex(this Transform transform, Vertex vertex)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2BBAE88", Offset = "0x2BB6E88", VA = "0x2BBAE88")]
		public static Vertex InverseTransformVertex(this Transform transform, Vertex vertex)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	internal struct Triangle : IEquatable<Triangle>
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int m_A;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int m_B;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int m_C;

		[Token(Token = "0x1700009B")]
		public int a
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x2BBB10C", Offset = "0x2BB710C", VA = "0x2BBB10C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009C")]
		public int b
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x2BBB114", Offset = "0x2BB7114", VA = "0x2BBB114")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009D")]
		public int c
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2BBB11C", Offset = "0x2BB711C", VA = "0x2BBB11C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009E")]
		public IEnumerable<int> indices
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2BBB124", Offset = "0x2BB7124", VA = "0x2BBB124")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2BBB1AC", Offset = "0x2BB71AC", VA = "0x2BBB1AC")]
		public Triangle(int a, int b, int c)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2BBB1B8", Offset = "0x2BB71B8", VA = "0x2BBB1B8", Slot = "4")]
		public bool Equals(Triangle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2BBB1EC", Offset = "0x2BB71EC", VA = "0x2BBB1EC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2BBB284", Offset = "0x2BB7284", VA = "0x2BBB284", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2BBB2A4", Offset = "0x2BB72A4", VA = "0x2BBB2A4")]
		public bool IsAdjacent(Triangle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2BBB338", Offset = "0x2BB7338", VA = "0x2BBB338")]
		private bool ContainsEdge(Edge edge)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007A")]
	[DisallowMultipleComponent]
	internal sealed class TriggerBehaviour : EntityBehaviour
	{
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2BBB438", Offset = "0x2BB7438", VA = "0x2BBB438", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2BBB5D4", Offset = "0x2BB75D4", VA = "0x2BBB5D4", Slot = "5")]
		public override void OnEnterPlayMode()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2BBB64C", Offset = "0x2BB764C", VA = "0x2BBB64C", Slot = "6")]
		public override void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2BBB6C4", Offset = "0x2BB76C4", VA = "0x2BBB6C4")]
		public TriggerBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public sealed class UnwrapParameters
	{
		[Token(Token = "0x4000253")]
		internal const float k_HardAngle = 88f;

		[Token(Token = "0x4000254")]
		internal const float k_PackMargin = 20f;

		[Token(Token = "0x4000255")]
		internal const float k_AngleError = 8f;

		[Token(Token = "0x4000256")]
		internal const float k_AreaError = 15f;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("hardAngle")]
		[SerializeField]
		[Range(1f, 180f)]
		[Tooltip("Angle between neighbor triangles that will generate seam.")]
		private float m_HardAngle;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("packMargin")]
		[SerializeField]
		[Range(1f, 64f)]
		[Tooltip("Measured in pixels, assuming mesh will cover an entire 1024x1024 lightmap.")]
		private float m_PackMargin;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 75f)]
		[Tooltip("Measured in percents. Angle error measures deviation of UV angles from geometry angles. Area error measures deviation of UV triangles area from geometry triangles if they were uniformly scaled.")]
		[SerializeField]
		[FormerlySerializedAs("angleError")]
		private float m_AngleError;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(1f, 75f)]
		[FormerlySerializedAs("areaError")]
		[SerializeField]
		private float m_AreaError;

		[Token(Token = "0x1700009F")]
		public float hardAngle
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2BBB6CC", Offset = "0x2BB76CC", VA = "0x2BBB6CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x2BBB6D4", Offset = "0x2BB76D4", VA = "0x2BBB6D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public float packMargin
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x2BBB6DC", Offset = "0x2BB76DC", VA = "0x2BBB6DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x2BBB6E4", Offset = "0x2BB76E4", VA = "0x2BBB6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float angleError
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x2BBB6EC", Offset = "0x2BB76EC", VA = "0x2BBB6EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x2BBB6F4", Offset = "0x2BB76F4", VA = "0x2BBB6F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float areaError
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x2BBB6FC", Offset = "0x2BB76FC", VA = "0x2BBB6FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x2BBB704", Offset = "0x2BB7704", VA = "0x2BBB704")]
			set
			{
			}
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2BB4304", Offset = "0x2BB0304", VA = "0x2BB4304")]
		public UnwrapParameters()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2BBB71C", Offset = "0x2BB771C", VA = "0x2BBB71C")]
		public UnwrapParameters(UnwrapParameters other)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2BBB70C", Offset = "0x2BB770C", VA = "0x2BBB70C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2BBB7A0", Offset = "0x2BB77A0", VA = "0x2BBB7A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	internal static class UvUnwrapping
	{
		[Token(Token = "0x200007D")]
		internal struct UVTransform
		{
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 translation;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float rotation;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector2 scale;

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2BBD980", Offset = "0x2BB9980", VA = "0x2BBD980", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Vector2> s_UVTransformProjectionBuffer;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector2 s_TempVector2;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<int> s_IndexBuffer;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2BBB94C", Offset = "0x2BB794C", VA = "0x2BBB94C")]
		internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2BBBAEC", Offset = "0x2BB7AEC", VA = "0x2BBBAEC")]
		internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, IEnumerable<Face> facesToConvert)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2BBC118", Offset = "0x2BB8118", VA = "0x2BBC118")]
		internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face)
		{
			return default(AutoUnwrapSettings);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2BBC21C", Offset = "0x2BB821C", VA = "0x2BBC21C")]
		internal static UVTransform GetUVTransform(ProBuilderMesh mesh, Face face)
		{
			return default(UVTransform);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2BBC308", Offset = "0x2BB8308", VA = "0x2BBC308")]
		private static int GetIndex(IList<int> collection, int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2BBBCCC", Offset = "0x2BB7CCC", VA = "0x2BBBCCC")]
		internal static UVTransform CalculateDelta(IList<Vector2> src, IList<int> srcIndices, IList<Vector2> dst, IList<int> dstIndices)
		{
			return default(UVTransform);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2BBC3B8", Offset = "0x2BB83B8", VA = "0x2BBC3B8")]
		private static Vector2 GetRotatedSize(IList<Vector2> points, IList<int> indices, Vector2 center, float rotation)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2BB433C", Offset = "0x2BB033C", VA = "0x2BB433C")]
		internal static void Unwrap(ProBuilderMesh mesh, Face face, [Optional] Vector3 projection)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2BB4478", Offset = "0x2BB0478", VA = "0x2BB4478")]
		internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2BBCFF4", Offset = "0x2BB8FF4", VA = "0x2BBCFF4")]
		internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2BBC6BC", Offset = "0x2BB86BC", VA = "0x2BBC6BC")]
		private static void ApplyUVSettings(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings uvSettings)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2BBD190", Offset = "0x2BB9190", VA = "0x2BBD190")]
		private static void ScaleUVs(Vector2[] uvs, IList<int> indexes, Vector2 scale, Bounds2D bounds)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2BBD3A8", Offset = "0x2BB93A8", VA = "0x2BBD3A8")]
		private static void ApplyUVAnchor(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings.Anchor anchor)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2BBD738", Offset = "0x2BB9738", VA = "0x2BBD738")]
		internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh)
		{
		}
	}
	[Token(Token = "0x200007F")]
	internal static class VectorHash
	{
		[Token(Token = "0x4000263")]
		public const float FltCompareResolution = 1000f;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2BBDB10", Offset = "0x2BB9B10", VA = "0x2BBDB10")]
		private static int HashFloat(float f)
		{
			return default(int);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2BBDB50", Offset = "0x2BB9B50", VA = "0x2BBDB50")]
		public static int GetHashCode(Vector2 v)
		{
			return default(int);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2BA9508", Offset = "0x2BA5508", VA = "0x2BA9508")]
		public static int GetHashCode(Vector3 v)
		{
			return default(int);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2BBDBCC", Offset = "0x2BB9BCC", VA = "0x2BBDBCC")]
		public static int GetHashCode(Vector4 v)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000080")]
	internal struct Vector2Mask
	{
		[Token(Token = "0x4000264")]
		private const byte X = 1;

		[Token(Token = "0x4000265")]
		private const byte Y = 2;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2Mask XY;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte m_Mask;

		[Token(Token = "0x170000A3")]
		public float x
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x2BBDCAC", Offset = "0x2BB9CAC", VA = "0x2BBDCAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		public float y
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x2BBDCC4", Offset = "0x2BB9CC4", VA = "0x2BBDCC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2BBDCDC", Offset = "0x2BB9CDC", VA = "0x2BBDCDC")]
		public Vector2Mask(Vector3 v, float epsilon = float.Epsilon)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2BBDD04", Offset = "0x2BB9D04", VA = "0x2BBDD04")]
		public Vector2Mask(byte mask)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2BBDD0C", Offset = "0x2BB9D0C", VA = "0x2BBDD0C")]
		public static implicit operator Vector2(Vector2Mask mask)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2BBDD74", Offset = "0x2BB9D74", VA = "0x2BBDD74")]
		public static implicit operator Vector2Mask(Vector2 v)
		{
			return default(Vector2Mask);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2BBDDA0", Offset = "0x2BB9DA0", VA = "0x2BBDDA0")]
		public static Vector2Mask operator |(Vector2Mask left, Vector2Mask right)
		{
			return default(Vector2Mask);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2BBDDA8", Offset = "0x2BB9DA8", VA = "0x2BBDDA8")]
		public static Vector2Mask operator &(Vector2Mask left, Vector2Mask right)
		{
			return default(Vector2Mask);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2BBDDB0", Offset = "0x2BB9DB0", VA = "0x2BBDDB0")]
		public static Vector2Mask operator ^(Vector2Mask left, Vector2Mask right)
		{
			return default(Vector2Mask);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2BBDDB8", Offset = "0x2BB9DB8", VA = "0x2BBDDB8")]
		public static Vector2 operator *(Vector2Mask mask, float value)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x2000081")]
	internal struct Vector3Mask : IEquatable<Vector3Mask>
	{
		[Token(Token = "0x4000268")]
		private const byte X = 1;

		[Token(Token = "0x4000269")]
		private const byte Y = 2;

		[Token(Token = "0x400026A")]
		private const byte Z = 4;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3Mask XYZ;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte m_Mask;

		[Token(Token = "0x170000A5")]
		public float x
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x2BBDE90", Offset = "0x2BB9E90", VA = "0x2BBDE90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A6")]
		public float y
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2BBDEA8", Offset = "0x2BB9EA8", VA = "0x2BBDEA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A7")]
		public float z
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2BBDEC0", Offset = "0x2BB9EC0", VA = "0x2BBDEC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A8")]
		public int active
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x2BBE028", Offset = "0x2BBA028", VA = "0x2BBE028")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A9")]
		public float this[int i]
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x2BBE42C", Offset = "0x2BBA42C", VA = "0x2BBE42C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x2BBE480", Offset = "0x2BBA480", VA = "0x2BBE480")]
			set
			{
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2BBDED8", Offset = "0x2BB9ED8", VA = "0x2BBDED8")]
		public Vector3Mask(Vector3 v, float epsilon = float.Epsilon)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2BBDF10", Offset = "0x2BB9F10", VA = "0x2BBDF10")]
		public Vector3Mask(byte mask)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2BBDF18", Offset = "0x2BB9F18", VA = "0x2BBDF18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2BBE044", Offset = "0x2BBA044", VA = "0x2BBE044")]
		public static implicit operator Vector3(Vector3Mask mask)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2BBE0B4", Offset = "0x2BBA0B4", VA = "0x2BBE0B4")]
		public static explicit operator Vector3Mask(Vector3 v)
		{
			return default(Vector3Mask);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2BBE0F0", Offset = "0x2BBA0F0", VA = "0x2BBE0F0")]
		public static Vector3Mask operator |(Vector3Mask left, Vector3Mask right)
		{
			return default(Vector3Mask);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2BBE0F8", Offset = "0x2BBA0F8", VA = "0x2BBE0F8")]
		public static Vector3Mask operator &(Vector3Mask left, Vector3Mask right)
		{
			return default(Vector3Mask);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2BBE100", Offset = "0x2BBA100", VA = "0x2BBE100")]
		public static Vector3Mask operator ^(Vector3Mask left, Vector3Mask right)
		{
			return default(Vector3Mask);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2BBE108", Offset = "0x2BBA108", VA = "0x2BBE108")]
		public static Vector3 operator *(Vector3Mask mask, float value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2BBE1AC", Offset = "0x2BBA1AC", VA = "0x2BBE1AC")]
		public static Vector3 operator *(Vector3Mask mask, Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2BBE244", Offset = "0x2BBA244", VA = "0x2BBE244")]
		public static Vector3 operator *(Quaternion rotation, Vector3Mask mask)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2BBE3B4", Offset = "0x2BBA3B4", VA = "0x2BBE3B4")]
		public static bool operator ==(Vector3Mask left, Vector3Mask right)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2BBE3C4", Offset = "0x2BBA3C4", VA = "0x2BBE3C4")]
		public static bool operator !=(Vector3Mask left, Vector3Mask right)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2BBE4E8", Offset = "0x2BBA4E8", VA = "0x2BBE4E8", Slot = "4")]
		public bool Equals(Vector3Mask other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2BBE4F8", Offset = "0x2BBA4F8", VA = "0x2BBE4F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2BBE5A0", Offset = "0x2BBA5A0", VA = "0x2BBE5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public sealed class Vertex : IEquatable<Vertex>
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color m_Color;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 m_Normal;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector4 m_Tangent;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_UV0;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 m_UV2;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector4 m_UV3;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector4 m_UV4;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MeshArrays m_Attributes;

		[Token(Token = "0x170000AA")]
		public Vector3 position
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x2BBE5F4", Offset = "0x2BBA5F4", VA = "0x2BBE5F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x2BBE600", Offset = "0x2BBA600", VA = "0x2BBE600")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public Color color
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x2BBE628", Offset = "0x2BBA628", VA = "0x2BBE628")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x2BBE634", Offset = "0x2BBA634", VA = "0x2BBE634")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public Vector3 normal
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x2BBE66C", Offset = "0x2BBA66C", VA = "0x2BBE66C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x2BBE678", Offset = "0x2BBA678", VA = "0x2BBE678")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public Vector4 tangent
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x2BBE6B0", Offset = "0x2BBA6B0", VA = "0x2BBE6B0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x2BBE6BC", Offset = "0x2BBA6BC", VA = "0x2BBE6BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public Vector2 uv0
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x2BBE6F4", Offset = "0x2BBA6F4", VA = "0x2BBE6F4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x2BBE6FC", Offset = "0x2BBA6FC", VA = "0x2BBE6FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Vector2 uv2
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x2BBE730", Offset = "0x2BBA730", VA = "0x2BBE730")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x2BBE738", Offset = "0x2BBA738", VA = "0x2BBE738")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public Vector4 uv3
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x2BBE76C", Offset = "0x2BBA76C", VA = "0x2BBE76C")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x2BBE778", Offset = "0x2BBA778", VA = "0x2BBE778")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public Vector4 uv4
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x2BBE7B0", Offset = "0x2BBA7B0", VA = "0x2BBE7B0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x2BBE7BC", Offset = "0x2BBA7BC", VA = "0x2BBE7BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		internal MeshArrays attributes
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x2BBE7F4", Offset = "0x2BBA7F4", VA = "0x2BBE7F4")]
			get
			{
				return default(MeshArrays);
			}
		}

		[Token(Token = "0x170000B3")]
		private bool hasPosition
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x2BBE80C", Offset = "0x2BBA80C", VA = "0x2BBE80C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x2BBE618", Offset = "0x2BBA618", VA = "0x2BBE618")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		private bool hasColor
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x2BBE818", Offset = "0x2BBA818", VA = "0x2BBE818")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x2BBE64C", Offset = "0x2BBA64C", VA = "0x2BBE64C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		private bool hasNormal
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x2BBE824", Offset = "0x2BBA824", VA = "0x2BBE824")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x2BBE690", Offset = "0x2BBA690", VA = "0x2BBE690")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		private bool hasTangent
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x2BBE830", Offset = "0x2BBA830", VA = "0x2BBE830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x2BBE6D4", Offset = "0x2BBA6D4", VA = "0x2BBE6D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		private bool hasUV0
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x2BBE83C", Offset = "0x2BBA83C", VA = "0x2BBE83C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x2BBE710", Offset = "0x2BBA710", VA = "0x2BBE710")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		private bool hasUV2
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2BBE848", Offset = "0x2BBA848", VA = "0x2BBE848")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x2BBE74C", Offset = "0x2BBA74C", VA = "0x2BBE74C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		private bool hasUV3
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x2BBE854", Offset = "0x2BBA854", VA = "0x2BBE854")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x2BBE790", Offset = "0x2BBA790", VA = "0x2BBE790")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		private bool hasUV4
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x2BBE860", Offset = "0x2BBA860", VA = "0x2BBE860")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x2BBE7D4", Offset = "0x2BBA7D4", VA = "0x2BBE7D4")]
			set
			{
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2BBE7FC", Offset = "0x2BBA7FC", VA = "0x2BBE7FC")]
		public bool HasArrays(MeshArrays attribute)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2BBE86C", Offset = "0x2BBA86C", VA = "0x2BBE86C")]
		public Vertex()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2BBE874", Offset = "0x2BBA874", VA = "0x2BBE874", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2BBE8E4", Offset = "0x2BBA8E4", VA = "0x2BBE8E4", Slot = "4")]
		public bool Equals(Vertex other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2BBEA2C", Offset = "0x2BBAA2C", VA = "0x2BBEA2C")]
		public bool Equals(Vertex other, MeshArrays mask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2BBEBA8", Offset = "0x2BBABA8", VA = "0x2BBEBA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2BBEC0C", Offset = "0x2BBAC0C", VA = "0x2BBEC0C")]
		public Vertex(Vertex vertex)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2BBED4C", Offset = "0x2BBAD4C", VA = "0x2BBED4C")]
		public static bool operator ==(Vertex a, Vertex b)
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2BBED74", Offset = "0x2BBAD74", VA = "0x2BBED74")]
		public static bool operator !=(Vertex a, Vertex b)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2BBEDA8", Offset = "0x2BBADA8", VA = "0x2BBEDA8")]
		public static Vertex operator +(Vertex a, Vertex b)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2BBEDAC", Offset = "0x2BBADAC", VA = "0x2BBEDAC")]
		public static Vertex Add(Vertex a, Vertex b)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2BBEE24", Offset = "0x2BBAE24", VA = "0x2BBEE24")]
		public void Add(Vertex b)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2BBEF14", Offset = "0x2BBAF14", VA = "0x2BBEF14")]
		public static Vertex operator -(Vertex a, Vertex b)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2BBEF18", Offset = "0x2BBAF18", VA = "0x2BBEF18")]
		public static Vertex Subtract(Vertex a, Vertex b)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2BBEF90", Offset = "0x2BBAF90", VA = "0x2BBEF90")]
		public void Subtract(Vertex b)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x2BBF080", Offset = "0x2BBB080", VA = "0x2BBF080")]
		public static Vertex operator *(Vertex a, float value)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2BBF084", Offset = "0x2BBB084", VA = "0x2BBF084")]
		public static Vertex Multiply(Vertex a, float value)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2BBF0FC", Offset = "0x2BBB0FC", VA = "0x2BBF0FC")]
		public void Multiply(float value)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2BBF140", Offset = "0x2BBB140", VA = "0x2BBF140")]
		public static Vertex operator /(Vertex a, float value)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2BBF144", Offset = "0x2BBB144", VA = "0x2BBF144")]
		public static Vertex Divide(Vertex a, float value)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2BBF1BC", Offset = "0x2BBB1BC", VA = "0x2BBF1BC")]
		public void Divide(float value)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2BBF200", Offset = "0x2BBB200", VA = "0x2BBF200")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2BBF724", Offset = "0x2BBB724", VA = "0x2BBF724")]
		public string ToString([Optional] string args)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2BBFA5C", Offset = "0x2BBBA5C", VA = "0x2BBFA5C")]
		public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2BBFA84", Offset = "0x2BBBA84", VA = "0x2BBFA84")]
		public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, MeshArrays attributes)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2BC0420", Offset = "0x2BBC420", VA = "0x2BC0420")]
		public static void SetMesh(Mesh mesh, IList<Vertex> vertices)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2BC06E4", Offset = "0x2BBC6E4", VA = "0x2BC06E4")]
		public static Vertex Average(IList<Vertex> vertices, [Optional] IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2BC1264", Offset = "0x2BBD264", VA = "0x2BC1264")]
		public static Vertex Mix(Vertex x, Vertex y, float weight)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public static class VertexPositioning
	{
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<int> s_CoincidentVertices;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2BC1548", Offset = "0x2BBD548", VA = "0x2BC1548")]
		public static Vector3[] VerticesInWorldSpace(this ProBuilderMesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2BC16C0", Offset = "0x2BBD6C0", VA = "0x2BC16C0")]
		public static void TranslateVerticesInWorldSpace(this ProBuilderMesh mesh, int[] indexes, Vector3 offset)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2BC17D4", Offset = "0x2BBD7D4", VA = "0x2BC17D4")]
		internal static void TranslateVerticesInWorldSpace(this ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2BC1C70", Offset = "0x2BBDC70", VA = "0x2BC1C70")]
		public static void TranslateVertices(this ProBuilderMesh mesh, IEnumerable<int> indexes, Vector3 offset)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2BC1F00", Offset = "0x2BBDF00", VA = "0x2BC1F00")]
		public static void TranslateVertices(this ProBuilderMesh mesh, IEnumerable<Edge> edges, Vector3 offset)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2BC202C", Offset = "0x2BBE02C", VA = "0x2BC202C")]
		public static void TranslateVertices(this ProBuilderMesh mesh, IEnumerable<Face> faces, Vector3 offset)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2BC1D9C", Offset = "0x2BBDD9C", VA = "0x2BC1D9C")]
		private static void TranslateVerticesInternal(ProBuilderMesh mesh, IEnumerable<int> indices, Vector3 offset)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2BC2158", Offset = "0x2BBE158", VA = "0x2BC2158")]
		public static void SetSharedVertexPosition(this ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x2BC24B8", Offset = "0x2BBE4B8", VA = "0x2BC24B8")]
		internal static void SetSharedVertexValues(this ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex)
		{
		}
	}
	[Token(Token = "0x2000084")]
	public sealed class WingedEdge : IEquatable<WingedEdge>
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Edge, WingedEdge> k_OppositeEdgeDictionary;

		[Token(Token = "0x170000BB")]
		public EdgeLookup edge
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2BC27F0", Offset = "0x2BBE7F0", VA = "0x2BC27F0")]
			[CompilerGenerated]
			get
			{
				return default(EdgeLookup);
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2BC27FC", Offset = "0x2BBE7FC", VA = "0x2BC27FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public Face face
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2BC2804", Offset = "0x2BBE804", VA = "0x2BC2804")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2BC280C", Offset = "0x2BBE80C", VA = "0x2BC280C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public WingedEdge next
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x2BC2814", Offset = "0x2BBE814", VA = "0x2BC2814")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x2BC281C", Offset = "0x2BBE81C", VA = "0x2BC281C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public WingedEdge previous
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x2BC2824", Offset = "0x2BBE824", VA = "0x2BC2824")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x2BC282C", Offset = "0x2BBE82C", VA = "0x2BC282C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public WingedEdge opposite
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x2BC2834", Offset = "0x2BBE834", VA = "0x2BC2834")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2BC283C", Offset = "0x2BBE83C", VA = "0x2BC283C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2BC2844", Offset = "0x2BBE844", VA = "0x2BC2844")]
		private WingedEdge()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2BC284C", Offset = "0x2BBE84C", VA = "0x2BC284C", Slot = "4")]
		public bool Equals(WingedEdge other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2BC28D4", Offset = "0x2BBE8D4", VA = "0x2BC28D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2BC29C8", Offset = "0x2BBE9C8", VA = "0x2BC29C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2BC2A34", Offset = "0x2BBEA34", VA = "0x2BC2A34")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2BC2A68", Offset = "0x2BBEA68", VA = "0x2BC2A68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2BC2C54", Offset = "0x2BBEC54", VA = "0x2BC2C54")]
		internal static int[] MakeQuad(WingedEdge left, WingedEdge right)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2BC3044", Offset = "0x2BBF044", VA = "0x2BC3044")]
		public WingedEdge GetAdjacentEdgeWithCommonIndex(int common)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2BC3110", Offset = "0x2BBF110", VA = "0x2BC3110")]
		public static List<Edge> SortEdgesByAdjacency(Face face)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2BC3224", Offset = "0x2BBF224", VA = "0x2BC3224")]
		public static void SortEdgesByAdjacency(List<Edge> edges)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2BC33B8", Offset = "0x2BBF3B8", VA = "0x2BC33B8")]
		public static Dictionary<int, List<WingedEdge>> GetSpokes(List<WingedEdge> wings)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2BC37D0", Offset = "0x2BBF7D0", VA = "0x2BC37D0")]
		internal static List<int> SortCommonIndexesByAdjacency(List<WingedEdge> wings, HashSet<int> common)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2BC3AC0", Offset = "0x2BBFAC0", VA = "0x2BC3AC0")]
		public static List<WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace = false)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2BC3BB4", Offset = "0x2BBFBB4", VA = "0x2BC3BB4")]
		public static List<WingedEdge> GetWingedEdges(ProBuilderMesh mesh, IEnumerable<Face> faces, bool oneWingPerFace = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000087")]
	public sealed class WingedEdgeEnumerator : IEnumerator<WingedEdge>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private WingedEdge m_Start;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private WingedEdge m_Current;

		[Token(Token = "0x170000C0")]
		public WingedEdge Current
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2BC447C", Offset = "0x2BC047C", VA = "0x2BC447C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2BC4484", Offset = "0x2BC0484", VA = "0x2BC4484", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2BC4410", Offset = "0x2BC0410", VA = "0x2BC4410")]
		public WingedEdgeEnumerator(WingedEdge start)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2BC4438", Offset = "0x2BC0438", VA = "0x2BC4438", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2BC4474", Offset = "0x2BC0474", VA = "0x2BC4474", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2BC448C", Offset = "0x2BC048C", VA = "0x2BC448C", Slot = "5")]
		public void Dispose()
		{
		}
	}
}
namespace UnityEngine.ProBuilder.Shapes
{
	[Token(Token = "0x2000088")]
	[Shape("Arch")]
	public class Arch : Shape
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Min(0.01f)]
		private float m_Thickness;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(2f, 200f)]
		[SerializeField]
		private int m_NumberOfSides;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 360f)]
		[SerializeField]
		private float m_ArchDegrees;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_EndCaps;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool m_Smooth;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2BC4490", Offset = "0x2BC0490", VA = "0x2BC4490", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2BC4524", Offset = "0x2BC0524", VA = "0x2BC4524")]
		private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2BC45E8", Offset = "0x2BC05E8", VA = "0x2BC45E8", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2BC50E0", Offset = "0x2BC10E0", VA = "0x2BC50E0")]
		public Arch()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[Shape("Cone")]
	public class Cone : Shape
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(3f, 64f)]
		[SerializeField]
		internal int m_NumberOfSides;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_Radius;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Smooth;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2BC5110", Offset = "0x2BC1110", VA = "0x2BC5110", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2BC519C", Offset = "0x2BC119C", VA = "0x2BC519C", Slot = "4")]
		public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2BC5304", Offset = "0x2BC1304", VA = "0x2BC5304", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2BC5F0C", Offset = "0x2BC1F0C", VA = "0x2BC5F0C")]
		public Cone()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[Shape("Cube")]
	public class Cube : Shape
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] k_CubeVertices;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] k_CubeTriangles;

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2BC5F24", Offset = "0x2BC1F24", VA = "0x2BC5F24", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2BC5F28", Offset = "0x2BC1F28", VA = "0x2BC5F28", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2BC6124", Offset = "0x2BC2124", VA = "0x2BC6124")]
		public Cube()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[Shape("Cylinder")]
	public class Cylinder : Shape
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Range(3f, 64f)]
		private int m_AxisDivisions;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Min(0f)]
		[SerializeField]
		private int m_HeightCuts;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Smooth;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2BC62A4", Offset = "0x2BC22A4", VA = "0x2BC62A4", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2BC6380", Offset = "0x2BC2380", VA = "0x2BC6380", Slot = "4")]
		public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2BC63B0", Offset = "0x2BC23B0", VA = "0x2BC63B0", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2BC6E50", Offset = "0x2BC2E50", VA = "0x2BC6E50")]
		public Cylinder()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[Shape("Door")]
	public class Door : Shape
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Min(0.01f)]
		[SerializeField]
		private float m_DoorHeight;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Min(0.01f)]
		private float m_LegWidth;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2BC6E68", Offset = "0x2BC2E68", VA = "0x2BC6E68", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2BC6F18", Offset = "0x2BC2F18", VA = "0x2BC6F18", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2BC8730", Offset = "0x2BC4730", VA = "0x2BC8730")]
		public Door()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[Shape("Pipe")]
	public class Pipe : Shape
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Min(0.01f)]
		private float m_Thickness;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(3f, 64f)]
		[SerializeField]
		private int m_NumberOfSides;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 31f)]
		[SerializeField]
		private int m_HeightCuts;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_Smooth;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2BC8744", Offset = "0x2BC4744", VA = "0x2BC8744", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2BC87D0", Offset = "0x2BC47D0", VA = "0x2BC87D0", Slot = "4")]
		public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2BC8800", Offset = "0x2BC4800", VA = "0x2BC8800", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2BC91C4", Offset = "0x2BC51C4", VA = "0x2BC91C4")]
		public Pipe()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[Shape("Plane")]
	public class Plane : Shape
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Min(0f)]
		private int m_HeightSegments;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Min(0f)]
		[SerializeField]
		private int m_WidthSegments;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2BC91E0", Offset = "0x2BC51E0", VA = "0x2BC91E0", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2BC9290", Offset = "0x2BC5290", VA = "0x2BC9290", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2BC94C4", Offset = "0x2BC54C4", VA = "0x2BC94C4")]
		public Plane()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[Shape("Prism")]
	public class Prism : Shape
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2BC94D4", Offset = "0x2BC54D4", VA = "0x2BC94D4", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2BC94D8", Offset = "0x2BC54D8", VA = "0x2BC94D8", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2BC9BB8", Offset = "0x2BC5BB8", VA = "0x2BC9BB8")]
		public Prism()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	internal sealed class ProBuilderShape : MonoBehaviour
	{
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private Shape m_Shape;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 m_Size;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Quaternion m_Rotation;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ProBuilderMesh m_Mesh;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PivotLocation m_PivotLocation;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 m_PivotPosition;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		internal ushort m_UnmodifiedMeshVersion;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Bounds m_EditionBounds;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Bounds m_ShapeBox;

		[Token(Token = "0x170000C2")]
		public Shape shape
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2BC9BC0", Offset = "0x2BC5BC0", VA = "0x2BC9BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x2BC9BC8", Offset = "0x2BC5BC8", VA = "0x2BC9BC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public PivotLocation pivotLocation
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2BC9BD0", Offset = "0x2BC5BD0", VA = "0x2BC9BD0")]
			get
			{
				return default(PivotLocation);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2BC9BD8", Offset = "0x2BC5BD8", VA = "0x2BC9BD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public Vector3 pivotLocalPosition
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2BC9BE0", Offset = "0x2BC5BE0", VA = "0x2BC9BE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2BC9BEC", Offset = "0x2BC5BEC", VA = "0x2BC9BEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public Vector3 pivotGlobalPosition
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2BC9BF8", Offset = "0x2BC5BF8", VA = "0x2BC9BF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2BC9D24", Offset = "0x2BC5D24", VA = "0x2BC9D24")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public Vector3 size
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2BC9D84", Offset = "0x2BC5D84", VA = "0x2BC9D84")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x2BC9D90", Offset = "0x2BC5D90", VA = "0x2BC9D90")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x2BC9E4C", Offset = "0x2BC5E4C", VA = "0x2BC9E4C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x2BC9E58", Offset = "0x2BC5E58", VA = "0x2BC9E58")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public Bounds editionBounds
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x2BC9E64", Offset = "0x2BC5E64", VA = "0x2BC9E64")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000C9")]
		public Bounds shapeBox
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x2BC9F1C", Offset = "0x2BC5F1C", VA = "0x2BC9F1C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool isEditable
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x2BC9F30", Offset = "0x2BC5F30", VA = "0x2BC9F30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		public ProBuilderMesh mesh
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x2BC9C2C", Offset = "0x2BC5C2C", VA = "0x2BC9C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2BC9F58", Offset = "0x2BC5F58", VA = "0x2BC9F58")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2BC9FFC", Offset = "0x2BC5FFC", VA = "0x2BC9FFC")]
		internal void UpdateComponent()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2BCA3C4", Offset = "0x2BC63C4", VA = "0x2BCA3C4")]
		internal void UpdateBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2BCA454", Offset = "0x2BC6454", VA = "0x2BCA454")]
		internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2BCA224", Offset = "0x2BC6224", VA = "0x2BCA224")]
		private void Rebuild()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2BCA758", Offset = "0x2BC6758", VA = "0x2BCA758")]
		internal void SetShape(Shape shape, PivotLocation location)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2BCA8D0", Offset = "0x2BC68D0", VA = "0x2BCA8D0")]
		internal void RotateInsideBounds(Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2BCA030", Offset = "0x2BC6030", VA = "0x2BCA030")]
		private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2BCA530", Offset = "0x2BC6530", VA = "0x2BCA530")]
		internal void RebuildPivot(Vector3 size, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2BCA99C", Offset = "0x2BC699C", VA = "0x2BCA99C")]
		public ProBuilderShape()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public abstract class Shape
	{
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2BCAA74", Offset = "0x2BC6A74", VA = "0x2BCAA74", Slot = "4")]
		public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004A7")]
		public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation);

		[Token(Token = "0x60004A8")]
		public abstract void CopyShape(Shape shape);

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2BC5108", Offset = "0x2BC1108", VA = "0x2BC5108")]
		protected Shape()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ShapeAttribute : Attribute
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2BCAAA4", Offset = "0x2BC6AA4", VA = "0x2BCAAA4")]
		public ShapeAttribute(string n)
		{
		}
	}
	[Token(Token = "0x2000093")]
	[Shape("Sphere")]
	public class Sphere : Shape
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] k_IcosphereVertices;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] k_IcosphereTriangles;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(1f, 5f)]
		[SerializeField]
		private int m_Subdivisions;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_BottomMostVertexIndex;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Smooth;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2BCAACC", Offset = "0x2BC6ACC", VA = "0x2BCAACC", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2BCAB50", Offset = "0x2BC6B50", VA = "0x2BCAB50", Slot = "4")]
		public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2BCABAC", Offset = "0x2BC6BAC", VA = "0x2BCABAC", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2BCB490", Offset = "0x2BC7490", VA = "0x2BCB490")]
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius)
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2BCB948", Offset = "0x2BC7948", VA = "0x2BCB948")]
		public Sphere()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[Shape("Sprite")]
	public class Sprite : Shape
	{
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2BCBB48", Offset = "0x2BC7B48", VA = "0x2BCBB48", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2BCBB4C", Offset = "0x2BC7B4C", VA = "0x2BCBB4C", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2BCBE44", Offset = "0x2BC7E44", VA = "0x2BCBE44")]
		public Sprite()
		{
		}
	}
	[Token(Token = "0x2000095")]
	internal enum StepGenerationType
	{
		[Token(Token = "0x40002A8")]
		Height,
		[Token(Token = "0x40002A9")]
		Count
	}
	[Token(Token = "0x2000096")]
	[Shape("Stairs")]
	public class Stairs : Shape
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StepGenerationType m_StepGenerationType;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Min(0.01f)]
		[SerializeField]
		private float m_StepsHeight;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 256f)]
		[SerializeField]
		private int m_StepsCount;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_HomogeneousSteps;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(-360f, 360f)]
		[SerializeField]
		private float m_Circumference;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_Sides;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Min(0f)]
		private float m_InnerRadius;

		[Token(Token = "0x170000CC")]
		public bool sides
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x2BCBE4C", Offset = "0x2BC7E4C", VA = "0x2BCBE4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x2BCBE54", Offset = "0x2BC7E54", VA = "0x2BCBE54")]
			set
			{
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2BCBE5C", Offset = "0x2BC7E5C", VA = "0x2BCBE5C", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2BCBF08", Offset = "0x2BC7F08", VA = "0x2BCBF08", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2BCDD28", Offset = "0x2BC9D28", VA = "0x2BCDD28", Slot = "4")]
		public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2BCCEA0", Offset = "0x2BC8EA0", VA = "0x2BCCEA0")]
		private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2BCBF20", Offset = "0x2BC7F20", VA = "0x2BCBF20")]
		private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2BCDE6C", Offset = "0x2BC9E6C", VA = "0x2BCDE6C")]
		public Stairs()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[Shape("Torus")]
	public class Torus : Shape
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Range(3f, 64f)]
		private int m_Rows;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(3f, 64f)]
		[SerializeField]
		private int m_Columns;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Min(0.01f)]
		private float m_TubeRadius;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(0f, 360f)]
		private float m_HorizontalCircumference;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 360f)]
		private float m_VerticalCircumference;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_Smooth;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2BCDE98", Offset = "0x2BC9E98", VA = "0x2BCDE98", Slot = "6")]
		public override void CopyShape(Shape shape)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2BCDF28", Offset = "0x2BC9F28", VA = "0x2BCDF28", Slot = "4")]
		public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2BCDFA8", Offset = "0x2BC9FA8", VA = "0x2BCDFA8", Slot = "5")]
		public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2BCE910", Offset = "0x2BCA910", VA = "0x2BCE910")]
		private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2BCEC44", Offset = "0x2BCAC44", VA = "0x2BCEC44")]
		private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2BCEEBC", Offset = "0x2BCAEBC", VA = "0x2BCEEBC")]
		public Torus()
		{
		}
	}
}
namespace UnityEngine.ProBuilder.MeshOperations
{
	[Token(Token = "0x2000098")]
	public static class AppendElements
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2BCEEE8", Offset = "0x2BCAEE8", VA = "0x2BCEEE8")]
		internal static Face AppendFace(this ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, int[] common)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2BCF750", Offset = "0x2BCB750", VA = "0x2BCF750")]
		public static Face[] AppendFaces(this ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, int[][] shared)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2BCFD2C", Offset = "0x2BCBD2C", VA = "0x2BCFD2C")]
		public static Face CreatePolygon(this ProBuilderMesh mesh, IList<int> indexes, bool unordered)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2BD0310", Offset = "0x2BCC310", VA = "0x2BD0310")]
		public static Face CreatePolygonWithHole(this ProBuilderMesh mesh, IList<int> indexes, IList<IList<int>> holes)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2BD108C", Offset = "0x2BCD08C", VA = "0x2BD108C")]
		public static ActionResult CreateShapeFromPolygon(this PolyShape poly)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2BD10C4", Offset = "0x2BCD0C4", VA = "0x2BD10C4")]
		internal static void ClearAndRefreshMesh(this ProBuilderMesh mesh)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2BD10BC", Offset = "0x2BCD0BC", VA = "0x2BD10BC")]
		public static ActionResult CreateShapeFromPolygon(this ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2BD1C8C", Offset = "0x2BCDC8C", VA = "0x2BD1C8C")]
		[Obsolete("Face.CreateShapeFromPolygon is deprecated as it no longer relies on camera look at.")]
		public static ActionResult CreateShapeFromPolygon(this ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, [Optional] IList<IList<Vector3>> holePoints)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2BD1100", Offset = "0x2BCD100", VA = "0x2BD1100")]
		public static ActionResult CreateShapeFromPolygon(this ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals, IList<IList<Vector3>> holePoints)
		{
			return null;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2BD0248", Offset = "0x2BCC248", VA = "0x2BD0248")]
		internal static FaceRebuildData FaceWithVertices(List<Vertex> vertices, bool unordered = true)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2BD0C44", Offset = "0x2BCCC44", VA = "0x2BD0C44")]
		internal static FaceRebuildData FaceWithVerticesAndHole(List<Vertex> borderVertices, List<List<Vertex>> holes)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2BD2320", Offset = "0x2BCE320", VA = "0x2BD2320")]
		internal static List<FaceRebuildData> TentCapWithVertices(List<Vertex> path)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2BD1C94", Offset = "0x2BCDC94", VA = "0x2BD1C94")]
		public static void DuplicateAndFlip(this ProBuilderMesh mesh, Face[] faces)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2BD26A0", Offset = "0x2BCE6A0", VA = "0x2BD26A0")]
		public static Face Bridge(this ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry = false)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2BD3D08", Offset = "0x2BCFD08", VA = "0x2BD3D08")]
		public static Face AppendVerticesToFace(this ProBuilderMesh mesh, Face face, Vector3[] points)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2BD3D10", Offset = "0x2BCFD10", VA = "0x2BD3D10")]
		public static Face AppendVerticesToFace(this ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2BD494C", Offset = "0x2BD094C", VA = "0x2BD494C")]
		public static List<Edge> AppendVerticesToEdge(this ProBuilderMesh mesh, Edge edge, int count)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2BD49CC", Offset = "0x2BD09CC", VA = "0x2BD49CC")]
		public static List<Edge> AppendVerticesToEdge(this ProBuilderMesh mesh, IList<Edge> edges, int count)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2BD6C3C", Offset = "0x2BD2C3C", VA = "0x2BD6C3C")]
		public static Face[] InsertVertexInFace(this ProBuilderMesh mesh, Face face, Vector3 point)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2BD7A48", Offset = "0x2BD3A48", VA = "0x2BD7A48")]
		public static Vertex InsertVertexOnEdge(this ProBuilderMesh mesh, Edge originalEdge, Vector3 point)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2BD8DE4", Offset = "0x2BD4DE4", VA = "0x2BD8DE4")]
		public static Vertex InsertVertexInMesh(this ProBuilderMesh mesh, Vector3 point, Vector3 normal)
		{
			return null;
		}
	}
	[Token(Token = "0x200009B")]
	public static class Bevel
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] k_BridgeIndexesTri;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2BD929C", Offset = "0x2BD529C", VA = "0x2BD929C")]
		public static List<Face> BevelEdges(ProBuilderMesh mesh, IList<Edge> edges, float amount)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2BDBBDC", Offset = "0x2BD7BDC", VA = "0x2BDBBDC")]
		private static List<FaceRebuildData> GetBridgeFaces(IList<Vertex> vertices, WingedEdge left, WingedEdge right, Dictionary<int, List<SimpleTuple<FaceRebuildData, List<int>>>> holes)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2BDB7D8", Offset = "0x2BD77D8", VA = "0x2BDB7D8")]
		private static void SlideEdge(IList<Vertex> vertices, WingedEdge we, float amount)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2BDC564", Offset = "0x2BD8564", VA = "0x2BDC564")]
		private static Edge GetLeadingEdge(WingedEdge wing, int common)
		{
			return default(Edge);
		}
	}
	[Token(Token = "0x20000A0")]
	public static class CombineMeshes
	{
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2BDC9B8", Offset = "0x2BD89B8", VA = "0x2BDC9B8")]
		[Obsolete("Combine(IEnumerable<ProBuilderMesh> meshes) is deprecated. Plase use Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget).")]
		public static List<ProBuilderMesh> Combine(IEnumerable<ProBuilderMesh> meshes)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2BDCE38", Offset = "0x2BD8E38", VA = "0x2BDCE38")]
		public static List<ProBuilderMesh> Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2BDC9BC", Offset = "0x2BD89BC", VA = "0x2BDC9BC")]
		private static List<ProBuilderMesh> CombineToNewMeshes(IEnumerable<ProBuilderMesh> meshes)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2BDD934", Offset = "0x2BD9934", VA = "0x2BDD934")]
		private static void AccumulateMeshesInfo(IEnumerable<ProBuilderMesh> meshes, int offset, ref List<Vertex> vertices, ref List<Face> faces, ref List<Face> autoUvFaces, ref List<SharedVertex> sharedVertices, ref List<SharedVertex> sharedTextures, ref List<Material> materialMap, [Optional] Transform targetTransform)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2BDF280", Offset = "0x2BDB280", VA = "0x2BDF280")]
		private static ProBuilderMesh CreateMeshFromSplit(List<Vertex> vertices, List<Face> faces, Dictionary<int, int> sharedVertexLookup, Dictionary<int, int> sharedTextureLookup, Dictionary<int, int> remap, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2BDE5E0", Offset = "0x2BDA5E0", VA = "0x2BDE5E0")]
		internal static List<ProBuilderMesh> SplitByMaxVertexCount(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices, IList<SharedVertex> sharedTextures, uint maxVertexCount = 65535u)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	internal sealed class ConnectFaceRebuildData
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceRebuildData faceRebuildData;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> newVertexIndexes;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2BDF7D8", Offset = "0x2BDB7D8", VA = "0x2BDF7D8")]
		public ConnectFaceRebuildData(FaceRebuildData faceRebuildData, List<int> newVertexIndexes)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public static class ConnectElements
	{
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2BDF804", Offset = "0x2BDB804", VA = "0x2BDF804")]
		public static Face[] Connect(this ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2BE0FEC", Offset = "0x2BDCFEC", VA = "0x2BE0FEC")]
		public static SimpleTuple<Face[], Edge[]> Connect(this ProBuilderMesh mesh, IEnumerable<Edge> edges)
		{
			return default(SimpleTuple<Face[], Edge[]>);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2BE1084", Offset = "0x2BDD084", VA = "0x2BE1084")]
		public static int[] Connect(this ProBuilderMesh mesh, IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2BDFAB4", Offset = "0x2BDBAB4", VA = "0x2BDFAB4")]
		internal static ActionResult Connect(this ProBuilderMesh mesh, IEnumerable<Edge> edges, out Face[] addedFaces, out Edge[] connections, bool returnFaces = false, bool returnEdges = false, [Optional] HashSet<Face> faceMask)
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2BE4078", Offset = "0x2BE0078", VA = "0x2BE4078")]
		private static List<ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, List<Vertex> vertices)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2BE3710", Offset = "0x2BDF710", VA = "0x2BE3710")]
		private static List<ConnectFaceRebuildData> ConnectEdgesInFace(Face face, List<WingedEdge> edges, List<Vertex> vertices)
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2BE31E4", Offset = "0x2BDF1E4", VA = "0x2BE31E4")]
		private static bool InsertVertices(Face face, List<WingedEdge> edges, List<Vertex> vertices, out ConnectFaceRebuildData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2BE2914", Offset = "0x2BDE914", VA = "0x2BE2914")]
		private static List<ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, List<Vertex> vertices, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2BE1ED0", Offset = "0x2BDDED0", VA = "0x2BE1ED0")]
		private static List<ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, List<int> indexes, List<Vertex> vertices, Dictionary<int, int> lookup, int sharedIndexOffset)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	public static class DeleteElements
	{
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2BD676C", Offset = "0x2BD276C", VA = "0x2BD676C")]
		public static void DeleteVertices(this ProBuilderMesh mesh, IEnumerable<int> distinctIndexes)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2BD48D4", Offset = "0x2BD08D4", VA = "0x2BD48D4")]
		public static int[] DeleteFace(this ProBuilderMesh mesh, Face face)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2BDC464", Offset = "0x2BD8464", VA = "0x2BDC464")]
		public static int[] DeleteFaces(this ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2BE4C80", Offset = "0x2BE0C80", VA = "0x2BE4C80")]
		public static int[] DeleteFaces(this ProBuilderMesh mesh, IList<int> faceIndexes)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2BE5258", Offset = "0x2BE1258", VA = "0x2BE5258")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MeshValidation.RemoveDegenerateTriangles")]
		public static int[] RemoveDegenerateTriangles(this ProBuilderMesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2BE52FC", Offset = "0x2BE12FC", VA = "0x2BE52FC")]
		[Obsolete("Use MeshValidation.RemoveUnusedVertices")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int[] RemoveUnusedVertices(this ProBuilderMesh mesh)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AB")]
	public static class ElementSelection
	{
		[Token(Token = "0x40002E6")]
		private const int k_MaxHoleIterations = 2048;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 Vector3_Zero;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2BE5698", Offset = "0x2BE1698", VA = "0x2BE5698")]
		public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, List<Face> neighborFaces)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2BD3A04", Offset = "0x2BCFA04", VA = "0x2BD3A04")]
		internal static List<SimpleTuple<Face, Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2BE591C", Offset = "0x2BE191C", VA = "0x2BE591C")]
		internal static List<Face> GetNeighborFaces(ProBuilderMesh mesh, int[] indexes)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2BE5BD0", Offset = "0x2BE1BD0", VA = "0x2BE5BD0")]
		internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2BE6214", Offset = "0x2BE2214", VA = "0x2BE6214")]
		public static IEnumerable<Edge> GetPerimeterEdges(this ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2BE6814", Offset = "0x2BE2814", VA = "0x2BE6814")]
		internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, IList<Edge> edges)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2BE6B88", Offset = "0x2BE2B88", VA = "0x2BE6B88")]
		internal static IEnumerable<Face> GetPerimeterFaces(ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2BE72B8", Offset = "0x2BE32B8", VA = "0x2BE72B8")]
		internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all)
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2BE7600", Offset = "0x2BE3600", VA = "0x2BE7600")]
		private static WingedEdge EdgeRingNext(WingedEdge edge)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2BE7680", Offset = "0x2BE3680", VA = "0x2BE7680")]
		internal static IEnumerable<Edge> GetEdgeRing(ProBuilderMesh pb, IEnumerable<Edge> edges)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2BE7B08", Offset = "0x2BE3B08", VA = "0x2BE7B08")]
		internal static IEnumerable<Edge> GetEdgeRingIterative(ProBuilderMesh pb, IEnumerable<Edge> edges)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2BE7FA8", Offset = "0x2BE3FA8", VA = "0x2BE7FA8")]
		internal static bool GetEdgeLoop(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Edge[] loop)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2BE8568", Offset = "0x2BE4568", VA = "0x2BE8568")]
		internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Edge[] loop)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2BE8318", Offset = "0x2BE4318", VA = "0x2BE8318")]
		private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, HashSet<EdgeLookup> used)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2BE8858", Offset = "0x2BE4858", VA = "0x2BE8858")]
		private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, HashSet<EdgeLookup> used)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2BE8EE4", Offset = "0x2BE4EE4", VA = "0x2BE8EE4")]
		private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2BE8BD8", Offset = "0x2BE4BD8", VA = "0x2BE8BD8")]
		internal static List<WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles = false)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2BE8FC8", Offset = "0x2BE4FC8", VA = "0x2BE8FC8")]
		public static HashSet<Face> GrowSelection(ProBuilderMesh mesh, IEnumerable<Face> faces, float maxAngleDiff = -1f)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2BE9538", Offset = "0x2BE5538", VA = "0x2BE9538")]
		internal static void Flood(WingedEdge wing, HashSet<Face> selection)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2BE95B4", Offset = "0x2BE55B4", VA = "0x2BE95B4")]
		internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, HashSet<Face> selection)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2BE983C", Offset = "0x2BE583C", VA = "0x2BE983C")]
		public static HashSet<Face> FloodSelection(ProBuilderMesh mesh, IList<Face> faces, float maxAngleDiff)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2BE9AE8", Offset = "0x2BE5AE8", VA = "0x2BE9AE8")]
		public static HashSet<Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring = false)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x2BE9EC0", Offset = "0x2BE5EC0", VA = "0x2BE9EC0")]
		public static HashSet<Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x2BE9CE8", Offset = "0x2BE5CE8", VA = "0x2BE9CE8")]
		private static HashSet<Face> GetFaceLoop(List<WingedEdge> wings, Face face, bool ring)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x2BEA0DC", Offset = "0x2BE60DC", VA = "0x2BEA0DC")]
		internal static List<List<Edge>> FindHoles(ProBuilderMesh mesh, IEnumerable<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x2BEA450", Offset = "0x2BE6450", VA = "0x2BEA450")]
		internal static List<List<WingedEdge>> FindHoles(List<WingedEdge> wings, HashSet<int> common)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2BEAC84", Offset = "0x2BE6C84", VA = "0x2BEAC84")]
		private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	public static class ExtrudeElements
	{
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2BEB0EC", Offset = "0x2BE70EC", VA = "0x2BEB0EC")]
		public static Face[] Extrude(this ProBuilderMesh mesh, IEnumerable<Face> faces, ExtrudeMethod method, float distance)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2BED6A0", Offset = "0x2BE96A0", VA = "0x2BED6A0")]
		public static Edge[] Extrude(this ProBuilderMesh mesh, IEnumerable<Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2BEE858", Offset = "0x2BEA858", VA = "0x2BEE858")]
		public static List<Face> DetachFaces(this ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2BEE860", Offset = "0x2BEA860", VA = "0x2BEE860")]
		public static List<Face> DetachFaces(this ProBuilderMesh mesh, IEnumerable<Face> faces, bool deleteSourceFaces)
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2BEB100", Offset = "0x2BE7100", VA = "0x2BEB100")]
		private static Face[] ExtrudePerFace(ProBuilderMesh pb, IEnumerable<Face> faces, float distance)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2BEBC6C", Offset = "0x2BE7C6C", VA = "0x2BEBC6C")]
		private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, bool compensateAngleVertexDistance, float distance)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2BEF2D4", Offset = "0x2BEB2D4", VA = "0x2BEF2D4")]
		private static List<HashSet<Face>> GetFaceGroups(List<WingedEdge> wings)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2BEF6E8", Offset = "0x2BEB6E8", VA = "0x2BEF6E8")]
		private static Dictionary<EdgeLookup, Face> GetPerimeterEdges(HashSet<Face> faces, Dictionary<int, int> lookup)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	internal static class InternalMeshUtility
	{
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2BEE6C0", Offset = "0x2BEA6C0", VA = "0x2BEE6C0")]
		internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, int[] all, IList<Vector3> norm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2BEFB3C", Offset = "0x2BEBB3C", VA = "0x2BEFB3C")]
		public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2BF0EC0", Offset = "0x2BECEC0", VA = "0x2BF0EC0")]
		public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces)
		{
			return default(bool);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2BF2010", Offset = "0x2BEE010", VA = "0x2BF2010")]
		internal static void FilterUnusedSubmeshIndexes(ProBuilderMesh mesh)
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public static class MergeElements
	{
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2BF2624", Offset = "0x2BEE624", VA = "0x2BF2624")]
		public static List<Face> MergePairs(ProBuilderMesh target, IEnumerable<SimpleTuple<Face, Face>> pairs, bool collapseCoincidentVertices = true)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2BF30F4", Offset = "0x2BEF0F4", VA = "0x2BF30F4")]
		public static Face Merge(ProBuilderMesh target, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2BF2C6C", Offset = "0x2BEEC6C", VA = "0x2BF2C6C")]
		internal static void CollapseCoincidentVertices(ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public sealed class MeshImportSettings
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Quads;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_Smoothing;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float m_SmoothingThreshold;

		[Token(Token = "0x170000CD")]
		public bool quads
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2BF3864", Offset = "0x2BEF864", VA = "0x2BF3864")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x2BF386C", Offset = "0x2BEF86C", VA = "0x2BF386C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool smoothing
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x2BF3874", Offset = "0x2BEF874", VA = "0x2BF3874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x2BF387C", Offset = "0x2BEF87C", VA = "0x2BF387C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public float smoothingAngle
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x2BF3884", Offset = "0x2BEF884", VA = "0x2BF3884")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x2BF388C", Offset = "0x2BEF88C", VA = "0x2BF388C")]
			set
			{
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2BF3894", Offset = "0x2BEF894", VA = "0x2BF3894", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2BF396C", Offset = "0x2BEF96C", VA = "0x2BF396C")]
		public MeshImportSettings()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public sealed class MeshImporter
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MeshImportSettings k_DefaultImportSettings;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Mesh m_SourceMesh;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material[] m_SourceMaterials;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProBuilderMesh m_Destination;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vertex[] m_Vertices;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2BF3984", Offset = "0x2BEF984", VA = "0x2BF3984")]
		public MeshImporter(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2BF3AE8", Offset = "0x2BEFAE8", VA = "0x2BF3AE8")]
		public MeshImporter(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2BF3C08", Offset = "0x2BEFC08", VA = "0x2BF3C08")]
		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MeshImporter(ProBuilderMesh destination)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2BF3C30", Offset = "0x2BEFC30", VA = "0x2BF3C30")]
		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Import(GameObject go, [Optional] MeshImportSettings importSettings)
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2BF3DB4", Offset = "0x2BEFDB4", VA = "0x2BF3DB4")]
		public void Import([Optional] MeshImportSettings importSettings)
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public static class MeshTransform
	{
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2BF5150", Offset = "0x2BF1150", VA = "0x2BF5150")]
		internal static void SetPivot(this ProBuilderMesh mesh, PivotLocation pivotLocation)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2BF0BEC", Offset = "0x2BECBEC", VA = "0x2BF0BEC")]
		public static void CenterPivot(this ProBuilderMesh mesh, int[] indexes)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2BF51F4", Offset = "0x2BF11F4", VA = "0x2BF51F4")]
		public static void SetPivot(this ProBuilderMesh mesh, Vector3 worldPosition)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2BF5388", Offset = "0x2BF1388", VA = "0x2BF5388")]
		public static void FreezeScaleTransform(this ProBuilderMesh mesh)
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public static class MeshValidation
	{
		[Token(Token = "0x20000BB")]
		private enum AttributeValidationStrategy
		{
			[Token(Token = "0x4000314")]
			Resize,
			[Token(Token = "0x4000315")]
			Nullify
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2BF54E4", Offset = "0x2BF14E4", VA = "0x2BF54E4")]
		public static bool ContainsDegenerateTriangles(this ProBuilderMesh mesh)
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2BF54F8", Offset = "0x2BF14F8", VA = "0x2BF54F8")]
		public static bool ContainsDegenerateTriangles(this ProBuilderMesh mesh, IList<Face> faces)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2BF58F8", Offset = "0x2BF18F8", VA = "0x2BF58F8")]
		public static bool ContainsDegenerateTriangles(this ProBuilderMesh mesh, Face face)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2BF5A54", Offset = "0x2BF1A54", VA = "0x2BF5A54")]
		public static bool ContainsNonContiguousTriangles(this ProBuilderMesh mesh, Face face)
		{
			return default(bool);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2BF5B84", Offset = "0x2BF1B84", VA = "0x2BF5B84")]
		public static List<Face> EnsureFacesAreComposedOfContiguousTriangles(this ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2BF6218", Offset = "0x2BF2218", VA = "0x2BF6218")]
		internal static List<List<Triangle>> CollectFaceGroups(this ProBuilderMesh mesh, Face face)
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2BF65DC", Offset = "0x2BF25DC", VA = "0x2BF65DC")]
		public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, [Optional] List<int> removed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2BF3464", Offset = "0x2BEF464", VA = "0x2BF3464")]
		public static bool RemoveUnusedVertices(ProBuilderMesh mesh, [Optional] List<int> removed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2BF6F48", Offset = "0x2BF2F48", VA = "0x2BF6F48")]
		internal static List<int> RebuildIndexes(IEnumerable<int> indices, List<int> removed)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2BF732C", Offset = "0x2BF332C", VA = "0x2BF732C")]
		internal static List<Edge> RebuildEdges(IEnumerable<Edge> edges, List<int> removed)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2BF7774", Offset = "0x2BF3774", VA = "0x2BF7774")]
		internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, ref Face[] faces, ref Edge[] edges, ref int[] indices, IEnumerable<int> removed)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2BF7950", Offset = "0x2BF3950", VA = "0x2BF7950")]
		internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, out int removedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2BF7C70", Offset = "0x2BF3C70", VA = "0x2BF7C70")]
		private static void EnsureRealNumbers(IList<Vector2> attribute)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2BF7E30", Offset = "0x2BF3E30", VA = "0x2BF7E30")]
		private static void EnsureRealNumbers(IList<Vector3> attribute)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2BF7FFC", Offset = "0x2BF3FFC", VA = "0x2BF7FFC")]
		private static void EnsureRealNumbers(IList<Vector4> attribute)
		{
		}

		[Token(Token = "0x60005A0")]
		private static void EnsureArraySize<T>(ref T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy = AttributeValidationStrategy.Nullify, [Optional] T fill)
		{
		}

		[Token(Token = "0x60005A1")]
		private static void EnsureListSize<T>(ref List<T> attribute, int expectedVertexCount, AttributeValidationStrategy strategy = AttributeValidationStrategy.Nullify, [Optional] T fill)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2BF7A7C", Offset = "0x2BF3A7C", VA = "0x2BF7A7C")]
		private static void EnsureValidAttributes(ProBuilderMesh mesh)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public static class QuadUtility
	{
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2BF4824", Offset = "0x2BF0824", VA = "0x2BF4824")]
		public static List<Face> ToQuads(this ProBuilderMesh mesh, IList<Face> faces, bool smoothing = true)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2BF8960", Offset = "0x2BF4960", VA = "0x2BF8960")]
		private static Face GetBestQuadConnection(WingedEdge wing, Dictionary<EdgeLookup, float> connections)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2BF832C", Offset = "0x2BF432C", VA = "0x2BF832C")]
		private static float GetQuadScore(this ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold = 0.9f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000C0")]
	internal static class Subdivision
	{
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2BF8BA4", Offset = "0x2BF4BA4", VA = "0x2BF8BA4")]
		public static ActionResult Subdivide(this ProBuilderMesh pb)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2BF8C5C", Offset = "0x2BF4C5C", VA = "0x2BF8C5C")]
		public static Face[] Subdivide(this ProBuilderMesh pb, IList<Face> faces)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	public static class SurfaceTopology
	{
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2BF8C64", Offset = "0x2BF4C64", VA = "0x2BF8C64")]
		public static Face[] ToTriangles(this ProBuilderMesh mesh, IList<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2BF91C4", Offset = "0x2BF51C4", VA = "0x2BF91C4")]
		private static List<FaceRebuildData> BreakFaceIntoTris(Face face, List<Vertex> vertices, Dictionary<int, int> lookup)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2BF97CC", Offset = "0x2BF57CC", VA = "0x2BF97CC")]
		public static WindingOrder GetWindingOrder(this ProBuilderMesh mesh, Face face)
		{
			return default(WindingOrder);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2BF9A84", Offset = "0x2BF5A84", VA = "0x2BF9A84")]
		private static WindingOrder GetWindingOrder(IList<Vertex> vertices, IList<int> indexes)
		{
			return default(WindingOrder);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2BF9804", Offset = "0x2BF5804", VA = "0x2BF9804")]
		public static WindingOrder GetWindingOrder(IList<Vector2> points)
		{
			return default(WindingOrder);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2BF9C1C", Offset = "0x2BF5C1C", VA = "0x2BF9C1C")]
		public static bool FlipEdge(this ProBuilderMesh mesh, Face face)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2BF9F38", Offset = "0x2BF5F38", VA = "0x2BF9F38")]
		public static ActionResult ConformNormals(this ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2BFA400", Offset = "0x2BF6400", VA = "0x2BFA400")]
		private static void GetWindingFlags(WingedEdge edge, bool flag, Dictionary<Face, bool> flags)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2BFA640", Offset = "0x2BF6640", VA = "0x2BFA640")]
		internal static ActionResult ConformOppositeNormal(WingedEdge source)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2BFA4EC", Offset = "0x2BF64EC", VA = "0x2BFA4EC")]
		private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing)
		{
			return default(Edge);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2BFA750", Offset = "0x2BF6750", VA = "0x2BFA750")]
		internal static void MatchNormal(Face source, Face target, Dictionary<int, int> lookup)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	internal static class Triangulation
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UnityEngine.ProBuilder.Poly2Tri.TriangulationContext s_TriangulationContext;

		[Token(Token = "0x170000D0")]
		private static UnityEngine.ProBuilder.Poly2Tri.TriangulationContext triangulationContext
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x2BFA988", Offset = "0x2BF6988", VA = "0x2BFA988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2BFAA14", Offset = "0x2BF6A14", VA = "0x2BFAA14")]
		public static bool SortAndTriangulate(IList<Vector2> points, out List<int> indexes, bool convex = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2BFB83C", Offset = "0x2BF783C", VA = "0x2BFB83C")]
		public static bool TriangulateVertices(IList<Vertex> vertices, out List<int> triangles, bool unordered = true, bool convex = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2BFBC68", Offset = "0x2BF7C68", VA = "0x2BFBC68")]
		public static bool TriangulateVertices(Vector3[] vertices, out List<int> triangles, [Optional] Vector3[][] holes)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2BFBA50", Offset = "0x2BF7A50", VA = "0x2BFBA50")]
		public static bool TriangulateVertices(Vector3[] vertices, out List<int> triangles, bool unordered = true, bool convex = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2BFAD10", Offset = "0x2BF6D10", VA = "0x2BFAD10")]
		public static bool Triangulate(IList<Vector2> points, out List<int> indexes, bool convex = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2BFBDD4", Offset = "0x2BF7DD4", VA = "0x2BFBDD4")]
		public static bool Triangulate(IList<Vector2> points, IList<IList<Vector2>> holes, out List<int> indexes)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C6")]
	internal static class UVEditing
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2BFCB68", Offset = "0x2BF8B68", VA = "0x2BFCB68")]
		public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2BFCDE0", Offset = "0x2BF8DE0", VA = "0x2BFCDE0")]
		private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2BFD7C0", Offset = "0x2BF97C0", VA = "0x2BFD7C0")]
		internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel)
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2BFDD60", Offset = "0x2BF9D60", VA = "0x2BFDD60")]
		internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh = true)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2BFE0B0", Offset = "0x2BFA0B0", VA = "0x2BFE0B0")]
		public static void SewUVs(this ProBuilderMesh mesh, int[] indexes, float delta)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2BFE5F8", Offset = "0x2BFA5F8", VA = "0x2BFE5F8")]
		public static void CollapseUVs(this ProBuilderMesh mesh, int[] indexes)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2BFDA08", Offset = "0x2BF9A08", VA = "0x2BFDA08")]
		public static void SplitUVs(this ProBuilderMesh mesh, IEnumerable<int> indexes)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2BFE6C4", Offset = "0x2BFA6C4", VA = "0x2BFE6C4")]
		internal static void SplitUVs(ProBuilderMesh mesh, IEnumerable<Face> faces)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2BFEA94", Offset = "0x2BFAA94", VA = "0x2BFEA94")]
		internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2BFEE30", Offset = "0x2BFAE30", VA = "0x2BFEE30")]
		public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel = 0)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2BFF3E8", Offset = "0x2BFB3E8", VA = "0x2BFF3E8")]
		internal static Vector2 FindMinimalUV(Vector2[] uvs, [Optional] int[] indices, float xMin = 0f, float yMin = 0f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2BFF4AC", Offset = "0x2BFB4AC", VA = "0x2BFF4AC")]
		public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel = 0)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2BFFA8C", Offset = "0x2BFBA8C", VA = "0x2BFFA8C")]
		public static void ProjectFacesSphere(ProBuilderMesh pb, int[] indexes, int channel = 0)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2BFFC0C", Offset = "0x2BFBC0C", VA = "0x2BFFC0C")]
		public static Vector2[] FitUVs(Vector2[] uvs)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CA")]
	public static class VertexEditing
	{
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2BFFE54", Offset = "0x2BFBE54", VA = "0x2BFFE54")]
		public static int MergeVertices(this ProBuilderMesh mesh, int[] indexes, bool collapseToFirst = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2C00164", Offset = "0x2BFC164", VA = "0x2C00164")]
		public static void SplitVertices(this ProBuilderMesh mesh, Edge edge)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2C001EC", Offset = "0x2BFC1EC", VA = "0x2C001EC")]
		public static void SplitVertices(this ProBuilderMesh mesh, IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2C005B4", Offset = "0x2BFC5B4", VA = "0x2C005B4")]
		public static int[] WeldVertices(this ProBuilderMesh mesh, IEnumerable<int> indexes, float neighborRadius)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2C01274", Offset = "0x2BFD274", VA = "0x2C01274")]
		internal static FaceRebuildData ExplodeVertex(IList<Vertex> vertices, IList<SimpleTuple<WingedEdge, int>> edgeAndCommonIndex, float distance, out Dictionary<int, List<int>> appendedVertices)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2C01DC8", Offset = "0x2BFDDC8", VA = "0x2C01DC8")]
		private static Edge AlignEdgeWithDirection(EdgeLookup edge, int commonIndex)
		{
			return default(Edge);
		}
	}
}
