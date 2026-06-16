using System;
using System.Reflection;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Purchasing;

[Token(Token = "0x2000002")]
internal class OSXStoreBindings : UnityEngine.Purchasing.INativeAppleStore, INativeStore
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2C01DF4", Offset = "0x2BFDDF4", VA = "0x2C01DF4", Slot = "4")]
	public void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2C01E2C", Offset = "0x2BFDE2C", VA = "0x2C01E2C", Slot = "5")]
	public void RestoreTransactions()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2C01E64", Offset = "0x2BFDE64", VA = "0x2C01E64", Slot = "10")]
	public void Connect()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2C01E9C", Offset = "0x2BFDE9C", VA = "0x2C01E9C", Slot = "6")]
	public void AddTransactionObserver()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2C01ED4", Offset = "0x2BFDED4", VA = "0x2C01ED4", Slot = "11")]
	public void FetchProducts(string json)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2C01F0C", Offset = "0x2BFDF0C", VA = "0x2C01F0C", Slot = "12")]
	public void FetchExistingPurchases()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2C01F44", Offset = "0x2BFDF44", VA = "0x2C01F44", Slot = "13")]
	public void Purchase(string productJSON, string developerPayload)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2C01F7C", Offset = "0x2BFDF7C", VA = "0x2C01F7C", Slot = "14")]
	public void FinishTransaction(string productJSON, string transactionID)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2C01FB4", Offset = "0x2BFDFB4", VA = "0x2C01FB4", Slot = "7")]
	public void InterceptPromotionalPurchases()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2C01FEC", Offset = "0x2BFDFEC", VA = "0x2C01FEC", Slot = "8")]
	public void DeallocateMemory(IntPtr pointer)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2C02024", Offset = "0x2BFE024", VA = "0x2C02024", Slot = "9")]
	public void RefreshAppReceipt()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2C0205C", Offset = "0x2BFE05C", VA = "0x2C0205C")]
	public OSXStoreBindings()
	{
	}
}
