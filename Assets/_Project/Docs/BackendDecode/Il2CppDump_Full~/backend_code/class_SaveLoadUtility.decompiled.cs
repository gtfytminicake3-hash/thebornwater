public class SaveLoadUtility : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x200021E")]
	[CompilerGenerated]
	private struct <GetCloudSaveRefrence>d__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4000FDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000FDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000FE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SaveLoadUtility <>4__this;

		[Token(Token = "0x4000FE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x16AC410", Offset = "0x16A8410", VA = "0x16AC410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x16AC758", Offset = "0x16A8758", VA = "0x16AC758", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200021F")]
	[CompilerGenerated]
	private struct <LoadAll>d__25 : IAsyncStateMachine
	{
		[Token(Token = "0x4000FE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000FE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000FE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SaveLoadUtility <>4__this;

		[Token(Token = "0x4000FE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timeout>5__2;

		[Token(Token = "0x4000FE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x4000FE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x16AC7C0", Offset = "0x16A87C0", VA = "0x16AC7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x16AE2A4", Offset = "0x16AA2A4", VA = "0x16AE2A4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000FCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SaveFileReader readFromString;

	[Token(Token = "0x4000FCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SaveLoadUtility mInstance;

	[Token(Token = "0x4000FCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SaveData[] saveSlot;

	[Token(Token = "0x4000FCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SaveSlots currentSlot;

	[Token(Token = "0x4000FCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<SaveSlots, int> isTheSlotCloud;

	[Token(Token = "0x4000FCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string saveGameID_DateTime;

	[Token(Token = "0x4000FD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string saveGameID_Day;

	[Token(Token = "0x4000FD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action RegisterToOnLoadAll;

	[Token(Token = "0x4000FD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<SaveData> RegisterToOnLoadCurrentSlot;

	[Token(Token = "0x4000FD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string customSave;

	[Token(Token = "0x4000FD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SaveSlots overrideSlot;

	[Token(Token = "0x4000FD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SaveData customSaveData;

	[Token(Token = "0x4000FD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private SaveSlotMenu saveSlotMenu;

	[Token(Token = "0x4000FD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private MainMenu mainMenu;

	[Token(Token = "0x4000FD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GPGSCloudSave cloudSave;

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x16A8AF8", Offset = "0x16A4AF8", VA = "0x16A8AF8")]
	public static SaveLoadUtility GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x16A8B40", Offset = "0x16A4B40", VA = "0x16A8B40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x16A8CC4", Offset = "0x16A4CC4", VA = "0x16A8CC4")]
	[AsyncStateMachine(typeof(<GetCloudSaveRefrence>d__17))]
	private Task GetCloudSaveRefrence()
	{
		return null;
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x16A8D80", Offset = "0x16A4D80", VA = "0x16A8D80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x16A8E44", Offset = "0x16A4E44", VA = "0x16A8E44")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x16A8FE0", Offset = "0x16A4FE0", VA = "0x16A8FE0")]
	public void SetCurrentSlot(SaveSlots slot)
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x16A917C", Offset = "0x16A517C", VA = "0x16A917C")]
	public SaveSlots GetCurrentSlot()
	{
		return default(SaveSlots);
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x16A9184", Offset = "0x16A5184", VA = "0x16A9184")]
	public void SaveCurrentSlot(SaveData data)
	{
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x16A95C4", Offset = "0x16A55C4", VA = "0x16A95C4")]
	public void SaveCurrentDataToP31Prefs(SaveData data, SaveSlots saveSlot)
	{
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x16A95C8", Offset = "0x16A55C8", VA = "0x16A95C8")]
	public void Save(GameController gameControllerInstance)
	{
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x16A8D84", Offset = "0x16A4D84", VA = "0x16A8D84")]
	[AsyncStateMachine(typeof(<LoadAll>d__25))]
	public Task LoadAll()
	{
		return null;
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x16AAA40", Offset = "0x16A6A40", VA = "0x16AAA40")]
	public void LoadCurrentSlot(Action<SaveData> action)
	{
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x16AAADC", Offset = "0x16A6ADC", VA = "0x16AAADC")]
	public SaveData LoadCurrentSlot()
	{
		return null;
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x16AB094", Offset = "0x16A7094", VA = "0x16AB094")]
	public string GetCurrentSaveString()
	{
		return null;
	}

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x16AB148", Offset = "0x16A7148", VA = "0x16AB148")]
	public void DeleteAll()
	{
	}

	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x16AB150", Offset = "0x16A7150", VA = "0x16AB150")]
	public void DeleteSlot(SaveSlots slot)
	{
	}

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x16AB290", Offset = "0x16A7290", VA = "0x16AB290")]
	private void FindWhichHasMoreDays(SaveData playerPrefsData, SaveData p31PrefsData, Action<bool, SaveData> callback)
	{
	}

	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x16AB404", Offset = "0x16A7404", VA = "0x16AB404")]
	private SaveData FindWhichHasMoreDays(SaveData localSaveData, SaveData cloudSaveData, string slot, int currentSlot)
	{
		return null;
	}

	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x16AB818", Offset = "0x16A7818", VA = "0x16AB818")]
	private void OverrideLocalSaveDate(SaveData data, string slot, int currentSlot)
	{
	}

	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x16AB9A0", Offset = "0x16A79A0", VA = "0x16AB9A0")]
	private int StringIntoSlot(string slot)
	{
		return default(int);
	}

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x16ABABC", Offset = "0x16A7ABC", VA = "0x16ABABC")]
	public void LoadCustomSaveFile()
	{
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x16ABC48", Offset = "0x16A7C48", VA = "0x16ABC48")]
	public void SaveDataToAFile(int saveSlot)
	{
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x16ABE84", Offset = "0x16A7E84", VA = "0x16ABE84")]
	public SaveLoadUtility()
	{
	}
}
[Token(Token = "0x2000220")]