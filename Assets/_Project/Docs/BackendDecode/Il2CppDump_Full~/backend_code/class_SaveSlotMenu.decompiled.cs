public class SaveSlotMenu : MonoBehaviour
{
	[Token(Token = "0x4000A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ConfirmDeleteSave confirmDelete;

	[Token(Token = "0x4000A8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MainMenu mainMenu;

	[Token(Token = "0x4000A8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SaveSlotButton[] buttons;

	[Token(Token = "0x4000A8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] debugButtons;

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x176DFE8", Offset = "0x1769FE8", VA = "0x176DFE8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x176DFEC", Offset = "0x1769FEC", VA = "0x176DFEC")]
	private void UpdateCustomSavedebugTool()
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x176E0E4", Offset = "0x176A0E4", VA = "0x176E0E4")]
	public void UpdateUI()
	{
	}

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x176DC70", Offset = "0x1769C70", VA = "0x176DC70")]
	public void OnClick(SaveSlots slot)
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x176E604", Offset = "0x176A604", VA = "0x176E604")]
	private bool CheckForPurchaseComplete(SaveSlots slot)
	{
		return default(bool);
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x176DDD0", Offset = "0x1769DD0", VA = "0x176DDD0")]
	public void OnDelete(SaveSlots slot)
	{
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x176B658", Offset = "0x1767658", VA = "0x176B658")]
	public void ConfirmDelete(SaveSlots slotId)
	{
	}

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x176B6E8", Offset = "0x17676E8", VA = "0x176B6E8")]
	public void CancelDelete()
	{
	}

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x176E9CC", Offset = "0x176A9CC", VA = "0x176E9CC")]
	public void CallUpdateUI()
	{
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x176E9D0", Offset = "0x176A9D0", VA = "0x176E9D0")]
	public SaveSlotMenu()
	{
	}
}
[Token(Token = "0x200016A")]