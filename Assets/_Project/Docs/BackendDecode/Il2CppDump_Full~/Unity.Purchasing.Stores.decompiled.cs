using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Purchasing.Extension;
using Stores.Android.GooglePlay.AAR.Interfaces;
using Uniject;
using Unity.Services.Analytics;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Internal;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Services;
using UnityEngine.Purchasing.Telemetry;
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
		[Address(RVA = "0x2C32360", Offset = "0x2C2E360", VA = "0x2C32360")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] NullableFlags;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C32368", Offset = "0x2C2E368", VA = "0x2C32368")]
		public NullableAttribute(byte P_0)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C323E8", Offset = "0x2C2E3E8", VA = "0x2C323E8")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte Flag;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C32410", Offset = "0x2C2E410", VA = "0x2C32410")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Stores.Android.GooglePlay.AAR.Interfaces
{
	[Token(Token = "0x2000005")]
	internal interface IGooglePurchasesUpdatedHandler
	{
		[Token(Token = "0x6000005")]
		void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache productCache);
	}
}
namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000006")]
	internal class AnalyticsClient : UnityEngine.Purchasing.IAnalyticsClient
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.IAnalyticsAdapter m_Analytics;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C32438", Offset = "0x2C2E438", VA = "0x2C32438")]
		[Preserve]
		internal AnalyticsClient(UnityEngine.Purchasing.IAnalyticsAdapter analytics)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2C32460", Offset = "0x2C2E460", VA = "0x2C32460", Slot = "4")]
		public void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2C32894", Offset = "0x2C2E894", VA = "0x2C32894", Slot = "5")]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}
	}
	[Token(Token = "0x2000007")]
	[Preserve]
	internal class AnalyticsServiceWrapper : IAnalyticsServiceWrapper
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2C32CA0", Offset = "0x2C2ECA0", VA = "0x2C32CA0", Slot = "4")]
		public IAnalyticsService? AnalyticsServiceInstance()
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2C32DA8", Offset = "0x2C2EDA8", VA = "0x2C32DA8")]
		public AnalyticsServiceWrapper()
		{
		}
	}
	[Token(Token = "0x2000008")]
	internal class CoreAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ILogger m_Logger;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IAnalyticsStandardEventComponent? m_CoreAnalytics;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TransactionEventHelper m_TransactionEventHelper;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2C32DB0", Offset = "0x2C2EDB0", VA = "0x2C32DB0")]
		[Preserve]
		internal CoreAnalyticsAdapter(IAnalyticsServiceWrapper analytics, ILogger logger)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C32E58", Offset = "0x2C2EE58", VA = "0x2C32E58", Slot = "4")]
		public void SendTransactionEvent(CartItem item, string receipt)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C33084", Offset = "0x2C2F084", VA = "0x2C33084")]
		private Dictionary<string, object> BuildTransactionParameters(CartItem item, string receipt)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C33820", Offset = "0x2C2F820", VA = "0x2C33820", Slot = "5")]
		public void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C32F7C", Offset = "0x2C2EF7C", VA = "0x2C32F7C")]
		private IAnalyticsStandardEventComponent? CoreAnalyticsComponent()
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C33A4C", Offset = "0x2C2FA4C", VA = "0x2C33A4C")]
		private Dictionary<string, object> BuildTransactionFailedParameters(CartItem item, string failureReason)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2C33554", Offset = "0x2C2F554", VA = "0x2C33554")]
		private static Dictionary<string, object> GenerateItemReceivedForPurchase(CartItem item)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2C3348C", Offset = "0x2C2F48C", VA = "0x2C3348C")]
		private Dictionary<string, object> GenerateRealCurrencySpentOnPurchase(Product product)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2C33C3C", Offset = "0x2C2FC3C", VA = "0x2C33C3C")]
		private Dictionary<string, object> CreateRealCurrencyFromProduct(Product product)
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	internal interface IAnalyticsServiceWrapper
	{
		[Token(Token = "0x6000014")]
		IAnalyticsService? AnalyticsServiceInstance();
	}
	[Token(Token = "0x200000A")]
	internal class AnalyticsTransactionReceipt
	{
		[Token(Token = "0x17000001")]
		public string transactionReceipt
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2C33E44", Offset = "0x2C2FE44", VA = "0x2C33E44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2C33E4C", Offset = "0x2C2FE4C", VA = "0x2C33E4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string transactionReceiptSignature
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2C33E54", Offset = "0x2C2FE54", VA = "0x2C33E54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2C33E5C", Offset = "0x2C2FE5C", VA = "0x2C33E5C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public TransactionServer? transactionServer
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2C33E64", Offset = "0x2C2FE64", VA = "0x2C33E64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2C33E6C", Offset = "0x2C2FE6C", VA = "0x2C33E6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2C33E74", Offset = "0x2C2FE74", VA = "0x2C33E74")]
		public AnalyticsTransactionReceipt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	internal class GoogleReceipt
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string json;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string signature;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2C33E7C", Offset = "0x2C2FE7C", VA = "0x2C33E7C")]
		public GoogleReceipt()
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal class CommonTransactionEventHelper
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2C33448", Offset = "0x2C2F448", VA = "0x2C33448")]
		internal static string GetTransactionName(Product product)
		{
			return null;
		}
	}
	[Token(Token = "0x200000D")]
	internal class TransactionEventHelper
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAnalyticsServiceWrapper m_Analytics;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ILogger m_Logger;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2C32E2C", Offset = "0x2C2EE2C", VA = "0x2C32E2C")]
		internal TransactionEventHelper(IAnalyticsServiceWrapper analytics, ILogger logger)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2C33D8C", Offset = "0x2C2FD8C", VA = "0x2C33D8C")]
		internal long CheckCurrencyCodeAndExtractRealCurrencyAmount(Product product)
		{
			return default(long);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2C33E84", Offset = "0x2C2FE84", VA = "0x2C33E84")]
		private long ExtractRealCurrencyAmount(Product product)
		{
			return default(long);
		}
	}
	[Token(Token = "0x200000E")]
	internal class TransactionFailedEventHelper
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2C33968", Offset = "0x2C2F968", VA = "0x2C33968")]
		internal static string BuildFailureReason(PurchaseFailureDescription failureDescription)
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	internal static class UnifiedReceiptAnalyticsExtensions
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2C3335C", Offset = "0x2C2F35C", VA = "0x2C3335C")]
		public static AnalyticsTransactionReceipt ToReceiptAndSignature(this UnifiedReceipt receipt)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2C340F8", Offset = "0x2C300F8", VA = "0x2C340F8")]
		private static TransactionServer? ToTransactionServer(this UnifiedReceipt receipt)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	[Preserve]
	internal class GoogleCachedQueryProductDetailsService : IGoogleCachedQueryProductDetailsService
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ConcurrentDictionary<string, AndroidJavaObject> m_CachedQueriedProductDetails;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2C34204", Offset = "0x2C30204", VA = "0x2C34204", Slot = "1")]
		~GoogleCachedQueryProductDetailsService()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2C344CC", Offset = "0x2C304CC", VA = "0x2C344CC", Slot = "4")]
		public IEnumerable<AndroidJavaObject> GetCachedQueriedProducts()
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2C3451C", Offset = "0x2C3051C", VA = "0x2C3451C")]
		private AndroidJavaObject GetCachedQueriedProductDetails(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2C34574", Offset = "0x2C30574", VA = "0x2C34574")]
		private IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<string> productIds)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2C34618", Offset = "0x2C30618", VA = "0x2C34618", Slot = "5")]
		public IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2C34744", Offset = "0x2C30744", VA = "0x2C34744")]
		private bool Contains(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2C3479C", Offset = "0x2C3079C", VA = "0x2C3479C", Slot = "6")]
		public bool Contains(ProductDefinition products)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2C347B0", Offset = "0x2C307B0", VA = "0x2C347B0", Slot = "7")]
		public void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2C34B60", Offset = "0x2C30B60", VA = "0x2C34B60")]
		public GoogleCachedQueryProductDetailsService()
		{
		}
	}
	[Token(Token = "0x2000012")]
	internal class GoogleFinishTransactionUseCase : IGoogleFinishTransactionUseCase
	{
		[StructLayout(3)]
		[Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <FinishTransaction>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GoogleFinishTransactionUseCase <>4__this;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string purchaseToken;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProductDefinition product;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<UnityEngine.Purchasing.Interfaces.IGooglePurchase?> <>u__1;

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2C35024", Offset = "0x2C31024", VA = "0x2C35024", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2C35400", Offset = "0x2C31400", VA = "0x2C35400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2C34C54", Offset = "0x2C30C54", VA = "0x2C34C54")]
		[Preserve]
		internal GoogleFinishTransactionUseCase(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2C34C80", Offset = "0x2C30C80", VA = "0x2C34C80", Slot = "4")]
		[AsyncStateMachine(typeof(<FinishTransaction>d__3))]
		public Task FinishTransaction(ProductDefinition? product, string? purchaseToken, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2C34D64", Offset = "0x2C30D64", VA = "0x2C34D64")]
		private void FinishTransactionForPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, ProductDefinition? product, string? purchaseToken, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)
		{
		}
	}
	[Token(Token = "0x2000015")]
	[Preserve]
	internal class GoogleLastKnownProductService : IGoogleLastKnownProductService
	{
		[Token(Token = "0x17000004")]
		public string? LastKnownOldProductId
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2C35468", Offset = "0x2C31468", VA = "0x2C35468", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2C35470", Offset = "0x2C31470", VA = "0x2C35470", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string? LastKnownProductId
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2C35478", Offset = "0x2C31478", VA = "0x2C35478", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2C35480", Offset = "0x2C31480", VA = "0x2C35480", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public GooglePlayReplacementMode? LastKnownReplacementMode
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2C35488", Offset = "0x2C31488", VA = "0x2C35488", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2C35490", Offset = "0x2C31490", VA = "0x2C35490", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2C35498", Offset = "0x2C31498", VA = "0x2C35498")]
		public GoogleLastKnownProductService()
		{
		}
	}
	[Token(Token = "0x2000016")]
	internal class GooglePlayCheckEntitlementUseCase : IGooglePlayCheckEntitlementUseCase
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2C35508", Offset = "0x2C31508", VA = "0x2C35508")]
		[Preserve]
		internal GooglePlayCheckEntitlementUseCase(IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
		}
	}
	[Token(Token = "0x2000017")]
	internal class GooglePlayStoreService : UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService
	{
		[StructLayout(3)]
		[Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <FetchProducts>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GooglePlayStoreService <>4__this;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<List<ProductDescription>> onProductsReceived;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<UnityEngine.Purchasing.Exceptions.GoogleFetchProductException> onFetchProductsFailed;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<List<ProductDescription>> <>u__1;

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2C35BAC", Offset = "0x2C31BAC", VA = "0x2C35BAC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2C35F98", Offset = "0x2C31F98", VA = "0x2C35F98", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <FetchPurchases>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GooglePlayStoreService <>4__this;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string?> onQueryPurchaseFailed;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2C35FA4", Offset = "0x2C31FA4", VA = "0x2C35FA4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2C36200", Offset = "0x2C32200", VA = "0x2C36200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <FinishTransaction>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GooglePlayStoreService <>4__this;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ProductDefinition product;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string purchaseToken;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2C3620C", Offset = "0x2C3220C", VA = "0x2C3620C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2C36470", Offset = "0x2C32470", VA = "0x2C36470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <TryFetchPurchases>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GooglePlayStoreService <>4__this;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2C364D8", Offset = "0x2C324D8", VA = "0x2C364D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2C36780", Offset = "0x2C32780", VA = "0x2C36780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IGooglePurchaseService m_GooglePurchaseService;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IGoogleFinishTransactionUseCase m_GoogleFinishTransactionUseCase;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly IGooglePlayCheckEntitlementUseCase m_GoogleCheckEntitlementUseCase;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly IGooglePlayStoreConnectionService m_GooglePlayStoreConnectionService;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2C35530", Offset = "0x2C31530", VA = "0x2C35530")]
		internal GooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2C355A4", Offset = "0x2C315A4", VA = "0x2C355A4", Slot = "8")]
		[AsyncStateMachine(typeof(<FetchProducts>d__10))]
		public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<UnityEngine.Purchasing.Exceptions.GoogleFetchProductException> onFetchProductsFailed)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2C35654", Offset = "0x2C31654", VA = "0x2C35654", Slot = "5")]
		public void Purchase(ProductDefinition product)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2C35668", Offset = "0x2C31668", VA = "0x2C35668", Slot = "9")]
		public virtual void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2C35954", Offset = "0x2C31954", VA = "0x2C35954", Slot = "6")]
		[AsyncStateMachine(typeof(<FinishTransaction>d__13))]
		public Task FinishTransaction(ProductDefinition? product, string? purchaseToken, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2C35A38", Offset = "0x2C31A38", VA = "0x2C35A38", Slot = "7")]
		[AsyncStateMachine(typeof(<FetchPurchases>d__14))]
		public void FetchPurchases(Action<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed, Action<string?> onQueryPurchaseFailed)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2C35ADC", Offset = "0x2C31ADC", VA = "0x2C35ADC")]
		[AsyncStateMachine(typeof(<TryFetchPurchases>d__15))]
		private Task TryFetchPurchases(Action<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed)
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	internal class GooglePurchaseService : IGooglePurchaseService
	{
		[StructLayout(3)]
		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <Purchase>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GooglePurchaseService <>4__this;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProductDefinition product;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Order currentOrder;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public GooglePlayReplacementMode? desiredReplacementMode;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<List<AndroidJavaObject>> <>u__1;

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2C37568", Offset = "0x2C33568", VA = "0x2C37568", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2C377C8", Offset = "0x2C337C8", VA = "0x2C377C8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ILogger m_Logger;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEngine.Purchasing.Extension.IProductCache? m_ProductCache;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2C367E8", Offset = "0x2C327E8", VA = "0x2C367E8")]
		[Preserve]
		internal GooglePurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, ILogger logger)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2C36828", Offset = "0x2C32828", VA = "0x2C36828", Slot = "4")]
		[AsyncStateMachine(typeof(<Purchase>d__6))]
		public void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2C368D8", Offset = "0x2C328D8", VA = "0x2C368D8")]
		private void OnQueryProductDetailsResponse(List<AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2C3698C", Offset = "0x2C3298C", VA = "0x2C3698C")]
		private bool ValidateQueryProductDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Order? currentOrder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2C36B98", Offset = "0x2C32B98", VA = "0x2C36B98")]
		private bool ValidateSkus(List<AndroidJavaObject>? skus)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2C370F4", Offset = "0x2C330F4", VA = "0x2C370F4")]
		private void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject>? skus)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2C36BF8", Offset = "0x2C32BF8", VA = "0x2C36BF8")]
		private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2C36DAC", Offset = "0x2C32DAC", VA = "0x2C36DAC")]
		private static bool ValidateCurrentOrder(Order? currentOrder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2C36E70", Offset = "0x2C32E70", VA = "0x2C36E70")]
		private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Order? currentOrder)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2C369F0", Offset = "0x2C329F0", VA = "0x2C369F0")]
		private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2C37238", Offset = "0x2C33238", VA = "0x2C37238")]
		private void HandleBillingFlowResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, AndroidJavaObject sku)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2C37560", Offset = "0x2C33560", VA = "0x2C37560", Slot = "5")]
		public void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache? productCache)
		{
		}
	}
	[Token(Token = "0x200001E")]
	internal class GooglePurchasesUpdatedHandler : IGooglePurchasesUpdatedHandler
	{
		[StructLayout(3)]
		[Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <HandleUserCancelledPurchaseFailure>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GooglePurchasesUpdatedHandler <>4__this;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2C3A7B8", Offset = "0x2C367B8", VA = "0x2C3A7B8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2C3AA0C", Offset = "0x2C36A0C", VA = "0x2C3AA0C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IGoogleLastKnownProductService m_LastKnownProductService;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEngine.Purchasing.Extension.IProductCache? m_ProductCache;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2C377D4", Offset = "0x2C337D4", VA = "0x2C377D4")]
		[Preserve]
		internal GooglePurchasesUpdatedHandler(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2C37814", Offset = "0x2C33814", VA = "0x2C37814")]
		public void SubscribeToPurchasesUpdatedEvent(IGooglePurchasesUpdatedListener purchasesUpdatedListener)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2C378F8", Offset = "0x2C338F8", VA = "0x2C378F8", Slot = "5")]
		public void HandleUpdatedPurchases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2C379D4", Offset = "0x2C339D4", VA = "0x2C379D4")]
		private void HandleResultOkCases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2C37A98", Offset = "0x2C33A98", VA = "0x2C37A98")]
		private void HandleErrorCases(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2C3895C", Offset = "0x2C3495C", VA = "0x2C3895C")]
		private void HandleExistingPurchasesErrorCase(List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2C37C60", Offset = "0x2C33C60", VA = "0x2C37C60")]
		private void HandleNoPurchasesErrorCase(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2C38B5C", Offset = "0x2C34B5C", VA = "0x2C38B5C")]
		[AsyncStateMachine(typeof(<HandleUserCancelledPurchaseFailure>d__12))]
		private void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2C38BF4", Offset = "0x2C34BF4", VA = "0x2C38BF4")]
		private void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2C37B1C", Offset = "0x2C33B1C", VA = "0x2C37B1C")]
		private void ApplyOnPurchases(List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2C38D40", Offset = "0x2C34D40", VA = "0x2C38D40")]
		private void OnPurchaseOk(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2C39798", Offset = "0x2C35798", VA = "0x2C39798")]
		private void HandlePurchasedProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2C39B70", Offset = "0x2C35B70", VA = "0x2C39B70")]
		private bool IsDeferredSubscriptionChange(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2C39CB8", Offset = "0x2C35CB8", VA = "0x2C39CB8")]
		private bool IsLastReplacementModeDeferred()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2C391CC", Offset = "0x2C351CC", VA = "0x2C391CC")]
		private void OnPurchaseCancelled(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2C39D88", Offset = "0x2C35D88", VA = "0x2C39D88")]
		private void OnPurchaseCancelled(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2C3A058", Offset = "0x2C36058", VA = "0x2C3A058")]
		private void OnPurchaseAlreadyOwned(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2C3A328", Offset = "0x2C36328", VA = "0x2C3A328")]
		private void OnPurchaseFailedForUnknownReason(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase, string debugMessage)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2C3A5C0", Offset = "0x2C365C0", VA = "0x2C3A5C0", Slot = "4")]
		public void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache? productCache)
		{
		}
	}
	[Token(Token = "0x2000021")]
	internal class GoogleQueryPurchasesUseCase : IGoogleQueryPurchasesUseCase
	{
		[Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string purchaseToken;

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2C3B030", Offset = "0x2C37030", VA = "0x2C3B030")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2C3B038", Offset = "0x2C37038", VA = "0x2C3B038")]
			internal bool <GetPurchaseByToken>b__0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <GetPurchaseByToken>d__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string purchaseToken;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GoogleQueryPurchasesUseCase <>4__this;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass5_0 <>8__1;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2C3B0E8", Offset = "0x2C370E8", VA = "0x2C3B0E8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2C3B408", Offset = "0x2C37408", VA = "0x2C3B408", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <QueryPurchases>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GoogleQueryPurchasesUseCase <>4__this;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1;

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2C3B484", Offset = "0x2C37484", VA = "0x2C3B484", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2C3B8C4", Offset = "0x2C378C4", VA = "0x2C3B8C4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2C3AA18", Offset = "0x2C36A18", VA = "0x2C3AA18")]
		[Preserve]
		internal GoogleQueryPurchasesUseCase(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2C3AA44", Offset = "0x2C36A44", VA = "0x2C3AA44", Slot = "4")]
		[AsyncStateMachine(typeof(<QueryPurchases>d__3))]
		public Task<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases()
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2C3AB30", Offset = "0x2C36B30", VA = "0x2C3AB30")]
		private Task<IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2C3ACC8", Offset = "0x2C36CC8", VA = "0x2C3ACC8", Slot = "5")]
		[AsyncStateMachine(typeof(<GetPurchaseByToken>d__5))]
		public Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase?>? GetPurchaseByToken(string? purchaseToken)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2C3ADBC", Offset = "0x2C36DBC", VA = "0x2C3ADBC")]
		private static bool IsResultOk(UnityEngine.Purchasing.Models.IGoogleBillingResult result)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	internal interface IGoogleCachedQueryProductDetailsService
	{
		[Token(Token = "0x6000085")]
		IEnumerable<AndroidJavaObject> GetCachedQueriedProducts();

		[Token(Token = "0x6000086")]
		IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products);

		[Token(Token = "0x6000087")]
		bool Contains(ProductDefinition products);

		[Token(Token = "0x6000088")]
		void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts);
	}
	[Token(Token = "0x2000028")]
	internal class BillingClientStateListener : AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener
	{
		[Token(Token = "0x400006B")]
		private const string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action m_OnConnected;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> m_Disconnect;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2C3B940", Offset = "0x2C37940", VA = "0x2C3B940")]
		internal BillingClientStateListener(Uniject.IUtil util)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2C3B9C4", Offset = "0x2C379C4", VA = "0x2C3B9C4", Slot = "10")]
		public void RegisterOnConnected(Action onConnected)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2C3B9CC", Offset = "0x2C379CC", VA = "0x2C3B9CC", Slot = "11")]
		public void RegisterOnDisconnected(Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2C3B9D4", Offset = "0x2C379D4", VA = "0x2C3B9D4")]
		[Preserve]
		public void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2C3BB00", Offset = "0x2C37B00", VA = "0x2C3BB00")]
		private void HandleBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2C3BC78", Offset = "0x2C37C78", VA = "0x2C3BC78")]
		[Preserve]
		public void onBillingServiceDisconnected()
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
	{
		[Token(Token = "0x4000071")]
		private const string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2C3BDA8", Offset = "0x2C37DA8", VA = "0x2C3BDA8")]
		internal GoogleAcknowledgePurchaseListener(Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2C3BE30", Offset = "0x2C37E30", VA = "0x2C3BE30")]
		[Preserve]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal class GoogleConsumeResponseListener : AndroidJavaProxy
	{
		[Token(Token = "0x4000076")]
		private const string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2C3BFF4", Offset = "0x2C37FF4", VA = "0x2C3BFF4")]
		internal GoogleConsumeResponseListener(Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2C3C07C", Offset = "0x2C3807C", VA = "0x2C3C07C")]
		[Preserve]
		private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
		}
	}
	[Token(Token = "0x200002E")]
	internal class GooglePurchasesResponseListener : AndroidJavaProxy
	{
		[Token(Token = "0x400007B")]
		private const string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>> m_OnQueryPurchasesResponse;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2C3C240", Offset = "0x2C38240", VA = "0x2C3C240")]
		internal GooglePurchasesResponseListener(Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2C3C2C8", Offset = "0x2C382C8", VA = "0x2C3C2C8")]
		[Preserve]
		public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases)
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal class GooglePurchasesUpdatedListener : AndroidJavaProxy, IGooglePurchasesUpdatedListener
	{
		[Token(Token = "0x4000081")]
		private const string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener";

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x14000001")]
		public event Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> OnPurchaseUpdated
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2C3C5D0", Offset = "0x2C385D0", VA = "0x2C3C5D0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x2C3C680", Offset = "0x2C38680", VA = "0x2C3C680", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2C3C730", Offset = "0x2C38730", VA = "0x2C3C730")]
		internal GooglePurchasesUpdatedListener(IGooglePurchaseBuilder purchaseBuilder, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2C3C7B8", Offset = "0x2C387B8", VA = "0x2C3C7B8")]
		[Preserve]
		public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2C3C8EC", Offset = "0x2C388EC", VA = "0x2C3C8EC")]
		private void HandlePurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal class ProductDetailsResponseListener : AndroidJavaProxy
	{
		[Token(Token = "0x4000088")]
		private const string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener";

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, List<AndroidJavaObject>> m_OnProductDetailsResponse;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2C3CB78", Offset = "0x2C38B78", VA = "0x2C3CB78")]
		internal ProductDetailsResponseListener(Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2C3CC10", Offset = "0x2C38C10", VA = "0x2C3CC10")]
		[Preserve]
		public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject queryProductDetailsResult)
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal class MetricizedGooglePlayStoreService : GooglePlayStoreService
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2C3D09C", Offset = "0x2C3909C", VA = "0x2C3D09C")]
		[Preserve]
		internal MetricizedGooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2C3D114", Offset = "0x2C39114", VA = "0x2C3D114", Slot = "8")]
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<UnityEngine.Purchasing.Exceptions.GoogleFetchProductException> onFetchProductsFailed)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2C3D290", Offset = "0x2C39290", VA = "0x2C3D290", Slot = "9")]
		public override void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}
	}
	[Token(Token = "0x2000037")]
	internal class ProductDetailsQueryResponse : IProductDetailsQueryResponse
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ConcurrentBag<(UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> m_Responses;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2C3D454", Offset = "0x2C39454", VA = "0x2C3D454", Slot = "1")]
		~ProductDetailsQueryResponse()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2C3D950", Offset = "0x2C39950", VA = "0x2C3D950", Slot = "5")]
		public void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2C3DADC", Offset = "0x2C39ADC", VA = "0x2C3DADC", Slot = "6")]
		public List<AndroidJavaObject> ProductDetails()
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2C3DCAC", Offset = "0x2C39CAC", VA = "0x2C3DCAC", Slot = "4")]
		public bool IsRecoverable()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2C3DE20", Offset = "0x2C39E20", VA = "0x2C3DE20", Slot = "7")]
		public UnityEngine.Purchasing.Models.GoogleBillingResponseCode GetRecoverableBillingResponseCode()
		{
			return default(UnityEngine.Purchasing.Models.GoogleBillingResponseCode);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2C3E130", Offset = "0x2C3A130", VA = "0x2C3E130")]
		private static bool IsRecoverable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2C3E158", Offset = "0x2C3A158", VA = "0x2C3E158")]
		private static bool IsServiceUnavailable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2C3E200", Offset = "0x2C3A200", VA = "0x2C3E200")]
		private static bool IsDeveloperError(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2C3E2A8", Offset = "0x2C3A2A8", VA = "0x2C3E2A8")]
		public ProductDetailsQueryResponse()
		{
		}
	}
	[Token(Token = "0x2000039")]
	internal class QueryProductDetailsService : UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService
	{
		[StructLayout(3)]
		[Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <QueryInAppsAndSubsProductDetails>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ProductDetailsQueryResponse> <>t__builder;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public QueryProductDetailsService <>4__this;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<Task<(UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>)>> <tasks>5__2;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<(UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>)[]> <>u__1;

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2C3F470", Offset = "0x2C3B470", VA = "0x2C3F470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2C3F9E4", Offset = "0x2C3B9E4", VA = "0x2C3F9E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <QueryProductDescriptions>d__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<List<ProductDescription>> <>t__builder;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public QueryProductDetailsService <>4__this;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<List<AndroidJavaObject>> <>u__1;

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2C3FA60", Offset = "0x2C3BA60", VA = "0x2C3FA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2C3FD44", Offset = "0x2C3BD44", VA = "0x2C3FD44", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <QueryProductDetails>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<List<AndroidJavaObject>> <>t__builder;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public QueryProductDetailsService <>4__this;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<ProductDetailsQueryResponse> <>u__1;

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2C3FDC0", Offset = "0x2C3BDC0", VA = "0x2C3FDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2C401BC", Offset = "0x2C3C1BC", VA = "0x2C401BC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IProductDetailsConverter m_ProductDetailsConverter;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2C3E458", Offset = "0x2C3A458", VA = "0x2C3E458")]
		[Preserve]
		internal QueryProductDetailsService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2C3E494", Offset = "0x2C3A494", VA = "0x2C3E494", Slot = "4")]
		public Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2C3E5A8", Offset = "0x2C3A5A8", VA = "0x2C3E5A8", Slot = "5")]
		[AsyncStateMachine(typeof(<QueryProductDescriptions>d__5))]
		public Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2C3E6A0", Offset = "0x2C3A6A0", VA = "0x2C3E6A0", Slot = "6")]
		[AsyncStateMachine(typeof(<QueryProductDetails>d__6))]
		public virtual Task<List<AndroidJavaObject>> QueryProductDetails(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2C3E798", Offset = "0x2C3A798", VA = "0x2C3E798")]
		[AsyncStateMachine(typeof(<QueryInAppsAndSubsProductDetails>d__7))]
		private Task<ProductDetailsQueryResponse> QueryInAppsAndSubsProductDetails(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2C3E88C", Offset = "0x2C3A88C", VA = "0x2C3E88C")]
		private bool ShouldRetryQuery(IEnumerable<ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2C3E95C", Offset = "0x2C3A95C", VA = "0x2C3E95C")]
		private bool AreAllProductDetailsCached(IEnumerable<ProductDefinition> products)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2C3EB24", Offset = "0x2C3AB24", VA = "0x2C3EB24")]
		private IEnumerable<AndroidJavaObject> GetCachedProductDetails(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2C3ECB0", Offset = "0x2C3ACB0", VA = "0x2C3ECB0")]
		private Task<(UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> QueryInAppsAsync(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2C3F110", Offset = "0x2C3B110", VA = "0x2C3F110")]
		private Task<(UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> QuerySubsAsync(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2C3EE9C", Offset = "0x2C3AE9C", VA = "0x2C3EE9C")]
		private Task<(UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> QueryProductDetails(List<string> productList, string type)
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	internal class GooglePlayPurchaseCallback : IGooglePurchaseCallback
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnityEngine.Purchasing.Extension.IProductCache? m_ProductCache;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IStorePurchaseCallback? m_PurchaseCallback;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IStorePurchaseFetchCallback? m_PurchaseFetchCallback;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityEngine.Purchasing.IGooglePlayChangeSubscriptionCallback? m_ChangeSubscriptionCallback;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IGooglePurchaseConverter m_GooglePurchaseConverter;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2C40238", Offset = "0x2C3C238", VA = "0x2C40238")]
		[Preserve]
		internal GooglePlayPurchaseCallback(IGooglePurchaseConverter googlePurchaseConverter, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2C40264", Offset = "0x2C3C264", VA = "0x2C40264", Slot = "12")]
		public void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache productCache)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2C4026C", Offset = "0x2C3C26C", VA = "0x2C4026C", Slot = "4")]
		public void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2C40274", Offset = "0x2C3C274", VA = "0x2C40274", Slot = "5")]
		public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2C4027C", Offset = "0x2C3C27C", VA = "0x2C4027C", Slot = "6")]
		public void SetChangeSubscriptionCallback(UnityEngine.Purchasing.IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2C40284", Offset = "0x2C3C284", VA = "0x2C40284", Slot = "7")]
		public void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2C40348", Offset = "0x2C3C348", VA = "0x2C40348")]
		private void OnOrderPurchaseSuccessful(Order order)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2C40598", Offset = "0x2C3C598", VA = "0x2C40598", Slot = "8")]
		public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2C4067C", Offset = "0x2C3C67C", VA = "0x2C4067C", Slot = "9")]
		public void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2C40810", Offset = "0x2C3C810", VA = "0x2C40810", Slot = "10")]
		public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2C408C0", Offset = "0x2C3C8C0", VA = "0x2C408C0", Slot = "11")]
		public void NotifyUpgradeDowngradeSubscription(string sku)
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal class GooglePlayStore : global::Purchasing.Extension.InternalStore, UnityEngine.Purchasing.IGooglePlayStore, UnityEngine.Purchasing.Extension.IStore
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly IGooglePlayStoreConnectionService m_ConnectionService;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly IGooglePlayStoreFetchProductsService m_FetchProductsService;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly IGooglePlayStorePurchaseService m_StorePurchaseService;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly IGooglePlayStoreFetchPurchasesService m_PlayStoreFetchPurchasesService;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly IGooglePlayStoreCheckEntitlementService m_CheckEntitlementsService;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly IGooglePlayStoreChangeSubscriptionService m_ChangeSubscriptionService;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly ICartValidator m_CartValidator;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2C40974", Offset = "0x2C3C974", VA = "0x2C40974")]
		[Preserve]
		internal GooglePlayStore(IGooglePlayStoreFetchProductsService fetchProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGooglePlayStoreFetchPurchasesService playStoreFetchPurchasesService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePlayStoreChangeSubscriptionService changeSubscriptionService, IGooglePlayStoreCheckEntitlementService checkEntitlementsService, IGooglePurchaseCallback googlePurchaseCallback, ICartValidator cartValidator, IGooglePlayStoreConnectionService connectionService, UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2C409EC", Offset = "0x2C3C9EC", VA = "0x2C409EC", Slot = "17")]
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2C40A94", Offset = "0x2C3CA94", VA = "0x2C40A94", Slot = "18")]
		public override void FetchPurchases()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2C40A98", Offset = "0x2C3CA98", VA = "0x2C40A98")]
		private void FetchPurchasesInternal()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2C40B3C", Offset = "0x2C3CB3C", VA = "0x2C40B3C", Slot = "19")]
		public override void Purchase(ICart cart)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2C40CF8", Offset = "0x2C3CCF8", VA = "0x2C40CF8", Slot = "20")]
		public override void FinishTransaction(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2C40F4C", Offset = "0x2C3CF4C", VA = "0x2C40F4C", Slot = "16")]
		public override void Connect()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2C40FEC", Offset = "0x2C3CFEC", VA = "0x2C40FEC", Slot = "21")]
		public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2C41114", Offset = "0x2C3D114", VA = "0x2C41114", Slot = "22")]
		public override void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2C411BC", Offset = "0x2C3D1BC", VA = "0x2C411BC", Slot = "30")]
		public void SetChangeSubscriptionCallback(UnityEngine.Purchasing.IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2C41268", Offset = "0x2C3D268", VA = "0x2C41268", Slot = "23")]
		public override void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2C41314", Offset = "0x2C3D314", VA = "0x2C41314", Slot = "25")]
		public override void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2C413C0", Offset = "0x2C3D3C0", VA = "0x2C413C0", Slot = "26")]
		public override void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2C41468", Offset = "0x2C3D468", VA = "0x2C41468", Slot = "24")]
		public override void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2C41514", Offset = "0x2C3D514", VA = "0x2C41514", Slot = "31")]
		public void OnPause(bool isPaused)
		{
		}
	}
	[Token(Token = "0x2000041")]
	internal class GooglePurchaseConverter : IGooglePurchaseConverter
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2C41520", Offset = "0x2C3D520", VA = "0x2C41520")]
		[Preserve]
		internal GooglePurchaseConverter(IProductDetailsConverter productDetailsConverter)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2C41528", Offset = "0x2C3D528", VA = "0x2C41528", Slot = "4")]
		public Order CreateOrderFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.Extension.IProductCache? productCache)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2C41B6C", Offset = "0x2C3DB6C", VA = "0x2C41B6C")]
		private static ProductType GetProductType(ICart cart)
		{
			return default(ProductType);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2C418E0", Offset = "0x2C3D8E0", VA = "0x2C418E0", Slot = "5")]
		public ICart CreateCartFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.Extension.IProductCache? productCache)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2C41C9C", Offset = "0x2C3DC9C", VA = "0x2C41C9C")]
		private Product DefaultProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	internal interface IGooglePurchaseConverter
	{
		[Token(Token = "0x60000FC")]
		Order CreateOrderFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.Extension.IProductCache? productCache);
	}
	[Token(Token = "0x2000043")]
	internal class GooglePlayStoreChangeSubscriptionService : IGooglePlayStoreChangeSubscriptionService
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2C41E9C", Offset = "0x2C3DE9C", VA = "0x2C41E9C")]
		[Preserve]
		internal GooglePlayStoreChangeSubscriptionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)
		{
		}
	}
	[Token(Token = "0x2000044")]
	internal class GooglePlayStoreCheckEntitlementService : IGooglePlayStoreCheckEntitlementService
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IStoreCheckEntitlementCallback m_EntitlementCallback;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2C41EC4", Offset = "0x2C3DEC4", VA = "0x2C41EC4")]
		[Preserve]
		internal GooglePlayStoreCheckEntitlementService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2C41EEC", Offset = "0x2C3DEEC", VA = "0x2C41EEC", Slot = "4")]
		public void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal class GooglePlayStoreConnectionService : IGooglePlayStoreConnectionService
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly UnityEngine.Purchasing.Interfaces.IBillingClientStateListener m_BillingClientStateListener;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IStoreConnectCallback m_ConnectCallback;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2C41EF4", Offset = "0x2C3DEF4", VA = "0x2C41EF4")]
		[Preserve]
		public GooglePlayStoreConnectionService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2C41F20", Offset = "0x2C3DF20", VA = "0x2C41F20", Slot = "4")]
		public void Connect()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2C42140", Offset = "0x2C3E140", VA = "0x2C42140", Slot = "5")]
		public void SetConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2C42148", Offset = "0x2C3E148", VA = "0x2C42148")]
		private void OnConnected()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2C421E8", Offset = "0x2C3E1E8", VA = "0x2C421E8")]
		private void OnDisconnected(UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode)
		{
		}
	}
	[Token(Token = "0x2000046")]
	internal class GooglePlayStoreFetchProductsService : IGooglePlayStoreFetchProductsService
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IStoreProductsCallback? m_ProductsCallback;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2C422DC", Offset = "0x2C3E2DC", VA = "0x2C422DC")]
		[Preserve]
		internal GooglePlayStoreFetchProductsService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2C42304", Offset = "0x2C3E304", VA = "0x2C42304", Slot = "4")]
		public void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2C4244C", Offset = "0x2C3E44C", VA = "0x2C4244C")]
		private void OnProductsFetched(List<ProductDescription> retrievedProducts)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2C424FC", Offset = "0x2C3E4FC", VA = "0x2C424FC")]
		private void OnFetchProductsFailed(UnityEngine.Purchasing.Exceptions.GoogleFetchProductException exception)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2C425BC", Offset = "0x2C3E5BC", VA = "0x2C425BC", Slot = "5")]
		public void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
		}
	}
	[Token(Token = "0x2000047")]
	internal class GooglePlayStoreFetchPurchasesService : IGooglePlayStoreFetchPurchasesService
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGooglePurchaseConverter m_PurchaseConverter;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityEngine.Purchasing.Extension.IProductCache? m_ProductCache;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IStorePurchaseFetchCallback? m_FetchCallback;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Uniject.IUtil m_Util;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2C425C4", Offset = "0x2C3E5C4", VA = "0x2C425C4")]
		[Preserve]
		internal GooglePlayStoreFetchPurchasesService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseConverter purchaseConverter, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2C42600", Offset = "0x2C3E600", VA = "0x2C42600", Slot = "4")]
		public void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache productCache)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2C42608", Offset = "0x2C3E608", VA = "0x2C42608", Slot = "5")]
		public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2C42610", Offset = "0x2C3E610", VA = "0x2C42610", Slot = "6")]
		public void FetchPurchases()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2C42754", Offset = "0x2C3E754", VA = "0x2C42754")]
		private void OnPurchasesFetched(List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>? purchases)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2C42A0C", Offset = "0x2C3EA0C", VA = "0x2C42A0C")]
		private void PurchaseRetrievalFailedForUnknownReasons([Optional] string? message)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2C42B20", Offset = "0x2C3EB20", VA = "0x2C42B20")]
		private static Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPending()
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2C42BE8", Offset = "0x2C3EBE8", VA = "0x2C42BE8")]
		private void UpdateDeferredProductsByPurchases(List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2C42D18", Offset = "0x2C3ED18", VA = "0x2C42D18")]
		private void UpdateDeferredProductsByPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2C42EBC", Offset = "0x2C3EEBC", VA = "0x2C42EBC")]
		private void UpdateDeferredProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase, string sku)
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class GooglePlayStoreFinishTransactionService : IGooglePlayStoreFinishTransactionService
	{
		[Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GooglePlayStoreFinishTransactionService <>4__this;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ProductDefinition product;

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2C43C44", Offset = "0x2C3FC44", VA = "0x2C43C44")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2C43C4C", Offset = "0x2C3FC4C", VA = "0x2C43C4C")]
			internal void <FinishTransaction>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <FinishTransaction>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GooglePlayStoreFinishTransactionService <>4__this;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProductDefinition product;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string purchaseToken;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass9_0 <>8__1;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2C43C70", Offset = "0x2C3FC70", VA = "0x2C43C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2C440B8", Offset = "0x2C400B8", VA = "0x2C440B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly HashSet<string?> m_ProcessedPurchaseToken;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityEngine.Purchasing.Extension.IProductCache? m_ProductCache;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IStorePurchaseConfirmCallback? m_ConfirmCallback;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_RetryCount;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2C4323C", Offset = "0x2C3F23C", VA = "0x2C4323C")]
		[Preserve]
		internal GooglePlayStoreFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2C432C0", Offset = "0x2C3F2C0", VA = "0x2C432C0", Slot = "4")]
		public void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache? productCache)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2C432C8", Offset = "0x2C3F2C8", VA = "0x2C432C8", Slot = "5")]
		public void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2C432D0", Offset = "0x2C3F2D0", VA = "0x2C432D0", Slot = "6")]
		[AsyncStateMachine(typeof(<FinishTransaction>d__9))]
		public void FinishTransaction(ProductDefinition? product, string purchaseToken)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2C43374", Offset = "0x2C3F374", VA = "0x2C43374")]
		private void HandleFinishTransaction(ProductDefinition? product, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2C43B64", Offset = "0x2C3FB64", VA = "0x2C43B64")]
		private void SendTransactionFailedCallback(PurchaseFailureDescription purchaseFailureDescription, string? purchaseToken)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2C438C8", Offset = "0x2C3F8C8", VA = "0x2C438C8")]
		private void CallPurchaseSucceededUpdateReceipt(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2C439F4", Offset = "0x2C3F9F4", VA = "0x2C439F4")]
		private static bool IsResponseCodeInRecoverableState(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004D")]
	internal class GooglePlayStorePurchaseService : IGooglePlayStorePurchaseService
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2C440C4", Offset = "0x2C400C4", VA = "0x2C440C4")]
		[Preserve]
		internal GooglePlayStorePurchaseService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C440EC", Offset = "0x2C400EC", VA = "0x2C440EC", Slot = "4")]
		public void Purchase(ProductDefinition product)
		{
		}
	}
	[Token(Token = "0x200004E")]
	internal interface IGooglePlayStoreChangeSubscriptionService
	{
	}
	[Token(Token = "0x200004F")]
	internal interface IGooglePlayStoreConnectionService
	{
		[Token(Token = "0x6000128")]
		void Connect();

		[Token(Token = "0x6000129")]
		void SetConnectionCallback(IStoreConnectCallback storeConnectCallback);
	}
	[Token(Token = "0x2000050")]
	internal interface IGooglePlayStoreFetchProductsService
	{
		[Token(Token = "0x600012A")]
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		[Token(Token = "0x600012B")]
		void SetProductsCallback(IStoreProductsCallback productsCallback);
	}
	[Token(Token = "0x2000051")]
	internal interface IGooglePlayStoreFetchPurchasesService
	{
		[Token(Token = "0x600012C")]
		void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache productCache);

		[Token(Token = "0x600012D")]
		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

		[Token(Token = "0x600012E")]
		void FetchPurchases();
	}
	[Token(Token = "0x2000052")]
	internal interface IGooglePlayStoreFinishTransactionService
	{
		[Token(Token = "0x600012F")]
		void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache productCache);

		[Token(Token = "0x6000130")]
		void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

		[Token(Token = "0x6000131")]
		void FinishTransaction(ProductDefinition product, string purchaseToken);
	}
	[Token(Token = "0x2000053")]
	internal interface IGooglePlayStorePurchaseService
	{
		[Token(Token = "0x6000132")]
		void Purchase(ProductDefinition product);
	}
	[Token(Token = "0x2000054")]
	[Preserve]
	internal class AppleFetchProductsService : UnityEngine.Purchasing.IAppleFetchProductsService
	{
		[StructLayout(3)]
		[Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <ExecuteFetchProductsRequest>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<List<ProductDescription>> <>t__builder;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AppleFetchProductsService <>4__this;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<List<ProductDescription>> <>u__1;

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2C445CC", Offset = "0x2C405CC", VA = "0x2C445CC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2C449EC", Offset = "0x2C409EC", VA = "0x2C449EC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnityEngine.Purchasing.INativeAppleStore? m_NativeStore;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly UnityEngine.Purchasing.TaskQueue queue;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskCompletionSource<List<ProductDescription>>? m_CurrentRequestCompletionSource;

		[Token(Token = "0x17000007")]
		private string? LastRequestProductsJson
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2C44198", Offset = "0x2C40198", VA = "0x2C44198")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2C441A0", Offset = "0x2C401A0", VA = "0x2C441A0", Slot = "4")]
		public void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore nativeStore)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2C441A8", Offset = "0x2C401A8", VA = "0x2C441A8", Slot = "8")]
		public virtual Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2C44290", Offset = "0x2C40290", VA = "0x2C44290")]
		private void ValidateThatRequestIsPossible()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2C442E8", Offset = "0x2C402E8", VA = "0x2C442E8")]
		[AsyncStateMachine(typeof(<ExecuteFetchProductsRequest>d__10))]
		private Task<List<ProductDescription>> ExecuteFetchProductsRequest(IReadOnlyCollection<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2C443E0", Offset = "0x2C403E0", VA = "0x2C443E0", Slot = "6")]
		public void OnProductsFetched(string json)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2C44454", Offset = "0x2C40454", VA = "0x2C44454", Slot = "7")]
		public void OnProductDetailsRetrieveFailed(string errorMessage)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2C44550", Offset = "0x2C40550", VA = "0x2C44550")]
		public AppleFetchProductsService()
		{
		}
	}
	[Token(Token = "0x2000057")]
	internal class AppleStoreImpl : JsonStore, UnityEngine.Purchasing.IAppleStoreCallbacks, UnityEngine.Purchasing.IAppleAppReceiptViewer
	{
		[StructLayout(3)]
		[Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <FetchProducts>d__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AppleStoreImpl <>4__this;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<List<ProductDescription>> <>u__1;

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2C483FC", Offset = "0x2C443FC", VA = "0x2C483FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2C48984", Offset = "0x2C44984", VA = "0x2C48984", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <OnPurchaseSucceeded>d__63 : IAsyncStateMachine
		{
			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AppleStoreImpl <>4__this;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string purchaseDetailsJson;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2C48990", Offset = "0x2C44990", VA = "0x2C48990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2C48ED8", Offset = "0x2C44ED8", VA = "0x2C48ED8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<bool, string?>? m_RestoreCallback;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<string>? m_FetchStorePromotionOrderError;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<List<Product>>? m_FetchStorePromotionOrderSuccess;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<string>? m_FetchStorePromotionVisibilityError;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<string, AppleStorePromotionVisibility>? m_FetchStorePromotionVisibilitySuccess;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Action<string>? m_RefreshAppReceiptSuccessCallback;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action<string>? m_RefreshAppReceiptErrorCallback;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TaskCompletionSource<bool>? m_RefreshAppReceiptTask;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool m_RefreshAppReceipt;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private UnityEngine.Purchasing.INativeAppleStore? m_Native;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly UnityEngine.Purchasing.IAppleFetchProductsService m_FetchProductsService;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly UnityEngine.Purchasing.ITransactionLog m_TransactionLog;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Uniject.IUtil? s_Util;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AppleStoreImpl? s_Instance;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string? appReceipt;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_IsTransactionObserverEnabled;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Guid m_AppAccountToken;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[CompilerGenerated]
		private Action<Product>? OnPromotionalPurchaseIntercepted;

		[Token(Token = "0x17000008")]
		public bool simulateAskToBuy
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2C455E8", Offset = "0x2C415E8", VA = "0x2C455E8", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C44BC0", Offset = "0x2C40BC0", VA = "0x2C44BC0")]
		protected AppleStoreImpl(ICartValidator cartValidator, UnityEngine.Purchasing.IAppleFetchProductsService fetchProductsService, UnityEngine.Purchasing.ITransactionLog transactionLog, Uniject.IUtil util, ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C44CF4", Offset = "0x2C40CF4", VA = "0x2C44CF4")]
		public void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore apple)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C44F24", Offset = "0x2C40F24", VA = "0x2C44F24")]
		public UnityEngine.Purchasing.INativeAppleStore? GetNativeStore()
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C44F2C", Offset = "0x2C40F2C", VA = "0x2C44F2C", Slot = "39")]
		public string? AppReceipt()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2C44F34", Offset = "0x2C40F34", VA = "0x2C44F34", Slot = "16")]
		public override void Connect()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2C45050", Offset = "0x2C41050", VA = "0x2C45050", Slot = "32")]
		protected override void FinishTransaction(ProductDefinition? productDefinition, string transactionId)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2C451F4", Offset = "0x2C411F4", VA = "0x2C451F4", Slot = "19")]
		public override void Purchase(ICart cart)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2C4535C", Offset = "0x2C4135C", VA = "0x2C4535C")]
		private string PurchaseOptions()
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2C4549C", Offset = "0x2C4149C", VA = "0x2C4549C", Slot = "17")]
		[AsyncStateMachine(typeof(<FetchProducts>d__29))]
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2C45534", Offset = "0x2C41534", VA = "0x2C45534", Slot = "18")]
		public override void FetchPurchases()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2C455E0", Offset = "0x2C415E0", VA = "0x2C455E0", Slot = "37")]
		public void SetRestoreTransactionsCallback(Action<bool, string?>? successCallback)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2C455F0", Offset = "0x2C415F0", VA = "0x2C455F0", Slot = "36")]
		public override void OnPurchaseDeferred(string productDetails)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2C45868", Offset = "0x2C41868", VA = "0x2C45868")]
		private void OnPromotionalPurchaseAttempted(string payload)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2C45948", Offset = "0x2C41948", VA = "0x2C45948", Slot = "30")]
		public override void OnPurchasesFetched(string json)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2C45A14", Offset = "0x2C41A14", VA = "0x2C45A14")]
		private List<Order> CreateOrdersFromFetchedPurchases(Dictionary<string, Dictionary<string, object>> fetchedPurchases)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2C45B94", Offset = "0x2C41B94", VA = "0x2C45B94")]
		private List<Order> GenerateOrdersFromProducts(Dictionary<string, object> transactions, bool isPending)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2C4601C", Offset = "0x2C4201C", VA = "0x2C4601C")]
		private static OwnershipType OwnershipTypeFromString(string ownershipTypeString)
		{
			return default(OwnershipType);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2C46328", Offset = "0x2C42328", VA = "0x2C46328")]
		private void OnTransactionsRestoredSuccess()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2C4634C", Offset = "0x2C4234C", VA = "0x2C4634C")]
		private void OnTransactionsRestoredFail(string error)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2C46370", Offset = "0x2C42370", VA = "0x2C46370")]
		private void OnEntitlementRevoked(string purchaseDetailsJson)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2C463DC", Offset = "0x2C423DC", VA = "0x2C463DC")]
		private void RevokeEntitlement(string productId)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2C4648C", Offset = "0x2C4248C", VA = "0x2C4648C")]
		private void OnFetchStorePromotionOrderSucceeded(string productIds)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2C4677C", Offset = "0x2C4277C", VA = "0x2C4677C")]
		private void OnFetchStorePromotionOrderFailed(string error)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2C46798", Offset = "0x2C42798", VA = "0x2C46798")]
		private void OnFetchStorePromotionVisibilitySucceeded(string result)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2C46A88", Offset = "0x2C42A88", VA = "0x2C46A88")]
		private void OnFetchStorePromotionVisibilityFailed(string error)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2C44A68", Offset = "0x2C40A68", VA = "0x2C44A68")]
		[MonoPInvokeCallback(typeof(UnityEngine.Purchasing.UnityPurchasingCallback))]
		private static void MessageCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2C46AAC", Offset = "0x2C42AAC", VA = "0x2C46AAC")]
		private void ProcessCallbackMessage(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2C47190", Offset = "0x2C43190", VA = "0x2C47190")]
		private string ConvertPtrToString(IntPtr subjectPtr)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2C47984", Offset = "0x2C43984", VA = "0x2C47984", Slot = "38")]
		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2C47888", Offset = "0x2C43888", VA = "0x2C47888")]
		private void OnAppReceiptRetrieved(string receipt)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2C47908", Offset = "0x2C43908", VA = "0x2C47908")]
		private void OnAppReceiptRefreshedFailed(string error)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2C47628", Offset = "0x2C43628", VA = "0x2C47628")]
		private void OnCheckEntitlement(string productId, int entitlementStatus)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2C472CC", Offset = "0x2C432CC", VA = "0x2C472CC")]
		[AsyncStateMachine(typeof(<OnPurchaseSucceeded>d__63))]
		private void OnPurchaseSucceeded(string purchaseDetailsJson)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2C4798C", Offset = "0x2C4398C", VA = "0x2C4798C")]
		private Task<bool> RefreshAppReceiptAsync()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2C47A94", Offset = "0x2C43A94", VA = "0x2C47A94")]
		private void ProcessValidPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string signatureJws)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2C47BE8", Offset = "0x2C43BE8", VA = "0x2C47BE8")]
		private void ProcessNewPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string signatureJws)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2C47D10", Offset = "0x2C43D10", VA = "0x2C47D10")]
		private void ProcessLoggedPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2C45728", Offset = "0x2C41728", VA = "0x2C45728")]
		private DeferredOrder GenerateAppleDeferredOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2C460A8", Offset = "0x2C420A8", VA = "0x2C460A8")]
		private PendingOrder GenerateApplePendingOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2C461E8", Offset = "0x2C421E8", VA = "0x2C461E8")]
		private ConfirmedOrder GenerateAppleConfirmedOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2C47D50", Offset = "0x2C43D50", VA = "0x2C47D50")]
		private void EnsureConfirmedOrderIsFinished(ConfirmedOrder confirmedOrder)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2C47F74", Offset = "0x2C43F74", VA = "0x2C47F74")]
		private void InvokeErrorIfRepurchasedConsumables(ConfirmedOrder confirmedOrder)
		{
		}
	}
	[Token(Token = "0x200005D")]
	internal class MetricizedAppleStoreImpl : AppleStoreImpl
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2C48EE4", Offset = "0x2C44EE4", VA = "0x2C48EE4")]
		[Preserve]
		internal MetricizedAppleStoreImpl(ICartValidator cartValidator, UnityEngine.Purchasing.IAppleFetchProductsService fetchProductsService, UnityEngine.Purchasing.ITransactionLog transactionLog, Uniject.IUtil util, ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2C48F08", Offset = "0x2C44F08", VA = "0x2C48F08", Slot = "17")]
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2C49074", Offset = "0x2C45074", VA = "0x2C49074", Slot = "19")]
		public override void Purchase(ICart cart)
		{
		}
	}
	[Token(Token = "0x2000060")]
	internal interface INativeStoreProvider
	{
		[Token(Token = "0x6000180")]
		UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
	}
	[Token(Token = "0x2000061")]
	internal class JsonStore : global::Purchasing.Extension.InternalStore, UnityEngine.Purchasing.IUnityCallback
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected ICartValidator m_CartValidator;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected string m_StoreName;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private INativeStore? m_Store;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected readonly ILogger Logger;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PurchaseFailureDescription? LastPurchaseFailureDescription;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2C49220", Offset = "0x2C45220", VA = "0x2C49220")]
		public void SetNativeStore(INativeStore native)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2C44CB0", Offset = "0x2C40CB0", VA = "0x2C44CB0")]
		internal JsonStore(ICartValidator cartValidator, ILogger logger, string storeName)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2C49228", Offset = "0x2C45228", VA = "0x2C49228", Slot = "17")]
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2C492EC", Offset = "0x2C452EC", VA = "0x2C492EC", Slot = "18")]
		public override void FetchPurchases()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2C49398", Offset = "0x2C45398", VA = "0x2C49398", Slot = "30")]
		public virtual void OnPurchasesFetched(string json)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2C49464", Offset = "0x2C45464", VA = "0x2C49464")]
		internal List<Order> CreateOrdersFromFetchedPurchases(List<ProductDescription> productDescriptions)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2C498D8", Offset = "0x2C458D8", VA = "0x2C498D8", Slot = "19")]
		public override void Purchase(ICart cart)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2C49A50", Offset = "0x2C45A50", VA = "0x2C49A50", Slot = "31")]
		protected virtual void Purchase(ProductDefinition productDefinition, string developerPayload)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2C49B28", Offset = "0x2C45B28", VA = "0x2C49B28", Slot = "20")]
		public override void FinishTransaction(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2C45118", Offset = "0x2C41118", VA = "0x2C45118", Slot = "32")]
		protected virtual void FinishTransaction(ProductDefinition? productDefinition, string transactionId)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2C49E0C", Offset = "0x2C45E0C", VA = "0x2C49E0C", Slot = "16")]
		public override void Connect()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2C49EB4", Offset = "0x2C45EB4", VA = "0x2C49EB4", Slot = "33")]
		public void OnStoreConnectionSucceeded()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2C49F5C", Offset = "0x2C45F5C", VA = "0x2C49F5C", Slot = "34")]
		public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2C4A038", Offset = "0x2C46038", VA = "0x2C4A038")]
		protected DeferredOrder GenerateDeferredOrder(string id, string receipt, string transactionID)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2C496D0", Offset = "0x2C456D0", VA = "0x2C496D0")]
		protected PendingOrder GeneratePendingOrder(string id, string receipt, string transactionID)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2C497D4", Offset = "0x2C457D4", VA = "0x2C497D4")]
		protected ConfirmedOrder GenerateConfirmedOrder(string id, string receipt, string transactionID)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2C47EC8", Offset = "0x2C43EC8", VA = "0x2C47EC8")]
		protected Product FindProductById(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2C47364", Offset = "0x2C43364", VA = "0x2C47364", Slot = "35")]
		public void OnPurchaseFailed(string json)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2C4A13C", Offset = "0x2C4613C", VA = "0x2C4A13C")]
		public void OnPurchaseFailed(PurchaseFailureDescription failure, [Optional] string? json)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2C4A4B8", Offset = "0x2C464B8", VA = "0x2C4A4B8", Slot = "36")]
		public virtual void OnPurchaseDeferred(string productDetails)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2C4A240", Offset = "0x2C46240", VA = "0x2C4A240")]
		private static StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string? json)
		{
			return default(StoreSpecificPurchaseErrorCode);
		}
	}
	[Token(Token = "0x2000062")]
	internal class NativeStoreProvider : INativeStoreProvider
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2C4A5B8", Offset = "0x2C465B8", VA = "0x2C4A5B8", Slot = "4")]
		public UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2C4A68C", Offset = "0x2C4668C", VA = "0x2C4A68C")]
		public NativeStoreProvider()
		{
		}
	}
	[Token(Token = "0x2000063")]
	internal static class ProductServiceDependencyFactoryInjector
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2C4A694", Offset = "0x2C46694", VA = "0x2C4A694")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
	[Token(Token = "0x2000064")]
	internal class ProductServiceFactory : UnityEngine.Purchasing.IProductServiceFactory
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProductServiceFactory? s_Instance;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string?, Func<IStoreWrapper, IProductService>> m_ProductServiceInstantiationByName;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2C4A744", Offset = "0x2C46744", VA = "0x2C4A744")]
		internal static ProductServiceFactory Instance()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2C4A7AC", Offset = "0x2C467AC", VA = "0x2C4A7AC")]
		private ProductServiceFactory()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2C4A908", Offset = "0x2C46908", VA = "0x2C4A908", Slot = "4")]
		public IProductService Create(IStoreWrapper store)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2C4AAD0", Offset = "0x2C46AD0", VA = "0x2C4AAD0")]
		private static UnityEngine.Purchasing.ProductService CreateGenericProductService(IStoreWrapper storeWrapper)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2C4ABB8", Offset = "0x2C46BB8", VA = "0x2C4ABB8")]
		private static void AddProductServiceDependencies(IStoreWrapper store, UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2C4AED4", Offset = "0x2C46ED4", VA = "0x2C4AED4")]
		private static UnityEngine.Purchasing.Services.AppleStoreExtendedProductService CreateAppleProductService(IStoreWrapper store)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	internal static class PurchaseServiceDependencyFactoryInjector
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2C4B838", Offset = "0x2C47838", VA = "0x2C4B838")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
	[Token(Token = "0x2000066")]
	internal class PurchaseServiceFactory : UnityEngine.Purchasing.IPurchaseServiceFactory
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PurchaseServiceFactory? s_Instance;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string?, Func<IStoreWrapper, IPurchaseService>> m_PurchaseServiceInstantiationByName;

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2C4B8E8", Offset = "0x2C478E8", VA = "0x2C4B8E8")]
		internal static PurchaseServiceFactory Instance()
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2C4B950", Offset = "0x2C47950", VA = "0x2C4B950")]
		private PurchaseServiceFactory()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2C4BB0C", Offset = "0x2C47B0C", VA = "0x2C4BB0C", Slot = "4")]
		public IPurchaseService Create(IStoreWrapper store)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2C4BCD4", Offset = "0x2C47CD4", VA = "0x2C4BCD4")]
		private static PurchaseService CreateDefaultPurchaseService(IStoreWrapper store)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C4BE40", Offset = "0x2C47E40", VA = "0x2C4BE40")]
		private static void AddPurchaseServiceDependencies(IStoreWrapper store, UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2C4C4C8", Offset = "0x2C484C8", VA = "0x2C4C4C8")]
		private static void AddAnalyticsDependencies(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2C4C600", Offset = "0x2C48600", VA = "0x2C4C600")]
		private static UnityEngine.Purchasing.GooglePlayStoreExtendedPurchaseService CreateGooglePurchaseService(IStoreWrapper store)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2C4C8F8", Offset = "0x2C488F8", VA = "0x2C4C8F8")]
		private static UnityEngine.Purchasing.Services.AppleStoreExtendedPurchaseService CreateApplePurchaseService(IStoreWrapper store)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	internal class StoreFactory : UnityEngine.Purchasing.IStoreFactory
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StoreFactory? s_Instance;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ILogger m_Logger;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly INativeStoreProvider m_NativeStoreProvider;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper TelemetryMetricsInstanceWrapper;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper TelemetryDiagnosticsInstanceWrapper;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string?, Func<IStoreWrapper>> m_StoreInstantiationByName;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2C4CEF8", Offset = "0x2C48EF8", VA = "0x2C4CEF8")]
		internal StoreFactory(Uniject.IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2C4B6A8", Offset = "0x2C476A8", VA = "0x2C4B6A8")]
		internal static StoreFactory Instance()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2C4CFAC", Offset = "0x2C48FAC", VA = "0x2C4CFAC")]
		private void RegisterBaseStores()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2C4D158", Offset = "0x2C49158", VA = "0x2C4D158", Slot = "5")]
		public void RegisterStore(string storeName, Func<IStoreWrapper> function)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2C4D1C0", Offset = "0x2C491C0", VA = "0x2C4D1C0", Slot = "4")]
		public IStoreWrapper CreateStore(string storeName)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2C4D320", Offset = "0x2C49320", VA = "0x2C4D320")]
		private UnityEngine.Purchasing.IDependencyInjectionService CreateBaseDiService()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2C4D390", Offset = "0x2C49390", VA = "0x2C4D390")]
		private void AddUtilsDependencies(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2C4D4A0", Offset = "0x2C494A0", VA = "0x2C4D4A0")]
		private void AddTelemetryDependencies(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2C4D6B8", Offset = "0x2C496B8", VA = "0x2C4D6B8")]
		private IStoreWrapper InstantiateAppleStore()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2C4D8B0", Offset = "0x2C498B0", VA = "0x2C4D8B0")]
		private IStoreWrapper InstantiateMacAppStore()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2C4D720", Offset = "0x2C49720", VA = "0x2C4D720")]
		private IStoreWrapper InstantiateAppleAppStore(string storeName, string storeDisplayName)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2C4D918", Offset = "0x2C49918", VA = "0x2C4D918")]
		private void AddMetricizedAppleStoreDependencies(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2C4DC88", Offset = "0x2C49C88", VA = "0x2C4DC88")]
		private static UnityEngine.Purchasing.ITransactionLog BuildTransactionLog()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2C4DAD0", Offset = "0x2C49AD0", VA = "0x2C4DAD0")]
		private void CreateAndAssignNativeAppleStore(AppleStoreImpl store)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2C4DD14", Offset = "0x2C49D14", VA = "0x2C4DD14")]
		private IStoreWrapper InstantiateFakeStore()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2C4DDA4", Offset = "0x2C49DA4", VA = "0x2C4DDA4")]
		private FakeStore CreateFakeStoreByUIMode(FakeStoreUIMode useFakeStoreUIMode)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2C4DFB0", Offset = "0x2C49FB0", VA = "0x2C4DFB0")]
		private IStoreWrapper InstantiateGooglePlayStore()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2C4DB88", Offset = "0x2C49B88", VA = "0x2C4DB88")]
		private static IStoreWrapper CreateStoreWrapper(string storeName, UnityEngine.Purchasing.IDependencyInjectionService di)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2C4EE78", Offset = "0x2C4AE78", VA = "0x2C4EE78")]
		private void LinkGooglePlayStoreDependencies(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2C4F17C", Offset = "0x2C4B17C", VA = "0x2C4F17C")]
		private static void LinkProductCache(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C4E01C", Offset = "0x2C4A01C", VA = "0x2C4E01C")]
		private static void AddGooglePlayStoreServices(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C4E684", Offset = "0x2C4A684", VA = "0x2C4E684")]
		private void AddGooglePlayStoreServiceAars(UnityEngine.Purchasing.IDependencyInjectionService di)
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal static class StoreManagerFactoryInjector
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C4F6C4", Offset = "0x2C4B6C4", VA = "0x2C4F6C4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
	[Token(Token = "0x2000069")]
	internal static class StoreServiceDependencyFactoryInjector
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C4F774", Offset = "0x2C4B774", VA = "0x2C4F774")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
	[Token(Token = "0x200006A")]
	internal class StoreServiceFactory : UnityEngine.Purchasing.IStoreServiceFactory
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StoreServiceFactory? s_Instance;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string?, Func<IRetryPolicy, IStoreWrapper, IStoreService>> m_StoreServiceInstantiationByName;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2C4F824", Offset = "0x2C4B824", VA = "0x2C4F824")]
		internal static StoreServiceFactory Instance()
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2C4F88C", Offset = "0x2C4B88C", VA = "0x2C4F88C")]
		private StoreServiceFactory()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C4FA48", Offset = "0x2C4BA48", VA = "0x2C4FA48", Slot = "4")]
		public IStoreService Create(IStoreWrapper store, IRetryPolicy? retryPolicy)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2C4FC58", Offset = "0x2C4BC58", VA = "0x2C4FC58")]
		private static UnityEngine.Purchasing.StoreService CreateGenericStoreService(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2C4FD50", Offset = "0x2C4BD50", VA = "0x2C4FD50")]
		private static void AddStoreServiceDependencies(UnityEngine.Purchasing.IDependencyInjectionService di, IRetryPolicy? retryPolicy, IStoreWrapper store)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C500A8", Offset = "0x2C4C0A8", VA = "0x2C500A8")]
		private static UnityEngine.Purchasing.GooglePlayStoreExtendedService CreateGoogleStoreService(IRetryPolicy? retryPolicy, IStoreWrapper store)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2C505A0", Offset = "0x2C4C5A0", VA = "0x2C505A0")]
		private static UnityEngine.Purchasing.Services.AppleStoreExtendedService CreateAppleStoreService(IRetryPolicy? retryPolicy, IStoreWrapper store)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	internal class DialogRequest
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string QueryText;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string OkayButtonText;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string CancelButtonText;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<string> Options;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<bool, int> Callback;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2C50B18", Offset = "0x2C4CB18", VA = "0x2C50B18")]
		public DialogRequest()
		{
		}
	}
	[Token(Token = "0x200006C")]
	internal class FakeStore : JsonStore, INativeStore
	{
		[Token(Token = "0x200006D")]
		protected enum DialogType
		{
			[Token(Token = "0x400013B")]
			Purchase,
			[Token(Token = "0x400013C")]
			FetchProducts
		}

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<ConfirmedOrder> m_ConfirmedOrders;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FakeStoreUIMode UIMode;

		[Token(Token = "0x17000009")]
		public string unavailableProductId
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2C50B20", Offset = "0x2C4CB20", VA = "0x2C50B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C4DEF8", Offset = "0x2C49EF8", VA = "0x2C4DEF8")]
		public FakeStore(ICartValidator cartValidator, ILogger logger)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C50B28", Offset = "0x2C4CB28", VA = "0x2C50B28", Slot = "16")]
		public override void Connect()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C50B2C", Offset = "0x2C4CB2C", VA = "0x2C50B2C", Slot = "38")]
		public void FetchProducts(string json)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2C50C44", Offset = "0x2C4CC44", VA = "0x2C50C44")]
		public void StoreFetchProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2C51114", Offset = "0x2C4D114", VA = "0x2C51114")]
		private ProductMetadata GetOrCreateProductMetadata(string productId)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2C51684", Offset = "0x2C4D684", VA = "0x2C51684", Slot = "39")]
		public void FetchExistingPurchases()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2C51734", Offset = "0x2C4D734", VA = "0x2C51734", Slot = "40")]
		public void Purchase(string productJson, string optionsJson)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2C51750", Offset = "0x2C4D750", VA = "0x2C51750")]
		private ProductDefinition ParseProductDefinition(string productJSON)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2C51C38", Offset = "0x2C4DC38", VA = "0x2C51C38")]
		private ProductType ParseProductType(Dictionary<string, object> dictionary)
		{
			return default(ProductType);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2C518C4", Offset = "0x2C4D8C4", VA = "0x2C518C4")]
		private void FakePurchase(ProductDefinition productDefinition, string developerPayload)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2C52080", Offset = "0x2C4E080", VA = "0x2C52080", Slot = "41")]
		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		[Token(Token = "0x60001D4")]
		protected virtual bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback) where T : Enum
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000070")]
	internal class FakeStoreCartValidator : UnityEngine.Purchasing.StoreCartValidator
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2C4DE74", Offset = "0x2C49E74", VA = "0x2C4DE74")]
		public FakeStoreCartValidator()
		{
		}
	}
	[Token(Token = "0x2000071")]
	internal class LifecycleNotifier : MonoBehaviour
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action OnDestroyCallback;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2C52204", Offset = "0x2C4E204", VA = "0x2C52204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2C52220", Offset = "0x2C4E220", VA = "0x2C52220")]
		public LifecycleNotifier()
		{
		}
	}
	[Token(Token = "0x2000072")]
	internal class UIFakeStore : FakeStore
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DialogRequest m_CurrentDialog;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int m_LastSelectedDropdownIndex;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject m_UIFakeStoreWindowObject;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject m_EventSystem;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2C4DEF4", Offset = "0x2C49EF4", VA = "0x2C4DEF4")]
		public UIFakeStore(ICartValidator cartValidator, ILogger logger)
		{
		}

		[Token(Token = "0x60001DE")]
		protected override bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2C52228", Offset = "0x2C4E228", VA = "0x2C52228")]
		private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<string> options, Action<bool, int> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2C522E8", Offset = "0x2C4E2E8", VA = "0x2C522E8")]
		private void InstantiateDialog()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2C5240C", Offset = "0x2C4E40C", VA = "0x2C5240C")]
		private UIFakeStoreWindow GetOrCreateFakeStoreWindow()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2C52500", Offset = "0x2C4E500", VA = "0x2C52500")]
		private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2C525B4", Offset = "0x2C4E5B4", VA = "0x2C525B4")]
		private void EnsureEventSystemCreated(Transform rootTransform)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2C52654", Offset = "0x2C4E654", VA = "0x2C52654")]
		private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2C52920", Offset = "0x2C4E920", VA = "0x2C52920")]
		private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2C526C0", Offset = "0x2C4E6C0", VA = "0x2C526C0")]
		private void CreateEventSystem(Transform rootTransform)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2C52A84", Offset = "0x2C4EA84", VA = "0x2C52A84")]
		private string CreatePurchaseQuestion(ProductDefinition definition)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2C52AF0", Offset = "0x2C4EAF0", VA = "0x2C52AF0")]
		private string CreateFetchProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2C52D0C", Offset = "0x2C4ED0C", VA = "0x2C52D0C")]
		private void OkayButtonClicked()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2C52E50", Offset = "0x2C4EE50", VA = "0x2C52E50")]
		private void CancelButtonClicked()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2C52E90", Offset = "0x2C4EE90", VA = "0x2C52E90")]
		private void DropdownValueChanged(int selectedItem)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2C52DBC", Offset = "0x2C4EDBC", VA = "0x2C52DBC")]
		private void CloseDialog()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2C522D8", Offset = "0x2C4E2D8", VA = "0x2C522D8")]
		public bool IsShowingDialog()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000075")]
	internal class UIFakeStoreDropdown
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<string> m_Options;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action<int, string> m_OnDropdown;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 scrollPosition;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2C52F18", Offset = "0x2C4EF18", VA = "0x2C52F18")]
		public void DoPopup(int windowID)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C531CC", Offset = "0x2C4F1CC", VA = "0x2C531CC")]
		private void OnOptionSelected(int optionIndex)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2C53250", Offset = "0x2C4F250", VA = "0x2C53250")]
		internal void SetOptions(List<string> options)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2C532CC", Offset = "0x2C4F2CC", VA = "0x2C532CC")]
		internal void SetSelectionAction(Action<int, string> onDropdown)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2C532D4", Offset = "0x2C4F2D4", VA = "0x2C532D4")]
		public UIFakeStoreDropdown()
		{
		}
	}
	[Token(Token = "0x2000076")]
	internal class UIFakeStoreWindow : MonoBehaviour
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_QueryText;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_OkText;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_CancelText;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_LastSelectedOptionText;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action m_OnOk;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action m_OnCancel;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<int> m_OnDropdown;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_CancelEnabled;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_DropdownEnabled;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_DoDropdown;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly UIFakeStoreDropdown m_Dropdown;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 scrollPosition;

		[Token(Token = "0x4000158")]
		private const float k_MenuScreenRatio = 0.6f;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2C532DC", Offset = "0x2C4F2DC", VA = "0x2C532DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2C53458", Offset = "0x2C4F458", VA = "0x2C53458")]
		private Rect CreateCenteredWindowRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2C534CC", Offset = "0x2C4F4CC", VA = "0x2C534CC")]
		private void DoMainGUI(int windowID)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2C53810", Offset = "0x2C4F810", VA = "0x2C53810")]
		private void DoDropDown()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2C5381C", Offset = "0x2C4F81C", VA = "0x2C5381C")]
		private void OnOkClicked()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2C53838", Offset = "0x2C4F838", VA = "0x2C53838")]
		private void OnCancelClicked()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2C52838", Offset = "0x2C4E838", VA = "0x2C52838")]
		internal void ConfigureMainDialogText(string queryText, string okText, string cancelText)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2C52844", Offset = "0x2C4E844", VA = "0x2C52844")]
		internal void ConfigureDropdownOptions(List<string> options)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2C53854", Offset = "0x2C4F854", VA = "0x2C53854")]
		private void OnDropdown(int index, string selectionText)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2C52A60", Offset = "0x2C4EA60", VA = "0x2C52A60")]
		internal void AssignCallbacks(Action onOk, Action onCancel, Action<int> onDropdown)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2C53884", Offset = "0x2C4F884", VA = "0x2C53884")]
		public UIFakeStoreWindow()
		{
		}
	}
}
namespace UnityEngine.Purchasing.Registration
{
	[Token(Token = "0x2000077")]
	internal class IapCoreInitializeCallback : IInitializablePackage
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2C538E4", Offset = "0x2C4F8E4", VA = "0x2C538E4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Register()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2C53A7C", Offset = "0x2C4FA7C", VA = "0x2C53A7C", Slot = "4")]
		public Task Initialize(CoreRegistry registry)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2C53C94", Offset = "0x2C4FC94", VA = "0x2C53C94")]
		private static void CacheInitializedEnvironment(CoreRegistry registry)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2C53CC0", Offset = "0x2C4FCC0", VA = "0x2C53CC0")]
		private static string GetCurrentEnvironment(CoreRegistry registry)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2C53E08", Offset = "0x2C4FE08", VA = "0x2C53E08")]
		private static void InitializeTelemetryComponents(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2C53A74", Offset = "0x2C4FA74", VA = "0x2C53A74")]
		public IapCoreInitializeCallback()
		{
		}
	}
}
namespace UnityEngine.Purchasing.Utils
{
	[Token(Token = "0x2000079")]
	internal class GooglePurchaseBuilder : IGooglePurchaseBuilder
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ILogger m_Logger;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2C540FC", Offset = "0x2C500FC", VA = "0x2C540FC")]
		[Preserve]
		internal GooglePurchaseBuilder(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2C54128", Offset = "0x2C50128", VA = "0x2C54128", Slot = "4")]
		public IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2C54268", Offset = "0x2C50268", VA = "0x2C54268")]
		private void LogWarningForException(Exception exception)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2C542A0", Offset = "0x2C502A0", VA = "0x2C542A0")]
		public UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(AndroidJavaObject purchase)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2C5477C", Offset = "0x2C5077C", VA = "0x2C5477C")]
		private static IEnumerable<AndroidJavaObject> TryFindAllProductDetails(IEnumerable<string> skus, IEnumerable<AndroidJavaObject> productDetails)
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	internal static class GoogleReceiptEncoder
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2C54A24", Offset = "0x2C50A24", VA = "0x2C54A24")]
		internal static string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, List<string> productDetailsJson)
		{
			return null;
		}
	}
	[Token(Token = "0x200007D")]
	[Preserve]
	internal class ProductDetailsConverter : IProductDetailsConverter
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2C54B40", Offset = "0x2C50B40", VA = "0x2C54B40", Slot = "4")]
		public List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2C555F8", Offset = "0x2C515F8", VA = "0x2C555F8")]
		public string GetProductId(AndroidJavaObject productDetails)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2C557A8", Offset = "0x2C517A8", VA = "0x2C557A8")]
		public ProductDescription ConvertToProductDescription(AndroidJavaObject productDetails, ProductType productType)
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2C55848", Offset = "0x2C51848", VA = "0x2C55848")]
		internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails, ProductType productType = ProductType.Unknown)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2C570C4", Offset = "0x2C530C4", VA = "0x2C570C4")]
		public ProductDetailsConverter()
		{
		}
	}
}
namespace UnityEngine.Purchasing.Models
{
	[Token(Token = "0x200007E")]
	internal class GoogleBillingClient : UnityEngine.Purchasing.Interfaces.IGoogleBillingClient
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass s_AndroidProductClassName;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass s_BillingFlowParamsClass;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaClass s_ProductDetailsParamsClass;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static AndroidJavaClass s_SubscriptionUpdateParamsClass;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static AndroidJavaClass s_ConsumeParamsClass;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static AndroidJavaClass s_AcknowledgePurchaseParamsClass;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static AndroidJavaClass s_BillingClientClass;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static AndroidJavaClass s_PendingPurchasesParamsClass;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static AndroidJavaClass s_QueryPurchasesParamsClass;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly AndroidJavaObject m_BillingClient;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_ObfuscatedAccountId;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_ObfuscatedProfileId;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2C570CC", Offset = "0x2C530CC", VA = "0x2C570CC")]
		private static AndroidJavaClass GetProductParamsClass()
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2C57170", Offset = "0x2C53170", VA = "0x2C57170")]
		private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass()
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2C5720C", Offset = "0x2C5320C", VA = "0x2C5720C")]
		private static AndroidJavaClass GetBillingFlowParamClass()
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2C572A8", Offset = "0x2C532A8", VA = "0x2C572A8")]
		private static AndroidJavaClass GetProductDetailsParamsClass()
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2C57344", Offset = "0x2C53344", VA = "0x2C57344")]
		private static AndroidJavaClass GetSubscriptionUpdateParamClass()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2C573E0", Offset = "0x2C533E0", VA = "0x2C573E0")]
		private static AndroidJavaClass GetConsumeParamsClass()
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2C5747C", Offset = "0x2C5347C", VA = "0x2C5747C")]
		private static AndroidJavaClass GetAcknowledgePurchaseParamsClass()
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2C57518", Offset = "0x2C53518", VA = "0x2C57518")]
		private static AndroidJavaClass GetBillingClientClass()
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2C575B4", Offset = "0x2C535B4", VA = "0x2C575B4")]
		private static AndroidJavaClass GetPendingPurchasesParamsClass()
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2C57650", Offset = "0x2C53650", VA = "0x2C57650")]
		private static AndroidJavaObject PendingPurchasesParams()
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2C57960", Offset = "0x2C53960", VA = "0x2C57960")]
		private static AndroidJavaClass GetQueryPurchasesParamsClass()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2C579FC", Offset = "0x2C539FC", VA = "0x2C579FC")]
		private static AndroidJavaObject QueryPurchasesParams(string productType)
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2C57D1C", Offset = "0x2C53D1C", VA = "0x2C57D1C")]
		[Preserve]
		internal GoogleBillingClient(IGooglePurchasesUpdatedListener googlePurchasesUpdatedListener, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2C580FC", Offset = "0x2C540FC", VA = "0x2C580FC", Slot = "4")]
		public void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2C581C0", Offset = "0x2C541C0", VA = "0x2C581C0", Slot = "5")]
		public void QueryPurchasesAsync(string productType, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2C582F8", Offset = "0x2C542F8", VA = "0x2C582F8", Slot = "6")]
		public void QueryProductDetailsAsync(List<string> products, string type, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2C58538", Offset = "0x2C54538", VA = "0x2C58538")]
		private static AndroidJavaObject QueryProductDetailsParams(List<string> products, string type)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2C58938", Offset = "0x2C54938", VA = "0x2C58938")]
		private static AndroidJavaObject QueryProductDetailsParamsProductList(List<string> products, string type)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2C58A48", Offset = "0x2C54A48", VA = "0x2C58A48")]
		private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2C58E0C", Offset = "0x2C54E0C", VA = "0x2C58E0C", Slot = "7")]
		public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2C596C8", Offset = "0x2C556C8", VA = "0x2C596C8")]
		private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2C59B94", Offset = "0x2C55B94", VA = "0x2C59B94")]
		private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayReplacementMode replacementMode)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2C59AAC", Offset = "0x2C55AAC", VA = "0x2C59AAC")]
		private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2C599C4", Offset = "0x2C559C4", VA = "0x2C599C4")]
		private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2C59E4C", Offset = "0x2C55E4C", VA = "0x2C59E4C", Slot = "8")]
		public void ConsumeAsync(string purchaseToken, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2C5A32C", Offset = "0x2C5632C", VA = "0x2C5A32C", Slot = "9")]
		public void AcknowledgePurchase(string purchaseToken, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge)
		{
		}
	}
	[Token(Token = "0x2000080")]
	internal class GoogleBillingResult : UnityEngine.Purchasing.Models.IGoogleBillingResult
	{
		[Token(Token = "0x1700000A")]
		public UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2C5A820", Offset = "0x2C56820", VA = "0x2C5A820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(UnityEngine.Purchasing.Models.GoogleBillingResponseCode);
			}
		}

		[Token(Token = "0x1700000B")]
		public string debugMessage
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2C5A828", Offset = "0x2C56828", VA = "0x2C5A828", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2C5A830", Offset = "0x2C56830", VA = "0x2C5A830")]
		internal GoogleBillingResult(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x2000081")]
	internal static class GoogleBillingStrings
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2C5A9B4", Offset = "0x2C569B4", VA = "0x2C5A9B4")]
		internal static string getWarningMessageMoreThanOneSkuFound(string sku)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	internal static class GoogleProductTypeEnum
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2C5AA20", Offset = "0x2C56A20", VA = "0x2C5AA20")]
		internal static string InApp()
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2C5AA60", Offset = "0x2C56A60", VA = "0x2C5AA60")]
		internal static string Sub()
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	internal class GooglePurchase : UnityEngine.Purchasing.Interfaces.IGooglePurchase
	{
		[Token(Token = "0x1700000C")]
		public bool isAcknowledged
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2C5AAA0", Offset = "0x2C56AA0", VA = "0x2C5AAA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public int purchaseState
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x2C5AAA8", Offset = "0x2C56AA8", VA = "0x2C5AAA8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000E")]
		public List<string> skus
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2C5AAB0", Offset = "0x2C56AB0", VA = "0x2C5AAB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string receipt
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2C5AAB8", Offset = "0x2C56AB8", VA = "0x2C5AAB8", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public string signature
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2C5AAC0", Offset = "0x2C56AC0", VA = "0x2C5AAC0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public string originalJson
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2C5AAC8", Offset = "0x2C56AC8", VA = "0x2C5AAC8", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public string purchaseToken
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x2C5AAD0", Offset = "0x2C56AD0", VA = "0x2C5AAD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public string? obfuscatedAccountId
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x2C5AAD8", Offset = "0x2C56AD8", VA = "0x2C5AAD8", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public string? obfuscatedProfileId
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2C5AAE0", Offset = "0x2C56AE0", VA = "0x2C5AAE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public IEnumerable<ProductDescription> productDescriptions
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x2C5AAE8", Offset = "0x2C56AE8", VA = "0x2C5AAE8", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public string? sku
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2C5AAF0", Offset = "0x2C56AF0", VA = "0x2C5AAF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2C5AB38", Offset = "0x2C56B38", VA = "0x2C5AB38")]
		internal GooglePurchase(AndroidJavaObject purchase, IEnumerable<AndroidJavaObject> productDetailsEnum)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2C5B42C", Offset = "0x2C5742C", VA = "0x2C5B42C", Slot = "17")]
		public virtual bool IsAcknowledged()
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2C5B434", Offset = "0x2C57434", VA = "0x2C5B434", Slot = "18")]
		public virtual bool IsPurchased()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2C5B62C", Offset = "0x2C5762C", VA = "0x2C5B62C", Slot = "19")]
		public virtual bool IsPending()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000085")]
	internal static class GooglePurchaseStateEnum
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int? s_Purchased;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int? s_Pending;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2C5B8C4", Offset = "0x2C578C4", VA = "0x2C5B8C4")]
		private static AndroidJavaObject GetPurchaseStateJavaObject()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2C5B450", Offset = "0x2C57450", VA = "0x2C5B450")]
		internal static int Purchased()
		{
			return default(int);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2C5B648", Offset = "0x2C57648", VA = "0x2C5B648")]
		internal static int Pending()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000086")]
	[Preserve]
	internal class GooglePurchaseStateEnumProvider : IGooglePurchaseStateEnumProvider
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2C5B930", Offset = "0x2C57930", VA = "0x2C5B930", Slot = "4")]
		public int Purchased()
		{
			return default(int);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2C5B934", Offset = "0x2C57934", VA = "0x2C5B934", Slot = "5")]
		public int Pending()
		{
			return default(int);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2C5B938", Offset = "0x2C57938", VA = "0x2C5B938")]
		public GooglePurchaseStateEnumProvider()
		{
		}
	}
}
namespace UnityEngine.Purchasing.Interfaces
{
	[Token(Token = "0x2000087")]
	internal interface IGoogleFinishTransactionUseCase
	{
		[Token(Token = "0x6000256")]
		Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
	}
	[Token(Token = "0x2000088")]
	internal interface IGoogleLastKnownProductService
	{
		[Token(Token = "0x17000017")]
		string? LastKnownOldProductId
		{
			[Token(Token = "0x6000257")]
			get;
			[Token(Token = "0x6000258")]
			set;
		}

		[Token(Token = "0x17000018")]
		string? LastKnownProductId
		{
			[Token(Token = "0x6000259")]
			get;
			[Token(Token = "0x600025A")]
			set;
		}

		[Token(Token = "0x17000019")]
		GooglePlayReplacementMode? LastKnownReplacementMode
		{
			[Token(Token = "0x600025B")]
			get;
			[Token(Token = "0x600025C")]
			set;
		}
	}
	[Token(Token = "0x2000089")]
	internal interface IGooglePlayCheckEntitlementUseCase
	{
	}
	[Token(Token = "0x200008A")]
	internal interface IGooglePurchaseBuilder
	{
		[Token(Token = "0x600025D")]
		IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases);
	}
	[Token(Token = "0x200008B")]
	internal interface IGooglePurchaseCallback
	{
		[Token(Token = "0x600025E")]
		void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

		[Token(Token = "0x600025F")]
		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

		[Token(Token = "0x6000260")]
		void SetChangeSubscriptionCallback(UnityEngine.Purchasing.IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

		[Token(Token = "0x6000261")]
		void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);

		[Token(Token = "0x6000262")]
		void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription);

		[Token(Token = "0x6000263")]
		void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);

		[Token(Token = "0x6000264")]
		void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

		[Token(Token = "0x6000265")]
		void NotifyUpgradeDowngradeSubscription(string sku);
	}
	[Token(Token = "0x200008C")]
	internal interface IGooglePurchaseService
	{
		[Token(Token = "0x6000266")]
		void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode);

		[Token(Token = "0x6000267")]
		void SetProductCache(UnityEngine.Purchasing.Extension.IProductCache productCache);
	}
	[Token(Token = "0x200008D")]
	internal interface IGooglePurchaseStateEnumProvider
	{
		[Token(Token = "0x6000268")]
		int Purchased();

		[Token(Token = "0x6000269")]
		int Pending();
	}
	[Token(Token = "0x200008E")]
	internal interface IGooglePurchasesUpdatedListener
	{
		[Token(Token = "0x14000002")]
		event Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> OnPurchaseUpdated;
	}
	[Token(Token = "0x200008F")]
	internal interface IGoogleQueryPurchasesUseCase
	{
		[Token(Token = "0x600026C")]
		Task<List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();

		[Token(Token = "0x600026D")]
		Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase?>? GetPurchaseByToken(string? purchaseToken);
	}
	[Token(Token = "0x2000090")]
	internal interface IProductDetailsConverter
	{
		[Token(Token = "0x600026E")]
		List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions);
	}
	[Token(Token = "0x2000091")]
	internal interface IProductDetailsQueryResponse
	{
		[Token(Token = "0x600026F")]
		bool IsRecoverable();
	}
	[Token(Token = "0x2000092")]
	internal interface IGooglePlayStoreCheckEntitlementService
	{
		[Token(Token = "0x6000270")]
		void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback);
	}
}
