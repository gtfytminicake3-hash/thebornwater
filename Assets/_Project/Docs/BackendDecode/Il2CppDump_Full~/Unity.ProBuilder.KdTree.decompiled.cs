using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.ProBuilder.KdTree
{
	[Token(Token = "0x2000002")]
	internal struct HyperRect<T>
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private T[] minPoint;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		private T[] maxPoint;

		[Token(Token = "0x17000001")]
		public T[] MinPoint
		{
			[Token(Token = "0x6000001")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public T[] MaxPoint
		{
			[Token(Token = "0x6000003")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			set
			{
			}
		}

		[Token(Token = "0x6000005")]
		public static HyperRect<T> Infinite(int dimensions, ITypeMath<T> math)
		{
			return default(HyperRect<T>);
		}

		[Token(Token = "0x6000006")]
		public T[] GetClosestPoint(T[] toPoint, ITypeMath<T> math)
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		public HyperRect<T> Clone()
		{
			return default(HyperRect<T>);
		}
	}
	[Token(Token = "0x2000003")]
	internal enum AddDuplicateBehavior
	{
		[Token(Token = "0x4000004")]
		Skip,
		[Token(Token = "0x4000005")]
		Error,
		[Token(Token = "0x4000006")]
		Update,
		[Token(Token = "0x4000007")]
		Collect
	}
	[Token(Token = "0x2000004")]
	internal class DuplicateNodeError : Exception
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2B715FC", Offset = "0x2B6D5FC", VA = "0x2B715FC")]
		public DuplicateNodeError()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	internal class KdTree<TKey, TValue> : IEnumerable<KdTreeNode<TKey, TValue>>, IEnumerable
	{
		[Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x0")]
			public Stack<KdTreeNode<TKey, TValue>> left;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x0")]
			public Stack<KdTreeNode<TKey, TValue>> right;

			[Token(Token = "0x6000016")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000017")]
			internal void <GetEnumerator>b__0(KdTreeNode<TKey, TValue> node)
			{
			}

			[Token(Token = "0x6000018")]
			internal void <GetEnumerator>b__1(KdTreeNode<TKey, TValue> node)
			{
			}
		}

		[Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__33 : IEnumerator<KdTreeNode<TKey, TValue>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			private KdTreeNode<TKey, TValue> <>2__current;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x0")]
			public KdTree<TKey, TValue> <>4__this;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x0")]
			private <>c__DisplayClass33_0 <>8__1;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x0")]
			private Action<KdTreeNode<TKey, TValue>> <addLeft>5__2;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x0")]
			private Action<KdTreeNode<TKey, TValue>> <addRight>5__3;

			[Token(Token = "0x17000005")]
			private KdTreeNode<TKey, TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.Current
			{
				[Token(Token = "0x600001C")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600001E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000019")]
			[DebuggerHidden]
			public <GetEnumerator>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600001A")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600001B")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600001D")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private int dimensions;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private ITypeMath<TKey> typeMath;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		private KdTreeNode<TKey, TValue> root;

		[Token(Token = "0x17000003")]
		public AddDuplicateBehavior AddDuplicateBehavior
		{
			[Token(Token = "0x600000B")]
			[CompilerGenerated]
			get
			{
				return default(AddDuplicateBehavior);
			}
			[Token(Token = "0x600000C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int Count
		{
			[Token(Token = "0x6000010")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000011")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000009")]
		public KdTree(int dimensions, ITypeMath<TKey> typeMath)
		{
		}

		[Token(Token = "0x600000A")]
		public KdTree(int dimensions, ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior)
		{
		}

		[Token(Token = "0x600000D")]
		public bool Add(TKey[] point, TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		private void AddNearestNeighbours(KdTreeNode<TKey, TValue> node, TKey[] target, HyperRect<TKey> rect, int depth, NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey> nearestNeighbours, TKey maxSearchRadiusSquared)
		{
		}

		[Token(Token = "0x600000F")]
		public KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		private void AddNodeToStringBuilder(KdTreeNode<TKey, TValue> node, StringBuilder sb, int depth)
		{
		}

		[Token(Token = "0x6000013")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[IteratorStateMachine(typeof(KdTree<, >.<GetEnumerator>d__33))]
		public IEnumerator<KdTreeNode<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	internal class KdTreeNode<TKey, TValue>
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public TKey[] Point;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		public TValue Value;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public List<TValue> Duplicates;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		internal KdTreeNode<TKey, TValue> LeftChild;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		internal KdTreeNode<TKey, TValue> RightChild;

		[Token(Token = "0x17000007")]
		internal KdTreeNode<TKey, TValue> this[int compare]
		{
			[Token(Token = "0x6000021")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			set
			{
			}
		}

		[Token(Token = "0x600001F")]
		public KdTreeNode()
		{
		}

		[Token(Token = "0x6000020")]
		public KdTreeNode(TKey[] point, TValue value)
		{
		}

		[Token(Token = "0x6000023")]
		public void AddDuplicate(TValue value)
		{
		}

		[Token(Token = "0x6000024")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	internal interface ITypeMath<T>
	{
		[Token(Token = "0x17000008")]
		T MinValue
		{
			[Token(Token = "0x6000026")]
			get;
		}

		[Token(Token = "0x17000009")]
		T NegativeInfinity
		{
			[Token(Token = "0x6000029")]
			get;
		}

		[Token(Token = "0x1700000A")]
		T PositiveInfinity
		{
			[Token(Token = "0x600002A")]
			get;
		}

		[Token(Token = "0x6000025")]
		int Compare(T a, T b);

		[Token(Token = "0x6000027")]
		bool AreEqual(T[] a, T[] b);

		[Token(Token = "0x6000028")]
		T Multiply(T a, T b);

		[Token(Token = "0x600002B")]
		T DistanceSquaredBetweenPoints(T[] a, T[] b);
	}
	[Token(Token = "0x200000A")]
	internal class NearestNeighbourList<TItem, TDistance>
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private PriorityQueue<TItem, TDistance> queue;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		private ITypeMath<TDistance> distanceMath;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		private int maxCapacity;

		[Token(Token = "0x1700000B")]
		public int MaxCapacity
		{
			[Token(Token = "0x600002D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000C")]
		public int Count
		{
			[Token(Token = "0x600002E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool IsCapacityReached
		{
			[Token(Token = "0x6000032")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002C")]
		public NearestNeighbourList(int maxCapacity, ITypeMath<TDistance> distanceMath)
		{
		}

		[Token(Token = "0x600002F")]
		public bool Add(TItem item, TDistance distance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		public TDistance GetFurtherestDistance()
		{
			return (TDistance)null;
		}

		[Token(Token = "0x6000031")]
		public TItem RemoveFurtherest()
		{
			return (TItem)null;
		}
	}
	[Token(Token = "0x200000B")]
	internal struct ItemPriority<TItem, TPriority>
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		public TItem Item;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		public TPriority Priority;
	}
	[Token(Token = "0x200000C")]
	internal class PriorityQueue<TItem, TPriority>
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		private ITypeMath<TPriority> priorityMath;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		private ItemPriority<TItem, TPriority>[] queue;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x0")]
		private int capacity;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x0")]
		private int count;

		[Token(Token = "0x1700000E")]
		public int Count
		{
			[Token(Token = "0x6000034")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000033")]
		public PriorityQueue(int capacity, ITypeMath<TPriority> priorityMath)
		{
		}

		[Token(Token = "0x6000035")]
		private void ExpandCapacity()
		{
		}

		[Token(Token = "0x6000036")]
		public void Enqueue(TItem item, TPriority priority)
		{
		}

		[Token(Token = "0x6000037")]
		public TItem Dequeue()
		{
			return (TItem)null;
		}

		[Token(Token = "0x6000038")]
		private void ReorderItem(int index, int direction)
		{
		}

		[Token(Token = "0x6000039")]
		public TPriority GetHighestPriority()
		{
			return (TPriority)null;
		}
	}
}
namespace UnityEngine.ProBuilder.KdTree.Math
{
	[Serializable]
	[Token(Token = "0x200000D")]
	internal class FloatMath : TypeMath<float>
	{
		[Token(Token = "0x1700000F")]
		public override float MinValue
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2B71698", Offset = "0x2B6D698", VA = "0x2B71698", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000010")]
		public override float Zero
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2B716A4", Offset = "0x2B6D6A4", VA = "0x2B716A4", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public override float NegativeInfinity
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2B716AC", Offset = "0x2B6D6AC", VA = "0x2B716AC", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public override float PositiveInfinity
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2B716B8", Offset = "0x2B6D6B8", VA = "0x2B716B8", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2B7166C", Offset = "0x2B6D66C", VA = "0x2B7166C", Slot = "11")]
		public override int Compare(float a, float b)
		{
			return default(int);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2B7168C", Offset = "0x2B6D68C", VA = "0x2B7168C", Slot = "12")]
		public override bool AreEqual(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2B716C4", Offset = "0x2B6D6C4", VA = "0x2B716C4", Slot = "18")]
		public override float Add(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2B716CC", Offset = "0x2B6D6CC", VA = "0x2B716CC", Slot = "19")]
		public override float Subtract(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2B716D4", Offset = "0x2B6D6D4", VA = "0x2B716D4", Slot = "20")]
		public override float Multiply(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2B716DC", Offset = "0x2B6D6DC", VA = "0x2B716DC", Slot = "21")]
		public override float DistanceSquaredBetweenPoints(float[] a, float[] b)
		{
			return default(float);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2B717D4", Offset = "0x2B6D7D4", VA = "0x2B717D4")]
		public FloatMath()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	internal abstract class TypeMath<T> : ITypeMath<T>
	{
		[Token(Token = "0x17000013")]
		public abstract T MinValue
		{
			[Token(Token = "0x6000048")]
			get;
		}

		[Token(Token = "0x17000014")]
		public abstract T Zero
		{
			[Token(Token = "0x6000049")]
			get;
		}

		[Token(Token = "0x17000015")]
		public abstract T NegativeInfinity
		{
			[Token(Token = "0x600004A")]
			get;
		}

		[Token(Token = "0x17000016")]
		public abstract T PositiveInfinity
		{
			[Token(Token = "0x600004B")]
			get;
		}

		[Token(Token = "0x6000045")]
		public abstract int Compare(T a, T b);

		[Token(Token = "0x6000046")]
		public abstract bool AreEqual(T a, T b);

		[Token(Token = "0x6000047")]
		public virtual bool AreEqual(T[] a, T[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		public abstract T Add(T a, T b);

		[Token(Token = "0x600004D")]
		public abstract T Subtract(T a, T b);

		[Token(Token = "0x600004E")]
		public abstract T Multiply(T a, T b);

		[Token(Token = "0x600004F")]
		public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b);

		[Token(Token = "0x6000050")]
		protected TypeMath()
		{
		}
	}
}
