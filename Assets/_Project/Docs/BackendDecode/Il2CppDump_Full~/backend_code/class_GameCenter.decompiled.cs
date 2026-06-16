public class GameCenter : MonoBehaviour
{
	[Token(Token = "0x20001FA")]
	[CompilerGenerated]
	private sealed class <CheckInternetConnectivity>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool?> action;

		[Token(Token = "0x4000EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x170000B5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x16A3D18", Offset = "0x169FD18", VA = "0x16A3D18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x16A3D58", Offset = "0x169FD58", VA = "0x16A3D58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x16A30FC", Offset = "0x169F0FC", VA = "0x16A30FC")]
		[DebuggerHidden]
		public <CheckInternetConnectivity>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x16A3B6C", Offset = "0x169FB6C", VA = "0x16A3B6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x16A3B70", Offset = "0x169FB70", VA = "0x16A3B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x16A3D20", Offset = "0x169FD20", VA = "0x16A3D20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000EE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isSignedIn;

	[Token(Token = "0x4000EE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameCenter mInstance;

	[Token(Token = "0x4000EEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool iOSGCcomplete;

	[Token(Token = "0x4000EEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IAchievement[] mLoadedAchievements;

	[Token(Token = "0x4000EEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject purchaseManagerPrefab;

	[Token(Token = "0x4000EED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool enablePurchasing;

	[Token(Token = "0x4000EEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject mainMenu;

	[Token(Token = "0x4000EEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool enableIAPInternet;

	[Token(Token = "0x4000EF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool enableSavedGames;

	[Token(Token = "0x4000EF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool enableAd;

	[Token(Token = "0x4000EF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	private bool onRequestPermission;

	[Token(Token = "0x4000EF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool setTestingPlayerSaveFiles;

	[Token(Token = "0x4000EF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public static bool TestingPlayerSaveFiles;

	[Token(Token = "0x4000EF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string TestingPlayerSaveFiles_PlayerPrefs;

	[Token(Token = "0x170000B4")]
	public bool IsAdEnabled
	{
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x16A29D8", Offset = "0x169E9D8", VA = "0x16A29D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x16A29E0", Offset = "0x169E9E0", VA = "0x16A29E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x16A2BDC", Offset = "0x169EBDC", VA = "0x16A2BDC")]
	private void Check_TestingPlayerSaveFiles_PlayerPrefs()
	{
	}

	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x16A2C64", Offset = "0x169EC64", VA = "0x16A2C64")]
	public static void Disable_TestingPlayerSaveFiles()
	{
	}

	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x16A2CE4", Offset = "0x169ECE4", VA = "0x16A2CE4")]
	private static void Register_TestingPlayerSaveFiles_PlayerPrefs()
	{
	}

	[Token(Token = "0x6000D32")]
	[Address(RVA = "0x16A2D44", Offset = "0x169ED44", VA = "0x16A2D44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D33")]
	[Address(RVA = "0x16A2E30", Offset = "0x169EE30", VA = "0x16A2E30")]
	public void RequestInternetAccess()
	{
	}

	[Token(Token = "0x6000D34")]
	[Address(RVA = "0x16A2ED0", Offset = "0x169EED0", VA = "0x16A2ED0")]
	[IteratorStateMachine(typeof(<CheckInternetConnectivity>d__22))]
	private IEnumerator CheckInternetConnectivity(Action<bool?> action)
	{
		return null;
	}

	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x16A2F30", Offset = "0x169EF30", VA = "0x16A2F30")]
	private void ActivatePurchasing(bool? activate)
	{
	}

	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x16A2DD4", Offset = "0x169EDD4", VA = "0x16A2DD4")]
	public void EnableSignIn()
	{
	}

	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x16A3124", Offset = "0x169F124", VA = "0x16A3124")]
	private void RegisterToOnSceneLoaded(GameObject obj)
	{
	}

	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x16A322C", Offset = "0x169F22C", VA = "0x16A322C")]
	public static GameCenter GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x16A3284", Offset = "0x169F284", VA = "0x16A3284")]
	private void Update()
	{
	}

	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x16A3288", Offset = "0x169F288", VA = "0x16A3288")]
	private void ProcessAuthentication(bool success)
	{
	}

	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x16A342C", Offset = "0x169F42C", VA = "0x16A342C")]
	private void ProcessLoadedAchievements(IAchievement[] achievements)
	{
	}

	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x16A3448", Offset = "0x169F448", VA = "0x16A3448")]
	public void ShowLeaderBoards()
	{
	}

	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x16A35DC", Offset = "0x169F5DC", VA = "0x16A35DC")]
	public void ShowAchievements()
	{
	}

	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x16A383C", Offset = "0x169F83C", VA = "0x16A383C")]
	public void PostScores(long highscore)
	{
	}

	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0x169B068", Offset = "0x1697068", VA = "0x169B068")]
	public void PostAchievement(string id, double value = 100.0, int steps = 1)
	{
	}

	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x16A38D8", Offset = "0x169F8D8", VA = "0x16A38D8")]
	private static void HighScoreCallback(bool result)
	{
	}

	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x16A3960", Offset = "0x169F960", VA = "0x16A3960")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x16A3964", Offset = "0x169F964", VA = "0x16A3964")]
	public void SignOut()
	{
	}

	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x16A39C0", Offset = "0x169F9C0", VA = "0x16A39C0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x16A39C4", Offset = "0x169F9C4", VA = "0x16A39C4")]
	public GameCenter()
	{
	}
}
[Token(Token = "0x20001FB")]