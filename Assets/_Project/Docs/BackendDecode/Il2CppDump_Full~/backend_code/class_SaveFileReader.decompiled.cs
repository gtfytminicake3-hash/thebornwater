public class SaveFileReader : ScriptableObject
{
	[Token(Token = "0x4000F41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SaveData saveData;

	[Token(Token = "0x4000F42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea(1, 10)]
	public string stringToEdit;

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x16A73A8", Offset = "0x16A33A8", VA = "0x16A73A8")]
	public SaveFileReader()
	{
	}
}
[Serializable]
[Token(Token = "0x200020D")]