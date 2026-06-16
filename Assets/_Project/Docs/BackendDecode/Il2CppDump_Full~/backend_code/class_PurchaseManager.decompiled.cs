public class PurchaseManager : MonoBehaviour
{
	[Token(Token = "0x2000174")]
	[CompilerGenerated]
	private sealed class <DummyCode>d__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PurchaseManager <>4__this;

		[Token(Token = "0x170000A0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1773FF0", Offset = "0x176FFF0", VA = "0x1773FF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1774030", Offset = "0x1770030", VA = "0x1774030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1773764", Offset = "0x176F764", VA = "0x1773764")]
		[DebuggerHidden]
		public <DummyCode>d__85(int <>1__state)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1773E90", Offset = "0x176FE90", VA = "0x1773E90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1773E94", Offset = "0x176FE94", VA = "0x1773E94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1773FF8", Offset = "0x176FFF8", VA = "0x1773FF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class <OnPurchaseCompleteCoroutine>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PurchaseManager <>4__this;

		[Token(Token = "0x170000A2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x17740D8", Offset = "0x17700D8", VA = "0x17740D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1774118", Offset = "0x1770118", VA = "0x1774118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1772A54", Offset = "0x176EA54", VA = "0x1772A54")]
		[DebuggerHidden]
		public <OnPurchaseCompleteCoroutine>d__66(int <>1__state)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1774038", Offset = "0x1770038", VA = "0x1774038", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x177403C", Offset = "0x177003C", VA = "0x177403C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x17740E0", Offset = "0x17700E0", VA = "0x17740E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class <PurchaseCheckCoroutine>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PurchaseManager <>4__this;

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <initTimeout>5__2;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <initStart>5__3;

		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Product <product>5__4;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <restoreWait>5__5;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <restoreStart>5__6;

		[Token(Token = "0x170000A4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x1775394", Offset = "0x1771394", VA = "0x1775394", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x17753D4", Offset = "0x17713D4", VA = "0x17753D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1772298", Offset = "0x176E298", VA = "0x1772298")]
		[DebuggerHidden]
		public <PurchaseCheckCoroutine>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1774120", Offset = "0x1770120", VA = "0x1774120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1774124", Offset = "0x1770124", VA = "0x1774124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x177539C", Offset = "0x177139C", VA = "0x177539C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class <WaitForIAPInitialization>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PurchaseManager <>4__this;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timeout>5__2;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <startTime>5__3;

		[Token(Token = "0x170000A6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x17755F0", Offset = "0x17715F0", VA = "0x17755F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1775630", Offset = "0x1771630", VA = "0x1775630", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1772320", Offset = "0x176E320", VA = "0x1772320")]
		[DebuggerHidden]
		public <WaitForIAPInitialization>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x17753DC", Offset = "0x17713DC", VA = "0x17753DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x17753E0", Offset = "0x17713E0", VA = "0x17753E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x17755F8", Offset = "0x17715F8", VA = "0x17755F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000ACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PurchaseManager instance;

	[Token(Token = "0x4000ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int dayLimit;

	[Token(Token = "0x4000AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int perDayCount_Ad;

	[Token(Token = "0x4000AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool hasChecked;

	[Token(Token = "0x4000AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[SerializeField]
	private bool isFirstEntry;

	[Token(Token = "0x4000AD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool isActive;

	[Token(Token = "0x4000AD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool isPopUpActive;

	[Token(Token = "0x4000AD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string playerPrefsID;

	[Token(Token = "0x4000AD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string firstEntry;

	[Token(Token = "0x4000AD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string adz_FirstEntry;

	[Token(Token = "0x4000AD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string productID;

	[Token(Token = "0x4000AD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string localizedPricing;

	[Token(Token = "0x4000ADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action<bool> eventRegistor;

	[Token(Token = "0x4000ADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Scene currentScene;

	[Token(Token = "0x4000ADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject demoEndedText;

	[Token(Token = "0x4000ADD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject demoAckText;

	[Token(Token = "0x4000ADE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject cancelButton;

	[Token(Token = "0x4000ADF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject ackButton;

	[Token(Token = "0x4000AE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject popUpPanel;

	[Token(Token = "0x4000AE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject purchasePanel;

	[Token(Token = "0x4000AE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject ingamePopUpPanel;

	[Token(Token = "0x4000AE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject mainPanel;

	[Token(Token = "0x4000AE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject adPanel;

	[Token(Token = "0x4000AE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject unleashPanel;

	[Token(Token = "0x4000AE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject internetAccessDialogueBox;

	[Token(Token = "0x4000AE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject enableInternetButton;

	[Token(Token = "0x4000AE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject quitButton;

	[Token(Token = "0x4000AE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject internetNotAvailableText;

	[Token(Token = "0x4000AEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private GameObject internetRetryingText;

	[Token(Token = "0x4000AEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[EventRef]
	[SerializeField]
	private string clickSoundSmall;

	[Token(Token = "0x4000AEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool enableAdMode;

	[Token(Token = "0x4000AED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Action onAdPopupDisabledCallback;

	[Token(Token = "0x4000AEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Button unleashButton;

	[Token(Token = "0x4000AEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool testing;

	[Token(Token = "0x4000AF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private IMediationManager casManager;

	[Token(Token = "0x4000AF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private StoreController _store;

	[Token(Token = "0x4000AF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private CatalogProvider _catalog;

	[Token(Token = "0x4000AF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _iapReady;

	[Token(Token = "0x4000AF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private IEnumerator enumeratorAdz;

	[Token(Token = "0x4000AF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int counter;

	[Token(Token = "0x4000AF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private string earnedPlayerPref;

	[Token(Token = "0x4000AF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private string watchedPlayerPref;

	[Token(Token = "0x1700009C")]
	public static PurchaseManager Instance
	{
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x17717B0", Offset = "0x176D7B0", VA = "0x17717B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009D")]
	public bool IsPurchased
	{
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x17717F8", Offset = "0x176D7F8", VA = "0x17717F8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x1771800", Offset = "0x176D800", VA = "0x1771800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	public bool IsAdEnabled
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1771808", Offset = "0x176D808", VA = "0x1771808")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700009F")]
	public GameObject MainMenu
	{
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1771810", Offset = "0x176D810", VA = "0x1771810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1771818", Offset = "0x176D818", VA = "0x1771818")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x1771820", Offset = "0x176D820", VA = "0x1771820")]
	public void LoadAdScene()
	{
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x1771874", Offset = "0x176D874", VA = "0x1771874")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x1771A24", Offset = "0x176DA24", VA = "0x1771A24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x1771E24", Offset = "0x176DE24", VA = "0x1771E24")]
	public void OnInitialized(bool? isInternetAvailable)
	{
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x17721B8", Offset = "0x176E1B8", VA = "0x17721B8")]
	private void CheckForPurchasingOnEntry()
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x1771FF0", Offset = "0x176DFF0", VA = "0x1771FF0")]
	private void EnableDisableInternetAccessDialogueBox(bool enable)
	{
	}

	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x17720A8", Offset = "0x176E0A8", VA = "0x17720A8")]
	private void OnInternetAccessDialogueBox(bool set)
	{
	}

	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x1772240", Offset = "0x176E240", VA = "0x1772240")]
	public void OnEnableInternetAccess()
	{
	}

	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x1772248", Offset = "0x176E248", VA = "0x1772248")]
	public void OnQuit()
	{
	}

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x1772158", Offset = "0x176E158", VA = "0x1772158")]
	[IteratorStateMachine(typeof(<PurchaseCheckCoroutine>d__59))]
	private IEnumerator PurchaseCheckCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x17722C0", Offset = "0x176E2C0", VA = "0x17722C0")]
	[IteratorStateMachine(typeof(<WaitForIAPInitialization>d__60))]
	private IEnumerator WaitForIAPInitialization()
	{
		return null;
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x1772348", Offset = "0x176E348", VA = "0x1772348")]
	public void OnFirstEntry()
	{
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x17723EC", Offset = "0x176E3EC", VA = "0x17723EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x177245C", Offset = "0x176E45C", VA = "0x177245C")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x177269C", Offset = "0x176E69C", VA = "0x177269C")]
	public void OnPurchaseComplete(Product product)
	{
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x1772988", Offset = "0x176E988", VA = "0x1772988")]
	public void OnPurchaseComplete()
	{
	}

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x1772928", Offset = "0x176E928", VA = "0x1772928")]
	[IteratorStateMachine(typeof(<OnPurchaseCompleteCoroutine>d__66))]
	private IEnumerator OnPurchaseCompleteCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x1772A7C", Offset = "0x176EA7C", VA = "0x1772A7C")]
	public void DisableAll()
	{
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x1773020", Offset = "0x176F020", VA = "0x1773020")]
	public void OnPurchaseFailure(Product product, PurchaseFailureReason reason)
	{
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x176E8C8", Offset = "0x176A8C8", VA = "0x176E8C8")]
	public void GetPurchaseStatus(Action<bool> callBack)
	{
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x176EB44", Offset = "0x176AB44", VA = "0x176EB44")]
	public void InvokePurchase()
	{
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x176E994", Offset = "0x176A994", VA = "0x176E994")]
	public void ClearToGo()
	{
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x177314C", Offset = "0x176F14C", VA = "0x177314C")]
	private void EnablePopUp()
	{
	}

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x1772BF8", Offset = "0x176EBF8", VA = "0x1772BF8")]
	private void DisablePopUp()
	{
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x1773414", Offset = "0x176F414", VA = "0x1773414")]
	public void GotoMenu()
	{
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x17734DC", Offset = "0x176F4DC", VA = "0x17734DC")]
	public void AdGoToMenu()
	{
	}

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x1773584", Offset = "0x176F584", VA = "0x1773584")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x177359C", Offset = "0x176F59C", VA = "0x177359C")]
	public void Understood()
	{
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x17735F0", Offset = "0x176F5F0", VA = "0x17735F0")]
	public void DisableAnimator()
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x1772794", Offset = "0x176E794", VA = "0x1772794")]
	private bool CheckPurchaseStatus(bool iapStatus)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x1772424", Offset = "0x176E424", VA = "0x1772424")]
	private void Notify()
	{
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x1773434", Offset = "0x176F434", VA = "0x1773434")]
	private void PlayClickSound()
	{
	}

	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x17736B0", Offset = "0x176F6B0", VA = "0x17736B0")]
	public void RecallAd()
	{
	}

	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x1773704", Offset = "0x176F704", VA = "0x1773704")]
	[IteratorStateMachine(typeof(<DummyCode>d__85))]
	private IEnumerator DummyCode()
	{
		return null;
	}

	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x177378C", Offset = "0x176F78C", VA = "0x177378C")]
	public void EnableAdPopup(Action action)
	{
	}

	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x1772EF8", Offset = "0x176EEF8", VA = "0x1772EF8")]
	public void DisableAdPopup()
	{
	}

	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x177394C", Offset = "0x176F94C", VA = "0x177394C")]
	public void OnAdWatched()
	{
	}

	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x17739FC", Offset = "0x176F9FC", VA = "0x17739FC")]
	public void WatchAd()
	{
	}

	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x1773AA4", Offset = "0x176FAA4", VA = "0x1773AA4")]
	public void HasUserEarnedRewardOnLastAd(int set)
	{
	}

	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x1773AB0", Offset = "0x176FAB0", VA = "0x1773AB0")]
	public void HasUserWatchedAdForTheDay(int day)
	{
	}

	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x1773ABC", Offset = "0x176FABC", VA = "0x1773ABC")]
	public int CheckForUsersLastRewardStatus()
	{
		return default(int);
	}

	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x1773AF0", Offset = "0x176FAF0", VA = "0x1773AF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x1773BA0", Offset = "0x176FBA0", VA = "0x1773BA0")]
	public PurchaseManager()
	{
	}
}
[Token(Token = "0x2000178")]