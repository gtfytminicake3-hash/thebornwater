using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x245AB28", Offset = "0x2456B28", VA = "0x245AB28")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x245ABE4", Offset = "0x2456BE4", VA = "0x245ABE4")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace GooglePlayGames
{
	[Token(Token = "0x2000004")]
	public static class GameInfo
	{
		[Token(Token = "0x4000006")]
		private const string UnescapedApplicationId = "APP_ID";

		[Token(Token = "0x4000007")]
		private const string UnescapedIosClientId = "IOS_CLIENTID";

		[Token(Token = "0x4000008")]
		private const string UnescapedWebClientId = "WEB_CLIENTID";

		[Token(Token = "0x4000009")]
		private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";

		[Token(Token = "0x400000A")]
		public const string ApplicationId = "402409140132";

		[Token(Token = "0x400000B")]
		public const string IosClientId = "__IOS_CLIENTID__";

		[Token(Token = "0x400000C")]
		public const string WebClientId = "";

		[Token(Token = "0x400000D")]
		public const string NearbyConnectionServiceId = "";

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x245ABEC", Offset = "0x2456BEC", VA = "0x245ABEC")]
		public static bool ApplicationIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x245ACCC", Offset = "0x2456CCC", VA = "0x245ACCC")]
		public static bool IosClientIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x245AD60", Offset = "0x2456D60", VA = "0x245AD60")]
		public static bool WebClientIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x245ADF4", Offset = "0x2456DF4", VA = "0x245ADF4")]
		public static bool NearbyConnectionsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x245AC80", Offset = "0x2456C80", VA = "0x245AC80")]
		private static string ToEscapedToken(string token)
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	internal delegate void ReportProgress(string id, double progress, Action<bool> callback);
	[Token(Token = "0x2000006")]
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ReportProgress mProgressCallback;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string mId;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool mIsIncremental;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int mCurrentSteps;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int mTotalSteps;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double mPercentComplete;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool mCompleted;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool mHidden;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DateTime mLastModifiedTime;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string mTitle;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string mRevealedImageUrl;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string mUnlockedImageUrl;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityWebRequest mImageFetcher;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Texture2D mImage;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string mDescription;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ulong mPoints;

		[Token(Token = "0x17000001")]
		public string id
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x245B494", Offset = "0x2457494", VA = "0x245B494", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x245B49C", Offset = "0x245749C", VA = "0x245B49C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public bool isIncremental
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x245B4A4", Offset = "0x24574A4", VA = "0x245B4A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		public int currentSteps
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x245B4AC", Offset = "0x24574AC", VA = "0x245B4AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000004")]
		public int totalSteps
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x245B4B4", Offset = "0x24574B4", VA = "0x245B4B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000005")]
		public double percentCompleted
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x245B4BC", Offset = "0x24574BC", VA = "0x245B4BC", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x245B4C4", Offset = "0x24574C4", VA = "0x245B4C4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool completed
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x245B4CC", Offset = "0x24574CC", VA = "0x245B4CC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool hidden
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x245B4D4", Offset = "0x24574D4", VA = "0x245B4D4", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public DateTime lastReportedDate
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x245B4DC", Offset = "0x24574DC", VA = "0x245B4DC", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000009")]
		public string title
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x245B4E4", Offset = "0x24574E4", VA = "0x245B4E4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public Texture2D image
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x245B4EC", Offset = "0x24574EC", VA = "0x245B4EC", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public string achievedDescription
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x245B4F0", Offset = "0x24574F0", VA = "0x245B4F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public string unachievedDescription
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x245B4F8", Offset = "0x24574F8", VA = "0x245B4F8", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public int points
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x245B500", Offset = "0x2457500", VA = "0x245B500", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x245AFE0", Offset = "0x2456FE0", VA = "0x245AFE0")]
		internal PlayGamesAchievement()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x245B12C", Offset = "0x245712C", VA = "0x245B12C")]
		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x245B1E8", Offset = "0x24571E8", VA = "0x245B1E8")]
		internal PlayGamesAchievement(Achievement ach)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x245B34C", Offset = "0x245734C", VA = "0x245B34C", Slot = "4")]
		public void ReportProgress(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x245B37C", Offset = "0x245737C", VA = "0x245B37C")]
		private Texture2D LoadImage()
		{
			return null;
		}
	}
	[Token(Token = "0x2000007")]
	public class PlayGamesLeaderboard : ILeaderboard
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UserScope mUserScope;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Range mRange;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TimeScope mTimeScope;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] mFilteredUserIds;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool mLoading;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IScore mLocalUserScore;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint mMaxRange;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PlayGamesScore> mScoreList;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string mTitle;

		[Token(Token = "0x1700000E")]
		public bool loading
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x245BB80", Offset = "0x2457B80", VA = "0x245BB80", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x245BB88", Offset = "0x2457B88", VA = "0x245BB88")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public string id
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x245BB90", Offset = "0x2457B90", VA = "0x245BB90", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x245BB98", Offset = "0x2457B98", VA = "0x245BB98", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public UserScope userScope
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x245BBA0", Offset = "0x2457BA0", VA = "0x245BBA0", Slot = "6")]
			get
			{
				return default(UserScope);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x245BBA8", Offset = "0x2457BA8", VA = "0x245BBA8", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Range range
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x245BBB0", Offset = "0x2457BB0", VA = "0x245BBB0", Slot = "7")]
			get
			{
				return default(Range);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x245BBB8", Offset = "0x2457BB8", VA = "0x245BBB8", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public TimeScope timeScope
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x245BBC0", Offset = "0x2457BC0", VA = "0x245BBC0", Slot = "8")]
			get
			{
				return default(TimeScope);
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x245BBC8", Offset = "0x2457BC8", VA = "0x245BBC8", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public IScore localUserScore
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x245BBD0", Offset = "0x2457BD0", VA = "0x245BBD0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public uint maxRange
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x245BBD8", Offset = "0x2457BD8", VA = "0x245BBD8", Slot = "16")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000015")]
		public IScore[] scores
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x245BBE0", Offset = "0x2457BE0", VA = "0x245BBE0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public string title
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x245BC78", Offset = "0x2457C78", VA = "0x245BC78", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public int ScoreCount
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x245C11C", Offset = "0x245811C", VA = "0x245C11C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x245B508", Offset = "0x2457508", VA = "0x245B508")]
		public PlayGamesLeaderboard(string id)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x245B590", Offset = "0x2457590", VA = "0x245B590", Slot = "9")]
		public void SetUserFilter(string[] userIDs)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x245B598", Offset = "0x2457598", VA = "0x245B598", Slot = "10")]
		public void LoadScores(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x245BC80", Offset = "0x2457C80", VA = "0x245BC80")]
		internal bool SetFromData(LeaderboardScoreData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x245BF78", Offset = "0x2457F78", VA = "0x245BF78")]
		internal void SetMaxRange(ulong val)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x245C10C", Offset = "0x245810C", VA = "0x245C10C")]
		internal void SetTitle(string value)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x245C114", Offset = "0x2458114", VA = "0x245C114")]
		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x245BF80", Offset = "0x2457F80", VA = "0x245BF80")]
		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x245C0A4", Offset = "0x24580A4", VA = "0x245C0A4")]
		internal bool HasAllScores()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000008")]
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal PlayGamesPlatform mPlatform;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PlayerStats mStats;

		[Token(Token = "0x17000018")]
		public IUserProfile[] friends
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x245C5A4", Offset = "0x24585A4", VA = "0x245C5A4", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public bool authenticated
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x245C6D0", Offset = "0x24586D0", VA = "0x245C6D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public bool underage
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x245C794", Offset = "0x2458794", VA = "0x245C794", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public new string userName
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x245C79C", Offset = "0x245879C", VA = "0x245C79C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public new string id
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x245CBE0", Offset = "0x2458BE0", VA = "0x245CBE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public new bool isFriend
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x245CCA4", Offset = "0x2458CA4", VA = "0x245CCA4", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public new UserState state
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x245CCAC", Offset = "0x2458CAC", VA = "0x245CCAC", Slot = "17")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x1700001F")]
		public new string AvatarURL
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x245CCB4", Offset = "0x2458CB4", VA = "0x245CCB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x245C164", Offset = "0x2458164", VA = "0x245C164")]
		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x245C230", Offset = "0x2458230", VA = "0x245C230", Slot = "9")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x245C3A0", Offset = "0x24583A0", VA = "0x245C3A0", Slot = "11")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x245C468", Offset = "0x2458468", VA = "0x245C468", Slot = "12")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x245CD78", Offset = "0x2458D78", VA = "0x245CD78")]
		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class PlayGamesPlatform : ISocialPlatform
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayGamesPlatform sInstance;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool sNearbyInitializePending;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static INearbyConnectionClient sNearbyConnectionClient;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PlayGamesLocalUser mLocalUser;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IPlayGamesClient mClient;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string mDefaultLbUi;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> mIdMap;

		[Token(Token = "0x17000020")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x245D2E4", Offset = "0x24592E4", VA = "0x245D2E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x245D36C", Offset = "0x245936C", VA = "0x245D36C")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public static PlayGamesPlatform Instance
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x245B058", Offset = "0x2457058", VA = "0x245B058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public static INearbyConnectionClient Nearby
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x245D510", Offset = "0x2459510", VA = "0x245D510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public ISavedGameClient SavedGame
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x245D758", Offset = "0x2459758", VA = "0x245D758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public IEventsClient Events
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x245D7FC", Offset = "0x24597FC", VA = "0x245D7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public ILocalUser localUser
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x245D8A0", Offset = "0x24598A0", VA = "0x245D8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x245D110", Offset = "0x2459110", VA = "0x245D110")]
		internal PlayGamesPlatform(IPlayGamesClient client)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x245D1F0", Offset = "0x24591F0", VA = "0x245D1F0")]
		private PlayGamesPlatform()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x245D5A4", Offset = "0x24595A4", VA = "0x245D5A4")]
		public static void InitializeNearby(Action<INearbyConnectionClient> callback)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x245D9C8", Offset = "0x24599C8", VA = "0x245D9C8")]
		public static PlayGamesPlatform Activate()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x245DAA4", Offset = "0x2459AA4", VA = "0x245DAA4")]
		public void AddIdMapping(string fromId, string toId)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x245C2F8", Offset = "0x24582F8", VA = "0x245C2F8")]
		public void Authenticate(Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x245DB0C", Offset = "0x2459B0C", VA = "0x245DB0C", Slot = "9")]
		public void Authenticate(ILocalUser unused, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x245DBCC", Offset = "0x2459BCC", VA = "0x245DBCC", Slot = "11")]
		public void Authenticate(ILocalUser unused, Action<bool, string> callback)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x245DC8C", Offset = "0x2459C8C", VA = "0x245DC8C")]
		public void ManuallyAuthenticate(Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x245C6E4", Offset = "0x24586E4", VA = "0x245C6E4")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x245DD38", Offset = "0x2459D38", VA = "0x245DD38")]
		public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x245DF9C", Offset = "0x2459F9C", VA = "0x245DF9C")]
		public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x245E108", Offset = "0x245A108", VA = "0x245E108")]
		public void RequestRecallAccess(Action<RecallAccess> callback)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x245E1DC", Offset = "0x245A1DC", VA = "0x245E1DC", Slot = "12")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x245C97C", Offset = "0x245897C", VA = "0x245C97C")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x245CE74", Offset = "0x2458E74", VA = "0x245CE74")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x245C860", Offset = "0x2458860", VA = "0x245C860")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x245CA90", Offset = "0x2458A90", VA = "0x245CA90")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x245E328", Offset = "0x245A328", VA = "0x245E328", Slot = "5")]
		public void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x245E778", Offset = "0x245A778", VA = "0x245E778")]
		internal static int progressToSteps(double progress, int totalSteps)
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x245E7B4", Offset = "0x245A7B4", VA = "0x245E7B4")]
		public void RevealAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x245E944", Offset = "0x245A944", VA = "0x245E944")]
		public void UnlockAchievement(string achievementID, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x245EAD4", Offset = "0x245AAD4", VA = "0x245EAD4")]
		public void IncrementAchievement(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x245EC9C", Offset = "0x245AC9C", VA = "0x245EC9C")]
		public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x245EE64", Offset = "0x245AE64", VA = "0x245EE64", Slot = "13")]
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x245F00C", Offset = "0x245B00C", VA = "0x245F00C", Slot = "14")]
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x245F1A4", Offset = "0x245B1A4", VA = "0x245F1A4", Slot = "15")]
		public IAchievement CreateAchievement()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x245F1F4", Offset = "0x245B1F4", VA = "0x245F1F4", Slot = "6")]
		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x245F3BC", Offset = "0x245B3BC", VA = "0x245F3BC")]
		public void ReportScore(long score, string board, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x245F614", Offset = "0x245B614", VA = "0x245F614", Slot = "16")]
		public void LoadScores(string leaderboardId, Action<IScore[]> callback)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x245F774", Offset = "0x245B774", VA = "0x245F774")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x245F908", Offset = "0x245B908", VA = "0x245F908")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x245FA74", Offset = "0x245BA74", VA = "0x245FA74", Slot = "17")]
		public ILeaderboard CreateLeaderboard()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x245FAD0", Offset = "0x245BAD0", VA = "0x245FAD0", Slot = "7")]
		public void ShowAchievementsUI()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x245FAD8", Offset = "0x245BAD8", VA = "0x245FAD8")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x245FC48", Offset = "0x245BC48", VA = "0x245FC48", Slot = "8")]
		public void ShowLeaderboardUI()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x245FCDC", Offset = "0x245BCDC", VA = "0x245FCDC")]
		public void ShowLeaderboardUI(string leaderboardId)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x245FCD0", Offset = "0x245BCD0", VA = "0x245FCD0")]
		public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x245FD08", Offset = "0x245BD08", VA = "0x245FD08")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x245FEE0", Offset = "0x245BEE0", VA = "0x245FEE0")]
		public void SetDefaultLeaderboardForUI(string lbid)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x245C480", Offset = "0x2458480", VA = "0x245C480", Slot = "18")]
		public void LoadFriends(ILocalUser user, Action<bool> callback)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x245B5C8", Offset = "0x24575C8", VA = "0x245B5C8", Slot = "19")]
		public void LoadScores(ILeaderboard board, Action<bool> callback)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x245FF94", Offset = "0x245BF94", VA = "0x245FF94", Slot = "10")]
		public bool GetLoading(ILeaderboard board)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x246003C", Offset = "0x245C03C", VA = "0x246003C")]
		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2460220", Offset = "0x245C220", VA = "0x2460220")]
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x24603BC", Offset = "0x245C3BC", VA = "0x24603BC")]
		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2460550", Offset = "0x245C550", VA = "0x2460550")]
		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2460650", Offset = "0x245C650", VA = "0x2460650")]
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2460790", Offset = "0x245C790", VA = "0x2460790")]
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x24608C8", Offset = "0x245C8C8", VA = "0x24608C8")]
		internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x245C5B8", Offset = "0x24585B8", VA = "0x245C5B8")]
		internal IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x245E668", Offset = "0x245A668", VA = "0x245E668")]
		private string MapId(string id)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		[Token(Token = "0x6000087")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}
	}
	[Token(Token = "0x200001A")]
	public class PlayGamesScore : IScore
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mLbId;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long mValue;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ulong mRank;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string mPlayerId;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string mMetadata;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DateTime mDate;

		[Token(Token = "0x17000026")]
		public string leaderboardID
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x24615D4", Offset = "0x245D5D4", VA = "0x24615D4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x24615DC", Offset = "0x245D5DC", VA = "0x24615DC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public long value
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x24615E4", Offset = "0x245D5E4", VA = "0x24615E4", Slot = "7")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x24615EC", Offset = "0x245D5EC", VA = "0x24615EC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public DateTime date
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x24615F4", Offset = "0x245D5F4", VA = "0x24615F4", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000029")]
		public string formattedValue
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x24615FC", Offset = "0x245D5FC", VA = "0x24615FC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public string userID
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2461608", Offset = "0x245D608", VA = "0x2461608", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public int rank
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2461610", Offset = "0x245D610", VA = "0x2461610", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public string metaData
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2461618", Offset = "0x245D618", VA = "0x2461618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x24614DC", Offset = "0x245D4DC", VA = "0x24614DC")]
		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x24615A0", Offset = "0x245D5A0", VA = "0x24615A0", Slot = "4")]
		public void ReportScore(Action<bool> callback)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class PlayGamesUserProfile : IUserProfile
	{
		[Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <LoadImage>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayGamesUserProfile <>4__this;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x2461E30", Offset = "0x245DE30", VA = "0x2461E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0x2461E70", Offset = "0x245DE70", VA = "0x2461E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2461A30", Offset = "0x245DA30", VA = "0x2461A30")]
			[DebuggerHidden]
			public <LoadImage>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2461C6C", Offset = "0x245DC6C", VA = "0x2461C6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2461C70", Offset = "0x245DC70", VA = "0x2461C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2461E38", Offset = "0x245DE38", VA = "0x2461E38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mDisplayName;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string mPlayerId;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string mAvatarUrl;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mIsFriend;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mImageLoading;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D mImage;

		[Token(Token = "0x1700002D")]
		public string userName
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x246173C", Offset = "0x245D73C", VA = "0x246173C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public string id
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2461744", Offset = "0x245D744", VA = "0x2461744", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public string gameId
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x246174C", Offset = "0x245D74C", VA = "0x246174C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public bool isFriend
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2461754", Offset = "0x245D754", VA = "0x2461754", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public UserState state
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x246175C", Offset = "0x245D75C", VA = "0x246175C", Slot = "7")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x17000032")]
		public Texture2D image
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2461764", Offset = "0x245D764", VA = "0x2461764", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public string AvatarURL
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2461A28", Offset = "0x245DA28", VA = "0x2461A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x245C1E4", Offset = "0x24581E4", VA = "0x245C1E4")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x24616F0", Offset = "0x245D6F0", VA = "0x24616F0")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl, bool isFriend)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x245CB90", Offset = "0x2458B90", VA = "0x245CB90")]
		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x246188C", Offset = "0x245D88C", VA = "0x246188C")]
		[IteratorStateMachine(typeof(<LoadImage>d__23))]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2461A58", Offset = "0x245DA58", VA = "0x2461A58", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2461B70", Offset = "0x245DB70", VA = "0x2461B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2461C20", Offset = "0x245DC20", VA = "0x2461C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2461620", Offset = "0x245D620", VA = "0x2461620")]
		private void setAvatarUrl(string avatarUrl)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class NearbyConnectionClientFactory
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x245D8B0", Offset = "0x24598B0", VA = "0x245D8B0")]
		public static void Create(Action<INearbyConnectionClient> callback)
		{
		}
	}
	[Token(Token = "0x200001E")]
	internal class PlayGamesClientFactory
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x245D3FC", Offset = "0x24593FC", VA = "0x245D3FC")]
		internal static IPlayGamesClient GetPlatformPlayGamesClient()
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2462218", Offset = "0x245E218", VA = "0x2462218")]
		public PlayGamesClientFactory()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class PluginVersion
	{
		[Token(Token = "0x400005C")]
		public const int VersionInt = 131072;

		[Token(Token = "0x400005D")]
		public const string VersionString = "2.1.0";

		[Token(Token = "0x400005E")]
		public const string VersionKey = "20100";

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2462220", Offset = "0x245E220", VA = "0x2462220")]
		public PluginVersion()
		{
		}
	}
}
namespace GooglePlayGames.Android
{
	[Token(Token = "0x2000020")]
	public class AndroidClient : IPlayGamesClient
	{
		[Token(Token = "0x2000021")]
		private enum AuthState
		{
			[Token(Token = "0x400006E")]
			Unauthenticated,
			[Token(Token = "0x400006F")]
			Authenticated
		}

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object GameServicesLock;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object AuthStateLock;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string PlayGamesSdkClassName;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ISavedGameClient mSavedGameClient;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEventsClient mEventsClient;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Player mUser;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AuthState mAuthState;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IUserProfile[] mFriends;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoadFriendsStatus mLastLoadFriendsStatus;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AndroidJavaClass mGamesClass;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string TasksClassName;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AndroidJavaObject mFriendsResolutionException;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly int mLeaderboardMaxResults;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private readonly int mFriendsMaxResults;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x24620C0", Offset = "0x245E0C0", VA = "0x24620C0")]
		internal AndroidClient()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x24623D4", Offset = "0x245E3D4", VA = "0x24623D4")]
		private static void InitializeSdk()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x246276C", Offset = "0x245E76C", VA = "0x246276C", Slot = "4")]
		public void Authenticate(Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2462CEC", Offset = "0x245ECEC", VA = "0x2462CEC", Slot = "5")]
		public void ManuallyAuthenticate(Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2462778", Offset = "0x245E778", VA = "0x2462778")]
		private void Authenticate(bool isAutoSignIn, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2462F58", Offset = "0x245EF58", VA = "0x2462F58")]
		private void SignInOnResult(bool isAuthenticated, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x24637CC", Offset = "0x245F7CC", VA = "0x24637CC", Slot = "7")]
		public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2463C80", Offset = "0x245FC80", VA = "0x2463C80", Slot = "8")]
		public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2464568", Offset = "0x2460568", VA = "0x2464568")]
		private AuthResponse ToAuthResponse(AndroidJavaObject result)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x246441C", Offset = "0x246041C", VA = "0x246441C")]
		private AndroidJavaObject getJavaScopeEnum(AuthScope scope)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2464C78", Offset = "0x2460C78", VA = "0x2464C78", Slot = "9")]
		public void RequestRecallAccessToken(Action<RecallAccess> callback)
		{
		}

		[Token(Token = "0x60000D2")]
		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x246511C", Offset = "0x246111C", VA = "0x246511C")]
		private static void InvokeCallbackOnGameThread(Action callback)
		{
		}

		[Token(Token = "0x60000D4")]
		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		[Token(Token = "0x60000D5")]
		private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x24653F8", Offset = "0x24613F8", VA = "0x24653F8", Slot = "6")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x24654C4", Offset = "0x24614C4", VA = "0x24654C4", Slot = "11")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x24654DC", Offset = "0x24614DC", VA = "0x24654DC")]
		private void LoadAllFriends(int pageSize, bool forceReload, bool loadMore, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2465A94", Offset = "0x2461A94", VA = "0x2465A94", Slot = "26")]
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2465AA4", Offset = "0x2461AA4", VA = "0x2465AA4", Slot = "27")]
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x24655C0", Offset = "0x24615C0", VA = "0x24655C0")]
		private void LoadFriendsPaginated(int pageSize, bool isLoadMore, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2465ABC", Offset = "0x2461ABC", VA = "0x2465ABC")]
		private static bool IsApiException(AndroidJavaObject exception)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2465C48", Offset = "0x2461C48", VA = "0x2465C48", Slot = "23")]
		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2465C50", Offset = "0x2461C50", VA = "0x2465C50", Slot = "22")]
		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x246653C", Offset = "0x246253C", VA = "0x246653C", Slot = "24")]
		public void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2466A68", Offset = "0x2462A68", VA = "0x2466A68", Slot = "25")]
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2466E18", Offset = "0x2462E18", VA = "0x2466E18", Slot = "36")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2466E20", Offset = "0x2462E20", VA = "0x2466E20", Slot = "10")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2466E60", Offset = "0x2462E60", VA = "0x2466E60", Slot = "12")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2466EA0", Offset = "0x2462EA0", VA = "0x2466EA0", Slot = "13")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2466EE0", Offset = "0x2462EE0", VA = "0x2466EE0", Slot = "14")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2467354", Offset = "0x2463354", VA = "0x2467354", Slot = "15")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x24678E4", Offset = "0x24638E4", VA = "0x24678E4", Slot = "16")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2467D58", Offset = "0x2463D58", VA = "0x2467D58", Slot = "17")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2467FA4", Offset = "0x2463FA4", VA = "0x2467FA4", Slot = "18")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x24681F0", Offset = "0x24641F0", VA = "0x24681F0", Slot = "19")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x24684A4", Offset = "0x24644A4", VA = "0x24684A4", Slot = "20")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2468758", Offset = "0x2464758", VA = "0x2468758", Slot = "21")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2468BD8", Offset = "0x2464BD8", VA = "0x2468BD8", Slot = "31")]
		public int LeaderboardMaxResults()
		{
			return default(int);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2468BE0", Offset = "0x2464BE0", VA = "0x2468BE0", Slot = "28")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2469528", Offset = "0x2465528", VA = "0x2469528", Slot = "29")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2469B20", Offset = "0x2465B20", VA = "0x2469B20", Slot = "30")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2469FB8", Offset = "0x2465FB8", VA = "0x2469FB8")]
		private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x246B18C", Offset = "0x246718C", VA = "0x246B18C", Slot = "32")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x246B42C", Offset = "0x246742C", VA = "0x246B42C", Slot = "33")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x246B714", Offset = "0x2467714", VA = "0x246B714", Slot = "34")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x246B7D8", Offset = "0x24677D8", VA = "0x246B7D8", Slot = "35")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2467C84", Offset = "0x2463C84", VA = "0x2467C84")]
		private AndroidJavaObject getAchievementsClient()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x24636F8", Offset = "0x245F6F8", VA = "0x24636F8")]
		private AndroidJavaObject getPlayersClient()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2469A28", Offset = "0x2465A28", VA = "0x2469A28")]
		private AndroidJavaObject getLeaderboardsClient()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2467280", Offset = "0x2463280", VA = "0x2467280")]
		private AndroidJavaObject getPlayerStatsClient()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2462D00", Offset = "0x245ED00", VA = "0x2462D00")]
		private AndroidJavaObject getGamesSignInClient()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2465048", Offset = "0x2461048", VA = "0x2465048")]
		private AndroidJavaObject getRecallClient()
		{
			return null;
		}
	}
	[Token(Token = "0x200003D")]
	internal class AndroidEventsClient : IEventsClient
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mEventsClient;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x246C850", Offset = "0x2468850", VA = "0x246C850")]
		public AndroidEventsClient()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2471818", Offset = "0x246D818", VA = "0x2471818", Slot = "4")]
		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2471B20", Offset = "0x246DB20", VA = "0x2471B20", Slot = "5")]
		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2471E90", Offset = "0x246DE90", VA = "0x2471E90", Slot = "6")]
		public void IncrementEvent(string eventId, uint stepsToIncrement)
		{
		}

		[Token(Token = "0x6000145")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2471FB8", Offset = "0x246DFB8", VA = "0x2471FB8")]
		private static Event CreateEvent(AndroidJavaObject eventJava)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	internal class AndroidHelperFragment
	{
		[Token(Token = "0x40000B3")]
		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x24625D8", Offset = "0x245E5D8", VA = "0x24625D8")]
		public static AndroidJavaObject GetActivity()
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2473104", Offset = "0x246F104", VA = "0x2473104")]
		public static AndroidJavaObject GetDefaultPopupView()
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x246881C", Offset = "0x246481C", VA = "0x246881C")]
		public static void ShowAchievementsUI(Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x24733E8", Offset = "0x246F3E8", VA = "0x24733E8")]
		public static void ShowCaptureOverlayUI()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2468CEC", Offset = "0x2464CEC", VA = "0x2468CEC")]
		public static void ShowAllLeaderboardsUI(Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x24690A8", Offset = "0x24650A8", VA = "0x24690A8")]
		public static void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan timeSpan, Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x24665D8", Offset = "0x24625D8", VA = "0x24665D8")]
		public static void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x246DA68", Offset = "0x2469A68", VA = "0x246DA68")]
		public static void IsResolutionRequired(AndroidJavaObject friendsSharingConsentException, Action<bool> cb)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2466134", Offset = "0x2462134", VA = "0x2466134")]
		public static void AskForLoadFriendsResolution(AndroidJavaObject friendsSharingConsentException, Action<UIStatus> cb)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x24735EC", Offset = "0x246F5EC", VA = "0x24735EC")]
		public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, Action<SelectUIStatus, ISavedGameMetadata> cb)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2473B1C", Offset = "0x246FB1C", VA = "0x2473B1C")]
		public AndroidHelperFragment()
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class AndroidJavaConverter
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x246B0F8", Offset = "0x24670F8", VA = "0x246B0F8")]
		internal static DateTime ToDateTime(long milliseconds)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2469AFC", Offset = "0x2465AFC", VA = "0x2469AFC")]
		internal static int ToLeaderboardVariantTimeSpan(LeaderboardTimeSpan span)
		{
			return default(int);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2469B10", Offset = "0x2465B10", VA = "0x2469B10")]
		internal static int ToLeaderboardVariantCollection(LeaderboardCollection collection)
		{
			return default(int);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2469FA0", Offset = "0x2465FA0", VA = "0x2469FA0")]
		internal static int ToPageDirection(ScorePageDirection direction)
		{
			return default(int);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x246C400", Offset = "0x2468400", VA = "0x246C400")]
		internal static Player ToPlayer(AndroidJavaObject player)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2474400", Offset = "0x2470400", VA = "0x2474400")]
		internal static PlayerProfile ToPlayerProfile(AndroidJavaObject player)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x247475C", Offset = "0x247075C", VA = "0x247475C")]
		internal static List<string> ToStringList(AndroidJavaObject stringList)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2474A18", Offset = "0x2470A18", VA = "0x2474A18")]
		internal static AndroidJavaObject ToJavaStringList(List<string> list)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x246E7AC", Offset = "0x246A7AC", VA = "0x246E7AC")]
		internal static FriendsListVisibilityStatus ToFriendsListVisibilityStatus(int playerListVisibility)
		{
			return default(FriendsListVisibilityStatus);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x246D5E4", Offset = "0x24695E4", VA = "0x246D5E4")]
		internal static IUserProfile[] playersBufferToArray(AndroidJavaObject playersBuffer)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2474C08", Offset = "0x2470C08", VA = "0x2474C08")]
		public AndroidJavaConverter()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class AndroidNearbyConnectionClient : INearbyConnectionClient
	{
		[Token(Token = "0x200004B")]
		private class AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy
		{
			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action<AdvertisingResult> mResultCallback;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Action<ConnectionRequest> mConnectionRequestCallback;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AndroidNearbyConnectionClient mClient;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string mLocalEndpointName;

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x247596C", Offset = "0x247196C", VA = "0x247596C")]
			public AdvertisingConnectionLifecycleCallbackProxy(Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback, AndroidNearbyConnectionClient client)
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x247835C", Offset = "0x247435C", VA = "0x247835C")]
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2478508", Offset = "0x2474508", VA = "0x2478508")]
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x24787D8", Offset = "0x24747D8", VA = "0x24787D8")]
			public void onDisconnected(string endpointId)
			{
			}
		}

		[Token(Token = "0x200004C")]
		private class PayloadCallback : AndroidJavaProxy
		{
			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IMessageListener mListener;

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2476894", Offset = "0x2472894", VA = "0x2476894")]
			public PayloadCallback(IMessageListener listener)
			{
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2478898", Offset = "0x2474898", VA = "0x2478898")]
			public void onPayloadReceived(string endpointId, AndroidJavaObject payload)
			{
			}
		}

		[Token(Token = "0x200004D")]
		private class DiscoveringConnectionLifecycleCallback : AndroidJavaProxy
		{
			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action<ConnectionResponse> mResponseCallback;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IMessageListener mListener;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AndroidJavaObject mClient;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2476454", Offset = "0x2472454", VA = "0x2476454")]
			public DiscoveringConnectionLifecycleCallback(Action<ConnectionResponse> responseCallback, IMessageListener listener, AndroidJavaObject client)
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2478AA8", Offset = "0x2474AA8", VA = "0x2478AA8")]
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2478DDC", Offset = "0x2474DDC", VA = "0x2478DDC")]
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0x24791AC", Offset = "0x24751AC", VA = "0x24791AC")]
			public void onDisconnected(string endpointId)
			{
			}
		}

		[Token(Token = "0x200004E")]
		private class EndpointDiscoveryCallback : AndroidJavaProxy
		{
			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IDiscoveryListener mListener;

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2476FE4", Offset = "0x2472FE4", VA = "0x2476FE4")]
			public EndpointDiscoveryCallback(IDiscoveryListener listener)
			{
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2479258", Offset = "0x2475258", VA = "0x2479258")]
			public void onEndpointFound(string endpointId, AndroidJavaObject endpointInfo)
			{
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x24794D8", Offset = "0x24754D8", VA = "0x24794D8")]
			public void onEndpointLost(string endpointId)
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x247934C", Offset = "0x247534C", VA = "0x247934C")]
			private EndpointDetails CreateEndPointDetails(string endpointId, AndroidJavaObject endpointInfo)
			{
				return default(EndpointDetails);
			}
		}

		[Token(Token = "0x200004F")]
		private class OnGameThreadMessageListener : IMessageListener
		{
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IMessageListener mListener;

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x24763EC", Offset = "0x24723EC", VA = "0x24763EC")]
			public OnGameThreadMessageListener(IMessageListener listener)
			{
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x2479584", Offset = "0x2475584", VA = "0x2479584", Slot = "4")]
			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
			{
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x2479680", Offset = "0x2475680", VA = "0x2479680", Slot = "5")]
			public void OnRemoteEndpointDisconnected(string remoteEndpointId)
			{
			}
		}

		[Token(Token = "0x2000052")]
		private class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IDiscoveryListener mListener;

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2476FBC", Offset = "0x2472FBC", VA = "0x2476FBC")]
			public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
			{
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x24798D8", Offset = "0x24758D8", VA = "0x24798D8", Slot = "4")]
			public void OnEndpointFound(EndpointDetails discoveredEndpoint)
			{
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x24799C8", Offset = "0x24759C8", VA = "0x24799C8", Slot = "5")]
			public void OnEndpointLost(string lostEndpointId)
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mClient;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly long NearbyClientId;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int ApplicationInfoFlags;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string ServiceId;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected IMessageListener mAdvertisingMessageListener;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2461E78", Offset = "0x245DE78", VA = "0x2461E78")]
		public AndroidNearbyConnectionClient()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2474D84", Offset = "0x2470D84", VA = "0x2474D84", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2474D8C", Offset = "0x2470D8C", VA = "0x2474D8C", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2474D94", Offset = "0x2470D94", VA = "0x2474D94", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2475200", Offset = "0x2471200", VA = "0x2475200", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2474D98", Offset = "0x2470D98", VA = "0x2474D98")]
		private void InternalSend(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2475204", Offset = "0x2471204", VA = "0x2475204", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2475A04", Offset = "0x2471A04", VA = "0x2475A04")]
		private AndroidJavaObject CreateAdvertisingOptions()
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2475F20", Offset = "0x2471F20", VA = "0x2475F20", Slot = "9")]
		public void StopAdvertising()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2475FF0", Offset = "0x2471FF0", VA = "0x2475FF0", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x24764EC", Offset = "0x24724EC", VA = "0x24764EC", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2476918", Offset = "0x2472918", VA = "0x2476918", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingDuration, IDiscoveryListener listener)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2477068", Offset = "0x2473068", VA = "0x2477068")]
		private AndroidJavaObject CreateDiscoveryOptions()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2477584", Offset = "0x2473584", VA = "0x2477584", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x247764C", Offset = "0x247364C", VA = "0x247764C", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x24777F0", Offset = "0x24737F0", VA = "0x24777F0", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x24778B8", Offset = "0x24738B8", VA = "0x24778B8", Slot = "16")]
		public void StopAllConnections()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2477988", Offset = "0x2473988", VA = "0x2477988", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2477B50", Offset = "0x2473B50", VA = "0x2477B50", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2477BA8", Offset = "0x2473BA8", VA = "0x2477BA8")]
		private static string ReadServiceId()
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	internal class AndroidSavedGameClient : ISavedGameClient
	{
		[Token(Token = "0x200005C")]
		private class AndroidConflictResolver : IConflictResolver
		{
			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly AndroidJavaObject mSnapshotsClient;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly AndroidJavaObject mConflict;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly AndroidSnapshotMetadata mOriginal;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly AndroidSnapshotMetadata mUnmerged;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly Action<SavedGameRequestStatus, ISavedGameMetadata> mCompleteCallback;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly Action mRetryFileOpen;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly AndroidSavedGameClient mAndroidSavedGameClient;

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x247C110", Offset = "0x2478110", VA = "0x247C110")]
			internal AndroidConflictResolver(AndroidSavedGameClient androidSavedGameClient, AndroidJavaObject snapshotClient, AndroidJavaObject conflict, AndroidSnapshotMetadata original, AndroidSnapshotMetadata unmerged, Action<SavedGameRequestStatus, ISavedGameMetadata> completeCallback, Action retryOpen)
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x247C238", Offset = "0x2478238", VA = "0x247C238", Slot = "5")]
			public void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x247CB1C", Offset = "0x2478B1C", VA = "0x247CB1C", Slot = "4")]
			public void ChooseMetadata(ISavedGameMetadata chosenMetadata)
			{
			}
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex ValidFilenameRegex;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mSnapshotsClient;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AndroidClient mAndroidClient;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x246C624", Offset = "0x2468624", VA = "0x246C624")]
		public AndroidSavedGameClient(AndroidClient androidClient)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2479D18", Offset = "0x2475D18", VA = "0x2479D18", Slot = "4")]
		public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x247A428", Offset = "0x2476428", VA = "0x247A428", Slot = "5")]
		public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x247A088", Offset = "0x2476088", VA = "0x247A088")]
		private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x247A600", Offset = "0x2476600", VA = "0x247A600", Slot = "6")]
		public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x247A954", Offset = "0x2476954", VA = "0x247A954", Slot = "7")]
		public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x247AABC", Offset = "0x2476ABC", VA = "0x247AABC", Slot = "8")]
		public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x247BB4C", Offset = "0x2477B4C", VA = "0x247BB4C", Slot = "9")]
		public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x247BEA4", Offset = "0x2477EA4", VA = "0x247BEA4", Slot = "10")]
		public void Delete(ISavedGameMetadata metadata)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2479F60", Offset = "0x2475F60", VA = "0x2479F60")]
		private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x247A008", Offset = "0x2476008", VA = "0x247A008")]
		internal static bool IsValidFilename(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x247B15C", Offset = "0x247715C", VA = "0x247B15C")]
		private static AndroidJavaObject AsMetadataChange(SavedGameMetadataUpdate update)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	internal class AndroidSnapshotMetadata : ISavedGameMetadata
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mJavaSnapshot;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AndroidJavaObject mJavaMetadata;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AndroidJavaObject mJavaContents;

		[Token(Token = "0x17000036")]
		public AndroidJavaObject JavaSnapshot
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x247EC54", Offset = "0x247AC54", VA = "0x247EC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public AndroidJavaObject JavaMetadata
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x247EC5C", Offset = "0x247AC5C", VA = "0x247EC5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public AndroidJavaObject JavaContents
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x247EC64", Offset = "0x247AC64", VA = "0x247EC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public bool IsOpen
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x247A86C", Offset = "0x247686C", VA = "0x247A86C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public string Filename
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x247EC6C", Offset = "0x247AC6C", VA = "0x247EC6C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public string Description
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x247ED44", Offset = "0x247AD44", VA = "0x247ED44", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public string CoverImageURL
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x247EE1C", Offset = "0x247AE1C", VA = "0x247EE1C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x247EEF4", Offset = "0x247AEF4", VA = "0x247EEF4", Slot = "8")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x1700003E")]
		public DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x247F004", Offset = "0x247B004", VA = "0x247F004", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x247E6E4", Offset = "0x247A6E4", VA = "0x247E6E4")]
		public AndroidSnapshotMetadata(AndroidJavaObject javaSnapshot)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2473CDC", Offset = "0x246FCDC", VA = "0x2473CDC")]
		public AndroidSnapshotMetadata(AndroidJavaObject javaMetadata, AndroidJavaObject javaContents)
		{
		}
	}
	[Token(Token = "0x2000066")]
	internal class AndroidTaskUtils
	{
		[Token(Token = "0x2000067")]
		private class TaskOnCompleteProxy<T> : AndroidJavaProxy
		{
			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<T> mCallback;

			[Token(Token = "0x60001F1")]
			public TaskOnCompleteProxy(Action<T> callback)
			{
			}

			[Token(Token = "0x60001F2")]
			public void onComplete(T result)
			{
			}
		}

		[Token(Token = "0x2000068")]
		private class TaskOnSuccessProxy<T> : AndroidJavaProxy
		{
			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action<T> mCallback;

			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool mDisposeResult;

			[Token(Token = "0x60001F3")]
			public TaskOnSuccessProxy(Action<T> callback, bool disposeResult)
			{
			}

			[Token(Token = "0x60001F4")]
			public void onSuccess(T result)
			{
			}
		}

		[Token(Token = "0x2000069")]
		private class TaskOnFailedProxy : AndroidJavaProxy
		{
			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action<AndroidJavaObject> mCallback;

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x247F0E8", Offset = "0x247B0E8", VA = "0x247F0E8")]
			public TaskOnFailedProxy(Action<AndroidJavaObject> callback)
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x247F16C", Offset = "0x247B16C", VA = "0x247F16C")]
			public void onFailure(AndroidJavaObject exception)
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x247F0E0", Offset = "0x247B0E0", VA = "0x247F0E0")]
		private AndroidTaskUtils()
		{
		}

		[Token(Token = "0x60001ED")]
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}

		[Token(Token = "0x60001EE")]
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, bool disposeResult, Action<T> callback)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2462DD4", Offset = "0x245EDD4", VA = "0x2462DD4")]
		public static void AddOnFailureListener(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		[Token(Token = "0x60001F0")]
		public static void AddOnCompleteListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}
	}
}
namespace GooglePlayGames.OurUtils
{
	[Token(Token = "0x200006A")]
	public class Logger
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool debugLogEnabled;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool warningLogEnabled;

		[Token(Token = "0x1700003F")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x247F298", Offset = "0x247B298", VA = "0x247F298")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x247F2F0", Offset = "0x247B2F0", VA = "0x247F2F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public static bool WarningLogEnabled
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x247F350", Offset = "0x247B350", VA = "0x247F350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x247F3A8", Offset = "0x247B3A8", VA = "0x247F3A8")]
			set
			{
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x245BE6C", Offset = "0x2457E6C", VA = "0x245BE6C")]
		public static void d(string msg)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2461094", Offset = "0x245D094", VA = "0x2461094")]
		public static void w(string msg)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x245DE90", Offset = "0x2459E90", VA = "0x245DE90")]
		public static void e(string msg)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x247F420", Offset = "0x247B420", VA = "0x247F420")]
		public static string describe(byte[] b)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x247F4C0", Offset = "0x247B4C0", VA = "0x247F4C0")]
		private static string ToLogMessage(string prefix, string logType, string msg)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x247F7B4", Offset = "0x247B7B4", VA = "0x247F7B4")]
		public Logger()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public static class Misc
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x247FB38", Offset = "0x247BB38", VA = "0x247FB38")]
		public static bool BuffersAreIdentical(byte[] a, byte[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x247FBA4", Offset = "0x247BBA4", VA = "0x247FBA4")]
		public static byte[] GetSubsetBytes(byte[] array, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		public static T CheckNotNull<T>(T value)
		{
			return (T)null;
		}

		[Token(Token = "0x600020E")]
		public static T CheckNotNull<T>(T value, string paramName)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000070")]
	public class NearbyHelperObject : MonoBehaviour
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static NearbyHelperObject instance;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static double mAdvertisingRemaining;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static double mDiscoveryRemaining;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static INearbyConnectionClient mClient;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2474C10", Offset = "0x2470C10", VA = "0x2474C10")]
		public static void CreateObject(INearbyConnectionClient client)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x247FCF8", Offset = "0x247BCF8", VA = "0x247FCF8")]
		private static double ToSeconds(TimeSpan? span)
		{
			return default(double);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2479C44", Offset = "0x2475C44", VA = "0x2479C44")]
		public static void StartAdvertisingTimer(TimeSpan? span)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2479CB4", Offset = "0x2475CB4", VA = "0x2479CB4")]
		public static void StartDiscoveryTimer(TimeSpan? span)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x247FDE8", Offset = "0x247BDE8", VA = "0x247FDE8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x247FE54", Offset = "0x247BE54", VA = "0x247FE54")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x247FEEC", Offset = "0x247BEEC", VA = "0x247FEEC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x247FCF0", Offset = "0x247BCF0", VA = "0x247FCF0")]
		public NearbyHelperObject()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public static class PlatformUtils
	{
		[Token(Token = "0x17000041")]
		public static bool Supported
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x24800F8", Offset = "0x247C0F8", VA = "0x24800F8")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x2000072")]
	public class PlayGamesHelperObject : MonoBehaviour
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayGamesHelperObject instance;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool sIsDummy;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Action> sQueue;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Action> localQueue;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool sQueueEmpty;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Action<bool>> sPauseCallbackList;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<Action<bool>> sFocusCallbackList;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2462228", Offset = "0x245E228", VA = "0x2462228")]
		public static void CreateObject()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x248017C", Offset = "0x247C17C", VA = "0x248017C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x24801E8", Offset = "0x247C1E8", VA = "0x24801E8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x24618EC", Offset = "0x245D8EC", VA = "0x24618EC")]
		public static void RunCoroutine(IEnumerator action)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2465200", Offset = "0x2461200", VA = "0x2465200")]
		public static void RunOnGameThread(Action action)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x24802A4", Offset = "0x247C2A4", VA = "0x24802A4")]
		public void Update()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x248051C", Offset = "0x247C51C", VA = "0x248051C")]
		public void OnApplicationFocus(bool focused)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x24807F8", Offset = "0x247C7F8", VA = "0x24807F8")]
		public void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2480AD4", Offset = "0x247CAD4", VA = "0x2480AD4")]
		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2480BE4", Offset = "0x247CBE4", VA = "0x2480BE4")]
		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2480C64", Offset = "0x247CC64", VA = "0x2480C64")]
		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2480D74", Offset = "0x247CD74", VA = "0x2480D74")]
		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2480100", Offset = "0x247C100", VA = "0x2480100")]
		public PlayGamesHelperObject()
		{
		}
	}
}
namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x2000074")]
	public class Achievement
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool mIsIncremental;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool mIsRevealed;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool mIsUnlocked;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int mCurrentSteps;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int mTotalSteps;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string mDescription;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string mName;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long mLastModifiedTime;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ulong mPoints;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string mRevealedImageUrl;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string mUnlockedImageUrl;

		[Token(Token = "0x17000042")]
		public bool IsIncremental
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2481230", Offset = "0x247D230", VA = "0x2481230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2481238", Offset = "0x247D238", VA = "0x2481238")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int CurrentSteps
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2481240", Offset = "0x247D240", VA = "0x2481240")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2481248", Offset = "0x247D248", VA = "0x2481248")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int TotalSteps
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2481250", Offset = "0x247D250", VA = "0x2481250")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2481258", Offset = "0x247D258", VA = "0x2481258")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool IsUnlocked
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2481260", Offset = "0x247D260", VA = "0x2481260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2481268", Offset = "0x247D268", VA = "0x2481268")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool IsRevealed
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2481270", Offset = "0x247D270", VA = "0x2481270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2481278", Offset = "0x247D278", VA = "0x2481278")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public string Id
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2481280", Offset = "0x247D280", VA = "0x2481280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2481288", Offset = "0x247D288", VA = "0x2481288")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public string Description
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2481290", Offset = "0x247D290", VA = "0x2481290")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2481298", Offset = "0x247D298", VA = "0x2481298")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public string Name
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x24812A0", Offset = "0x247D2A0", VA = "0x24812A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x24812A8", Offset = "0x247D2A8", VA = "0x24812A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public DateTime LastModifiedTime
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x245B2AC", Offset = "0x24572AC", VA = "0x245B2AC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x247066C", Offset = "0x246C66C", VA = "0x247066C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public ulong Points
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x24812B0", Offset = "0x247D2B0", VA = "0x24812B0")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x24812B8", Offset = "0x247D2B8", VA = "0x24812B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public string RevealedImageUrl
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x24812C0", Offset = "0x247D2C0", VA = "0x24812C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x24812C8", Offset = "0x247D2C8", VA = "0x24812C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public string UnlockedImageUrl
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x24812D0", Offset = "0x247D2D0", VA = "0x24812D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x24812D8", Offset = "0x247D2D8", VA = "0x24812D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2480F88", Offset = "0x247CF88", VA = "0x2480F88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2470610", Offset = "0x246C610", VA = "0x2470610")]
		public Achievement()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class AuthResponse
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _authCode;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<AuthScope> _grantedScopes;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2464AB0", Offset = "0x2460AB0", VA = "0x2464AB0")]
		public AuthResponse(string authCode, List<AuthScope> grantedScopes)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2481364", Offset = "0x247D364", VA = "0x2481364")]
		public List<AuthScope> GetGrantedScopes()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x248136C", Offset = "0x247D36C", VA = "0x248136C")]
		public string GetAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2481374", Offset = "0x247D374", VA = "0x2481374", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x24814A4", Offset = "0x247D4A4", VA = "0x24814A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2481518", Offset = "0x247D518", VA = "0x2481518", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	public enum AuthScope
	{
		[Token(Token = "0x400012A")]
		EMAIL,
		[Token(Token = "0x400012B")]
		PROFILE,
		[Token(Token = "0x400012C")]
		OPEN_ID
	}
	[Token(Token = "0x2000077")]
	public static class AuthScopeExtensions
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, AuthScope> _stringToEnumMap;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<AuthScope, string> _enumToStringMap;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2464B3C", Offset = "0x2460B3C", VA = "0x2464B3C")]
		public static string GetValue(this AuthScope authScope)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x248169C", Offset = "0x247D69C", VA = "0x248169C")]
		public static AuthScope FromValue(string value)
		{
			return default(AuthScope);
		}
	}
	[Token(Token = "0x2000079")]
	public enum CommonStatusCodes
	{
		[Token(Token = "0x4000131")]
		SuccessCached = -1,
		[Token(Token = "0x4000132")]
		Success = 0,
		[Token(Token = "0x4000133")]
		ServiceMissing = 1,
		[Token(Token = "0x4000134")]
		ServiceVersionUpdateRequired = 2,
		[Token(Token = "0x4000135")]
		ServiceDisabled = 3,
		[Token(Token = "0x4000136")]
		SignInRequired = 4,
		[Token(Token = "0x4000137")]
		InvalidAccount = 5,
		[Token(Token = "0x4000138")]
		ResolutionRequired = 6,
		[Token(Token = "0x4000139")]
		NetworkError = 7,
		[Token(Token = "0x400013A")]
		InternalError = 8,
		[Token(Token = "0x400013B")]
		ServiceInvalid = 9,
		[Token(Token = "0x400013C")]
		DeveloperError = 10,
		[Token(Token = "0x400013D")]
		LicenseCheckFailed = 11,
		[Token(Token = "0x400013E")]
		Error = 13,
		[Token(Token = "0x400013F")]
		Interrupted = 14,
		[Token(Token = "0x4000140")]
		Timeout = 15,
		[Token(Token = "0x4000141")]
		Canceled = 16,
		[Token(Token = "0x4000142")]
		ApiNotConnected = 17,
		[Token(Token = "0x4000143")]
		AuthApiInvalidCredentials = 3000,
		[Token(Token = "0x4000144")]
		AuthApiAccessForbidden = 3001,
		[Token(Token = "0x4000145")]
		AuthApiClientError = 3002,
		[Token(Token = "0x4000146")]
		AuthApiServerError = 3003,
		[Token(Token = "0x4000147")]
		AuthTokenError = 3004,
		[Token(Token = "0x4000148")]
		AuthUrlResolution = 3005
	}
	[Token(Token = "0x200007A")]
	public enum DataSource
	{
		[Token(Token = "0x400014A")]
		ReadCacheOrNetwork,
		[Token(Token = "0x400014B")]
		ReadNetworkOnly
	}
	[Token(Token = "0x200007B")]
	public enum ResponseStatus
	{
		[Token(Token = "0x400014D")]
		Success = 1,
		[Token(Token = "0x400014E")]
		SuccessWithStale = 2,
		[Token(Token = "0x400014F")]
		LicenseCheckFailed = -1,
		[Token(Token = "0x4000150")]
		InternalError = -2,
		[Token(Token = "0x4000151")]
		NotAuthorized = -3,
		[Token(Token = "0x4000152")]
		VersionUpdateRequired = -4,
		[Token(Token = "0x4000153")]
		Timeout = -5,
		[Token(Token = "0x4000154")]
		ResolutionRequired = -6
	}
	[Token(Token = "0x200007C")]
	public enum UIStatus
	{
		[Token(Token = "0x4000156")]
		Valid = 1,
		[Token(Token = "0x4000157")]
		InternalError = -2,
		[Token(Token = "0x4000158")]
		NotAuthorized = -3,
		[Token(Token = "0x4000159")]
		VersionUpdateRequired = -4,
		[Token(Token = "0x400015A")]
		Timeout = -5,
		[Token(Token = "0x400015B")]
		UserClosedUI = -6,
		[Token(Token = "0x400015C")]
		UiBusy = -12,
		[Token(Token = "0x400015D")]
		NetworkError = -20
	}
	[Token(Token = "0x200007D")]
	public enum LeaderboardStart
	{
		[Token(Token = "0x400015F")]
		TopScores = 1,
		[Token(Token = "0x4000160")]
		PlayerCentered
	}
	[Token(Token = "0x200007E")]
	public enum LeaderboardTimeSpan
	{
		[Token(Token = "0x4000162")]
		Daily = 1,
		[Token(Token = "0x4000163")]
		Weekly,
		[Token(Token = "0x4000164")]
		AllTime
	}
	[Token(Token = "0x200007F")]
	public enum LeaderboardCollection
	{
		[Token(Token = "0x4000166")]
		Public = 1,
		[Token(Token = "0x4000167")]
		Social
	}
	[Token(Token = "0x2000080")]
	public enum FriendsListVisibilityStatus
	{
		[Token(Token = "0x4000169")]
		Unknown = 0,
		[Token(Token = "0x400016A")]
		Visible = 1,
		[Token(Token = "0x400016B")]
		ResolutionRequired = 2,
		[Token(Token = "0x400016C")]
		Unavailable = 3,
		[Token(Token = "0x400016D")]
		NetworkError = -4,
		[Token(Token = "0x400016E")]
		NotAuthorized = -5
	}
	[Token(Token = "0x2000081")]
	public enum LoadFriendsStatus
	{
		[Token(Token = "0x4000170")]
		Unknown = 0,
		[Token(Token = "0x4000171")]
		Completed = 1,
		[Token(Token = "0x4000172")]
		LoadMore = 2,
		[Token(Token = "0x4000173")]
		ResolutionRequired = -3,
		[Token(Token = "0x4000174")]
		InternalError = -4,
		[Token(Token = "0x4000175")]
		NotAuthorized = -5,
		[Token(Token = "0x4000176")]
		NetworkError = -6
	}
	[Token(Token = "0x2000082")]
	public class CommonTypesUtil
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2481ACC", Offset = "0x247DACC", VA = "0x2481ACC")]
		public static bool StatusIsSuccess(ResponseStatus status)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2481AD8", Offset = "0x247DAD8", VA = "0x2481AD8")]
		public CommonTypesUtil()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class DummyClient : IPlayGamesClient
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2481AE0", Offset = "0x247DAE0", VA = "0x2481AE0", Slot = "4")]
		public void Authenticate(Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2481B78", Offset = "0x247DB78", VA = "0x2481B78", Slot = "5")]
		public void ManuallyAuthenticate(Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2481BA8", Offset = "0x247DBA8", VA = "0x2481BA8", Slot = "6")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2481BBC", Offset = "0x247DBBC", VA = "0x2481BBC", Slot = "7")]
		public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2481BEC", Offset = "0x247DBEC", VA = "0x2481BEC", Slot = "8")]
		public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2481C1C", Offset = "0x247DC1C", VA = "0x2481C1C", Slot = "9")]
		public void RequestRecallAccessToken(Action<RecallAccess> callback)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2481C4C", Offset = "0x247DC4C", VA = "0x2481C4C", Slot = "10")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2481C90", Offset = "0x247DC90", VA = "0x2481C90", Slot = "14")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2481D24", Offset = "0x247DD24", VA = "0x2481D24", Slot = "12")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2481D68", Offset = "0x247DD68", VA = "0x2481D68", Slot = "13")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2481D7C", Offset = "0x247DD7C", VA = "0x2481D7C", Slot = "15")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2481DAC", Offset = "0x247DDAC", VA = "0x2481DAC", Slot = "16")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2481DDC", Offset = "0x247DDDC", VA = "0x2481DDC", Slot = "17")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2481E0C", Offset = "0x247DE0C", VA = "0x2481E0C", Slot = "18")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2481E3C", Offset = "0x247DE3C", VA = "0x2481E3C", Slot = "19")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2481E6C", Offset = "0x247DE6C", VA = "0x2481E6C", Slot = "20")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2481E9C", Offset = "0x247DE9C", VA = "0x2481E9C", Slot = "21")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2481ECC", Offset = "0x247DECC", VA = "0x2481ECC", Slot = "22")]
		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2481EFC", Offset = "0x247DEFC", VA = "0x2481EFC", Slot = "23")]
		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2481F10", Offset = "0x247DF10", VA = "0x2481F10", Slot = "26")]
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2481F40", Offset = "0x247DF40", VA = "0x2481F40", Slot = "27")]
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2481F70", Offset = "0x247DF70", VA = "0x2481F70", Slot = "24")]
		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2481FA0", Offset = "0x247DFA0", VA = "0x2481FA0", Slot = "25")]
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2481FD0", Offset = "0x247DFD0", VA = "0x2481FD0", Slot = "28")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2482000", Offset = "0x247E000", VA = "0x2482000", Slot = "31")]
		public int LeaderboardMaxResults()
		{
			return default(int);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2482008", Offset = "0x247E008", VA = "0x2482008", Slot = "29")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2482120", Offset = "0x247E120", VA = "0x2482120", Slot = "30")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x24821AC", Offset = "0x247E1AC", VA = "0x24821AC", Slot = "32")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x24821DC", Offset = "0x247E1DC", VA = "0x24821DC", Slot = "33")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x248220C", Offset = "0x247E20C", VA = "0x248220C", Slot = "34")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2482220", Offset = "0x247E220", VA = "0x2482220", Slot = "35")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2482234", Offset = "0x247E234", VA = "0x2482234", Slot = "11")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2482260", Offset = "0x247E260", VA = "0x2482260", Slot = "36")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2481B10", Offset = "0x247DB10", VA = "0x2481B10")]
		private static void LogUsage()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x24822A8", Offset = "0x247E2A8", VA = "0x24822A8")]
		public DummyClient()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public interface IPlayGamesClient
	{
		[Token(Token = "0x6000275")]
		void Authenticate(Action<SignInStatus> callback);

		[Token(Token = "0x6000276")]
		void ManuallyAuthenticate(Action<SignInStatus> callback);

		[Token(Token = "0x6000277")]
		bool IsAuthenticated();

		[Token(Token = "0x6000278")]
		void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback);

		[Token(Token = "0x6000279")]
		void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback);

		[Token(Token = "0x600027A")]
		void RequestRecallAccessToken(Action<RecallAccess> callback);

		[Token(Token = "0x600027B")]
		string GetUserId();

		[Token(Token = "0x600027C")]
		void LoadFriends(Action<bool> callback);

		[Token(Token = "0x600027D")]
		string GetUserDisplayName();

		[Token(Token = "0x600027E")]
		string GetUserImageUrl();

		[Token(Token = "0x600027F")]
		void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

		[Token(Token = "0x6000280")]
		void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

		[Token(Token = "0x6000281")]
		void LoadAchievements(Action<Achievement[]> callback);

		[Token(Token = "0x6000282")]
		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6000283")]
		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6000284")]
		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6000285")]
		void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

		[Token(Token = "0x6000286")]
		void ShowAchievementsUI(Action<UIStatus> callback);

		[Token(Token = "0x6000287")]
		void AskForLoadFriendsResolution(Action<UIStatus> callback);

		[Token(Token = "0x6000288")]
		LoadFriendsStatus GetLastLoadFriendsStatus();

		[Token(Token = "0x6000289")]
		void ShowCompareProfileWithAlternativeNameHintsUI(string otherUserId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);

		[Token(Token = "0x600028A")]
		void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);

		[Token(Token = "0x600028B")]
		void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);

		[Token(Token = "0x600028C")]
		void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);

		[Token(Token = "0x600028D")]
		void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

		[Token(Token = "0x600028E")]
		void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

		[Token(Token = "0x600028F")]
		void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

		[Token(Token = "0x6000290")]
		int LeaderboardMaxResults();

		[Token(Token = "0x6000291")]
		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6000292")]
		void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6000293")]
		ISavedGameClient GetSavedGameClient();

		[Token(Token = "0x6000294")]
		IEventsClient GetEventsClient();

		[Token(Token = "0x6000295")]
		IUserProfile[] GetFriends();
	}
	[Token(Token = "0x2000085")]
	public class LeaderboardScoreData
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ResponseStatus mStatus;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ulong mApproxCount;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string mTitle;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IScore mPlayerScore;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ScorePageToken mPrevPage;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScorePageToken mNextPage;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PlayGamesScore> mScores;

		[Token(Token = "0x1700004E")]
		public bool Valid
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2482338", Offset = "0x247E338", VA = "0x2482338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public ResponseStatus Status
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x248234C", Offset = "0x247E34C", VA = "0x248234C")]
			get
			{
				return default(ResponseStatus);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2482354", Offset = "0x247E354", VA = "0x2482354")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public ulong ApproximateCount
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x248235C", Offset = "0x247E35C", VA = "0x248235C")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x2482364", Offset = "0x247E364", VA = "0x2482364")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public string Title
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x248236C", Offset = "0x247E36C", VA = "0x248236C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2482374", Offset = "0x247E374", VA = "0x2482374")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public string Id
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x248237C", Offset = "0x247E37C", VA = "0x248237C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2482384", Offset = "0x247E384", VA = "0x2482384")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public IScore PlayerScore
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x248238C", Offset = "0x247E38C", VA = "0x248238C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2482394", Offset = "0x247E394", VA = "0x2482394")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public IScore[] Scores
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x248239C", Offset = "0x247E39C", VA = "0x248239C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public ScorePageToken PrevPageToken
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x24824A4", Offset = "0x247E4A4", VA = "0x24824A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x24824AC", Offset = "0x247E4AC", VA = "0x24824AC")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public ScorePageToken NextPageToken
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x24824B4", Offset = "0x247E4B4", VA = "0x24824B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x24824BC", Offset = "0x247E4BC", VA = "0x24824BC")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x24822B0", Offset = "0x247E2B0", VA = "0x24822B0")]
		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2482088", Offset = "0x247E088", VA = "0x2482088")]
		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x24823EC", Offset = "0x247E3EC", VA = "0x24823EC")]
		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x24824C4", Offset = "0x247E4C4", VA = "0x24824C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public class Player : PlayGamesUserProfile
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2482654", Offset = "0x247E654", VA = "0x2482654")]
		internal Player(string displayName, string playerId, string avatarUrl)
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class PlayerProfile : PlayGamesUserProfile
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x248265C", Offset = "0x247E65C", VA = "0x248265C")]
		internal PlayerProfile(string displayName, string playerId, string avatarUrl, bool isFriend)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class PlayerStats
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float UNSET_VALUE;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool mValid;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int mNumberOfPurchases;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float mAvgSessionLength;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int mDaysSinceLastPlayed;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int mNumberOfSessions;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float mSessPercentile;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float mSpendPercentile;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float mSpendProbability;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float mChurnProbability;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float mHighSpenderProbability;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float mTotalSpendNext28Days;

		[Token(Token = "0x17000057")]
		public bool Valid
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x24826F4", Offset = "0x247E6F4", VA = "0x24826F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public int NumberOfPurchases
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x24826FC", Offset = "0x247E6FC", VA = "0x24826FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public float AvgSessionLength
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2482704", Offset = "0x247E704", VA = "0x2482704")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005A")]
		public int DaysSinceLastPlayed
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x248270C", Offset = "0x247E70C", VA = "0x248270C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005B")]
		public int NumberOfSessions
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2482714", Offset = "0x247E714", VA = "0x2482714")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005C")]
		public float SessPercentile
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x248271C", Offset = "0x247E71C", VA = "0x248271C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005D")]
		public float SpendPercentile
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2482724", Offset = "0x247E724", VA = "0x2482724")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005E")]
		public float SpendProbability
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x248272C", Offset = "0x247E72C", VA = "0x248272C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005F")]
		public float ChurnProbability
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2482734", Offset = "0x247E734", VA = "0x2482734")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000060")]
		public float HighSpenderProbability
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x248273C", Offset = "0x247E73C", VA = "0x248273C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000061")]
		public float TotalSpendNext28Days
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2482744", Offset = "0x247E744", VA = "0x2482744")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2482664", Offset = "0x247E664", VA = "0x2482664")]
		public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2481D08", Offset = "0x247DD08", VA = "0x2481D08")]
		public PlayerStats()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x248274C", Offset = "0x247E74C", VA = "0x248274C")]
		public bool HasNumberOfPurchases()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x24827CC", Offset = "0x247E7CC", VA = "0x24827CC")]
		public bool HasAvgSessionLength()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x248283C", Offset = "0x247E83C", VA = "0x248283C")]
		public bool HasDaysSinceLastPlayed()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x24828BC", Offset = "0x247E8BC", VA = "0x24828BC")]
		public bool HasNumberOfSessions()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x248293C", Offset = "0x247E93C", VA = "0x248293C")]
		public bool HasSessPercentile()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x24829AC", Offset = "0x247E9AC", VA = "0x24829AC")]
		public bool HasSpendPercentile()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2482A1C", Offset = "0x247EA1C", VA = "0x2482A1C")]
		public bool HasChurnProbability()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2482A8C", Offset = "0x247EA8C", VA = "0x2482A8C")]
		public bool HasHighSpenderProbability()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2482AFC", Offset = "0x247EAFC", VA = "0x2482AFC")]
		public bool HasTotalSpendNext28Days()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000089")]
	public class RecallAccess
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mSessionId;

		[Token(Token = "0x17000062")]
		public string sessionId
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2482BE0", Offset = "0x247EBE0", VA = "0x2482BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2482BE8", Offset = "0x247EBE8", VA = "0x2482BE8")]
			internal set
			{
			}
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2482BB8", Offset = "0x247EBB8", VA = "0x2482BB8")]
		internal RecallAccess(string sessionId)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public enum ScorePageDirection
	{
		[Token(Token = "0x400018D")]
		Forward = 1,
		[Token(Token = "0x400018E")]
		Backward
	}
	[Token(Token = "0x200008B")]
	public class ScorePageToken
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object mInternalObject;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LeaderboardCollection mCollection;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private LeaderboardTimeSpan mTimespan;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ScorePageDirection mDirection;

		[Token(Token = "0x17000063")]
		public LeaderboardCollection Collection
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x2482C40", Offset = "0x247EC40", VA = "0x2482C40")]
			get
			{
				return default(LeaderboardCollection);
			}
		}

		[Token(Token = "0x17000064")]
		public LeaderboardTimeSpan TimeSpan
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x2482C48", Offset = "0x247EC48", VA = "0x2482C48")]
			get
			{
				return default(LeaderboardTimeSpan);
			}
		}

		[Token(Token = "0x17000065")]
		public ScorePageDirection Direction
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2482C50", Offset = "0x247EC50", VA = "0x2482C50")]
			get
			{
				return default(ScorePageDirection);
			}
		}

		[Token(Token = "0x17000066")]
		public string LeaderboardId
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x2482C58", Offset = "0x247EC58", VA = "0x2482C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		internal object InternalObject
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2482C60", Offset = "0x247EC60", VA = "0x2482C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2482BF0", Offset = "0x247EBF0", VA = "0x2482BF0")]
		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public enum SignInInteractivity
	{
		[Token(Token = "0x4000195")]
		NoPrompt,
		[Token(Token = "0x4000196")]
		CanPromptAlways,
		[Token(Token = "0x4000197")]
		CanPromptOnce
	}
	[Token(Token = "0x200008D")]
	public enum SignInStatus
	{
		[Token(Token = "0x4000199")]
		Success,
		[Token(Token = "0x400019A")]
		InternalError,
		[Token(Token = "0x400019B")]
		Canceled
	}
}
namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x200008E")]
	public enum ConflictResolutionStrategy
	{
		[Token(Token = "0x400019D")]
		UseLongestPlaytime,
		[Token(Token = "0x400019E")]
		UseOriginal,
		[Token(Token = "0x400019F")]
		UseUnmerged,
		[Token(Token = "0x40001A0")]
		UseManual,
		[Token(Token = "0x40001A1")]
		UseLastKnownGood,
		[Token(Token = "0x40001A2")]
		UseMostRecentlySaved
	}
	[Token(Token = "0x200008F")]
	public enum SavedGameRequestStatus
	{
		[Token(Token = "0x40001A4")]
		Success = 1,
		[Token(Token = "0x40001A5")]
		TimeoutError = -1,
		[Token(Token = "0x40001A6")]
		InternalError = -2,
		[Token(Token = "0x40001A7")]
		AuthenticationError = -3,
		[Token(Token = "0x40001A8")]
		BadInputError = -4
	}
	[Token(Token = "0x2000090")]
	public enum SelectUIStatus
	{
		[Token(Token = "0x40001AA")]
		SavedGameSelected = 1,
		[Token(Token = "0x40001AB")]
		UserClosedUI = 2,
		[Token(Token = "0x40001AC")]
		InternalError = -1,
		[Token(Token = "0x40001AD")]
		TimeoutError = -2,
		[Token(Token = "0x40001AE")]
		AuthenticationError = -3,
		[Token(Token = "0x40001AF")]
		BadInputError = -4,
		[Token(Token = "0x40001B0")]
		UiBusy = -5
	}
	[Token(Token = "0x2000091")]
	public delegate void ConflictCallback(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
	[Token(Token = "0x2000092")]
	public interface ISavedGameClient
	{
		[Token(Token = "0x60002D0")]
		void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

		[Token(Token = "0x60002D1")]
		void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);

		[Token(Token = "0x60002D2")]
		void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback);

		[Token(Token = "0x60002D3")]
		void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback);

		[Token(Token = "0x60002D4")]
		void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

		[Token(Token = "0x60002D5")]
		void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback);

		[Token(Token = "0x60002D6")]
		void Delete(ISavedGameMetadata metadata);
	}
	[Token(Token = "0x2000093")]
	public interface IConflictResolver
	{
		[Token(Token = "0x60002D7")]
		void ChooseMetadata(ISavedGameMetadata chosenMetadata);

		[Token(Token = "0x60002D8")]
		void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
	}
	[Token(Token = "0x2000094")]
	public interface ISavedGameMetadata
	{
		[Token(Token = "0x17000068")]
		bool IsOpen
		{
			[Token(Token = "0x60002D9")]
			get;
		}

		[Token(Token = "0x17000069")]
		string Filename
		{
			[Token(Token = "0x60002DA")]
			get;
		}

		[Token(Token = "0x1700006A")]
		string Description
		{
			[Token(Token = "0x60002DB")]
			get;
		}

		[Token(Token = "0x1700006B")]
		string CoverImageURL
		{
			[Token(Token = "0x60002DC")]
			get;
		}

		[Token(Token = "0x1700006C")]
		TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x60002DD")]
			get;
		}

		[Token(Token = "0x1700006D")]
		DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x60002DE")]
			get;
		}
	}
	[Token(Token = "0x2000095")]
	public struct SavedGameMetadataUpdate
	{
		[Token(Token = "0x2000096")]
		public struct Builder
		{
			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool mDescriptionUpdated;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string mNewDescription;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool mCoverImageUpdated;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal byte[] mNewPngCoverImage;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TimeSpan? mNewPlayedTime;

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2482E60", Offset = "0x247EE60", VA = "0x2482E60")]
			public Builder WithUpdatedDescription(string description)
			{
				return default(Builder);
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x2482ED8", Offset = "0x247EED8", VA = "0x2482ED8")]
			public Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(Builder);
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2482EF8", Offset = "0x247EEF8", VA = "0x2482EF8")]
			public Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(Builder);
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x2483000", Offset = "0x247F000", VA = "0x2483000")]
			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly bool mDescriptionUpdated;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string mNewDescription;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool mCoverImageUpdated;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly byte[] mNewPngCoverImage;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly TimeSpan? mNewPlayedTime;

		[Token(Token = "0x1700006E")]
		public bool IsDescriptionUpdated
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x2482DF8", Offset = "0x247EDF8", VA = "0x2482DF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public string UpdatedDescription
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2482E00", Offset = "0x247EE00", VA = "0x2482E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public bool IsCoverImageUpdated
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2482E08", Offset = "0x247EE08", VA = "0x2482E08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public byte[] UpdatedPngCoverImage
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x2482E10", Offset = "0x247EE10", VA = "0x2482E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public bool IsPlayedTimeUpdated
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x2482E18", Offset = "0x247EE18", VA = "0x2482E18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public TimeSpan? UpdatedPlayedTime
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2482E54", Offset = "0x247EE54", VA = "0x2482E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2482DBC", Offset = "0x247EDBC", VA = "0x2482DBC")]
		private SavedGameMetadataUpdate(Builder builder)
		{
		}
	}
}
namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000097")]
	public struct AdvertisingResult
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ResponseStatus mStatus;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string mLocalEndpointName;

		[Token(Token = "0x17000074")]
		public bool Succeeded
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x2483098", Offset = "0x247F098", VA = "0x2483098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public ResponseStatus Status
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x24830A8", Offset = "0x247F0A8", VA = "0x24830A8")]
			get
			{
				return default(ResponseStatus);
			}
		}

		[Token(Token = "0x17000076")]
		public string LocalEndpointName
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x24830B0", Offset = "0x247F0B0", VA = "0x24830B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2483034", Offset = "0x247F034", VA = "0x2483034")]
		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
		}
	}
	[Token(Token = "0x2000098")]
	public struct ConnectionRequest
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EndpointDetails mRemoteEndpoint;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly byte[] mPayload;

		[Token(Token = "0x17000077")]
		public EndpointDetails RemoteEndpoint
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x248322C", Offset = "0x247F22C", VA = "0x248322C")]
			get
			{
				return default(EndpointDetails);
			}
		}

		[Token(Token = "0x17000078")]
		public byte[] Payload
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2483240", Offset = "0x247F240", VA = "0x2483240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x24830B8", Offset = "0x247F0B8", VA = "0x24830B8")]
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public struct ConnectionResponse
	{
		[Token(Token = "0x200009A")]
		public enum Status
		{
			[Token(Token = "0x40001C5")]
			Accepted,
			[Token(Token = "0x40001C6")]
			Rejected,
			[Token(Token = "0x40001C7")]
			ErrorInternal,
			[Token(Token = "0x40001C8")]
			ErrorNetworkNotConnected,
			[Token(Token = "0x40001C9")]
			ErrorEndpointNotConnected,
			[Token(Token = "0x40001CA")]
			ErrorAlreadyConnected
		}

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte[] EmptyPayload;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly long mLocalClientId;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string mRemoteEndpointId;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Status mResponseStatus;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly byte[] mPayload;

		[Token(Token = "0x17000079")]
		public long LocalClientId
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x24832EC", Offset = "0x247F2EC", VA = "0x24832EC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700007A")]
		public string RemoteEndpointId
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x24832F4", Offset = "0x247F2F4", VA = "0x24832F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public Status ResponseStatus
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x24832FC", Offset = "0x247F2FC", VA = "0x24832FC")]
			get
			{
				return default(Status);
			}
		}

		[Token(Token = "0x1700007C")]
		public byte[] Payload
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x2483304", Offset = "0x247F304", VA = "0x2483304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2483248", Offset = "0x247F248", VA = "0x2483248")]
		private ConnectionResponse(long localClientId, string remoteEndpointId, Status code, byte[] payload)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x248330C", Offset = "0x247F30C", VA = "0x248330C")]
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2483390", Offset = "0x247F390", VA = "0x2483390")]
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2483414", Offset = "0x247F414", VA = "0x2483414")]
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2483498", Offset = "0x247F498", VA = "0x2483498")]
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x248351C", Offset = "0x247F51C", VA = "0x248351C")]
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x248353C", Offset = "0x247F53C", VA = "0x248353C")]
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}
	}
	[Token(Token = "0x200009B")]
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2483628", Offset = "0x247F628", VA = "0x2483628", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2483630", Offset = "0x247F630", VA = "0x2483630", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2483638", Offset = "0x247F638", VA = "0x2483638", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x24836A0", Offset = "0x247F6A0", VA = "0x24836A0", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2483708", Offset = "0x247F708", VA = "0x2483708", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x24837AC", Offset = "0x247F7AC", VA = "0x24837AC", Slot = "9")]
		public void StopAdvertising()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2483814", Offset = "0x247F814", VA = "0x2483814", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2483908", Offset = "0x247F908", VA = "0x2483908", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2483970", Offset = "0x247F970", VA = "0x2483970", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x24839D8", Offset = "0x247F9D8", VA = "0x24839D8", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2483A40", Offset = "0x247FA40", VA = "0x2483A40", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2483AA8", Offset = "0x247FAA8", VA = "0x2483AA8", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2483B10", Offset = "0x247FB10", VA = "0x2483B10", Slot = "16")]
		public void StopAllConnections()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2483B78", Offset = "0x247FB78", VA = "0x2483B78")]
		public string LocalEndpointId()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2483BC0", Offset = "0x247FBC0", VA = "0x2483BC0")]
		public string LocalDeviceId()
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2483C00", Offset = "0x247FC00", VA = "0x2483C00", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2483C40", Offset = "0x247FC40", VA = "0x2483C40", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2483C80", Offset = "0x247FC80", VA = "0x2483C80")]
		public DummyNearbyConnectionClient()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public struct EndpointDetails
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string mEndpointId;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string mName;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string mServiceId;

		[Token(Token = "0x1700007D")]
		public string EndpointId
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x2483C88", Offset = "0x247FC88", VA = "0x2483C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public string Name
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2483C90", Offset = "0x247FC90", VA = "0x2483C90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public string ServiceId
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2483C98", Offset = "0x247FC98", VA = "0x2483C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x24831A0", Offset = "0x247F1A0", VA = "0x24831A0")]
		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public interface INearbyConnectionClient
	{
		[Token(Token = "0x6000313")]
		int MaxUnreliableMessagePayloadLength();

		[Token(Token = "0x6000314")]
		int MaxReliableMessagePayloadLength();

		[Token(Token = "0x6000315")]
		void SendReliable(List<string> recipientEndpointIds, byte[] payload);

		[Token(Token = "0x6000316")]
		void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);

		[Token(Token = "0x6000317")]
		void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);

		[Token(Token = "0x6000318")]
		void StopAdvertising();

		[Token(Token = "0x6000319")]
		void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);

		[Token(Token = "0x600031A")]
		void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);

		[Token(Token = "0x600031B")]
		void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener);

		[Token(Token = "0x600031C")]
		void StopDiscovery(string serviceId);

		[Token(Token = "0x600031D")]
		void RejectConnectionRequest(string requestingEndpointId);

		[Token(Token = "0x600031E")]
		void DisconnectFromEndpoint(string remoteEndpointId);

		[Token(Token = "0x600031F")]
		void StopAllConnections();

		[Token(Token = "0x6000320")]
		string GetAppBundleId();

		[Token(Token = "0x6000321")]
		string GetServiceId();
	}
	[Token(Token = "0x200009E")]
	public interface IMessageListener
	{
		[Token(Token = "0x6000322")]
		void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

		[Token(Token = "0x6000323")]
		void OnRemoteEndpointDisconnected(string remoteEndpointId);
	}
	[Token(Token = "0x200009F")]
	public interface IDiscoveryListener
	{
		[Token(Token = "0x6000324")]
		void OnEndpointFound(EndpointDetails discoveredEndpoint);

		[Token(Token = "0x6000325")]
		void OnEndpointLost(string lostEndpointId);
	}
	[Token(Token = "0x20000A0")]
	public enum InitializationStatus
	{
		[Token(Token = "0x40001CF")]
		Success,
		[Token(Token = "0x40001D0")]
		VersionUpdateRequired,
		[Token(Token = "0x40001D1")]
		InternalError
	}
	[Token(Token = "0x20000A1")]
	public struct NearbyConnectionConfiguration
	{
		[Token(Token = "0x40001D2")]
		public const int MaxUnreliableMessagePayloadLength = 1168;

		[Token(Token = "0x40001D3")]
		public const int MaxReliableMessagePayloadLength = 4096;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Action<InitializationStatus> mInitializationCallback;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly long mLocalClientId;

		[Token(Token = "0x17000080")]
		public long LocalClientId
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x2483D00", Offset = "0x247FD00", VA = "0x2483D00")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000081")]
		public Action<InitializationStatus> InitializationCallback
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x2483D08", Offset = "0x247FD08", VA = "0x2483D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2483CA0", Offset = "0x247FCA0", VA = "0x2483CA0")]
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}
	}
}
namespace GooglePlayGames.BasicApi.Events
{
	[Token(Token = "0x20000A2")]
	internal class Event : IEvent
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string mName;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string mDescription;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string mImageUrl;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ulong mCurrentCount;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EventVisibility mVisibility;

		[Token(Token = "0x17000082")]
		public string Id
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2483D68", Offset = "0x247FD68", VA = "0x2483D68", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public string Name
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2483D70", Offset = "0x247FD70", VA = "0x2483D70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public string Description
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x2483D78", Offset = "0x247FD78", VA = "0x2483D78", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public string ImageUrl
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x2483D80", Offset = "0x247FD80", VA = "0x2483D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public ulong CurrentCount
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2483D88", Offset = "0x247FD88", VA = "0x2483D88", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000087")]
		public EventVisibility Visibility
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2483D90", Offset = "0x247FD90", VA = "0x2483D90", Slot = "9")]
			get
			{
				return default(EventVisibility);
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2483D10", Offset = "0x247FD10", VA = "0x2483D10")]
		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public enum EventVisibility
	{
		[Token(Token = "0x40001DD")]
		Hidden = 1,
		[Token(Token = "0x40001DE")]
		Revealed
	}
	[Token(Token = "0x20000A4")]
	public interface IEvent
	{
		[Token(Token = "0x17000088")]
		string Id
		{
			[Token(Token = "0x6000330")]
			get;
		}

		[Token(Token = "0x17000089")]
		string Name
		{
			[Token(Token = "0x6000331")]
			get;
		}

		[Token(Token = "0x1700008A")]
		string Description
		{
			[Token(Token = "0x6000332")]
			get;
		}

		[Token(Token = "0x1700008B")]
		string ImageUrl
		{
			[Token(Token = "0x6000333")]
			get;
		}

		[Token(Token = "0x1700008C")]
		ulong CurrentCount
		{
			[Token(Token = "0x6000334")]
			get;
		}

		[Token(Token = "0x1700008D")]
		EventVisibility Visibility
		{
			[Token(Token = "0x6000335")]
			get;
		}
	}
	[Token(Token = "0x20000A5")]
	public interface IEventsClient
	{
		[Token(Token = "0x6000336")]
		void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

		[Token(Token = "0x6000337")]
		void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

		[Token(Token = "0x6000338")]
		void IncrementEvent(string eventId, uint stepsToIncrement);
	}
}
