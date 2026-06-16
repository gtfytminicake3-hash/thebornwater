public class FeedbackEmailer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000123")]
	public class UserAttachment
	{
		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string User_MailId;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string User_FeedBack;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string User_Location;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string User_Device;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Android_Version;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SaveData saveData;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x17590B8", Offset = "0x17550B8", VA = "0x17590B8")]
		public UserAttachment()
		{
		}
	}

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool triggerResultEmail;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool resultEmailSucess;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string playerprefBasePath;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string attachmentFilePath;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string userMailId;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public InputField PlayerMailId;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public InputField Body;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text statusText;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string From;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string UserPass;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string SMTPClient;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string SMTPPort;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string To;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string Subject;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string AttachFile;

	[Token(Token = "0x6000883")]
	[Address(RVA = "0x1758A14", Offset = "0x1754A14", VA = "0x1758A14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0x1758C44", Offset = "0x1754C44", VA = "0x1758C44")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0x1758B60", Offset = "0x1754B60", VA = "0x1758B60")]
	public void OnInitialize()
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0x1758A7C", Offset = "0x1754A7C", VA = "0x1758A7C")]
	private void GetAttachment(string path)
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0x1758D0C", Offset = "0x1754D0C", VA = "0x1758D0C")]
	private bool FileExist(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0x1758DF8", Offset = "0x1754DF8", VA = "0x1758DF8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0x1758DFC", Offset = "0x1754DFC", VA = "0x1758DFC")]
	private void SavePlayerPrefs()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0x1758CA8", Offset = "0x1754CA8", VA = "0x1758CA8")]
	private static string CreatePlayerPrefPath(string subPath)
	{
		return null;
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x1758E84", Offset = "0x1754E84", VA = "0x1758E84")]
	public static void CreateAttachmentFile()
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0x1759110", Offset = "0x1755110", VA = "0x1759110")]
	private static string ConvertToJson(UserAttachment userAttachment)
	{
		return null;
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x1759168", Offset = "0x1755168", VA = "0x1759168")]
	private static void SaveAttachmentFile(string attachmentFilePath, string attachmentFileContent, [Optional] Action<string> callBack)
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x1759350", Offset = "0x1755350", VA = "0x1759350")]
	private void ModifyAttachmentData(string userMailId = "", string userFeedBack = "")
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x1759668", Offset = "0x1755668", VA = "0x1759668")]
	public void sendEmail()
	{
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x17599C4", Offset = "0x17559C4", VA = "0x17599C4")]
	private void SendEmail(string newFilePath)
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x1759C50", Offset = "0x1755C50", VA = "0x1759C50")]
	private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x1759EB4", Offset = "0x1755EB4", VA = "0x1759EB4")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x1759F14", Offset = "0x1755F14", VA = "0x1759F14")]
	public FeedbackEmailer()
	{
	}
}
[Token(Token = "0x2000124")]
[CreateAssetMenu(fileName = "GameCheckList", menuName = "ScriptableObjects/GameCheckList")]
[ExecuteInEditMode]