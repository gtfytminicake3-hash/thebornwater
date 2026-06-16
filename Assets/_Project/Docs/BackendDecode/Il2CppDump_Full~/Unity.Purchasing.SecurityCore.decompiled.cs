using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.Purchasing.Security;

[Token(Token = "0x2000002")]
public class AppleReceipt
{
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	public AppleInAppPurchaseReceipt[] inAppPurchaseReceipts;

	[Token(Token = "0x17000001")]
	internal string bundleID
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2C32238", Offset = "0x2C2E238", VA = "0x2C32238")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	internal string appVersion
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C32240", Offset = "0x2C2E240", VA = "0x2C32240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	internal byte[] opaque
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C32248", Offset = "0x2C2E248", VA = "0x2C32248")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	internal byte[] hash
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C32250", Offset = "0x2C2E250", VA = "0x2C32250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	internal string originalApplicationVersion
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2C32258", Offset = "0x2C2E258", VA = "0x2C32258")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	internal DateTime receiptCreationDate
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C32260", Offset = "0x2C2E260", VA = "0x2C32260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2C32268", Offset = "0x2C2E268", VA = "0x2C32268")]
	public AppleReceipt()
	{
	}
}
[Token(Token = "0x2000003")]
public class AppleInAppPurchaseReceipt
{
	[Token(Token = "0x17000007")]
	internal int quantity
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2C32270", Offset = "0x2C2E270", VA = "0x2C32270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public string productID
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2C32278", Offset = "0x2C2E278", VA = "0x2C32278", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2C32280", Offset = "0x2C2E280", VA = "0x2C32280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000009")]
	internal string transactionID
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2C32288", Offset = "0x2C2E288", VA = "0x2C32288")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	internal string originalTransactionIdentifier
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C32290", Offset = "0x2C2E290", VA = "0x2C32290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public DateTime purchaseDate
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C32298", Offset = "0x2C2E298", VA = "0x2C32298", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C322A0", Offset = "0x2C2E2A0", VA = "0x2C322A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	internal DateTime originalPurchaseDate
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C322A8", Offset = "0x2C2E2A8", VA = "0x2C322A8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public DateTime subscriptionExpirationDate
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C322B0", Offset = "0x2C2E2B0", VA = "0x2C322B0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2C322B8", Offset = "0x2C2E2B8", VA = "0x2C322B8")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public DateTime cancellationDate
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2C322C0", Offset = "0x2C2E2C0", VA = "0x2C322C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2C322C8", Offset = "0x2C2E2C8", VA = "0x2C322C8")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public int isFreeTrial
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2C322D0", Offset = "0x2C2E2D0", VA = "0x2C322D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2C322D8", Offset = "0x2C2E2D8", VA = "0x2C322D8")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public int productType
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2C322E0", Offset = "0x2C2E2E0", VA = "0x2C322E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2C322E8", Offset = "0x2C2E2E8", VA = "0x2C322E8")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int isIntroductoryPricePeriod
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2C322F0", Offset = "0x2C2E2F0", VA = "0x2C322F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2C322F8", Offset = "0x2C2E2F8", VA = "0x2C322F8")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2C32300", Offset = "0x2C2E300", VA = "0x2C32300")]
	public AppleInAppPurchaseReceipt()
	{
	}
}
[Token(Token = "0x2000004")]
public enum GooglePurchaseState
{
	[Token(Token = "0x4000014")]
	Purchased = 0,
	[Token(Token = "0x4000015")]
	Cancelled = 1,
	[Token(Token = "0x4000016")]
	Refunded = 2,
	[Token(Token = "0x4000017")]
	Deferred = 4
}
[Token(Token = "0x2000005")]
public class IAPSecurityException : Exception
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2C32308", Offset = "0x2C2E308", VA = "0x2C32308")]
	public IAPSecurityException()
	{
	}
}
