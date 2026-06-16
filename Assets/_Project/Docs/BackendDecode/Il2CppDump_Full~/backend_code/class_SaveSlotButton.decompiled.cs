public class SaveSlotButton : MonoBehaviour
{
	[Token(Token = "0x4000A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text saveName;

	[Token(Token = "0x4000A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text saveDate;

	[Token(Token = "0x4000A89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject DeleteButton;

	[Token(Token = "0x4000A8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SaveSlotMenu saveSlotMenu;

	[Token(Token = "0x4000A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SaveSlots index;

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x176DB58", Offset = "0x1769B58", VA = "0x176DB58")]
	public void Set(string sName, string sDate, bool showButon, SaveSlots indexArg)
	{
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x176DBE0", Offset = "0x1769BE0", VA = "0x176DBE0")]
	public void SetForCalendarissue(string sName, bool showButon, SaveSlots indexArg)
	{
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x176DC54", Offset = "0x1769C54", VA = "0x176DC54")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x176DDB4", Offset = "0x1769DB4", VA = "0x176DDB4")]
	public void OnDelete()
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x176DFE0", Offset = "0x1769FE0", VA = "0x176DFE0")]
	public SaveSlotButton()
	{
	}
}
[Token(Token = "0x2000168")]