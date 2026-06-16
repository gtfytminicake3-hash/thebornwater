using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using UnityEngine.Events;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2C022D4", Offset = "0x2BFE2D4", VA = "0x2C022D4")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] NullableFlags;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C022DC", Offset = "0x2BFE2DC", VA = "0x2C022DC")]
		public NullableAttribute(byte P_0)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C0235C", Offset = "0x2BFE35C", VA = "0x2C0235C")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte Flag;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C02384", Offset = "0x2BFE384", VA = "0x2C02384")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Token(Token = "0x2000005")]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000006")]
	private struct MonoScriptData
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2C023AC", Offset = "0x2BFE3AC", VA = "0x2C023AC")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2C02468", Offset = "0x2BFE468", VA = "0x2C02468")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000007")]
	public enum CodelessButtonType
	{
		[Token(Token = "0x4000009")]
		Purchase,
		[Token(Token = "0x400000A")]
		Restore
	}
	[Token(Token = "0x2000008")]
	public static class CodelessCatalogProvider
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2C02470", Offset = "0x2BFE470", VA = "0x2C02470")]
		public static CatalogProvider PopulateCatalogProvider(ProductCatalog catalog)
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	public class CodelessIAPButton : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000A")]
		public class OnProductFetchedEvent : UnityEvent<Product>
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2C0413C", Offset = "0x2C0013C", VA = "0x2C0413C")]
			public OnProductFetchedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000B")]
		public class OnProductFetchFailedEvent : UnityEvent<ProductDefinition, string>
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2C04184", Offset = "0x2C00184", VA = "0x2C04184")]
			public OnProductFetchFailedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000C")]
		public class OnPurchaseFetchedEvent : UnityEvent<Order>
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2C041CC", Offset = "0x2C001CC", VA = "0x2C041CC")]
			public OnPurchaseFetchedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000D")]
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string?>
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2C04214", Offset = "0x2C00214", VA = "0x2C04214")]
			public OnTransactionsRestoredEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2C0425C", Offset = "0x2C0025C", VA = "0x2C0425C")]
			public OnOrderPendingEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000F")]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2C042A4", Offset = "0x2C002A4", VA = "0x2C042A4")]
			public OnOrderConfirmedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000010")]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2C042EC", Offset = "0x2C002EC", VA = "0x2C042EC")]
			public OnPurchaseFailedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000011")]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2C04334", Offset = "0x2C00334", VA = "0x2C04334")]
			public OnOrderDeferredEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000012")]
		[Obsolete]
		public class OnPurchaseCompletedLegacyEvent : UnityEvent<Product>
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2C0437C", Offset = "0x2C0037C", VA = "0x2C0437C")]
			public OnPurchaseCompletedLegacyEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000013")]
		[Obsolete]
		public class OnPurchaseFailedLegacyEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2C043C4", Offset = "0x2C003C4", VA = "0x2C043C4")]
			public OnPurchaseFailedLegacyEvent()
			{
			}
		}

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public string? productId;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public CodelessButtonType buttonType;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Automatically confirm the transaction immediately after a successful purchase.")]
		[FormerlySerializedAs("consumePurchase")]
		public bool automaticallyConfirmTransaction;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Event fired after fetching a product.")]
		public OnProductFetchedEvent? onProductFetched;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Event fired after failing to fetch a product.")]
		public OnProductFetchFailedEvent? onProductFetchFailed;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Event fired after fetching a purchase.")]
		public OnPurchaseFetchedEvent? onPurchaseFetched;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Event fired after a restore transactions.")]
		public OnTransactionsRestoredEvent? onTransactionsRestored;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Event fired after a pending order.")]
		public OnOrderPendingEvent? onOrderPending;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Event fired after a confirmed order.")]
		public OnOrderConfirmedEvent? onOrderConfirmed;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseFailedEvent? onPurchaseFailed;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Event fired after the payment of a purchase was delayed or postponed for this product.")]
		public OnOrderDeferredEvent? onOrderDeferred;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Obsolete Events (for backward compatibility only)")]
		[Tooltip("Event fired after a successful purchase of this product.")]
		[Obsolete]
		[FormerlySerializedAs("onPurchaseComplete")]
		public OnPurchaseCompletedLegacyEvent? onPurchaseCompleteLegacy;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Obsolete]
		[FormerlySerializedAs("onPurchaseFailed")]
		[Tooltip("Event fired after failing to purchase an order.")]
		public OnPurchaseFailedLegacyEvent? onPurchaseFailedLegacy;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Button that triggers purchase.")]
		public Button? button;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2C02DF8", Offset = "0x2BFEDF8", VA = "0x2C02DF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2C02E24", Offset = "0x2BFEE24", VA = "0x2C02E24")]
		private void AddPurchaseButtonListener()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2C02FA8", Offset = "0x2BFEFA8", VA = "0x2C02FA8")]
		private void AddRestoreButtonListener()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2C03388", Offset = "0x2BFF388", VA = "0x2C03388")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C03458", Offset = "0x2BFF458", VA = "0x2C03458")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C03488", Offset = "0x2BFF488", VA = "0x2C03488")]
		private void PurchaseProduct()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C036F4", Offset = "0x2BFF6F4", VA = "0x2C036F4")]
		private void Restore()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C02E14", Offset = "0x2BFEE14", VA = "0x2C02E14")]
		internal bool IsAPurchaseButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C02F98", Offset = "0x2BFEF98", VA = "0x2C02F98")]
		private bool IsARestoreButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2C03804", Offset = "0x2BFF804", VA = "0x2C03804")]
		public void OnProductFetched(Product product)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2C03864", Offset = "0x2BFF864", VA = "0x2C03864")]
		public void OnProductFetchFailed(ProductDefinition product, string failureReason)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2C038D8", Offset = "0x2BFF8D8", VA = "0x2C038D8")]
		public void OnPurchaseFetched(Order order)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2C03938", Offset = "0x2BFF938", VA = "0x2C03938")]
		public void OnTransactionsRestored(bool success, string? error)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2C039AC", Offset = "0x2BFF9AC", VA = "0x2C039AC")]
		public void OnOrderPending(PendingOrder order)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2C03B34", Offset = "0x2BFFB34", VA = "0x2C03B34")]
		public void OnOrderConfirmed(ConfirmedOrder order)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2C03B94", Offset = "0x2BFFB94", VA = "0x2C03B94")]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2C03D70", Offset = "0x2BFFD70", VA = "0x2C03D70")]
		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2C03DD0", Offset = "0x2BFFDD0", VA = "0x2C03DD0")]
		private Button? GetButton()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2C033C4", Offset = "0x2BFF3C4", VA = "0x2C033C4")]
		private void AddButtonToCodelessListener()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2C03468", Offset = "0x2BFF468", VA = "0x2C03468")]
		private void RemoveButtonToCodelessListener()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2C033E4", Offset = "0x2BFF3E4", VA = "0x2C033E4")]
		internal void OnInitCompleted()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2C040C4", Offset = "0x2C000C4", VA = "0x2C040C4")]
		public CodelessIAPButton()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class CodelessIAPStoreListener
	{
		[StructLayout(3)]
		[Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <ConnectToStore>d__60 : IAsyncStateMachine
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CodelessIAPStoreListener <>4__this;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2C0AAA4", Offset = "0x2C06AA4", VA = "0x2C0AAA4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2C0AD00", Offset = "0x2C06D00", VA = "0x2C0AD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <CreateCodelessIAPStoreListenerInstance>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2C0AD68", Offset = "0x2C06D68", VA = "0x2C0AD68", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2C0B040", Offset = "0x2C07040", VA = "0x2C0B040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct <InitializeCodelessPurchasingOnLoad>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2C0B0A8", Offset = "0x2C070A8", VA = "0x2C0B0A8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2C0B264", Offset = "0x2C07264", VA = "0x2C0B264", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <InitializePurchasing>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CodelessIAPStoreListener <>4__this;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2C0B270", Offset = "0x2C07270", VA = "0x2C0B270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2C0B4CC", Offset = "0x2C074CC", VA = "0x2C0B4CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CodelessIAPStoreListener? s_Instance;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<CodelessIAPButton> m_ActiveCodelessButtons;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<IAPListener> m_ActiveListeners;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_UnityPurchasingInitialized;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IStoreService? m_StoreService;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IProductService? m_ProductService;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IPurchaseService? m_PurchasingService;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly ProductCatalog m_Catalog;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CatalogProvider? m_CatalogProvider;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		protected IStoreController controller;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		protected IExtensionProvider extensions;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		private ConfigurationBuilder m_Builder;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_InitializationComplete;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public static bool initializationComplete;

		[Token(Token = "0x17000001")]
		public static CodelessIAPStoreListener Instance
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2C03044", Offset = "0x2BFF044", VA = "0x2C03044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public IStoreController StoreController
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2C0A1F4", Offset = "0x2C061F4", VA = "0x2C0A1F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2C0440C", Offset = "0x2C0040C", VA = "0x2C0440C")]
		[RuntimeInitializeOnLoadMethod]
		[AsyncStateMachine(typeof(<InitializeCodelessPurchasingOnLoad>d__14))]
		private static void InitializeCodelessPurchasingOnLoad()
		{
		}

		[Token(Token = "0x600002B")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public T GetStoreConfiguration<T>() where T : notnull, IStoreConfiguration
		{
			return (T)null;
		}

		[Token(Token = "0x600002C")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public T GetStoreExtensions<T>() where T : notnull, IStoreExtension
		{
			return (T)null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2C04490", Offset = "0x2C00490", VA = "0x2C04490")]
		[AsyncStateMachine(typeof(<CreateCodelessIAPStoreListenerInstance>d__19))]
		private static Task CreateCodelessIAPStoreListenerInstance()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2C04548", Offset = "0x2C00548", VA = "0x2C04548")]
		[AsyncStateMachine(typeof(<InitializePurchasing>d__20))]
		private Task InitializePurchasing()
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2C04604", Offset = "0x2C00604", VA = "0x2C04604")]
		private void InitCatalog()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2C04620", Offset = "0x2C00620", VA = "0x2C04620")]
		private void CreateServices()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2C04660", Offset = "0x2C00660", VA = "0x2C04660")]
		private void ConfigureServiceCallbacks()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2C04678", Offset = "0x2C00678", VA = "0x2C04678")]
		private void ConfigureProductServiceCallbacks()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2C04CA0", Offset = "0x2C00CA0", VA = "0x2C04CA0")]
		private void ChangeProductServiceCallbacks()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2C04834", Offset = "0x2C00834", VA = "0x2C04834")]
		private void ConfigurePurchasingServiceCallbacks()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2C04F8C", Offset = "0x2C00F8C", VA = "0x2C04F8C")]
		private void OnInitialProductsFetched(List<Product> products)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2C050C4", Offset = "0x2C010C4", VA = "0x2C050C4")]
		private void HandleOnInitForAllButtons()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2C05018", Offset = "0x2C01018", VA = "0x2C05018")]
		private void FetchExistingPurchases()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2C051F0", Offset = "0x2C011F0", VA = "0x2C051F0")]
		private void InvokeOnProductsFetched(List<Product> products)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2C05218", Offset = "0x2C01218", VA = "0x2C05218")]
		private void InvokeListenersOnProductsFetched(List<Product> products)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2C05354", Offset = "0x2C01354", VA = "0x2C05354")]
		private void InvokeButtonsOnProductsFetched(List<Product> products)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2C0589C", Offset = "0x2C0189C", VA = "0x2C0589C")]
		private void OnInitialProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2C058C4", Offset = "0x2C018C4", VA = "0x2C058C4")]
		private void InvokeListenersOnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2C05A00", Offset = "0x2C01A00", VA = "0x2C05A00")]
		private void InvokeButtonsOnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2C05EFC", Offset = "0x2C01EFC", VA = "0x2C05EFC")]
		private void OnAdditionalProductsFetched(List<Product> products)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2C05F24", Offset = "0x2C01F24", VA = "0x2C05F24")]
		private void OnAdditionalProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2C05F4C", Offset = "0x2C01F4C", VA = "0x2C05F4C")]
		private void OnPurchasesFetched(Orders existingOrders)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2C05F74", Offset = "0x2C01F74", VA = "0x2C05F74")]
		private void InvokeListenersOnPurchasesFetched(Orders existingOrders)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2C060B0", Offset = "0x2C020B0", VA = "0x2C060B0")]
		private void InvokeButtonsOnPurchasesFetched(Orders existingOrders)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2C071F8", Offset = "0x2C031F8", VA = "0x2C071F8")]
		private void OnPurchasesFetchFailure(PurchasesFetchFailureDescription failure)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2C0738C", Offset = "0x2C0338C", VA = "0x2C0738C")]
		private void OnOrderPending(PendingOrder order)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2C073C0", Offset = "0x2C033C0", VA = "0x2C073C0")]
		private void InvokeOnOrderPending(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2C07420", Offset = "0x2C03420", VA = "0x2C07420")]
		private void InvokeListenersOnOrderPending(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2C0755C", Offset = "0x2C0355C", VA = "0x2C0755C")]
		private void InvokeButtonsOnOrderPending(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2C073E8", Offset = "0x2C033E8", VA = "0x2C073E8")]
		private void ConfirmOrderIfAutomatic(PendingOrder order)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2C07CD0", Offset = "0x2C03CD0", VA = "0x2C07CD0")]
		private bool ShouldConfirmOrderAutomatically(PendingOrder order)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2C08210", Offset = "0x2C04210", VA = "0x2C08210")]
		private CodelessIAPButton FindMatchingButtonByProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2C0815C", Offset = "0x2C0415C", VA = "0x2C0815C")]
		private void ConfirmOrder(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2C08374", Offset = "0x2C04374", VA = "0x2C08374")]
		private void OnPurchaseConfirmed(Order order)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2C08508", Offset = "0x2C04508", VA = "0x2C08508")]
		private void OnOrderConfirmed(ConfirmedOrder order)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2C08558", Offset = "0x2C04558", VA = "0x2C08558")]
		private void InvokeListenersOnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2C08694", Offset = "0x2C04694", VA = "0x2C08694")]
		private void InvokeButtonsOnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2C08530", Offset = "0x2C04530", VA = "0x2C08530")]
		private void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2C08D44", Offset = "0x2C04D44", VA = "0x2C08D44")]
		private void InvokeListenersOnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2C08E80", Offset = "0x2C04E80", VA = "0x2C08E80")]
		private void InvokeButtonsOnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2C096F8", Offset = "0x2C056F8", VA = "0x2C096F8")]
		private void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2C09720", Offset = "0x2C05720", VA = "0x2C09720")]
		private void InvokeListenersOnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2C0985C", Offset = "0x2C0585C", VA = "0x2C0985C")]
		private void InvokeButtonsOnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2C09F18", Offset = "0x2C05F18", VA = "0x2C09F18")]
		[AsyncStateMachine(typeof(<ConnectToStore>d__60))]
		private Task ConnectToStore()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2C09FD4", Offset = "0x2C05FD4", VA = "0x2C09FD4")]
		private void FetchInitialProducts()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2C0A0EC", Offset = "0x2C060EC", VA = "0x2C0A0EC")]
		private Task AutoInitializeUnityGamingServicesIfEnabled()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2C0A1B0", Offset = "0x2C061B0", VA = "0x2C0A1B0")]
		private static bool ShouldAutoInitUgs()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2C030B0", Offset = "0x2BFF0B0", VA = "0x2C030B0")]
		public bool HasProductInCatalog(string productID)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2C03ED4", Offset = "0x2BFFED4", VA = "0x2C03ED4")]
		public Product? GetProduct(string? productID)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2C03DD8", Offset = "0x2BFFDD8", VA = "0x2C03DD8")]
		public void AddButton(CodelessIAPButton button)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2C03E7C", Offset = "0x2BFFE7C", VA = "0x2C03E7C")]
		public void RemoveButton(CodelessIAPButton button)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2C0A204", Offset = "0x2C06204", VA = "0x2C0A204")]
		public void AddListener(IAPListener listener)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2C0A2A8", Offset = "0x2C062A8", VA = "0x2C0A2A8")]
		public void RemoveListener(IAPListener listener)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2C034B8", Offset = "0x2BFF4B8", VA = "0x2C034B8")]
		public void InitiatePurchase(string? productID)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2C0A300", Offset = "0x2C06300", VA = "0x2C0A300")]
		private void SendPurchaseFailedEventsToAllButtons(Product? product)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2C0A708", Offset = "0x2C06708", VA = "0x2C0A708")]
		public ProductCatalog GetProductCatalog()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2C0A710", Offset = "0x2C06710", VA = "0x2C0A710")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2C0A718", Offset = "0x2C06718", VA = "0x2C0A718")]
		public CodelessIAPStoreListener()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[RequireComponent(typeof(Button))]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	public class IAPButton : MonoBehaviour
	{
		[Token(Token = "0x2000025")]
		public enum ButtonType
		{
			[Token(Token = "0x4000059")]
			Purchase,
			[Token(Token = "0x400005A")]
			Restore
		}

		[Serializable]
		[Token(Token = "0x2000026")]
		public class OnProductFetchedEvent : UnityEvent<Product>
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2C0B704", Offset = "0x2C07704", VA = "0x2C0B704")]
			public OnProductFetchedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000027")]
		public class OnProductFetchFailedEvent : UnityEvent<ProductDefinition, string>
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2C0B74C", Offset = "0x2C0774C", VA = "0x2C0B74C")]
			public OnProductFetchFailedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000028")]
		public class OnPurchaseFetchedEvent : UnityEvent<Order>
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2C0B794", Offset = "0x2C07794", VA = "0x2C0B794")]
			public OnPurchaseFetchedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000029")]
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string?>
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2C0B7DC", Offset = "0x2C077DC", VA = "0x2C0B7DC")]
			public OnTransactionsRestoredEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002A")]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x2C0B824", Offset = "0x2C07824", VA = "0x2C0B824")]
			public OnOrderPendingEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002B")]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x2C0B86C", Offset = "0x2C0786C", VA = "0x2C0B86C")]
			public OnOrderConfirmedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002C")]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2C0B8B4", Offset = "0x2C078B4", VA = "0x2C0B8B4")]
			public OnPurchaseFailedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002D")]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2C0B8FC", Offset = "0x2C078FC", VA = "0x2C0B8FC")]
			public OnOrderDeferredEvent()
			{
			}
		}

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public string? productId;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public ButtonType buttonType;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Consume the product immediately after a successful purchase.")]
		public bool consumePurchase;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Event fired after fetching a product.")]
		public OnProductFetchedEvent? onProductFetched;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Event fired after failing to fetch a product.")]
		public OnProductFetchFailedEvent? onProductFetchFailed;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Event fired after fetching a purchase.")]
		public OnPurchaseFetchedEvent? onPurchaseFetched;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Event fired after a restore transactions.")]
		public OnTransactionsRestoredEvent? onTransactionsRestored;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Event fired after a pending order.")]
		public OnOrderPendingEvent? onOrderPending;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Event fired after a confirmed order.")]
		public OnOrderConfirmedEvent? onOrderConfirmed;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Event fired after a failed purchase of this product.")]
		public OnPurchaseFailedEvent? onPurchaseFailed;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Event fired after the payment of a purchase was delayed or postponed for this product.")]
		public OnOrderDeferredEvent? onOrderDeferred;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("[Optional] Displays the localized title from the app store.")]
		public Text? titleText;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("[Optional] Displays the localized description from the app store.")]
		public Text? descriptionText;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("[Optional] Displays the localized price from the app store.")]
		public Text? priceText;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2C0B534", Offset = "0x2C07534", VA = "0x2C0B534")]
		public void OnProductFetched(Product product)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2C0B56C", Offset = "0x2C0756C", VA = "0x2C0B56C")]
		public void OnProductFetchFailed(ProductDefinition product, string failureReason)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2C0B5A4", Offset = "0x2C075A4", VA = "0x2C0B5A4")]
		public void OnPurchaseFetched(Order order)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2C0B5DC", Offset = "0x2C075DC", VA = "0x2C0B5DC")]
		private void OnTransactionsRestored(bool success, string? error)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2C0B614", Offset = "0x2C07614", VA = "0x2C0B614")]
		public void OnOrderPending(PendingOrder order)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2C0B64C", Offset = "0x2C0764C", VA = "0x2C0B64C")]
		public void OnOrderConfirmed(ConfirmedOrder order)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2C0B684", Offset = "0x2C07684", VA = "0x2C0B684")]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2C0B6BC", Offset = "0x2C076BC", VA = "0x2C0B6BC")]
		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2C0B6F4", Offset = "0x2C076F4", VA = "0x2C0B6F4")]
		public IAPButton()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AddComponentMenu("In-App Purchasing/IAP Listener")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	public class IAPListener : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002F")]
		public class OnProductsFetchedEvent : UnityEvent<List<Product>>
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2C0B9FC", Offset = "0x2C079FC", VA = "0x2C0B9FC")]
			public OnProductsFetchedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000030")]
		public class OnProductsFetchFailedEvent : UnityEvent<ProductFetchFailed>
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2C0BA44", Offset = "0x2C07A44", VA = "0x2C0BA44")]
			public OnProductsFetchFailedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000031")]
		public class OnPurchasesFetchedEvent : UnityEvent<Orders>
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2C0BA8C", Offset = "0x2C07A8C", VA = "0x2C0BA8C")]
			public OnPurchasesFetchedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000032")]
		public class OnPurchasesFetchFailureEvent : UnityEvent<PurchasesFetchFailureDescription>
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2C0BAD4", Offset = "0x2C07AD4", VA = "0x2C0BAD4")]
			public OnPurchasesFetchFailureEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000033")]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2C0BB1C", Offset = "0x2C07B1C", VA = "0x2C0BB1C")]
			public OnOrderPendingEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000034")]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2C0BB64", Offset = "0x2C07B64", VA = "0x2C0BB64")]
			public OnOrderConfirmedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2C0BBAC", Offset = "0x2C07BAC", VA = "0x2C0BBAC")]
			public OnPurchaseFailedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2C0BBF4", Offset = "0x2C07BF4", VA = "0x2C0BBF4")]
			public OnOrderDeferredEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		[Obsolete]
		public class OnProductsFetchedLegacyEvent : UnityEvent<ProductCollection>
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2C0BC3C", Offset = "0x2C07C3C", VA = "0x2C0BC3C")]
			public OnProductsFetchedLegacyEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		[Obsolete]
		public class OnPurchaseCompletedLegacyEvent : UnityEvent<Product>
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2C0BC84", Offset = "0x2C07C84", VA = "0x2C0BC84")]
			public OnPurchaseCompletedLegacyEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000039")]
		[Obsolete]
		public class OnPurchaseFailedLegacyEvent : UnityEvent<Product, PurchaseFailureReason>
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2C0BCCC", Offset = "0x2C07CCC", VA = "0x2C0BCCC")]
			public OnPurchaseFailedLegacyEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		[Obsolete]
		public class OnPurchaseDetailedFailedLegacyEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2C0BD14", Offset = "0x2C07D14", VA = "0x2C0BD14")]
			public OnPurchaseDetailedFailedLegacyEvent()
			{
			}
		}

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Automatically confirm the transaction immediately after a successful purchase.")]
		public bool automaticallyConfirmTransaction;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Preserve this GameObject when a new scene is loaded.")]
		public bool dontDestroyOnLoad;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Event fired after fetching products.")]
		public OnProductsFetchedEvent onProductsFetched;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Event fired after failing to fetch products.")]
		public OnProductsFetchFailedEvent onProductsFetchFailed;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Event fired after fetching purchases.")]
		public OnPurchasesFetchedEvent onPurchasesFetched;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Event fired after failing to fetch purchases.")]
		public OnPurchasesFetchFailureEvent onPurchasesFetchFailure;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Event fired after updating a pending order.")]
		public OnOrderPendingEvent onOrderPending;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Event fired after updating a confirmed order.")]
		public OnOrderConfirmedEvent onOrderConfirmed;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Event fired after failing to purchase an order.")]
		public OnPurchaseFailedEvent onPurchaseFailed;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Event fired after the payment of a purchase was delayed or postponed.")]
		public OnOrderDeferredEvent onOrderDeferred;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Event fired after a successful fetching the products from the store.")]
		[FormerlySerializedAs("onProductsFetched")]
		[Header("Obsolete Events (for backward compatibility only)")]
		[Obsolete]
		public OnProductsFetchedLegacyEvent onProductsFetchedLegacy;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("onPurchaseComplete")]
		[Tooltip("Event fired after a successful purchase of this product.")]
		[Obsolete]
		public OnPurchaseCompletedLegacyEvent onPurchaseCompleteLegacy;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[FormerlySerializedAs("onPurchaseFailed")]
		[Obsolete]
		public OnPurchaseFailedLegacyEvent onPurchaseFailedLegacy;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Obsolete]
		[FormerlySerializedAs("onPurchaseDetailedFailedEvent")]
		[Tooltip("Event fired after failing to purchase an order.")]
		public OnPurchaseDetailedFailedLegacyEvent onPurchaseDetailedFailedLegacy;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2C0B944", Offset = "0x2C07944", VA = "0x2C0B944")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2C0B9CC", Offset = "0x2C079CC", VA = "0x2C0B9CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2C057E8", Offset = "0x2C017E8", VA = "0x2C057E8")]
		public void OnProductsFetched(List<Product> products)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2C05E9C", Offset = "0x2C01E9C", VA = "0x2C05E9C")]
		public void OnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2C07190", Offset = "0x2C03190", VA = "0x2C07190")]
		public void OnPurchasesFetched(Orders orders)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2C07334", Offset = "0x2C03334", VA = "0x2C07334")]
		public void OnPurchasesFetchFailure(PurchasesFetchFailureDescription purchasesFetchFailureDescription)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2C07BA4", Offset = "0x2C03BA4", VA = "0x2C07BA4")]
		public void OnOrderPending(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2C08CDC", Offset = "0x2C04CDC", VA = "0x2C08CDC")]
		public void OnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2C094DC", Offset = "0x2C054DC", VA = "0x2C094DC")]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2C09EB8", Offset = "0x2C05EB8", VA = "0x2C09EB8")]
		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2C0B9EC", Offset = "0x2C079EC", VA = "0x2C0B9EC")]
		public IAPListener()
		{
		}
	}
}
