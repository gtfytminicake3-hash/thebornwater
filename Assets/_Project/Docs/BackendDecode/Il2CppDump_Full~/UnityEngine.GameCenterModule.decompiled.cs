using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	public static class Social
	{
		[Token(Token = "0x17000001")]
		public static ISocialPlatform Active
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2E5153C", Offset = "0x2E4D53C", VA = "0x2E5153C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2E515A8", Offset = "0x2E4D5A8", VA = "0x2E515A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public static ILocalUser localUser
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2E51640", Offset = "0x2E4D640", VA = "0x2E51640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2E516D8", Offset = "0x2E4D6D8", VA = "0x2E516D8")]
		public static void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2E5179C", Offset = "0x2E4D79C", VA = "0x2E5179C")]
		public static void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E51860", Offset = "0x2E4D860", VA = "0x2E51860")]
		public static void ShowAchievementsUI()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2E518FC", Offset = "0x2E4D8FC", VA = "0x2E518FC")]
		public static void ShowLeaderboardUI()
		{
		}
	}
}
namespace UnityEngine.SocialPlatforms
{
	[Token(Token = "0x2000003")]
	public class Local : ISocialPlatform
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static LocalUser m_LocalUser;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		private List<UserProfile> m_Friends;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private List<UserProfile> m_Users;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		private List<AchievementDescription> m_AchievementDescriptions;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		private List<Achievement> m_Achievements;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		private List<Leaderboard> m_Leaderboards;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D m_DefaultTexture;

		[Token(Token = "0x17000003")]
		public ILocalUser localUser
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2E51998", Offset = "0x2E4D998", VA = "0x2E51998", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2E51A7C", Offset = "0x2E4DA7C", VA = "0x2E51A7C", Slot = "9")]
		private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, Action<bool> callback)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2E52850", Offset = "0x2E4E850", VA = "0x2E52850", Slot = "5")]
		public void ReportProgress(string id, double progress, Action<bool> callback)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2E52E4C", Offset = "0x2E4EE4C", VA = "0x2E52E4C", Slot = "6")]
		public void ReportScore(long score, string board, Action<bool> callback)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2E53314", Offset = "0x2E4F314", VA = "0x2E53314", Slot = "10")]
		private bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(ILeaderboard board)
		{
			return default(bool);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2E53458", Offset = "0x2E4F458", VA = "0x2E53458", Slot = "7")]
		public void ShowAchievementsUI()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2E534C0", Offset = "0x2E4F4C0", VA = "0x2E534C0", Slot = "8")]
		public void ShowLeaderboardUI()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2E52CF0", Offset = "0x2E4ECF0", VA = "0x2E52CF0")]
		private bool VerifyUser()
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2E51C78", Offset = "0x2E4DC78", VA = "0x2E51C78")]
		private void PopulateStaticData()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2E51B8C", Offset = "0x2E4DB8C", VA = "0x2E51B8C")]
		private Texture2D CreateDummyTexture(int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2E536F0", Offset = "0x2E4F6F0", VA = "0x2E536F0")]
		public Local()
		{
		}
	}
	[Token(Token = "0x2000004")]
	internal static class ActivePlatform
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static ISocialPlatform _active;

		[Token(Token = "0x17000004")]
		internal static ISocialPlatform Instance
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2E51540", Offset = "0x2E4D540", VA = "0x2E51540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2E515F4", Offset = "0x2E4D5F4", VA = "0x2E515F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2E5385C", Offset = "0x2E4F85C", VA = "0x2E5385C")]
		private static ISocialPlatform SelectSocialPlatform()
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	public interface ISocialPlatform
	{
		[Token(Token = "0x17000005")]
		ILocalUser localUser
		{
			[Token(Token = "0x6000016")]
			get;
		}

		[Token(Token = "0x6000017")]
		void ReportProgress(string achievementID, double progress, Action<bool> callback);

		[Token(Token = "0x6000018")]
		void ReportScore(long score, string board, Action<bool> callback);

		[Token(Token = "0x6000019")]
		void ShowAchievementsUI();

		[Token(Token = "0x600001A")]
		void ShowLeaderboardUI();

		[Token(Token = "0x600001B")]
		void Authenticate(ILocalUser user, Action<bool> callback);

		[Token(Token = "0x600001C")]
		bool GetLoading(ILeaderboard board);
	}
	[Token(Token = "0x2000006")]
	public interface ILocalUser : IUserProfile
	{
		[Token(Token = "0x17000006")]
		bool authenticated
		{
			[Token(Token = "0x600001E")]
			get;
		}

		[Token(Token = "0x600001D")]
		void Authenticate(Action<bool> callback);
	}
	[Token(Token = "0x2000007")]
	public enum UserState
	{
		[Token(Token = "0x400000A")]
		Online,
		[Token(Token = "0x400000B")]
		OnlineAndAway,
		[Token(Token = "0x400000C")]
		OnlineAndBusy,
		[Token(Token = "0x400000D")]
		Offline,
		[Token(Token = "0x400000E")]
		Playing
	}
	[Token(Token = "0x2000008")]
	public interface IUserProfile
	{
		[Token(Token = "0x17000007")]
		string id
		{
			[Token(Token = "0x600001F")]
			get;
		}
	}
	[Token(Token = "0x2000009")]
	public interface IAchievement
	{
	}
	[Token(Token = "0x200000A")]
	public interface IAchievementDescription
	{
	}
	[Token(Token = "0x200000B")]
	public interface IScore
	{
	}
	[Token(Token = "0x200000C")]
	public enum UserScope
	{
		[Token(Token = "0x4000010")]
		Global,
		[Token(Token = "0x4000011")]
		FriendsOnly
	}
	[Token(Token = "0x200000D")]
	public enum TimeScope
	{
		[Token(Token = "0x4000013")]
		Today,
		[Token(Token = "0x4000014")]
		Week,
		[Token(Token = "0x4000015")]
		AllTime
	}
	[Token(Token = "0x200000E")]
	public struct Range
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		public int from;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x4")]
		public int count;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2E538AC", Offset = "0x2E4F8AC", VA = "0x2E538AC")]
		public Range(int fromValue, int valueCount)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public interface ILeaderboard
	{
		[Token(Token = "0x17000008")]
		bool loading
		{
			[Token(Token = "0x6000021")]
			get;
		}

		[Token(Token = "0x17000009")]
		string id
		{
			[Token(Token = "0x6000022")]
			get;
		}

		[Token(Token = "0x1700000A")]
		UserScope userScope
		{
			[Token(Token = "0x6000023")]
			get;
		}

		[Token(Token = "0x1700000B")]
		Range range
		{
			[Token(Token = "0x6000024")]
			get;
		}

		[Token(Token = "0x1700000C")]
		TimeScope timeScope
		{
			[Token(Token = "0x6000025")]
			get;
		}
	}
}
namespace UnityEngine.SocialPlatforms.Impl
{
	[Token(Token = "0x2000010")]
	public class LocalUser : UserProfile, ILocalUser, IUserProfile
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		private IUserProfile[] m_Friends;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x48")]
		private bool m_Authenticated;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x49")]
		private bool m_Underage;

		[Token(Token = "0x1700000D")]
		public bool authenticated
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2E53A20", Offset = "0x2E4FA20", VA = "0x2E53A20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2E51A20", Offset = "0x2E4DA20", VA = "0x2E51A20")]
		public LocalUser()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2E5396C", Offset = "0x2E4F96C", VA = "0x2E5396C", Slot = "8")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2E52828", Offset = "0x2E4E828", VA = "0x2E52828")]
		public void SetAuthenticated(bool value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2E52830", Offset = "0x2E4E830", VA = "0x2E52830")]
		public void SetUnderage(bool value)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class UserProfile : IUserProfile
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		protected string m_UserName;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		protected string m_ID;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		private string m_legacyID;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		protected bool m_IsFriend;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x2C")]
		protected UserState m_State;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		protected Texture2D m_Image;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		private string m_gameID;

		[Token(Token = "0x1700000E")]
		public string userName
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2E53BE8", Offset = "0x2E4FBE8", VA = "0x2E53BE8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string id
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2E53BE0", Offset = "0x2E4FBE0", VA = "0x2E53BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public bool isFriend
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2E53BF0", Offset = "0x2E4FBF0", VA = "0x2E53BF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public UserState state
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2E53BF8", Offset = "0x2E4FBF8", VA = "0x2E53BF8", Slot = "7")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2E538B4", Offset = "0x2E4F8B4", VA = "0x2E538B4")]
		public UserProfile()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2E53528", Offset = "0x2E4F528", VA = "0x2E53528")]
		public UserProfile(string name, string id, bool friend, UserState state, Texture2D image)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2E53A28", Offset = "0x2E4FA28", VA = "0x2E53A28")]
		public UserProfile(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2E53A80", Offset = "0x2E4FA80", VA = "0x2E53A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2E52840", Offset = "0x2E4E840", VA = "0x2E52840")]
		public void SetUserName(string name)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2E52838", Offset = "0x2E4E838", VA = "0x2E52838")]
		public void SetUserID(string id)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2E52848", Offset = "0x2E4E848", VA = "0x2E52848")]
		public void SetImage(Texture2D image)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Achievement : IAchievement
	{
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x10")]
		private bool m_Completed;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x11")]
		private bool m_Hidden;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		private DateTime m_LastReportedDate;

		[Token(Token = "0x17000012")]
		public string id
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2E53DC4", Offset = "0x2E4FDC4", VA = "0x2E53DC4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2E53DCC", Offset = "0x2E4FDCC", VA = "0x2E53DCC", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public double percentCompleted
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2E53DD4", Offset = "0x2E4FDD4", VA = "0x2E53DD4", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2E53DDC", Offset = "0x2E4FDDC", VA = "0x2E53DDC", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool completed
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2E53DAC", Offset = "0x2E4FDAC", VA = "0x2E53DAC", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public bool hidden
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2E53DB4", Offset = "0x2E4FDB4", VA = "0x2E53DB4", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public DateTime lastReportedDate
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2E53DBC", Offset = "0x2E4FDBC", VA = "0x2E53DBC", Slot = "10")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2E52DF8", Offset = "0x2E4EDF8", VA = "0x2E52DF8")]
		public Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2E53C00", Offset = "0x2E4FC00", VA = "0x2E53C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2E52DE0", Offset = "0x2E4EDE0", VA = "0x2E52DE0")]
		public void SetCompleted(bool value)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2E52DE8", Offset = "0x2E4EDE8", VA = "0x2E52DE8")]
		public void SetHidden(bool value)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E52DF0", Offset = "0x2E4EDF0", VA = "0x2E52DF0")]
		public void SetLastReportedDate(DateTime date)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class AchievementDescription : IAchievementDescription
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		private string m_Title;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D m_Image;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		private string m_AchievedDescription;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		private string m_UnachievedDescription;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Hidden;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x34")]
		private int m_Points;

		[Token(Token = "0x17000017")]
		public string id
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2E53F8C", Offset = "0x2E4FF8C", VA = "0x2E53F8C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2E53F94", Offset = "0x2E4FF94", VA = "0x2E53F94", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public string title
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2E53F64", Offset = "0x2E4FF64", VA = "0x2E53F64", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public string achievedDescription
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2E53F6C", Offset = "0x2E4FF6C", VA = "0x2E53F6C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public string unachievedDescription
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2E53F74", Offset = "0x2E4FF74", VA = "0x2E53F74", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public bool hidden
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2E53F84", Offset = "0x2E4FF84", VA = "0x2E53F84", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public int points
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2E53F7C", Offset = "0x2E4FF7C", VA = "0x2E53F7C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2E5357C", Offset = "0x2E4F57C", VA = "0x2E5357C")]
		public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2E53DE4", Offset = "0x2E4FDE4", VA = "0x2E53DE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public class Score : IScore
	{
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		private DateTime m_Date;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x18")]
		private string m_FormattedValue;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x20")]
		private string m_UserID;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x28")]
		private int m_Rank;

		[Token(Token = "0x1700001D")]
		public string leaderboardID
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2E54224", Offset = "0x2E50224", VA = "0x2E54224", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2E5422C", Offset = "0x2E5022C", VA = "0x2E5422C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public long value
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2E54234", Offset = "0x2E50234", VA = "0x2E54234", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2E5423C", Offset = "0x2E5023C", VA = "0x2E5423C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2E53F9C", Offset = "0x2E4FF9C", VA = "0x2E53F9C")]
		public Score(string leaderboardID, long value)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2E532B4", Offset = "0x2E4F2B4", VA = "0x2E532B4")]
		public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2E54060", Offset = "0x2E50060", VA = "0x2E54060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	public class Leaderboard : ILeaderboard
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x10")]
		private bool m_Loading;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x18")]
		private IScore m_LocalUserScore;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x20")]
		private uint m_MaxRange;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		private IScore[] m_Scores;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x30")]
		private string m_Title;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x38")]
		private string[] m_UserIDs;

		[Token(Token = "0x1700001F")]
		public bool loading
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2E533AC", Offset = "0x2E4F3AC", VA = "0x2E533AC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public string id
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2E545C8", Offset = "0x2E505C8", VA = "0x2E545C8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2E545D0", Offset = "0x2E505D0", VA = "0x2E545D0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public UserScope userScope
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2E545D8", Offset = "0x2E505D8", VA = "0x2E545D8", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(UserScope);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2E545E0", Offset = "0x2E505E0", VA = "0x2E545E0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Range range
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2E545E8", Offset = "0x2E505E8", VA = "0x2E545E8", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Range);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2E545F0", Offset = "0x2E505F0", VA = "0x2E545F0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public TimeScope timeScope
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2E545F8", Offset = "0x2E505F8", VA = "0x2E545F8", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(TimeScope);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2E54600", Offset = "0x2E50600", VA = "0x2E54600", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public IScore[] scores
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2E532AC", Offset = "0x2E4F2AC", VA = "0x2E532AC", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2E535E4", Offset = "0x2E4F5E4", VA = "0x2E535E4")]
		public Leaderboard()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2E54244", Offset = "0x2E50244", VA = "0x2E54244", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2E5330C", Offset = "0x2E4F30C", VA = "0x2E5330C")]
		public void SetScores(IScore[] scores)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2E536E8", Offset = "0x2E4F6E8", VA = "0x2E536E8")]
		public void SetTitle(string title)
		{
		}
	}
}
