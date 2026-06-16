using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Services.Core.Internal;
using UnityEngine.LowLevel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Services.Core.Scheduler.Internal;

[Token(Token = "0x2000002")]
internal class ActionScheduler : IActionScheduler, IServiceComponent
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	internal readonly PlayerLoopSystem SchedulerLoopSystem;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x38")]
	private readonly ITimeProvider m_TimeProvider;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x40")]
	private readonly object m_Lock;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x48")]
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x50")]
	private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<ScheduledInvocation> m_ExpiredActions;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x60")]
	private long m_NextId;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2DAC910", Offset = "0x2DA8910", VA = "0x2DAC910")]
	public ActionScheduler()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2DAC974", Offset = "0x2DA8974", VA = "0x2DAC974")]
	public ActionScheduler(ITimeProvider timeProvider)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2DACB9C", Offset = "0x2DA8B9C", VA = "0x2DACB9C")]
	internal void ExecuteExpiredActions()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2DAD120", Offset = "0x2DA9120", VA = "0x2DAD120")]
	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2DAD1A0", Offset = "0x2DA91A0", VA = "0x2DAD1A0")]
	public void JoinPlayerLoopSystem()
	{
	}
}
[Token(Token = "0x2000003")]
internal abstract class MinimumBinaryHeap
{
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2DAD34C", Offset = "0x2DA934C", VA = "0x2DAD34C")]
	protected MinimumBinaryHeap()
	{
	}
}
[Token(Token = "0x2000004")]
internal class MinimumBinaryHeap<T> : MinimumBinaryHeap
{
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x0")]
	private readonly object m_Lock;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x0")]
	private readonly IComparer<T> m_Comparer;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_MinimumCapacity;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x0")]
	private T[] m_HeapArray;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x6000007")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000008")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public T Min
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x600000A")]
	public MinimumBinaryHeap(IComparer<T> comparer, int minimumCapacity = 10)
	{
	}

	[Token(Token = "0x600000B")]
	internal MinimumBinaryHeap(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10)
	{
	}

	[Token(Token = "0x600000C")]
	public void Insert(T item)
	{
	}

	[Token(Token = "0x600000D")]
	private void IncreaseHeapCapacityWhenFull()
	{
	}

	[Token(Token = "0x600000E")]
	public void Remove(T item)
	{
	}

	[Token(Token = "0x600000F")]
	private int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	public T ExtractMin()
	{
		return (T)null;
	}

	[Token(Token = "0x6000011")]
	private void DecreaseHeapCapacityWhenSpare()
	{
	}

	[Token(Token = "0x6000012")]
	private void MinHeapify()
	{
	}

	[Token(Token = "0x6000013")]
	private static void Swap(ref T lhs, ref T rhs)
	{
	}

	[Token(Token = "0x6000014")]
	private static int GetParentIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6000015")]
	private static int GetLeftChildIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6000016")]
	private static int GetRightChildIndex(int index)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
internal class ScheduledInvocation
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x10")]
	public Action Action;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public DateTime InvocationTime;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	public long ActionId;
}
[Token(Token = "0x2000007")]
internal class ScheduledInvocationComparer : IComparer<ScheduledInvocation>
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2DAD354", Offset = "0x2DA9354", VA = "0x2DAD354", Slot = "4")]
	public int Compare(ScheduledInvocation x, ScheduledInvocation y)
	{
		return default(int);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2DACB94", Offset = "0x2DA8B94", VA = "0x2DACB94")]
	public ScheduledInvocationComparer()
	{
	}
}
[Token(Token = "0x2000008")]
internal interface ITimeProvider
{
	[Token(Token = "0x17000003")]
	DateTime Now
	{
		[Token(Token = "0x600001B")]
		get;
	}
}
[Token(Token = "0x2000009")]
internal class UtcTimeProvider : ITimeProvider
{
	[Token(Token = "0x17000004")]
	public DateTime Now
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2DAD3FC", Offset = "0x2DA93FC", VA = "0x2DAD3FC", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2DAC96C", Offset = "0x2DA896C", VA = "0x2DAC96C")]
	public UtcTimeProvider()
	{
	}
}
