using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using CAS;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class CASImplementationExtensions
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x178F3AC", Offset = "0x178B3AC", VA = "0x178F3AC")]
	public static void ShowIfRequired(this ConsentFlow flow)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x178F658", Offset = "0x178B658", VA = "0x178F658")]
	public static void Show(this ConsentFlow flow)
	{
	}
}
[Token(Token = "0x2000003")]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000004")]
	private struct MonoScriptData
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x178F6B0", Offset = "0x178B6B0", VA = "0x178F6B0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x178F76C", Offset = "0x178B76C", VA = "0x178F76C")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace CAS
{
	[Token(Token = "0x2000005")]
	[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/App-Tracking-Transparency")]
	public static class ATTrackingStatus
	{
		[Token(Token = "0x2000006")]
		[WikiPage("https://developer.apple.com/documentation/apptrackingtransparency/attrackingmanager/authorizationstatus")]
		public enum AuthorizationStatus
		{
			[Token(Token = "0x4000007")]
			NotDetermined,
			[Token(Token = "0x4000008")]
			Restricted,
			[Token(Token = "0x4000009")]
			Denied,
			[Token(Token = "0x400000A")]
			Authorized
		}

		[Token(Token = "0x2000007")]
		public delegate void CompleteHandler(AuthorizationStatus status);

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x178F774", Offset = "0x178B774", VA = "0x178F774")]
		[WikiPage("https://developer.apple.com/documentation/apptrackingtransparency/attrackingmanager/3547037-requesttrackingauthorization")]
		public static void Request()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x178F778", Offset = "0x178B778", VA = "0x178F778")]
		[WikiPage("https://developer.apple.com/documentation/apptrackingtransparency/attrackingmanager/3547037-requesttrackingauthorization")]
		public static void Request(CompleteHandler callback)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x178F798", Offset = "0x178B798", VA = "0x178F798")]
		[WikiPage("https://developer.apple.com/documentation/apptrackingtransparency/attrackingmanager/3547038-trackingauthorizationstatus")]
		public static AuthorizationStatus GetStatus()
		{
			return default(AuthorizationStatus);
		}
	}
	[Token(Token = "0x2000008")]
	[WikiPage("https://docs.page/cleveradssolutions/docs/Unity/Initialize-SDK")]
	public static class MobileAds
	{
		[Token(Token = "0x400000B")]
		public const string wrapperVersion = "4.5.0";

		[Token(Token = "0x17000001")]
		public static IAdsSettings settings
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x178F8D0", Offset = "0x178B8D0", VA = "0x178F8D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static IMediationManager manager
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x178F9BC", Offset = "0x178B9BC", VA = "0x178F9BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public static ITargetingOptions targetingOptions
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x178FAE4", Offset = "0x178BAE4", VA = "0x178FAE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnApplicationBackground
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x178FBB8", Offset = "0x178BBB8", VA = "0x178FBB8")]
			add
			{
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x178FD74", Offset = "0x178BD74", VA = "0x178FD74")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action OnApplicationForeground
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x178FE44", Offset = "0x178BE44", VA = "0x178FE44")]
			add
			{
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x178FF14", Offset = "0x178BF14", VA = "0x178FF14")]
			remove
			{
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x178FFE4", Offset = "0x178BFE4", VA = "0x178FFE4")]
		public static string GetSDKVersion()
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1790120", Offset = "0x178C120", VA = "0x1790120")]
		public static float GetDeviceScreenScale()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1790248", Offset = "0x178C248", VA = "0x1790248")]
		public static IManagerBuilder BuildManager()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17903C8", Offset = "0x178C3C8", VA = "0x17903C8")]
		public static void ValidateIntegration()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17904EC", Offset = "0x178C4EC", VA = "0x17904EC")]
		public static AdNetwork[] GetActiveNetworks()
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17906A4", Offset = "0x178C6A4", VA = "0x17906A4")]
		public static bool IsActiveNetwork(AdNetwork network)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17907DC", Offset = "0x178C7DC", VA = "0x17907DC")]
		public static void ReportCustomRevenue(string json)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1790910", Offset = "0x178C910", VA = "0x1790910")]
		[Obsolete("Use ShowIfRequired() or Show() methods for ConsentFlow insntance.")]
		public static void ShowConsentFlow(ConsentFlow flow)
		{
		}
	}
	[Token(Token = "0x2000009")]
	internal static class AdTypeCode
	{
		[Token(Token = "0x400000C")]
		internal const int BANNER = 0;

		[Token(Token = "0x400000D")]
		internal const int INTER = 1;

		[Token(Token = "0x400000E")]
		internal const int REWARD = 2;

		[Token(Token = "0x400000F")]
		internal const int APP_OPEN = 3;

		[Token(Token = "0x4000010")]
		internal const int APP_RETURN = 5;
	}
	[Token(Token = "0x200000A")]
	internal static class AdActionCode
	{
		[Token(Token = "0x4000011")]
		internal const int LOADED = 1;

		[Token(Token = "0x4000012")]
		internal const int FAILED = 2;

		[Token(Token = "0x4000013")]
		internal const int SHOWN = 3;

		[Token(Token = "0x4000014")]
		internal const int IMPRESSION = 4;

		[Token(Token = "0x4000015")]
		internal const int SHOW_FAILED = 5;

		[Token(Token = "0x4000016")]
		internal const int CLICKED = 6;

		[Token(Token = "0x4000017")]
		internal const int COMPLETED = 7;

		[Token(Token = "0x4000018")]
		internal const int CLOSED = 8;

		[Token(Token = "0x4000019")]
		internal const int VIEW_RECT = 9;

		[Token(Token = "0x400001A")]
		internal const int INIT = 10;
	}
	[Token(Token = "0x200000B")]
	internal abstract class CASManagerBase : IMediationManager
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		private AdFlags enabledFormats;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<CASViewBase> adViews;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x130")]
		private LastPageAdContent _lastPageAdContent;

		[Token(Token = "0x17000004")]
		public string managerID
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1790914", Offset = "0x178C914", VA = "0x1790914", Slot = "57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x179091C", Offset = "0x178C91C", VA = "0x179091C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool isTestAdMode
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1790924", Offset = "0x178C924", VA = "0x1790924", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x179092C", Offset = "0x178C92C", VA = "0x179092C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public CASInitCompleteEvent initCompleteEvent
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1790934", Offset = "0x178C934", VA = "0x1790934")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x179093C", Offset = "0x178C93C", VA = "0x179093C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public InitialConfiguration initialConfig
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1790944", Offset = "0x178C944", VA = "0x1790944")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x179094C", Offset = "0x178C94C", VA = "0x179094C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public LastPageAdContent lastPageAdContent
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1792E9C", Offset = "0x178EE9C", VA = "0x1792E9C", Slot = "82")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x1792EA4", Offset = "0x178EEA4", VA = "0x1792EA4", Slot = "83")]
			set
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action OnInterstitialAdLoaded
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1790954", Offset = "0x178C954", VA = "0x1790954", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x17909F0", Offset = "0x178C9F0", VA = "0x17909F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event CASEventWithAdError OnInterstitialAdFailedToLoad
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1790A8C", Offset = "0x178CA8C", VA = "0x1790A8C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1790B28", Offset = "0x178CB28", VA = "0x1790B28", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action OnInterstitialAdShown
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1790BC4", Offset = "0x178CBC4", VA = "0x1790BC4", Slot = "59")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1790C60", Offset = "0x178CC60", VA = "0x1790C60", Slot = "60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event CASEventWithMeta OnInterstitialAdOpening
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1790CFC", Offset = "0x178CCFC", VA = "0x1790CFC", Slot = "61")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1790D98", Offset = "0x178CD98", VA = "0x1790D98", Slot = "62")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event CASEventWithMeta OnInterstitialAdImpression
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1790E34", Offset = "0x178CE34", VA = "0x1790E34", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1790ED0", Offset = "0x178CED0", VA = "0x1790ED0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event CASEventWithError OnInterstitialAdFailedToShow
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1790F6C", Offset = "0x178CF6C", VA = "0x1790F6C", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1791008", Offset = "0x178D008", VA = "0x1791008", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event Action OnInterstitialAdClicked
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x17910A4", Offset = "0x178D0A4", VA = "0x17910A4", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1791140", Offset = "0x178D140", VA = "0x1791140", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action OnInterstitialAdClosed
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x17911DC", Offset = "0x178D1DC", VA = "0x17911DC", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1791278", Offset = "0x178D278", VA = "0x1791278", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action OnRewardedAdLoaded
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1791314", Offset = "0x178D314", VA = "0x1791314", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x17913B0", Offset = "0x178D3B0", VA = "0x17913B0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event CASEventWithAdError OnRewardedAdFailedToLoad
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x179144C", Offset = "0x178D44C", VA = "0x179144C", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x17914E8", Offset = "0x178D4E8", VA = "0x17914E8", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action OnRewardedAdShown
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1791584", Offset = "0x178D584", VA = "0x1791584", Slot = "63")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1791620", Offset = "0x178D620", VA = "0x1791620", Slot = "64")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event CASEventWithMeta OnRewardedAdOpening
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x17916BC", Offset = "0x178D6BC", VA = "0x17916BC", Slot = "65")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1791758", Offset = "0x178D758", VA = "0x1791758", Slot = "66")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event CASEventWithMeta OnRewardedAdImpression
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x17917F4", Offset = "0x178D7F4", VA = "0x17917F4", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1791890", Offset = "0x178D890", VA = "0x1791890", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event CASEventWithError OnRewardedAdFailedToShow
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x179192C", Offset = "0x178D92C", VA = "0x179192C", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x17919C8", Offset = "0x178D9C8", VA = "0x17919C8", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action OnRewardedAdClicked
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1791A64", Offset = "0x178DA64", VA = "0x1791A64", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1791B00", Offset = "0x178DB00", VA = "0x1791B00", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action OnRewardedAdCompleted
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1791B9C", Offset = "0x178DB9C", VA = "0x1791B9C", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1791C38", Offset = "0x178DC38", VA = "0x1791C38", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action OnRewardedAdClosed
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1791CD4", Offset = "0x178DCD4", VA = "0x1791CD4", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1791D70", Offset = "0x178DD70", VA = "0x1791D70", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action OnAppReturnAdShown
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1791E0C", Offset = "0x178DE0C", VA = "0x1791E0C", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1791EA8", Offset = "0x178DEA8", VA = "0x1791EA8", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event CASEventWithMeta OnAppReturnAdOpening
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1791F44", Offset = "0x178DF44", VA = "0x1791F44", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1791FE0", Offset = "0x178DFE0", VA = "0x1791FE0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event CASEventWithMeta OnAppReturnAdImpression
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x179207C", Offset = "0x178E07C", VA = "0x179207C", Slot = "48")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1792118", Offset = "0x178E118", VA = "0x1792118", Slot = "49")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event CASEventWithError OnAppReturnAdFailedToShow
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x17921B4", Offset = "0x178E1B4", VA = "0x17921B4", Slot = "50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1792250", Offset = "0x178E250", VA = "0x1792250", Slot = "51")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action OnAppReturnAdClicked
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x17922EC", Offset = "0x178E2EC", VA = "0x17922EC", Slot = "52")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1792388", Offset = "0x178E388", VA = "0x1792388", Slot = "53")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event Action OnAppReturnAdClosed
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1792424", Offset = "0x178E424", VA = "0x1792424", Slot = "54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x17924C0", Offset = "0x178E4C0", VA = "0x17924C0", Slot = "55")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event Action OnAppOpenAdLoaded
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x179255C", Offset = "0x178E55C", VA = "0x179255C", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x17925F8", Offset = "0x178E5F8", VA = "0x17925F8", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event CASEventWithAdError OnAppOpenAdFailedToLoad
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1792694", Offset = "0x178E694", VA = "0x1792694", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1792730", Offset = "0x178E730", VA = "0x1792730", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event Action OnAppOpenAdShown
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x17927CC", Offset = "0x178E7CC", VA = "0x17927CC", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1792868", Offset = "0x178E868", VA = "0x1792868", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event CASEventWithMeta OnAppOpenAdImpression
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1792904", Offset = "0x178E904", VA = "0x1792904", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x17929A0", Offset = "0x178E9A0", VA = "0x17929A0", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event CASEventWithError OnAppOpenAdFailedToShow
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1792A3C", Offset = "0x178EA3C", VA = "0x1792A3C", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1792AD8", Offset = "0x178EAD8", VA = "0x1792AD8", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event Action OnAppOpenAdClicked
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1792B74", Offset = "0x178EB74", VA = "0x1792B74", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1792C10", Offset = "0x178EC10", VA = "0x1792C10", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event Action OnAppOpenAdClosed
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1792CAC", Offset = "0x178ECAC", VA = "0x1792CAC", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x1792D48", Offset = "0x178ED48", VA = "0x1792D48", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600005F")]
		public abstract void EnableAd(AdType adType);

		[Token(Token = "0x6000060")]
		protected abstract void LoadAdNetive(AdType adType);

		[Token(Token = "0x6000061")]
		public abstract bool IsReadyAd(AdType adType);

		[Token(Token = "0x6000062")]
		public abstract void ShowAd(AdType adType);

		[Token(Token = "0x6000063")]
		public abstract void DisposeAd(AdType adType);

		[Token(Token = "0x6000064")]
		public abstract void SetAppReturnAdsEnabled(bool enable);

		[Token(Token = "0x6000065")]
		public abstract void SkipNextAppReturnAds();

		[Token(Token = "0x6000066")]
		protected abstract void SetLastPageAdContentNative(string json);

		[Token(Token = "0x6000067")]
		protected abstract CASViewBase CreateAdView(AdSize size);

		[Token(Token = "0x6000068")]
		public abstract AdMetaData WrapImpression(AdType adType, object impression);

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1792DE4", Offset = "0x178EDE4", VA = "0x1792DE4", Slot = "81")]
		internal virtual void Init(CASInitSettings initSettings)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1792F30", Offset = "0x178EF30", VA = "0x1792F30", Slot = "84")]
		public bool IsEnabledAd(AdType adType)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1792F40", Offset = "0x178EF40", VA = "0x1792F40")]
		internal bool IsEnabledAdFlag(AdFlags adFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1792F50", Offset = "0x178EF50", VA = "0x1792F50", Slot = "85")]
		public void SetEnableAd(AdType adType, bool enabled)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x17931EC", Offset = "0x178F1EC", VA = "0x17931EC", Slot = "42")]
		public void LoadAd(AdType adType)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1793848", Offset = "0x178F848", VA = "0x1793848", Slot = "45")]
		public IAdView GetAdView(AdSize size)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1793A74", Offset = "0x178FA74", VA = "0x1793A74", Slot = "86")]
		public virtual void RemoveAdViewFromFactory(CASViewBase view)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1793ACC", Offset = "0x178FACC", VA = "0x1793ACC")]
		internal void OnInitialized(string error, string countryCode, bool isConsentRequired, bool testMode, int consentFlowStatus)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1793228", Offset = "0x178F228", VA = "0x1793228", Slot = "87")]
		public void HandleCallback(int action, int type, int error, string errorMessage, object impression)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1793FF8", Offset = "0x178FFF8", VA = "0x1793FF8")]
		protected CASManagerBase()
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal abstract class CASViewBase : IAdView, IDisposable
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		protected CASManagerBase _manager;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected AdPosition _position;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected int _positionX;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int _positionY;

		[Token(Token = "0x17000009")]
		public IMediationManager manager
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1794554", Offset = "0x1790554", VA = "0x1794554", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public AdSize size
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x179455C", Offset = "0x179055C", VA = "0x179455C", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(AdSize);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1794564", Offset = "0x1790564", VA = "0x1794564")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Rect rectInPixels
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x179456C", Offset = "0x179056C", VA = "0x179456C", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1794578", Offset = "0x1790578", VA = "0x1794578")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public AdPosition position
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x17945BC", Offset = "0x17905BC", VA = "0x17945BC", Slot = "21")]
			get
			{
				return default(AdPosition);
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x17945C4", Offset = "0x17905C4", VA = "0x17945C4", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public abstract int refreshInterval
		{
			[Token(Token = "0x6000088")]
			get;
			[Token(Token = "0x6000089")]
			set;
		}

		[Token(Token = "0x1700000E")]
		public abstract bool isReady
		{
			[Token(Token = "0x600008A")]
			get;
		}

		[Token(Token = "0x14000021")]
		public event CASViewEvent OnLoaded
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1794074", Offset = "0x1790074", VA = "0x1794074", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1794110", Offset = "0x1790110", VA = "0x1794110", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event CASViewEventWithError OnFailed
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x17941AC", Offset = "0x17901AC", VA = "0x17941AC", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1794248", Offset = "0x1790248", VA = "0x1794248", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event CASViewEventWithMeta OnImpression
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x17942E4", Offset = "0x17902E4", VA = "0x17942E4", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1794380", Offset = "0x1790380", VA = "0x1794380", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event CASViewEvent OnClicked
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x179441C", Offset = "0x179041C", VA = "0x179441C", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x17944B8", Offset = "0x17904B8", VA = "0x17944B8", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1794584", Offset = "0x1790584", VA = "0x1794584")]
		internal CASViewBase(CASManagerBase manager, AdSize size)
		{
		}

		[Token(Token = "0x6000085")]
		internal abstract void Enable();

		[Token(Token = "0x6000086")]
		public abstract void LoadNative();

		[Token(Token = "0x6000087")]
		public abstract void SetActive(bool active);

		[Token(Token = "0x600008B")]
		internal abstract void DestroyNative();

		[Token(Token = "0x600008C")]
		protected abstract void SetPositionNative(int position, int x, int y);

		[Token(Token = "0x600008D")]
		protected abstract void SetPositionPxNative(int position, int x, int y);

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x179461C", Offset = "0x179061C", VA = "0x179461C", Slot = "16")]
		public void Load()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1794908", Offset = "0x1790908", VA = "0x1794908", Slot = "31")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1794948", Offset = "0x1790948", VA = "0x1794948", Slot = "32")]
		public void DisableRefresh()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x17945D4", Offset = "0x17905D4", VA = "0x17945D4", Slot = "15")]
		public void SetPosition(int x, int y, AdPosition position)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1794A18", Offset = "0x1790A18", VA = "0x1794A18", Slot = "33")]
		public void SetPositionPx(int x, int y, AdPosition position)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x179495C", Offset = "0x179095C", VA = "0x179495C")]
		private bool IsValidPosition(int x, int y, AdPosition position)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1794658", Offset = "0x1790658", VA = "0x1794658", Slot = "34")]
		public void HandleCallback(int action, int type, int error, string errorMessage, object impression)
		{
		}
	}
	[Token(Token = "0x200000D")]
	internal delegate void ManagerStateChanges(int index, CASManagerBase manager);
	[Token(Token = "0x200000E")]
	internal interface IAppStateEventClient
	{
		[Token(Token = "0x14000025")]
		event Action OnApplicationBackground;

		[Token(Token = "0x14000026")]
		event Action OnApplicationForeground;
	}
	[Token(Token = "0x200000F")]
	internal static class CASFactory
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		private static IAppStateEventClient appStateEventClient;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x8")]
		private static IAdsSettings settings;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x10")]
		private static List<CASManagerBase> managers;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x20")]
		internal static ConsentFlow.Status consentFlowStatus;

		[Token(Token = "0x1700000F")]
		internal static bool isDebug
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1794F08", Offset = "0x1790F08", VA = "0x1794F08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000027")]
		internal static event ManagerStateChanges OnManagerStateChanged
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1794D50", Offset = "0x1790D50", VA = "0x1794D50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1794E2C", Offset = "0x1790E2C", VA = "0x1794E2C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x178FA08", Offset = "0x178BA08", VA = "0x178FA08")]
		internal static IMediationManager GetMainManagerOrNull()
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1794FD0", Offset = "0x1790FD0", VA = "0x1794FD0")]
		private static CASInitSettings LoadInitSettingsFromResources()
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1795028", Offset = "0x1791028", VA = "0x1795028")]
		private static IAdsSettings CreateSettigns(CASInitSettings initSettings)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1790294", Offset = "0x178C294", VA = "0x1790294")]
		internal static CASInitSettings LoadDefaultBuiderFromResources()
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x178FC84", Offset = "0x178BC84", VA = "0x178FC84")]
		internal static IAppStateEventClient GetAppStateEventClient()
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x178F91C", Offset = "0x178B91C", VA = "0x178F91C")]
		internal static IAdsSettings GetAdsSettings()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x178FB30", Offset = "0x178BB30", VA = "0x178FB30")]
		internal static ITargetingOptions GetTargetingOptions()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1790030", Offset = "0x178C030", VA = "0x1790030")]
		internal static string GetSDKVersion()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x179016C", Offset = "0x178C16C", VA = "0x179016C")]
		internal static float GetDeviceScreenScale()
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1790830", Offset = "0x178C830", VA = "0x1790830")]
		internal static void ReportCustomRevenue(string json)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17930E4", Offset = "0x178F0E4", VA = "0x17930E4")]
		public static bool IsAutoload(AdType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x179588C", Offset = "0x179188C", VA = "0x179588C")]
		internal static IMediationManager CreateManager(CASInitSettings initSettings)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1795E24", Offset = "0x1791E24", VA = "0x1795E24")]
		internal static bool TryGetManagerByIndexAsync(int index, ManagerStateChanges managerStateHandler)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1793D24", Offset = "0x178FD24", VA = "0x1793D24")]
		internal static void OnManagerInitialized(CASManagerBase manager)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1790414", Offset = "0x178C414", VA = "0x1790414")]
		internal static void ValidateIntegration()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x17961C0", Offset = "0x17921C0", VA = "0x17961C0")]
		internal static string GetActiveMediationPattern()
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1790538", Offset = "0x178C538", VA = "0x1790538")]
		internal static AdNetwork[] GetActiveNetworks()
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x17906F8", Offset = "0x178C6F8", VA = "0x17906F8")]
		internal static bool IsActiveNetwork(AdNetwork network)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x178F404", Offset = "0x178B404", VA = "0x178F404")]
		internal static void ShowConsentFlow(ConsentFlow flow, bool ifRequired)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1796940", Offset = "0x1792940", VA = "0x1796940")]
		internal static void HandleConsentFlow(ConsentFlow flow, ConsentFlow.Status status)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1795FA4", Offset = "0x1791FA4", VA = "0x1795FA4")]
		internal static void UnityLog(string message)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1793E44", Offset = "0x178FE44", VA = "0x1793E44")]
		internal static void RuntimeLog(int adType, string message)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1794A60", Offset = "0x1790A60", VA = "0x1794A60")]
		internal static void RuntimeLog(AdSize adSize, string message)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class CASInitSettings : ScriptableObject, IManagerBuilder, IAdsPreset
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		public bool testAdMode;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x20")]
		public string[] managerIds;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x28")]
		public AdFlags allowedAdFlags;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x2C")]
		public Audience audienceTagged;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x30")]
		[Obsolete("No longer supported")]
		public AdSize bannerSize;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int bannerRefresh;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int interstitialInterval;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LoadingManagerMode loadingMode;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool debugMode;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool trackLocationEnabled;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		private bool interWhenNoRewardedAd;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x48")]
		internal string targetId;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x50")]
		internal string userID;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x58")]
		internal Dictionary<string, string> extras;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x60")]
		internal CASInitCompleteEvent initListener;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x68")]
		internal ConsentFlow consentFlow;

		[Token(Token = "0x17000010")]
		public AdFlags defaultAllowedFormats
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1796EE4", Offset = "0x1792EE4", VA = "0x1796EE4", Slot = "17")]
			get
			{
				return default(AdFlags);
			}
		}

		[Token(Token = "0x17000011")]
		public Audience defaultAudienceTagged
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1796EEC", Offset = "0x1792EEC", VA = "0x1796EEC", Slot = "18")]
			get
			{
				return default(Audience);
			}
		}

		[Token(Token = "0x17000012")]
		public int defaultBannerRefresh
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1796EF4", Offset = "0x1792EF4", VA = "0x1796EF4", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public int defaultInterstitialInterval
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1796EFC", Offset = "0x1792EFC", VA = "0x1796EFC", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public LoadingManagerMode defaultLoadingMode
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1796F04", Offset = "0x1792F04", VA = "0x1796F04", Slot = "21")]
			get
			{
				return default(LoadingManagerMode);
			}
		}

		[Token(Token = "0x17000015")]
		public bool defaultDebugModeEnabled
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1796F0C", Offset = "0x1792F0C", VA = "0x1796F0C", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool defaultIOSTrackLocationEnabled
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1796F14", Offset = "0x1792F14", VA = "0x1796F14", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool defaultLocationCollectionEnabled
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1796F1C", Offset = "0x1792F1C", VA = "0x1796F1C", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public bool defaultInterstitialWhenNoRewardedAd
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1796F24", Offset = "0x1792F24", VA = "0x1796F24", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public int managersCount
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1795DA0", Offset = "0x1791DA0", VA = "0x1795DA0", Slot = "26")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1796B24", Offset = "0x1792B24", VA = "0x1796B24", Slot = "8")]
		public IMediationManager Initialize()
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1796B28", Offset = "0x1792B28", VA = "0x1796B28", Slot = "4")]
		public IMediationManager Build()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1796C78", Offset = "0x1792C78", VA = "0x1796C78", Slot = "7")]
		public IManagerBuilder WithManagerIdAtIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1796B98", Offset = "0x1792B98", VA = "0x1796B98", Slot = "9")]
		public IManagerBuilder WithCASId(int index)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1796C7C", Offset = "0x1792C7C", VA = "0x1796C7C", Slot = "10")]
		public IManagerBuilder WithCompletionListener(CASInitCompleteEvent listener)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1796C84", Offset = "0x1792C84", VA = "0x1796C84", Slot = "11")]
		public IManagerBuilder WithEnabledAdTypes(params AdFlags[] adTypes)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1796CD8", Offset = "0x1792CD8", VA = "0x1796CD8", Slot = "12")]
		public IManagerBuilder WithUserID(string userID)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1796CE0", Offset = "0x1792CE0", VA = "0x1796CE0", Slot = "5")]
		public IManagerBuilder WithConsentFlow(ConsentFlow flow)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1796CE8", Offset = "0x1792CE8", VA = "0x1796CE8", Slot = "6")]
		public IManagerBuilder WithMediationExtras(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1796DA0", Offset = "0x1792DA0", VA = "0x1796DA0", Slot = "13")]
		public IManagerBuilder ClearMediationExtras()
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1796DF4", Offset = "0x1792DF4", VA = "0x1796DF4", Slot = "14")]
		public IManagerBuilder WithManagerId(string managerId)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1796DF8", Offset = "0x1792DF8", VA = "0x1796DF8", Slot = "15")]
		public IManagerBuilder WithCASId(string casId)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1796EDC", Offset = "0x1792EDC", VA = "0x1796EDC", Slot = "16")]
		public IManagerBuilder WithTestAdMode(bool test)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1796F2C", Offset = "0x1792F2C", VA = "0x1796F2C", Slot = "27")]
		public string GetManagerId(int index)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1795DBC", Offset = "0x1791DBC", VA = "0x1795DBC", Slot = "28")]
		public int IndexOfManagerId(string id)
		{
			return default(int);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1792E30", Offset = "0x178EE30", VA = "0x1792E30", Slot = "29")]
		public bool IsTestAdMode()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1796F5C", Offset = "0x1792F5C", VA = "0x1796F5C")]
		public CASInitSettings()
		{
		}
	}
}
namespace CAS.Unity
{
	[Token(Token = "0x2000011")]
	internal class CASSettingsClient : IAdsSettings, ITargetingOptions
	{
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x50")]
		public float lastInterImpressionTimestamp;

		[Token(Token = "0x1700001A")]
		public bool analyticsCollectionEnabled
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1796FFC", Offset = "0x1792FFC", VA = "0x1796FFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1797004", Offset = "0x1793004", VA = "0x1797004")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public int trialAdFreeInterval
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x179700C", Offset = "0x179300C", VA = "0x179700C", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1797014", Offset = "0x1793014", VA = "0x1797014", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int bannerRefreshInterval
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x179701C", Offset = "0x179301C", VA = "0x179701C", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1797024", Offset = "0x1793024", VA = "0x1797024", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public int interstitialInterval
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x179702C", Offset = "0x179302C", VA = "0x179702C", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x1797034", Offset = "0x1793034", VA = "0x1797034", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public ConsentStatus userConsent
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x179703C", Offset = "0x179303C", VA = "0x179703C", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(ConsentStatus);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1797044", Offset = "0x1793044", VA = "0x1797044", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public CCPAStatus userCCPAStatus
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x179704C", Offset = "0x179304C", VA = "0x179704C", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(CCPAStatus);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x1797054", Offset = "0x1793054", VA = "0x1797054", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Audience taggedAudience
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x179705C", Offset = "0x179305C", VA = "0x179705C", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(Audience);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1797064", Offset = "0x1793064", VA = "0x1797064", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool isDebugMode
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x179706C", Offset = "0x179306C", VA = "0x179706C", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1797074", Offset = "0x1793074", VA = "0x1797074", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isMutedAdSounds
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x179707C", Offset = "0x179307C", VA = "0x179707C", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1797084", Offset = "0x1793084", VA = "0x1797084", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public LoadingManagerMode loadingMode
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x179708C", Offset = "0x179308C", VA = "0x179708C", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(LoadingManagerMode);
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1797094", Offset = "0x1793094", VA = "0x1797094", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool iOSAppPauseOnBackground
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x179709C", Offset = "0x179309C", VA = "0x179709C", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x17970A4", Offset = "0x17930A4", VA = "0x17970A4", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool allowInterstitialAdsWhenVideoCostAreLower
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x17970AC", Offset = "0x17930AC", VA = "0x17970AC", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x17970B4", Offset = "0x17930B4", VA = "0x17970B4", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool trackLocationEnabled
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x17970BC", Offset = "0x17930BC", VA = "0x17970BC", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x17970C4", Offset = "0x17930C4", VA = "0x17970C4", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool locationCollectionEnabled
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x17970CC", Offset = "0x17930CC", VA = "0x17970CC", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x17970D4", Offset = "0x17930D4", VA = "0x17970D4", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool isExecuteEventsOnUnityThread
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x17970DC", Offset = "0x17930DC", VA = "0x17970DC", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x17970E4", Offset = "0x17930E4", VA = "0x17970E4", Slot = "32")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Gender gender
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x17970EC", Offset = "0x17930EC", VA = "0x17970EC", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(Gender);
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x17970F4", Offset = "0x17930F4", VA = "0x17970F4", Slot = "34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int age
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x17970FC", Offset = "0x17930FC", VA = "0x17970FC", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1797104", Offset = "0x1793104", VA = "0x1797104", Slot = "36")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public string contentURL
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x179710C", Offset = "0x179310C", VA = "0x179710C", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1797114", Offset = "0x1793114", VA = "0x1797114", Slot = "38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17954D4", Offset = "0x17914D4", VA = "0x17954D4")]
		internal CASSettingsClient()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x179711C", Offset = "0x179311C", VA = "0x179711C", Slot = "7")]
		public void RestartInterstitialInterval()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1797138", Offset = "0x1793138", VA = "0x1797138", Slot = "39")]
		public void SetTestDeviceIds(IList<string> testDeviceIds)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x179713C", Offset = "0x179313C", VA = "0x179713C", Slot = "40")]
		public void SetKeywords(IList<string> keywords)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1797140", Offset = "0x1793140", VA = "0x1797140", Slot = "41")]
		public ConsentStatus GetVendorConsent(int vendorId)
		{
			return default(ConsentStatus);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1797148", Offset = "0x1793148", VA = "0x1797148", Slot = "42")]
		public ConsentStatus GetAdditionalConsent(int providerId)
		{
			return default(ConsentStatus);
		}
	}
}
namespace CAS.Android
{
	[Token(Token = "0x2000012")]
	public class CASImpressionClient : AdMetaData
	{
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private readonly AndroidJavaObject impression;

		[Token(Token = "0x1700002C")]
		public override AdNetwork network
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1797178", Offset = "0x1793178", VA = "0x1797178", Slot = "4")]
			get
			{
				return default(AdNetwork);
			}
		}

		[Token(Token = "0x1700002D")]
		public override double revenue
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1797250", Offset = "0x1793250", VA = "0x1797250", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002E")]
		public override double cpm
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1797274", Offset = "0x1793274", VA = "0x1797274", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002F")]
		public override PriceAccuracy priceAccuracy
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1797360", Offset = "0x1793360", VA = "0x1797360", Slot = "7")]
			get
			{
				return default(PriceAccuracy);
			}
		}

		[Token(Token = "0x17000030")]
		public override string creativeIdentifier
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1797438", Offset = "0x1793438", VA = "0x1797438", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public override string sourceUnitId
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1797510", Offset = "0x1793510", VA = "0x1797510", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public override int impressionDepth
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x17975E8", Offset = "0x17935E8", VA = "0x17975E8", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000033")]
		public override double lifetimeRevenue
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x17976C0", Offset = "0x17936C0", VA = "0x17976C0", Slot = "11")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1797150", Offset = "0x1793150", VA = "0x1797150")]
		public CASImpressionClient(AdType type, AndroidJavaObject impression)
		{
		}
	}
	[Token(Token = "0x2000013")]
	internal static class CASJavaBridge
	{
		[Token(Token = "0x4000073")]
		internal const string PluginPackage = "com.cleveradssolutions.plugin.unity";

		[Token(Token = "0x4000074")]
		internal const string BridgeBuilderClass = "com.cleveradssolutions.plugin.unity.CASBridgeBuilder";

		[Token(Token = "0x4000075")]
		internal const string SettingsClass = "com.cleveradssolutions.plugin.unity.CASBridgeSettings";

		[Token(Token = "0x4000076")]
		internal const string AdCallbackClass = "com.cleveradssolutions.plugin.unity.CASCallback";

		[Token(Token = "0x4000077")]
		internal const string AdViewClass = "com.cleveradssolutions.plugin.unity.CASView";

		[Token(Token = "0x4000078")]
		internal const string ConsentFlowClass = "com.cleveradssolutions.plugin.unity.CASConsentFlow";

		[Token(Token = "0x4000079")]
		internal const string SimpleCallbackClass = "com.cleveradssolutions.plugin.unity.CASSimpleCallback";

		[Token(Token = "0x400007A")]
		internal const string AppStateEventNotifierClass = "com.cleveradssolutions.plugin.unity.AppStateEventNotifier";

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		internal static bool executeEventsOnUnityThread;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17977AC", Offset = "0x17937AC", VA = "0x17977AC")]
		internal static void ExecuteEvent(Action adEvent)
		{
		}
	}
	[Token(Token = "0x2000014")]
	internal class CASCallback : AndroidJavaProxy
	{
		[Token(Token = "0x2000015")]
		internal interface Handler
		{
			[Token(Token = "0x600010A")]
			void HandleCallback(int action, int type, int error, string errorMessage, object impression);
		}

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		private readonly Handler _client;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1797948", Offset = "0x1793948", VA = "0x1797948")]
		internal CASCallback(Handler client)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17979CC", Offset = "0x17939CC", VA = "0x17979CC", Slot = "4")]
		public override AndroidJavaObject Invoke(string methodName, object[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000018")]
	internal class CASAppStateEventClient : AndroidJavaProxy, IAppStateEventClient
	{
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x30")]
		private readonly AndroidJavaObject _bridge;

		[Token(Token = "0x14000028")]
		public event Action OnApplicationBackground
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x179831C", Offset = "0x179431C", VA = "0x179831C", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x17983B8", Offset = "0x17943B8", VA = "0x17983B8", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public event Action OnApplicationForeground
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1798454", Offset = "0x1794454", VA = "0x1798454", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x17984F0", Offset = "0x17944F0", VA = "0x17984F0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x17954FC", Offset = "0x17914FC", VA = "0x17954FC")]
		internal CASAppStateEventClient()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x179858C", Offset = "0x179458C", VA = "0x179858C", Slot = "4")]
		public override AndroidJavaObject Invoke(string methodName, object[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	internal class CASConsentFlowCallback : AndroidJavaProxy
	{
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		private Action<ConsentFlow.Status> OnResult;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x17986B8", Offset = "0x17946B8", VA = "0x17986B8")]
		internal CASConsentFlowCallback(Action<ConsentFlow.Status> OnResult)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x179873C", Offset = "0x179473C", VA = "0x179873C", Slot = "4")]
		public override AndroidJavaObject Invoke(string methodName, object[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	internal class CASConsentFlowClient : IDisposable
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		public AndroidJavaObject obj;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1796498", Offset = "0x1792498", VA = "0x1796498")]
		internal CASConsentFlowClient(ConsentFlow flow, bool forceTesting)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1796818", Offset = "0x1792818", VA = "0x1796818")]
		internal void Show(bool ifRequired)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x17989D4", Offset = "0x17949D4", VA = "0x17989D4", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200001C")]
	internal sealed class CASManagerClient : CASManagerBase, CASCallback.Handler
	{
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x138")]
		private AndroidJavaObject _managerBridge;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x140")]
		private CASCallback _managerCallback;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x17989EC", Offset = "0x17949EC", VA = "0x17989EC", Slot = "81")]
		internal override void Init(CASInitSettings initSettings)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x17992D8", Offset = "0x17952D8", VA = "0x17992D8", Slot = "78")]
		protected override void SetLastPageAdContentNative(string json)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x179939C", Offset = "0x179539C", VA = "0x179939C", Slot = "71")]
		public override void EnableAd(AdType adType)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1799494", Offset = "0x1795494", VA = "0x1799494", Slot = "73")]
		public override bool IsReadyAd(AdType adType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x17995A4", Offset = "0x17955A4", VA = "0x17995A4", Slot = "72")]
		protected override void LoadAdNetive(AdType adType)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x179969C", Offset = "0x179569C", VA = "0x179969C", Slot = "74")]
		public override void ShowAd(AdType adType)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1799794", Offset = "0x1795794", VA = "0x1799794", Slot = "75")]
		public override void DisposeAd(AdType adType)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x179988C", Offset = "0x179588C", VA = "0x179988C")]
		[Preserve]
		public bool TryOpenDebugger()
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1799964", Offset = "0x1795964", VA = "0x1799964", Slot = "76")]
		public override void SetAppReturnAdsEnabled(bool enable)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1799A60", Offset = "0x1795A60", VA = "0x1799A60", Slot = "77")]
		public override void SkipNextAppReturnAds()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1799B24", Offset = "0x1795B24", VA = "0x1799B24", Slot = "79")]
		protected override CASViewBase CreateAdView(AdSize size)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1799D4C", Offset = "0x1795D4C", VA = "0x1799D4C", Slot = "80")]
		public override AdMetaData WrapImpression(AdType adType, object impression)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1795DB8", Offset = "0x1791DB8", VA = "0x1795DB8")]
		public CASManagerClient()
		{
		}
	}
	[Token(Token = "0x200001D")]
	internal class CASSettingsClient : IAdsSettings, ITargetingOptions
	{
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x10")]
		private readonly AndroidJavaClass settingsBridge;

		[Token(Token = "0x17000034")]
		public bool analyticsCollectionEnabled
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1799E08", Offset = "0x1795E08", VA = "0x1799E08")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1799E10", Offset = "0x1795E10", VA = "0x1799E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int trialAdFreeInterval
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1799E18", Offset = "0x1795E18", VA = "0x1799E18", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1799EF0", Offset = "0x1795EF0", VA = "0x1799EF0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int bannerRefreshInterval
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1799FE8", Offset = "0x1795FE8", VA = "0x1799FE8", Slot = "16")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x179A0C0", Offset = "0x17960C0", VA = "0x179A0C0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int interstitialInterval
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x179A1B8", Offset = "0x17961B8", VA = "0x179A1B8", Slot = "17")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x179A290", Offset = "0x1796290", VA = "0x179A290", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public ConsentStatus userConsent
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x179A388", Offset = "0x1796388", VA = "0x179A388", Slot = "18")]
			get
			{
				return default(ConsentStatus);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x179A460", Offset = "0x1796460", VA = "0x179A460", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public CCPAStatus userCCPAStatus
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x179A558", Offset = "0x1796558", VA = "0x179A558", Slot = "20")]
			get
			{
				return default(CCPAStatus);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x179A630", Offset = "0x1796630", VA = "0x179A630", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Audience taggedAudience
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x179A728", Offset = "0x1796728", VA = "0x179A728", Slot = "22")]
			get
			{
				return default(Audience);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x179A800", Offset = "0x1796800", VA = "0x179A800", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isDebugMode
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x179A8F8", Offset = "0x17968F8", VA = "0x179A8F8", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x179A9D0", Offset = "0x17969D0", VA = "0x179A9D0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool isMutedAdSounds
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x179AACC", Offset = "0x1796ACC", VA = "0x179AACC", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x179ABA4", Offset = "0x1796BA4", VA = "0x179ABA4", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public LoadingManagerMode loadingMode
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x179ACA0", Offset = "0x1796CA0", VA = "0x179ACA0", Slot = "11")]
			get
			{
				return default(LoadingManagerMode);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x179AD78", Offset = "0x1796D78", VA = "0x179AD78", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool isExecuteEventsOnUnityThread
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x179B1A4", Offset = "0x17971A4", VA = "0x179B1A4", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x179B204", Offset = "0x1797204", VA = "0x179B204", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool iOSAppPauseOnBackground
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x179B268", Offset = "0x1797268", VA = "0x179B268", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x179B270", Offset = "0x1797270", VA = "0x179B270", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool trackLocationEnabled
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x179B274", Offset = "0x1797274", VA = "0x179B274", Slot = "30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x179B350", Offset = "0x1797350", VA = "0x179B350", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool allowInterstitialAdsWhenVideoCostAreLower
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x179B450", Offset = "0x1797450", VA = "0x179B450", Slot = "32")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x179B528", Offset = "0x1797528", VA = "0x179B528", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public Gender gender
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x179B624", Offset = "0x1797624", VA = "0x179B624", Slot = "33")]
			get
			{
				return default(Gender);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x179B6FC", Offset = "0x17976FC", VA = "0x179B6FC", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int age
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x179B7F4", Offset = "0x17977F4", VA = "0x179B7F4", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x179B8CC", Offset = "0x17978CC", VA = "0x179B8CC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public string contentURL
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x179B9C4", Offset = "0x17979C4", VA = "0x179B9C4", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x179BA9C", Offset = "0x1797A9C", VA = "0x179BA9C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool locationCollectionEnabled
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x179B278", Offset = "0x1797278", VA = "0x179B278", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x179B354", Offset = "0x1797354", VA = "0x179B354", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1795450", Offset = "0x1791450", VA = "0x1795450")]
		public CASSettingsClient()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1795618", Offset = "0x1791618", VA = "0x1795618")]
		public string GetSDKVersion()
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17960FC", Offset = "0x17920FC", VA = "0x17960FC")]
		public void ValidateIntegration()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x17957C8", Offset = "0x17917C8", VA = "0x17957C8")]
		public void ReportCustomRevenue(string json)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17962B0", Offset = "0x17922B0", VA = "0x17962B0")]
		public string GetActiveMediationPattern()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1796388", Offset = "0x1792388", VA = "0x1796388")]
		public bool IsActiveMediationNetwork(AdNetwork net)
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x179AE70", Offset = "0x1796E70", VA = "0x179AE70", Slot = "25")]
		public void SetTestDeviceIds(IList<string> testDeviceIds)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x179B0E0", Offset = "0x17970E0", VA = "0x179B0E0", Slot = "7")]
		public void RestartInterstitialInterval()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x179BB60", Offset = "0x1797B60", VA = "0x179BB60", Slot = "40")]
		public void SetKeywords(IList<string> keywords)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x17956F0", Offset = "0x17916F0", VA = "0x17956F0")]
		public float GetDeviceScreenScale()
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x179BDD0", Offset = "0x1797DD0", VA = "0x179BDD0", Slot = "41")]
		public ConsentStatus GetVendorConsent(int vendorId)
		{
			return default(ConsentStatus);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x179BEDC", Offset = "0x1797EDC", VA = "0x179BEDC", Slot = "42")]
		public ConsentStatus GetAdditionalConsent(int providerId)
		{
			return default(ConsentStatus);
		}
	}
	[Token(Token = "0x200001E")]
	internal sealed class CASViewClient : CASViewBase, CASCallback.Handler
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x60")]
		private readonly AndroidJavaObject _bridge;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x68")]
		private CASCallback _callback;

		[Token(Token = "0x17000046")]
		public override bool isReady
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x179BFE8", Offset = "0x1797FE8", VA = "0x179BFE8", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public override int refreshInterval
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x179C0C0", Offset = "0x17980C0", VA = "0x179C0C0", Slot = "25")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x179C198", Offset = "0x1798198", VA = "0x179C198", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1799B8C", Offset = "0x1795B8C", VA = "0x1799B8C")]
		internal CASViewClient(CASManagerBase manager, AdSize size)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x179C290", Offset = "0x1798290", VA = "0x179C290", Slot = "28")]
		internal override void DestroyNative()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x179C354", Offset = "0x1798354", VA = "0x179C354", Slot = "22")]
		internal override void Enable()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x179C418", Offset = "0x1798418", VA = "0x179C418", Slot = "23")]
		public override void LoadNative()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x179C4DC", Offset = "0x17984DC", VA = "0x179C4DC", Slot = "24")]
		public override void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x179C614", Offset = "0x1798614", VA = "0x179C614", Slot = "29")]
		protected override void SetPositionNative(int position, int x, int y)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x179C794", Offset = "0x1798794", VA = "0x179C794", Slot = "30")]
		protected override void SetPositionPxNative(int position, int x, int y)
		{
		}
	}
}
namespace CAS.AdObject
{
	[Token(Token = "0x200001F")]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/App-Open-Ad-object")]
	[DisallowMultipleComponent]
	[AddComponentMenu("CleverAdsSolutions/AppOpen Ad Object")]
	public sealed class AppOpenAdObject : MonoBehaviour
	{
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x20")]
		public ManagerIndex managerId;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool autoshow;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnAdLoaded;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x38")]
		public CASUEventWithError OnAdFailedToLoad;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x40")]
		public CASUEventWithError OnAdFailedToShow;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnAdShown;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnAdClicked;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent OnAdClosed;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x60")]
		public CASUEventWithMeta OnAdImpression;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x68")]
		private IMediationManager manager;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x70")]
		private bool loadAdOnAwake;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x179C914", Offset = "0x1798914", VA = "0x179C914")]
		public void Load()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x179C9CC", Offset = "0x17989CC", VA = "0x179C9CC")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x179CA80", Offset = "0x1798A80", VA = "0x179CA80")]
		public void Show()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x179CBB0", Offset = "0x1798BB0", VA = "0x179CBB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x179CCC0", Offset = "0x1798CC0", VA = "0x179CCC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x179D1B4", Offset = "0x17991B4", VA = "0x179D1B4")]
		private void OnManagerReady(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x179D5F0", Offset = "0x17995F0", VA = "0x179D5F0")]
		private void AdFailedToLoad(AdError error)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x179D664", Offset = "0x1799664", VA = "0x179D664")]
		private void AdFailedToShow(string error)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x179D6CC", Offset = "0x17996CC", VA = "0x179D6CC")]
		private void AppForeground()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x179D754", Offset = "0x1799754", VA = "0x179D754")]
		public AppOpenAdObject()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AddComponentMenu("CleverAdsSolutions/Banner Ad Object")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/Banner-Ad-object")]
	public sealed class BannerAdObject : MonoBehaviour
	{
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		public ManagerIndex managerId;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AdPosition adPosition;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("For greater control over where a AdView is placed on screen. Use Density-independent Pixels (DP).")]
		private Vector2Int adOffset;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AdSize adSize;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent OnAdLoaded;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x40")]
		public CASUEventWithError OnAdFailedToLoad;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnAdShown;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnAdClicked;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent OnAdHidden;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x60")]
		public CASUEventWithMeta OnAdImpression;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x68")]
		private IMediationManager manager;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x70")]
		private IAdView adView;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x78")]
		private bool loadAdOnAwake;

		[Token(Token = "0x17000048")]
		public static BannerAdObject Instance
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x179D75C", Offset = "0x179975C", VA = "0x179D75C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x179D7A4", Offset = "0x17997A4", VA = "0x179D7A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Rect rectInPixels
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x179E068", Offset = "0x179A068", VA = "0x179E068")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x179D7F0", Offset = "0x17997F0", VA = "0x179D7F0")]
		public void SetAdPosition(AdPosition position)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x179D8E0", Offset = "0x17998E0", VA = "0x179D8E0")]
		public void SetAdPosition(int x, int y, AdPosition position = AdPosition.TopLeft)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x179D9C0", Offset = "0x17999C0", VA = "0x179D9C0")]
		public void SetAdSize(AdSize size)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x179DFB4", Offset = "0x1799FB4", VA = "0x179DFB4")]
		public void LoadAd()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x179E118", Offset = "0x179A118", VA = "0x179E118")]
		public void SetAdPositionEnumIndex(int enumIndex)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x179E11C", Offset = "0x179A11C", VA = "0x179E11C")]
		public void SetAdSizeEnumIndex(int enumIndex)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x179E124", Offset = "0x179A124", VA = "0x179E124")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x179E170", Offset = "0x179A170", VA = "0x179E170")]
		private void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x179E280", Offset = "0x179A280", VA = "0x179E280")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x179E43C", Offset = "0x179A43C", VA = "0x179E43C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x179E500", Offset = "0x179A500", VA = "0x179E500")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x179E998", Offset = "0x179A998", VA = "0x179E998")]
		private void OnManagerReady(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x179E63C", Offset = "0x179A63C", VA = "0x179E63C")]
		private void DetachAdView()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x179D9C8", Offset = "0x17999C8", VA = "0x179D9C8")]
		private void RefreshLinkWithAdView()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x179EA98", Offset = "0x179AA98", VA = "0x179EA98")]
		private void AdLoaded(IAdView ad)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x179EAEC", Offset = "0x179AAEC", VA = "0x179EAEC")]
		private void AdLoadFailed(IAdView ad, AdError error)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x179EB90", Offset = "0x179AB90", VA = "0x179EB90")]
		private void AdImpression(IAdView ad, AdMetaData impression)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x179EBE8", Offset = "0x179ABE8", VA = "0x179EBE8")]
		private void AdClicked(IAdView view)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x179EC10", Offset = "0x179AC10", VA = "0x179EC10")]
		public BannerAdObject()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/User-Consent-Flow#inspector-implementation")]
	[DisallowMultipleComponent]
	[AddComponentMenu("CleverAdsSolutions/Consent Flow Ad Object")]
	public class ConsentFlowAdObject : MonoBehaviour
	{
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal bool showOnAwakeIfRequired;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x24")]
		public ConsentFlow.DebugGeography debugGeography;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x28")]
		public string privacyPolicyUrl;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnCompleted;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x38")]
		public CASUEventWithError OnFailed;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x40")]
		public CASUToggleEvent EnableOptionsButton;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x179EC78", Offset = "0x179AC78", VA = "0x179EC78")]
		public void ShowIfRequired()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x179ED6C", Offset = "0x179AD6C", VA = "0x179ED6C")]
		public void Show()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x179EC88", Offset = "0x179AC88", VA = "0x179EC88")]
		public ConsentFlow CreateFlow()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x179ED7C", Offset = "0x179AD7C", VA = "0x179ED7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x179EE7C", Offset = "0x179AE7C", VA = "0x179EE7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x179EF18", Offset = "0x179AF18", VA = "0x179EF18")]
		private void OnManagerStateChanged(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x179F000", Offset = "0x179B000", VA = "0x179F000")]
		private void HandleFlowResult(ConsentFlow.Status status)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x179F0E8", Offset = "0x179B0E8", VA = "0x179F0E8")]
		public ConsentFlowAdObject()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/Interstitial-Ad-object")]
	[DisallowMultipleComponent]
	[AddComponentMenu("CleverAdsSolutions/Interstitial Ad Object")]
	public sealed class InterstitialAdObject : MonoBehaviour
	{
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public ManagerIndex managerId;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent OnAdLoaded;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		public CASUEventWithError OnAdFailedToLoad;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x38")]
		public CASUEventWithError OnAdFailedToShow;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent OnAdShown;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnAdClicked;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnAdClosed;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x58")]
		public CASUEventWithMeta OnAdImpression;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x60")]
		private IMediationManager manager;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x68")]
		private bool loadAdOnAwake;

		[Token(Token = "0x1700004A")]
		public bool isAdReady
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x179F140", Offset = "0x179B140", VA = "0x179F140")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x179F1F4", Offset = "0x179B1F4", VA = "0x179F1F4")]
		public void LoadAd()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x179F2AC", Offset = "0x179B2AC", VA = "0x179F2AC")]
		public void Present()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x179F3DC", Offset = "0x179B3DC", VA = "0x179F3DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x179F4EC", Offset = "0x179B4EC", VA = "0x179F4EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x179F988", Offset = "0x179B988", VA = "0x179F988")]
		private void OnManagerReady(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x179FD1C", Offset = "0x179BD1C", VA = "0x179FD1C")]
		private void AdFailedToLoad(AdError error)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x179FD90", Offset = "0x179BD90", VA = "0x179FD90")]
		private void AdFailedToShow(string error)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x179FDF8", Offset = "0x179BDF8", VA = "0x179FDF8")]
		public InterstitialAdObject()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[DisallowMultipleComponent]
	[AddComponentMenu("CleverAdsSolutions/Initialize Manager Ad Object")]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/Manager-Ad-object")]
	public class ManagerAdObject : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x20")]
		public ManagerIndex managerId;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool initializeOnAwake;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x29")]
		public bool consentFlowEnabled;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		public ConsentFlowAdObject consentFlow;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		public CCPAStatus metaDataProcessing;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x3C")]
		public ConsentStatus metaAdvertiserTracking;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent OnInitialized;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x48")]
		public CASUEventWithError OnInitializationFailed;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x179FE00", Offset = "0x179BE00", VA = "0x179FE00")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x179FEA8", Offset = "0x179BEA8", VA = "0x179FEA8")]
		public IManagerBuilder CreateBuilder()
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x17A0228", Offset = "0x179C228", VA = "0x17A0228")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x17A029C", Offset = "0x179C29C", VA = "0x17A029C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x17A0358", Offset = "0x179C358", VA = "0x17A0358")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x17A03F4", Offset = "0x179C3F4", VA = "0x17A03F4")]
		private void OnManagerReady(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x17A04D4", Offset = "0x179C4D4", VA = "0x17A04D4")]
		public ManagerAdObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class CASUEventWithError : UnityEvent<string>
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x17A04E4", Offset = "0x179C4E4", VA = "0x17A04E4")]
		public CASUEventWithError()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class CASUEventWithMeta : UnityEvent<AdMetaData>
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x17A052C", Offset = "0x179C52C", VA = "0x17A052C")]
		public CASUEventWithMeta()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class CASUToggleEvent : UnityEvent<bool>
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x17A0574", Offset = "0x179C574", VA = "0x17A0574")]
		public CASUToggleEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public struct ManagerIndex
	{
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int android;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int ios;

		[Token(Token = "0x1700004B")]
		public int index
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x17A05BC", Offset = "0x179C5BC", VA = "0x17A05BC")]
			get
			{
				return default(int);
			}
		}
	}
	[Token(Token = "0x2000028")]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/Return-To-Play-Ad-Object")]
	[AddComponentMenu("CleverAdsSolutions/Return To Play Ad Object")]
	[DisallowMultipleComponent]
	public class ReturnToPlayAdObject : MonoBehaviour
	{
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x20")]
		public ManagerIndex managerId;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _allowReturnToPlayAd;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnAdLoaded;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x38")]
		public CASUEventWithError OnAdFailedToLoad;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x40")]
		public CASUEventWithError OnAdFailedToShow;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnAdShown;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnAdClicked;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent OnAdClosed;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x60")]
		public CASUEventWithMeta OnAdImpression;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x68")]
		private IMediationManager manager;

		[Token(Token = "0x1700004C")]
		public bool allowReturnToPlayAd
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x17A05C4", Offset = "0x179C5C4", VA = "0x17A05C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x17A05CC", Offset = "0x179C5CC", VA = "0x17A05CC")]
			set
			{
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x17A0694", Offset = "0x179C694", VA = "0x17A0694")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x17A07A4", Offset = "0x179C7A4", VA = "0x17A07A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x17A0CC8", Offset = "0x179CCC8", VA = "0x17A0CC8")]
		private void OnManagerReady(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x17A1074", Offset = "0x179D074", VA = "0x17A1074")]
		private void AdFailedToLoad(AdError error)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x17A10E8", Offset = "0x179D0E8", VA = "0x17A10E8")]
		private void AdFailedToShow(string error)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x17A1150", Offset = "0x179D150", VA = "0x17A1150")]
		public ReturnToPlayAdObject()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AddComponentMenu("CleverAdsSolutions/Rewarded Ad Object")]
	[HelpURL("https://docs.page/cleveradssolutions/docs/Unity/Rewarded-Ad-object")]
	[DisallowMultipleComponent]
	public sealed class RewardedAdObject : MonoBehaviour
	{
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x20")]
		public ManagerIndex managerId;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		public bool restartInterstitialInterval;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnAdLoaded;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x38")]
		public CASUEventWithError OnAdFailedToLoad;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x40")]
		public CASUEventWithError OnAdFailedToShow;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnAdShown;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnAdClicked;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent OnAdClosed;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x60")]
		public CASUEventWithMeta OnAdImpression;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent OnReward;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x70")]
		private IMediationManager manager;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x78")]
		private bool loadAdOnAwake;

		[Token(Token = "0x1700004D")]
		public bool isAdReady
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x17A1160", Offset = "0x179D160", VA = "0x17A1160")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x17A1214", Offset = "0x179D214", VA = "0x17A1214")]
		public void LoadAd()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x17A12CC", Offset = "0x179D2CC", VA = "0x17A12CC")]
		public void Present()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x17A13FC", Offset = "0x179D3FC", VA = "0x17A13FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x17A150C", Offset = "0x179D50C", VA = "0x17A150C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x17A1A40", Offset = "0x179DA40", VA = "0x17A1A40")]
		private void OnManagerReady(int index, CASManagerBase manager)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x17A1E10", Offset = "0x179DE10", VA = "0x17A1E10")]
		private void AdFailedToLoad(AdError error)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x17A1E84", Offset = "0x179DE84", VA = "0x17A1E84")]
		private void AdFailedToShow(string error)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x17A1EEC", Offset = "0x179DEEC", VA = "0x17A1EEC")]
		private void AdClosed()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x17A1FAC", Offset = "0x179DFAC", VA = "0x17A1FAC")]
		public RewardedAdObject()
		{
		}
	}
}
