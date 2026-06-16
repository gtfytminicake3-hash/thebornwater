using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Purchasing.Extension;
using Purchasing.Utilities;
using Uniject;
using Unity.Services.Core.Telemetry.Internal;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Security;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2C0BDAC", Offset = "0x2C07DAC", VA = "0x2C0BDAC")]
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
		[Address(RVA = "0x2C0BDB4", Offset = "0x2C07DB4", VA = "0x2C0BDB4")]
		public NullableAttribute(byte P_0)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C0BE34", Offset = "0x2C07E34", VA = "0x2C0BE34")]
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
		[Address(RVA = "0x2C0BE5C", Offset = "0x2C07E5C", VA = "0x2C0BE5C")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Purchasing.Extension
{
	[Token(Token = "0x2000005")]
	internal abstract class InternalStore : Store, IInternalStore, IStore
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal IStoreConnectionStateService StoreConnectionStateService;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2C0BE84", Offset = "0x2C07E84", VA = "0x2C0BE84")]
		protected InternalStore()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C0BFB0", Offset = "0x2C07FB0", VA = "0x2C0BFB0", Slot = "29")]
		public ConnectionState GetStoreConnectionState()
		{
			return default(ConnectionState);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2C0C050", Offset = "0x2C08050", VA = "0x2C0C050", Slot = "28")]
		public void SetStoreConnectionState(ConnectionState connectionState)
		{
		}
	}
}
namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000006")]
	internal interface IAnalyticsAdapter
	{
		[Token(Token = "0x6000008")]
		void SendTransactionEvent(CartItem item, string receipt);

		[Token(Token = "0x6000009")]
		void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription);
	}
	[Token(Token = "0x2000007")]
	internal interface IAnalyticsClient
	{
		[Token(Token = "0x600000A")]
		void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder);

		[Token(Token = "0x600000B")]
		void OnPurchaseFailed(FailedOrder failedOrder);
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public abstract class IapException : Exception
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C0C0FC", Offset = "0x2C080FC", VA = "0x2C0C0FC")]
		internal IapException()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C0C154", Offset = "0x2C08154", VA = "0x2C0C154")]
		internal IapException(string message)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C0C1BC", Offset = "0x2C081BC", VA = "0x2C0C1BC")]
		protected IapException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class ServiceCreationException : IapException
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C0C23C", Offset = "0x2C0823C", VA = "0x2C0C23C")]
		internal ServiceCreationException(string message)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public interface IProductService
	{
		[Token(Token = "0x14000001")]
		event Action<List<Product>>? OnProductsFetched;

		[Token(Token = "0x14000002")]
		event Action<ProductFetchFailed>? OnProductsFetchFailed;

		[Token(Token = "0x6000010")]
		void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions);

		[Token(Token = "0x6000011")]
		ReadOnlyObservableCollection<Product> GetProducts();
	}
	[Token(Token = "0x200000B")]
	internal interface IProductServiceFactory
	{
		[Token(Token = "0x6000016")]
		IProductService Create(IStoreWrapper store);
	}
	[Token(Token = "0x200000C")]
	internal interface IProductServiceFactoryManager
	{
		[Token(Token = "0x6000017")]
		IProductServiceFactory GetServiceFactory();
	}
	[Token(Token = "0x200000D")]
	internal interface IProductServiceFactoryManagerInjectionPoint
	{
		[Token(Token = "0x6000018")]
		void SetServiceFactory(IProductServiceFactory serviceFactory);
	}
	[Token(Token = "0x200000E")]
	public class ProductFetchFailed
	{
		[Token(Token = "0x17000001")]
		public List<ProductDefinition> FailedFetchProducts
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2C0C240", Offset = "0x2C08240", VA = "0x2C0C240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public string FailureReason
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2C0C248", Offset = "0x2C08248", VA = "0x2C0C248")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2C0C250", Offset = "0x2C08250", VA = "0x2C0C250")]
		internal ProductFetchFailed(List<ProductDefinition> products, string reason)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class ProductFetchFailureDescription : IRetryableRequestFailureDescription
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ProductFetchFailureReason reason;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isRetryable;

		[Token(Token = "0x17000003")]
		public ProductFetchFailureReason Reason
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2C0C27C", Offset = "0x2C0827C", VA = "0x2C0C27C")]
			get
			{
				return default(ProductFetchFailureReason);
			}
		}

		[Token(Token = "0x17000004")]
		public string Message
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2C0C284", Offset = "0x2C08284", VA = "0x2C0C284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public bool IsRetryable
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2C0C28C", Offset = "0x2C0828C", VA = "0x2C0C28C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2C0C294", Offset = "0x2C08294", VA = "0x2C0C294")]
		public ProductFetchFailureDescription(ProductFetchFailureReason reason, string message, bool isRetryable = false)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public enum ProductFetchFailureReason
	{
		[Token(Token = "0x400000A")]
		ProviderUnavailable,
		[Token(Token = "0x400000B")]
		ProductsUnavailable,
		[Token(Token = "0x400000C")]
		Unknown
	}
	[Token(Token = "0x2000011")]
	internal class ProductFetchRequest
	{
		[Token(Token = "0x17000006")]
		internal ReadOnlyCollection<ProductDefinition> RequestedProducts
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2C0C2D4", Offset = "0x2C082D4", VA = "0x2C0C2D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		internal Action<List<Product>> SuccessAction
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2C0C2DC", Offset = "0x2C082DC", VA = "0x2C0C2DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		internal Action<List<ProductDefinition>, string> FailureAction
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2C0C2E4", Offset = "0x2C082E4", VA = "0x2C0C2E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2C0C2EC", Offset = "0x2C082EC", VA = "0x2C0C2EC")]
		internal ProductFetchRequest(ReadOnlyCollection<ProductDefinition> products, Action<List<Product>> fetchSuccessAction, Action<List<ProductDefinition>, string> fetchFailureAction)
		{
		}
	}
	[Token(Token = "0x2000012")]
	internal class ProductService : IProductService
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IRetryPolicy k_DefaultRetryPolicy;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IFetchProductsUseCase m_FetchProductsUseCase;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IStoreWrapper m_StoreWrapper;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IProductCache m_ProductCache;

		[Token(Token = "0x14000003")]
		public event Action<List<Product>>? OnProductsFetched
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2C0C328", Offset = "0x2C08328", VA = "0x2C0C328", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2C0C3D8", Offset = "0x2C083D8", VA = "0x2C0C3D8", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<ProductFetchFailed>? OnProductsFetchFailed
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2C0C488", Offset = "0x2C08488", VA = "0x2C0C488", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2C0C538", Offset = "0x2C08538", VA = "0x2C0C538", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2C0C5E8", Offset = "0x2C085E8", VA = "0x2C0C5E8")]
		internal ProductService(IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2C0C6B4", Offset = "0x2C086B4", VA = "0x2C0C6B4", Slot = "4")]
		public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2C0C6BC", Offset = "0x2C086BC", VA = "0x2C0C6BC", Slot = "10")]
		public void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy? retryPolicy)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2C0CB2C", Offset = "0x2C08B2C", VA = "0x2C0CB2C", Slot = "5")]
		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2C0CBD0", Offset = "0x2C08BD0", VA = "0x2C0CBD0")]
		private void HandleProductsFetched(List<Product>? fetchedProducts)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2C0CA5C", Offset = "0x2C08A5C", VA = "0x2C0CA5C")]
		private void HandleProductsFetchFailed(List<ProductDefinition>? fetchedProducts, string reason)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2C0C8FC", Offset = "0x2C088FC", VA = "0x2C0C8FC")]
		private void CheckStoreConnectionState()
		{
		}
	}
	[Token(Token = "0x2000013")]
	internal class ProductServiceContainer
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProductServiceContainer? s_Instance;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IProductService> m_InstantiatedServices;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2C0CE08", Offset = "0x2C08E08", VA = "0x2C0CE08")]
		internal static ProductServiceContainer Instance()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2C0CEEC", Offset = "0x2C08EEC", VA = "0x2C0CEEC")]
		internal IProductService FindService(string storeName)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2C0CF80", Offset = "0x2C08F80", VA = "0x2C0CF80")]
		internal void SetService(string storeName, IProductService service)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2C0CE70", Offset = "0x2C08E70", VA = "0x2C0CE70")]
		public ProductServiceContainer()
		{
		}
	}
	[Token(Token = "0x2000014")]
	internal class ProductServiceDependencyInjector
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IStoreWrapper m_storeWrapper;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IProductServiceFactoryManager m_ServiceFactoryManager;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2C0D07C", Offset = "0x2C0907C", VA = "0x2C0D07C")]
		internal ProductServiceDependencyInjector(IStoreWrapper storeWrapper)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2C0D120", Offset = "0x2C09120", VA = "0x2C0D120")]
		internal IProductService CreateProductService()
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	internal class ProductServiceFactoryManager : IProductServiceFactoryManager, IProductServiceFactoryManagerInjectionPoint
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ProductServiceFactoryManager s_Instance;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IProductServiceFactory m_Factory;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2C0D0A8", Offset = "0x2C090A8", VA = "0x2C0D0A8")]
		internal static ProductServiceFactoryManager Instance()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2C0D244", Offset = "0x2C09244", VA = "0x2C0D244", Slot = "5")]
		public void SetServiceFactory(IProductServiceFactory serviceFactory)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2C0D24C", Offset = "0x2C0924C", VA = "0x2C0D24C", Slot = "4")]
		public IProductServiceFactory GetServiceFactory()
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2C0D23C", Offset = "0x2C0923C", VA = "0x2C0D23C")]
		public ProductServiceFactoryManager()
		{
		}
	}
	[Token(Token = "0x2000016")]
	internal static class ProductServiceProvider
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2C0D254", Offset = "0x2C09254", VA = "0x2C0D254")]
		public static IProductService GetDefaultProductService()
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2C0D358", Offset = "0x2C09358", VA = "0x2C0D358")]
		public static IProductService GetProductService(string storeName)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2C0D334", Offset = "0x2C09334", VA = "0x2C0D334")]
		private static IProductService GetProductServiceInternal(IStoreWrapper storeWrapper)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2C0D4EC", Offset = "0x2C094EC", VA = "0x2C0D4EC")]
		private static IProductService LocateExistingService(IStoreWrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2C0D5C8", Offset = "0x2C095C8", VA = "0x2C0D5C8")]
		private static IProductService CreateNewService(IStoreWrapper wrapper)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	internal class FetchProductsUseCase : IFetchProductsUseCase, IStoreProductsCallback
	{
		[StructLayout(3)]
		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <OnProductsFetchFailed>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FetchProductsUseCase <>4__this;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProductFetchFailureDescription failureDescription;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2C0E65C", Offset = "0x2C0A65C", VA = "0x2C0E65C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2C0E8D8", Offset = "0x2C0A8D8", VA = "0x2C0E8D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStore m_Store;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IRetryService m_RetryService;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ProductFetchRequest? m_ActiveRequest;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IRetryRequest? m_ActiveRetryRequest;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2C0D79C", Offset = "0x2C0979C", VA = "0x2C0D79C")]
		[Preserve]
		internal FetchProductsUseCase(IStore storeResponsible, IRetryService retryService)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2C0D860", Offset = "0x2C09860", VA = "0x2C0D860", Slot = "4")]
		public void FetchProducts(List<ProductDefinition>? productDefinitions, Action<List<Product>?> fetchSuccessAction, Action<List<ProductDefinition>?, string> fetchFailureAction, IRetryPolicy retryPolicy)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2C0D9AC", Offset = "0x2C099AC", VA = "0x2C0D9AC")]
		private void ProcessValidFetchRequest(ProductFetchRequest request, IRetryPolicy retryPolicy)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2C0DB64", Offset = "0x2C09B64", VA = "0x2C0DB64", Slot = "5")]
		public void OnProductsFetched(IReadOnlyList<ProductDescription> products)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2C0DB7C", Offset = "0x2C09B7C", VA = "0x2C0DB7C")]
		private void ProcessFetchedProductsAndInvokeCallbacks(ProductFetchRequest request, IReadOnlyList<ProductDescription> productsRetrieved)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2C0DFE8", Offset = "0x2C09FE8", VA = "0x2C0DFE8")]
		private ProductDefinition GetMatchingDefinition(ProductDescription description)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2C0E0D8", Offset = "0x2C0A0D8", VA = "0x2C0E0D8")]
		private Product CreateMatchedProduct(ProductDefinition definition, ProductDescription description)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2C0E14C", Offset = "0x2C0A14C", VA = "0x2C0E14C")]
		private static void InvokeSuccessIfFetchedProducts(List<Product> fetchedProducts, Action<List<Product>>? successCallback)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2C0E1BC", Offset = "0x2C0A1BC", VA = "0x2C0E1BC")]
		private static void InvokeFailureIfIncomplete(ProductFetchRequest request, List<ProductDefinition> matchedDefinitions)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2C0E39C", Offset = "0x2C0A39C", VA = "0x2C0E39C", Slot = "6")]
		[AsyncStateMachine(typeof(<OnProductsFetchFailed>d__13))]
		public void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2C0E434", Offset = "0x2C0A434", VA = "0x2C0E434")]
		private void SendRequestFailureCallback(ProductFetchRequest productFetchRequest, ProductFetchFailureDescription failureDescription)
		{
		}
	}
	[Token(Token = "0x200001C")]
	internal interface IFetchProductsUseCase
	{
		[Token(Token = "0x6000052")]
		void FetchProducts(List<ProductDefinition>? productDefinitions, Action<List<Product>?> fetchSuccessAction, Action<List<ProductDefinition>?, string> fetchFailureAction, IRetryPolicy retryPolicy);
	}
	[Token(Token = "0x200001D")]
	internal class GooglePlayStoreExtendedPurchaseService : PurchaseService, IGooglePlayStoreExtendedPurchaseService
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly IGooglePlayChangeSubscriptionUseCase m_GooglePlayChangeSubscriptionUseCase;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2C0E8E4", Offset = "0x2C0A8E4", VA = "0x2C0E8E4")]
		[Preserve]
		internal GooglePlayStoreExtendedPurchaseService(IGooglePlayChangeSubscriptionUseCase googlePlayChangeSubscriptionUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2C0EC84", Offset = "0x2C0AC84", VA = "0x2C0EC84", Slot = "25")]
		public GooglePurchaseState? GetPurchaseState(Order order)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2C0EDA8", Offset = "0x2C0ADA8", VA = "0x2C0EDA8", Slot = "24")]
		protected override void RestoreTransactionsInternal(Action<bool, string?>? callback)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public interface IGooglePlayStoreExtendedPurchaseService
	{
		[Token(Token = "0x6000056")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		GooglePurchaseState? GetPurchaseState(Order order);
	}
	[Token(Token = "0x200001F")]
	internal class GooglePlayGetGooglePurchaseUseCase
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStore m_Store;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2C0EE50", Offset = "0x2C0AE50", VA = "0x2C0EE50")]
		[Preserve]
		public GooglePlayGetGooglePurchaseUseCase(IStore store)
		{
		}
	}
	[Token(Token = "0x2000020")]
	internal class GooglePlayRestoreTransactionUseCase : IRestoreTransactionsUseCase
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2C0EE78", Offset = "0x2C0AE78", VA = "0x2C0EE78")]
		[Preserve]
		public GooglePlayRestoreTransactionUseCase(IFetchPurchasesUseCase fetchPurchasesUseCase)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2C0EEA0", Offset = "0x2C0AEA0", VA = "0x2C0EEA0", Slot = "4")]
		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}
	}
	[Token(Token = "0x2000021")]
	internal class GooglePlayCartValidator : StoreCartValidator
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2C0EEC0", Offset = "0x2C0AEC0", VA = "0x2C0EEC0")]
		[Preserve]
		internal GooglePlayCartValidator()
		{
		}
	}
	[Token(Token = "0x2000022")]
	internal interface IGooglePlayChangeSubscriptionCallback : IStorePurchaseCallback
	{
		[Token(Token = "0x600005B")]
		void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId);

		[Token(Token = "0x600005C")]
		void OnSubscriptionChange(string storeSpecificId);
	}
	[Token(Token = "0x2000023")]
	internal interface IGooglePlayChangeSubscriptionUseCase
	{
	}
	[Token(Token = "0x2000024")]
	internal class SubscriptionChangeRequest
	{
		[Token(Token = "0x17000009")]
		internal Order CurrentOrder
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2C0F0D4", Offset = "0x2C0B0D4", VA = "0x2C0F0D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		internal Product NewSubscription
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2C0F0DC", Offset = "0x2C0B0DC", VA = "0x2C0F0DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000025")]
	internal class GooglePlayPurchaseUseCase : PurchaseUseCase, IGooglePlayChangeSubscriptionUseCase, IGooglePlayChangeSubscriptionCallback, IStorePurchaseCallback
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<SubscriptionChangeRequest> m_PendingRequests;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IProductCache m_ProductCache;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		private Action<DeferredPaymentUntilRenewalDateOrder>? OnDeferredPaymentUntilRenewalDate;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2C0F0E4", Offset = "0x2C0B0E4", VA = "0x2C0F0E4")]
		internal GooglePlayPurchaseUseCase(IGooglePlayStore storeResponsible, IProductCache productCache)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2C0F3A4", Offset = "0x2C0B3A4", VA = "0x2C0F3A4")]
		private void OnSubscriptionChangeFailed(FailedOrder order)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2C0F634", Offset = "0x2C0B634", VA = "0x2C0F634", Slot = "14")]
		public void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2C0F8AC", Offset = "0x2C0B8AC", VA = "0x2C0F8AC")]
		internal void InvokeOnDeferredPaymentUntilRenewalDate(DeferredPaymentUntilRenewalDateOrder pendingPurchase)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2C0FA48", Offset = "0x2C0BA48", VA = "0x2C0FA48", Slot = "15")]
		public void OnSubscriptionChange(string storeSpecificId)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2C0F560", Offset = "0x2C0B560", VA = "0x2C0F560")]
		private SubscriptionChangeRequest GetMatchingRequest(string productId)
		{
			return null;
		}
	}
	[Token(Token = "0x2000027")]
	internal class AppleAppStoreCartValidator : StoreCartValidator
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2C0FC58", Offset = "0x2C0BC58", VA = "0x2C0FC58")]
		internal AppleAppStoreCartValidator(string storeName)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public interface IAppleStoreExtendedPurchaseService
	{
		[Token(Token = "0x1700000B")]
		[Obsolete]
		string? appReceipt
		{
			[Token(Token = "0x6000068")]
			get;
		}

		[Token(Token = "0x6000069")]
		[Obsolete]
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
	[Token(Token = "0x2000029")]
	public class AggregateCartValidator : ICartValidator
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ICartValidator> m_CartValidators;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2C0FCC4", Offset = "0x2C0BCC4", VA = "0x2C0FCC4")]
		public AggregateCartValidator(params ICartValidator[] cartValidators)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2C0FD4C", Offset = "0x2C0BD4C", VA = "0x2C0FD4C", Slot = "4")]
		public void Validate(ICart cart)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class NonNullCartValidator : ICartValidator
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2C0FEF0", Offset = "0x2C0BEF0", VA = "0x2C0FEF0", Slot = "4")]
		public void Validate(ICart cart)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2C1015C", Offset = "0x2C0C15C", VA = "0x2C1015C")]
		public NonNullCartValidator()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class SingleProductCartValidator : ICartValidator
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2C101EC", Offset = "0x2C0C1EC", VA = "0x2C101EC", Slot = "4")]
		public void Validate(ICart cart)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2C102F4", Offset = "0x2C0C2F4", VA = "0x2C102F4")]
		public SingleProductCartValidator()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class SingleProductSingleQuantityCartValidator : AggregateCartValidator
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2C0EF40", Offset = "0x2C0AF40", VA = "0x2C0EF40")]
		public SingleProductSingleQuantityCartValidator()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class SingleQuantityCartValidator : ICartValidator
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2C10304", Offset = "0x2C0C304", VA = "0x2C10304", Slot = "4")]
		public void Validate(ICart cart)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2C102FC", Offset = "0x2C0C2FC", VA = "0x2C102FC")]
		public SingleQuantityCartValidator()
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal class StoreCartValidator : ICartValidator
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string m_StoreName;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ICartValidator m_CartValidator;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2C0F0A8", Offset = "0x2C0B0A8", VA = "0x2C0F0A8")]
		public StoreCartValidator(string storeName, ICartValidator cartValidator)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2C10540", Offset = "0x2C0C540", VA = "0x2C10540", Slot = "4")]
		public void Validate(ICart cart)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class InvalidCartException : IapException
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2C106D4", Offset = "0x2C0C6D4", VA = "0x2C106D4")]
		public InvalidCartException()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2C10154", Offset = "0x2C0C154", VA = "0x2C10154")]
		public InvalidCartException(string message)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2C106D8", Offset = "0x2C0C6D8", VA = "0x2C106D8")]
		protected InvalidCartException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class InvalidCartItemException : IapException
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2C106DC", Offset = "0x2C0C6DC", VA = "0x2C106DC")]
		public InvalidCartItemException()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2C10158", Offset = "0x2C0C158", VA = "0x2C10158")]
		public InvalidCartItemException(string message)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2C106E0", Offset = "0x2C0C6E0", VA = "0x2C106E0")]
		protected InvalidCartItemException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public interface IOnEntitlementRevokedCallback
	{
		[Token(Token = "0x6000081")]
		void onEntitlementRevoked(string productId);
	}
	[Token(Token = "0x2000034")]
	public interface IStoreCheckEntitlementCallback
	{
		[Token(Token = "0x6000082")]
		void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, [Optional] string message);
	}
	[Token(Token = "0x2000035")]
	public interface IStorePurchaseCallback
	{
		[Token(Token = "0x6000083")]
		void OnPurchaseSucceeded(PendingOrder order);

		[Token(Token = "0x6000084")]
		void OnPurchaseFailed(FailedOrder failedOrder);

		[Token(Token = "0x6000085")]
		void OnPurchaseDeferred(DeferredOrder deferredOrder);
	}
	[Token(Token = "0x2000036")]
	public interface IStorePurchaseConfirmCallback
	{
		[Token(Token = "0x6000086")]
		void OnConfirmOrderSucceeded(string transactionId);

		[Token(Token = "0x6000087")]
		void OnConfirmOrderFailed(FailedOrder failedOrder);
	}
	[Token(Token = "0x2000037")]
	public interface IStorePurchaseFetchCallback
	{
		[Token(Token = "0x6000088")]
		void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders);

		[Token(Token = "0x6000089")]
		void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason);
	}
	[Token(Token = "0x2000038")]
	public interface ICartValidator
	{
		[Token(Token = "0x600008A")]
		void Validate(ICart cart);
	}
	[Token(Token = "0x2000039")]
	public interface ICart
	{
		[Token(Token = "0x600008B")]
		IReadOnlyList<CartItem> Items();
	}
	[Token(Token = "0x200003A")]
	public interface IPurchaseService
	{
		[Token(Token = "0x1700000C")]
		IAppleStoreExtendedPurchaseService? Apple
		{
			[Token(Token = "0x600008C")]
			get;
		}

		[Token(Token = "0x1700000D")]
		IGooglePlayStoreExtendedPurchaseService? Google
		{
			[Token(Token = "0x600008D")]
			get;
		}

		[Token(Token = "0x14000005")]
		event Action<PendingOrder>? OnPurchasePending;

		[Token(Token = "0x14000006")]
		event Action<Order>? OnPurchaseConfirmed;

		[Token(Token = "0x14000007")]
		event Action<FailedOrder>? OnPurchaseFailed;

		[Token(Token = "0x14000008")]
		event Action<DeferredOrder>? OnPurchaseDeferred;

		[Token(Token = "0x14000009")]
		event Action<Orders>? OnPurchasesFetched;

		[Token(Token = "0x1400000A")]
		event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed;

		[Token(Token = "0x600008E")]
		void PurchaseProduct(Product product);

		[Token(Token = "0x600008F")]
		void ConfirmPurchase(PendingOrder order);

		[Token(Token = "0x6000090")]
		void FetchPurchases();

		[Token(Token = "0x6000091")]
		void RestoreTransactions(Action<bool, string?>? callback);

		[Token(Token = "0x6000092")]
		ReadOnlyObservableCollection<Order> GetPurchases();
	}
	[Token(Token = "0x200003B")]
	internal interface IPurchaseServiceFactory
	{
		[Token(Token = "0x600009F")]
		IPurchaseService Create(IStoreWrapper store);
	}
	[Token(Token = "0x200003C")]
	internal interface IPurchaseServiceFactoryManager
	{
		[Token(Token = "0x60000A0")]
		IPurchaseServiceFactory GetServiceFactory();
	}
	[Token(Token = "0x200003D")]
	internal interface IPurchaseServiceFactoryManagerInjectionPoint
	{
		[Token(Token = "0x60000A1")]
		void SetServiceFactory(IPurchaseServiceFactory serviceFactory);
	}
	[Token(Token = "0x200003E")]
	internal interface ICheckEntitlementUseCase
	{
	}
	[Token(Token = "0x200003F")]
	internal interface IConfirmOrderUseCase
	{
		[Token(Token = "0x60000A2")]
		void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> action);
	}
	[Token(Token = "0x2000040")]
	internal interface IFetchPurchasesUseCase
	{
		[Token(Token = "0x60000A3")]
		void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction);
	}
	[Token(Token = "0x2000041")]
	internal interface IOnEntitlementRevokedUseCase
	{
		[Token(Token = "0x1400000B")]
		event Action<string> OnEntitlementRevoked;
	}
	[Token(Token = "0x2000042")]
	internal interface IPurchaseUseCase
	{
		[Token(Token = "0x1400000C")]
		event Action<PendingOrder> OnPurchaseSuccess;

		[Token(Token = "0x1400000D")]
		event Action<FailedOrder> OnPurchaseFail;

		[Token(Token = "0x1400000E")]
		event Action<DeferredOrder> OnPurchaseDefer;

		[Token(Token = "0x60000A6")]
		void Purchase(ICart cart);
	}
	[Token(Token = "0x2000043")]
	internal class AppleOrderInfo : OrderInfo, IAppleOrderInfo
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IAppleAppReceiptViewer m_ReceiptViewer;

		[Token(Token = "0x1700000E")]
		public string? AppReceipt
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2C106E4", Offset = "0x2C0C6E4", VA = "0x2C106E4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string? OriginalTransactionID
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2C10784", Offset = "0x2C0C784", VA = "0x2C10784", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2C1078C", Offset = "0x2C0C78C", VA = "0x2C1078C", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public OwnershipType OwnershipType
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2C10794", Offset = "0x2C0C794", VA = "0x2C10794", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public string StoreName
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2C1079C", Offset = "0x2C0C79C", VA = "0x2C1079C", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2C107A4", Offset = "0x2C0C7A4", VA = "0x2C107A4", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Guid? AppAccountToken
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2C107AC", Offset = "0x2C0C7AC", VA = "0x2C107AC", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public string? jwsRepresentation
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2C107C0", Offset = "0x2C0C7C0", VA = "0x2C107C0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2C107C8", Offset = "0x2C0C7C8", VA = "0x2C107C8")]
		public AppleOrderInfo(string transactionID, string storeName, IAppleAppReceiptViewer appReceiptViewer, string? originalTransactionID, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class Cart : ICart
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly HashSet<CartItem> m_CartItems;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IReadOnlyList<CartItem>? m_CachedItemsList;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2C0F8D0", Offset = "0x2C0B8D0", VA = "0x2C0F8D0")]
		public Cart(CartItem cartItem)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2C1097C", Offset = "0x2C0C97C", VA = "0x2C1097C", Slot = "4")]
		public IReadOnlyList<CartItem> Items()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2C109D4", Offset = "0x2C0C9D4", VA = "0x2C109D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2C10A90", Offset = "0x2C0CA90", VA = "0x2C10A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000045")]
	public class CartItem
	{
		[Token(Token = "0x17000014")]
		public Product Product
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2C10BD0", Offset = "0x2C0CBD0", VA = "0x2C10BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public int Quantity
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x2C10BD8", Offset = "0x2C0CBD8", VA = "0x2C10BD8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2C0F8C8", Offset = "0x2C0B8C8", VA = "0x2C0F8C8")]
		public CartItem(Product product)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2C10BE0", Offset = "0x2C0CBE0", VA = "0x2C10BE0")]
		internal CartItem(Product product, int quantity)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2C10C60", Offset = "0x2C0CC60", VA = "0x2C10C60")]
		public static implicit operator CartItem(Product product)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2C10CBC", Offset = "0x2C0CCBC", VA = "0x2C10CBC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2C10CD8", Offset = "0x2C0CCD8", VA = "0x2C10CD8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000046")]
	internal class CheckEntitlementRequest
	{
		[Token(Token = "0x17000016")]
		internal Product ProductToCheck
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2C10D74", Offset = "0x2C0CD74", VA = "0x2C10D74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		internal Action<Entitlement> OnChecked
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2C10D7C", Offset = "0x2C0CD7C", VA = "0x2C10D7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000047")]
	public class ConfirmedOrder : Order
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2C10D84", Offset = "0x2C0CD84", VA = "0x2C10D84")]
		public ConfirmedOrder(ICart cart, IOrderInfo info)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2C10E80", Offset = "0x2C0CE80", VA = "0x2C10E80")]
		private List<IPurchasedProductInfo> FillPurchasedProductInfo()
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	internal class ConfirmOrderRequest
	{
		[Token(Token = "0x17000018")]
		internal PendingOrder OrderToConfirm
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2C111BC", Offset = "0x2C0D1BC", VA = "0x2C111BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		internal Action<PendingOrder, Order> Action
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2C111C4", Offset = "0x2C0D1C4", VA = "0x2C111C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2C111CC", Offset = "0x2C0D1CC", VA = "0x2C111CC")]
		internal ConfirmOrderRequest(PendingOrder order, Action<PendingOrder, Order> purchaseSuccessAction)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class DeferredOrder : Order
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2C111F8", Offset = "0x2C0D1F8", VA = "0x2C111F8")]
		public DeferredOrder(ICart cart, IOrderInfo info)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class DeferredPaymentUntilRenewalDateOrder
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2C0F880", Offset = "0x2C0B880", VA = "0x2C0F880")]
		public DeferredPaymentUntilRenewalDateOrder(Order currentOrder, Product subscriptionOrdered)
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class Entitlement
	{
		[Token(Token = "0x1700001A")]
		internal Order? Order
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2C11224", Offset = "0x2C0D224", VA = "0x2C11224")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2C1122C", Offset = "0x2C0D22C", VA = "0x2C1122C")]
		internal Entitlement(Product? product, Order? order, EntitlementStatus status, [Optional] string? message)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public enum EntitlementStatus
	{
		[Token(Token = "0x400004F")]
		Unknown,
		[Token(Token = "0x4000050")]
		NotEntitled,
		[Token(Token = "0x4000051")]
		EntitledUntilConsumed,
		[Token(Token = "0x4000052")]
		EntitledButNotFinished,
		[Token(Token = "0x4000053")]
		FullyEntitled
	}
	[Token(Token = "0x200004D")]
	public class FailedOrder : Order
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PurchaseFailureReason m_FailureReason;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_Details;

		[Token(Token = "0x1700001B")]
		public PurchaseFailureReason FailureReason
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2C11270", Offset = "0x2C0D270", VA = "0x2C11270")]
			get
			{
				return default(PurchaseFailureReason);
			}
		}

		[Token(Token = "0x1700001C")]
		public string Details
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2C11278", Offset = "0x2C0D278", VA = "0x2C11278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2C0F97C", Offset = "0x2C0B97C", VA = "0x2C0F97C")]
		public FailedOrder(ICart cart, PurchaseFailureReason reason, string details)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2C11280", Offset = "0x2C0D280", VA = "0x2C11280")]
		public FailedOrder(Order order, PurchaseFailureReason reason, string details)
		{
		}
	}
	[Token(Token = "0x200004E")]
	internal class GoogleOrderInfo : OrderInfo
	{
		[Token(Token = "0x1700001D")]
		public string? ObfuscatedAccountId
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2C112D0", Offset = "0x2C0D2D0", VA = "0x2C112D0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public string? ObfuscatedProfileId
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2C112D8", Offset = "0x2C0D2D8", VA = "0x2C112D8", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2C112E0", Offset = "0x2C0D2E0", VA = "0x2C112E0")]
		public GoogleOrderInfo(string receipt, string? transactionID, string storeName, string? obfuscatedAccountId, string? obfuscatedProfileId)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public interface IAppleOrderInfo
	{
		[Token(Token = "0x1700001F")]
		string? AppReceipt
		{
			[Token(Token = "0x60000D3")]
			get;
		}

		[Token(Token = "0x17000020")]
		string? OriginalTransactionID
		{
			[Token(Token = "0x60000D4")]
			get;
		}

		[Token(Token = "0x17000021")]
		string StoreName
		{
			[Token(Token = "0x60000D5")]
			get;
		}
	}
	[Token(Token = "0x2000050")]
	public interface IOrderInfo
	{
		[Token(Token = "0x17000022")]
		IAppleOrderInfo? Apple
		{
			[Token(Token = "0x60000D6")]
			get;
		}

		[Token(Token = "0x17000023")]
		List<IPurchasedProductInfo> PurchasedProductInfo
		{
			[Token(Token = "0x60000D7")]
			set;
		}

		[Token(Token = "0x17000024")]
		string Receipt
		{
			[Token(Token = "0x60000D8")]
			get;
		}

		[Token(Token = "0x17000025")]
		string TransactionID
		{
			[Token(Token = "0x60000D9")]
			get;
		}
	}
	[Token(Token = "0x2000051")]
	public interface IPurchasedProductInfo
	{
	}
	[Token(Token = "0x2000052")]
	public abstract class Order
	{
		[Token(Token = "0x17000026")]
		public ICart CartOrdered
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2C11308", Offset = "0x2C0D308", VA = "0x2C11308")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2C11310", Offset = "0x2C0D310", VA = "0x2C11310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public IOrderInfo Info
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2C11318", Offset = "0x2C0D318", VA = "0x2C11318")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2C10E54", Offset = "0x2C0CE54", VA = "0x2C10E54")]
		protected Order(ICart cart, IOrderInfo info)
		{
		}
	}
	[Token(Token = "0x2000053")]
	internal class OrderInfo : IOrderInfo
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_Receipt;

		[Token(Token = "0x17000028")]
		public IAppleOrderInfo? Apple
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2C11320", Offset = "0x2C0D320", VA = "0x2C11320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public List<IPurchasedProductInfo> PurchasedProductInfo
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2C11368", Offset = "0x2C0D368", VA = "0x2C11368", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public string TransactionID
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x2C11370", Offset = "0x2C0D370", VA = "0x2C11370", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public string Receipt
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2C11378", Offset = "0x2C0D378", VA = "0x2C11378", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2C114EC", Offset = "0x2C0D4EC", VA = "0x2C114EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2C1137C", Offset = "0x2C0D37C", VA = "0x2C1137C")]
		private string GetReceipt()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2C11514", Offset = "0x2C0D514", VA = "0x2C11514")]
		private void SetReceipt(string receipt)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2C10890", Offset = "0x2C0C890", VA = "0x2C10890")]
		public OrderInfo(string receipt, string? transactionID, string storeName)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2C1153C", Offset = "0x2C0D53C", VA = "0x2C1153C")]
		private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public class Orders
	{
		[Token(Token = "0x1700002C")]
		public IReadOnlyList<ConfirmedOrder> ConfirmedOrders
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2C115F8", Offset = "0x2C0D5F8", VA = "0x2C115F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IReadOnlyList<PendingOrder> PendingOrders
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2C11600", Offset = "0x2C0D600", VA = "0x2C11600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IReadOnlyList<DeferredOrder> DeferredOrders
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2C11608", Offset = "0x2C0D608", VA = "0x2C11608")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2C115BC", Offset = "0x2C0D5BC", VA = "0x2C115BC")]
		public Orders(IReadOnlyList<ConfirmedOrder> confirmedOrders, IReadOnlyList<PendingOrder> pendingOrders, IReadOnlyList<DeferredOrder> deferredOrders)
		{
		}
	}
	[Token(Token = "0x2000055")]
	public enum OwnershipType
	{
		[Token(Token = "0x4000061")]
		Undefined = -1,
		[Token(Token = "0x4000062")]
		Purchased,
		[Token(Token = "0x4000063")]
		FamilyShared
	}
	[Token(Token = "0x2000056")]
	public class PendingOrder : Order
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2C11610", Offset = "0x2C0D610", VA = "0x2C11610")]
		public PendingOrder(ICart cart, IOrderInfo info)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2C116E0", Offset = "0x2C0D6E0", VA = "0x2C116E0")]
		private List<IPurchasedProductInfo> FillPurchasedProductInfo()
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	internal class PurchasedProductInfo : IPurchasedProductInfo
	{
		[Token(Token = "0x1700002F")]
		private SubscriptionInfo? subscriptionInfo
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x2C11CEC", Offset = "0x2C0DCEC", VA = "0x2C11CEC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2C1111C", Offset = "0x2C0D11C", VA = "0x2C1111C")]
		public PurchasedProductInfo(string productId, string receipt, ProductType productType)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2C119B8", Offset = "0x2C0D9B8", VA = "0x2C119B8")]
		private void TryInitSubscriptionInfo(SubscriptionInfoHelper subscriptionInfoHelper)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class PurchasesFetchFailureDescription
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PurchasesFetchFailureReason failureReason;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2C11CF4", Offset = "0x2C0DCF4", VA = "0x2C11CF4")]
		public PurchasesFetchFailureDescription(PurchasesFetchFailureReason reason, string message)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public enum PurchasesFetchFailureReason
	{
		[Token(Token = "0x4000069")]
		PurchasingUnavailable,
		[Token(Token = "0x400006A")]
		StoreNotConnected,
		[Token(Token = "0x400006B")]
		Unknown
	}
	[Token(Token = "0x200005A")]
	public class SubscriptionInfo
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Result m_IsSubscribed;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly Result m_IsExpired;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Result m_IsCancelled;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly Result m_IsFreeTrial;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Result m_IsAutoRenewing;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly Result m_IsIntroductoryPricePeriod;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string m_ProductId;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly DateTime m_PurchaseDate;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly DateTime m_SubscriptionExpireDate;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly DateTime m_SubscriptionCancelDate;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly TimeSpan m_RemainedTime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string m_IntroductoryPrice;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly TimeSpan m_IntroductoryPricePeriod;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly long m_IntroductoryPriceCycles;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly TimeSpan m_FreeTrialPeriod;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly TimeSpan m_SubscriptionPeriod;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string m_FreeTrialPeriodString;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly string m_SKUDetails;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2C11D24", Offset = "0x2C0DD24", VA = "0x2C11D24")]
		public SubscriptionInfo(AppleInAppPurchaseReceipt r, string introJson)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2C125B8", Offset = "0x2C0E5B8", VA = "0x2C125B8")]
		public SubscriptionInfo(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2C134EC", Offset = "0x2C0F4EC", VA = "0x2C134EC")]
		private static DateTime NextBillingDate(DateTime billingBeginDate, TimeSpanUnits units)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2C131E0", Offset = "0x2C0F1E0", VA = "0x2C131E0")]
		private static TimeSpan AccumulateIntroductoryDuration(TimeSpanUnits units, long cycles)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2C12FE0", Offset = "0x2C0EFE0", VA = "0x2C12FE0")]
		private static TimeSpan ComputePeriodTimeSpan(TimeSpanUnits units)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2C13290", Offset = "0x2C0F290", VA = "0x2C13290")]
		private static double ComputeExtraTime(string metadata, double newSKUPeriodInSeconds)
		{
			return default(double);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2C13098", Offset = "0x2C0F098", VA = "0x2C13098")]
		private static TimeSpan ParseTimeSpan(string periodString)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2C12DB4", Offset = "0x2C0EDB4", VA = "0x2C12DB4")]
		private static TimeSpanUnits ParsePeriodTimeSpanUnits(string timeSpan)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public enum Result
	{
		[Token(Token = "0x400007F")]
		True,
		[Token(Token = "0x4000080")]
		False,
		[Token(Token = "0x4000081")]
		Unsupported
	}
	[Token(Token = "0x200005C")]
	public enum SubscriptionPeriodUnit
	{
		[Token(Token = "0x4000083")]
		Day,
		[Token(Token = "0x4000084")]
		Week,
		[Token(Token = "0x4000085")]
		Month,
		[Token(Token = "0x4000086")]
		Year,
		[Token(Token = "0x4000087")]
		NotAvailable
	}
	[Token(Token = "0x200005D")]
	internal enum AppleStoreProductType
	{
		[Token(Token = "0x4000089")]
		NonConsumable,
		[Token(Token = "0x400008A")]
		Consumable,
		[Token(Token = "0x400008B")]
		NonRenewingSubscription,
		[Token(Token = "0x400008C")]
		AutoRenewingSubscription
	}
	[Token(Token = "0x200005E")]
	public class TimeSpanUnits
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double days;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int months;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int years;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2C13630", Offset = "0x2C0F630", VA = "0x2C13630")]
		public TimeSpanUnits(double d, int m, int y)
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class SubscriptionInfoHelper
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string m_Receipt;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string m_ProductId;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string m_IntroJson;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2C1197C", Offset = "0x2C0D97C", VA = "0x2C1197C")]
		public SubscriptionInfoHelper(string receipt, string id, string introJson)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2C11A50", Offset = "0x2C0DA50", VA = "0x2C11A50")]
		public SubscriptionInfo GetSubscriptionInfo()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2C13CE8", Offset = "0x2C0FCE8", VA = "0x2C13CE8")]
		private SubscriptionInfo GetAppleAppStoreSubInfo(string payload, string productId)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2C140D4", Offset = "0x2C100D4", VA = "0x2C140D4")]
		private static AppleInAppPurchaseReceipt FindMostRecentReceipt(List<AppleInAppPurchaseReceipt> receipts)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2C1366C", Offset = "0x2C0F66C", VA = "0x2C1366C")]
		private static SubscriptionInfo GetGooglePlayStoreSubInfo(string payload)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class ReceiptParserException : IapException
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2C14334", Offset = "0x2C10334", VA = "0x2C14334")]
		public ReceiptParserException()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2C14338", Offset = "0x2C10338", VA = "0x2C14338")]
		public ReceiptParserException(string message)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2C1433C", Offset = "0x2C1033C", VA = "0x2C1433C")]
		protected ReceiptParserException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class InvalidProductTypeException : ReceiptParserException
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2C12500", Offset = "0x2C0E500", VA = "0x2C12500")]
		public InvalidProductTypeException()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2C14340", Offset = "0x2C10340", VA = "0x2C14340")]
		protected InvalidProductTypeException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class NullProductIdException : ReceiptParserException
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2C13CE4", Offset = "0x2C0FCE4", VA = "0x2C13CE4")]
		public NullProductIdException()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2C14344", Offset = "0x2C10344", VA = "0x2C14344")]
		protected NullProductIdException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class NullReceiptException : ReceiptParserException
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2C140D0", Offset = "0x2C100D0", VA = "0x2C140D0")]
		public NullReceiptException()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2C14348", Offset = "0x2C10348", VA = "0x2C14348")]
		protected NullReceiptException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2C140CC", Offset = "0x2C100CC", VA = "0x2C140CC")]
		public StoreSubscriptionInfoNotSupportedException(string message)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class PurchaseService : IPurchaseService
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IPurchaseUseCase m_PurchaseUseCase;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IConfirmOrderUseCase m_ConfirmOrderUseCase;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ICheckEntitlementUseCase m_CheckEntitlementUseCase;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly ObservableCollection<Order> m_Purchases;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ReadOnlyObservableCollection<Order> m_PurchasesReadOnly;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly IStoreWrapper m_StoreWrapper;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IAnalyticsClient m_AnalyticsClient;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_ProcessFetchedPendingOrders;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly HashSet<string> m_PurchasesProcessedInSession;

		[Token(Token = "0x17000030")]
		public IAppleStoreExtendedPurchaseService? Apple
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2C14B8C", Offset = "0x2C10B8C", VA = "0x2C14B8C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IGooglePlayStoreExtendedPurchaseService? Google
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2C14BD4", Offset = "0x2C10BD4", VA = "0x2C14BD4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<PendingOrder>? OnPurchasePending
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2C1434C", Offset = "0x2C1034C", VA = "0x2C1434C", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2C143FC", Offset = "0x2C103FC", VA = "0x2C143FC", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<Order>? OnPurchaseConfirmed
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2C144AC", Offset = "0x2C104AC", VA = "0x2C144AC", Slot = "13")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2C1455C", Offset = "0x2C1055C", VA = "0x2C1455C", Slot = "14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<FailedOrder>? OnPurchaseFailed
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2C1460C", Offset = "0x2C1060C", VA = "0x2C1460C", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2C146BC", Offset = "0x2C106BC", VA = "0x2C146BC", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<DeferredOrder>? OnPurchaseDeferred
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2C1476C", Offset = "0x2C1076C", VA = "0x2C1476C", Slot = "17")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2C1481C", Offset = "0x2C1081C", VA = "0x2C1481C", Slot = "18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<Orders>? OnPurchasesFetched
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2C148CC", Offset = "0x2C108CC", VA = "0x2C148CC", Slot = "19")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2C1497C", Offset = "0x2C1097C", VA = "0x2C1497C", Slot = "20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2C14A2C", Offset = "0x2C10A2C", VA = "0x2C14A2C", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2C14ADC", Offset = "0x2C10ADC", VA = "0x2C14ADC", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2C0E928", Offset = "0x2C0A928", VA = "0x2C0E928")]
		internal PurchaseService(IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2C14C1C", Offset = "0x2C10C1C", VA = "0x2C14C1C", Slot = "6")]
		public void PurchaseProduct(Product product)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2C14DC4", Offset = "0x2C10DC4", VA = "0x2C14DC4", Slot = "23")]
		public void Purchase(ICart cart)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2C1511C", Offset = "0x2C1111C", VA = "0x2C1511C")]
		internal void PurchaseSucceeded(PendingOrder order)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2C15500", Offset = "0x2C11500", VA = "0x2C15500")]
		private void RemovePendingOrders(PendingOrder order)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2C1526C", Offset = "0x2C1126C", VA = "0x2C1526C")]
		private void RemoveDeferredOrders(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2C159CC", Offset = "0x2C119CC", VA = "0x2C159CC")]
		internal void PurchaseFailed(FailedOrder order)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2C15AA0", Offset = "0x2C11AA0", VA = "0x2C15AA0")]
		private void PurchaseDeferred(DeferredOrder order)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2C15B20", Offset = "0x2C11B20", VA = "0x2C15B20", Slot = "7")]
		public void ConfirmPurchase(PendingOrder order)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2C15D1C", Offset = "0x2C11D1C", VA = "0x2C15D1C")]
		private FailedOrder ConfirmPurchaseValidations(PendingOrder order)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2C15F38", Offset = "0x2C11F38", VA = "0x2C15F38")]
		private void OnConfirmSucceeded(PendingOrder pendingOrder, ConfirmedOrder confirmedOrder)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2C15F1C", Offset = "0x2C11F1C", VA = "0x2C15F1C")]
		private void OnConfirmFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C1604C", Offset = "0x2C1204C", VA = "0x2C1604C", Slot = "8")]
		public void FetchPurchases()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2C162F8", Offset = "0x2C122F8", VA = "0x2C162F8")]
		private void OnFetchSuccess(Orders fetchedPurchases)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2C16C28", Offset = "0x2C12C28", VA = "0x2C16C28")]
		private bool WasPurchaseAlreadyProcessed(string transactionId)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2C158C8", Offset = "0x2C118C8", VA = "0x2C158C8")]
		private void ProcessPendingOrder(PendingOrder fetchedPurchase)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2C162DC", Offset = "0x2C122DC", VA = "0x2C162DC")]
		private void OnFetchFailure(PurchasesFetchFailureDescription fetchFailed)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2C16C80", Offset = "0x2C12C80", VA = "0x2C16C80", Slot = "9")]
		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2C16E38", Offset = "0x2C12E38", VA = "0x2C16E38", Slot = "24")]
		protected virtual void RestoreTransactionsInternal(Action<bool, string?>? callback)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2C16F08", Offset = "0x2C12F08", VA = "0x2C16F08", Slot = "10")]
		public ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2C1506C", Offset = "0x2C1106C", VA = "0x2C1506C")]
		internal bool IsStoreConnected()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006A")]
	internal class PurchaseServiceContainer
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PurchaseServiceContainer? s_Instance;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string?, IPurchaseService> m_InstantiatedServices;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2C17210", Offset = "0x2C13210", VA = "0x2C17210")]
		internal static PurchaseServiceContainer Instance()
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2C172F4", Offset = "0x2C132F4", VA = "0x2C172F4")]
		internal IPurchaseService FindService(string storeName)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2C17388", Offset = "0x2C13388", VA = "0x2C17388")]
		internal void SetService(string storeName, IPurchaseService service)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2C17278", Offset = "0x2C13278", VA = "0x2C17278")]
		public PurchaseServiceContainer()
		{
		}
	}
	[Token(Token = "0x200006B")]
	internal class PurchaseServiceDependencyInjector
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IStoreWrapper m_storeWrapper;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IPurchaseServiceFactoryManager m_ServiceFactoryManager;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2C17484", Offset = "0x2C13484", VA = "0x2C17484")]
		internal PurchaseServiceDependencyInjector(IStoreWrapper storeWrapper)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2C17528", Offset = "0x2C13528", VA = "0x2C17528")]
		internal IPurchaseService CreatePurchaseService()
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	internal class PurchaseServiceFactoryManager : IPurchaseServiceFactoryManager, IPurchaseServiceFactoryManagerInjectionPoint
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PurchaseServiceFactoryManager s_Instance;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPurchaseServiceFactory m_Factory;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2C174B0", Offset = "0x2C134B0", VA = "0x2C174B0")]
		internal static PurchaseServiceFactoryManager Instance()
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2C1764C", Offset = "0x2C1364C", VA = "0x2C1764C", Slot = "5")]
		public void SetServiceFactory(IPurchaseServiceFactory serviceFactory)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C17654", Offset = "0x2C13654", VA = "0x2C17654", Slot = "4")]
		public IPurchaseServiceFactory GetServiceFactory()
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C17644", Offset = "0x2C13644", VA = "0x2C17644")]
		public PurchaseServiceFactoryManager()
		{
		}
	}
	[Token(Token = "0x200006D")]
	internal static class PurchaseServiceProvider
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C1765C", Offset = "0x2C1365C", VA = "0x2C1765C")]
		public static IPurchaseService GetDefaultPurchaseService()
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C1769C", Offset = "0x2C1369C", VA = "0x2C1769C")]
		public static IPurchaseService GetPurchaseService(string storeName)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2C17678", Offset = "0x2C13678", VA = "0x2C17678")]
		private static IPurchaseService GetPurchaseServiceInternal(IStoreWrapper storeWrapper)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2C176C0", Offset = "0x2C136C0", VA = "0x2C176C0")]
		private static IPurchaseService LocateExistingService(IStoreWrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2C17778", Offset = "0x2C13778", VA = "0x2C17778")]
		private static IPurchaseService CreateNewService(IStoreWrapper wrapper)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	internal static class PurchaseUseCaseFactory
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2C17928", Offset = "0x2C13928", VA = "0x2C17928")]
		internal static IPurchaseUseCase Create(IStore store, IProductCache productCache)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	internal class CheckEntitlementUseCase : ICheckEntitlementUseCase, IStoreCheckEntitlementCallback
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStore m_Store;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<CheckEntitlementRequest> m_OngoingRequests;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2C179E4", Offset = "0x2C139E4", VA = "0x2C179E4")]
		[Preserve]
		internal CheckEntitlementUseCase(IStore storeResponsible)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2C17AE4", Offset = "0x2C13AE4", VA = "0x2C17AE4", Slot = "4")]
		public void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, [Optional] string message)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2C17CF8", Offset = "0x2C13CF8", VA = "0x2C17CF8")]
		private CheckEntitlementRequest GetMatchingRequest(ProductDefinition productDefinition)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	internal class ConfirmOrderUseCase : IConfirmOrderUseCase, IStorePurchaseConfirmCallback
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStore m_Store;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<ConfirmOrderRequest> m_ConfirmationRequests;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2C17E10", Offset = "0x2C13E10", VA = "0x2C17E10")]
		[Preserve]
		internal ConfirmOrderUseCase(IStore storeResponsible)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2C17F10", Offset = "0x2C13F10", VA = "0x2C17F10", Slot = "4")]
		public void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> confirmationAction)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2C17FD8", Offset = "0x2C13FD8", VA = "0x2C17FD8")]
		private bool FindExistingConfirmationRequest(PendingOrder orderToCheckFor)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2C180B0", Offset = "0x2C140B0", VA = "0x2C180B0")]
		private void AddAndSendFinishTransactionRequest(PendingOrder order, Action<PendingOrder, Order> confirmationAction)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2C1820C", Offset = "0x2C1420C", VA = "0x2C1820C", Slot = "5")]
		public void OnConfirmOrderSucceeded(string transactionId)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2C18464", Offset = "0x2C14464", VA = "0x2C18464", Slot = "6")]
		public void OnConfirmOrderFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2C18390", Offset = "0x2C14390", VA = "0x2C18390")]
		private ConfirmOrderRequest GetMatchingRequest(string transactionIdentifier)
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	internal class FetchPurchasesUseCase : IFetchPurchasesUseCase, IStorePurchaseFetchCallback
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStore m_Store;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		private Action<Orders> FetchSuccessAction;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private Action<PurchasesFetchFailureDescription> FetchFailureAction;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2C18970", Offset = "0x2C14970", VA = "0x2C18970")]
		[Preserve]
		internal FetchPurchasesUseCase(IStore storeResponsible)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2C18A28", Offset = "0x2C14A28", VA = "0x2C18A28", Slot = "4")]
		public void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2C18AE0", Offset = "0x2C14AE0", VA = "0x2C18AE0", Slot = "5")]
		public void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2C18C98", Offset = "0x2C14C98", VA = "0x2C18C98", Slot = "6")]
		public void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason)
		{
		}
	}
	[Token(Token = "0x2000075")]
	internal class OnEntitlementRevokedUseCase : IOnEntitlementRevokedUseCase, IOnEntitlementRevokedCallback
	{
		[Token(Token = "0x14000015")]
		public event Action<string> OnEntitlementRevoked
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2C18CB4", Offset = "0x2C14CB4", VA = "0x2C18CB4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2C18D64", Offset = "0x2C14D64", VA = "0x2C18D64", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2C18E14", Offset = "0x2C14E14", VA = "0x2C18E14")]
		[Preserve]
		internal OnEntitlementRevokedUseCase(IStore storeResponsible)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2C18EC8", Offset = "0x2C14EC8", VA = "0x2C18EC8", Slot = "6")]
		public void onEntitlementRevoked(string productId)
		{
		}
	}
	[Token(Token = "0x2000076")]
	internal class PurchaseUseCase : IPurchaseUseCase, IStorePurchaseCallback
	{
		[Token(Token = "0x17000032")]
		protected IStore m_Store
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2C18EE4", Offset = "0x2C14EE4", VA = "0x2C18EE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000016")]
		public event Action<PendingOrder> OnPurchaseSuccess
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2C18F98", Offset = "0x2C14F98", VA = "0x2C18F98", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2C19048", Offset = "0x2C15048", VA = "0x2C19048", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<FailedOrder> OnPurchaseFail
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2C0F2F4", Offset = "0x2C0B2F4", VA = "0x2C0F2F4", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2C190F8", Offset = "0x2C150F8", VA = "0x2C190F8", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action<DeferredOrder> OnPurchaseDefer
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2C191A8", Offset = "0x2C151A8", VA = "0x2C191A8", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2C19258", Offset = "0x2C15258", VA = "0x2C19258", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2C0F23C", Offset = "0x2C0B23C", VA = "0x2C0F23C")]
		internal PurchaseUseCase(IStore storeResponsible)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2C18EEC", Offset = "0x2C14EEC", VA = "0x2C18EEC", Slot = "4")]
		public void Purchase(ICart cart)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2C19308", Offset = "0x2C15308", VA = "0x2C19308", Slot = "11")]
		public void OnPurchaseSucceeded(PendingOrder order)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2C0FA2C", Offset = "0x2C0BA2C", VA = "0x2C0FA2C", Slot = "12")]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2C19324", Offset = "0x2C15324", VA = "0x2C19324", Slot = "13")]
		public void OnPurchaseDeferred(DeferredOrder deferredOrder)
		{
		}
	}
	[Token(Token = "0x2000077")]
	internal class AsyncDelayer : IAsyncDelayer
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2C19340", Offset = "0x2C15340", VA = "0x2C19340", Slot = "4")]
		public Task Delay(int delayMilliseconds)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2C19398", Offset = "0x2C15398", VA = "0x2C19398")]
		public AsyncDelayer()
		{
		}
	}
	[Token(Token = "0x2000078")]
	internal interface IAsyncDelayer
	{
		[Token(Token = "0x600016D")]
		Task Delay(int delayMilliseconds);
	}
	[Token(Token = "0x2000079")]
	internal interface IRetryableRequestFailureDescription
	{
		[Token(Token = "0x17000033")]
		bool IsRetryable
		{
			[Token(Token = "0x600016E")]
			get;
		}
	}
	[Token(Token = "0x200007A")]
	public interface IRetryPolicy
	{
		[Token(Token = "0x600016F")]
		Task<bool> ShouldRetry(IRetryPolicyInformation info);
	}
	[Token(Token = "0x200007B")]
	public interface IRetryPolicyInformation
	{
		[Token(Token = "0x17000034")]
		int NumberOfAttempts
		{
			[Token(Token = "0x6000170")]
			get;
		}
	}
	[Token(Token = "0x200007C")]
	internal interface IRetryRequest
	{
		[Token(Token = "0x6000171")]
		Task<bool> Invoke();

		[Token(Token = "0x6000172")]
		Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription);
	}
	[Token(Token = "0x200007D")]
	internal interface IRetryService
	{
		[Token(Token = "0x6000173")]
		IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy);
	}
	[Token(Token = "0x200007E")]
	public class ExponentialBackOffRetryPolicy : IRetryPolicy
	{
		[StructLayout(3)]
		[Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <ShouldRetry>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExponentialBackOffRetryPolicy <>4__this;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IRetryPolicyInformation info;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2C19664", Offset = "0x2C15664", VA = "0x2C19664", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2C199A4", Offset = "0x2C159A4", VA = "0x2C199A4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int m_BaseRetryDelay;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly int m_MaxRetryDelay;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float m_ExponentialFactor;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly int m_MaxNumberOfRetriesBeforeCeiling;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IAsyncDelayer m_Delayer;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2C0CD58", Offset = "0x2C08D58", VA = "0x2C0CD58")]
		public ExponentialBackOffRetryPolicy(int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2f)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2C193A0", Offset = "0x2C153A0", VA = "0x2C193A0")]
		private static void ValidateArguments(int baseRetryDelay, int maxRetryDelay, float exponentialFactor)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2C1944C", Offset = "0x2C1544C", VA = "0x2C1944C")]
		private int CalculateMaxNumberOfRetriesBeforeCeiling(int baseRetryDelay, int maxRetryDelay, float exponentialFactor)
		{
			return default(int);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2C194E4", Offset = "0x2C154E4", VA = "0x2C194E4", Slot = "5")]
		[AsyncStateMachine(typeof(<ShouldRetry>d__9))]
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2C195DC", Offset = "0x2C155DC", VA = "0x2C195DC")]
		private int AdjustDelay(int numberOfRetries)
		{
			return default(int);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2C1963C", Offset = "0x2C1563C", VA = "0x2C1963C")]
		private bool HasHitMaxRetryDelay(int numberOfRetries)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000080")]
	public class MaximumNumberOfAttemptsRetryPolicy : IRetryPolicy
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int m_MaximumNumberOfAttempts;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2C19A20", Offset = "0x2C15A20", VA = "0x2C19A20")]
		public MaximumNumberOfAttemptsRetryPolicy(int maximumNumberOfAttempts)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2C19A48", Offset = "0x2C15A48", VA = "0x2C19A48", Slot = "5")]
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public class NoRetriesPolicy : IRetryPolicy
	{
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2C19B44", Offset = "0x2C15B44", VA = "0x2C19B44", Slot = "5")]
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2C19BAC", Offset = "0x2C15BAC", VA = "0x2C19BAC")]
		public NoRetriesPolicy()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public struct RetryPolicyInformation : IRetryPolicyInformation
	{
		[Token(Token = "0x17000035")]
		public readonly int NumberOfAttempts
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2C19BB4", Offset = "0x2C15BB4", VA = "0x2C19BB4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2C19BBC", Offset = "0x2C15BBC", VA = "0x2C19BBC")]
		internal RetryPolicyInformation(int numberOfAttempts, float timeSinceFirstAttempt)
		{
		}
	}
	[Token(Token = "0x2000083")]
	internal class RetryRequest : IRetryRequest
	{
		[StructLayout(3)]
		[Token(Token = "0x2000086")]
		[CompilerGenerated]
		private struct <InvokeFromMainThread>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RetryRequest <>4__this;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2C1A3D0", Offset = "0x2C163D0", VA = "0x2C1A3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2C1A618", Offset = "0x2C16618", VA = "0x2C1A618", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000087")]
		[CompilerGenerated]
		private struct <Retry>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IRetryableRequestFailureDescription requestFailureDescription;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RetryRequest <>4__this;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x2C1A694", Offset = "0x2C16694", VA = "0x2C1A694", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2C1A9A0", Offset = "0x2C169A0", VA = "0x2C1A9A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000088")]
		[CompilerGenerated]
		private struct <RetryFromMainThread>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RetryRequest <>4__this;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2C1AA1C", Offset = "0x2C16A1C", VA = "0x2C1AA1C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2C1AD54", Offset = "0x2C16D54", VA = "0x2C1AD54", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_StartTime;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_NumberOfAttempts;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Action m_Request;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IRetryPolicy m_RetryPolicy;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2C19BC8", Offset = "0x2C15BC8", VA = "0x2C19BC8")]
		public RetryRequest(Action request, IRetryPolicy retryPolicy, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2C19C04", Offset = "0x2C15C04", VA = "0x2C19C04", Slot = "4")]
		public Task<bool> Invoke()
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2C19C84", Offset = "0x2C15C84", VA = "0x2C19C84")]
		public Task<bool> RunTaskOnMainThread(Func<Task<bool>> function)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2C19E14", Offset = "0x2C15E14", VA = "0x2C19E14")]
		[AsyncStateMachine(typeof(<InvokeFromMainThread>d__8))]
		private Task<bool> InvokeFromMainThread()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2C19F00", Offset = "0x2C15F00", VA = "0x2C19F00")]
		private void FirstTry()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2C19F40", Offset = "0x2C15F40", VA = "0x2C19F40", Slot = "5")]
		[AsyncStateMachine(typeof(<Retry>d__10))]
		public Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2C1A038", Offset = "0x2C16038", VA = "0x2C1A038")]
		[AsyncStateMachine(typeof(<RetryFromMainThread>d__11))]
		private Task<bool> RetryFromMainThread()
		{
			return null;
		}
	}
	[Token(Token = "0x2000089")]
	internal class RetryService : IRetryService
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Uniject.IUtil m_Util;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2C1ADD0", Offset = "0x2C16DD0", VA = "0x2C1ADD0")]
		internal RetryService(Uniject.IUtil util)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2C1ADF8", Offset = "0x2C16DF8", VA = "0x2C1ADF8", Slot = "4")]
		public IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	internal class GooglePlayStoreConnectionUseCase : IGooglePlayStoreConnectionUseCase
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2C1AE6C", Offset = "0x2C16E6C", VA = "0x2C1AE6C")]
		[Preserve]
		public GooglePlayStoreConnectionUseCase(IGoogleBillingClient billingClient)
		{
		}
	}
	[Token(Token = "0x200008B")]
	internal class GooglePlayStoreSetObfuscatedIdUseCase : IGooglePlayStoreSetObfuscatedIdUseCase
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IGoogleBillingClient m_BillingClient;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2C1AE94", Offset = "0x2C16E94", VA = "0x2C1AE94")]
		[Preserve]
		internal GooglePlayStoreSetObfuscatedIdUseCase(IGoogleBillingClient billingClient)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public interface IGooglePlayStoreConnectionUseCase
	{
	}
	[Token(Token = "0x200008D")]
	internal interface IGooglePlayStoreSetObfuscatedIdUseCase
	{
	}
	[Token(Token = "0x200008E")]
	internal class GooglePlayStoreExtendedService : StoreService
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IGooglePlayStoreSetObfuscatedIdUseCase m_GooglePlayStoreSetObfuscatedIdUseCase;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IGooglePlayStoreConnectionUseCase m_GooglePlayStoreConnectionUseCase;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2C1AEBC", Offset = "0x2C16EBC", VA = "0x2C1AEBC")]
		[Preserve]
		internal GooglePlayStoreExtendedService(IGooglePlayStoreSetObfuscatedIdUseCase googlePlayStoreSetObfuscatedIdUseCase, IGooglePlayStoreConnectionUseCase googlePlayStoreConnectionUseCase, IStoreConnectUseCase connectUseCase)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class StoreException : Exception
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2C1AF20", Offset = "0x2C16F20", VA = "0x2C1AF20")]
		public StoreException(string message)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2C1AF88", Offset = "0x2C16F88", VA = "0x2C1AF88")]
		public StoreException(string message, Exception innerException)
		{
		}
	}
	[Token(Token = "0x2000090")]
	public interface IStoreConnectCallback
	{
		[Token(Token = "0x600019A")]
		void OnStoreConnectionSucceeded();

		[Token(Token = "0x600019B")]
		void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription);
	}
	[Token(Token = "0x2000091")]
	internal interface IStoreConnectionStateService
	{
		[Token(Token = "0x600019C")]
		ConnectionState GetConnectionState();

		[Token(Token = "0x600019D")]
		void SetConnectionState(ConnectionState connectionState);
	}
	[Token(Token = "0x2000092")]
	internal interface IStoreFactory
	{
		[Token(Token = "0x600019E")]
		IStoreWrapper CreateStore(string storeName);
	}
	[Token(Token = "0x2000093")]
	internal interface IStoreManagerFactoryInjectionPoint
	{
		[Token(Token = "0x600019F")]
		void SetStoreFactory(IStoreFactory storeFactory);
	}
	[Token(Token = "0x2000094")]
	public interface IStoreService
	{
		[Token(Token = "0x60001A0")]
		Task Connect();
	}
	[Token(Token = "0x2000095")]
	internal interface IStoreServiceFactory
	{
		[Token(Token = "0x60001A1")]
		IStoreService Create(IStoreWrapper store, IRetryPolicy? retryPolicy);
	}
	[Token(Token = "0x2000096")]
	internal interface IStoreServiceFactoryManager
	{
		[Token(Token = "0x60001A2")]
		IStoreServiceFactory GetServiceFactory();
	}
	[Token(Token = "0x2000097")]
	internal interface IStoreServiceFactoryManagerInjectionPoint
	{
		[Token(Token = "0x60001A3")]
		void SetServiceFactory(IStoreServiceFactory serviceFactory);
	}
	[Token(Token = "0x2000098")]
	public interface IStoreWrapper
	{
		[Token(Token = "0x17000036")]
		Store instance
		{
			[Token(Token = "0x60001A4")]
			get;
		}

		[Token(Token = "0x17000037")]
		string name
		{
			[Token(Token = "0x60001A5")]
			get;
		}

		[Token(Token = "0x60001A6")]
		ConnectionState GetStoreConnectionState();
	}
	[Token(Token = "0x2000099")]
	internal interface IStoreConnectUseCase
	{
		[Token(Token = "0x60001A7")]
		Task Connect();
	}
	[Token(Token = "0x200009A")]
	public enum ConnectionState
	{
		[Token(Token = "0x40000EA")]
		Disconnected,
		[Token(Token = "0x40000EB")]
		Connecting,
		[Token(Token = "0x40000EC")]
		Connected,
		[Token(Token = "0x40000ED")]
		Disconnecting,
		[Token(Token = "0x40000EE")]
		Unavailable
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class StoreConnectionFailureDescription : IRetryableRequestFailureDescription
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string message;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isRetryable;

		[Token(Token = "0x17000038")]
		public bool IsRetryable
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x2C1AFF8", Offset = "0x2C16FF8", VA = "0x2C1AFF8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2C1B000", Offset = "0x2C17000", VA = "0x2C1B000")]
		public StoreConnectionFailureDescription(string message, bool isRetryable = false)
		{
		}
	}
	[Token(Token = "0x200009C")]
	internal class StoreConnectionStateService : IStoreConnectionStateService
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ConnectionState? m_StoreConnectionState;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2C0BF40", Offset = "0x2C07F40", VA = "0x2C0BF40")]
		public StoreConnectionStateService()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2C1B030", Offset = "0x2C17030", VA = "0x2C1B030", Slot = "4")]
		public ConnectionState GetConnectionState()
		{
			return default(ConnectionState);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2C1B088", Offset = "0x2C17088", VA = "0x2C1B088", Slot = "5")]
		public void SetConnectionState(ConnectionState connectionState)
		{
		}
	}
	[Token(Token = "0x200009D")]
	internal class StoreManager : IStoreManagerFactoryInjectionPoint
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StoreManager? s_Instance;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IStoreFactory? m_StoreFactory;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string?, IStoreWrapper> m_InstantiatedStores;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2C1B0F0", Offset = "0x2C170F0", VA = "0x2C1B0F0", Slot = "4")]
		public void SetStoreFactory(IStoreFactory? storeFactory)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2C0D270", Offset = "0x2C09270", VA = "0x2C0D270")]
		public static StoreManager Instance()
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2C0D37C", Offset = "0x2C0937C", VA = "0x2C0D37C", Slot = "5")]
		public IStoreWrapper GetStore(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2C0D2D8", Offset = "0x2C092D8", VA = "0x2C0D2D8")]
		public IStoreWrapper GetDefaultStore()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2C1B0F8", Offset = "0x2C170F8", VA = "0x2C1B0F8")]
		public StoreManager()
		{
		}
	}
	[Token(Token = "0x200009E")]
	internal class StoreService : IStoreService
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStoreConnectUseCase m_StoreConnectUseCase;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2C1AEF8", Offset = "0x2C16EF8", VA = "0x2C1AEF8")]
		internal StoreService(IStoreConnectUseCase connectUseCase)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2C1B20C", Offset = "0x2C1720C", VA = "0x2C1B20C", Slot = "4")]
		public Task Connect()
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	internal class StoreServiceContainer
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StoreServiceContainer? s_Instance;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string?, IStoreService> m_InstantiatedServices;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2C1B2AC", Offset = "0x2C172AC", VA = "0x2C1B2AC")]
		internal static StoreServiceContainer Instance()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2C1B390", Offset = "0x2C17390", VA = "0x2C1B390")]
		internal IStoreService FindService(string storeName)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2C1B424", Offset = "0x2C17424", VA = "0x2C1B424")]
		internal void SetService(string storeName, IStoreService service)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2C1B314", Offset = "0x2C17314", VA = "0x2C1B314")]
		public StoreServiceContainer()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	internal class StoreServiceDependencyInjector
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IRetryPolicy? m_RetryPolicy;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IStoreWrapper m_Store;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IStoreServiceFactoryManager m_ServiceFactoryManager;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2C1B520", Offset = "0x2C17520", VA = "0x2C1B520")]
		internal StoreServiceDependencyInjector(IStoreWrapper storeWrapper, IRetryPolicy? retryPolicy)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2C1B5CC", Offset = "0x2C175CC", VA = "0x2C1B5CC")]
		internal IStoreService CreateStoreService()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	internal class StoreServiceFactoryManager : IStoreServiceFactoryManager, IStoreServiceFactoryManagerInjectionPoint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StoreServiceFactoryManager s_Instance;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IStoreServiceFactory m_Factory;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2C1B554", Offset = "0x2C17554", VA = "0x2C1B554")]
		internal static StoreServiceFactoryManager Instance()
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2C1B6F4", Offset = "0x2C176F4", VA = "0x2C1B6F4", Slot = "5")]
		public void SetServiceFactory(IStoreServiceFactory serviceFactory)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C1B6FC", Offset = "0x2C176FC", VA = "0x2C1B6FC", Slot = "4")]
		public IStoreServiceFactory GetServiceFactory()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C1B6EC", Offset = "0x2C176EC", VA = "0x2C1B6EC")]
		public StoreServiceFactoryManager()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	internal static class StoreServiceProvider
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C1B704", Offset = "0x2C17704", VA = "0x2C1B704")]
		public static IStoreService GetDefaultStoreService()
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C1B744", Offset = "0x2C17744", VA = "0x2C1B744")]
		public static IStoreService GetStoreService(string storeName)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2C1B720", Offset = "0x2C17720", VA = "0x2C1B720")]
		private static IStoreService GetStoreServiceInternal(IStoreWrapper storeWrapper)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2C1B768", Offset = "0x2C17768", VA = "0x2C1B768")]
		private static IStoreService LocateExistingService(IStoreWrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C1B820", Offset = "0x2C17820", VA = "0x2C1B820")]
		private static IStoreService CreateNewService(IStoreWrapper wrapper)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	internal class StoreWrapper : IStoreWrapper
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private InternalStore m_InternalStore;

		[Token(Token = "0x17000039")]
		public string name
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x2C1BA0C", Offset = "0x2C17A0C", VA = "0x2C1BA0C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public Store instance
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2C1BA14", Offset = "0x2C17A14", VA = "0x2C1BA14", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C1BA1C", Offset = "0x2C17A1C", VA = "0x2C1BA1C", Slot = "6")]
		public ConnectionState GetStoreConnectionState()
		{
			return default(ConnectionState);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2C1BA30", Offset = "0x2C17A30", VA = "0x2C1BA30")]
		public StoreWrapper(string name, InternalStore instance)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	internal class StoreConnectUseCase : IStoreConnectUseCase, IStoreConnectCallback
	{
		[StructLayout(3)]
		[Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private struct <OnStoreConnectionFailed>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public StoreConnectUseCase <>4__this;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public StoreConnectionFailureDescription failureDescription;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2C1C1AC", Offset = "0x2C181AC", VA = "0x2C1C1AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2C1C54C", Offset = "0x2C1854C", VA = "0x2C1C54C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IStore m_Store;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IRetryService m_RetryService;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IRetryPolicy m_RetryPolicyOnDisconnect;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private Action<StoreConnectionFailureDescription>? OnStoreDisconnection;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskCompletionSource<object?>? m_CurrentConnectionCompletion;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IRetryRequest? m_CurrentRequest;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2C1BA5C", Offset = "0x2C17A5C", VA = "0x2C1BA5C")]
		internal StoreConnectUseCase(IStore store, IRetryService retryService, IRetryPolicy retryPolicyOnDisconnect)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2C1BB2C", Offset = "0x2C17B2C", VA = "0x2C1BB2C", Slot = "4")]
		public Task Connect()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2C1BD68", Offset = "0x2C17D68", VA = "0x2C1BD68")]
		private void InitializeRequest()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2C1BF2C", Offset = "0x2C17F2C", VA = "0x2C1BF2C", Slot = "5")]
		public void OnStoreConnectionSucceeded()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2C1C008", Offset = "0x2C18008", VA = "0x2C1C008", Slot = "6")]
		[AsyncStateMachine(typeof(<OnStoreConnectionFailed>d__12))]
		public void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2C1C0A0", Offset = "0x2C180A0", VA = "0x2C1C0A0")]
		private void SendDisconnectionEvent(StoreConnectionFailureDescription connectionFailureDescription)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	internal class StoreConnectUseCaseFactory
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2C1C558", Offset = "0x2C18558", VA = "0x2C1C558")]
		public IStoreConnectUseCase CreateUseCase(IStoreWrapper storeWrapper, IRetryService retryService)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2C1C6A4", Offset = "0x2C186A4", VA = "0x2C1C6A4")]
		private static IRetryPolicy CreateRetryPolicy(string storeName)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2C1C758", Offset = "0x2C18758", VA = "0x2C1C758")]
		public StoreConnectUseCaseFactory()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class StoreController : IStoreService, IProductService, IPurchaseService
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IStoreService m_StoreService;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IProductService m_ProductService;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IPurchaseService m_PurchaseService;

		[Token(Token = "0x1700003B")]
		private IAppleStoreExtendedPurchaseService? UnityEngine.Purchasing.IPurchaseService.Apple
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x2C1C7D0", Offset = "0x2C187D0", VA = "0x2C1C7D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private IGooglePlayStoreExtendedPurchaseService? UnityEngine.Purchasing.IPurchaseService.Google
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2C1C870", Offset = "0x2C18870", VA = "0x2C1C870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000019")]
		public event Action<PendingOrder>? OnPurchasePending
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2C1C914", Offset = "0x2C18914", VA = "0x2C1C914", Slot = "18")]
			add
			{
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x2C1C9C0", Offset = "0x2C189C0", VA = "0x2C1C9C0", Slot = "19")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event Action<Order>? OnPurchaseConfirmed
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2C1CA6C", Offset = "0x2C18A6C", VA = "0x2C1CA6C", Slot = "20")]
			add
			{
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2C1CB18", Offset = "0x2C18B18", VA = "0x2C1CB18", Slot = "21")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event Action<FailedOrder>? OnPurchaseFailed
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x2C1CBC4", Offset = "0x2C18BC4", VA = "0x2C1CBC4", Slot = "22")]
			add
			{
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x2C1CC70", Offset = "0x2C18C70", VA = "0x2C1CC70", Slot = "23")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event Action<DeferredOrder>? OnPurchaseDeferred
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2C1CD1C", Offset = "0x2C18D1C", VA = "0x2C1CD1C", Slot = "24")]
			add
			{
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2C1CDC8", Offset = "0x2C18DC8", VA = "0x2C1CDC8", Slot = "25")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event Action<Orders>? OnPurchasesFetched
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2C1CE74", Offset = "0x2C18E74", VA = "0x2C1CE74", Slot = "26")]
			add
			{
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2C1CF20", Offset = "0x2C18F20", VA = "0x2C1CF20", Slot = "27")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event Action<PurchasesFetchFailureDescription>? OnPurchasesFetchFailed
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2C1CFCC", Offset = "0x2C18FCC", VA = "0x2C1CFCC", Slot = "28")]
			add
			{
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x2C1D078", Offset = "0x2C19078", VA = "0x2C1D078", Slot = "29")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event Action<List<Product>>? OnProductsFetched
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2C1D124", Offset = "0x2C19124", VA = "0x2C1D124", Slot = "7")]
			add
			{
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2C1D1D0", Offset = "0x2C191D0", VA = "0x2C1D1D0", Slot = "8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event Action<ProductFetchFailed>? OnProductsFetchFailed
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2C1D27C", Offset = "0x2C1927C", VA = "0x2C1D27C", Slot = "9")]
			add
			{
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2C1D328", Offset = "0x2C19328", VA = "0x2C1D328", Slot = "10")]
			remove
			{
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2C1C760", Offset = "0x2C18760", VA = "0x2C1C760")]
		public StoreController([Optional] string? storeName)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2C1D3D4", Offset = "0x2C193D4", VA = "0x2C1D3D4", Slot = "4")]
		public Task Connect()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2C1D474", Offset = "0x2C19474", VA = "0x2C1D474", Slot = "5")]
		public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2C1D51C", Offset = "0x2C1951C", VA = "0x2C1D51C", Slot = "6")]
		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2C1D5C0", Offset = "0x2C195C0", VA = "0x2C1D5C0", Slot = "13")]
		public void PurchaseProduct(Product product)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2C1D66C", Offset = "0x2C1966C", VA = "0x2C1D66C", Slot = "14")]
		public void ConfirmPurchase(PendingOrder order)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2C1D718", Offset = "0x2C19718", VA = "0x2C1D718", Slot = "15")]
		public void FetchPurchases()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2C1D7BC", Offset = "0x2C197BC", VA = "0x2C1D7BC", Slot = "16")]
		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2C1D868", Offset = "0x2C19868", VA = "0x2C1D868", Slot = "17")]
		public ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A8")]
	public static class UnityIAPServices
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2C1D90C", Offset = "0x2C1990C", VA = "0x2C1D90C")]
		public static IPurchaseService DefaultPurchase()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2C1D910", Offset = "0x2C19910", VA = "0x2C1D910")]
		public static IPurchaseService Purchase(string storeName)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	internal class CoreServicesEnvironmentSubject
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoreServicesEnvironmentSubject s_Instance;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_LastKnownEnvironment;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<ICoreServicesEnvironmentObserver> m_Observers;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2C1D914", Offset = "0x2C19914", VA = "0x2C1D914")]
		internal static CoreServicesEnvironmentSubject Instance()
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2C1DA04", Offset = "0x2C19A04", VA = "0x2C1DA04")]
		internal void UpdateCurrentEnvironment(string currentEnvironment)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2C1DA0C", Offset = "0x2C19A0C", VA = "0x2C1DA0C")]
		private void NotifyObservers()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2C1D988", Offset = "0x2C19988", VA = "0x2C1D988")]
		public CoreServicesEnvironmentSubject()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	internal interface ICoreServicesEnvironmentObserver
	{
		[Token(Token = "0x60001F3")]
		void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	internal class DependencyInjectionException : Exception
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2C1DBB8", Offset = "0x2C19BB8", VA = "0x2C1DBB8")]
		internal DependencyInjectionException()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C1DC10", Offset = "0x2C19C10", VA = "0x2C1DC10")]
		internal DependencyInjectionException(string message)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2C1DC78", Offset = "0x2C19C78", VA = "0x2C1DC78")]
		protected DependencyInjectionException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	internal class DependencyInjectionService : IDependencyInjectionService
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly HashSet<object> m_ServiceInstances;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly HashSet<Type> m_ServiceConcreteTypes;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2C1DCF8", Offset = "0x2C19CF8", VA = "0x2C1DCF8", Slot = "4")]
		public void AddInstance(object instance)
		{
		}

		[Token(Token = "0x60001F8")]
		public void AddService<T>() where T : class
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2C1DD50", Offset = "0x2C19D50", VA = "0x2C1DD50")]
		private void ValidateTypeIsNotAnInterface(Type type)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2C1DDD0", Offset = "0x2C19DD0", VA = "0x2C1DDD0")]
		private void ValidateTypeIsNotADuplicate(Type type)
		{
		}

		[Token(Token = "0x60001FB")]
		public T GetInstance<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2C1DE80", Offset = "0x2C19E80", VA = "0x2C1DE80")]
		private object GetInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2C1DEC4", Offset = "0x2C19EC4", VA = "0x2C1DEC4")]
		private object FindServiceInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2C1E000", Offset = "0x2C1A000", VA = "0x2C1E000")]
		private Type FindConcreteServiceType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2C1E174", Offset = "0x2C1A174", VA = "0x2C1E174")]
		private object CreateServiceInstance(Type concreteType)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2C1E1CC", Offset = "0x2C1A1CC", VA = "0x2C1E1CC")]
		private ConstructorInfo FindConstructorForType(Type concreteType)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2C1E478", Offset = "0x2C1A478", VA = "0x2C1E478")]
		private ConstructorInfo HandleMultipleConstructors(ConstructorInfo[] constructors, Type concreteType)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2C1E548", Offset = "0x2C1A548", VA = "0x2C1E548")]
		private List<ConstructorInfo> FindInjectableConstructors(ConstructorInfo[] constructors)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2C1E2B8", Offset = "0x2C1A2B8", VA = "0x2C1E2B8")]
		private object[] GetParameterInstancesForConstructor(ConstructorInfo constructor)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2C1E65C", Offset = "0x2C1A65C", VA = "0x2C1E65C")]
		public DependencyInjectionService()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	internal interface IDependencyInjectionService
	{
		[Token(Token = "0x600020A")]
		void AddInstance(object instance);

		[Token(Token = "0x600020B")]
		void AddService<T>() where T : class;

		[Token(Token = "0x600020C")]
		T GetInstance<T>() where T : class;
	}
	[Token(Token = "0x20000AF")]
	internal class InjectAttribute : Attribute
	{
	}
	[Token(Token = "0x20000B0")]
	[Preserve]
	internal class ErrorMessages
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2C1E958", Offset = "0x2C1A958", VA = "0x2C1E958")]
		public ErrorMessages()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class CatalogProvider
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string?, Dictionary<string, string>> m_StoreSpecificIds;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ProductDefinition> m_Products;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2C1E960", Offset = "0x2C1A960", VA = "0x2C1E960", Slot = "4")]
		public List<ProductDefinition> GetProducts([Optional] string? storeName)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2C1EB44", Offset = "0x2C1AB44", VA = "0x2C1EB44", Slot = "5")]
		public void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs, IEnumerable<PayoutDefinition>? payouts)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2C1EC70", Offset = "0x2C1AC70", VA = "0x2C1EC70")]
		private string AddStoreSpecificIds(string id, StoreSpecificIds? storeIDs)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2C1F13C", Offset = "0x2C1B13C", VA = "0x2C1F13C", Slot = "6")]
		public void FetchProducts(Action<List<ProductDefinition>> callback, string storeName)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2C1E980", Offset = "0x2C1A980", VA = "0x2C1E980")]
		private void UpdateStoreSpecificIDs(string storeName)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2C1F180", Offset = "0x2C1B180", VA = "0x2C1F180")]
		public CatalogProvider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class Price : ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public decimal value;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int[] data;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private double num;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2C1F244", Offset = "0x2C1B244", VA = "0x2C1F244", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2C1F2C0", Offset = "0x2C1B2C0", VA = "0x2C1F2C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2C1F32C", Offset = "0x2C1B32C", VA = "0x2C1F32C")]
		public Price()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class StoreID
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string store;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;
	}
	[Token(Token = "0x20000B4")]
	public enum TranslationLocale
	{
		[Token(Token = "0x400011E")]
		af_ZA,
		[Token(Token = "0x400011F")]
		sq_SQ,
		[Token(Token = "0x4000120")]
		am_ET,
		[Token(Token = "0x4000121")]
		ar_AE,
		[Token(Token = "0x4000122")]
		hy_AM,
		[Token(Token = "0x4000123")]
		az_AZ,
		[Token(Token = "0x4000124")]
		bn_BD,
		[Token(Token = "0x4000125")]
		eu_ES,
		[Token(Token = "0x4000126")]
		be_BY,
		[Token(Token = "0x4000127")]
		bg_BG,
		[Token(Token = "0x4000128")]
		my_MM,
		[Token(Token = "0x4000129")]
		ca_CA,
		[Token(Token = "0x400012A")]
		zh_HK,
		[Token(Token = "0x400012B")]
		zh_CN,
		[Token(Token = "0x400012C")]
		zh_TW,
		[Token(Token = "0x400012D")]
		hr_HR,
		[Token(Token = "0x400012E")]
		cs_CZ,
		[Token(Token = "0x400012F")]
		da_DK,
		[Token(Token = "0x4000130")]
		nl_NL,
		[Token(Token = "0x4000131")]
		en_AU,
		[Token(Token = "0x4000132")]
		en_CA,
		[Token(Token = "0x4000133")]
		en_US,
		[Token(Token = "0x4000134")]
		en_GB,
		[Token(Token = "0x4000135")]
		en_IN,
		[Token(Token = "0x4000136")]
		en_SG,
		[Token(Token = "0x4000137")]
		en_ZA,
		[Token(Token = "0x4000138")]
		et_EE,
		[Token(Token = "0x4000139")]
		fil_FIL,
		[Token(Token = "0x400013A")]
		fi_FI,
		[Token(Token = "0x400013B")]
		fr_CA,
		[Token(Token = "0x400013C")]
		fr_FR,
		[Token(Token = "0x400013D")]
		gl_ES,
		[Token(Token = "0x400013E")]
		ka_GE,
		[Token(Token = "0x400013F")]
		de_DE,
		[Token(Token = "0x4000140")]
		el_GR,
		[Token(Token = "0x4000141")]
		gu_IN,
		[Token(Token = "0x4000142")]
		iw_IL,
		[Token(Token = "0x4000143")]
		hi_IN,
		[Token(Token = "0x4000144")]
		hu_HU,
		[Token(Token = "0x4000145")]
		is_IS,
		[Token(Token = "0x4000146")]
		id_ID,
		[Token(Token = "0x4000147")]
		it_IT,
		[Token(Token = "0x4000148")]
		ja_JP,
		[Token(Token = "0x4000149")]
		kn_IN,
		[Token(Token = "0x400014A")]
		kk_KZ,
		[Token(Token = "0x400014B")]
		km_KH,
		[Token(Token = "0x400014C")]
		ko_KR,
		[Token(Token = "0x400014D")]
		ky_KG,
		[Token(Token = "0x400014E")]
		lo_LA,
		[Token(Token = "0x400014F")]
		lv_LV,
		[Token(Token = "0x4000150")]
		lt_LT,
		[Token(Token = "0x4000151")]
		mk_MK,
		[Token(Token = "0x4000152")]
		ms_MY,
		[Token(Token = "0x4000153")]
		ms_MS,
		[Token(Token = "0x4000154")]
		ml_IN,
		[Token(Token = "0x4000155")]
		mr_IN,
		[Token(Token = "0x4000156")]
		mn_MN,
		[Token(Token = "0x4000157")]
		ne_NP,
		[Token(Token = "0x4000158")]
		no_NO,
		[Token(Token = "0x4000159")]
		fa_FA,
		[Token(Token = "0x400015A")]
		fa_AE,
		[Token(Token = "0x400015B")]
		fa_AF,
		[Token(Token = "0x400015C")]
		fa_IR,
		[Token(Token = "0x400015D")]
		pl_PL,
		[Token(Token = "0x400015E")]
		pt_BR,
		[Token(Token = "0x400015F")]
		pt_PT,
		[Token(Token = "0x4000160")]
		pa_IN,
		[Token(Token = "0x4000161")]
		ro_RO,
		[Token(Token = "0x4000162")]
		rm_CH,
		[Token(Token = "0x4000163")]
		ru_RU,
		[Token(Token = "0x4000164")]
		sr_RS,
		[Token(Token = "0x4000165")]
		si_LK,
		[Token(Token = "0x4000166")]
		sk_SK,
		[Token(Token = "0x4000167")]
		sl_SI,
		[Token(Token = "0x4000168")]
		es_419,
		[Token(Token = "0x4000169")]
		es_ES,
		[Token(Token = "0x400016A")]
		es_MX,
		[Token(Token = "0x400016B")]
		es_US,
		[Token(Token = "0x400016C")]
		sw_KE,
		[Token(Token = "0x400016D")]
		sv_SE,
		[Token(Token = "0x400016E")]
		ta_IN,
		[Token(Token = "0x400016F")]
		te_IN,
		[Token(Token = "0x4000170")]
		th_TH,
		[Token(Token = "0x4000171")]
		tr_TR,
		[Token(Token = "0x4000172")]
		uk_UA,
		[Token(Token = "0x4000173")]
		ur_UZ,
		[Token(Token = "0x4000174")]
		vi_VN,
		[Token(Token = "0x4000175")]
		zu_ZA
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class LocalizedProductDescription
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TranslationLocale googleLocale;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string title;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string description;

		[Token(Token = "0x1700003D")]
		public string Title
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x2C1F334", Offset = "0x2C1B334", VA = "0x2C1F334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public string Description
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x2C1F47C", Offset = "0x2C1B47C", VA = "0x2C1F47C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2C1F33C", Offset = "0x2C1B33C", VA = "0x2C1F33C")]
		private static string DecodeNonLatinCharacters(string s)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2C1F484", Offset = "0x2C1B484", VA = "0x2C1F484")]
		public LocalizedProductDescription()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class ProductCatalogPayout
	{
		[Token(Token = "0x20000B8")]
		public enum ProductCatalogPayoutType
		{
			[Token(Token = "0x4000180")]
			Other,
			[Token(Token = "0x4000181")]
			Currency,
			[Token(Token = "0x4000182")]
			Item,
			[Token(Token = "0x4000183")]
			Resource
		}

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string t;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string st;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double q;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string d;

		[Token(Token = "0x1700003F")]
		public string typeString
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2C1F5B0", Offset = "0x2C1B5B0", VA = "0x2C1F5B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public string subtype
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x2C1F5B8", Offset = "0x2C1B5B8", VA = "0x2C1F5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public double quantity
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2C1F5C0", Offset = "0x2C1B5C0", VA = "0x2C1F5C0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000042")]
		public string data
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2C1F5C8", Offset = "0x2C1B5C8", VA = "0x2C1F5C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2C1F5D0", Offset = "0x2C1B5D0", VA = "0x2C1F5D0")]
		public ProductCatalogPayout()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class ProductCatalogItem
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProductType type;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<StoreID> storeIDs;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocalizedProductDescription defaultDescription;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Price googlePrice;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<LocalizedProductDescription> descriptions;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ProductCatalogPayout> payouts;

		[Token(Token = "0x17000043")]
		public IList<ProductCatalogPayout> Payouts
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2C1F670", Offset = "0x2C1B670", VA = "0x2C1F670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public ICollection<StoreID> allStoreIDs
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2C1F678", Offset = "0x2C1B678", VA = "0x2C1F678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2C1F680", Offset = "0x2C1B680", VA = "0x2C1F680")]
		public ProductCatalogItem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class ProductCatalog
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IProductCatalogImpl instance;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enableCodelessAutoInitialization;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool enableUnityGamingServicesAutoInitialization;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ProductCatalogItem> products;

		[Token(Token = "0x17000045")]
		public ICollection<ProductCatalogItem> allProducts
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2C1F7F4", Offset = "0x2C1B7F4", VA = "0x2C1F7F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2C1F7FC", Offset = "0x2C1B7FC", VA = "0x2C1F7FC")]
		internal static void Initialize()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2C1F8A4", Offset = "0x2C1B8A4", VA = "0x2C1F8A4")]
		public static void Initialize(IProductCatalogImpl productCatalogImpl)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2C1F8F0", Offset = "0x2C1B8F0", VA = "0x2C1F8F0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2C1FA38", Offset = "0x2C1BA38", VA = "0x2C1FA38")]
		public static ProductCatalog Deserialize(string catalogJSON)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2C1FA80", Offset = "0x2C1BA80", VA = "0x2C1FA80")]
		public static ProductCatalog FromTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2C1FA9C", Offset = "0x2C1BA9C", VA = "0x2C1FA9C")]
		public static ProductCatalog LoadDefaultCatalog()
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2C1FB58", Offset = "0x2C1BB58", VA = "0x2C1FB58")]
		public ProductCatalog()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public interface IProductCatalogImpl
	{
		[Token(Token = "0x600022E")]
		ProductCatalog LoadDefaultCatalog();
	}
	[Token(Token = "0x20000BC")]
	internal class ProductCatalogImpl : IProductCatalogImpl
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2C1FBDC", Offset = "0x2C1BBDC", VA = "0x2C1FBDC", Slot = "4")]
		public ProductCatalog LoadDefaultCatalog()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2C1F89C", Offset = "0x2C1B89C", VA = "0x2C1F89C")]
		public ProductCatalogImpl()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class ConfigurationBuilder
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal CatalogProvider m_CatalogProvider;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ConfigurationProvider m_ConfigurationProvider;

		[Token(Token = "0x6000231")]
		public T Configure<T>() where T : IStoreConfiguration
		{
			return (T)null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2C1FCE0", Offset = "0x2C1BCE0", VA = "0x2C1FCE0")]
		public ConfigurationBuilder()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	internal class AppleConfiguration : IAppleConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2C1FDF0", Offset = "0x2C1BDF0", VA = "0x2C1FDF0")]
		public AppleConfiguration()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	internal class ConfigurationProvider
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Type, IStoreConfiguration> m_ConfigMap;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2C1FD6C", Offset = "0x2C1BD6C", VA = "0x2C1FD6C")]
		public ConfigurationProvider()
		{
		}

		[Token(Token = "0x6000235")]
		public T GetConfiguration<T>() where T : IStoreConfiguration
		{
			return (T)null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2C1FDF8", Offset = "0x2C1BDF8", VA = "0x2C1FDF8")]
		private void RegisterConfigurations()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	internal class GooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2C1FF48", Offset = "0x2C1BF48", VA = "0x2C1FF48")]
		public GooglePlayConfiguration()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IAppleConfiguration : IStoreConfiguration
	{
	}
	[Token(Token = "0x20000C2")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IGooglePlayConfiguration : IStoreConfiguration
	{
	}
	[Token(Token = "0x20000C3")]
	internal class StoreConfiguration
	{
		[Token(Token = "0x17000046")]
		public AppStore androidStore
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2C1FF50", Offset = "0x2C1BF50", VA = "0x2C1FF50")]
			[CompilerGenerated]
			get
			{
				return default(AppStore);
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2C1FF58", Offset = "0x2C1BF58", VA = "0x2C1FF58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2C1FF60", Offset = "0x2C1BF60", VA = "0x2C1FF60")]
		public StoreConfiguration(AppStore store)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2C1FF88", Offset = "0x2C1BF88", VA = "0x2C1FF88")]
		public static StoreConfiguration Deserialize(string json)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C4")]
	internal class AppleExtensions : IAppleExtensions, IStoreExtension
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2C2020C", Offset = "0x2C1C20C", VA = "0x2C2020C")]
		public AppleExtensions()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	internal class ExtensionProvider : IExtensionProvider
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2C20214", Offset = "0x2C1C214", VA = "0x2C20214")]
		public ExtensionProvider()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2C20298", Offset = "0x2C1C298", VA = "0x2C20298")]
		private void RegisterExtensions()
		{
		}

		[Token(Token = "0x600023F")]
		public T GetExtension<T>() where T : IStoreExtension
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20000C6")]
	internal class GoogleExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2C203F0", Offset = "0x2C1C3F0", VA = "0x2C203F0", Slot = "4")]
		public void RestoreTransactions(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2C204BC", Offset = "0x2C1C4BC", VA = "0x2C204BC", Slot = "5")]
		public GooglePurchaseState GetPurchaseState(Product product)
		{
			return default(GooglePurchaseState);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2C203E8", Offset = "0x2C1C3E8", VA = "0x2C203E8")]
		public GoogleExtensions()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IAppleExtensions : IStoreExtension
	{
	}
	[Token(Token = "0x20000C9")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IExtensionProvider
	{
		[Token(Token = "0x6000245")]
		T GetExtension<T>() where T : IStoreExtension;
	}
	[Token(Token = "0x20000CA")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		[Token(Token = "0x6000246")]
		void RestoreTransactions(Action<bool, string> callback);

		[Token(Token = "0x6000247")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		GooglePurchaseState GetPurchaseState(Product product);
	}
	[Token(Token = "0x20000CB")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreExtension
	{
	}
	[Token(Token = "0x20000CC")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreController
	{
	}
	[Token(Token = "0x20000CD")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreListener
	{
		[Token(Token = "0x6000248")]
		PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args);

		[Token(Token = "0x6000249")]
		[Obsolete("Use IDetailedStoreListener.OnPurchaseFailed for more detailed callback.", false)]
		void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason);
	}
	[Token(Token = "0x20000CE")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class PurchaseEventArgs
	{
		[Token(Token = "0x17000047")]
		private Product purchasedProduct
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2C20BE4", Offset = "0x2C1CBE4", VA = "0x2C20BE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2C20BBC", Offset = "0x2C1CBBC", VA = "0x2C20BBC")]
		internal PurchaseEventArgs(Product purchasedProduct)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public enum PurchaseProcessingResult
	{
		[Token(Token = "0x4000198")]
		Complete,
		[Token(Token = "0x4000199")]
		Pending
	}
	[Token(Token = "0x20000D0")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	internal class PurchasingManager : IStoreController
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly UnityEngine.Purchasing.ITransactionLog m_TransactionLog;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StoreController m_StoreController;

		[Token(Token = "0x17000048")]
		public bool useTransactionLog
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x2C20BEC", Offset = "0x2C1CBEC", VA = "0x2C20BEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2C20BF4", Offset = "0x2C1CBF4", VA = "0x2C20BF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2C20BFC", Offset = "0x2C1CBFC", VA = "0x2C20BFC")]
		public PurchasingManager()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2C2105C", Offset = "0x2C1D05C", VA = "0x2C2105C")]
		private static void OnPurchaseFailedAction(FailedOrder failedOrder)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2C211F4", Offset = "0x2C1D1F4", VA = "0x2C211F4")]
		private void OnPurchasePendingAction(PendingOrder pendingOrder)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2C21A10", Offset = "0x2C1DA10", VA = "0x2C21A10")]
		private void OnPurchaseConfirmedAction(Order order)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2C21C28", Offset = "0x2C1DC28", VA = "0x2C21C28")]
		private void OnPurchasesFetchedAction(Orders orders)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2C21764", Offset = "0x2C1D764", VA = "0x2C21764")]
		private void InvokeProcessPurchase(Product product, Order order)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2C231C4", Offset = "0x2C1F1C4", VA = "0x2C231C4", Slot = "4")]
		public void ConfirmPendingPurchase(Product product)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2C232A8", Offset = "0x2C1F2A8", VA = "0x2C232A8")]
		private static PendingOrder CreatePendingOrderFromProduct(Product product)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2C23104", Offset = "0x2C1F104", VA = "0x2C23104")]
		private bool HasRecordedTransaction(string transactionId)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D5")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class UnityPurchasing
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static IStoreListener m_StoreListener;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static bool shouldFetchProductsAtInit;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool isInitialized;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static PurchasingManager m_PurchasingManager;
	}
	[Serializable]
	[Token(Token = "0x20000D6")]
	public class PayoutDefinition
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PayoutType m_Type;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Subtype;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double m_Quantity;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_Data;

		[Token(Token = "0x40001AA")]
		public const int MaxSubtypeLength = 64;

		[Token(Token = "0x40001AB")]
		public const int MaxDataLength = 1024;

		[Token(Token = "0x17000049")]
		private PayoutType type
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2C23978", Offset = "0x2C1F978", VA = "0x2C23978")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		private string subtype
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2C23980", Offset = "0x2C1F980", VA = "0x2C23980")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		private double quantity
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2C23A20", Offset = "0x2C1FA20", VA = "0x2C23A20")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		private string data
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2C23A28", Offset = "0x2C1FA28", VA = "0x2C23A28")]
			set
			{
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2C23AC8", Offset = "0x2C1FAC8", VA = "0x2C23AC8")]
		public PayoutDefinition()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2C23B24", Offset = "0x2C1FB24", VA = "0x2C23B24")]
		public PayoutDefinition(string typeString, string subtype, double quantity, string data)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public enum PayoutType
	{
		[Token(Token = "0x40001AD")]
		Other,
		[Token(Token = "0x40001AE")]
		Currency,
		[Token(Token = "0x40001AF")]
		Item,
		[Token(Token = "0x40001B0")]
		Resource
	}
	[Token(Token = "0x20000D8")]
	public class Product
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_Receipt;

		[Token(Token = "0x1700004D")]
		public ProductDefinition definition
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2C23D44", Offset = "0x2C1FD44", VA = "0x2C23D44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2C23D4C", Offset = "0x2C1FD4C", VA = "0x2C23D4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public ProductMetadata metadata
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2C23D54", Offset = "0x2C1FD54", VA = "0x2C23D54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2C23D5C", Offset = "0x2C1FD5C", VA = "0x2C23D5C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		internal bool availableToPurchase
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2C23D64", Offset = "0x2C1FD64", VA = "0x2C23D64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string transactionID
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2C23D6C", Offset = "0x2C1FD6C", VA = "0x2C23D6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2C23D74", Offset = "0x2C1FD74", VA = "0x2C23D74")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000051")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		internal string appleOriginalTransactionID
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2C23D7C", Offset = "0x2C1FD7C", VA = "0x2C23D7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string receipt
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2C23D84", Offset = "0x2C1FD84", VA = "0x2C23D84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2C21760", Offset = "0x2C1D760", VA = "0x2C21760")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2C23CE8", Offset = "0x2C1FCE8", VA = "0x2C23CE8")]
		[Obsolete("This constructor is obsolete and should not be used. Use the Product(ProductDefinition, ProductMetadata) constructor and assign the receipt separately if needed.")]
		internal Product(ProductDefinition definition, ProductMetadata metadata, string receipt)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2C0E368", Offset = "0x2C0A368", VA = "0x2C0E368")]
		internal Product(ProductDefinition definition, ProductMetadata metadata)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2C14FA8", Offset = "0x2C10FA8", VA = "0x2C14FA8")]
		internal static Product CreateUnknownProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2C23D88", Offset = "0x2C1FD88", VA = "0x2C23D88")]
		private string GetReceipt()
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2C23FA4", Offset = "0x2C1FFA4", VA = "0x2C23FA4")]
		private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName)
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2C23F34", Offset = "0x2C1FF34", VA = "0x2C23F34")]
		private void SetReceipt(string curReceipt)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2C23FA8", Offset = "0x2C1FFA8", VA = "0x2C23FA8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2C24044", Offset = "0x2C20044", VA = "0x2C24044", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2C24060", Offset = "0x2C20060", VA = "0x2C24060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class ProductCollection
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2C20F94", Offset = "0x2C1CF94", VA = "0x2C20F94")]
		public ProductCollection()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class ProductDefinition
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<PayoutDefinition> m_Payouts;

		[Token(Token = "0x17000053")]
		public string id
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x2C2420C", Offset = "0x2C2020C", VA = "0x2C2420C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x2C24214", Offset = "0x2C20214", VA = "0x2C24214")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string storeSpecificId
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x2C2421C", Offset = "0x2C2021C", VA = "0x2C2421C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x2C24224", Offset = "0x2C20224", VA = "0x2C24224")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public ProductType type
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x2C2422C", Offset = "0x2C2022C", VA = "0x2C2422C")]
			[CompilerGenerated]
			get
			{
				return default(ProductType);
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x2C24234", Offset = "0x2C20234", VA = "0x2C24234")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool enabled
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x2C2423C", Offset = "0x2C2023C", VA = "0x2C2423C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x2C24244", Offset = "0x2C20244", VA = "0x2C24244")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public IEnumerable<PayoutDefinition> payouts
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2C24488", Offset = "0x2C20488", VA = "0x2C24488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2C240CC", Offset = "0x2C200CC", VA = "0x2C240CC")]
		private ProductDefinition()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2C1EFFC", Offset = "0x2C1AFFC", VA = "0x2C1EFFC")]
		public ProductDefinition(string id, string storeSpecificId, ProductType type)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2C24148", Offset = "0x2C20148", VA = "0x2C24148")]
		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2C24150", Offset = "0x2C20150", VA = "0x2C24150")]
		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2C23D28", Offset = "0x2C1FD28", VA = "0x2C23D28")]
		public ProductDefinition(string id, ProductType type)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2C2424C", Offset = "0x2C2024C", VA = "0x2C2424C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2C243DC", Offset = "0x2C203DC", VA = "0x2C243DC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2C2446C", Offset = "0x2C2046C", VA = "0x2C2446C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2C1F008", Offset = "0x2C1B008", VA = "0x2C1F008")]
		internal void SetPayouts(IEnumerable<PayoutDefinition> newPayouts)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class ProductMetadata
	{
		[Token(Token = "0x17000058")]
		public string localizedPriceString
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2C244E4", Offset = "0x2C204E4", VA = "0x2C244E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x2C244EC", Offset = "0x2C204EC", VA = "0x2C244EC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string localizedTitle
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x2C244F4", Offset = "0x2C204F4", VA = "0x2C244F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x2C244FC", Offset = "0x2C204FC", VA = "0x2C244FC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public string localizedDescription
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x2C24504", Offset = "0x2C20504", VA = "0x2C24504")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x2C2450C", Offset = "0x2C2050C", VA = "0x2C2450C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public string isoCurrencyCode
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2C24514", Offset = "0x2C20514", VA = "0x2C24514")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2C2451C", Offset = "0x2C2051C", VA = "0x2C2451C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public decimal localizedPrice
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2C24524", Offset = "0x2C20524", VA = "0x2C24524")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x2C24530", Offset = "0x2C20530", VA = "0x2C24530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2C24490", Offset = "0x2C20490", VA = "0x2C24490")]
		public ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2C23D3C", Offset = "0x2C1FD3C", VA = "0x2C23D3C")]
		public ProductMetadata()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2C24538", Offset = "0x2C20538", VA = "0x2C24538", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000DC")]
	public enum ProductType
	{
		[Token(Token = "0x40001C2")]
		Consumable,
		[Token(Token = "0x40001C3")]
		NonConsumable,
		[Token(Token = "0x40001C4")]
		Subscription,
		[Token(Token = "0x40001C5")]
		Unknown
	}
	[Token(Token = "0x20000DD")]
	public class PurchaseFailureDescription
	{
		[Token(Token = "0x1700005D")]
		public CartItem item
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2C24778", Offset = "0x2C20778", VA = "0x2C24778")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x2C24780", Offset = "0x2C20780", VA = "0x2C24780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		[Obsolete("Use item.Product instead")]
		public Product product
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x2C24788", Offset = "0x2C20788", VA = "0x2C24788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public PurchaseFailureReason reason
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x2C247A0", Offset = "0x2C207A0", VA = "0x2C247A0")]
			[CompilerGenerated]
			get
			{
				return default(PurchaseFailureReason);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2C247A8", Offset = "0x2C207A8", VA = "0x2C247A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public string message
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2C247B0", Offset = "0x2C207B0", VA = "0x2C247B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2C247B8", Offset = "0x2C207B8", VA = "0x2C247B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2C24738", Offset = "0x2C20738", VA = "0x2C24738")]
		public PurchaseFailureDescription(CartItem item, PurchaseFailureReason reason, string message)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2C247C0", Offset = "0x2C207C0", VA = "0x2C247C0")]
		internal FailedOrder ConvertToFailedOrder(string? transactionId = "")
		{
			return null;
		}
	}
	[Token(Token = "0x20000DE")]
	public enum PurchaseFailureReason
	{
		[Token(Token = "0x40001CA")]
		PurchasingUnavailable,
		[Token(Token = "0x40001CB")]
		ExistingPurchasePending,
		[Token(Token = "0x40001CC")]
		ProductUnavailable,
		[Token(Token = "0x40001CD")]
		SignatureInvalid,
		[Token(Token = "0x40001CE")]
		UserCancelled,
		[Token(Token = "0x40001CF")]
		PaymentDeclined,
		[Token(Token = "0x40001D0")]
		DuplicateTransaction,
		[Token(Token = "0x40001D1")]
		ValidationFailure,
		[Token(Token = "0x40001D2")]
		StoreNotConnected,
		[Token(Token = "0x40001D3")]
		PurchaseMissing,
		[Token(Token = "0x40001D4")]
		Unknown
	}
	[Token(Token = "0x20000DF")]
	internal static class ListExtension
	{
		[Token(Token = "0x60002A2")]
		internal static AndroidJavaObject ToJava<T>(this List<T> values)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		private static AndroidJavaObject ToJavaArray<T>(List<T> values)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E0")]
	internal class UnityActivity
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass s_UnityPlayerClass;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2C248EC", Offset = "0x2C208EC", VA = "0x2C248EC")]
		private static AndroidJavaClass GetUnityPlayerClass()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2C24990", Offset = "0x2C20990", VA = "0x2C24990")]
		internal static AndroidJavaObject GetCurrentActivity()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	public static class GetGoogleProductMetadataExtension
	{
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2C249EC", Offset = "0x2C209EC", VA = "0x2C249EC")]
		public static GoogleProductMetadata GetGoogleProductMetadata(this ProductMetadata productMetadata)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E2")]
	public enum GooglePlayReplacementMode
	{
		[Token(Token = "0x40001D7")]
		UnknownReplacementMode = 0,
		[Token(Token = "0x40001D8")]
		WithTimeProration = 1,
		[Token(Token = "0x40001D9")]
		ChargeProratedPrice = 2,
		[Token(Token = "0x40001DA")]
		WithoutProration = 3,
		[Token(Token = "0x40001DB")]
		ChargeFullPrice = 5,
		[Token(Token = "0x40001DC")]
		Deferred = 6
	}
	[Token(Token = "0x20000E3")]
	internal interface IGooglePlayStore : IStore
	{
		[Token(Token = "0x60002A7")]
		void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

		[Token(Token = "0x60002A8")]
		void OnPause(bool isPaused);
	}
	[Token(Token = "0x20000E4")]
	public class GoogleProductMetadata : ProductMetadata
	{
		[Token(Token = "0x17000061")]
		public string originalJson
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x2C24A64", Offset = "0x2C20A64", VA = "0x2C24A64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x2C24A6C", Offset = "0x2C20A6C", VA = "0x2C24A6C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000062")]
		internal string subscriptionPeriod
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x2C24A74", Offset = "0x2C20A74", VA = "0x2C24A74")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		internal string freeTrialPeriod
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x2C24A7C", Offset = "0x2C20A7C", VA = "0x2C24A7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		internal string introductoryPrice
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2C24A84", Offset = "0x2C20A84", VA = "0x2C24A84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		internal string introductoryPricePeriod
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2C24A8C", Offset = "0x2C20A8C", VA = "0x2C24A8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		internal int introductoryPriceCycles
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2C24A94", Offset = "0x2C20A94", VA = "0x2C24A94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2C24A9C", Offset = "0x2C20A9C", VA = "0x2C24A9C")]
		internal GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
		{
		}
	}
	[Token(Token = "0x20000E5")]
	internal interface IUnityCallback
	{
	}
	[Token(Token = "0x20000E6")]
	public class AppleProductMetadata : ProductMetadata
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2C24AF0", Offset = "0x2C20AF0", VA = "0x2C24AF0")]
		internal AppleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice, bool isFamilyShareable)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public enum AppleStorePromotionVisibility
	{
		[Token(Token = "0x40001E5")]
		AppStoreConnectDefault = 0,
		[Token(Token = "0x40001E6")]
		Default = 0,
		[Token(Token = "0x40001E7")]
		Visible = 1,
		[Token(Token = "0x40001E8")]
		Show = 1,
		[Token(Token = "0x40001E9")]
		Hidden = 2,
		[Token(Token = "0x40001EA")]
		Hide = 2
	}
	[Token(Token = "0x20000E8")]
	internal interface IAppleAppReceiptViewer
	{
		[Token(Token = "0x60002B2")]
		string? AppReceipt();
	}
	[Token(Token = "0x20000E9")]
	internal interface IAppleFetchProductsService
	{
		[Token(Token = "0x60002B3")]
		void SetNativeStore(INativeAppleStore nativeStore);

		[Token(Token = "0x60002B4")]
		Task<List<ProductDescription>> FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		[Token(Token = "0x60002B5")]
		void OnProductsFetched(string json);

		[Token(Token = "0x60002B6")]
		void OnProductDetailsRetrieveFailed(string errorMessage);
	}
	[Token(Token = "0x20000EA")]
	internal interface IAppleStoreCallbacks
	{
		[Token(Token = "0x60002B7")]
		void SetRestoreTransactionsCallback(Action<bool, string?>? successCallback);

		[Token(Token = "0x60002B8")]
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
	[Token(Token = "0x20000EB")]
	internal interface INativeAppleStore : INativeStore
	{
		[Token(Token = "0x60002B9")]
		void SetUnityPurchasingCallback(UnityPurchasingCallback asyncCallback);

		[Token(Token = "0x60002BA")]
		void RestoreTransactions();

		[Token(Token = "0x60002BB")]
		void AddTransactionObserver();

		[Token(Token = "0x60002BC")]
		void InterceptPromotionalPurchases();

		[Token(Token = "0x60002BD")]
		void DeallocateMemory(IntPtr pointer);

		[Token(Token = "0x60002BE")]
		void RefreshAppReceipt();
	}
	[Token(Token = "0x20000EC")]
	public enum AppStore
	{
		[Token(Token = "0x40001EC")]
		NotSpecified,
		[Token(Token = "0x40001ED")]
		GooglePlay,
		[Token(Token = "0x40001EE")]
		MacAppStore,
		[Token(Token = "0x40001EF")]
		AppleAppStore,
		[Token(Token = "0x40001F0")]
		fake
	}
	[Token(Token = "0x20000ED")]
	public interface INativeStore
	{
		[Token(Token = "0x60002BF")]
		void Connect();

		[Token(Token = "0x60002C0")]
		void FetchProducts(string json);

		[Token(Token = "0x60002C1")]
		void FetchExistingPurchases();

		[Token(Token = "0x60002C2")]
		void Purchase(string productJson, string optionsJson);

		[Token(Token = "0x60002C3")]
		void FinishTransaction(string productJSON, string transactionID);
	}
	[Token(Token = "0x20000EE")]
	internal delegate void UnityPurchasingCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus);
	[Token(Token = "0x20000EF")]
	public enum FakeStoreUIMode
	{
		[Token(Token = "0x40001F2")]
		Default,
		[Token(Token = "0x40001F3")]
		StandardUser,
		[Token(Token = "0x40001F4")]
		DeveloperUser
	}
	[Token(Token = "0x20000F0")]
	public static class DefaultStoreHelper
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string s_DefaultCustomStoreOverrideName;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2C1B174", Offset = "0x2C17174", VA = "0x2C1B174")]
		public static string GetDefaultStoreName()
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2C24BF4", Offset = "0x2C20BF4", VA = "0x2C24BF4")]
		private static string GetBuiltInDefaultStoreName()
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2C20F9C", Offset = "0x2C1CF9C", VA = "0x2C20F9C")]
		internal static AppStore GetDefaultBuiltInAppStore()
		{
			return default(AppStore);
		}
	}
	[Token(Token = "0x20000F1")]
	internal static class SelectedAndroidStoreHelper
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string k_BillingModeFileName;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2C24CE8", Offset = "0x2C20CE8", VA = "0x2C24CE8")]
		internal static string GetSelectedAndroidStoreName()
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2C24D6C", Offset = "0x2C20D6C", VA = "0x2C24D6C")]
		internal static AppStore GetSelectedAndroidStore()
		{
			return default(AppStore);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2C24E2C", Offset = "0x2C20E2C", VA = "0x2C24E2C")]
		private static StoreConfiguration LoadStoreConfiguration()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F2")]
	public enum StoreSpecificPurchaseErrorCode
	{
		[Token(Token = "0x40001F8")]
		SKErrorUnknown,
		[Token(Token = "0x40001F9")]
		SKErrorClientInvalid,
		[Token(Token = "0x40001FA")]
		SKErrorPaymentCancelled,
		[Token(Token = "0x40001FB")]
		SKErrorPaymentInvalid,
		[Token(Token = "0x40001FC")]
		SKErrorPaymentNotAllowed,
		[Token(Token = "0x40001FD")]
		SKErrorStoreProductNotAvailable,
		[Token(Token = "0x40001FE")]
		SKErrorCloudServicePermissionDenied,
		[Token(Token = "0x40001FF")]
		SKErrorCloudServiceNetworkConnectionFailed,
		[Token(Token = "0x4000200")]
		SKErrorCloudServiceRevoked,
		[Token(Token = "0x4000201")]
		BILLING_RESPONSE_RESULT_OK,
		[Token(Token = "0x4000202")]
		BILLING_RESPONSE_RESULT_USER_CANCELED,
		[Token(Token = "0x4000203")]
		BILLING_RESPONSE_RESULT_SERVICE_UNAVAILABLE,
		[Token(Token = "0x4000204")]
		BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE,
		[Token(Token = "0x4000205")]
		BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE,
		[Token(Token = "0x4000206")]
		BILLING_RESPONSE_RESULT_DEVELOPER_ERROR,
		[Token(Token = "0x4000207")]
		BILLING_RESPONSE_RESULT_ERROR,
		[Token(Token = "0x4000208")]
		BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED,
		[Token(Token = "0x4000209")]
		BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED,
		[Token(Token = "0x400020A")]
		IABHELPER_ERROR_BASE,
		[Token(Token = "0x400020B")]
		IABHELPER_REMOTE_EXCEPTION,
		[Token(Token = "0x400020C")]
		IABHELPER_BAD_RESPONSE,
		[Token(Token = "0x400020D")]
		IABHELPER_VERIFICATION_FAILED,
		[Token(Token = "0x400020E")]
		IABHELPER_SEND_INTENT_FAILED,
		[Token(Token = "0x400020F")]
		IABHELPER_USER_CANCELLED,
		[Token(Token = "0x4000210")]
		IABHELPER_UNKNOWN_PURCHASE_RESPONSE,
		[Token(Token = "0x4000211")]
		IABHELPER_MISSING_TOKEN,
		[Token(Token = "0x4000212")]
		IABHELPER_UNKNOWN_ERROR,
		[Token(Token = "0x4000213")]
		IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE,
		[Token(Token = "0x4000214")]
		IABHELPER_INVALID_CONSUMPTION,
		[Token(Token = "0x4000215")]
		Unknown
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public class StoreSpecificIds : IEnumerable, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> m_productIdDictionary;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("m_keys")]
		private List<string> m_storeNames;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_values")]
		[SerializeField]
		private List<string> m_productIds;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2C24F94", Offset = "0x2C20F94", VA = "0x2C24F94", Slot = "4")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2C1F0A8", Offset = "0x2C1B0A8", VA = "0x2C1F0A8")]
		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2C25028", Offset = "0x2C21028", VA = "0x2C25028")]
		public void Add(string id, params string[] stores)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2C250D4", Offset = "0x2C210D4", VA = "0x2C250D4", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2C25354", Offset = "0x2C21354", VA = "0x2C25354", Slot = "6")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2C25484", Offset = "0x2C21484", VA = "0x2C25484")]
		public StoreSpecificIds()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F4")]
	public class UnifiedReceipt
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Payload;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Store;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string TransactionID;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2C25560", Offset = "0x2C21560", VA = "0x2C25560")]
		public UnifiedReceipt()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	internal static class SerializationExtensions
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2C12504", Offset = "0x2C0E504", VA = "0x2C12504")]
		public static string TryGetString(this Dictionary<string, object> dic, string key)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	internal class JSONSerializer
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2C25568", Offset = "0x2C21568", VA = "0x2C25568")]
		public static string SerializeProductDef(ProductDefinition product)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2C25E34", Offset = "0x2C21E34", VA = "0x2C25E34")]
		public static string SerializeProductDefs(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2C26188", Offset = "0x2C22188", VA = "0x2C26188")]
		public static Dictionary<string, Dictionary<string, object>> DeserializeFetchedPurchases(string json)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2C26490", Offset = "0x2C22490", VA = "0x2C26490")]
		public static List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2C26CF0", Offset = "0x2C22CF0", VA = "0x2C26CF0")]
		public static List<ProductDescription> DeserializeProductDescriptionsFromFetchProductsSk2(string json)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2C274D4", Offset = "0x2C234D4", VA = "0x2C274D4")]
		public static Dictionary<string, object> DeserializePurchaseDetails(string purchaseDetailJson)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2C26A04", Offset = "0x2C22A04", VA = "0x2C26A04")]
		private static ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2C2557C", Offset = "0x2C2157C", VA = "0x2C2557C")]
		private static Dictionary<string, object> EncodeProductDef(ProductDefinition product)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F7")]
	internal static class ProductDefinitionExtensions
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2C277C4", Offset = "0x2C237C4", VA = "0x2C277C4")]
		internal static List<ProductDefinition> DecodeJSON(this List<object> productsList, string storeName)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	internal static class ProductTypeExtensions
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2C273A0", Offset = "0x2C233A0", VA = "0x2C273A0")]
		internal static ProductType ToProductType(this string productType)
		{
			return default(ProductType);
		}
	}
	[Token(Token = "0x20000F9")]
	internal static class UnifiedReceiptFormatter
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2C11540", Offset = "0x2C0D540", VA = "0x2C11540")]
		internal static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName)
		{
			return null;
		}
	}
}
namespace UnityEngine.Purchasing.Utilities
{
	[Token(Token = "0x20000FA")]
	internal static class UnityUtilContainer
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UnityEngine.Purchasing.Extension.UnityUtil? s_UnityUtilInstance;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2C27F1C", Offset = "0x2C23F1C", VA = "0x2C27F1C")]
		internal static UnityEngine.Purchasing.Extension.UnityUtil Instance()
		{
			return null;
		}
	}
	[Token(Token = "0x20000FB")]
	internal static class UnityUtilDependencyInjector
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2C27F84", Offset = "0x2C23F84", VA = "0x2C27F84")]
		internal static UnityEngine.Purchasing.Extension.UnityUtil CreateUnityUtils()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2C281E0", Offset = "0x2C241E0", VA = "0x2C281E0")]
		private static global::Purchasing.Utilities.MonoBehaviourUtil CreateMonoBehaviourUtil()
		{
			return null;
		}
	}
}
namespace UnityEngine.Purchasing.Telemetry
{
	[Token(Token = "0x20000FC")]
	internal interface ITelemetryDiagnostics
	{
		[Token(Token = "0x60002E4")]
		void SendDiagnostic(string diagnosticName, Exception e);
	}
	[Token(Token = "0x20000FD")]
	internal interface ITelemetryDiagnosticsInstanceWrapper
	{
		[Token(Token = "0x60002E5")]
		void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance);

		[Token(Token = "0x60002E6")]
		void SendDiagnostic(string diagnosticName, string diagnosticException);
	}
	[Token(Token = "0x20000FE")]
	internal struct TelemetryDiagnosticParams
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal string name;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string exception;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2C282B4", Offset = "0x2C242B4", VA = "0x2C282B4")]
		internal TelemetryDiagnosticParams(string diagnosticName, string diagnosticException)
		{
		}
	}
	[Token(Token = "0x20000FF")]
	internal class TelemetryDiagnostics : ITelemetryDiagnostics
	{
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2C282BC", Offset = "0x2C242BC", VA = "0x2C282BC")]
		[Preserve]
		internal TelemetryDiagnostics(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2C282E4", Offset = "0x2C242E4", VA = "0x2C282E4", Slot = "4")]
		public void SendDiagnostic(string diagnosticName, Exception e)
		{
		}
	}
	[Token(Token = "0x2000100")]
	internal class TelemetryDiagnosticsInstanceWrapper : ITelemetryDiagnosticsInstanceWrapper
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IDiagnostics m_Instance;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ILogger m_Logger;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Uniject.IUtil m_Util;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly TelemetryQueue<TelemetryDiagnosticParams> m_Queue;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2C284A8", Offset = "0x2C244A8", VA = "0x2C284A8")]
		internal TelemetryDiagnosticsInstanceWrapper(ILogger logger, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2C2858C", Offset = "0x2C2458C", VA = "0x2C2858C", Slot = "4")]
		public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2C285E4", Offset = "0x2C245E4", VA = "0x2C285E4", Slot = "5")]
		public void SendDiagnostic(string diagnosticName, string diagnosticException)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2C28670", Offset = "0x2C24670", VA = "0x2C28670")]
		private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2C287A8", Offset = "0x2C247A8", VA = "0x2C287A8")]
		private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams)
		{
		}
	}
	[Token(Token = "0x2000102")]
	internal class IapTelemetryException : Exception
	{
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2C28964", Offset = "0x2C24964", VA = "0x2C28964")]
		public IapTelemetryException(string message)
		{
		}
	}
	[Token(Token = "0x2000103")]
	internal interface ITelemetryMetricEvent
	{
		[Token(Token = "0x60002F2")]
		void StartMetric();

		[Token(Token = "0x60002F3")]
		void StopAndSendMetric();
	}
	[Token(Token = "0x2000104")]
	internal interface ITelemetryMetricsInstanceWrapper
	{
		[Token(Token = "0x60002F4")]
		void SetMetricsInstance(IMetrics metricsInstance);

		[Token(Token = "0x60002F5")]
		void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds);
	}
	[Token(Token = "0x2000105")]
	internal interface ITelemetryMetricsService
	{
		[Token(Token = "0x60002F6")]
		void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition);
	}
	[Token(Token = "0x2000106")]
	internal struct TelemetryMetricDefinition
	{
		[Token(Token = "0x17000067")]
		public readonly TelemetryMetricTypes MetricType
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x2C289CC", Offset = "0x2C249CC", VA = "0x2C289CC")]
			[CompilerGenerated]
			get
			{
				return default(TelemetryMetricTypes);
			}
		}

		[Token(Token = "0x17000068")]
		public readonly string MetricName
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x2C289D4", Offset = "0x2C249D4", VA = "0x2C289D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2C289DC", Offset = "0x2C249DC", VA = "0x2C289DC")]
		public TelemetryMetricDefinition(string metricName, TelemetryMetricTypes metricType = TelemetryMetricTypes.Histogram)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2C289E8", Offset = "0x2C249E8", VA = "0x2C289E8")]
		public static implicit operator TelemetryMetricDefinition(string name)
		{
			return default(TelemetryMetricDefinition);
		}
	}
	[Token(Token = "0x2000107")]
	internal static class TelemetryMetricDefinitions
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly TelemetryMetricDefinition confirmSubscriptionPriceChangeName;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly TelemetryMetricDefinition continuePromotionalPurchasesName;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly TelemetryMetricDefinition dequeueQueryProductsTimeName;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static readonly TelemetryMetricDefinition dequeueQueryPurchasesTimeName;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static readonly TelemetryMetricDefinition fetchStorePromotionOrderName;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal static readonly TelemetryMetricDefinition fetchStorePromotionVisibilityName;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal static readonly TelemetryMetricDefinition initPurchaseName;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal static readonly TelemetryMetricDefinition packageInitTimeName;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal static readonly TelemetryMetricDefinition presentCodeRedemptionSheetName;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal static readonly TelemetryMetricDefinition refreshAppReceiptName;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal static readonly TelemetryMetricDefinition restoreTransactionName;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal static readonly TelemetryMetricDefinition fetchProductsName;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal static readonly TelemetryMetricDefinition setStorePromotionOrderName;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal static readonly TelemetryMetricDefinition setStorePromotionVisibilityName;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal static readonly TelemetryMetricDefinition upgradeDowngradeSubscriptionName;
	}
	[Token(Token = "0x2000108")]
	internal class TelemetryMetricEvent : ITelemetryMetricEvent
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TelemetryMetricTypes m_MetricType;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string m_MetricName;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2C28C6C", Offset = "0x2C24C6C", VA = "0x2C28C6C")]
		internal TelemetryMetricEvent(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2C28CF8", Offset = "0x2C24CF8", VA = "0x2C28CF8", Slot = "4")]
		public void StartMetric()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2C28D7C", Offset = "0x2C24D7C", VA = "0x2C28D7C", Slot = "5")]
		public void StopAndSendMetric()
		{
		}
	}
	[Token(Token = "0x2000109")]
	internal struct TelemetryMetricParams
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal TelemetryMetricTypes type;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal double timeSeconds;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2C28EE8", Offset = "0x2C24EE8", VA = "0x2C28EE8")]
		internal TelemetryMetricParams(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
		{
		}
	}
	[Token(Token = "0x200010A")]
	internal class TelemetryMetricsInstanceWrapper : ITelemetryMetricsInstanceWrapper
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IMetrics m_Instance;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ILogger m_Logger;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Uniject.IUtil m_Util;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly TelemetryQueue<TelemetryMetricParams> m_Queue;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2C28EF8", Offset = "0x2C24EF8", VA = "0x2C28EF8")]
		internal TelemetryMetricsInstanceWrapper(ILogger logger, Uniject.IUtil util)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2C28FDC", Offset = "0x2C24FDC", VA = "0x2C28FDC", Slot = "4")]
		public void SetMetricsInstance(IMetrics metricsInstance)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2C29044", Offset = "0x2C25044", VA = "0x2C29044", Slot = "5")]
		public void SendMetric(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2C290F0", Offset = "0x2C250F0", VA = "0x2C290F0")]
		private void SendMetricOnMainThread(TelemetryMetricParams metricParams)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2C2922C", Offset = "0x2C2522C", VA = "0x2C2922C")]
		private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2C29358", Offset = "0x2C25358", VA = "0x2C29358")]
		private void SendMetricByType(TelemetryMetricParams metricParams)
		{
		}
	}
	[Token(Token = "0x200010C")]
	internal class TelemetryMetricsService : ITelemetryMetricsService
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2C29540", Offset = "0x2C25540", VA = "0x2C29540")]
		public TelemetryMetricsService(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2C29568", Offset = "0x2C25568", VA = "0x2C29568", Slot = "4")]
		public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2C2972C", Offset = "0x2C2572C", VA = "0x2C2972C", Slot = "5")]
		public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition)
		{
			return null;
		}
	}
	[Token(Token = "0x200010D")]
	internal enum TelemetryMetricTypes
	{
		[Token(Token = "0x4000246")]
		Gauge,
		[Token(Token = "0x4000247")]
		Sum,
		[Token(Token = "0x4000248")]
		Histogram
	}
	[Token(Token = "0x200010E")]
	internal class TelemetryQueue<TTelemetryEventParams>
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<TTelemetryEventParams> m_SendTelemetryEvent;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ConcurrentQueue<TTelemetryEventParams> m_Queue;

		[Token(Token = "0x600030B")]
		public TelemetryQueue(Action<TTelemetryEventParams> sendTelemetryEvent)
		{
		}

		[Token(Token = "0x600030C")]
		internal void QueueEvent(TTelemetryEventParams telemetryEvent)
		{
		}

		[Token(Token = "0x600030D")]
		internal void SendQueuedEvents()
		{
		}
	}
}
namespace UnityEngine.Purchasing.Exceptions
{
	[Token(Token = "0x200010F")]
	internal class GoogleFetchProductException : FetchProductsException
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2C298F0", Offset = "0x2C258F0", VA = "0x2C298F0")]
		public GoogleFetchProductException(GoogleFetchProductsFailureReason failureReason, GoogleBillingResponseCode responseCode, ProductFetchFailureDescription failureDescription)
		{
		}
	}
	[Token(Token = "0x2000110")]
	internal class FetchProductsException : IapException
	{
		[Token(Token = "0x17000069")]
		internal ProductFetchFailureDescription FailureDescription
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2C2994C", Offset = "0x2C2594C", VA = "0x2C2994C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2C2991C", Offset = "0x2C2591C", VA = "0x2C2991C")]
		public FetchProductsException(ProductFetchFailureDescription failureDescription)
		{
		}
	}
}
namespace UnityEngine.Purchasing.Models
{
	[Token(Token = "0x2000111")]
	internal static class AndroidJavaObjectExtensions
	{
		[Token(Token = "0x6000311")]
		internal static IEnumerable<T> Enumerate<T>(this AndroidJavaObject androidJavaList)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2C29954", Offset = "0x2C25954", VA = "0x2C29954")]
		internal static IEnumerable<AndroidJavaObject> Enumerate(this AndroidJavaObject androidJavaList)
		{
			return null;
		}
	}
	[Token(Token = "0x2000113")]
	internal interface IGoogleBillingResult
	{
		[Token(Token = "0x1700006A")]
		GoogleBillingResponseCode responseCode
		{
			[Token(Token = "0x6000315")]
			get;
		}

		[Token(Token = "0x1700006B")]
		string debugMessage
		{
			[Token(Token = "0x6000316")]
			get;
		}
	}
	[Token(Token = "0x2000114")]
	internal enum GoogleBillingResponseCode
	{
		[Token(Token = "0x4000250")]
		ServiceTimeout = -3,
		[Token(Token = "0x4000251")]
		FeatureNotSupported = -2,
		[Token(Token = "0x4000252")]
		ServiceDisconnected = -1,
		[Token(Token = "0x4000253")]
		Ok = 0,
		[Token(Token = "0x4000254")]
		UserCanceled = 1,
		[Token(Token = "0x4000255")]
		ServiceUnavailable = 2,
		[Token(Token = "0x4000256")]
		BillingUnavailable = 3,
		[Token(Token = "0x4000257")]
		ItemUnavailable = 4,
		[Token(Token = "0x4000258")]
		DeveloperError = 5,
		[Token(Token = "0x4000259")]
		FatalError = 6,
		[Token(Token = "0x400025A")]
		ItemAlreadyOwned = 7,
		[Token(Token = "0x400025B")]
		ItemNotOwned = 8,
		[Token(Token = "0x400025C")]
		NetworkError = 12
	}
	[Token(Token = "0x2000115")]
	internal enum GoogleFetchProductsFailureReason
	{
		[Token(Token = "0x400025E")]
		BillingServiceDisconnected,
		[Token(Token = "0x400025F")]
		BillingServiceUnavailable,
		[Token(Token = "0x4000260")]
		Unknown
	}
}
namespace UnityEngine.Purchasing.Interfaces
{
	[Token(Token = "0x2000116")]
	internal interface IRestoreTransactionsUseCase
	{
		[Token(Token = "0x6000317")]
		void RestoreTransactions(Action<bool, string?>? callback);
	}
	[Token(Token = "0x2000117")]
	internal interface IBillingClientStateListener
	{
		[Token(Token = "0x6000318")]
		void RegisterOnConnected(Action onConnected);

		[Token(Token = "0x6000319")]
		void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected);
	}
	[Token(Token = "0x2000118")]
	internal interface IGoogleBillingClient
	{
		[Token(Token = "0x600031A")]
		void StartConnection(IBillingClientStateListener billingClientStateListener);

		[Token(Token = "0x600031B")]
		void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse);

		[Token(Token = "0x600031C")]
		void QueryProductDetailsAsync(List<string> skus, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction);

		[Token(Token = "0x600031D")]
		AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode);

		[Token(Token = "0x600031E")]
		void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume);

		[Token(Token = "0x600031F")]
		void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge);
	}
	[Token(Token = "0x2000119")]
	internal interface IGooglePlayStoreService
	{
		[Token(Token = "0x6000320")]
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed);

		[Token(Token = "0x6000321")]
		void Purchase(ProductDefinition product);

		[Token(Token = "0x6000322")]
		Task FinishTransaction(ProductDefinition? product, string? purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);

		[Token(Token = "0x6000323")]
		void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed, Action<string?> onQueryPurchaseFailed);
	}
	[Token(Token = "0x200011A")]
	internal interface IGooglePurchase
	{
		[Token(Token = "0x1700006C")]
		int purchaseState
		{
			[Token(Token = "0x6000324")]
			get;
		}

		[Token(Token = "0x1700006D")]
		List<string> skus
		{
			[Token(Token = "0x6000325")]
			get;
		}

		[Token(Token = "0x1700006E")]
		string receipt
		{
			[Token(Token = "0x6000326")]
			get;
		}

		[Token(Token = "0x1700006F")]
		string? obfuscatedAccountId
		{
			[Token(Token = "0x6000327")]
			get;
		}

		[Token(Token = "0x17000070")]
		string? obfuscatedProfileId
		{
			[Token(Token = "0x6000328")]
			get;
		}

		[Token(Token = "0x17000071")]
		string purchaseToken
		{
			[Token(Token = "0x6000329")]
			get;
		}

		[Token(Token = "0x17000072")]
		IEnumerable<ProductDescription> productDescriptions
		{
			[Token(Token = "0x600032A")]
			get;
		}

		[Token(Token = "0x17000073")]
		string? sku
		{
			[Token(Token = "0x600032B")]
			get;
		}

		[Token(Token = "0x600032C")]
		bool IsAcknowledged();

		[Token(Token = "0x600032D")]
		bool IsPurchased();

		[Token(Token = "0x600032E")]
		bool IsPending();
	}
	[Token(Token = "0x200011B")]
	internal interface IQueryProductDetailsService
	{
		[Token(Token = "0x600032F")]
		Task<List<AndroidJavaObject>> QueryProductDetails(ProductDefinition product);

		[Token(Token = "0x6000330")]
		Task<List<ProductDescription>> QueryProductDescriptions(IReadOnlyCollection<ProductDefinition> products);
	}
}
namespace UnityEngine.Purchasing.Extension
{
	[Token(Token = "0x200011C")]
	public interface IStoreProductsCallback
	{
		[Token(Token = "0x6000331")]
		void OnProductsFetched(IReadOnlyList<ProductDescription> products);

		[Token(Token = "0x6000332")]
		void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription);
	}
	[Token(Token = "0x200011D")]
	internal interface IInternalStore : IStore
	{
		[Token(Token = "0x6000333")]
		void SetStoreConnectionState(ConnectionState connectionState);
	}
	[Token(Token = "0x200011E")]
	internal interface IProductCache
	{
		[Token(Token = "0x6000334")]
		void Add(List<Product> product);

		[Token(Token = "0x6000335")]
		ReadOnlyObservableCollection<Product> GetProducts();

		[Token(Token = "0x6000336")]
		Product? Find(string? productId);

		[Token(Token = "0x6000337")]
		Product FindOrDefault(string? productId);
	}
	[Token(Token = "0x200011F")]
	internal interface IStore
	{
		[Token(Token = "0x6000338")]
		void Connect();

		[Token(Token = "0x6000339")]
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		[Token(Token = "0x600033A")]
		void FetchPurchases();

		[Token(Token = "0x600033B")]
		void Purchase(ICart cart);

		[Token(Token = "0x600033C")]
		void FinishTransaction(PendingOrder pendingOrder);

		[Token(Token = "0x600033D")]
		void SetProductsCallback(IStoreProductsCallback productsCallback);

		[Token(Token = "0x600033E")]
		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback);

		[Token(Token = "0x600033F")]
		void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

		[Token(Token = "0x6000340")]
		void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

		[Token(Token = "0x6000341")]
		void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback);

		[Token(Token = "0x6000342")]
		void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback);

		[Token(Token = "0x6000343")]
		void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback);
	}
	[Token(Token = "0x2000120")]
	internal class ProductCache : IProductCache
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ObservableCollection<Product> m_Products;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ReadOnlyObservableCollection<Product> m_ProductsReadOnly;

		[Token(Token = "0x17000074")]
		public Dictionary<string, Product> productsById
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x2C2999C", Offset = "0x2C2599C", VA = "0x2C2999C", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private Dictionary<string, Product> productsByStoreSpecificId
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x2C299A4", Offset = "0x2C259A4", VA = "0x2C299A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2C299AC", Offset = "0x2C259AC", VA = "0x2C299AC")]
		internal ProductCache()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2C29B24", Offset = "0x2C25B24", VA = "0x2C29B24", Slot = "4")]
		public void Add(List<Product> products)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2C29C54", Offset = "0x2C25C54", VA = "0x2C29C54", Slot = "9")]
		public void Add(Product product)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2C29DD0", Offset = "0x2C25DD0", VA = "0x2C29DD0", Slot = "5")]
		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2C29DD8", Offset = "0x2C25DD8", VA = "0x2C29DD8", Slot = "7")]
		public Product FindOrDefault(string? productId)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2C29D40", Offset = "0x2C25D40", VA = "0x2C29D40", Slot = "6")]
		public Product? Find(string? productId)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2C29DFC", Offset = "0x2C25DFC", VA = "0x2C29DFC")]
		private bool HasId(string? productId)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2C29E68", Offset = "0x2C25E68", VA = "0x2C29E68")]
		private bool HasStoreSpecificId(string? productId)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000121")]
	public class ProductDescription
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProductType type;

		[Token(Token = "0x17000076")]
		public string storeSpecificId
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x2C29F4C", Offset = "0x2C25F4C", VA = "0x2C29F4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x2C29F54", Offset = "0x2C25F54", VA = "0x2C29F54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public ProductMetadata metadata
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x2C29F5C", Offset = "0x2C25F5C", VA = "0x2C29F5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x2C29F64", Offset = "0x2C25F64", VA = "0x2C29F64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public string receipt
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x2C29F6C", Offset = "0x2C25F6C", VA = "0x2C29F6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x2C29F74", Offset = "0x2C25F74", VA = "0x2C29F74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public string transactionId
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x2C29F7C", Offset = "0x2C25F7C", VA = "0x2C29F7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x2C29F84", Offset = "0x2C25F84", VA = "0x2C29F84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2C29ED4", Offset = "0x2C25ED4", VA = "0x2C29ED4")]
		public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2C26C9C", Offset = "0x2C22C9C", VA = "0x2C26C9C")]
		public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2C29F18", Offset = "0x2C25F18", VA = "0x2C29F18")]
		public ProductDescription(string id, ProductMetadata metadata)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2C29F8C", Offset = "0x2C25F8C", VA = "0x2C29F8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	public abstract class Store : IStore
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected IStoreProductsCallback? ProductsCallback;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected IStorePurchaseFetchCallback? PurchaseFetchCallback;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected IStorePurchaseCallback? PurchaseCallback;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected IStorePurchaseConfirmCallback? ConfirmCallback;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected IStoreCheckEntitlementCallback? EntitlementCallback;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected IStoreConnectCallback? ConnectCallback;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IOnEntitlementRevokedCallback? EntitlementRevokedCallback;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal IProductCache ProductCache;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2C0BEE0", Offset = "0x2C07EE0", VA = "0x2C0BEE0")]
		protected Store()
		{
		}

		[Token(Token = "0x600035B")]
		public abstract void Connect();

		[Token(Token = "0x600035C")]
		public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		[Token(Token = "0x600035D")]
		public abstract void FetchPurchases();

		[Token(Token = "0x600035E")]
		public abstract void Purchase(ICart cart);

		[Token(Token = "0x600035F")]
		public abstract void FinishTransaction(PendingOrder pendingOrder);

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2C2A120", Offset = "0x2C26120", VA = "0x2C2A120", Slot = "21")]
		public virtual void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2C2A128", Offset = "0x2C26128", VA = "0x2C2A128", Slot = "22")]
		public virtual void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2C2A130", Offset = "0x2C26130", VA = "0x2C2A130", Slot = "23")]
		public virtual void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x2C2A138", Offset = "0x2C26138", VA = "0x2C2A138", Slot = "24")]
		public virtual void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2C2A140", Offset = "0x2C26140", VA = "0x2C2A140", Slot = "25")]
		public virtual void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2C2A148", Offset = "0x2C26148", VA = "0x2C2A148", Slot = "26")]
		public virtual void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2C2A150", Offset = "0x2C26150", VA = "0x2C2A150", Slot = "27")]
		public virtual void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback)
		{
		}
	}
	[Token(Token = "0x2000123")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreConfiguration
	{
	}
}
namespace UnityEngine.Purchasing.UseCases
{
	[Token(Token = "0x2000124")]
	internal class FetchStorePromotionOrderUseCase : IFetchStorePromotionOrderUseCase
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2C2A158", Offset = "0x2C26158", VA = "0x2C2A158")]
		[Preserve]
		internal FetchStorePromotionOrderUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}
	}
	[Token(Token = "0x2000125")]
	internal class FetchStorePromotionVisibilityUseCase : IFetchStorePromotionVisibilityUseCase
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2C2A184", Offset = "0x2C26184", VA = "0x2C2A184")]
		[Preserve]
		internal FetchStorePromotionVisibilityUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}
	}
	[Token(Token = "0x2000126")]
	internal class GetIntroductoryPriceDictionaryUseCase : IGetIntroductoryPriceDictionaryUseCase
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleFetchProductsService m_FetchProductsService;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2C2A1B0", Offset = "0x2C261B0", VA = "0x2C2A1B0")]
		[Preserve]
		internal GetIntroductoryPriceDictionaryUseCase(IAppleFetchProductsService fetchProductsService)
		{
		}
	}
	[Token(Token = "0x2000127")]
	internal class GetProductDetailsUseCase : IGetProductDetailsUseCase
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleFetchProductsService m_FetchProductsService;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2C2A1D8", Offset = "0x2C261D8", VA = "0x2C2A1D8")]
		[Preserve]
		internal GetProductDetailsUseCase(IAppleFetchProductsService fetchProductsService)
		{
		}
	}
	[Token(Token = "0x2000128")]
	internal class SetStorePromotionOrderUseCase : ISetStorePromotionOrderUseCase
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2C2A200", Offset = "0x2C26200", VA = "0x2C2A200")]
		[Preserve]
		internal SetStorePromotionOrderUseCase(INativeAppleStore nativeStore)
		{
		}
	}
	[Token(Token = "0x2000129")]
	internal class SetStorePromotionVisibilityUseCase : ISetStorePromotionVisibilityUseCase
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2C2A228", Offset = "0x2C26228", VA = "0x2C2A228")]
		[Preserve]
		internal SetStorePromotionVisibilityUseCase(INativeAppleStore nativeStore, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}
	}
	[Token(Token = "0x200012A")]
	internal class AppleRefreshAppReceiptUseCase : IRefreshAppReceiptUseCase
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2C2A254", Offset = "0x2C26254", VA = "0x2C2A254")]
		[Preserve]
		internal AppleRefreshAppReceiptUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2C2A280", Offset = "0x2C26280", VA = "0x2C2A280", Slot = "4")]
		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
		}
	}
	[Token(Token = "0x200012B")]
	internal class AppleRestoreTransactionsUseCase : IRestoreTransactionsUseCase
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2C2A32C", Offset = "0x2C2632C", VA = "0x2C2A32C")]
		[Preserve]
		internal AppleRestoreTransactionsUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2C2A358", Offset = "0x2C26358", VA = "0x2C2A358", Slot = "4")]
		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}
	}
	[Token(Token = "0x200012C")]
	internal class AppReceiptUseCase : IAppReceiptUseCase
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleAppReceiptViewer m_AppleAppReceiptViewer;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2C2A478", Offset = "0x2C26478", VA = "0x2C2A478")]
		[Preserve]
		internal AppReceiptUseCase(IAppleAppReceiptViewer appleAppReceiptViewer)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2C2A4A0", Offset = "0x2C264A0", VA = "0x2C2A4A0", Slot = "4")]
		public string? AppReceipt()
		{
			return null;
		}
	}
	[Token(Token = "0x200012D")]
	internal class ContinuePromotionalPurchasesUseCase : IContinuePromotionalPurchasesUseCase
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2C2A540", Offset = "0x2C26540", VA = "0x2C2A540")]
		[Preserve]
		internal ContinuePromotionalPurchasesUseCase(INativeAppleStore nativeStore)
		{
		}
	}
	[Token(Token = "0x200012E")]
	internal class PresentCodeRedemptionSheetUseCase : IPresentCodeRedemptionSheetUseCase
	{
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2C2A568", Offset = "0x2C26568", VA = "0x2C2A568")]
		[Preserve]
		internal PresentCodeRedemptionSheetUseCase(INativeAppleStore nativeStore)
		{
		}
	}
	[Token(Token = "0x200012F")]
	internal class SetPromotionalPurchaseInterceptorCallbackUseCase : ISetPromotionalPurchaseInterceptorCallbackUseCase
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2C2A590", Offset = "0x2C26590", VA = "0x2C2A590")]
		[Preserve]
		internal SetPromotionalPurchaseInterceptorCallbackUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}
	}
	[Token(Token = "0x2000130")]
	internal class SimulateAskToBuyUseCase : ISimulateAskToBuyUseCase
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2C2A5B8", Offset = "0x2C265B8", VA = "0x2C2A5B8")]
		[Preserve]
		internal SimulateAskToBuyUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}
	}
	[Token(Token = "0x2000131")]
	internal class CanMakePaymentsUseCase : ICanMakePaymentsUseCase
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly INativeAppleStore m_NativeAppleStore;

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2C2A5E0", Offset = "0x2C265E0", VA = "0x2C2A5E0")]
		[Preserve]
		internal CanMakePaymentsUseCase(INativeAppleStore nativeStore)
		{
		}
	}
	[Token(Token = "0x2000132")]
	internal class SetAppAccountTokenUseCase : ISetAppAccountTokenUseCase
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2C2A608", Offset = "0x2C26608", VA = "0x2C2A608")]
		[Preserve]
		internal SetAppAccountTokenUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}
	}
}
namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	[Token(Token = "0x2000133")]
	internal interface IFetchStorePromotionOrderUseCase
	{
	}
	[Token(Token = "0x2000134")]
	internal interface IFetchStorePromotionVisibilityUseCase
	{
	}
	[Token(Token = "0x2000135")]
	internal interface IGetIntroductoryPriceDictionaryUseCase
	{
	}
	[Token(Token = "0x2000136")]
	internal interface IGetProductDetailsUseCase
	{
	}
	[Token(Token = "0x2000137")]
	internal interface ISetStorePromotionOrderUseCase
	{
	}
	[Token(Token = "0x2000138")]
	internal interface ISetStorePromotionVisibilityUseCase
	{
	}
	[Token(Token = "0x2000139")]
	internal interface IAppReceiptUseCase
	{
		[Token(Token = "0x6000379")]
		string? AppReceipt();
	}
	[Token(Token = "0x200013A")]
	internal interface IContinuePromotionalPurchasesUseCase
	{
	}
	[Token(Token = "0x200013B")]
	internal interface IPresentCodeRedemptionSheetUseCase
	{
	}
	[Token(Token = "0x200013C")]
	internal interface IRefreshAppReceiptUseCase
	{
		[Token(Token = "0x600037A")]
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
	[Token(Token = "0x200013D")]
	internal interface ISetPromotionalPurchaseInterceptorCallbackUseCase
	{
	}
	[Token(Token = "0x200013E")]
	internal interface ISimulateAskToBuyUseCase
	{
	}
	[Token(Token = "0x200013F")]
	internal class ClearAppleTransactionLogsUseCase : IClearAppleTransactionLogsUseCase
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2C2A630", Offset = "0x2C26630", VA = "0x2C2A630")]
		[Preserve]
		internal ClearAppleTransactionLogsUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}
	}
	[Token(Token = "0x2000140")]
	internal interface ICanMakePaymentsUseCase
	{
	}
	[Token(Token = "0x2000141")]
	internal interface IClearAppleTransactionLogsUseCase
	{
	}
	[Token(Token = "0x2000142")]
	internal interface ISetAppAccountTokenUseCase
	{
	}
}
namespace UnityEngine.Purchasing.Services
{
	[Token(Token = "0x2000143")]
	internal class AppleStoreExtendedProductService : ProductService
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly IFetchStorePromotionOrderUseCase m_FetchStorePromotionOrderUseCase;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly IFetchStorePromotionVisibilityUseCase m_FetchStorePromotionVisibilityUseCase;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IGetIntroductoryPriceDictionaryUseCase m_GetIntroductoryPriceDictionaryUseCase;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly IGetProductDetailsUseCase m_GetProductDetailsUseCase;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly ISetStorePromotionOrderUseCase m_SetStorePromotionOrderUseCase;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly ISetStorePromotionVisibilityUseCase m_SetStorePromotionVisibilityUseCase;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2C2A658", Offset = "0x2C26658", VA = "0x2C2A658")]
		[Preserve]
		internal AppleStoreExtendedProductService(IFetchStorePromotionOrderUseCase fetchStorePromotionOrderUseCase, IFetchStorePromotionVisibilityUseCase fetchStorePromotionVisibilityUseCase, IGetIntroductoryPriceDictionaryUseCase getIntroductoryPriceDictionaryUseCase, IGetProductDetailsUseCase getProductDetailsUseCase, ISetStorePromotionOrderUseCase setStorePromotionOrderUseCase, ISetStorePromotionVisibilityUseCase setStorePromotionVisibilityUseCase, IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper)
		{
		}
	}
	[Token(Token = "0x2000144")]
	internal class AppleStoreExtendedPurchaseService : PurchaseService, IAppleStoreExtendedPurchaseService
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly IAppReceiptUseCase m_AppReceiptUseCase;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly IContinuePromotionalPurchasesUseCase m_ContinuePromotionalPurchasesUseCase;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly IPresentCodeRedemptionSheetUseCase m_PresentCodeRedemptionSheetUseCase;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly ISetPromotionalPurchaseInterceptorCallbackUseCase m_SetPromotionalPurchaseInterceptorCallbackUseCase;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly ISimulateAskToBuyUseCase m_SimulateAskToBuyUseCase;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly IOnEntitlementRevokedUseCase m_OnEntitlementRevokedUseCase;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly IRefreshAppReceiptUseCase m_RefreshAppReceiptUseCase;

		[Token(Token = "0x1700007A")]
		public string? appReceipt
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x2C2ADF4", Offset = "0x2C26DF4", VA = "0x2C2ADF4", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2C2A704", Offset = "0x2C26704", VA = "0x2C2A704")]
		[Preserve]
		internal AppleStoreExtendedPurchaseService(IAppReceiptUseCase appReceiptUseCase, IContinuePromotionalPurchasesUseCase continuePromotionalPurchasesUseCase, IPresentCodeRedemptionSheetUseCase presentCodeRedemptionSheetUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, ISetPromotionalPurchaseInterceptorCallbackUseCase setPromotionalPurchaseInterceptorCallbackUseCase, ISimulateAskToBuyUseCase simulateAskToBuyUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IOnEntitlementRevokedUseCase onEntitlementRevokedUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient, IRefreshAppReceiptUseCase refreshAppReceiptUseCase)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2C2A87C", Offset = "0x2C2687C", VA = "0x2C2A87C")]
		private void OnEntitlementOnEntitlementRevokedUseCaseOnOnEntitlementRevoked(string productId)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2C2AC9C", Offset = "0x2C26C9C", VA = "0x2C2AC9C")]
		private static bool DoesOrderContainAnyRevokedProductIds(string productId, Order order)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2C2AE94", Offset = "0x2C26E94", VA = "0x2C2AE94", Slot = "24")]
		protected override void RestoreTransactionsInternal(Action<bool, string?>? callback)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2C2AF3C", Offset = "0x2C26F3C", VA = "0x2C2AF3C", Slot = "26")]
		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
		}
	}
	[Token(Token = "0x2000146")]
	internal class AppleStoreExtendedService : StoreService
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ICanMakePaymentsUseCase m_CanMakePaymentsUseCase;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IClearAppleTransactionLogsUseCase m_ClearAppleTransactionLogsUseCase;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ISetAppAccountTokenUseCase m_SetAppAccountTokenUseCase;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2C2B018", Offset = "0x2C27018", VA = "0x2C2B018")]
		[Preserve]
		internal AppleStoreExtendedService(ICanMakePaymentsUseCase canMakePaymentsUseCase, IClearAppleTransactionLogsUseCase clearAppleTransactionLogsUseCase, ISetAppAccountTokenUseCase setAppAccountTokenUseCase, IStoreConnectUseCase connectUseCase)
		{
		}
	}
}
