using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Purchasing.Utilities;
using Uniject;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2C5B9BC", Offset = "0x2C579BC", VA = "0x2C5B9BC")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] NullableFlags;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C5B9C4", Offset = "0x2C579C4", VA = "0x2C5B9C4")]
		public NullableAttribute(byte P_0)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C5BA44", Offset = "0x2C57A44", VA = "0x2C5BA44")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte Flag;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C5BA6C", Offset = "0x2C57A6C", VA = "0x2C5BA6C")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Uniject
{
	[Token(Token = "0x2000005")]
	internal interface IThreadUtils
	{
		[Token(Token = "0x17000001")]
		bool IsRunningOnMainThread
		{
			[Token(Token = "0x6000005")]
			get;
		}

		[Token(Token = "0x6000006")]
		Task PostAsync(Action action);
	}
	[Token(Token = "0x2000006")]
	internal interface IUtil
	{
		[Token(Token = "0x6000007")]
		void RunOnMainThread(Action runnable);

		[Token(Token = "0x6000008")]
		void AddPauseListener(Action<bool> runnable);
	}
	[Token(Token = "0x2000007")]
	[Preserve]
	internal class UnityThreadUtils : IThreadUtils
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_UnityThreadId;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static TaskScheduler UnityThreadScheduler;

		[Token(Token = "0x17000002")]
		public bool IsRunningOnMainThread
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2C5BB30", Offset = "0x2C57B30", VA = "0x2C5BB30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2C5BA94", Offset = "0x2C57A94", VA = "0x2C5BA94")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void CaptureUnityThreadInfo()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2C5BB90", Offset = "0x2C57B90", VA = "0x2C5BB90", Slot = "5")]
		public Task PostAsync(Action action)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C5BC88", Offset = "0x2C57C88", VA = "0x2C5BC88")]
		public UnityThreadUtils()
		{
		}
	}
}
namespace Purchasing.Utilities
{
	[Token(Token = "0x2000008")]
	internal interface IMonoBehaviourUtil
	{
		[Token(Token = "0x600000D")]
		Coroutine StartCoroutine(IEnumerator start);
	}
	[Token(Token = "0x2000009")]
	[HideInInspector]
	[AddComponentMenu("")]
	internal class MonoBehaviourUtil : MonoBehaviour, IMonoBehaviourUtil
	{
		[Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class <DelayedCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int delay;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MonoBehaviourUtil <>4__this;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IEnumerator coroutine;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000015")]
				[Address(RVA = "0x2C5BED4", Offset = "0x2C57ED4", VA = "0x2C5BED4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000017")]
				[Address(RVA = "0x2C5BF14", Offset = "0x2C57F14", VA = "0x2C5BF14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2C5BDE4", Offset = "0x2C57DE4", VA = "0x2C5BDE4")]
			[DebuggerHidden]
			public <DelayedCoroutine>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2C5BE1C", Offset = "0x2C57E1C", VA = "0x2C5BE1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2C5BE20", Offset = "0x2C57E20", VA = "0x2C5BE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2C5BEDC", Offset = "0x2C57EDC", VA = "0x2C5BEDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C5BC90", Offset = "0x2C57C90", VA = "0x2C5BC90", Slot = "5")]
		public GameObject[] GetGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C5BD70", Offset = "0x2C57D70", VA = "0x2C5BD70", Slot = "6")]
		[IteratorStateMachine(typeof(<DelayedCoroutine>d__1))]
		public IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C5BE0C", Offset = "0x2C57E0C", VA = "0x2C5BE0C", Slot = "4")]
		private Coroutine Purchasing.Utilities.IMonoBehaviourUtil.StartCoroutine(IEnumerator start)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2C5BE14", Offset = "0x2C57E14", VA = "0x2C5BE14")]
		public MonoBehaviourUtil()
		{
		}
	}
}
namespace UnityEngine.Purchasing
{
	[Token(Token = "0x200000B")]
	internal static class EnumerableExtensions
	{
		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class <IgnoreExceptions>d__1<T, TException> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where TException : notnull, Exception
		{
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerable<T> enumerable;

			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerable<T> <>3__enumerable;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<TException> onException;

			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TException> <>3__onException;

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<T> <enumerator>5__2;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool <hasNext>5__3;

			[Token(Token = "0x17000005")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000021")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000023")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600001D")]
			[DebuggerHidden]
			public <IgnoreExceptions>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600001E")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600001F")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000020")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000022")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000024")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000025")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000018")]
		public static IEnumerable<T> NonNull<T>(this IEnumerable<T> enumerable) where T : notnull
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[IteratorStateMachine(typeof(<IgnoreExceptions>d__1<, >))]
		public static IEnumerable<T> IgnoreExceptions<T, TException>(this IEnumerable<T> enumerable, [Optional] Action<TException>? onException) where T : notnull where TException : notnull, Exception
		{
			return null;
		}
	}
	[Token(Token = "0x200000E")]
	internal static class LoggerExtensions
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2C5BF1C", Offset = "0x2C57F1C", VA = "0x2C5BF1C")]
		public static void LogIAP(this ILogger logger, string message)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2C5BFE0", Offset = "0x2C57FE0", VA = "0x2C5BFE0")]
		public static void LogIAPError(this ILogger logger, string message)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2C5C0A4", Offset = "0x2C580A4", VA = "0x2C5C0A4")]
		public static void LogIAPException(this ILogger logger, Exception exception)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2C5C210", Offset = "0x2C58210", VA = "0x2C5C210")]
		public static void LogIAPWarning(this ILogger logger, string message)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class MiniJson
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2C5C2D4", Offset = "0x2C582D4", VA = "0x2C5C2D4")]
		public static string JsonEncode(object json)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2C5C2DC", Offset = "0x2C582DC", VA = "0x2C5C2DC")]
		public static object JsonDecode(string json)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	internal class TaskQueue
	{
		[StructLayout(3)]
		[Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <Enqueue>d__2<T> : IAsyncStateMachine where T : notnull
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TaskQueue <>4__this;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<Task<T>> taskGenerator;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<T> <>u__2;

			[Token(Token = "0x600002E")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600002F")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly SemaphoreSlim semaphore;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2C5C334", Offset = "0x2C58334", VA = "0x2C5C334")]
		public TaskQueue()
		{
		}

		[Token(Token = "0x600002D")]
		[AsyncStateMachine(typeof(<Enqueue>d__2<>))]
		public Task<T> Enqueue<T>(Func<Task<T>> taskGenerator) where T : notnull
		{
			return null;
		}
	}
	[Token(Token = "0x2000012")]
	internal interface ITransactionLog
	{
		[Token(Token = "0x6000030")]
		bool HasRecordOf(string transactionID);

		[Token(Token = "0x6000031")]
		void Record(string transactionID);
	}
	[Token(Token = "0x2000013")]
	internal class TransactionLog : ITransactionLog
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string? m_PersistentDataPath;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2C5C39C", Offset = "0x2C5839C", VA = "0x2C5C39C")]
		public TransactionLog(string persistentDataPath)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2C5C45C", Offset = "0x2C5845C", VA = "0x2C5C45C", Slot = "4")]
		public bool HasRecordOf(string transactionID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2C5C530", Offset = "0x2C58530", VA = "0x2C5C530", Slot = "5")]
		public void Record(string transactionID)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2C5C4B8", Offset = "0x2C584B8", VA = "0x2C5C4B8")]
		private static string GetRecordPath(string dataPath, string transactionID)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2C5C644", Offset = "0x2C58644", VA = "0x2C5C644")]
		private static string ComputeHash(string transactionID)
		{
			return null;
		}
	}
}
namespace UnityEngine.Purchasing.Extension
{
	[Token(Token = "0x2000014")]
	internal class UnityUtil : IUtil
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IThreadUtils m_ThreadUtils;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IMonoBehaviourUtil m_MonoBehaviourUtils;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<RuntimePlatform> s_PcControlledPlatforms;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<Action<bool>> pauseListeners;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2C5C7B8", Offset = "0x2C587B8", VA = "0x2C5C7B8")]
		[Preserve]
		public UnityUtil(IThreadUtils threadUtils, IMonoBehaviourUtil monoBehaviorUtil)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2C5C84C", Offset = "0x2C5884C", VA = "0x2C5C84C", Slot = "4")]
		public void RunOnMainThread(Action runnable)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2C5C984", Offset = "0x2C58984", VA = "0x2C5C984", Slot = "5")]
		public void AddPauseListener(Action<bool> runnable)
		{
		}
	}
}
namespace UnityEngine.Purchasing.MiniJSON
{
	[Token(Token = "0x2000015")]
	public static class Json
	{
		[Token(Token = "0x2000016")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000017")]
			private enum TOKEN
			{
				[Token(Token = "0x4000023")]
				NONE,
				[Token(Token = "0x4000024")]
				CURLY_OPEN,
				[Token(Token = "0x4000025")]
				CURLY_CLOSE,
				[Token(Token = "0x4000026")]
				SQUARED_OPEN,
				[Token(Token = "0x4000027")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000028")]
				COLON,
				[Token(Token = "0x4000029")]
				COMMA,
				[Token(Token = "0x400002A")]
				STRING,
				[Token(Token = "0x400002B")]
				NUMBER,
				[Token(Token = "0x400002C")]
				TRUE,
				[Token(Token = "0x400002D")]
				FALSE,
				[Token(Token = "0x400002E")]
				NULL
			}

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000007")]
			private char PeekChar
			{
				[Token(Token = "0x6000048")]
				[Address(RVA = "0x2C5DA80", Offset = "0x2C59A80", VA = "0x2C5DA80")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000008")]
			private char NextChar
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0x2C5D8B0", Offset = "0x2C598B0", VA = "0x2C5D8B0")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000009")]
			private string NextWord
			{
				[Token(Token = "0x600004A")]
				[Address(RVA = "0x2C5D928", Offset = "0x2C59928", VA = "0x2C5D928")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private TOKEN NextToken
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0x2C5D0F4", Offset = "0x2C590F4", VA = "0x2C5D0F4")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2C5CE7C", Offset = "0x2C58E7C", VA = "0x2C5CE7C")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2C5CF18", Offset = "0x2C58F18", VA = "0x2C5CF18")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2C5CCAC", Offset = "0x2C58CAC", VA = "0x2C5CCAC")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2C5CFA8", Offset = "0x2C58FA8", VA = "0x2C5CFA8", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2C5CFD0", Offset = "0x2C58FD0", VA = "0x2C5CFD0")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2C5D534", Offset = "0x2C59534", VA = "0x2C5D534")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2C5CF8C", Offset = "0x2C58F8C", VA = "0x2C5CF8C")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2C5D65C", Offset = "0x2C5965C", VA = "0x2C5D65C")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2C5D2B8", Offset = "0x2C592B8", VA = "0x2C5D2B8")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2C5D75C", Offset = "0x2C5975C", VA = "0x2C5D75C")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2C5D9DC", Offset = "0x2C599DC", VA = "0x2C5D9DC")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000018")]
		private sealed class Serializer
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly StringBuilder builder;

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2C5DAF8", Offset = "0x2C59AF8", VA = "0x2C5DAF8")]
			private Serializer()
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2C5CE08", Offset = "0x2C58E08", VA = "0x2C5CE08")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2C5DB5C", Offset = "0x2C59B5C", VA = "0x2C5DB5C")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2C5E328", Offset = "0x2C5A328", VA = "0x2C5E328")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2C5E004", Offset = "0x2C5A004", VA = "0x2C5E004")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2C5DD2C", Offset = "0x2C59D2C", VA = "0x2C5DD2C")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2C5E768", Offset = "0x2C5A768", VA = "0x2C5E768")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2C5C308", Offset = "0x2C58308", VA = "0x2C5C308")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2C5C2D8", Offset = "0x2C582D8", VA = "0x2C5C2D8")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public static class MiniJsonExtensions
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2C5EA48", Offset = "0x2C5AA48", VA = "0x2C5EA48")]
		public static string toJson(this Dictionary<string, object> obj)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2C5EA4C", Offset = "0x2C5AA4C", VA = "0x2C5EA4C")]
		public static List<object> ArrayListFromJson(this string json)
		{
			return null;
		}
	}
}
