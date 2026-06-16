using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace CAS;

[Token(Token = "0x2000002")]
public struct AdError
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private readonly int code;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x8")]
	private readonly string message;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x178DED0", Offset = "0x1789ED0", VA = "0x178DED0")]
	public AdError(int code, string message)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x178DEDC", Offset = "0x1789EDC", VA = "0x178DEDC")]
	public string GetMessage()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x178DEE0", Offset = "0x1789EE0", VA = "0x178DEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Impression-Level-Data")]
public abstract class AdMetaData
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public readonly AdType type;

	[Token(Token = "0x17000001")]
	public abstract AdNetwork network
	{
		[Token(Token = "0x6000004")]
		get;
	}

	[Token(Token = "0x17000002")]
	public abstract double revenue
	{
		[Token(Token = "0x6000005")]
		get;
	}

	[Token(Token = "0x17000003")]
	public abstract double cpm
	{
		[Token(Token = "0x6000006")]
		get;
	}

	[Token(Token = "0x17000004")]
	public abstract PriceAccuracy priceAccuracy
	{
		[Token(Token = "0x6000007")]
		get;
	}

	[Token(Token = "0x17000005")]
	public abstract string creativeIdentifier
	{
		[Token(Token = "0x6000008")]
		get;
	}

	[Token(Token = "0x17000006")]
	public abstract string sourceUnitId
	{
		[Token(Token = "0x6000009")]
		get;
	}

	[Token(Token = "0x17000007")]
	public abstract int impressionDepth
	{
		[Token(Token = "0x600000A")]
		get;
	}

	[Token(Token = "0x17000008")]
	public abstract double lifetimeRevenue
	{
		[Token(Token = "0x600000B")]
		get;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x178DFD4", Offset = "0x1789FD4", VA = "0x178DFD4")]
	public AdMetaData(AdType type)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x178DFFC", Offset = "0x1789FFC", VA = "0x178DFFC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public enum AdNetwork
{
	[Token(Token = "0x4000005")]
	GoogleAds = 0,
	[Token(Token = "0x4000006")]
	LiftoffMonetize = 1,
	[Token(Token = "0x4000007")]
	Kidoz = 2,
	[Token(Token = "0x4000008")]
	Chartboost = 3,
	[Token(Token = "0x4000009")]
	UnityAds = 4,
	[Token(Token = "0x400000A")]
	AppLovin = 5,
	[Token(Token = "0x400000B")]
	SuperAwesome = 6,
	[Token(Token = "0x400000C")]
	StartIO = 7,
	[Token(Token = "0x400000D")]
	CASExchange = 8,
	[Token(Token = "0x400000E")]
	AudienceNetwork = 9,
	[Token(Token = "0x400000F")]
	InMobi = 10,
	[Token(Token = "0x4000010")]
	DTExchange = 11,
	[Token(Token = "0x4000011")]
	CrossPromotion = 13,
	[Token(Token = "0x4000012")]
	IronSource = 14,
	[Token(Token = "0x4000013")]
	YangoAds = 15,
	[Token(Token = "0x4000014")]
	HyprMX = 16,
	[Token(Token = "0x4000015")]
	Smaato = 18,
	[Token(Token = "0x4000016")]
	Bigo = 19,
	[Token(Token = "0x4000017")]
	Ogury = 20,
	[Token(Token = "0x4000018")]
	Madex = 21,
	[Token(Token = "0x4000019")]
	Mintegral = 23,
	[Token(Token = "0x400001A")]
	Pangle = 24,
	[Token(Token = "0x400001B")]
	YsoNetwork = 25,
	[Token(Token = "0x400001C")]
	Prado = 26,
	[Token(Token = "0x400001D")]
	Maticoo = 27,
	[Token(Token = "0x400001E")]
	Verve = 29,
	[Token(Token = "0x400001F")]
	DSPExchange = 30,
	[Token(Token = "0x4000020")]
	LastPage = 31
}
[Token(Token = "0x2000005")]
public enum AdPosition
{
	[Token(Token = "0x4000022")]
	TopCenter,
	[Token(Token = "0x4000023")]
	TopLeft,
	[Token(Token = "0x4000024")]
	TopRight,
	[Token(Token = "0x4000025")]
	BottomCenter,
	[Token(Token = "0x4000026")]
	BottomLeft,
	[Token(Token = "0x4000027")]
	BottomRight,
	[Token(Token = "0x4000028")]
	MiddleCenter,
	[Token(Token = "0x4000029")]
	MiddleLeft,
	[Token(Token = "0x400002A")]
	MiddleRight,
	[Token(Token = "0x400002B")]
	Undefined
}
[Token(Token = "0x2000006")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Banner-Ads#ad-size")]
public enum AdSize
{
	[Token(Token = "0x400002D")]
	Banner = 1,
	[Token(Token = "0x400002E")]
	AdaptiveBanner,
	[Token(Token = "0x400002F")]
	SmartBanner,
	[Token(Token = "0x4000030")]
	Leaderboard,
	[Token(Token = "0x4000031")]
	MediumRectangle,
	[Token(Token = "0x4000032")]
	AdaptiveFullWidth,
	[Token(Token = "0x4000033")]
	ThinBanner
}
[Token(Token = "0x2000007")]
public enum AdType
{
	[Token(Token = "0x4000035")]
	Banner,
	[Token(Token = "0x4000036")]
	Interstitial,
	[Token(Token = "0x4000037")]
	Rewarded,
	[Token(Token = "0x4000038")]
	AppOpen,
	[Token(Token = "0x4000039")]
	[Obsolete("Not supported")]
	Native,
	[Token(Token = "0x400003A")]
	None
}
[Token(Token = "0x2000008")]
[Flags]
public enum AdFlags
{
	[Token(Token = "0x400003C")]
	None = 0,
	[Token(Token = "0x400003D")]
	Banner = 1,
	[Token(Token = "0x400003E")]
	Interstitial = 2,
	[Token(Token = "0x400003F")]
	Rewarded = 4,
	[Token(Token = "0x4000040")]
	AppOpen = 8,
	[Token(Token = "0x4000041")]
	Everything = 0xF
}
[Token(Token = "0x2000009")]
public class ConsentFlow
{
	[Token(Token = "0x200000A")]
	public enum Status
	{
		[Token(Token = "0x4000047")]
		Unknown = 0,
		[Token(Token = "0x4000048")]
		Obtained = 3,
		[Token(Token = "0x4000049")]
		NotRequired = 4,
		[Token(Token = "0x400004A")]
		Unavailable = 5,
		[Token(Token = "0x400004B")]
		InternalError = 10,
		[Token(Token = "0x400004C")]
		InternetError = 11,
		[Token(Token = "0x400004D")]
		ContextInvalid = 12,
		[Token(Token = "0x400004E")]
		FlowStillShowing = 13
	}

	[Token(Token = "0x200000B")]
	public enum DebugGeography
	{
		[Token(Token = "0x4000050")]
		Disabled,
		[Token(Token = "0x4000051")]
		EEA,
		[Token(Token = "0x4000052")]
		[Obsolete("Renamed to Other")]
		NotEEA,
		[Token(Token = "0x4000053")]
		RegulatedUSState,
		[Token(Token = "0x4000054")]
		Other
	}

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x10")]
	public bool isEnabled;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public string privacyPolicyUrl;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x20")]
	public Action<Status> OnResult;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	public DebugGeography debugGeography;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x178E278", Offset = "0x178A278", VA = "0x178E278")]
	public ConsentFlow(bool isEnabled = true)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x178E2AC", Offset = "0x178A2AC", VA = "0x178E2AC")]
	public ConsentFlow WithPrivacyPolicy(string url)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x178E2B4", Offset = "0x178A2B4", VA = "0x178E2B4")]
	public ConsentFlow WithCompletionListener(Action<Status> result)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x178E354", Offset = "0x178A354", VA = "0x178E354")]
	public ConsentFlow WithDebugGeography(DebugGeography debugGeography)
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
public interface IAdsPreset
{
}
[Token(Token = "0x200000D")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Privacy-Regulations")]
public enum ConsentStatus
{
	[Token(Token = "0x4000056")]
	Undefined,
	[Token(Token = "0x4000057")]
	Accepted,
	[Token(Token = "0x4000058")]
	Denied
}
[Token(Token = "0x200000E")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Privacy-Regulations")]
public enum CCPAStatus
{
	[Token(Token = "0x400005A")]
	Undefined,
	[Token(Token = "0x400005B")]
	OptOutSale,
	[Token(Token = "0x400005C")]
	OptInSale
}
[Token(Token = "0x200000F")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Privacy-Regulations")]
public enum Audience
{
	[Token(Token = "0x400005E")]
	Mixed,
	[Token(Token = "0x400005F")]
	Children,
	[Token(Token = "0x4000060")]
	NotChildren
}
[Token(Token = "0x2000010")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Configuring-SDK")]
public interface IAdsSettings
{
	[Token(Token = "0x17000009")]
	Audience taggedAudience
	{
		[Token(Token = "0x6000012")]
		set;
	}

	[Token(Token = "0x1700000A")]
	int bannerRefreshInterval
	{
		[Token(Token = "0x6000013")]
		set;
	}

	[Token(Token = "0x1700000B")]
	int interstitialInterval
	{
		[Token(Token = "0x6000014")]
		set;
	}

	[Token(Token = "0x1700000C")]
	bool allowInterstitialAdsWhenVideoCostAreLower
	{
		[Token(Token = "0x6000016")]
		set;
	}

	[Token(Token = "0x1700000D")]
	bool isDebugMode
	{
		[Token(Token = "0x6000017")]
		get;
		[Token(Token = "0x6000018")]
		set;
	}

	[Token(Token = "0x1700000E")]
	LoadingManagerMode loadingMode
	{
		[Token(Token = "0x6000019")]
		get;
		[Token(Token = "0x600001A")]
		set;
	}

	[Token(Token = "0x6000015")]
	void RestartInterstitialInterval();
}
[Token(Token = "0x2000011")]
public delegate void CASViewEvent(IAdView view);
[Token(Token = "0x2000012")]
public delegate void CASViewEventWithError(IAdView view, AdError error);
[Token(Token = "0x2000013")]
public delegate void CASViewEventWithMeta(IAdView view, AdMetaData data);
[Token(Token = "0x2000014")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Banner-Ads")]
public interface IAdView : IDisposable
{
	[Token(Token = "0x1700000F")]
	Rect rectInPixels
	{
		[Token(Token = "0x6000029")]
		get;
	}

	[Token(Token = "0x17000010")]
	bool isReady
	{
		[Token(Token = "0x600002A")]
		get;
	}

	[Token(Token = "0x17000011")]
	AdPosition position
	{
		[Token(Token = "0x600002B")]
		set;
	}

	[Token(Token = "0x14000001")]
	event CASViewEvent OnLoaded;

	[Token(Token = "0x14000002")]
	event CASViewEventWithError OnFailed;

	[Token(Token = "0x14000003")]
	event CASViewEventWithMeta OnImpression;

	[Token(Token = "0x14000004")]
	event CASViewEvent OnClicked;

	[Token(Token = "0x600002C")]
	void SetPosition(int x, int y, AdPosition position = AdPosition.TopLeft);

	[Token(Token = "0x600002D")]
	void Load();

	[Token(Token = "0x600002E")]
	void SetActive(bool active);
}
[Token(Token = "0x2000015")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Initialize-SDK")]
public interface IManagerBuilder : IAdsPreset
{
	[Token(Token = "0x600002F")]
	IMediationManager Build();

	[Token(Token = "0x6000030")]
	IManagerBuilder WithConsentFlow(ConsentFlow flow);

	[Token(Token = "0x6000031")]
	IManagerBuilder WithMediationExtras(string key, string value);

	[Token(Token = "0x6000032")]
	IManagerBuilder WithManagerIdAtIndex(int index);
}
[Token(Token = "0x2000016")]
public delegate void CASEventWithError(string error);
[Token(Token = "0x2000017")]
public delegate void CASEventWithAdError(AdError error);
[Token(Token = "0x2000018")]
public delegate void CASEventWithMeta(AdMetaData meta);
[Token(Token = "0x2000019")]
public delegate void CASInitCompleteEvent(InitialConfiguration config);
[Token(Token = "0x200001A")]
public class WikiPageAttribute : Attribute
{
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x178EA18", Offset = "0x178AA18", VA = "0x178EA18")]
	public WikiPageAttribute(string url)
	{
	}
}
[Token(Token = "0x200001B")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Initialize-SDK")]
public interface IMediationManager
{
	[Token(Token = "0x14000005")]
	event Action OnInterstitialAdLoaded;

	[Token(Token = "0x14000006")]
	event CASEventWithAdError OnInterstitialAdFailedToLoad;

	[Token(Token = "0x14000007")]
	event CASEventWithMeta OnInterstitialAdImpression;

	[Token(Token = "0x14000008")]
	event CASEventWithError OnInterstitialAdFailedToShow;

	[Token(Token = "0x14000009")]
	event Action OnInterstitialAdClicked;

	[Token(Token = "0x1400000A")]
	event Action OnInterstitialAdClosed;

	[Token(Token = "0x1400000B")]
	event Action OnRewardedAdLoaded;

	[Token(Token = "0x1400000C")]
	event CASEventWithAdError OnRewardedAdFailedToLoad;

	[Token(Token = "0x1400000D")]
	event CASEventWithMeta OnRewardedAdImpression;

	[Token(Token = "0x1400000E")]
	event CASEventWithError OnRewardedAdFailedToShow;

	[Token(Token = "0x1400000F")]
	event Action OnRewardedAdClicked;

	[Token(Token = "0x14000010")]
	event Action OnRewardedAdCompleted;

	[Token(Token = "0x14000011")]
	event Action OnRewardedAdClosed;

	[Token(Token = "0x14000012")]
	event Action OnAppOpenAdLoaded;

	[Token(Token = "0x14000013")]
	event CASEventWithAdError OnAppOpenAdFailedToLoad;

	[Token(Token = "0x14000014")]
	event CASEventWithMeta OnAppOpenAdImpression;

	[Token(Token = "0x14000015")]
	event CASEventWithError OnAppOpenAdFailedToShow;

	[Token(Token = "0x14000016")]
	event Action OnAppOpenAdClicked;

	[Token(Token = "0x14000017")]
	event Action OnAppOpenAdClosed;

	[Token(Token = "0x14000018")]
	event Action OnAppReturnAdShown;

	[Token(Token = "0x14000019")]
	event CASEventWithMeta OnAppReturnAdImpression;

	[Token(Token = "0x1400001A")]
	event CASEventWithError OnAppReturnAdFailedToShow;

	[Token(Token = "0x1400001B")]
	event Action OnAppReturnAdClicked;

	[Token(Token = "0x1400001C")]
	event Action OnAppReturnAdClosed;

	[Token(Token = "0x6000062")]
	void LoadAd(AdType adType);

	[Token(Token = "0x6000063")]
	bool IsReadyAd(AdType adType);

	[Token(Token = "0x6000064")]
	void ShowAd(AdType adType);

	[Token(Token = "0x6000065")]
	IAdView GetAdView(AdSize size);

	[Token(Token = "0x6000070")]
	void SetAppReturnAdsEnabled(bool enable);
}
[Token(Token = "0x200001C")]
public class InitialConfiguration
{
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x10")]
	public readonly string error;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x18")]
	public readonly IMediationManager manager;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x20")]
	public readonly string countryCode;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x28")]
	public readonly bool isConsentRequired;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x2C")]
	public readonly ConsentFlow.Status consentFlowStatus;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x178EA20", Offset = "0x178AA20", VA = "0x178EA20")]
	public InitialConfiguration(string error, IMediationManager manager, string countryCode, bool isConsentRequired, ConsentFlow.Status consentFlowStatus)
	{
	}
}
[Token(Token = "0x200001D")]
public enum Gender
{
	[Token(Token = "0x4000067")]
	Unknown,
	[Token(Token = "0x4000068")]
	Male,
	[Token(Token = "0x4000069")]
	Female
}
[Token(Token = "0x200001E")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Initialize-CAS#targeting-options")]
public interface ITargetingOptions
{
	[Token(Token = "0x17000012")]
	bool locationCollectionEnabled
	{
		[Token(Token = "0x6000072")]
		set;
	}
}
[Serializable]
[Token(Token = "0x200001F")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Configuring-Last-Page-Ad")]
public class LastPageAdContent
{
}
[Token(Token = "0x2000020")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Other-Options#loading-mode")]
public enum LoadingManagerMode
{
	[Token(Token = "0x400006B")]
	[Obsolete("Not longer support, replaced to Auto")]
	FastestRequests = 0,
	[Token(Token = "0x400006C")]
	[Obsolete("Not longer support, replaced to Auto")]
	FastRequests = 1,
	[Token(Token = "0x400006D")]
	Auto = 2,
	[Token(Token = "0x400006E")]
	Optimal = 2,
	[Token(Token = "0x400006F")]
	[Obsolete("Not longer support, replaced to Auto")]
	HighePerformance = 3,
	[Token(Token = "0x4000070")]
	[Obsolete("Not longer support, replaced to Auto")]
	HighestPerformance = 4,
	[Token(Token = "0x4000071")]
	Manual = 5
}
[Token(Token = "0x2000021")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Impression-Level-Data")]
public enum PriceAccuracy
{
	[Token(Token = "0x4000073")]
	Floor,
	[Token(Token = "0x4000074")]
	Bid,
	[Token(Token = "0x4000075")]
	Undisclosed
}
[Token(Token = "0x2000022")]
[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Include-Android#execute-events-on-unity-thread")]
public static class EventExecutor
{
	[Token(Token = "0x2000023")]
	public sealed class EventExecutorComponent : MonoBehaviour
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x178EE58", Offset = "0x178AE58", VA = "0x178EE58")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x178EEF4", Offset = "0x178AEF4", VA = "0x178EEF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x178F264", Offset = "0x178B264", VA = "0x178F264")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x178F318", Offset = "0x178B318", VA = "0x178F318")]
		public EventExecutorComponent()
		{
		}
	}

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x0")]
	private static EventExecutorComponent instance;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x8")]
	private static List<Action> eventsQueue;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x10")]
	private static List<Action> stagedEventsQueue;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x18")]
	private static bool eventsQueueEmpty;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x1C")]
	private static int unityManagedThreadId;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x178EA74", Offset = "0x178AA74", VA = "0x178EA74")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x178EBBC", Offset = "0x178ABBC", VA = "0x178EBBC")]
	public static void Add(Action action)
	{
	}
}
[Token(Token = "0x2000024")]
public class MediationExtras
{
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x0")]
	[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Additional-Meta-AudienceNetwork-steps")]
	public static string facebookAdvertiserTracking;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x8")]
	[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Additional-Meta-AudienceNetwork-steps")]
	public static string facebookDataProcessing;
}
