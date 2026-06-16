using System;
using System.Reflection;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Purchasing;

[Token(Token = "0x2000002")]
internal class iOSStoreBindings : UnityEngine.Purchasing.INativeAppleStore, INativeStore
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2C02064", Offset = "0x2BFE064", VA = "0x2C02064", Slot = "4")]
	public void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2C0209C", Offset = "0x2BFE09C", VA = "0x2C0209C", Slot = "5")]
	public void RestoreTransactions()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2C020D4", Offset = "0x2BFE0D4", VA = "0x2C020D4", Slot = "10")]
	public void Connect()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2C0210C", Offset = "0x2BFE10C", VA = "0x2C0210C", Slot = "6")]
	public void AddTransactionObserver()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2C02144", Offset = "0x2BFE144", VA = "0x2C02144", Slot = "11")]
	public void FetchProducts(string json)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2C0217C", Offset = "0x2BFE17C", VA = "0x2C0217C", Slot = "12")]
	public void FetchExistingPurchases()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2C021B4", Offset = "0x2BFE1B4", VA = "0x2C021B4", Slot = "13")]
	public void Purchase(string productJSON, string developerPayload)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2C021EC", Offset = "0x2BFE1EC", VA = "0x2C021EC", Slot = "14")]
	public void FinishTransaction(string productJSON, string transactionID)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2C02224", Offset = "0x2BFE224", VA = "0x2C02224", Slot = "7")]
	public void InterceptPromotionalPurchases()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2C0225C", Offset = "0x2BFE25C", VA = "0x2C0225C", Slot = "8")]
	public void DeallocateMemory(IntPtr pointer)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2C02294", Offset = "0x2BFE294", VA = "0x2C02294", Slot = "9")]
	public void RefreshAppReceipt()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2C022CC", Offset = "0x2BFE2CC", VA = "0x2C022CC")]
	public iOSStoreBindings()
	{
	}
}
