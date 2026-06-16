using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000003")]
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
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x166FE14", Offset = "0x166BE14", VA = "0x166FE14")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x166FECC", Offset = "0x166BECC", VA = "0x166FECC")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace Prime31;

[Token(Token = "0x2000004")]
public class iCloudEventListener : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x166FED4", Offset = "0x166BED4", VA = "0x166FED4")]
	public iCloudEventListener()
	{
	}
}
[Token(Token = "0x2000005")]
public class iCloudGUIManager : MonoBehaviourGUI
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x166FEDC", Offset = "0x166BEDC", VA = "0x166FEDC")]
	public iCloudGUIManager()
	{
	}
}
