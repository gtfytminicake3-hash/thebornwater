using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using FMOD;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using UnityEngine.Timeline;

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
	[Address(RVA = "0x17C9F10", Offset = "0x17C5F10", VA = "0x17C9F10")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x17C9FCC", Offset = "0x17C5FCC", VA = "0x17C9FCC")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace FMODUnity
{
	[Token(Token = "0x2000004")]
	public class PlatformAndroid : Platform
	{
		[Token(Token = "0x17000001")]
		internal override string DisplayName
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x17CA050", Offset = "0x17C6050", VA = "0x17CA050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x17C9FD4", Offset = "0x17C5FD4", VA = "0x17C9FD4")]
		static PlatformAndroid()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17CA090", Offset = "0x17C6090", VA = "0x17CA090", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17CA2C0", Offset = "0x17C62C0", VA = "0x17CA2C0", Slot = "11")]
		internal override string GetBankFolder()
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17CA30C", Offset = "0x17C630C", VA = "0x17CA30C")]
		internal static string StaticGetBankFolder()
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x17CA458", Offset = "0x17C6458", VA = "0x17CA458", Slot = "13")]
		internal override string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x17CA4AC", Offset = "0x17C64AC", VA = "0x17CA4AC")]
		internal static string StaticGetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17CA4F8", Offset = "0x17C64F8", VA = "0x17CA4F8")]
		public PlatformAndroid()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class PlatformWebGL : Platform
	{
		[Token(Token = "0x17000002")]
		internal override string DisplayName
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x17CA67C", Offset = "0x17C667C", VA = "0x17CA67C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x17CA600", Offset = "0x17C6600", VA = "0x17CA600")]
		static PlatformWebGL()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x17CA6BC", Offset = "0x17C66BC", VA = "0x17CA6BC", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x17CA6D8", Offset = "0x17C66D8", VA = "0x17CA6D8", Slot = "13")]
		internal override string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x17CA748", Offset = "0x17C6748", VA = "0x17CA748")]
		public PlatformWebGL()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class PlatformIOS : Platform
	{
		[Token(Token = "0x17000003")]
		internal override string DisplayName
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17CA818", Offset = "0x17C6818", VA = "0x17CA818", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x17CA79C", Offset = "0x17C679C", VA = "0x17CA79C")]
		static PlatformIOS()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x17CA858", Offset = "0x17C6858", VA = "0x17CA858", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17CA874", Offset = "0x17C6874", VA = "0x17CA874", Slot = "14")]
		internal override void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17CA8F4", Offset = "0x17C68F4", VA = "0x17CA8F4")]
		public static void StaticLoadPlugins(Platform platform, FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17CA910", Offset = "0x17C6910", VA = "0x17CA910")]
		public PlatformIOS()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class PlatformLinux : Platform
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<CodecChannelCount> staticCodecChannels;

		[Token(Token = "0x17000004")]
		internal override string DisplayName
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x17CAB64", Offset = "0x17C6B64", VA = "0x17CAB64", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		internal override List<CodecChannelCount> DefaultCodecChannels
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x17CAC30", Offset = "0x17C6C30", VA = "0x17CAC30", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17CA964", Offset = "0x17C6964", VA = "0x17CA964")]
		static PlatformLinux()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17CABA4", Offset = "0x17C6BA4", VA = "0x17CABA4", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17CABC0", Offset = "0x17C6BC0", VA = "0x17CABC0", Slot = "13")]
		internal override string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17CAC88", Offset = "0x17C6C88", VA = "0x17CAC88")]
		public PlatformLinux()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class PlatformMac : Platform
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<CodecChannelCount> staticCodecChannels;

		[Token(Token = "0x17000006")]
		internal override string DisplayName
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x17CAED4", Offset = "0x17C6ED4", VA = "0x17CAED4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		internal override List<CodecChannelCount> DefaultCodecChannels
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x17CB000", Offset = "0x17C7000", VA = "0x17CB000", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17CACDC", Offset = "0x17C6CDC", VA = "0x17CACDC")]
		static PlatformMac()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x17CAF14", Offset = "0x17C6F14", VA = "0x17CAF14", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17CAF30", Offset = "0x17C6F30", VA = "0x17CAF30", Slot = "13")]
		internal override string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17CB058", Offset = "0x17C7058", VA = "0x17CB058")]
		public PlatformMac()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class PlatformAppleTV : Platform
	{
		[Token(Token = "0x17000008")]
		internal override string DisplayName
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x17CB128", Offset = "0x17C7128", VA = "0x17CB128", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17CB0AC", Offset = "0x17C70AC", VA = "0x17CB0AC")]
		static PlatformAppleTV()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17CB168", Offset = "0x17C7168", VA = "0x17CB168", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17CB184", Offset = "0x17C7184", VA = "0x17CB184", Slot = "14")]
		internal override void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17CB204", Offset = "0x17C7204", VA = "0x17CB204")]
		public PlatformAppleTV()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class PlatformVisionOS : Platform
	{
		[Token(Token = "0x17000009")]
		internal override string DisplayName
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x17CB2D4", Offset = "0x17C72D4", VA = "0x17CB2D4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17CB258", Offset = "0x17C7258", VA = "0x17CB258")]
		static PlatformVisionOS()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x17CB314", Offset = "0x17C7314", VA = "0x17CB314", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x17CB318", Offset = "0x17C7318", VA = "0x17CB318", Slot = "14")]
		internal override void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17CB398", Offset = "0x17C7398", VA = "0x17CB398")]
		public PlatformVisionOS()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class PlatformWindows : Platform
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<CodecChannelCount> staticCodecChannels;

		[Token(Token = "0x1700000A")]
		internal override string DisplayName
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x17CB5E4", Offset = "0x17C75E4", VA = "0x17CB5E4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		internal override List<CodecChannelCount> DefaultCodecChannels
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x17CB6D0", Offset = "0x17C76D0", VA = "0x17CB6D0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x17CB3EC", Offset = "0x17C73EC", VA = "0x17CB3EC")]
		static PlatformWindows()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x17CB624", Offset = "0x17C7624", VA = "0x17CB624", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17CB684", Offset = "0x17C7684", VA = "0x17CB684", Slot = "13")]
		internal override string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17CB728", Offset = "0x17C7728", VA = "0x17CB728")]
		public PlatformWindows()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public struct AutomatableSlots
	{
		[Token(Token = "0x4000009")]
		public const int Count = 16;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("slot00")]
		public float Slot00;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[FormerlySerializedAs("slot01")]
		public float Slot01;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("slot02")]
		public float Slot02;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[FormerlySerializedAs("slot03")]
		public float Slot03;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("slot04")]
		public float Slot04;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("slot05")]
		public float Slot05;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("slot06")]
		public float Slot06;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("slot07")]
		public float Slot07;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("slot08")]
		public float Slot08;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("slot09")]
		public float Slot09;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("slot10")]
		public float Slot10;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("slot11")]
		public float Slot11;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("slot12")]
		public float Slot12;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("slot13")]
		public float Slot13;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("slot14")]
		public float Slot14;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("slot15")]
		public float Slot15;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17CB77C", Offset = "0x17C777C", VA = "0x17CB77C")]
		public float GetValue(int index)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200000D")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17CB894", Offset = "0x17C7894", VA = "0x17CB894")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public abstract class EventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string CollisionTag;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x17CB89C", Offset = "0x17C789C", VA = "0x17CB89C", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x17CB8AC", Offset = "0x17C78AC", VA = "0x17CB8AC", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x17CB8BC", Offset = "0x17C78BC", VA = "0x17CB8BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x17CB8CC", Offset = "0x17C78CC", VA = "0x17CB8CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x17CB8DC", Offset = "0x17C78DC", VA = "0x17CB8DC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x17CB9BC", Offset = "0x17C79BC", VA = "0x17CB9BC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x17CBA9C", Offset = "0x17C7A9C", VA = "0x17CBA9C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x17CBB00", Offset = "0x17C7B00", VA = "0x17CBB00")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x17CBB64", Offset = "0x17C7B64", VA = "0x17CBB64")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x17CBB74", Offset = "0x17C7B74", VA = "0x17CBB74")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x17CBB84", Offset = "0x17C7B84", VA = "0x17CBB84")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x17CBB94", Offset = "0x17C7B94", VA = "0x17CBB94")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x17CBBA4", Offset = "0x17C7BA4", VA = "0x17CBBA4")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x17CBBB4", Offset = "0x17C7BB4", VA = "0x17CBBB4")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x17CBBC4", Offset = "0x17C7BC4", VA = "0x17CBBC4")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x17CBBD4", Offset = "0x17C7BD4", VA = "0x17CBBD4")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17CBBE4", Offset = "0x17C7BE4", VA = "0x17CBBE4", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x17CBBF4", Offset = "0x17C7BF4", VA = "0x17CBBF4", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x17CBC04", Offset = "0x17C7C04", VA = "0x17CBC04", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x17CBC14", Offset = "0x17C7C14", VA = "0x17CBC14", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000048")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17CBC24", Offset = "0x17C7C24", VA = "0x17CBC24")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[Obsolete("Use the EventReference struct instead")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string MigrateTo;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x17CBC74", Offset = "0x17C7C74", VA = "0x17CBC74")]
		public EventRefAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public struct EventReference
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GUID Guid;

		[Token(Token = "0x1700000C")]
		public bool IsNull
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x17CBCE8", Offset = "0x17C7CE8", VA = "0x17CBCE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x17CBC7C", Offset = "0x17C7C7C", VA = "0x17CBC7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("template")]
		public FMODEventPlayableBehavior Template;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("eventLength")]
		public float EventLength;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Obsolete("Use the eventReference field instead")]
		public string eventName;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("eventReference")]
		[SerializeField]
		public EventReference EventReference;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("stopType")]
		[SerializeField]
		public STOP_MODE StopType;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("parameters")]
		[SerializeField]
		public ParamRef[] Parameters;

		[NonSerialized]
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool CachedParameters;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private FMODEventPlayableBehavior behavior;

		[Token(Token = "0x1700000D")]
		public GameObject TrackTargetObject
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x17CBEE0", Offset = "0x17C7EE0", VA = "0x17CBEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x17CBEE8", Offset = "0x17C7EE8", VA = "0x17CBEE8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public override double duration
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x17CBEF0", Offset = "0x17C7EF0", VA = "0x17CBEF0", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700000F")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x17CBF24", Offset = "0x17C7F24", VA = "0x17CBF24", Slot = "9")]
			get
			{
				return default(ClipCaps);
			}
		}

		[Token(Token = "0x17000010")]
		public TimelineClip OwningClip
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x17CBF2C", Offset = "0x17C7F2C", VA = "0x17CBF2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x17CBF34", Offset = "0x17C7F34", VA = "0x17CBF34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event EventHandler<EventArgs> OnCreatePlayable
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x17CBD48", Offset = "0x17C7D48", VA = "0x17CBD48")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x17CBE14", Offset = "0x17C7E14", VA = "0x17CBE14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x17CBF3C", Offset = "0x17C7F3C", VA = "0x17CBF3C")]
		public void LinkParameters(EventDescription eventDescription)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x17CC0D0", Offset = "0x17C80D0", VA = "0x17CC0D0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17CC3DC", Offset = "0x17C83DC", VA = "0x17CC3DC")]
		public FMODEventPlayable()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public enum STOP_MODE
	{
		[Token(Token = "0x4000029")]
		AllowFadeout,
		[Token(Token = "0x400002A")]
		Immediate,
		[Token(Token = "0x400002B")]
		None
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class ParameterAutomationLink
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PARAMETER_ID ID;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Slot;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x17CC518", Offset = "0x17C8518", VA = "0x17CC518")]
		public ParameterAutomationLink()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class FMODEventPlayableBehavior : PlayableBehaviour
	{
		[Token(Token = "0x2000015")]
		public class EventArgs : System.EventArgs
		{
			[Token(Token = "0x17000013")]
			public EventInstance eventInstance
			{
				[Token(Token = "0x600006A")]
				[Address(RVA = "0x17CD798", Offset = "0x17C9798", VA = "0x17CD798")]
				[CompilerGenerated]
				get
				{
					return default(EventInstance);
				}
				[Token(Token = "0x600006B")]
				[Address(RVA = "0x17CD7A0", Offset = "0x17C97A0", VA = "0x17CD7A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x17CD24C", Offset = "0x17C924C", VA = "0x17CD24C")]
			public EventArgs()
			{
			}
		}

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("eventReference")]
		public EventReference EventReference;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("stopType")]
		public STOP_MODE StopType;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("parameters")]
		[NotKeyable]
		public ParamRef[] Parameters;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("parameterLinks")]
		public List<ParameterAutomationLink> ParameterLinks;

		[NonSerialized]
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject TrackTargetObject;

		[NonSerialized]
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TimelineClip OwningClip;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("parameterAutomation")]
		public AutomatableSlots ParameterAutomation;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool isPlayheadInside;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private EventInstance eventInstance;

		[Token(Token = "0x17000011")]
		public float ClipStartTime
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x17CC9F8", Offset = "0x17C89F8", VA = "0x17CC9F8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x17CCA00", Offset = "0x17C8A00", VA = "0x17CCA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float CurrentVolume
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x17CCA08", Offset = "0x17C8A08", VA = "0x17CCA08")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x17CCA10", Offset = "0x17C8A10", VA = "0x17CCA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event EventHandler<EventArgs> Enter
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x17CC520", Offset = "0x17C8520", VA = "0x17CC520")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x17CC5EC", Offset = "0x17C85EC", VA = "0x17CC5EC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event EventHandler<EventArgs> Exit
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x17CC6B8", Offset = "0x17C86B8", VA = "0x17CC6B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x17CC788", Offset = "0x17C8788", VA = "0x17CC788")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event EventHandler<EventArgs> GraphStop
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x17CC858", Offset = "0x17C8858", VA = "0x17CC858")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x17CC928", Offset = "0x17C8928", VA = "0x17CC928")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x17CC468", Offset = "0x17C8468", VA = "0x17CC468")]
		public FMODEventPlayableBehavior()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x17CCA18", Offset = "0x17C8A18", VA = "0x17CCA18")]
		protected void PlayEvent()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x17CD160", Offset = "0x17C9160", VA = "0x17CD160", Slot = "22")]
		protected virtual void OnEnter()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x17CD2A4", Offset = "0x17C92A4", VA = "0x17CD2A4", Slot = "23")]
		protected virtual void OnExit()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x17CD3D4", Offset = "0x17C93D4", VA = "0x17CD3D4", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x17CD538", Offset = "0x17C9538", VA = "0x17CD538")]
		public void UpdateBehavior(float time, float volume)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x17CD5F4", Offset = "0x17C95F4", VA = "0x17CD5F4", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}
	}
	[Token(Token = "0x2000016")]
	[TrackBindingType(typeof(GameObject))]
	[DisplayName("FMOD/Event Track")]
	[TrackClipType(typeof(FMODEventPlayable))]
	[TrackColor(0.066f, 0.134f, 0.244f)]
	public class FMODEventTrack : TrackAsset
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FMODEventMixerBehaviour template;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x17CD7A8", Offset = "0x17C97A8", VA = "0x17CD7A8", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x17CDBF0", Offset = "0x17C9BF0", VA = "0x17CDBF0")]
		public FMODEventTrack()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class FMODEventMixerBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float volume;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x17CDC94", Offset = "0x17C9C94", VA = "0x17CDC94", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x17CDC84", Offset = "0x17C9C84", VA = "0x17CDC84")]
		public FMODEventMixerBehaviour()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x17CDE48", Offset = "0x17C9E48", VA = "0x17CDE48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x17CE064", Offset = "0x17CA064", VA = "0x17CE064")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class ParamRef
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x17CE06C", Offset = "0x17CA06C", VA = "0x17CE06C")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x17CE074", Offset = "0x17CA074", VA = "0x17CE074")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class PlatformCallbackHandler : ScriptableObject
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x17CE07C", Offset = "0x17CA07C", VA = "0x17CE07C", Slot = "4")]
		public virtual void PreInitialize(FMOD.Studio.System system, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x17CE080", Offset = "0x17CA080", VA = "0x17CE080")]
		public PlatformCallbackHandler()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public abstract class Platform : ScriptableObject
	{
		[Token(Token = "0x200001D")]
		public class Property<T>
		{
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T Value;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool HasValue;

			[Token(Token = "0x60000AB")]
			public Property()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200001E")]
		public class PropertyBool : Property<TriStateBool>
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x17CFE44", Offset = "0x17CBE44", VA = "0x17CFE44")]
			public PropertyBool()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200001F")]
		public class PropertyScreenPosition : Property<ScreenPosition>
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x17CFE8C", Offset = "0x17CBE8C", VA = "0x17CFE8C")]
			public PropertyScreenPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000020")]
		public class PropertyInt : Property<int>
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x17CFED4", Offset = "0x17CBED4", VA = "0x17CFED4")]
			public PropertyInt()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000021")]
		public class PropertySpeakerMode : Property<SPEAKERMODE>
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x17CFF1C", Offset = "0x17CBF1C", VA = "0x17CFF1C")]
			public PropertySpeakerMode()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000022")]
		public class PropertyString : Property<string>
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x17CFF64", Offset = "0x17CBF64", VA = "0x17CFF64")]
			public PropertyString()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000023")]
		public class PropertyStringList : Property<List<string>>
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x17CFFAC", Offset = "0x17CBFAC", VA = "0x17CFFAC")]
			public PropertyStringList()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000024")]
		public class PropertyCallbackHandler : Property<PlatformCallbackHandler>
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x17CFFF4", Offset = "0x17CBFF4", VA = "0x17CFFF4")]
			public PropertyCallbackHandler()
			{
			}
		}

		[Token(Token = "0x2000025")]
		internal interface PropertyOverrideControl
		{
			[Token(Token = "0x60000B3")]
			bool HasValue(Platform platform);

			[Token(Token = "0x60000B4")]
			void Clear(Platform platform);
		}

		[Token(Token = "0x2000026")]
		internal struct PropertyAccessor<T> : PropertyOverrideControl
		{
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<PropertyStorage, Property<T>> Getter;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly T DefaultValue;

			[Token(Token = "0x60000B5")]
			public PropertyAccessor(Func<PropertyStorage, Property<T>> getter, T defaultValue)
			{
			}

			[Token(Token = "0x60000B6")]
			public bool HasValue(Platform platform)
			{
				return default(bool);
			}

			[Token(Token = "0x60000B7")]
			public T Get(Platform platform)
			{
				return (T)null;
			}

			[Token(Token = "0x60000B8")]
			public void Set(Platform platform, T value)
			{
			}

			[Token(Token = "0x60000B9")]
			public void Clear(Platform platform)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000027")]
		public class PropertyStorage
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PropertyBool LiveUpdate;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropertyInt LiveUpdatePort;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyBool Overlay;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropertyScreenPosition OverlayPosition;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PropertyInt OverlayFontSize;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PropertyBool Logging;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PropertyInt SampleRate;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public PropertyString BuildDirectory;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public PropertySpeakerMode SpeakerMode;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public PropertyInt VirtualChannelCount;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public PropertyInt RealChannelCount;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public PropertyInt DSPBufferLength;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public PropertyInt DSPBufferCount;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public PropertyStringList Plugins;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public PropertyStringList StaticPlugins;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public PropertyCallbackHandler CallbackHandler;

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x17CEBA4", Offset = "0x17CABA4", VA = "0x17CEBA4")]
			public PropertyStorage()
			{
			}
		}

		[Token(Token = "0x2000028")]
		internal static class PropertyAccessors
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PropertyAccessor<TriStateBool> LiveUpdate;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly PropertyAccessor<int> LiveUpdatePort;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly PropertyAccessor<TriStateBool> Overlay;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static readonly PropertyAccessor<ScreenPosition> OverlayPosition;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static readonly PropertyAccessor<int> OverlayFontSize;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly PropertyAccessor<TriStateBool> Logging;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static readonly PropertyAccessor<int> SampleRate;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static readonly PropertyAccessor<string> BuildDirectory;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static readonly PropertyAccessor<SPEAKERMODE> SpeakerMode;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static readonly PropertyAccessor<int> VirtualChannelCount;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static readonly PropertyAccessor<int> RealChannelCount;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static readonly PropertyAccessor<int> DSPBufferLength;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static readonly PropertyAccessor<int> DSPBufferCount;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static readonly PropertyAccessor<List<string>> Plugins;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static readonly PropertyAccessor<List<string>> StaticPlugins;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static readonly PropertyAccessor<PlatformCallbackHandler> CallbackHandler;
		}

		[Serializable]
		[Token(Token = "0x200002A")]
		public class PropertyThreadAffinityList : Property<List<ThreadAffinityGroup>>
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x17CFBB8", Offset = "0x17CBBB8", VA = "0x17CFBB8")]
			public PropertyThreadAffinityList()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002B")]
		internal class PropertyCodecChannels : Property<List<CodecChannelCount>>
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x17CFC00", Offset = "0x17CBC00", VA = "0x17CFC00")]
			public PropertyCodecChannels()
			{
			}
		}

		[Token(Token = "0x4000044")]
		internal const float DefaultPriority = 0f;

		[Token(Token = "0x4000045")]
		internal const string RegisterStaticPluginsClassName = "StaticPluginManager";

		[Token(Token = "0x4000046")]
		internal const string RegisterStaticPluginsFunctionName = "Register";

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string identifier;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string parentIdentifier;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool active;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected PropertyStorage Properties;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("outputType")]
		[SerializeField]
		internal string OutputTypeName;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadAffinityGroup> StaticThreadAffinities;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PropertyThreadAffinityList threadAffinities;

		[NonSerialized]
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Platform Parent;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<CodecChannelCount> staticCodecChannels;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PropertyCodecChannels codecChannels;

		[Token(Token = "0x17000014")]
		internal string Identifier
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x17CE088", Offset = "0x17CA088", VA = "0x17CE088")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x17CE090", Offset = "0x17CA090", VA = "0x17CE090")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		internal abstract string DisplayName
		{
			[Token(Token = "0x6000079")]
			get;
		}

		[Token(Token = "0x17000016")]
		internal virtual float Priority
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x17CE098", Offset = "0x17CA098", VA = "0x17CE098", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		internal virtual bool MatchesCurrentEnvironment
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x17CE0A0", Offset = "0x17CA0A0", VA = "0x17CE0A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		internal virtual bool IsIntrinsic
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x17CE0A8", Offset = "0x17CA0A8", VA = "0x17CE0A8", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		internal string ParentIdentifier
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x17CEEE4", Offset = "0x17CAEE4", VA = "0x17CEEE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x17CEEEC", Offset = "0x17CAEEC", VA = "0x17CEEEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		internal bool IsLiveUpdateEnabled
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x17CEEF4", Offset = "0x17CAEF4", VA = "0x17CEEF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		internal bool IsOverlayEnabled
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x17CEF98", Offset = "0x17CAF98", VA = "0x17CEF98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		internal bool Active
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x17CF03C", Offset = "0x17CB03C", VA = "0x17CF03C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		internal bool HasAnyOverriddenProperties
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x17CF044", Offset = "0x17CB044", VA = "0x17CF044")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public TriStateBool LiveUpdate
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x17CEF0C", Offset = "0x17CAF0C", VA = "0x17CEF0C")]
			get
			{
				return default(TriStateBool);
			}
		}

		[Token(Token = "0x1700001F")]
		public int LiveUpdatePort
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x17CF160", Offset = "0x17CB160", VA = "0x17CF160")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		public TriStateBool Overlay
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x17CEFB0", Offset = "0x17CAFB0", VA = "0x17CEFB0")]
			get
			{
				return default(TriStateBool);
			}
		}

		[Token(Token = "0x17000021")]
		public ScreenPosition OverlayRect
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x17CF1EC", Offset = "0x17CB1EC", VA = "0x17CF1EC")]
			get
			{
				return default(ScreenPosition);
			}
		}

		[Token(Token = "0x17000022")]
		public int OverlayFontSize
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x17CF278", Offset = "0x17CB278", VA = "0x17CF278")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public TriStateBool Logging
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x17CF3A0", Offset = "0x17CB3A0", VA = "0x17CF3A0")]
			get
			{
				return default(TriStateBool);
			}
		}

		[Token(Token = "0x17000024")]
		public int SampleRate
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x17CF42C", Offset = "0x17CB42C", VA = "0x17CF42C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public string BuildDirectory
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x17CF4B8", Offset = "0x17CB4B8", VA = "0x17CF4B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public SPEAKERMODE SpeakerMode
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x17CF544", Offset = "0x17CB544", VA = "0x17CF544")]
			get
			{
				return default(SPEAKERMODE);
			}
		}

		[Token(Token = "0x17000027")]
		public int VirtualChannelCount
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x17CF5D0", Offset = "0x17CB5D0", VA = "0x17CF5D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public int RealChannelCount
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x17CF65C", Offset = "0x17CB65C", VA = "0x17CF65C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public int DSPBufferLength
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x17CF6E8", Offset = "0x17CB6E8", VA = "0x17CF6E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002A")]
		public int DSPBufferCount
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x17CF774", Offset = "0x17CB774", VA = "0x17CF774")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public List<string> Plugins
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x17CE400", Offset = "0x17CA400", VA = "0x17CE400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public List<string> StaticPlugins
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x17CE9D4", Offset = "0x17CA9D4", VA = "0x17CE9D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public PlatformCallbackHandler CallbackHandler
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x17CF800", Offset = "0x17CB800", VA = "0x17CF800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		internal virtual List<ThreadAffinityGroup> DefaultThreadAffinities
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x17CFA98", Offset = "0x17CBA98", VA = "0x17CFA98", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IEnumerable<ThreadAffinityGroup> ThreadAffinities
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x17CFAF0", Offset = "0x17CBAF0", VA = "0x17CFAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		internal PropertyThreadAffinityList ThreadAffinitiesProperty
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x17CFB20", Offset = "0x17CBB20", VA = "0x17CFB20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		internal virtual List<CodecChannelCount> DefaultCodecChannels
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x17CFB28", Offset = "0x17CBB28", VA = "0x17CFB28", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		internal List<CodecChannelCount> CodecChannels
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x17CFB80", Offset = "0x17CBB80", VA = "0x17CFB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		internal PropertyCodecChannels CodecChannelsProperty
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x17CFBB0", Offset = "0x17CBBB0", VA = "0x17CFBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007A")]
		internal abstract void DeclareRuntimePlatforms(Settings settings);

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x17CE0B0", Offset = "0x17CA0B0", VA = "0x17CE0B0", Slot = "9")]
		internal virtual void PreSystemCreate(Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x17CE0B4", Offset = "0x17CA0B4", VA = "0x17CE0B4", Slot = "10")]
		internal virtual void PreInitialize(FMOD.Studio.System studioSystem)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x17CE0B8", Offset = "0x17CA0B8", VA = "0x17CE0B8", Slot = "11")]
		internal virtual string GetBankFolder()
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x17CE108", Offset = "0x17CA108", VA = "0x17CE108", Slot = "12")]
		protected virtual string GetPluginBasePath()
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x17CE180", Offset = "0x17CA180", VA = "0x17CE180", Slot = "13")]
		internal virtual string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x17CE1E0", Offset = "0x17CA1E0", VA = "0x17CE1E0", Slot = "14")]
		internal virtual void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x17CE228", Offset = "0x17CA228", VA = "0x17CE228", Slot = "15")]
		internal virtual void LoadDynamicPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x17CE61C", Offset = "0x17CA61C", VA = "0x17CE61C", Slot = "16")]
		internal virtual void LoadStaticPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x17CEB2C", Offset = "0x17CAB2C", VA = "0x17CEB2C")]
		internal void AffirmProperties()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x17CEDBC", Offset = "0x17CADBC", VA = "0x17CEDBC")]
		internal void ClearProperties()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x17CEE1C", Offset = "0x17CAE1C", VA = "0x17CEE1C", Slot = "17")]
		internal virtual void InitializeProperties()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x17CEE78", Offset = "0x17CAE78", VA = "0x17CEE78", Slot = "18")]
		internal virtual void EnsurePropertiesAreValid()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x17CF304", Offset = "0x17CB304", VA = "0x17CF304")]
		public void SetOverlayFontSize(int size)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x17CF88C", Offset = "0x17CB88C", VA = "0x17CF88C")]
		internal bool InheritsFrom(Platform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x17CF93C", Offset = "0x17CB93C", VA = "0x17CF93C")]
		internal OUTPUTTYPE GetOutputType()
		{
			return default(OUTPUTTYPE);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17CA54C", Offset = "0x17C654C", VA = "0x17CA54C")]
		protected Platform()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class PlatformDefault : Platform
	{
		[Token(Token = "0x4000076")]
		public const string ConstIdentifier = "default";

		[Token(Token = "0x17000034")]
		internal override string DisplayName
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x17D0A48", Offset = "0x17CCA48", VA = "0x17D0A48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		internal override bool IsIntrinsic
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x17D0A8C", Offset = "0x17CCA8C", VA = "0x17D0A8C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17D09D4", Offset = "0x17CC9D4", VA = "0x17D09D4")]
		public PlatformDefault()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17D0A88", Offset = "0x17CCA88", VA = "0x17D0A88", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x17D0A94", Offset = "0x17CCA94", VA = "0x17D0A94", Slot = "17")]
		internal override void InitializeProperties()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x17D0BB0", Offset = "0x17CCBB0", VA = "0x17D0BB0", Slot = "18")]
		internal override void EnsurePropertiesAreValid()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class PlatformGroup : Platform
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string displayName;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Legacy.Platform legacyIdentifier;

		[Token(Token = "0x17000036")]
		internal override string DisplayName
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x17D0C90", Offset = "0x17CCC90", VA = "0x17D0C90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x17D0C98", Offset = "0x17CCC98", VA = "0x17D0C98", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x17D0C9C", Offset = "0x17CCC9C", VA = "0x17D0C9C")]
		public PlatformGroup()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class PlatformMobileHigh : PlatformMobileLow
	{
		[Token(Token = "0x17000037")]
		internal override string DisplayName
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x17D0D6C", Offset = "0x17CCD6C", VA = "0x17D0D6C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		internal override float Priority
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x17D0DAC", Offset = "0x17CCDAC", VA = "0x17D0DAC", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000039")]
		internal override bool MatchesCurrentEnvironment
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x17D0DBC", Offset = "0x17CCDBC", VA = "0x17D0DBC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x17D0CF0", Offset = "0x17CCCF0", VA = "0x17D0CF0")]
		static PlatformMobileHigh()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x17D1010", Offset = "0x17CD010", VA = "0x17D1010")]
		public PlatformMobileHigh()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class PlatformMobileLow : Platform
	{
		[Token(Token = "0x1700003A")]
		internal override string DisplayName
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x17D1134", Offset = "0x17CD134", VA = "0x17D1134", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		internal override float Priority
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x17D0DB4", Offset = "0x17CCDB4", VA = "0x17D0DB4", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		internal override bool MatchesCurrentEnvironment
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x17D11B4", Offset = "0x17CD1B4", VA = "0x17D11B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x17D10B8", Offset = "0x17CD0B8", VA = "0x17D10B8")]
		static PlatformMobileLow()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17D1174", Offset = "0x17CD174", VA = "0x17D1174", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17D11BC", Offset = "0x17CD1BC", VA = "0x17D11BC", Slot = "11")]
		internal override string GetBankFolder()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x17D1208", Offset = "0x17CD208", VA = "0x17D1208", Slot = "13")]
		internal override string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17D1064", Offset = "0x17CD064", VA = "0x17D1064")]
		public PlatformMobileLow()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class PlatformPlayInEditor : Platform
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<CodecChannelCount> staticCodecChannels;

		[Token(Token = "0x1700003D")]
		internal override string DisplayName
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x17D12D0", Offset = "0x17CD2D0", VA = "0x17D12D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		internal override bool IsIntrinsic
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x17D1360", Offset = "0x17CD360", VA = "0x17D1360", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		internal override List<CodecChannelCount> DefaultCodecChannels
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x17D15AC", Offset = "0x17CD5AC", VA = "0x17D15AC", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x17D125C", Offset = "0x17CD25C", VA = "0x17D125C")]
		public PlatformPlayInEditor()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17D1310", Offset = "0x17CD310", VA = "0x17D1310", Slot = "5")]
		internal override void DeclareRuntimePlatforms(Settings settings)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x17D1368", Offset = "0x17CD368", VA = "0x17D1368", Slot = "11")]
		internal override string GetBankFolder()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x17D1464", Offset = "0x17CD464", VA = "0x17D1464", Slot = "16")]
		internal override void LoadStaticPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x17D1468", Offset = "0x17CD468", VA = "0x17D1468", Slot = "17")]
		internal override void InitializeProperties()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AddComponentMenu("")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		private struct LoadedBank
		{
			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x2000033")]
		private class GuidComparer : IEqualityComparer<GUID>
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x17D8BF4", Offset = "0x17D4BF4", VA = "0x17D8BF4", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<FMOD.GUID>.Equals(GUID x, GUID y)
			{
				return default(bool);
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x17D8C60", Offset = "0x17D4C60", VA = "0x17D8C60", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<FMOD.GUID>.GetHashCode(GUID obj)
			{
				return default(int);
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x17D8BEC", Offset = "0x17D4BEC", VA = "0x17D8BEC")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x2000034")]
		private class AttachedInstance
		{
			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastFramePosition;

			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool nonRigidbodyVelocity;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x17D50C8", Offset = "0x17D10C8", VA = "0x17D50C8")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <BanksToLoad>d__67 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Settings fmodSettings;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Settings <>3__fmodSettings;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string>.Enumerator <>7__wrap1;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <masterBankFileName>5__3;

			[Token(Token = "0x17000047")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x17D917C", Offset = "0x17D517C", VA = "0x17D917C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600014A")]
				[Address(RVA = "0x17D91BC", Offset = "0x17D51BC", VA = "0x17D91BC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x17D6940", Offset = "0x17D2940", VA = "0x17D6940")]
			[DebuggerHidden]
			public <BanksToLoad>d__67(int <>1__state)
			{
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x17D8CD0", Offset = "0x17D4CD0", VA = "0x17D8CD0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x17D8D24", Offset = "0x17D4D24", VA = "0x17D8D24", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x17D908C", Offset = "0x17D508C", VA = "0x17D908C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x17D90DC", Offset = "0x17D50DC", VA = "0x17D90DC")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0x17D912C", Offset = "0x17D512C", VA = "0x17D912C")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0x17D9184", Offset = "0x17D5184", VA = "0x17D9184", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x17D91C4", Offset = "0x17D51C4", VA = "0x17D91C4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x17D9260", Offset = "0x17D5260", VA = "0x17D9260", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <loadFromWeb>d__61 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000150")]
				[Address(RVA = "0x17D95A4", Offset = "0x17D55A4", VA = "0x17D95A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000152")]
				[Address(RVA = "0x17D95E4", Offset = "0x17D55E4", VA = "0x17D95E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x17D61DC", Offset = "0x17D21DC", VA = "0x17D61DC")]
			[DebuggerHidden]
			public <loadFromWeb>d__61(int <>1__state)
			{
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x17D9264", Offset = "0x17D5264", VA = "0x17D9264", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x17D9268", Offset = "0x17D5268", VA = "0x17D9268", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x17D95AC", Offset = "0x17D55AC", VA = "0x17D95AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400007A")]
		public const string BankStubPrefix = "bank stub:";

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Platform currentPlatform;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DEBUG_CALLBACK debugCallback;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FMOD.SYSTEM_CALLBACK errorCallback;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FMOD.System coreSystem;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DSP mixerHead;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isMuted;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<GUID, EventDescription> cachedDescriptions;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<string> sampleLoadRequests;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool listenerWarningIssued;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Rect windowRect;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string lastDebugText;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastDebugUpdate;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int loadingBanksRef;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static byte[] masterBusPrefix;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static byte[] eventSet3DAttributes;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static byte[] systemGetBus;

		[Token(Token = "0x17000040")]
		public static bool IsMuted
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x17D1D54", Offset = "0x17CDD54", VA = "0x17D1D54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x17D1DB0", Offset = "0x17CDDB0", VA = "0x17D1DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x17CD73C", Offset = "0x17C973C", VA = "0x17CD73C")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000043")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x17D3088", Offset = "0x17CF088", VA = "0x17D3088")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x17000044")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x17D8718", Offset = "0x17D4718", VA = "0x17D8718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public static bool HaveAllBanksLoaded
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x17D87E8", Offset = "0x17D47E8", VA = "0x17D87E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public static bool HaveMasterBanksLoaded
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x17D884C", Offset = "0x17D484C", VA = "0x17D884C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x17D1C38", Offset = "0x17CDC38", VA = "0x17D1C38")]
		static RuntimeManager()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x17D17A8", Offset = "0x17CD7A8", VA = "0x17D17A8")]
		[MonoPInvokeCallback(typeof(DEBUG_CALLBACK))]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, IntPtr filePtr, int line, IntPtr funcPtr, IntPtr messagePtr)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x17D18D4", Offset = "0x17CD8D4", VA = "0x17D18D4")]
		[MonoPInvokeCallback(typeof(FMOD.SYSTEM_CALLBACK))]
		private static RESULT ERROR_CALLBACK(IntPtr system, FMOD.SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x17D30E4", Offset = "0x17CF0E4", VA = "0x17D30E4")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17D3138", Offset = "0x17CF138", VA = "0x17D3138")]
		private void ReleaseStudioSystem()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x17D280C", Offset = "0x17CE80C", VA = "0x17D280C")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x17D3434", Offset = "0x17CF434", VA = "0x17D3434")]
		private int GetChannelCountForFormat(CodecType format)
		{
			return default(int);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x17D356C", Offset = "0x17CF56C", VA = "0x17D356C")]
		private static void SetThreadAffinities(Platform platform)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x17D423C", Offset = "0x17D023C", VA = "0x17D423C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x17D4EBC", Offset = "0x17D0EBC", VA = "0x17D4EBC")]
		private static AttachedInstance FindOrAddAttachedInstance(EventInstance instance, Transform transform, ATTRIBUTES_3D attributes)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x17CCFCC", Offset = "0x17C8FCC", VA = "0x17CCFCC")]
		public static void AttachInstanceToGameObject(EventInstance instance, GameObject gameObject, bool nonRigidbodyVelocity = false)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x17D50D0", Offset = "0x17D10D0", VA = "0x17D50D0")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, bool nonRigidbodyVelocity = false)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x17CCE74", Offset = "0x17C8E74", VA = "0x17CCE74")]
		public static void AttachInstanceToGameObject(EventInstance instance, GameObject gameObject, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x17D5180", Offset = "0x17D1180", VA = "0x17D5180")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17CCF20", Offset = "0x17C8F20", VA = "0x17CCF20")]
		public static void AttachInstanceToGameObject(EventInstance instance, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17D520C", Offset = "0x17D120C", VA = "0x17D520C")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x17D5298", Offset = "0x17D1298", VA = "0x17D5298")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x17CDEC4", Offset = "0x17C9EC4", VA = "0x17CDEC4")]
		internal void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x17D53E4", Offset = "0x17D13E4", VA = "0x17D53E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17D5410", Offset = "0x17D1410", VA = "0x17D5410")]
		private void UpdateDebugText()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x17D57F8", Offset = "0x17D17F8", VA = "0x17D57F8")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x17D5904", Offset = "0x17D1904", VA = "0x17D5904")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17D5984", Offset = "0x17D1984", VA = "0x17D5984")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x17D5AC0", Offset = "0x17D1AC0", VA = "0x17D5AC0")]
		private static void ReferenceLoadedBank(string bankName, bool loadSamples)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x17D5BB8", Offset = "0x17D1BB8", VA = "0x17D5BB8")]
		private void RegisterLoadedBank(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17D5E50", Offset = "0x17D1E50", VA = "0x17D5E50")]
		private void ExecuteSampleLoadRequestsIfReady()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17D6154", Offset = "0x17D2154", VA = "0x17D6154")]
		[IteratorStateMachine(typeof(<loadFromWeb>d__61))]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17D6204", Offset = "0x17D2204", VA = "0x17D6204")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x17D626C", Offset = "0x17D226C", VA = "0x17D626C")]
		private static void LoadBank(string bankName, bool loadSamples, string bankId)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x17D6604", Offset = "0x17D2604", VA = "0x17D6604")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x17D6680", Offset = "0x17D2680", VA = "0x17D6680")]
		private static void LoadBank(TextAsset asset, bool loadSamples, string bankId)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x17D3B58", Offset = "0x17CFB58", VA = "0x17D3B58")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x17D67B8", Offset = "0x17D27B8", VA = "0x17D67B8")]
		[IteratorStateMachine(typeof(<BanksToLoad>d__67))]
		private IEnumerable<string> BanksToLoad(Settings fmodSettings)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x17D6974", Offset = "0x17D2974", VA = "0x17D6974")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x17D6AE0", Offset = "0x17D2AE0", VA = "0x17D6AE0")]
		public static void UnloadBank(TextAsset asset)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x17D6B50", Offset = "0x17D2B50", VA = "0x17D6B50")]
		[Obsolete("[FMOD] Deprecated. Use AnySampleDataLoading instead.")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x17D6B9C", Offset = "0x17D2B9C", VA = "0x17D6B9C")]
		public static bool AnySampleDataLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x17D6D3C", Offset = "0x17D2D3C", VA = "0x17D6D3C")]
		[Obsolete("[FMOD] Deprecated. Use WaitForAllSampleLoading instead.")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x17D682C", Offset = "0x17D282C", VA = "0x17D682C")]
		public static void WaitForAllSampleLoading()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x17D6D88", Offset = "0x17D2D88", VA = "0x17D6D88")]
		public static GUID PathToGUID(string path)
		{
			return default(GUID);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x17D6F40", Offset = "0x17D2F40", VA = "0x17D6F40")]
		public static EventReference PathToEventReference(string path)
		{
			return default(EventReference);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x17CCD64", Offset = "0x17C8D64", VA = "0x17CCD64")]
		public static EventInstance CreateInstance(EventReference eventReference)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x17D7150", Offset = "0x17D3150", VA = "0x17D7150")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x17D7014", Offset = "0x17D3014", VA = "0x17D7014")]
		public static EventInstance CreateInstance(GUID guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x17D7450", Offset = "0x17D3450", VA = "0x17D7450")]
		public static void PlayOneShot(EventReference eventReference, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x17D7664", Offset = "0x17D3664", VA = "0x17D7664")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x17D7598", Offset = "0x17D3598", VA = "0x17D7598")]
		public static void PlayOneShot(GUID guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x17D7788", Offset = "0x17D3788", VA = "0x17D7788")]
		public static void PlayOneShotAttached(EventReference eventReference, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x17D7974", Offset = "0x17D3974", VA = "0x17D7974")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x17D78A8", Offset = "0x17D38A8", VA = "0x17D78A8")]
		public static void PlayOneShotAttached(GUID guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x17CC2CC", Offset = "0x17C82CC", VA = "0x17CC2CC")]
		public static EventDescription GetEventDescription(EventReference eventReference)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x17D7A7C", Offset = "0x17D3A7C", VA = "0x17D7A7C")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x17D7254", Offset = "0x17D3254", VA = "0x17D7254")]
		public static EventDescription GetEventDescription(GUID guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x17D7C44", Offset = "0x17D3C44", VA = "0x17D7C44")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody rigidBody, [Optional] GameObject attenuationObject)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x17D7CB4", Offset = "0x17D3CB4", VA = "0x17D7CB4")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody rigidBody, [Optional] GameObject attenuationObject)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x17D7E18", Offset = "0x17D3E18", VA = "0x17D7E18")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D, [Optional] GameObject attenuationObject)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17D7E88", Offset = "0x17D3E88", VA = "0x17D7E88")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D, [Optional] GameObject attenuationObject)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x17D7FE8", Offset = "0x17D3FE8", VA = "0x17D7FE8")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] GameObject attenuationObject, [Optional] Vector3 velocity)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17D8168", Offset = "0x17D4168", VA = "0x17D8168")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] GameObject attenuationObject)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x17D81D0", Offset = "0x17D41D0", VA = "0x17D81D0")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] GameObject attenuationObject)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x17D831C", Offset = "0x17D431C", VA = "0x17D831C")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x17D848C", Offset = "0x17D448C", VA = "0x17D848C")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x17D5A10", Offset = "0x17D1A10", VA = "0x17D5A10")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x17D85FC", Offset = "0x17D45FC", VA = "0x17D85FC")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x17D8660", Offset = "0x17D4660", VA = "0x17D8660")]
		private static void ApplyMuteState()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x17D89DC", Offset = "0x17D49DC", VA = "0x17D89DC")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x17D3F2C", Offset = "0x17CFF2C", VA = "0x17D3F2C")]
		private void SetOverlayPosition()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x17D8A5C", Offset = "0x17D4A5C", VA = "0x17D8A5C")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public GUID Guid;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string Path;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x17D6E84", Offset = "0x17D2E84", VA = "0x17D6E84")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x17D7B80", Offset = "0x17D3B80", VA = "0x17D7B80")]
		public EventNotFoundException(GUID guid)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x17D709C", Offset = "0x17D309C", VA = "0x17D709C")]
		public EventNotFoundException(EventReference eventReference)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Path;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x17D83D0", Offset = "0x17D43D0", VA = "0x17D83D0")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Path;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x17D8540", Offset = "0x17D4540", VA = "0x17D8540")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Path;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public RESULT Result;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x17D5D50", Offset = "0x17D1D50", VA = "0x17D5D50")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x17D95EC", Offset = "0x17D55EC", VA = "0x17D95EC")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public RESULT Result;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x17D3174", Offset = "0x17CF174", VA = "0x17D3174")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x17D3008", Offset = "0x17CF008", VA = "0x17D3008")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x40000B3")]
		None,
		[Token(Token = "0x40000B4")]
		ObjectStart,
		[Token(Token = "0x40000B5")]
		ObjectDestroy,
		[Token(Token = "0x40000B6")]
		TriggerEnter,
		[Token(Token = "0x40000B7")]
		TriggerExit,
		[Token(Token = "0x40000B8")]
		TriggerEnter2D,
		[Token(Token = "0x40000B9")]
		TriggerExit2D,
		[Token(Token = "0x40000BA")]
		CollisionEnter,
		[Token(Token = "0x40000BB")]
		CollisionExit,
		[Token(Token = "0x40000BC")]
		CollisionEnter2D,
		[Token(Token = "0x40000BD")]
		CollisionExit2D,
		[Token(Token = "0x40000BE")]
		ObjectEnable,
		[Token(Token = "0x40000BF")]
		ObjectDisable,
		[Token(Token = "0x40000C0")]
		ObjectMouseEnter,
		[Token(Token = "0x40000C1")]
		ObjectMouseExit,
		[Token(Token = "0x40000C2")]
		ObjectMouseDown,
		[Token(Token = "0x40000C3")]
		ObjectMouseUp,
		[Token(Token = "0x40000C4")]
		UIMouseEnter,
		[Token(Token = "0x40000C5")]
		UIMouseExit,
		[Token(Token = "0x40000C6")]
		UIMouseDown,
		[Token(Token = "0x40000C7")]
		UIMouseUp
	}
	[Token(Token = "0x200003F")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x40000C9")]
		None,
		[Token(Token = "0x40000CA")]
		ObjectStart,
		[Token(Token = "0x40000CB")]
		ObjectDestroy,
		[Token(Token = "0x40000CC")]
		TriggerEnter,
		[Token(Token = "0x40000CD")]
		TriggerExit,
		[Token(Token = "0x40000CE")]
		TriggerEnter2D,
		[Token(Token = "0x40000CF")]
		TriggerExit2D,
		[Token(Token = "0x40000D0")]
		ObjectEnable,
		[Token(Token = "0x40000D1")]
		ObjectDisable
	}
	[Token(Token = "0x2000040")]
	public enum ThreadType
	{
		[Token(Token = "0x40000D3")]
		Mixer,
		[Token(Token = "0x40000D4")]
		Feeder,
		[Token(Token = "0x40000D5")]
		Stream,
		[Token(Token = "0x40000D6")]
		File,
		[Token(Token = "0x40000D7")]
		Nonblocking,
		[Token(Token = "0x40000D8")]
		Record,
		[Token(Token = "0x40000D9")]
		Geometry,
		[Token(Token = "0x40000DA")]
		Profiler,
		[Token(Token = "0x40000DB")]
		Studio_Update,
		[Token(Token = "0x40000DC")]
		Studio_Load_Bank,
		[Token(Token = "0x40000DD")]
		Studio_Load_Sample,
		[Token(Token = "0x40000DE")]
		Convolution_1,
		[Token(Token = "0x40000DF")]
		Convolution_2
	}
	[Token(Token = "0x2000041")]
	[Flags]
	public enum ThreadAffinity : uint
	{
		[Token(Token = "0x40000E1")]
		Any = 0u,
		[Token(Token = "0x40000E2")]
		Core0 = 1u,
		[Token(Token = "0x40000E3")]
		Core1 = 2u,
		[Token(Token = "0x40000E4")]
		Core2 = 4u,
		[Token(Token = "0x40000E5")]
		Core3 = 8u,
		[Token(Token = "0x40000E6")]
		Core4 = 0x10u,
		[Token(Token = "0x40000E7")]
		Core5 = 0x20u,
		[Token(Token = "0x40000E8")]
		Core6 = 0x40u,
		[Token(Token = "0x40000E9")]
		Core7 = 0x80u,
		[Token(Token = "0x40000EA")]
		Core8 = 0x100u,
		[Token(Token = "0x40000EB")]
		Core9 = 0x200u,
		[Token(Token = "0x40000EC")]
		Core10 = 0x400u,
		[Token(Token = "0x40000ED")]
		Core11 = 0x800u,
		[Token(Token = "0x40000EE")]
		Core12 = 0x1000u,
		[Token(Token = "0x40000EF")]
		Core13 = 0x2000u,
		[Token(Token = "0x40000F0")]
		Core14 = 0x4000u,
		[Token(Token = "0x40000F1")]
		Core15 = 0x8000u
	}
	[Token(Token = "0x2000042")]
	public enum CodecType
	{
		[Token(Token = "0x40000F3")]
		FADPCM,
		[Token(Token = "0x40000F4")]
		Vorbis,
		[Token(Token = "0x40000F5")]
		AT9,
		[Token(Token = "0x40000F6")]
		XMA,
		[Token(Token = "0x40000F7")]
		Opus
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class ThreadAffinityGroup
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ThreadType> threads;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ThreadAffinity affinity;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x17D96A0", Offset = "0x17D56A0", VA = "0x17D96A0")]
		public ThreadAffinityGroup()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x17D971C", Offset = "0x17D571C", VA = "0x17D971C")]
		public ThreadAffinityGroup(ThreadAffinityGroup other)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x17D97E4", Offset = "0x17D57E4", VA = "0x17D97E4")]
		public ThreadAffinityGroup(ThreadAffinity affinity, params ThreadType[] threads)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class CodecChannelCount
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CodecType format;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int channels;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x17CAB5C", Offset = "0x17C6B5C", VA = "0x17CAB5C")]
		public CodecChannelCount()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x17D98A8", Offset = "0x17D58A8", VA = "0x17D98A8")]
		public CodecChannelCount(CodecChannelCount other)
		{
		}
	}
	[Token(Token = "0x2000045")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x17D1424", Offset = "0x17CD424", VA = "0x17D1424")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x17D7E14", Offset = "0x17D3E14", VA = "0x17D7E14")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x17CD0A0", Offset = "0x17C90A0", VA = "0x17CD0A0")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x17D4D88", Offset = "0x17D0D88", VA = "0x17D4D88")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x17D4E18", Offset = "0x17D0E18", VA = "0x17D4E18")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform, Vector3 velocity)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x17D98DC", Offset = "0x17D58DC", VA = "0x17D98DC")]
		public static ATTRIBUTES_3D To3DAttributes(this GameObject go)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x17D4B74", Offset = "0x17D0B74", VA = "0x17D4B74")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x17D9900", Offset = "0x17D5900", VA = "0x17D9900")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x17D4C78", Offset = "0x17D0C78", VA = "0x17D4C78")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x17D9A10", Offset = "0x17D5A10", VA = "0x17D9A10")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x17D417C", Offset = "0x17D017C", VA = "0x17D417C")]
		public static THREAD_TYPE ToFMODThreadType(ThreadType threadType)
		{
			return default(THREAD_TYPE);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x17D9B2C", Offset = "0x17D5B2C", VA = "0x17D9B2C")]
		public static string DisplayName(this ThreadType thread)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x17D4230", Offset = "0x17D0230", VA = "0x17D4230")]
		public static THREAD_AFFINITY ToFMODThreadAffinity(ThreadAffinity affinity)
		{
			return default(THREAD_AFFINITY);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x17D9BA8", Offset = "0x17D5BA8", VA = "0x17D9BA8")]
		private static void SetFMODAffinityBit(ThreadAffinity affinity, ThreadAffinity mask, THREAD_AFFINITY fmodMask, ref THREAD_AFFINITY fmodAffinity)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x17D27A0", Offset = "0x17CE7A0", VA = "0x17D27A0")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x17D26E8", Offset = "0x17CE6E8", VA = "0x17D26E8")]
		public static void DebugLog(string message)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x17D94D8", Offset = "0x17D54D8", VA = "0x17D94D8")]
		public static void DebugLogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x17D2630", Offset = "0x17CE630", VA = "0x17D2630")]
		public static void DebugLogWarning(string message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x17CEA60", Offset = "0x17CAA60", VA = "0x17CEA60")]
		public static void DebugLogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x17D257C", Offset = "0x17CE57C", VA = "0x17D257C")]
		public static void DebugLogError(string message)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x17D3A90", Offset = "0x17CFA90", VA = "0x17D3A90")]
		public static void DebugLogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x17D688C", Offset = "0x17D288C", VA = "0x17D688C")]
		public static void DebugLogException(Exception e)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x17D9C80", Offset = "0x17D5C80", VA = "0x17D9C80")]
		public static string GetPluginArchitectureFolder()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public enum ImportType
	{
		[Token(Token = "0x40000FD")]
		StreamingAssets,
		[Token(Token = "0x40000FE")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public enum BankLoadType
	{
		[Token(Token = "0x4000100")]
		All,
		[Token(Token = "0x4000101")]
		Specified,
		[Token(Token = "0x4000102")]
		None
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public enum MeterChannelOrderingType
	{
		[Token(Token = "0x4000104")]
		Standard,
		[Token(Token = "0x4000105")]
		SeparateLFE,
		[Token(Token = "0x4000106")]
		Positional
	}
	[Token(Token = "0x2000049")]
	public enum EventLinkage
	{
		[Token(Token = "0x4000108")]
		Path,
		[Token(Token = "0x4000109")]
		GUID
	}
	[Token(Token = "0x200004A")]
	public enum TriStateBool
	{
		[Token(Token = "0x400010B")]
		Disabled,
		[Token(Token = "0x400010C")]
		Enabled,
		[Token(Token = "0x400010D")]
		Development
	}
	[Token(Token = "0x200004B")]
	public enum ScreenPosition
	{
		[Token(Token = "0x400010F")]
		TopLeft,
		[Token(Token = "0x4000110")]
		TopCenter,
		[Token(Token = "0x4000111")]
		TopRight,
		[Token(Token = "0x4000112")]
		BottomLeft,
		[Token(Token = "0x4000113")]
		BottomCenter,
		[Token(Token = "0x4000114")]
		BottomRight,
		[Token(Token = "0x4000115")]
		Center,
		[Token(Token = "0x4000116")]
		VR
	}
	[Token(Token = "0x200004C")]
	public interface IEditorSettings
	{
	}
	[Token(Token = "0x200004D")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x200004E")]
		internal enum SharedLibraryUpdateStages
		{
			[Token(Token = "0x400014C")]
			Start,
			[Token(Token = "0x400014D")]
			DisableExistingLibraries,
			[Token(Token = "0x400014E")]
			RestartUnity,
			[Token(Token = "0x400014F")]
			CopyNewLibraries
		}

		[Token(Token = "0x200004F")]
		internal struct PlatformTemplate
		{
			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Identifier;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Func<Platform> CreateInstance;
		}

		[Token(Token = "0x4000117")]
		internal const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IEditorSettings editorSettings;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool isInitializing;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("SourceBankPathUnformatted")]
		private string sourceBankPathUnformatted;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public int BankRefreshCooldown;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public bool ShowBankRefreshWindow;

		[Token(Token = "0x4000122")]
		internal const int BankRefreshPrompt = -1;

		[Token(Token = "0x4000123")]
		internal const int BankRefreshManual = -2;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public string TargetBankFolder;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public EventLinkage EventLinkage;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal List<Legacy.PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		internal List<Legacy.PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		internal List<Legacy.PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		internal List<Legacy.PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		internal List<Legacy.PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		internal List<Legacy.PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		internal List<Legacy.PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		internal List<string> Plugins;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		[SerializeField]
		public bool EnableMemoryTracking;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
		[SerializeField]
		public bool AndroidUseOBB;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		public bool AndroidPatchBuild;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		public MeterChannelOrderingType MeterChannelOrdering;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		public bool StopEventsOutsideMaxDistance;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		[SerializeField]
		internal bool BoltUnitOptionsBuildPending;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		[SerializeField]
		public bool EnableErrorCallback;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		internal SharedLibraryUpdateStages SharedLibraryUpdateStage;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		internal double SharedLibraryTimeSinceStart;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		internal int CurrentVersion;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		public bool HideSetupWizard;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		internal int LastEventReferenceScanVersion;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		public List<Platform> Platforms;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal Dictionary<RuntimePlatform, List<Platform>> PlatformForRuntimePlatform;

		[NonSerialized]
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Platform DefaultPlatform;

		[NonSerialized]
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Platform PlayInEditorPlatform;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static List<PlatformTemplate> PlatformTemplates;

		[NonSerialized]
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool hasLoaded;

		[Token(Token = "0x1700004B")]
		public static Settings Instance
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x17CA3D8", Offset = "0x17C63D8", VA = "0x17CA3D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		internal static IEditorSettings EditorSettings
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x17D9FC0", Offset = "0x17D5FC0", VA = "0x17D9FC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x17DA018", Offset = "0x17D6018", VA = "0x17DA018")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public string SourceProjectPath
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x17DA074", Offset = "0x17D6074", VA = "0x17DA074")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x17DA07C", Offset = "0x17D607C", VA = "0x17DA07C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public string SourceBankPath
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x17DA084", Offset = "0x17D6084", VA = "0x17DA084")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x17DA08C", Offset = "0x17D608C", VA = "0x17DA08C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		internal string TargetPath
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x17DA094", Offset = "0x17D6094", VA = "0x17DA094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public string TargetSubFolder
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x17D65E8", Offset = "0x17D25E8", VA = "0x17D65E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x17DA198", Offset = "0x17D6198", VA = "0x17DA198")]
			set
			{
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x17D9DAC", Offset = "0x17D5DAC", VA = "0x17D9DAC")]
		internal static void Initialize()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x17D9BC0", Offset = "0x17D5BC0", VA = "0x17D9BC0")]
		internal static bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x17DA1B4", Offset = "0x17D61B4", VA = "0x17DA1B4")]
		internal Platform FindPlatform(string identifier)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x17DA30C", Offset = "0x17D630C", VA = "0x17DA30C")]
		internal bool PlatformExists(string identifier)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x17DA388", Offset = "0x17D6388", VA = "0x17DA388")]
		internal void AddPlatform(Platform platform)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x17DA4A0", Offset = "0x17D64A0", VA = "0x17DA4A0")]
		internal void RemovePlatform(string identifier)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x17DA580", Offset = "0x17D6580", VA = "0x17DA580")]
		internal void LinkPlatform(Platform platform)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x17CA0AC", Offset = "0x17C60AC", VA = "0x17CA0AC")]
		internal void DeclareRuntimePlatform(RuntimePlatform runtimePlatform, Platform platform)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x17DA5B8", Offset = "0x17D65B8", VA = "0x17DA5B8")]
		private void LinkPlatformToParent(Platform platform)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x17D3274", Offset = "0x17CF274", VA = "0x17D3274")]
		internal Platform FindCurrentPlatform()
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x17DA610", Offset = "0x17D6610", VA = "0x17DA610")]
		private Settings()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x17DA8FC", Offset = "0x17D68FC", VA = "0x17DA8FC")]
		internal void AddPlatformProperties(Platform platform)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x17DA5FC", Offset = "0x17D65FC", VA = "0x17DA5FC")]
		public void SetPlatformParent(Platform platform, Platform newParent)
		{
		}

		[Token(Token = "0x600018F")]
		internal static void AddPlatformTemplate<T>(string identifier) where T : Platform
		{
		}

		[Token(Token = "0x6000190")]
		private static Platform CreatePlatformInstance<T>(string identifier) where T : Platform
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x17DA930", Offset = "0x17D6930", VA = "0x17DA930")]
		internal void OnEnable()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x17DAB6C", Offset = "0x17D6B6C", VA = "0x17DAB6C")]
		private void PopulatePlatformsFromAsset()
		{
		}
	}
	[Token(Token = "0x2000053")]
	internal static class Legacy
	{
		[Serializable]
		[Token(Token = "0x2000054")]
		public enum Platform
		{
			[Token(Token = "0x4000159")]
			None,
			[Token(Token = "0x400015A")]
			PlayInEditor,
			[Token(Token = "0x400015B")]
			Default,
			[Token(Token = "0x400015C")]
			Desktop,
			[Token(Token = "0x400015D")]
			Mobile,
			[Token(Token = "0x400015E")]
			MobileHigh,
			[Token(Token = "0x400015F")]
			MobileLow,
			[Token(Token = "0x4000160")]
			Console,
			[Token(Token = "0x4000161")]
			Windows,
			[Token(Token = "0x4000162")]
			Mac,
			[Token(Token = "0x4000163")]
			Linux,
			[Token(Token = "0x4000164")]
			iOS,
			[Token(Token = "0x4000165")]
			Android,
			[Token(Token = "0x4000166")]
			Deprecated_1,
			[Token(Token = "0x4000167")]
			XboxOne,
			[Token(Token = "0x4000168")]
			PS4,
			[Token(Token = "0x4000169")]
			Deprecated_2,
			[Token(Token = "0x400016A")]
			Deprecated_3,
			[Token(Token = "0x400016B")]
			AppleTV,
			[Token(Token = "0x400016C")]
			UWP,
			[Token(Token = "0x400016D")]
			Switch,
			[Token(Token = "0x400016E")]
			WebGL,
			[Token(Token = "0x400016F")]
			Deprecated_4,
			[Token(Token = "0x4000170")]
			Reserved_1,
			[Token(Token = "0x4000171")]
			Reserved_2,
			[Token(Token = "0x4000172")]
			Reserved_3,
			[Token(Token = "0x4000173")]
			Count
		}

		[Token(Token = "0x2000055")]
		public class PlatformSettingBase
		{
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Platform Platform;

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x17DB2F0", Offset = "0x17D72F0", VA = "0x17DB2F0")]
			public PlatformSettingBase()
			{
			}
		}

		[Token(Token = "0x2000056")]
		public class PlatformSetting<T> : PlatformSettingBase
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T Value;

			[Token(Token = "0x60001A5")]
			public PlatformSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		public class PlatformIntSetting : PlatformSetting<int>
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x17DB2F8", Offset = "0x17D72F8", VA = "0x17DB2F8")]
			public PlatformIntSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000058")]
		public class PlatformStringSetting : PlatformSetting<string>
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x17DB340", Offset = "0x17D7340", VA = "0x17DB340")]
			public PlatformStringSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000059")]
		public class PlatformBoolSetting : PlatformSetting<TriStateBool>
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x17DB388", Offset = "0x17D7388", VA = "0x17DB388")]
			public PlatformBoolSetting()
			{
			}
		}

		[Token(Token = "0x600019D")]
		public static void CopySetting<T, U>(List<T> list, Platform fromPlatform, Platform toPlatform) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x17DB0B8", Offset = "0x17D70B8", VA = "0x17DB0B8")]
		public static void CopySetting(List<PlatformBoolSetting> list, Platform fromPlatform, Platform toPlatform)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x17DB118", Offset = "0x17D7118", VA = "0x17DB118")]
		public static void CopySetting(List<PlatformIntSetting> list, Platform fromPlatform, Platform toPlatform)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x17DB178", Offset = "0x17D7178", VA = "0x17DB178")]
		public static string DisplayName(Platform platform)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x17DB298", Offset = "0x17D7298", VA = "0x17DB298")]
		public static float SortOrder(Platform legacyPlatform)
		{
			return default(float);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x17DB2B8", Offset = "0x17D72B8", VA = "0x17DB2B8")]
		public static Platform Parent(Platform platform)
		{
			return default(Platform);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x17DB2DC", Offset = "0x17D72DC", VA = "0x17DB2DC")]
		public static bool IsGroup(Platform platform)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005B")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Bank Loader")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string CollisionTag;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool PreloadSamples;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool isQuitting;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x17DB3D0", Offset = "0x17D73D0", VA = "0x17DB3D0")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x17DB7A8", Offset = "0x17D77A8", VA = "0x17DB7A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x17DB7C4", Offset = "0x17D77C4", VA = "0x17DB7C4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x17DB7D0", Offset = "0x17D77D0", VA = "0x17DB7D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x17DB7E4", Offset = "0x17D77E4", VA = "0x17DB7E4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x17DB840", Offset = "0x17D7840", VA = "0x17DB840")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x17DB89C", Offset = "0x17D789C", VA = "0x17DB89C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x17DB8F8", Offset = "0x17D78F8", VA = "0x17DB8F8")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x17DB954", Offset = "0x17D7954", VA = "0x17DB954")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x17DB95C", Offset = "0x17D795C", VA = "0x17DB95C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x17DB41C", Offset = "0x17D741C", VA = "0x17DB41C")]
		public void Load()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x17DB658", Offset = "0x17D7658", VA = "0x17DB658")]
		public void Unload()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x17DB964", Offset = "0x17D7964", VA = "0x17DB964")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Event Emitter")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventReference EventReference;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Obsolete("Use the EventReference field instead.")]
		public string Event;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("PlayEvent")]
		public EmitterGameEvent EventPlayTrigger;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("StopEvent")]
		public EmitterGameEvent EventStopTrigger;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool AllowFadeout;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool TriggerOnce;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool Preload;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[FormerlySerializedAs("AllowNonRigidbodyDoppler")]
		public bool NonRigidbodyVelocity;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ParamRef[] Params;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool OverrideAttenuation;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float OverrideMinDistance;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float OverrideMaxDistance;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected EventDescription eventDescription;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected EventInstance instance;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool hasTriggered;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool isQuitting;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private bool isOneshot;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<ParamRef> cachedParams;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<StudioEventEmitter> activeEmitters;

		[Token(Token = "0x4000191")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000051")]
		public EmitterGameEvent PlayEvent
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x17DB96C", Offset = "0x17D796C", VA = "0x17DB96C")]
			get
			{
				return default(EmitterGameEvent);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x17DB974", Offset = "0x17D7974", VA = "0x17DB974")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public EmitterGameEvent StopEvent
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x17DB97C", Offset = "0x17D797C", VA = "0x17DB97C")]
			get
			{
				return default(EmitterGameEvent);
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x17DB984", Offset = "0x17D7984", VA = "0x17DB984")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x17DB98C", Offset = "0x17D798C", VA = "0x17DB98C")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000054")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x17DB994", Offset = "0x17D7994", VA = "0x17DB994")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x17000055")]
		public bool IsActive
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x17DB99C", Offset = "0x17D799C", VA = "0x17DB99C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x17DB9A4", Offset = "0x17D79A4", VA = "0x17DB9A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		private float MaxDistance
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x17DB9AC", Offset = "0x17D79AC", VA = "0x17DB9AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x17D4A1C", Offset = "0x17D0A1C", VA = "0x17D4A1C")]
		public static void UpdateActiveEmitters()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x17DBC28", Offset = "0x17D7C28", VA = "0x17DBC28")]
		private static void RegisterActiveEmitter(StudioEventEmitter emitter)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x17DBD38", Offset = "0x17D7D38", VA = "0x17DBD38")]
		private static void DeregisterActiveEmitter(StudioEventEmitter emitter)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x17DBB1C", Offset = "0x17D7B1C", VA = "0x17DBB1C")]
		private void UpdatePlayingStatus(bool force = false)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x17DC578", Offset = "0x17D8578", VA = "0x17DC578", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x17DC720", Offset = "0x17D8720", VA = "0x17DC720")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x17DC72C", Offset = "0x17D872C", VA = "0x17DC72C", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x17DC830", Offset = "0x17D8830", VA = "0x17DC830", Slot = "10")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x17DBA0C", Offset = "0x17D7A0C", VA = "0x17DBA0C")]
		private void Lookup()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x17DC87C", Offset = "0x17D887C", VA = "0x17DC87C")]
		public void Play()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x17DBFF0", Offset = "0x17D7FF0", VA = "0x17DBFF0")]
		private void PlayInstance()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x17DC9FC", Offset = "0x17D89FC", VA = "0x17DC9FC")]
		public void Stop()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x17DC4C4", Offset = "0x17D84C4", VA = "0x17DC4C4")]
		private void StopInstance()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x17DCA98", Offset = "0x17D8A98", VA = "0x17DCA98")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x17DCCE0", Offset = "0x17D8CE0", VA = "0x17DCCE0")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x17DBFA0", Offset = "0x17D7FA0", VA = "0x17DBFA0")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x17DCF28", Offset = "0x17D8F28", VA = "0x17DCF28")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Global Parameter Trigger")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("parameter")]
		[ParamRef]
		public string Parameter;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("value")]
		public float Value;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000057")]
		public PARAMETER_DESCRIPTION ParameterDescription
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x17DD134", Offset = "0x17D9134", VA = "0x17DD134")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x17DD154", Offset = "0x17D9154", VA = "0x17DD154", Slot = "10")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x17DD168", Offset = "0x17D9168", VA = "0x17DD168")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x17DD2E0", Offset = "0x17D92E0", VA = "0x17DD2E0")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Listener")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool nonRigidbodyVelocity;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject attenuationObject;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 lastFramePosition;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody rigidBody;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<StudioListener> listeners;

		[Token(Token = "0x17000058")]
		public static int ListenerCount
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x17D49AC", Offset = "0x17D09AC", VA = "0x17D49AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public int ListenerNumber
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x17DD2E4", Offset = "0x17D92E4", VA = "0x17DD2E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x17DD364", Offset = "0x17D9364", VA = "0x17DD364")]
		public static float DistanceToNearestListener(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x17DBDB8", Offset = "0x17D7DB8", VA = "0x17DBDB8")]
		public static float DistanceSquaredToNearestListener(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x17DD5B0", Offset = "0x17D95B0", VA = "0x17DD5B0")]
		private static void AddListener(StudioListener listener)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x17DD868", Offset = "0x17D9868", VA = "0x17DD868")]
		private static void RemoveListener(StudioListener listener)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x17DD960", Offset = "0x17D9960", VA = "0x17DD960")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x17DDB88", Offset = "0x17D9B88", VA = "0x17DDB88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x17DDBDC", Offset = "0x17D9BDC", VA = "0x17DDBDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x17DDF78", Offset = "0x17D9F78", VA = "0x17DDF78")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class EmitterRef
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x17DE064", Offset = "0x17DA064", VA = "0x17DE064")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Parameter Trigger")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x17DE06C", Offset = "0x17DA06C", VA = "0x17DE06C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x17DE25C", Offset = "0x17DA25C", VA = "0x17DE25C", Slot = "10")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x17DE270", Offset = "0x17DA270", VA = "0x17DE270")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x17DE3D4", Offset = "0x17DA3D4", VA = "0x17DE3D4")]
		public StudioParameterTrigger()
		{
		}
	}
}
namespace FMOD
{
	[Token(Token = "0x2000063")]
	public class VERSION
	{
		[Token(Token = "0x40001A3")]
		public const string dll = "fmod";

		[Token(Token = "0x40001A4")]
		public const int number = 131634;

		[Token(Token = "0x40001A5")]
		public const string dllSuffix = "";

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x17DE3D8", Offset = "0x17DA3D8", VA = "0x17DE3D8")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class CONSTANTS
	{
		[Token(Token = "0x40001A6")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x40001A7")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x40001A8")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x40001A9")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x17DE3E0", Offset = "0x17DA3E0", VA = "0x17DE3E0")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public enum RESULT
	{
		[Token(Token = "0x40001AB")]
		OK,
		[Token(Token = "0x40001AC")]
		ERR_BADCOMMAND,
		[Token(Token = "0x40001AD")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x40001AE")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x40001AF")]
		ERR_DMA,
		[Token(Token = "0x40001B0")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x40001B1")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x40001B2")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x40001B3")]
		ERR_DSP_INUSE,
		[Token(Token = "0x40001B4")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x40001B5")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x40001B6")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x40001B7")]
		ERR_DSP_TYPE,
		[Token(Token = "0x40001B8")]
		ERR_FILE_BAD,
		[Token(Token = "0x40001B9")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x40001BA")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x40001BB")]
		ERR_FILE_EOF,
		[Token(Token = "0x40001BC")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x40001BD")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x40001BE")]
		ERR_FORMAT,
		[Token(Token = "0x40001BF")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x40001C0")]
		ERR_HTTP,
		[Token(Token = "0x40001C1")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x40001C2")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x40001C3")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x40001C4")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x40001C5")]
		ERR_INITIALIZATION,
		[Token(Token = "0x40001C6")]
		ERR_INITIALIZED,
		[Token(Token = "0x40001C7")]
		ERR_INTERNAL,
		[Token(Token = "0x40001C8")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x40001C9")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x40001CA")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x40001CB")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x40001CC")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x40001CD")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x40001CE")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x40001CF")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x40001D0")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x40001D1")]
		ERR_MEMORY,
		[Token(Token = "0x40001D2")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x40001D3")]
		ERR_NEEDS3D,
		[Token(Token = "0x40001D4")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x40001D5")]
		ERR_NET_CONNECT,
		[Token(Token = "0x40001D6")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x40001D7")]
		ERR_NET_URL,
		[Token(Token = "0x40001D8")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x40001D9")]
		ERR_NOTREADY,
		[Token(Token = "0x40001DA")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x40001DB")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x40001DC")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x40001DD")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x40001DE")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x40001DF")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x40001E0")]
		ERR_PLUGIN,
		[Token(Token = "0x40001E1")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x40001E2")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x40001E3")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x40001E4")]
		ERR_RECORD,
		[Token(Token = "0x40001E5")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x40001E6")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x40001E7")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x40001E8")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x40001E9")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x40001EA")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x40001EB")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x40001EC")]
		ERR_TRUNCATED,
		[Token(Token = "0x40001ED")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x40001EE")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x40001EF")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x40001F0")]
		ERR_VERSION,
		[Token(Token = "0x40001F1")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x40001F2")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x40001F3")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x40001F4")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x40001F5")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x40001F6")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x40001F7")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x40001F8")]
		ERR_INVALID_STRING,
		[Token(Token = "0x40001F9")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x40001FA")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x40001FB")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x40001FC")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000066")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x40001FE")]
		CHANNEL,
		[Token(Token = "0x40001FF")]
		CHANNELGROUP,
		[Token(Token = "0x4000200")]
		MAX
	}
	[Token(Token = "0x2000067")]
	public struct VECTOR
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000068")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public struct GUID : IEquatable<GUID>
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Data1;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Data2;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Data3;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int Data4;

		[Token(Token = "0x1700005A")]
		public bool IsNull
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x17CBD18", Offset = "0x17C7D18", VA = "0x17CBD18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x17DE3E8", Offset = "0x17DA3E8", VA = "0x17DE3E8")]
		public GUID(Guid guid)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x17DE468", Offset = "0x17DA468", VA = "0x17DE468")]
		public static GUID Parse(string s)
		{
			return default(GUID);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x17DE4A4", Offset = "0x17DA4A4", VA = "0x17DE4A4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x17D8C1C", Offset = "0x17D4C1C", VA = "0x17D8C1C", Slot = "4")]
		public bool Equals(GUID other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x17DE54C", Offset = "0x17DA54C", VA = "0x17DE54C")]
		public static bool operator ==(GUID a, GUID b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x17DE574", Offset = "0x17DA574", VA = "0x17DE574")]
		public static bool operator !=(GUID a, GUID b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x17D8C74", Offset = "0x17D4C74", VA = "0x17D8C74", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x17DE59C", Offset = "0x17DA59C", VA = "0x17DE59C")]
		public static implicit operator Guid(GUID guid)
		{
			return default(Guid);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x17CBC80", Offset = "0x17C7C80", VA = "0x17CBC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x200006B")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x4000215")]
		AUTODETECT,
		[Token(Token = "0x4000216")]
		UNKNOWN,
		[Token(Token = "0x4000217")]
		NOSOUND,
		[Token(Token = "0x4000218")]
		WAVWRITER,
		[Token(Token = "0x4000219")]
		NOSOUND_NRT,
		[Token(Token = "0x400021A")]
		WAVWRITER_NRT,
		[Token(Token = "0x400021B")]
		WASAPI,
		[Token(Token = "0x400021C")]
		ASIO,
		[Token(Token = "0x400021D")]
		PULSEAUDIO,
		[Token(Token = "0x400021E")]
		ALSA,
		[Token(Token = "0x400021F")]
		COREAUDIO,
		[Token(Token = "0x4000220")]
		AUDIOTRACK,
		[Token(Token = "0x4000221")]
		OPENSL,
		[Token(Token = "0x4000222")]
		AUDIOOUT,
		[Token(Token = "0x4000223")]
		AUDIO3D,
		[Token(Token = "0x4000224")]
		WEBAUDIO,
		[Token(Token = "0x4000225")]
		NNAUDIO,
		[Token(Token = "0x4000226")]
		WINSONIC,
		[Token(Token = "0x4000227")]
		AAUDIO,
		[Token(Token = "0x4000228")]
		AUDIOWORKLET,
		[Token(Token = "0x4000229")]
		PHASE,
		[Token(Token = "0x400022A")]
		OHAUDIO,
		[Token(Token = "0x400022B")]
		MAX
	}
	[Token(Token = "0x200006C")]
	public enum PORT_TYPE
	{
		[Token(Token = "0x400022D")]
		MUSIC,
		[Token(Token = "0x400022E")]
		COPYRIGHT_MUSIC,
		[Token(Token = "0x400022F")]
		VOICE,
		[Token(Token = "0x4000230")]
		CONTROLLER,
		[Token(Token = "0x4000231")]
		PERSONAL,
		[Token(Token = "0x4000232")]
		VIBRATION,
		[Token(Token = "0x4000233")]
		AUX,
		[Token(Token = "0x4000234")]
		MAX
	}
	[Token(Token = "0x200006D")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x4000236")]
		TTY,
		[Token(Token = "0x4000237")]
		FILE,
		[Token(Token = "0x4000238")]
		CALLBACK
	}
	[Token(Token = "0x200006E")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x400023A")]
		NONE = 0u,
		[Token(Token = "0x400023B")]
		ERROR = 1u,
		[Token(Token = "0x400023C")]
		WARNING = 2u,
		[Token(Token = "0x400023D")]
		LOG = 4u,
		[Token(Token = "0x400023E")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x400023F")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x4000240")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x4000241")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x4000242")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x4000243")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x4000244")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x200006F")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x4000246")]
		NORMAL = 0u,
		[Token(Token = "0x4000247")]
		STREAM_FILE = 1u,
		[Token(Token = "0x4000248")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x4000249")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x400024A")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x400024B")]
		PLUGIN = 0x10u,
		[Token(Token = "0x400024C")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x400024D")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000070")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x400024F")]
		DEFAULT,
		[Token(Token = "0x4000250")]
		RAW,
		[Token(Token = "0x4000251")]
		MONO,
		[Token(Token = "0x4000252")]
		STEREO,
		[Token(Token = "0x4000253")]
		QUAD,
		[Token(Token = "0x4000254")]
		SURROUND,
		[Token(Token = "0x4000255")]
		_5POINT1,
		[Token(Token = "0x4000256")]
		_7POINT1,
		[Token(Token = "0x4000257")]
		_7POINT1POINT4,
		[Token(Token = "0x4000258")]
		MAX
	}
	[Token(Token = "0x2000071")]
	public enum SPEAKER
	{
		[Token(Token = "0x400025A")]
		NONE = -1,
		[Token(Token = "0x400025B")]
		FRONT_LEFT,
		[Token(Token = "0x400025C")]
		FRONT_RIGHT,
		[Token(Token = "0x400025D")]
		FRONT_CENTER,
		[Token(Token = "0x400025E")]
		LOW_FREQUENCY,
		[Token(Token = "0x400025F")]
		SURROUND_LEFT,
		[Token(Token = "0x4000260")]
		SURROUND_RIGHT,
		[Token(Token = "0x4000261")]
		BACK_LEFT,
		[Token(Token = "0x4000262")]
		BACK_RIGHT,
		[Token(Token = "0x4000263")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x4000264")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x4000265")]
		TOP_BACK_LEFT,
		[Token(Token = "0x4000266")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x4000267")]
		MAX
	}
	[Token(Token = "0x2000072")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x4000269")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x400026A")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x400026B")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x400026C")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x400026D")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x400026E")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x400026F")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x4000270")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x4000271")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x4000272")]
		MONO = 1u,
		[Token(Token = "0x4000273")]
		STEREO = 3u,
		[Token(Token = "0x4000274")]
		LRC = 7u,
		[Token(Token = "0x4000275")]
		QUAD = 0x33u,
		[Token(Token = "0x4000276")]
		SURROUND = 0x37u,
		[Token(Token = "0x4000277")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x4000278")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x4000279")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x400027A")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x2000073")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x400027C")]
		DEFAULT,
		[Token(Token = "0x400027D")]
		WAVEFORMAT,
		[Token(Token = "0x400027E")]
		PROTOOLS,
		[Token(Token = "0x400027F")]
		ALLMONO,
		[Token(Token = "0x4000280")]
		ALLSTEREO,
		[Token(Token = "0x4000281")]
		ALSA,
		[Token(Token = "0x4000282")]
		MAX
	}
	[Token(Token = "0x2000074")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x4000284")]
		OUTPUT,
		[Token(Token = "0x4000285")]
		CODEC,
		[Token(Token = "0x4000286")]
		DSP,
		[Token(Token = "0x4000287")]
		MAX
	}
	[Token(Token = "0x2000075")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x2000076")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x400028B")]
		NORMAL = 0u,
		[Token(Token = "0x400028C")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x400028D")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x400028E")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x400028F")]
		CLIP_OUTPUT = 8u,
		[Token(Token = "0x4000290")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x4000291")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x4000292")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x4000293")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x4000294")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x4000295")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x4000296")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x4000297")]
		PROFILE_METER_ALL = 0x200000u,
		[Token(Token = "0x4000298")]
		MEMORY_TRACKING = 0x400000u
	}
	[Token(Token = "0x2000077")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x400029A")]
		UNKNOWN,
		[Token(Token = "0x400029B")]
		AIFF,
		[Token(Token = "0x400029C")]
		ASF,
		[Token(Token = "0x400029D")]
		DLS,
		[Token(Token = "0x400029E")]
		FLAC,
		[Token(Token = "0x400029F")]
		FSB,
		[Token(Token = "0x40002A0")]
		IT,
		[Token(Token = "0x40002A1")]
		MIDI,
		[Token(Token = "0x40002A2")]
		MOD,
		[Token(Token = "0x40002A3")]
		MPEG,
		[Token(Token = "0x40002A4")]
		OGGVORBIS,
		[Token(Token = "0x40002A5")]
		PLAYLIST,
		[Token(Token = "0x40002A6")]
		RAW,
		[Token(Token = "0x40002A7")]
		S3M,
		[Token(Token = "0x40002A8")]
		USER,
		[Token(Token = "0x40002A9")]
		WAV,
		[Token(Token = "0x40002AA")]
		XM,
		[Token(Token = "0x40002AB")]
		XMA,
		[Token(Token = "0x40002AC")]
		AUDIOQUEUE,
		[Token(Token = "0x40002AD")]
		AT9,
		[Token(Token = "0x40002AE")]
		VORBIS,
		[Token(Token = "0x40002AF")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x40002B0")]
		MEDIACODEC,
		[Token(Token = "0x40002B1")]
		FADPCM,
		[Token(Token = "0x40002B2")]
		OPUS,
		[Token(Token = "0x40002B3")]
		MAX
	}
	[Token(Token = "0x2000078")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x40002B5")]
		NONE,
		[Token(Token = "0x40002B6")]
		PCM8,
		[Token(Token = "0x40002B7")]
		PCM16,
		[Token(Token = "0x40002B8")]
		PCM24,
		[Token(Token = "0x40002B9")]
		PCM32,
		[Token(Token = "0x40002BA")]
		PCMFLOAT,
		[Token(Token = "0x40002BB")]
		BITSTREAM,
		[Token(Token = "0x40002BC")]
		MAX
	}
	[Token(Token = "0x2000079")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x40002BE")]
		DEFAULT = 0u,
		[Token(Token = "0x40002BF")]
		LOOP_OFF = 1u,
		[Token(Token = "0x40002C0")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x40002C1")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x40002C2")]
		_2D = 8u,
		[Token(Token = "0x40002C3")]
		_3D = 0x10u,
		[Token(Token = "0x40002C4")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x40002C5")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x40002C6")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x40002C7")]
		OPENUSER = 0x400u,
		[Token(Token = "0x40002C8")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x40002C9")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x40002CA")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x40002CB")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x40002CC")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x40002CD")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x40002CE")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x40002CF")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x40002D0")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x40002D1")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x40002D2")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x40002D3")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x40002D4")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x40002D5")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x40002D6")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x40002D7")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x40002D8")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x40002D9")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x40002DA")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x200007A")]
	public enum OPENSTATE
	{
		[Token(Token = "0x40002DC")]
		READY,
		[Token(Token = "0x40002DD")]
		LOADING,
		[Token(Token = "0x40002DE")]
		ERROR,
		[Token(Token = "0x40002DF")]
		CONNECTING,
		[Token(Token = "0x40002E0")]
		BUFFERING,
		[Token(Token = "0x40002E1")]
		SEEKING,
		[Token(Token = "0x40002E2")]
		PLAYING,
		[Token(Token = "0x40002E3")]
		SETPOSITION,
		[Token(Token = "0x40002E4")]
		MAX
	}
	[Token(Token = "0x200007B")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x40002E6")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x40002E7")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x40002E8")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x40002E9")]
		MAX
	}
	[Token(Token = "0x200007C")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x40002EB")]
		END,
		[Token(Token = "0x40002EC")]
		VIRTUALVOICE,
		[Token(Token = "0x40002ED")]
		SYNCPOINT,
		[Token(Token = "0x40002EE")]
		OCCLUSION,
		[Token(Token = "0x40002EF")]
		MAX
	}
	[Token(Token = "0x200007D")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x40002F0")]
		public const int HEAD = -1;

		[Token(Token = "0x40002F1")]
		public const int FADER = -2;

		[Token(Token = "0x40002F2")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x200007E")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x40002F4")]
		NONE,
		[Token(Token = "0x40002F5")]
		SYSTEM,
		[Token(Token = "0x40002F6")]
		CHANNEL,
		[Token(Token = "0x40002F7")]
		CHANNELGROUP,
		[Token(Token = "0x40002F8")]
		CHANNELCONTROL,
		[Token(Token = "0x40002F9")]
		SOUND,
		[Token(Token = "0x40002FA")]
		SOUNDGROUP,
		[Token(Token = "0x40002FB")]
		DSP,
		[Token(Token = "0x40002FC")]
		DSPCONNECTION,
		[Token(Token = "0x40002FD")]
		GEOMETRY,
		[Token(Token = "0x40002FE")]
		REVERB3D,
		[Token(Token = "0x40002FF")]
		STUDIO_SYSTEM,
		[Token(Token = "0x4000300")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x4000301")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x4000302")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x4000303")]
		STUDIO_BUS,
		[Token(Token = "0x4000304")]
		STUDIO_VCA,
		[Token(Token = "0x4000305")]
		STUDIO_BANK,
		[Token(Token = "0x4000306")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x200007F")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x2000080")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dsp;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float stream;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometry;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float update;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float convolution1;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float convolution2;
	}
	[Token(Token = "0x2000081")]
	public struct DSP_DATA_PARAMETER_INFO
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr data;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint length;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int index;
	}
	[Token(Token = "0x2000082")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000316")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x4000317")]
		DEVICELOST = 2u,
		[Token(Token = "0x4000318")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x4000319")]
		THREADCREATED = 8u,
		[Token(Token = "0x400031A")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x400031B")]
		PREMIX = 0x20u,
		[Token(Token = "0x400031C")]
		POSTMIX = 0x40u,
		[Token(Token = "0x400031D")]
		ERROR = 0x80u,
		[Token(Token = "0x400031E")]
		MIDMIX = 0x100u,
		[Token(Token = "0x400031F")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x4000320")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x4000321")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x4000322")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x4000323")]
		BUFFEREDNOMIX = 0x2000u,
		[Token(Token = "0x4000324")]
		DEVICEREINITIALIZE = 0x4000u,
		[Token(Token = "0x4000325")]
		OUTPUTUNDERRUN = 0x8000u,
		[Token(Token = "0x4000326")]
		RECORDPOSITIONCHANGED = 0x10000u,
		[Token(Token = "0x4000327")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000083")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, IntPtr file, int line, IntPtr func, IntPtr message);
	[Token(Token = "0x2000084")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x2000085")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x2000086")]
	public delegate RESULT DSP_CALLBACK(IntPtr dsp, DSP_CALLBACK_TYPE type, IntPtr data);
	[Token(Token = "0x2000087")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x2000088")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x2000089")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x200008A")]
	public delegate RESULT FILE_OPEN_CALLBACK(IntPtr name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x200008B")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x200008C")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x200008D")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x200008E")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x200008F")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000090")]
	public delegate void FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x2000091")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, IntPtr sourcestr);
	[Token(Token = "0x2000092")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, IntPtr sourcestr);
	[Token(Token = "0x2000093")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, IntPtr sourcestr);
	[Token(Token = "0x2000094")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x2000095")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x4000329")]
		DEFAULT,
		[Token(Token = "0x400032A")]
		NOINTERP,
		[Token(Token = "0x400032B")]
		LINEAR,
		[Token(Token = "0x400032C")]
		CUBIC,
		[Token(Token = "0x400032D")]
		SPLINE,
		[Token(Token = "0x400032E")]
		MAX
	}
	[Token(Token = "0x2000096")]
	public enum DSP_CALLBACK_TYPE
	{
		[Token(Token = "0x4000330")]
		DATAPARAMETERRELEASE,
		[Token(Token = "0x4000331")]
		MAX
	}
	[Token(Token = "0x2000097")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x4000333")]
		STANDARD,
		[Token(Token = "0x4000334")]
		SIDECHAIN,
		[Token(Token = "0x4000335")]
		SEND,
		[Token(Token = "0x4000336")]
		SEND_SIDECHAIN,
		[Token(Token = "0x4000337")]
		MAX
	}
	[Token(Token = "0x2000098")]
	public enum TAGTYPE
	{
		[Token(Token = "0x4000339")]
		UNKNOWN,
		[Token(Token = "0x400033A")]
		ID3V1,
		[Token(Token = "0x400033B")]
		ID3V2,
		[Token(Token = "0x400033C")]
		VORBISCOMMENT,
		[Token(Token = "0x400033D")]
		SHOUTCAST,
		[Token(Token = "0x400033E")]
		ICECAST,
		[Token(Token = "0x400033F")]
		ASF,
		[Token(Token = "0x4000340")]
		MIDI,
		[Token(Token = "0x4000341")]
		PLAYLIST,
		[Token(Token = "0x4000342")]
		FMOD,
		[Token(Token = "0x4000343")]
		USER,
		[Token(Token = "0x4000344")]
		MAX
	}
	[Token(Token = "0x2000099")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x4000346")]
		BINARY,
		[Token(Token = "0x4000347")]
		INT,
		[Token(Token = "0x4000348")]
		FLOAT,
		[Token(Token = "0x4000349")]
		STRING,
		[Token(Token = "0x400034A")]
		STRING_UTF16,
		[Token(Token = "0x400034B")]
		STRING_UTF16BE,
		[Token(Token = "0x400034C")]
		STRING_UTF8,
		[Token(Token = "0x400034D")]
		MAX
	}
	[Token(Token = "0x200009A")]
	public struct TAG
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x200009B")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x4000355")]
		MS = 1u,
		[Token(Token = "0x4000356")]
		PCM = 2u,
		[Token(Token = "0x4000357")]
		PCMBYTES = 4u,
		[Token(Token = "0x4000358")]
		RAWBYTES = 8u,
		[Token(Token = "0x4000359")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x400035A")]
		MODORDER = 0x100u,
		[Token(Token = "0x400035B")]
		MODROW = 0x200u,
		[Token(Token = "0x400035C")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x200009C")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x400035D")]
		public const ulong NONE = ulong.MaxValue;

		[Token(Token = "0x400035E")]
		public const ulong FLAG_VR_CONTROLLER = 1152921504606846976uL;
	}
	[Token(Token = "0x200009D")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IntPtr pcmreadcallback_internal;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IntPtr pcmsetposcallback_internal;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IntPtr nonblockcallback_internal;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IntPtr fileuseropen_internal;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IntPtr fileuserclose_internal;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IntPtr fileuserread_internal;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IntPtr fileuserseek_internal;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IntPtr fileuserasyncread_internal;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IntPtr fileuserasynccancel_internal;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;

		[Token(Token = "0x1700005B")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x17E0308", Offset = "0x17DC308", VA = "0x17E0308")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x17E0284", Offset = "0x17DC284", VA = "0x17E0284")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x17E0420", Offset = "0x17DC420", VA = "0x17E0420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x17E039C", Offset = "0x17DC39C", VA = "0x17E039C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x17E0538", Offset = "0x17DC538", VA = "0x17E0538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x17E04B4", Offset = "0x17DC4B4", VA = "0x17E04B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public FILE_OPEN_CALLBACK fileuseropen
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x17E0650", Offset = "0x17DC650", VA = "0x17E0650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x17E05CC", Offset = "0x17DC5CC", VA = "0x17E05CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public FILE_CLOSE_CALLBACK fileuserclose
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x17E0768", Offset = "0x17DC768", VA = "0x17E0768")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x17E06E4", Offset = "0x17DC6E4", VA = "0x17E06E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public FILE_READ_CALLBACK fileuserread
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x17E0880", Offset = "0x17DC880", VA = "0x17E0880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x17E07FC", Offset = "0x17DC7FC", VA = "0x17E07FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public FILE_SEEK_CALLBACK fileuserseek
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x17E0998", Offset = "0x17DC998", VA = "0x17E0998")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x17E0914", Offset = "0x17DC914", VA = "0x17E0914")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x17E0AB0", Offset = "0x17DCAB0", VA = "0x17E0AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x17E0A2C", Offset = "0x17DCA2C", VA = "0x17E0A2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x17E0BC8", Offset = "0x17DCBC8", VA = "0x17E0BC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x17E0B44", Offset = "0x17DCB44", VA = "0x17E0B44")]
			set
			{
			}
		}
	}
	[Token(Token = "0x200009E")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x17E0C5C", Offset = "0x17DCC5C", VA = "0x17E0C5C")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PRESET
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x17E0C90", Offset = "0x17DCC90", VA = "0x17E0C90")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x17E0CB4", Offset = "0x17DCCB4", VA = "0x17E0CB4")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x17E0CD8", Offset = "0x17DCCD8", VA = "0x17E0CD8")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x17E0CFC", Offset = "0x17DCCFC", VA = "0x17E0CFC")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x17E0D20", Offset = "0x17DCD20", VA = "0x17E0D20")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x17E0D44", Offset = "0x17DCD44", VA = "0x17E0D44")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x17E0D68", Offset = "0x17DCD68", VA = "0x17E0D68")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x17E0D8C", Offset = "0x17DCD8C", VA = "0x17E0D8C")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x17E0DB0", Offset = "0x17DCDB0", VA = "0x17E0DB0")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x17E0DD4", Offset = "0x17DCDD4", VA = "0x17E0DD4")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x17E0DF8", Offset = "0x17DCDF8", VA = "0x17E0DF8")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x17E0E1C", Offset = "0x17DCE1C", VA = "0x17E0E1C")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x17E0E40", Offset = "0x17DCE40", VA = "0x17E0E40")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x17E0E64", Offset = "0x17DCE64", VA = "0x17E0E64")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x17E0E88", Offset = "0x17DCE88", VA = "0x17E0E88")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x17E0EAC", Offset = "0x17DCEAC", VA = "0x17E0EAC")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x17E0ED0", Offset = "0x17DCED0", VA = "0x17E0ED0")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x17E0EF4", Offset = "0x17DCEF4", VA = "0x17E0EF4")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17E0F18", Offset = "0x17DCF18", VA = "0x17E0F18")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x17E0F3C", Offset = "0x17DCF3C", VA = "0x17E0F3C")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x17E0F60", Offset = "0x17DCF60", VA = "0x17E0F60")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x17E0F84", Offset = "0x17DCF84", VA = "0x17E0F84")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x17E0FA8", Offset = "0x17DCFA8", VA = "0x17E0FA8")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x17E0FCC", Offset = "0x17DCFCC", VA = "0x17E0FCC")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x17E0FF0", Offset = "0x17DCFF0", VA = "0x17E0FF0")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint randomSeed;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int maxConvolutionThreads;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxOpusCodecs;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxSpatialObjects;
	}
	[Token(Token = "0x20000A1")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x40003A7")]
		CONNECTED = 1u,
		[Token(Token = "0x40003A8")]
		DEFAULT = 2u
	}
	[Token(Token = "0x20000A2")]
	public enum THREAD_PRIORITY
	{
		[Token(Token = "0x40003AA")]
		PLATFORM_MIN = -32768,
		[Token(Token = "0x40003AB")]
		PLATFORM_MAX = 32768,
		[Token(Token = "0x40003AC")]
		DEFAULT = -32769,
		[Token(Token = "0x40003AD")]
		LOW = -32770,
		[Token(Token = "0x40003AE")]
		MEDIUM = -32771,
		[Token(Token = "0x40003AF")]
		HIGH = -32772,
		[Token(Token = "0x40003B0")]
		VERY_HIGH = -32773,
		[Token(Token = "0x40003B1")]
		EXTREME = -32774,
		[Token(Token = "0x40003B2")]
		CRITICAL = -32775,
		[Token(Token = "0x40003B3")]
		MIXER = -32774,
		[Token(Token = "0x40003B4")]
		FEEDER = -32775,
		[Token(Token = "0x40003B5")]
		STREAM = -32773,
		[Token(Token = "0x40003B6")]
		FILE = -32772,
		[Token(Token = "0x40003B7")]
		NONBLOCKING = -32772,
		[Token(Token = "0x40003B8")]
		RECORD = -32772,
		[Token(Token = "0x40003B9")]
		GEOMETRY = -32770,
		[Token(Token = "0x40003BA")]
		PROFILER = -32771,
		[Token(Token = "0x40003BB")]
		STUDIO_UPDATE = -32771,
		[Token(Token = "0x40003BC")]
		STUDIO_LOAD_BANK = -32771,
		[Token(Token = "0x40003BD")]
		STUDIO_LOAD_SAMPLE = -32771,
		[Token(Token = "0x40003BE")]
		CONVOLUTION1 = -32773,
		[Token(Token = "0x40003BF")]
		CONVOLUTION2 = -32773
	}
	[Token(Token = "0x20000A3")]
	public enum THREAD_STACK_SIZE : uint
	{
		[Token(Token = "0x40003C1")]
		DEFAULT = 0u,
		[Token(Token = "0x40003C2")]
		MIXER = 81920u,
		[Token(Token = "0x40003C3")]
		FEEDER = 16384u,
		[Token(Token = "0x40003C4")]
		STREAM = 98304u,
		[Token(Token = "0x40003C5")]
		FILE = 65536u,
		[Token(Token = "0x40003C6")]
		NONBLOCKING = 114688u,
		[Token(Token = "0x40003C7")]
		RECORD = 16384u,
		[Token(Token = "0x40003C8")]
		GEOMETRY = 49152u,
		[Token(Token = "0x40003C9")]
		PROFILER = 131072u,
		[Token(Token = "0x40003CA")]
		STUDIO_UPDATE = 98304u,
		[Token(Token = "0x40003CB")]
		STUDIO_LOAD_BANK = 98304u,
		[Token(Token = "0x40003CC")]
		STUDIO_LOAD_SAMPLE = 98304u,
		[Token(Token = "0x40003CD")]
		CONVOLUTION1 = 16384u,
		[Token(Token = "0x40003CE")]
		CONVOLUTION2 = 16384u
	}
	[Token(Token = "0x20000A4")]
	[Flags]
	public enum THREAD_AFFINITY : long
	{
		[Token(Token = "0x40003D0")]
		GROUP_DEFAULT = 0x4000000000000000L,
		[Token(Token = "0x40003D1")]
		GROUP_A = 0x4000000000000001L,
		[Token(Token = "0x40003D2")]
		GROUP_B = 0x4000000000000002L,
		[Token(Token = "0x40003D3")]
		GROUP_C = 0x4000000000000003L,
		[Token(Token = "0x40003D4")]
		MIXER = 0x4000000000000001L,
		[Token(Token = "0x40003D5")]
		FEEDER = 0x4000000000000003L,
		[Token(Token = "0x40003D6")]
		STREAM = 0x4000000000000003L,
		[Token(Token = "0x40003D7")]
		FILE = 0x4000000000000003L,
		[Token(Token = "0x40003D8")]
		NONBLOCKING = 0x4000000000000003L,
		[Token(Token = "0x40003D9")]
		RECORD = 0x4000000000000003L,
		[Token(Token = "0x40003DA")]
		GEOMETRY = 0x4000000000000003L,
		[Token(Token = "0x40003DB")]
		PROFILER = 0x4000000000000003L,
		[Token(Token = "0x40003DC")]
		STUDIO_UPDATE = 0x4000000000000002L,
		[Token(Token = "0x40003DD")]
		STUDIO_LOAD_BANK = 0x4000000000000003L,
		[Token(Token = "0x40003DE")]
		STUDIO_LOAD_SAMPLE = 0x4000000000000003L,
		[Token(Token = "0x40003DF")]
		CONVOLUTION1 = 0x4000000000000003L,
		[Token(Token = "0x40003E0")]
		CONVOLUTION2 = 0x4000000000000003L,
		[Token(Token = "0x40003E1")]
		CORE_ALL = 0L,
		[Token(Token = "0x40003E2")]
		CORE_0 = 1L,
		[Token(Token = "0x40003E3")]
		CORE_1 = 2L,
		[Token(Token = "0x40003E4")]
		CORE_2 = 4L,
		[Token(Token = "0x40003E5")]
		CORE_3 = 8L,
		[Token(Token = "0x40003E6")]
		CORE_4 = 0x10L,
		[Token(Token = "0x40003E7")]
		CORE_5 = 0x20L,
		[Token(Token = "0x40003E8")]
		CORE_6 = 0x40L,
		[Token(Token = "0x40003E9")]
		CORE_7 = 0x80L,
		[Token(Token = "0x40003EA")]
		CORE_8 = 0x100L,
		[Token(Token = "0x40003EB")]
		CORE_9 = 0x200L,
		[Token(Token = "0x40003EC")]
		CORE_10 = 0x400L,
		[Token(Token = "0x40003ED")]
		CORE_11 = 0x800L,
		[Token(Token = "0x40003EE")]
		CORE_12 = 0x1000L,
		[Token(Token = "0x40003EF")]
		CORE_13 = 0x2000L,
		[Token(Token = "0x40003F0")]
		CORE_14 = 0x4000L,
		[Token(Token = "0x40003F1")]
		CORE_15 = 0x8000L
	}
	[Token(Token = "0x20000A5")]
	public enum THREAD_TYPE
	{
		[Token(Token = "0x40003F3")]
		MIXER,
		[Token(Token = "0x40003F4")]
		FEEDER,
		[Token(Token = "0x40003F5")]
		STREAM,
		[Token(Token = "0x40003F6")]
		FILE,
		[Token(Token = "0x40003F7")]
		NONBLOCKING,
		[Token(Token = "0x40003F8")]
		RECORD,
		[Token(Token = "0x40003F9")]
		GEOMETRY,
		[Token(Token = "0x40003FA")]
		PROFILER,
		[Token(Token = "0x40003FB")]
		STUDIO_UPDATE,
		[Token(Token = "0x40003FC")]
		STUDIO_LOAD_BANK,
		[Token(Token = "0x40003FD")]
		STUDIO_LOAD_SAMPLE,
		[Token(Token = "0x40003FE")]
		CONVOLUTION1,
		[Token(Token = "0x40003FF")]
		CONVOLUTION2,
		[Token(Token = "0x4000400")]
		MAX
	}
	[Token(Token = "0x20000A6")]
	public struct Factory
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x17E0FF8", Offset = "0x17DCFF8", VA = "0x17E0FF8")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x17E1004", Offset = "0x17DD004", VA = "0x17E1004")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system, uint headerversion);
	}
	[Token(Token = "0x20000A7")]
	public struct Memory
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x17E1088", Offset = "0x17DD088", VA = "0x17E1088")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x17D57EC", Offset = "0x17D17EC", VA = "0x17D57EC")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x17E108C", Offset = "0x17DD08C", VA = "0x17E108C")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x17E1160", Offset = "0x17DD160", VA = "0x17E1160")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x20000A8")]
	public struct Debug
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x17E11F4", Offset = "0x17DD1F4", VA = "0x17E11F4")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x17E1380", Offset = "0x17DD380", VA = "0x17E1380")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x20000A9")]
	public struct Thread
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x17D4238", Offset = "0x17D0238", VA = "0x17D4238")]
		public static RESULT SetAttributes(THREAD_TYPE type, THREAD_AFFINITY affinity = THREAD_AFFINITY.GROUP_DEFAULT, THREAD_PRIORITY priority = THREAD_PRIORITY.DEFAULT, THREAD_STACK_SIZE stacksize = THREAD_STACK_SIZE.DEFAULT)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x17E142C", Offset = "0x17DD42C", VA = "0x17E142C")]
		private static extern RESULT FMOD5_Thread_SetAttributes(THREAD_TYPE type, THREAD_AFFINITY affinity, THREAD_PRIORITY priority, THREAD_STACK_SIZE stacksize);
	}
	[Token(Token = "0x20000AA")]
	public struct System
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x17E14C8", Offset = "0x17DD4C8", VA = "0x17E14C8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x17D3950", Offset = "0x17CF950", VA = "0x17D3950")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x17E15D0", Offset = "0x17DD5D0", VA = "0x17E15D0")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x17E165C", Offset = "0x17DD65C", VA = "0x17E165C")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x17E16E8", Offset = "0x17DD6E8", VA = "0x17E16E8")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x17E19C4", Offset = "0x17DD9C4", VA = "0x17E19C4")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x17E19F8", Offset = "0x17DD9F8", VA = "0x17E19F8")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x17E1A84", Offset = "0x17DDA84", VA = "0x17E1A84")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x17D3958", Offset = "0x17CF958", VA = "0x17D3958")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x17E1B94", Offset = "0x17DDB94", VA = "0x17E1B94")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x17D3960", Offset = "0x17CF960", VA = "0x17D3960")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x17E1CBC", Offset = "0x17DDCBC", VA = "0x17E1CBC")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x17D3968", Offset = "0x17CF968", VA = "0x17D3968")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x17E1DF4", Offset = "0x17DDDF4", VA = "0x17E1DF4")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x17E1E90", Offset = "0x17DDE90", VA = "0x17E1E90")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x17E1FA8", Offset = "0x17DDFA8", VA = "0x17E1FA8")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x17D3970", Offset = "0x17CF970", VA = "0x17D3970")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x17E210C", Offset = "0x17DE10C", VA = "0x17E210C")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x17D3A88", Offset = "0x17CFA88", VA = "0x17D3A88")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x17E22B8", Offset = "0x17DE2B8", VA = "0x17E22B8")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x17CE48C", Offset = "0x17CA48C", VA = "0x17CE48C")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x17E2560", Offset = "0x17DE560", VA = "0x17E2560")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x17E25EC", Offset = "0x17DE5EC", VA = "0x17E25EC")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x17E2688", Offset = "0x17DE688", VA = "0x17E2688")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x17E272C", Offset = "0x17DE72C", VA = "0x17E272C")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x17E27C8", Offset = "0x17DE7C8", VA = "0x17E27C8")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x17E286C", Offset = "0x17DE86C", VA = "0x17E286C")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x17E2B18", Offset = "0x17DEB18", VA = "0x17E2B18")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x17E2B2C", Offset = "0x17DEB2C", VA = "0x17E2B2C")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x17E2BB8", Offset = "0x17DEBB8", VA = "0x17E2BB8")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x17E2C44", Offset = "0x17DEC44", VA = "0x17E2C44")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x17E2CE0", Offset = "0x17DECE0", VA = "0x17E2CE0")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x17E2D7C", Offset = "0x17DED7C", VA = "0x17E2D7C")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x17E2E94", Offset = "0x17DEE94", VA = "0x17E2E94")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x17E2F38", Offset = "0x17DEF38", VA = "0x17E2F38")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x17E2FBC", Offset = "0x17DEFBC", VA = "0x17E2FBC")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x17E3040", Offset = "0x17DF040", VA = "0x17E3040")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x17E30F4", Offset = "0x17DF0F4", VA = "0x17E30F4")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x17E31BC", Offset = "0x17DF1BC", VA = "0x17E31BC")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x17E3258", Offset = "0x17DF258", VA = "0x17E3258")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x17E32F4", Offset = "0x17DF2F4", VA = "0x17E32F4")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x17E33A0", Offset = "0x17DF3A0", VA = "0x17E33A0")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x17E3444", Offset = "0x17DF444", VA = "0x17E3444")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x17E34D0", Offset = "0x17DF4D0", VA = "0x17E34D0")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x17E355C", Offset = "0x17DF55C", VA = "0x17E355C")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x17E3618", Offset = "0x17DF618", VA = "0x17E3618")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x17E36D4", Offset = "0x17DF6D4", VA = "0x17E36D4")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x17D5AB0", Offset = "0x17D1AB0", VA = "0x17D5AB0")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x17D5AB8", Offset = "0x17D1AB8", VA = "0x17D5AB8")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x17E3860", Offset = "0x17DF860", VA = "0x17E3860")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x17E391C", Offset = "0x17DF91C", VA = "0x17E391C")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x17E39B8", Offset = "0x17DF9B8", VA = "0x17E39B8")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x17E3A44", Offset = "0x17DFA44", VA = "0x17E3A44")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x17E3AD0", Offset = "0x17DFAD0", VA = "0x17E3AD0")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x17D57F0", Offset = "0x17D17F0", VA = "0x17D57F0")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x17E3C04", Offset = "0x17DFC04", VA = "0x17E3C04")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x17E3C90", Offset = "0x17DFC90", VA = "0x17E3C90")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x17E3D34", Offset = "0x17DFD34", VA = "0x17E3D34")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x17E3F80", Offset = "0x17DFF80", VA = "0x17E3F80")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x17E3F88", Offset = "0x17DFF88", VA = "0x17E3F88")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x17E403C", Offset = "0x17E003C", VA = "0x17E403C")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x17E40F8", Offset = "0x17E00F8", VA = "0x17E40F8")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x17E4344", Offset = "0x17E0344", VA = "0x17E4344")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x17E434C", Offset = "0x17E034C", VA = "0x17E434C")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x17E4400", Offset = "0x17E0400", VA = "0x17E4400")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x17E44BC", Offset = "0x17E04BC", VA = "0x17E44BC")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x17E45D8", Offset = "0x17E05D8", VA = "0x17E45D8")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x17E4674", Offset = "0x17E0674", VA = "0x17E4674")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x17E4890", Offset = "0x17E0890", VA = "0x17E4890")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x17E4AAC", Offset = "0x17E0AAC", VA = "0x17E4AAC")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x17E4B38", Offset = "0x17E0B38", VA = "0x17E4B38")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x17E4BEC", Offset = "0x17E0BEC", VA = "0x17E4BEC")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x17E4CA0", Offset = "0x17E0CA0", VA = "0x17E4CA0")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x17E4D3C", Offset = "0x17E0D3C", VA = "0x17E4D3C")]
		public RESULT getDSPInfoByType(DSP_TYPE type, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x17D57E4", Offset = "0x17D17E4", VA = "0x17D57E4")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x17E4E5C", Offset = "0x17E0E5C", VA = "0x17E4E5C")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x17E4EE8", Offset = "0x17E0EE8", VA = "0x17E4EE8")]
		public RESULT attachChannelGroupToPort(PORT_TYPE portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x17E4F9C", Offset = "0x17E0F9C", VA = "0x17E4F9C")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x17E5028", Offset = "0x17E1028", VA = "0x17E5028")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x17E50C4", Offset = "0x17E10C4", VA = "0x17E50C4")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x17E5160", Offset = "0x17E1160", VA = "0x17E5160")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x17E51E4", Offset = "0x17E11E4", VA = "0x17E51E4")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x17E5268", Offset = "0x17E1268", VA = "0x17E5268")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x17E5304", Offset = "0x17E1304", VA = "0x17E5304")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x17E55F8", Offset = "0x17E15F8", VA = "0x17E55F8")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x17E5634", Offset = "0x17E1634", VA = "0x17E5634")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x17E56D0", Offset = "0x17E16D0", VA = "0x17E56D0")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x17E5770", Offset = "0x17E1770", VA = "0x17E5770")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x17E57FC", Offset = "0x17E17FC", VA = "0x17E57FC")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x17E58AC", Offset = "0x17E18AC", VA = "0x17E58AC")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x17E5950", Offset = "0x17E1950", VA = "0x17E5950")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x17E59E4", Offset = "0x17E19E4", VA = "0x17E59E4")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x17E5A70", Offset = "0x17E1A70", VA = "0x17E5A70")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x17E5B14", Offset = "0x17E1B14", VA = "0x17E5B14")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x17E5BC8", Offset = "0x17E1BC8", VA = "0x17E5BC8")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x17E5DCC", Offset = "0x17E1DCC", VA = "0x17E5DCC")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x17E6030", Offset = "0x17E2030", VA = "0x17E6030")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x17E60BC", Offset = "0x17E20BC", VA = "0x17E60BC")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x17E6148", Offset = "0x17E2148", VA = "0x17E6148")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x17E61D4", Offset = "0x17E21D4", VA = "0x17E61D4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x17E14D0", Offset = "0x17DD4D0", VA = "0x17E14D0")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x17E154C", Offset = "0x17DD54C", VA = "0x17E154C")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x17E15D8", Offset = "0x17DD5D8", VA = "0x17E15D8")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x17E1664", Offset = "0x17DD664", VA = "0x17E1664")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x17E18F8", Offset = "0x17DD8F8", VA = "0x17E18F8")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x17E1A00", Offset = "0x17DDA00", VA = "0x17E1A00")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x17E1A8C", Offset = "0x17DDA8C", VA = "0x17E1A8C")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x17E1B10", Offset = "0x17DDB10", VA = "0x17E1B10")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x17E1B9C", Offset = "0x17DDB9C", VA = "0x17E1B9C")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x17E1C20", Offset = "0x17DDC20", VA = "0x17E1C20")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x17E1CC4", Offset = "0x17DDCC4", VA = "0x17E1CC4")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x17E1D60", Offset = "0x17DDD60", VA = "0x17E1D60")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x17E1DFC", Offset = "0x17DDDFC", VA = "0x17E1DFC")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x17E1E98", Offset = "0x17DDE98", VA = "0x17E1E98")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x17E1FB0", Offset = "0x17DDFB0", VA = "0x17E1FB0")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x17E2088", Offset = "0x17DE088", VA = "0x17E2088")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x17E2198", Offset = "0x17DE198", VA = "0x17E2198")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x17E221C", Offset = "0x17DE21C", VA = "0x17E221C")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x17E2430", Offset = "0x17DE430", VA = "0x17E2430")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17E24BC", Offset = "0x17DE4BC", VA = "0x17E24BC")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17E2568", Offset = "0x17DE568", VA = "0x17E2568")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x17E25F4", Offset = "0x17DE5F4", VA = "0x17E25F4")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x17E2690", Offset = "0x17DE690", VA = "0x17E2690")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x17E2734", Offset = "0x17DE734", VA = "0x17E2734")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x17E27D0", Offset = "0x17DE7D0", VA = "0x17E27D0")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x17E2A64", Offset = "0x17DEA64", VA = "0x17E2A64")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x17E2B34", Offset = "0x17DEB34", VA = "0x17E2B34")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x17E2BC0", Offset = "0x17DEBC0", VA = "0x17E2BC0")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x17E2C4C", Offset = "0x17DEC4C", VA = "0x17E2C4C")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x17E2CE8", Offset = "0x17DECE8", VA = "0x17E2CE8")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x17E2D84", Offset = "0x17DED84", VA = "0x17E2D84")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x17E2E9C", Offset = "0x17DEE9C", VA = "0x17E2E9C")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x17E2F40", Offset = "0x17DEF40", VA = "0x17E2F40")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x17E2FC4", Offset = "0x17DEFC4", VA = "0x17E2FC4")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x17E3048", Offset = "0x17DF048", VA = "0x17E3048")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x17E30FC", Offset = "0x17DF0FC", VA = "0x17E30FC")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x17E31C4", Offset = "0x17DF1C4", VA = "0x17E31C4")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x17E3260", Offset = "0x17DF260", VA = "0x17E3260")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x17E32FC", Offset = "0x17DF2FC", VA = "0x17E32FC")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x17E33A8", Offset = "0x17DF3A8", VA = "0x17E33A8")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x17E344C", Offset = "0x17DF44C", VA = "0x17E344C")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x17E34D8", Offset = "0x17DF4D8", VA = "0x17E34D8")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x17E3564", Offset = "0x17DF564", VA = "0x17E3564")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x17E3620", Offset = "0x17DF620", VA = "0x17E3620")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x17E36DC", Offset = "0x17DF6DC", VA = "0x17E36DC")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x17E3768", Offset = "0x17DF768", VA = "0x17E3768")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x17E37E4", Offset = "0x17DF7E4", VA = "0x17E37E4")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x17E3868", Offset = "0x17DF868", VA = "0x17E3868")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x17E3924", Offset = "0x17DF924", VA = "0x17E3924")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x17E39C0", Offset = "0x17DF9C0", VA = "0x17E39C0")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x17E3A4C", Offset = "0x17DFA4C", VA = "0x17E3A4C")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x17E3ADC", Offset = "0x17DFADC", VA = "0x17E3ADC")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x17E3B70", Offset = "0x17DFB70", VA = "0x17E3B70")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x17E3C0C", Offset = "0x17DFC0C", VA = "0x17E3C0C")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x17E3C98", Offset = "0x17DFC98", VA = "0x17E3C98")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x17E3ECC", Offset = "0x17DFECC", VA = "0x17E3ECC")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x17E3F90", Offset = "0x17DFF90", VA = "0x17E3F90")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x17E4290", Offset = "0x17E0290", VA = "0x17E4290")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x17E4354", Offset = "0x17E0354", VA = "0x17E4354")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x17E44C4", Offset = "0x17E04C4", VA = "0x17E44C4")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x17E45E0", Offset = "0x17E05E0", VA = "0x17E45E0")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x17E47F4", Offset = "0x17E07F4", VA = "0x17E47F4")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x17E4A10", Offset = "0x17E0A10", VA = "0x17E4A10")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x17E4AB4", Offset = "0x17E0AB4", VA = "0x17E4AB4")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x17E4B40", Offset = "0x17E0B40", VA = "0x17E4B40")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x17E4BF4", Offset = "0x17E0BF4", VA = "0x17E4BF4")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x17E4CA8", Offset = "0x17E0CA8", VA = "0x17E4CA8")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x17E4D44", Offset = "0x17E0D44", VA = "0x17E4D44")]
		private static extern RESULT FMOD5_System_GetDSPInfoByType(IntPtr system, DSP_TYPE type, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x17E4DD8", Offset = "0x17E0DD8", VA = "0x17E4DD8")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x17E4E64", Offset = "0x17E0E64", VA = "0x17E4E64")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x17E4EF0", Offset = "0x17E0EF0", VA = "0x17E4EF0")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, PORT_TYPE portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x17E4FA4", Offset = "0x17E0FA4", VA = "0x17E4FA4")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x17E5030", Offset = "0x17E1030", VA = "0x17E5030")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x17E50CC", Offset = "0x17E10CC", VA = "0x17E50CC")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x17E5168", Offset = "0x17E1168", VA = "0x17E5168")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x17E51EC", Offset = "0x17E11EC", VA = "0x17E51EC")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x17E5270", Offset = "0x17E1270", VA = "0x17E5270")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x17E551C", Offset = "0x17E151C", VA = "0x17E551C")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x17E563C", Offset = "0x17E163C", VA = "0x17E563C")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x17E56D8", Offset = "0x17E16D8", VA = "0x17E56D8")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x17E5778", Offset = "0x17E1778", VA = "0x17E5778")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x17E5804", Offset = "0x17E1804", VA = "0x17E5804")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x17E58B4", Offset = "0x17E18B4", VA = "0x17E58B4")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x17E5958", Offset = "0x17E1958", VA = "0x17E5958")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x17E59EC", Offset = "0x17E19EC", VA = "0x17E59EC")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x17E5A78", Offset = "0x17E1A78", VA = "0x17E5A78")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17E5B1C", Offset = "0x17E1B1C", VA = "0x17E5B1C")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17E5D40", Offset = "0x17E1D40", VA = "0x17E5D40")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x17E5F9C", Offset = "0x17E1F9C", VA = "0x17E5F9C")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x17E6038", Offset = "0x17E2038", VA = "0x17E6038")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x17E60C4", Offset = "0x17E20C4", VA = "0x17E60C4")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x17E6150", Offset = "0x17E2150", VA = "0x17E6150")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x17E61DC", Offset = "0x17E21DC", VA = "0x17E61DC")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17E6260", Offset = "0x17E2260", VA = "0x17E6260")]
		public System(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x17E6268", Offset = "0x17E2268", VA = "0x17E6268")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x17E6278", Offset = "0x17E2278", VA = "0x17E6278")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public struct Sound
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x17E74A8", Offset = "0x17E34A8", VA = "0x17E74A8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x17E752C", Offset = "0x17E352C", VA = "0x17E752C")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x17E75B8", Offset = "0x17E35B8", VA = "0x17E75B8")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x17E7684", Offset = "0x17E3684", VA = "0x17E7684")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x17E7738", Offset = "0x17E3738", VA = "0x17E7738")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17E77D4", Offset = "0x17E37D4", VA = "0x17E77D4")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x17E7870", Offset = "0x17E3870", VA = "0x17E7870")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x17E790C", Offset = "0x17E390C", VA = "0x17E790C")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17E79A8", Offset = "0x17E39A8", VA = "0x17E79A8")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x17E7A54", Offset = "0x17E3A54", VA = "0x17E7A54")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x17E7AF8", Offset = "0x17E3AF8", VA = "0x17E7AF8")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x17E7B94", Offset = "0x17E3B94", VA = "0x17E7B94")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x17E7C30", Offset = "0x17E3C30", VA = "0x17E7C30")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x17E7CCC", Offset = "0x17E3CCC", VA = "0x17E7CCC")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x17E7D58", Offset = "0x17E3D58", VA = "0x17E7D58")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x17E8488", Offset = "0x17E4488", VA = "0x17E8488")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x17E8524", Offset = "0x17E4524", VA = "0x17E8524")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x17E85D8", Offset = "0x17E45D8", VA = "0x17E85D8")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x17E8664", Offset = "0x17E4664", VA = "0x17E8664")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x17E8700", Offset = "0x17E4700", VA = "0x17E8700")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x17E8A8C", Offset = "0x17E4A8C", VA = "0x17E8A8C")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x17E8B68", Offset = "0x17E4B68", VA = "0x17E8B68")]
		public RESULT readData(byte[] buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17E8C28", Offset = "0x17E4C28", VA = "0x17E8C28")]
		public RESULT readData(byte[] buffer, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x17E8CE8", Offset = "0x17E4CE8", VA = "0x17E8CE8")]
		[Obsolete("Use Sound.readData(byte[], out uint) or Sound.readData(byte[]) instead.")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x17E8D8C", Offset = "0x17E4D8C", VA = "0x17E8D8C")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x17E8E18", Offset = "0x17E4E18", VA = "0x17E8E18")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x17E8EA4", Offset = "0x17E4EA4", VA = "0x17E8EA4")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x17E8F30", Offset = "0x17E4F30", VA = "0x17E8F30")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x17E8FBC", Offset = "0x17E4FBC", VA = "0x17E8FBC")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x17E9058", Offset = "0x17E5058", VA = "0x17E9058")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x17E92FC", Offset = "0x17E52FC", VA = "0x17E92FC")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x17E9314", Offset = "0x17E5314", VA = "0x17E9314")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x17E9558", Offset = "0x17E5558", VA = "0x17E9558")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x17E95E4", Offset = "0x17E55E4", VA = "0x17E95E4")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x17E9670", Offset = "0x17E5670", VA = "0x17E9670")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x17E96FC", Offset = "0x17E56FC", VA = "0x17E96FC")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x17E9788", Offset = "0x17E5788", VA = "0x17E9788")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x17E9814", Offset = "0x17E5814", VA = "0x17E9814")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17E98C8", Offset = "0x17E58C8", VA = "0x17E98C8")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17E997C", Offset = "0x17E597C", VA = "0x17E997C")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x17E9A08", Offset = "0x17E5A08", VA = "0x17E9A08")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x17E9AA4", Offset = "0x17E5AA4", VA = "0x17E9AA4")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x17E9B40", Offset = "0x17E5B40", VA = "0x17E9B40")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x17E9BD4", Offset = "0x17E5BD4", VA = "0x17E9BD4")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x17E9C60", Offset = "0x17E5C60", VA = "0x17E9C60")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x17E9CEC", Offset = "0x17E5CEC", VA = "0x17E9CEC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x17E74B0", Offset = "0x17E34B0", VA = "0x17E74B0")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x17E7534", Offset = "0x17E3534", VA = "0x17E7534")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x17E75C0", Offset = "0x17E35C0", VA = "0x17E75C0")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x17E768C", Offset = "0x17E368C", VA = "0x17E768C")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x17E7740", Offset = "0x17E3740", VA = "0x17E7740")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x17E77DC", Offset = "0x17E37DC", VA = "0x17E77DC")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x17E7878", Offset = "0x17E3878", VA = "0x17E7878")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x17E7914", Offset = "0x17E3914", VA = "0x17E7914")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x17E79B0", Offset = "0x17E39B0", VA = "0x17E79B0")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x17E7A5C", Offset = "0x17E3A5C", VA = "0x17E7A5C")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x17E7B00", Offset = "0x17E3B00", VA = "0x17E7B00")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x17E7B9C", Offset = "0x17E3B9C", VA = "0x17E7B9C")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x17E7C38", Offset = "0x17E3C38", VA = "0x17E7C38")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17E7CD4", Offset = "0x17E3CD4", VA = "0x17E7CD4")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x17E7F20", Offset = "0x17E3F20", VA = "0x17E7F20")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x17E8490", Offset = "0x17E4490", VA = "0x17E8490")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x17E852C", Offset = "0x17E452C", VA = "0x17E852C")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x17E85E0", Offset = "0x17E45E0", VA = "0x17E85E0")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x17E866C", Offset = "0x17E466C", VA = "0x17E866C")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x17E89B4", Offset = "0x17E49B4", VA = "0x17E89B4")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x17E8A94", Offset = "0x17E4A94", VA = "0x17E8A94")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x17E8B84", Offset = "0x17E4B84", VA = "0x17E8B84")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, byte[] buffer, uint length, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x17E8C44", Offset = "0x17E4C44", VA = "0x17E8C44")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, byte[] buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x17E8CF0", Offset = "0x17E4CF0", VA = "0x17E8CF0")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x17E8D94", Offset = "0x17E4D94", VA = "0x17E8D94")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x17E8E20", Offset = "0x17E4E20", VA = "0x17E8E20")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x17E8EAC", Offset = "0x17E4EAC", VA = "0x17E8EAC")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x17E8F38", Offset = "0x17E4F38", VA = "0x17E8F38")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x17E8FC4", Offset = "0x17E4FC4", VA = "0x17E8FC4")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x17E9248", Offset = "0x17E5248", VA = "0x17E9248")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x17E94A4", Offset = "0x17E54A4", VA = "0x17E94A4")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x17E9560", Offset = "0x17E5560", VA = "0x17E9560")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x17E95EC", Offset = "0x17E55EC", VA = "0x17E95EC")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x17E9678", Offset = "0x17E5678", VA = "0x17E9678")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x17E9704", Offset = "0x17E5704", VA = "0x17E9704")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x17E9790", Offset = "0x17E5790", VA = "0x17E9790")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x17E981C", Offset = "0x17E581C", VA = "0x17E981C")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x17E98D0", Offset = "0x17E58D0", VA = "0x17E98D0")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x17E9984", Offset = "0x17E5984", VA = "0x17E9984")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x17E9A10", Offset = "0x17E5A10", VA = "0x17E9A10")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x17E9AAC", Offset = "0x17E5AAC", VA = "0x17E9AAC")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x17E9B48", Offset = "0x17E5B48", VA = "0x17E9B48")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x17E9BDC", Offset = "0x17E5BDC", VA = "0x17E9BDC")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x17E9C68", Offset = "0x17E5C68", VA = "0x17E9C68")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x17E9CF4", Offset = "0x17E5CF4", VA = "0x17E9CF4")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x17E9D78", Offset = "0x17E5D78", VA = "0x17E9D78")]
		public Sound(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x17E9D80", Offset = "0x17E5D80", VA = "0x17E9D80")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x17E9D90", Offset = "0x17E5D90", VA = "0x17E9D90")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	internal interface IChannelControl
	{
		[Token(Token = "0x6000398")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x6000399")]
		RESULT stop();

		[Token(Token = "0x600039A")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x600039B")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x600039C")]
		RESULT setVolume(float volume);

		[Token(Token = "0x600039D")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x600039E")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x600039F")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x60003A0")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x60003A1")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x60003A2")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x60003A3")]
		RESULT setMute(bool mute);

		[Token(Token = "0x60003A4")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x60003A5")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x60003A6")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x60003A7")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x60003A8")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x60003A9")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x60003AA")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x60003AB")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x60003AC")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x60003AD")]
		RESULT setPan(float pan);

		[Token(Token = "0x60003AE")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x60003AF")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x60003B0")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x60003B1")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x60003B2")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x60003B3")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x60003B4")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x60003B5")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x60003B6")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x60003B7")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x60003B8")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x60003B9")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x60003BA")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x60003BB")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x60003BC")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x60003BD")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x60003BE")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x60003BF")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x60003C0")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x60003C1")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x60003C2")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x60003C3")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x60003C4")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x60003C5")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x60003C6")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x60003C7")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x60003C8")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x60003C9")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x60003CA")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x60003CB")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x60003CC")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x60003CD")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x60003CE")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x60003CF")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x60003D0")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x60003D1")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x60003D2")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x60003D3")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x60003D4")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x60003D5")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x20000AD")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x17E9D98", Offset = "0x17E5D98", VA = "0x17E9D98")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x17E9E2C", Offset = "0x17E5E2C", VA = "0x17E9E2C")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x17E9EB8", Offset = "0x17E5EB8", VA = "0x17E9EB8")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x17E9F44", Offset = "0x17E5F44", VA = "0x17E9F44")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x17E9FD0", Offset = "0x17E5FD0", VA = "0x17E9FD0")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x17EA06C", Offset = "0x17E606C", VA = "0x17EA06C")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x17EA108", Offset = "0x17E6108", VA = "0x17EA108")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x17EA194", Offset = "0x17E6194", VA = "0x17EA194")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x17EA220", Offset = "0x17E6220", VA = "0x17EA220")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x17EA2AC", Offset = "0x17E62AC", VA = "0x17EA2AC")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x17EA338", Offset = "0x17E6338", VA = "0x17EA338")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x17EA3EC", Offset = "0x17E63EC", VA = "0x17EA3EC")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x17EA4A0", Offset = "0x17E64A0", VA = "0x17EA4A0")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x17EA540", Offset = "0x17E6540", VA = "0x17EA540")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x17EA5CC", Offset = "0x17E65CC", VA = "0x17EA5CC")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x17EA658", Offset = "0x17E6658", VA = "0x17EA658", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x17EA6E4", Offset = "0x17E66E4", VA = "0x17EA6E4", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x17EA768", Offset = "0x17E6768", VA = "0x17EA768", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x17EA7F4", Offset = "0x17E67F4", VA = "0x17EA7F4", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x17EA894", Offset = "0x17E6894", VA = "0x17EA894", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x17EA928", Offset = "0x17E6928", VA = "0x17EA928", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x17EA9B4", Offset = "0x17E69B4", VA = "0x17EA9B4", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x17EAA40", Offset = "0x17E6A40", VA = "0x17EAA40", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x17EAAE0", Offset = "0x17E6AE0", VA = "0x17EAAE0", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x17EAB6C", Offset = "0x17E6B6C", VA = "0x17EAB6C", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x17EAC00", Offset = "0x17E6C00", VA = "0x17EAC00", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x17EAC8C", Offset = "0x17E6C8C", VA = "0x17EAC8C", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x17EAD18", Offset = "0x17E6D18", VA = "0x17EAD18", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x17EADB8", Offset = "0x17E6DB8", VA = "0x17EADB8", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x17EAE54", Offset = "0x17E6E54", VA = "0x17EAE54", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17EAEF0", Offset = "0x17E6EF0", VA = "0x17EAEF0", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x17EAF84", Offset = "0x17E6F84", VA = "0x17EAF84", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x17EB010", Offset = "0x17E7010", VA = "0x17EB010", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x17EB09C", Offset = "0x17E709C", VA = "0x17EB09C", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x17EB128", Offset = "0x17E7128", VA = "0x17EB128", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x17EB1BC", Offset = "0x17E71BC", VA = "0x17EB1BC", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x17EB25C", Offset = "0x17E725C", VA = "0x17EB25C", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x17EB2F0", Offset = "0x17E72F0", VA = "0x17EB2F0", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x17EB3D4", Offset = "0x17E73D4", VA = "0x17EB3D4", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x17EB478", Offset = "0x17E7478", VA = "0x17EB478", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x17EB534", Offset = "0x17E7534", VA = "0x17EB534", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x17EB5F0", Offset = "0x17E75F0", VA = "0x17EB5F0", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x17EB68C", Offset = "0x17E768C", VA = "0x17EB68C", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x17EB730", Offset = "0x17E7730", VA = "0x17EB730", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x17EB7D8", Offset = "0x17E77D8", VA = "0x17EB7D8", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x17EB890", Offset = "0x17E7890", VA = "0x17EB890", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x17EB92C", Offset = "0x17E792C", VA = "0x17EB92C", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x17EB9C8", Offset = "0x17E79C8", VA = "0x17EB9C8", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x17EBA64", Offset = "0x17E7A64", VA = "0x17EBA64", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x17EBB18", Offset = "0x17E7B18", VA = "0x17EBB18", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x17EBBB0", Offset = "0x17E7BB0", VA = "0x17EBBB0", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x17EBC48", Offset = "0x17E7C48", VA = "0x17EBC48", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x17EBCD4", Offset = "0x17E7CD4", VA = "0x17EBCD4", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x17EBD60", Offset = "0x17E7D60", VA = "0x17EBD60", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x17EBDFC", Offset = "0x17E7DFC", VA = "0x17EBDFC", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x17EBE98", Offset = "0x17E7E98", VA = "0x17EBE98", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x17EBF34", Offset = "0x17E7F34", VA = "0x17EBF34", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x17EBFD0", Offset = "0x17E7FD0", VA = "0x17EBFD0", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x17EC06C", Offset = "0x17E806C", VA = "0x17EC06C", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x17EC108", Offset = "0x17E8108", VA = "0x17EC108", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x17EC1B4", Offset = "0x17E81B4", VA = "0x17EC1B4", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x17EC258", Offset = "0x17E8258", VA = "0x17EC258", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x17EC2E4", Offset = "0x17E82E4", VA = "0x17EC2E4", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x17EC370", Offset = "0x17E8370", VA = "0x17EC370", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x17EC40C", Offset = "0x17E840C", VA = "0x17EC40C", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x17EC4A8", Offset = "0x17E84A8", VA = "0x17EC4A8", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x17EC544", Offset = "0x17E8544", VA = "0x17EC544", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x17EC5E0", Offset = "0x17E85E0", VA = "0x17EC5E0", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x17EC674", Offset = "0x17E8674", VA = "0x17EC674", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x17EC700", Offset = "0x17E8700", VA = "0x17EC700", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x17EC794", Offset = "0x17E8794", VA = "0x17EC794", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x17EC820", Offset = "0x17E8820", VA = "0x17EC820", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x17EC8B4", Offset = "0x17E88B4", VA = "0x17EC8B4", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x17EC940", Offset = "0x17E8940", VA = "0x17EC940", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x17EC9E4", Offset = "0x17E89E4", VA = "0x17EC9E4", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x17ECA9C", Offset = "0x17E8A9C", VA = "0x17ECA9C", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x17ECB28", Offset = "0x17E8B28", VA = "0x17ECB28", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x17E9DA0", Offset = "0x17E5DA0", VA = "0x17E9DA0")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x17E9E34", Offset = "0x17E5E34", VA = "0x17E9E34")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x17E9EC0", Offset = "0x17E5EC0", VA = "0x17E9EC0")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x17E9F4C", Offset = "0x17E5F4C", VA = "0x17E9F4C")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x17E9FD8", Offset = "0x17E5FD8", VA = "0x17E9FD8")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x17EA074", Offset = "0x17E6074", VA = "0x17EA074")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x17EA110", Offset = "0x17E6110", VA = "0x17EA110")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x17EA19C", Offset = "0x17E619C", VA = "0x17EA19C")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x17EA228", Offset = "0x17E6228", VA = "0x17EA228")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x17EA2B4", Offset = "0x17E62B4", VA = "0x17EA2B4")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x17EA340", Offset = "0x17E6340", VA = "0x17EA340")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x17EA3F4", Offset = "0x17E63F4", VA = "0x17EA3F4")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x17EA4A8", Offset = "0x17E64A8", VA = "0x17EA4A8")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x17EA548", Offset = "0x17E6548", VA = "0x17EA548")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x17EA5D4", Offset = "0x17E65D4", VA = "0x17EA5D4")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x17EA660", Offset = "0x17E6660", VA = "0x17EA660")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x17EA6EC", Offset = "0x17E66EC", VA = "0x17EA6EC")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x17EA770", Offset = "0x17E6770", VA = "0x17EA770")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x17EA7FC", Offset = "0x17E67FC", VA = "0x17EA7FC")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x17EA89C", Offset = "0x17E689C", VA = "0x17EA89C")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x17EA930", Offset = "0x17E6930", VA = "0x17EA930")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x17EA9BC", Offset = "0x17E69BC", VA = "0x17EA9BC")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x17EAA48", Offset = "0x17E6A48", VA = "0x17EAA48")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x17EAAE8", Offset = "0x17E6AE8", VA = "0x17EAAE8")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x17EAB74", Offset = "0x17E6B74", VA = "0x17EAB74")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x17EAC08", Offset = "0x17E6C08", VA = "0x17EAC08")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x17EAC94", Offset = "0x17E6C94", VA = "0x17EAC94")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x17EAD20", Offset = "0x17E6D20", VA = "0x17EAD20")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x17EADC0", Offset = "0x17E6DC0", VA = "0x17EADC0")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x17EAE5C", Offset = "0x17E6E5C", VA = "0x17EAE5C")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x17EAEF8", Offset = "0x17E6EF8", VA = "0x17EAEF8")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x17EAF8C", Offset = "0x17E6F8C", VA = "0x17EAF8C")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x17EB018", Offset = "0x17E7018", VA = "0x17EB018")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x17EB0A4", Offset = "0x17E70A4", VA = "0x17EB0A4")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x17EB130", Offset = "0x17E7130", VA = "0x17EB130")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x17EB1C4", Offset = "0x17E71C4", VA = "0x17EB1C4")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x17EB264", Offset = "0x17E7264", VA = "0x17EB264")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x17EB2F8", Offset = "0x17E72F8", VA = "0x17EB2F8")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x17EB3DC", Offset = "0x17E73DC", VA = "0x17EB3DC")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x17EB480", Offset = "0x17E7480", VA = "0x17EB480")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x17EB53C", Offset = "0x17E753C", VA = "0x17EB53C")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x17EB5F8", Offset = "0x17E75F8", VA = "0x17EB5F8")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x17EB694", Offset = "0x17E7694", VA = "0x17EB694")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x17EB73C", Offset = "0x17E773C", VA = "0x17EB73C")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x17EB7E0", Offset = "0x17E77E0", VA = "0x17EB7E0")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x17EB898", Offset = "0x17E7898", VA = "0x17EB898")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x17EB934", Offset = "0x17E7934", VA = "0x17EB934")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x17EB9D0", Offset = "0x17E79D0", VA = "0x17EB9D0")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x17EBA6C", Offset = "0x17E7A6C", VA = "0x17EBA6C")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x17EBB20", Offset = "0x17E7B20", VA = "0x17EBB20")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x17EBBB8", Offset = "0x17E7BB8", VA = "0x17EBBB8")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x17EBC50", Offset = "0x17E7C50", VA = "0x17EBC50")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x17EBCDC", Offset = "0x17E7CDC", VA = "0x17EBCDC")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x17EBD68", Offset = "0x17E7D68", VA = "0x17EBD68")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x17EBE04", Offset = "0x17E7E04", VA = "0x17EBE04")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x17EBEA0", Offset = "0x17E7EA0", VA = "0x17EBEA0")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x17EBF3C", Offset = "0x17E7F3C", VA = "0x17EBF3C")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x17EBFD8", Offset = "0x17E7FD8", VA = "0x17EBFD8")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x17EC074", Offset = "0x17E8074", VA = "0x17EC074")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x17EC110", Offset = "0x17E8110", VA = "0x17EC110")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x17EC1BC", Offset = "0x17E81BC", VA = "0x17EC1BC")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x17EC260", Offset = "0x17E8260", VA = "0x17EC260")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x17EC2EC", Offset = "0x17E82EC", VA = "0x17EC2EC")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x17EC378", Offset = "0x17E8378", VA = "0x17EC378")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x17EC414", Offset = "0x17E8414", VA = "0x17EC414")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x17EC4B0", Offset = "0x17E84B0", VA = "0x17EC4B0")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x17EC54C", Offset = "0x17E854C", VA = "0x17EC54C")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x17EC5E8", Offset = "0x17E85E8", VA = "0x17EC5E8")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x17EC67C", Offset = "0x17E867C", VA = "0x17EC67C")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x17EC708", Offset = "0x17E8708", VA = "0x17EC708")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x17EC79C", Offset = "0x17E879C", VA = "0x17EC79C")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x17EC828", Offset = "0x17E8828", VA = "0x17EC828")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x17EC8BC", Offset = "0x17E88BC", VA = "0x17EC8BC")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x17EC948", Offset = "0x17E8948", VA = "0x17EC948")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x17EC9EC", Offset = "0x17E89EC", VA = "0x17EC9EC")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x17ECAA4", Offset = "0x17E8AA4", VA = "0x17ECAA4")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x17ECB30", Offset = "0x17E8B30", VA = "0x17ECB30")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x17ECBB4", Offset = "0x17E8BB4", VA = "0x17ECBB4")]
		public Channel(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x17ECBBC", Offset = "0x17E8BBC", VA = "0x17ECBBC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x17ECBCC", Offset = "0x17E8BCC", VA = "0x17ECBCC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x17ECBD4", Offset = "0x17E8BD4", VA = "0x17ECBD4")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x17ECC58", Offset = "0x17E8C58", VA = "0x17ECC58")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x17ECD00", Offset = "0x17E8D00", VA = "0x17ECD00")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x17ECDA4", Offset = "0x17E8DA4", VA = "0x17ECDA4")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x17ECE30", Offset = "0x17E8E30", VA = "0x17ECE30")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x17ECECC", Offset = "0x17E8ECC", VA = "0x17ECECC")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x17ECF58", Offset = "0x17E8F58", VA = "0x17ECF58")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x17ED1B4", Offset = "0x17E91B4", VA = "0x17ED1B4")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x17ED240", Offset = "0x17E9240", VA = "0x17ED240")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x17ED2DC", Offset = "0x17E92DC", VA = "0x17ED2DC", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x17ED368", Offset = "0x17E9368", VA = "0x17ED368", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x17ED3EC", Offset = "0x17E93EC", VA = "0x17ED3EC", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x17ED478", Offset = "0x17E9478", VA = "0x17ED478", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x17ED518", Offset = "0x17E9518", VA = "0x17ED518", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x17ED5AC", Offset = "0x17E95AC", VA = "0x17ED5AC", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x17ED638", Offset = "0x17E9638", VA = "0x17ED638", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x17ED6C4", Offset = "0x17E96C4", VA = "0x17ED6C4", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x17ED764", Offset = "0x17E9764", VA = "0x17ED764", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x17ED7F0", Offset = "0x17E97F0", VA = "0x17ED7F0", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x17ED884", Offset = "0x17E9884", VA = "0x17ED884", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x17ED910", Offset = "0x17E9910", VA = "0x17ED910", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x17ED99C", Offset = "0x17E999C", VA = "0x17ED99C", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x17EDA3C", Offset = "0x17E9A3C", VA = "0x17EDA3C", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x17EDAD8", Offset = "0x17E9AD8", VA = "0x17EDAD8", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x17EDB74", Offset = "0x17E9B74", VA = "0x17EDB74", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x17EDC08", Offset = "0x17E9C08", VA = "0x17EDC08", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x17EDC94", Offset = "0x17E9C94", VA = "0x17EDC94", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x17EDD20", Offset = "0x17E9D20", VA = "0x17EDD20", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x17EDDAC", Offset = "0x17E9DAC", VA = "0x17EDDAC", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x17EDE40", Offset = "0x17E9E40", VA = "0x17EDE40", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x17EDEE0", Offset = "0x17E9EE0", VA = "0x17EDEE0", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x17EDF74", Offset = "0x17E9F74", VA = "0x17EDF74", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x17EE058", Offset = "0x17EA058", VA = "0x17EE058", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x17EE0FC", Offset = "0x17EA0FC", VA = "0x17EE0FC", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x17EE1B8", Offset = "0x17EA1B8", VA = "0x17EE1B8", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x17EE274", Offset = "0x17EA274", VA = "0x17EE274", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x17EE310", Offset = "0x17EA310", VA = "0x17EE310", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x17EE3B4", Offset = "0x17EA3B4", VA = "0x17EE3B4", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x17EE45C", Offset = "0x17EA45C", VA = "0x17EE45C", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x17EE514", Offset = "0x17EA514", VA = "0x17EE514", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x17EE5B0", Offset = "0x17EA5B0", VA = "0x17EE5B0", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x17EE64C", Offset = "0x17EA64C", VA = "0x17EE64C", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x17EE6E8", Offset = "0x17EA6E8", VA = "0x17EE6E8", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x17EE798", Offset = "0x17EA798", VA = "0x17EE798", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x17EE834", Offset = "0x17EA834", VA = "0x17EE834", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x17EE8D0", Offset = "0x17EA8D0", VA = "0x17EE8D0", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x17EE95C", Offset = "0x17EA95C", VA = "0x17EE95C", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x17EE9E8", Offset = "0x17EA9E8", VA = "0x17EE9E8", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x17EEA84", Offset = "0x17EAA84", VA = "0x17EEA84", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x17EEB20", Offset = "0x17EAB20", VA = "0x17EEB20", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x17EEBBC", Offset = "0x17EABBC", VA = "0x17EEBBC", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x17EEC58", Offset = "0x17EAC58", VA = "0x17EEC58", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x17EECF4", Offset = "0x17EACF4", VA = "0x17EECF4", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x17EED90", Offset = "0x17EAD90", VA = "0x17EED90", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x17EEE3C", Offset = "0x17EAE3C", VA = "0x17EEE3C", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x17EEEE0", Offset = "0x17EAEE0", VA = "0x17EEEE0", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x17EEF6C", Offset = "0x17EAF6C", VA = "0x17EEF6C", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x17EEFF8", Offset = "0x17EAFF8", VA = "0x17EEFF8", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x17EF094", Offset = "0x17EB094", VA = "0x17EF094", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x17EF130", Offset = "0x17EB130", VA = "0x17EF130", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x17EF1CC", Offset = "0x17EB1CC", VA = "0x17EF1CC", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x17EF268", Offset = "0x17EB268", VA = "0x17EF268", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x17EF2FC", Offset = "0x17EB2FC", VA = "0x17EF2FC", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x17EF388", Offset = "0x17EB388", VA = "0x17EF388", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x17EF41C", Offset = "0x17EB41C", VA = "0x17EF41C", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x17EF4A8", Offset = "0x17EB4A8", VA = "0x17EF4A8", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x17EF53C", Offset = "0x17EB53C", VA = "0x17EF53C", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x17EF5C8", Offset = "0x17EB5C8", VA = "0x17EF5C8", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x17EF66C", Offset = "0x17EB66C", VA = "0x17EF66C", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x17EF724", Offset = "0x17EB724", VA = "0x17EF724", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x17EF7B0", Offset = "0x17EB7B0", VA = "0x17EF7B0", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x17ECBDC", Offset = "0x17E8BDC", VA = "0x17ECBDC")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x17ECC64", Offset = "0x17E8C64", VA = "0x17ECC64")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x17ECD08", Offset = "0x17E8D08", VA = "0x17ECD08")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x17ECDAC", Offset = "0x17E8DAC", VA = "0x17ECDAC")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x17ECE38", Offset = "0x17E8E38", VA = "0x17ECE38")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x17ECED4", Offset = "0x17E8ED4", VA = "0x17ECED4")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x17ED120", Offset = "0x17E9120", VA = "0x17ED120")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x17ED1BC", Offset = "0x17E91BC", VA = "0x17ED1BC")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x17ED248", Offset = "0x17E9248", VA = "0x17ED248")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x17ED2E4", Offset = "0x17E92E4", VA = "0x17ED2E4")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x17ED370", Offset = "0x17E9370", VA = "0x17ED370")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x17ED3F4", Offset = "0x17E93F4", VA = "0x17ED3F4")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x17ED480", Offset = "0x17E9480", VA = "0x17ED480")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x17ED520", Offset = "0x17E9520", VA = "0x17ED520")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x17ED5B4", Offset = "0x17E95B4", VA = "0x17ED5B4")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x17ED640", Offset = "0x17E9640", VA = "0x17ED640")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x17ED6CC", Offset = "0x17E96CC", VA = "0x17ED6CC")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x17ED76C", Offset = "0x17E976C", VA = "0x17ED76C")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x17ED7F8", Offset = "0x17E97F8", VA = "0x17ED7F8")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x17ED88C", Offset = "0x17E988C", VA = "0x17ED88C")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x17ED918", Offset = "0x17E9918", VA = "0x17ED918")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x17ED9A4", Offset = "0x17E99A4", VA = "0x17ED9A4")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x17EDA44", Offset = "0x17E9A44", VA = "0x17EDA44")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x17EDAE0", Offset = "0x17E9AE0", VA = "0x17EDAE0")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x17EDB7C", Offset = "0x17E9B7C", VA = "0x17EDB7C")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x17EDC10", Offset = "0x17E9C10", VA = "0x17EDC10")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x17EDC9C", Offset = "0x17E9C9C", VA = "0x17EDC9C")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x17EDD28", Offset = "0x17E9D28", VA = "0x17EDD28")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x17EDDB4", Offset = "0x17E9DB4", VA = "0x17EDDB4")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x17EDE48", Offset = "0x17E9E48", VA = "0x17EDE48")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x17EDEE8", Offset = "0x17E9EE8", VA = "0x17EDEE8")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x17EDF7C", Offset = "0x17E9F7C", VA = "0x17EDF7C")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x17EE060", Offset = "0x17EA060", VA = "0x17EE060")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x17EE104", Offset = "0x17EA104", VA = "0x17EE104")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x17EE1C0", Offset = "0x17EA1C0", VA = "0x17EE1C0")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x17EE27C", Offset = "0x17EA27C", VA = "0x17EE27C")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x17EE318", Offset = "0x17EA318", VA = "0x17EE318")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x17EE3C0", Offset = "0x17EA3C0", VA = "0x17EE3C0")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x17EE464", Offset = "0x17EA464", VA = "0x17EE464")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x17EE51C", Offset = "0x17EA51C", VA = "0x17EE51C")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x17EE5B8", Offset = "0x17EA5B8", VA = "0x17EE5B8")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x17EE654", Offset = "0x17EA654", VA = "0x17EE654")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x17EE6F0", Offset = "0x17EA6F0", VA = "0x17EE6F0")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x17EE7A0", Offset = "0x17EA7A0", VA = "0x17EE7A0")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x17EE83C", Offset = "0x17EA83C", VA = "0x17EE83C")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x17EE8D8", Offset = "0x17EA8D8", VA = "0x17EE8D8")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x17EE964", Offset = "0x17EA964", VA = "0x17EE964")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x17EE9F0", Offset = "0x17EA9F0", VA = "0x17EE9F0")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x17EEA8C", Offset = "0x17EAA8C", VA = "0x17EEA8C")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x17EEB28", Offset = "0x17EAB28", VA = "0x17EEB28")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x17EEBC4", Offset = "0x17EABC4", VA = "0x17EEBC4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x17EEC60", Offset = "0x17EAC60", VA = "0x17EEC60")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x17EECFC", Offset = "0x17EACFC", VA = "0x17EECFC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x17EED98", Offset = "0x17EAD98", VA = "0x17EED98")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x17EEE44", Offset = "0x17EAE44", VA = "0x17EEE44")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x17EEEE8", Offset = "0x17EAEE8", VA = "0x17EEEE8")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x17EEF74", Offset = "0x17EAF74", VA = "0x17EEF74")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x17EF000", Offset = "0x17EB000", VA = "0x17EF000")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x17EF09C", Offset = "0x17EB09C", VA = "0x17EF09C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x17EF138", Offset = "0x17EB138", VA = "0x17EF138")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x17EF1D4", Offset = "0x17EB1D4", VA = "0x17EF1D4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x17EF270", Offset = "0x17EB270", VA = "0x17EF270")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x17EF304", Offset = "0x17EB304", VA = "0x17EF304")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x17EF390", Offset = "0x17EB390", VA = "0x17EF390")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x17EF424", Offset = "0x17EB424", VA = "0x17EF424")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x17EF4B0", Offset = "0x17EB4B0", VA = "0x17EF4B0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x17EF544", Offset = "0x17EB544", VA = "0x17EF544")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x17EF5D0", Offset = "0x17EB5D0", VA = "0x17EF5D0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x17EF674", Offset = "0x17EB674", VA = "0x17EF674")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x17EF72C", Offset = "0x17EB72C", VA = "0x17EF72C")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x17EF7B8", Offset = "0x17EB7B8", VA = "0x17EF7B8")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x17EF83C", Offset = "0x17EB83C", VA = "0x17EF83C")]
		public ChannelGroup(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x17EF844", Offset = "0x17EB844", VA = "0x17EF844")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x17EF854", Offset = "0x17EB854", VA = "0x17EF854")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public struct SoundGroup
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x17EF85C", Offset = "0x17EB85C", VA = "0x17EF85C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x17EF8E0", Offset = "0x17EB8E0", VA = "0x17EF8E0")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x17EF96C", Offset = "0x17EB96C", VA = "0x17EF96C")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x17EF9F8", Offset = "0x17EB9F8", VA = "0x17EF9F8")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x17EFA84", Offset = "0x17EBA84", VA = "0x17EFA84")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x17EFB10", Offset = "0x17EBB10", VA = "0x17EFB10")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x17EFB9C", Offset = "0x17EBB9C", VA = "0x17EFB9C")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x17EFC30", Offset = "0x17EBC30", VA = "0x17EFC30")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x17EFCBC", Offset = "0x17EBCBC", VA = "0x17EFCBC")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x17EFD50", Offset = "0x17EBD50", VA = "0x17EFD50")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x17EFDDC", Offset = "0x17EBDDC", VA = "0x17EFDDC")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x17EFE60", Offset = "0x17EBE60", VA = "0x17EFE60")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x17F00BC", Offset = "0x17EC0BC", VA = "0x17F00BC")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x17F0148", Offset = "0x17EC148", VA = "0x17F0148")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x17F01E4", Offset = "0x17EC1E4", VA = "0x17F01E4")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x17F0270", Offset = "0x17EC270", VA = "0x17F0270")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x17F02FC", Offset = "0x17EC2FC", VA = "0x17F02FC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x17EF864", Offset = "0x17EB864", VA = "0x17EF864")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x17EF8E8", Offset = "0x17EB8E8", VA = "0x17EF8E8")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x17EF974", Offset = "0x17EB974", VA = "0x17EF974")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x17EFA00", Offset = "0x17EBA00", VA = "0x17EFA00")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x17EFA8C", Offset = "0x17EBA8C", VA = "0x17EFA8C")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x17EFB18", Offset = "0x17EBB18", VA = "0x17EFB18")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x17EFBA4", Offset = "0x17EBBA4", VA = "0x17EFBA4")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x17EFC38", Offset = "0x17EBC38", VA = "0x17EFC38")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x17EFCC4", Offset = "0x17EBCC4", VA = "0x17EFCC4")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x17EFD58", Offset = "0x17EBD58", VA = "0x17EFD58")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x17EFDE4", Offset = "0x17EBDE4", VA = "0x17EFDE4")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x17F0028", Offset = "0x17EC028", VA = "0x17F0028")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x17F00C4", Offset = "0x17EC0C4", VA = "0x17F00C4")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x17F0150", Offset = "0x17EC150", VA = "0x17F0150")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x17F01EC", Offset = "0x17EC1EC", VA = "0x17F01EC")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x17F0278", Offset = "0x17EC278", VA = "0x17F0278")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x17F0304", Offset = "0x17EC304", VA = "0x17F0304")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x17F0388", Offset = "0x17EC388", VA = "0x17F0388")]
		public SoundGroup(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x17F0390", Offset = "0x17EC390", VA = "0x17F0390")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x17F03A0", Offset = "0x17EC3A0", VA = "0x17F03A0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public struct DSP
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x17F03A8", Offset = "0x17EC3A8", VA = "0x17F03A8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x17F042C", Offset = "0x17EC42C", VA = "0x17F042C")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x17F04B8", Offset = "0x17EC4B8", VA = "0x17F04B8")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x17F0564", Offset = "0x17EC564", VA = "0x17F0564")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x17F0608", Offset = "0x17EC608", VA = "0x17F0608")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x17F06A0", Offset = "0x17EC6A0", VA = "0x17F06A0")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x17F073C", Offset = "0x17EC73C", VA = "0x17F073C")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x17F07C8", Offset = "0x17EC7C8", VA = "0x17F07C8")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x17F0854", Offset = "0x17EC854", VA = "0x17F0854")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x17F08F8", Offset = "0x17EC8F8", VA = "0x17F08F8")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x17F099C", Offset = "0x17EC99C", VA = "0x17F099C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x17F0A28", Offset = "0x17ECA28", VA = "0x17F0A28")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x17F0AC8", Offset = "0x17ECAC8", VA = "0x17F0AC8")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x17F0B54", Offset = "0x17ECB54", VA = "0x17F0B54")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x17F0BF4", Offset = "0x17ECBF4", VA = "0x17F0BF4")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x17F0CA0", Offset = "0x17ECCA0", VA = "0x17F0CA0")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x17F0D44", Offset = "0x17ECD44", VA = "0x17F0D44")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x17F0DE8", Offset = "0x17ECDE8", VA = "0x17F0DE8")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x17F0E8C", Offset = "0x17ECE8C", VA = "0x17F0E8C")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x17F0F58", Offset = "0x17ECF58", VA = "0x17F0F58")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x17F0FDC", Offset = "0x17ECFDC", VA = "0x17F0FDC")]
		public RESULT setCallback(DSP_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x17F1070", Offset = "0x17ED070", VA = "0x17F1070")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x17F110C", Offset = "0x17ED10C", VA = "0x17F110C")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x17F11A8", Offset = "0x17ED1A8", VA = "0x17F11A8")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x17F1244", Offset = "0x17ED244", VA = "0x17F1244")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x17F1300", Offset = "0x17ED300", VA = "0x17F1300")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x17F13BC", Offset = "0x17ED3BC", VA = "0x17F13BC")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x17F1478", Offset = "0x17ED478", VA = "0x17F1478")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x17F1548", Offset = "0x17ED548", VA = "0x17F1548")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x17F160C", Offset = "0x17ED60C", VA = "0x17F160C")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x17F1698", Offset = "0x17ED698", VA = "0x17F1698")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x17F17EC", Offset = "0x17ED7EC", VA = "0x17F17EC")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x17F1888", Offset = "0x17ED888", VA = "0x17F1888")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x17F1924", Offset = "0x17ED924", VA = "0x17F1924")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x17F1BC8", Offset = "0x17EDBC8", VA = "0x17F1BC8")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x17F1BE4", Offset = "0x17EDBE4", VA = "0x17F1BE4")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x17F1C70", Offset = "0x17EDC70", VA = "0x17F1C70")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x17F1D10", Offset = "0x17EDD10", VA = "0x17F1D10")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x17F1D9C", Offset = "0x17EDD9C", VA = "0x17F1D9C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x17F1E28", Offset = "0x17EDE28", VA = "0x17F1E28")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x17F1EC4", Offset = "0x17EDEC4", VA = "0x17F1EC4")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x17F1F88", Offset = "0x17EDF88", VA = "0x17F1F88")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x17F2060", Offset = "0x17EE060", VA = "0x17F2060")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x17F2138", Offset = "0x17EE138", VA = "0x17F2138")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x17F223C", Offset = "0x17EE23C", VA = "0x17F223C")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x17F03B0", Offset = "0x17EC3B0", VA = "0x17F03B0")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x17F0434", Offset = "0x17EC434", VA = "0x17F0434")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x17F04C8", Offset = "0x17EC4C8", VA = "0x17F04C8")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x17F056C", Offset = "0x17EC56C", VA = "0x17F056C")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x17F0610", Offset = "0x17EC610", VA = "0x17F0610")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x17F06A8", Offset = "0x17EC6A8", VA = "0x17F06A8")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x17F0744", Offset = "0x17EC744", VA = "0x17F0744")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x17F07D0", Offset = "0x17EC7D0", VA = "0x17F07D0")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x17F085C", Offset = "0x17EC85C", VA = "0x17F085C")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x17F0900", Offset = "0x17EC900", VA = "0x17F0900")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x17F09A4", Offset = "0x17EC9A4", VA = "0x17F09A4")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x17F0A30", Offset = "0x17ECA30", VA = "0x17F0A30")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x17F0AD0", Offset = "0x17ECAD0", VA = "0x17F0AD0")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x17F0B5C", Offset = "0x17ECB5C", VA = "0x17F0B5C")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x17F0BFC", Offset = "0x17ECBFC", VA = "0x17F0BFC")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x17F0CA8", Offset = "0x17ECCA8", VA = "0x17F0CA8")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x17F0D4C", Offset = "0x17ECD4C", VA = "0x17F0D4C")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x17F0DF0", Offset = "0x17ECDF0", VA = "0x17F0DF0")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x17F0E94", Offset = "0x17ECE94", VA = "0x17F0E94")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x17F0F60", Offset = "0x17ECF60", VA = "0x17F0F60")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x17F0FE4", Offset = "0x17ECFE4", VA = "0x17F0FE4")]
		private static extern RESULT FMOD5_DSP_SetCallback(IntPtr dsp, DSP_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x17F1078", Offset = "0x17ED078", VA = "0x17F1078")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x17F1114", Offset = "0x17ED114", VA = "0x17F1114")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x17F11B0", Offset = "0x17ED1B0", VA = "0x17F11B0")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x17F125C", Offset = "0x17ED25C", VA = "0x17F125C")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, byte[] data, uint length);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x17F1310", Offset = "0x17ED310", VA = "0x17F1310")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x17F13CC", Offset = "0x17ED3CC", VA = "0x17F13CC")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x17F1488", Offset = "0x17ED488", VA = "0x17F1488")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x17F1558", Offset = "0x17ED558", VA = "0x17F1558")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x17F1614", Offset = "0x17ED614", VA = "0x17F1614")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x17F1758", Offset = "0x17ED758", VA = "0x17F1758")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x17F17F4", Offset = "0x17ED7F4", VA = "0x17F17F4")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x17F1890", Offset = "0x17ED890", VA = "0x17F1890")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x17F1B14", Offset = "0x17EDB14", VA = "0x17F1B14")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x17F1BEC", Offset = "0x17EDBEC", VA = "0x17F1BEC")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x17F1C78", Offset = "0x17EDC78", VA = "0x17F1C78")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x17F1D18", Offset = "0x17EDD18", VA = "0x17F1D18")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x17F1DA4", Offset = "0x17EDDA4", VA = "0x17F1DA4")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x17F1E30", Offset = "0x17EDE30", VA = "0x17F1E30")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x17F1ECC", Offset = "0x17EDECC", VA = "0x17F1ECC")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x17F1F90", Offset = "0x17EDF90", VA = "0x17F1F90")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x17F2068", Offset = "0x17EE068", VA = "0x17F2068")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x17F2140", Offset = "0x17EE140", VA = "0x17F2140")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x17F2244", Offset = "0x17EE244", VA = "0x17F2244")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x17F22D8", Offset = "0x17EE2D8", VA = "0x17F22D8")]
		public DSP(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x17F22E0", Offset = "0x17EE2E0", VA = "0x17F22E0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x17F22F0", Offset = "0x17EE2F0", VA = "0x17F22F0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public struct DSPConnection
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x17F22F8", Offset = "0x17EE2F8", VA = "0x17F22F8")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x17F2384", Offset = "0x17EE384", VA = "0x17F2384")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x17F2410", Offset = "0x17EE410", VA = "0x17F2410")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x17F24A4", Offset = "0x17EE4A4", VA = "0x17F24A4")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x17F2530", Offset = "0x17EE530", VA = "0x17F2530")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x17F25EC", Offset = "0x17EE5EC", VA = "0x17F25EC")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x17F26A8", Offset = "0x17EE6A8", VA = "0x17F26A8")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x17F2734", Offset = "0x17EE734", VA = "0x17F2734")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x17F27C0", Offset = "0x17EE7C0", VA = "0x17F27C0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x17F2300", Offset = "0x17EE300", VA = "0x17F2300")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x17F238C", Offset = "0x17EE38C", VA = "0x17F238C")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x17F2418", Offset = "0x17EE418", VA = "0x17F2418")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x17F24AC", Offset = "0x17EE4AC", VA = "0x17F24AC")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x17F2538", Offset = "0x17EE538", VA = "0x17F2538")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x17F25F4", Offset = "0x17EE5F4", VA = "0x17F25F4")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x17F26B0", Offset = "0x17EE6B0", VA = "0x17F26B0")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x17F273C", Offset = "0x17EE73C", VA = "0x17F273C")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x17F27C8", Offset = "0x17EE7C8", VA = "0x17F27C8")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x17F284C", Offset = "0x17EE84C", VA = "0x17F284C")]
		public DSPConnection(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x17F2854", Offset = "0x17EE854", VA = "0x17F2854")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x17F2864", Offset = "0x17EE864", VA = "0x17F2864")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public struct Geometry
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x17F286C", Offset = "0x17EE86C", VA = "0x17F286C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x17F28F0", Offset = "0x17EE8F0", VA = "0x17F28F0")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x17F29C4", Offset = "0x17EE9C4", VA = "0x17F29C4")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x17F2A50", Offset = "0x17EEA50", VA = "0x17F2A50")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x17F2AEC", Offset = "0x17EEAEC", VA = "0x17F2AEC")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x17F2B88", Offset = "0x17EEB88", VA = "0x17F2B88")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x17F2C2C", Offset = "0x17EEC2C", VA = "0x17F2C2C")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x17F2CD0", Offset = "0x17EECD0", VA = "0x17F2CD0")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x17F2D84", Offset = "0x17EED84", VA = "0x17F2D84")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x17F2E4C", Offset = "0x17EEE4C", VA = "0x17F2E4C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x17F2ED8", Offset = "0x17EEED8", VA = "0x17F2ED8")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x17F2F78", Offset = "0x17EEF78", VA = "0x17F2F78")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x17F3014", Offset = "0x17EF014", VA = "0x17F3014")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x17F30B0", Offset = "0x17EF0B0", VA = "0x17F30B0")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x17F313C", Offset = "0x17EF13C", VA = "0x17F313C")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x17F31C8", Offset = "0x17EF1C8", VA = "0x17F31C8")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x17F3254", Offset = "0x17EF254", VA = "0x17F3254")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x17F32E0", Offset = "0x17EF2E0", VA = "0x17F32E0")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x17F337C", Offset = "0x17EF37C", VA = "0x17F337C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x17F3408", Offset = "0x17EF408", VA = "0x17F3408")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x17F2874", Offset = "0x17EE874", VA = "0x17F2874")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x17F28F8", Offset = "0x17EE8F8", VA = "0x17F28F8")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x17F29CC", Offset = "0x17EE9CC", VA = "0x17F29CC")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x17F2A58", Offset = "0x17EEA58", VA = "0x17F2A58")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x17F2AF4", Offset = "0x17EEAF4", VA = "0x17F2AF4")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x17F2B90", Offset = "0x17EEB90", VA = "0x17F2B90")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x17F2C34", Offset = "0x17EEC34", VA = "0x17F2C34")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x17F2CD8", Offset = "0x17EECD8", VA = "0x17F2CD8")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x17F2D8C", Offset = "0x17EED8C", VA = "0x17F2D8C")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x17F2E54", Offset = "0x17EEE54", VA = "0x17F2E54")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x17F2EE0", Offset = "0x17EEEE0", VA = "0x17F2EE0")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x17F2F80", Offset = "0x17EEF80", VA = "0x17F2F80")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x17F301C", Offset = "0x17EF01C", VA = "0x17F301C")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x17F30B8", Offset = "0x17EF0B8", VA = "0x17F30B8")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x17F3144", Offset = "0x17EF144", VA = "0x17F3144")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x17F31D0", Offset = "0x17EF1D0", VA = "0x17F31D0")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x17F325C", Offset = "0x17EF25C", VA = "0x17F325C")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x17F32E8", Offset = "0x17EF2E8", VA = "0x17F32E8")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x17F3384", Offset = "0x17EF384", VA = "0x17F3384")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x17F3410", Offset = "0x17EF410", VA = "0x17F3410")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x17F3494", Offset = "0x17EF494", VA = "0x17F3494")]
		public Geometry(IntPtr ptr)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x17F349C", Offset = "0x17EF49C", VA = "0x17F349C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x17F34AC", Offset = "0x17EF4AC", VA = "0x17F34AC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public struct Reverb3D
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x17F34B4", Offset = "0x17EF4B4", VA = "0x17F34B4")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x17F3538", Offset = "0x17EF538", VA = "0x17F3538")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x17F35DC", Offset = "0x17EF5DC", VA = "0x17F35DC")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x17F3680", Offset = "0x17EF680", VA = "0x17F3680")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x17F370C", Offset = "0x17EF70C", VA = "0x17F370C")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x17F3798", Offset = "0x17EF798", VA = "0x17F3798")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x17F3824", Offset = "0x17EF824", VA = "0x17F3824")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x17F38C4", Offset = "0x17EF8C4", VA = "0x17F38C4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x17F3950", Offset = "0x17EF950", VA = "0x17F3950")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x17F34BC", Offset = "0x17EF4BC", VA = "0x17F34BC")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x17F3540", Offset = "0x17EF540", VA = "0x17F3540")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x17F35E4", Offset = "0x17EF5E4", VA = "0x17F35E4")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x17F3688", Offset = "0x17EF688", VA = "0x17F3688")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x17F3714", Offset = "0x17EF714", VA = "0x17F3714")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x17F37A0", Offset = "0x17EF7A0", VA = "0x17F37A0")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x17F382C", Offset = "0x17EF82C", VA = "0x17F382C")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x17F38CC", Offset = "0x17EF8CC", VA = "0x17F38CC")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x17F3958", Offset = "0x17EF958", VA = "0x17F3958")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x17F39DC", Offset = "0x17EF9DC", VA = "0x17F39DC")]
		public Reverb3D(IntPtr ptr)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x17F39E4", Offset = "0x17EF9E4", VA = "0x17F39E4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x17F39F4", Offset = "0x17EF9F4", VA = "0x17F39F4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public struct StringWrapper
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x17F39FC", Offset = "0x17EF9FC", VA = "0x17F39FC")]
		public StringWrapper(IntPtr ptr)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x17F3A04", Offset = "0x17EFA04", VA = "0x17F3A04")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x17F3B54", Offset = "0x17EFB54", VA = "0x17F3B54")]
		public bool StartsWith(byte[] prefix)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x17F3C40", Offset = "0x17EFC40", VA = "0x17F3C40")]
		public bool Equals(byte[] comparison)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B5")]
	internal static class StringHelper
	{
		[Token(Token = "0x20000B6")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GCHandle gcHandle;

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x17F3EA0", Offset = "0x17EFEA0", VA = "0x17F3EA0")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x17F3E04", Offset = "0x17EFE04", VA = "0x17F3E04")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x17F3EA8", Offset = "0x17EFEA8", VA = "0x17F3EA8")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x17E8888", Offset = "0x17E4888", VA = "0x17E8888")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x17F3EC0", Offset = "0x17EFEC0", VA = "0x17F3EC0")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x17E8278", Offset = "0x17E4278", VA = "0x17E8278")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x17F3EF8", Offset = "0x17EFEF8", VA = "0x17F3EF8", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x17F3D4C", Offset = "0x17EFD4C", VA = "0x17F3D4C")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x17E7FB4", Offset = "0x17E3FB4", VA = "0x17E7FB4")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr buffernumchannels;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr bufferchannelmask;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr buffers;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;

		[Token(Token = "0x17000064")]
		public int numchannels
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x17F400C", Offset = "0x17F000C", VA = "0x17F400C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x17F4094", Offset = "0x17F0094", VA = "0x17F4094")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public IntPtr buffer
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x17F4120", Offset = "0x17F0120", VA = "0x17F4120")]
			get
			{
				return default(IntPtr);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x17F41A8", Offset = "0x17F01A8", VA = "0x17F41A8")]
			set
			{
			}
		}
	}
	[Token(Token = "0x20000B8")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x4000417")]
		PROCESS_PERFORM,
		[Token(Token = "0x4000418")]
		PROCESS_QUERY
	}
	[Token(Token = "0x20000B9")]
	public struct COMPLEX
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x20000BA")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x400041C")]
		DEFAULT,
		[Token(Token = "0x400041D")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x20000BB")]
	public delegate RESULT DSP_CREATE_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000BC")]
	public delegate RESULT DSP_RELEASE_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000BD")]
	public delegate RESULT DSP_RESET_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000BE")]
	public delegate RESULT DSP_SETPOSITION_CALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x20000BF")]
	public delegate RESULT DSP_READ_CALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x20000C0")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x20000C1")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x20000C2")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x20000C3")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x20000C4")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x20000C5")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x20000C6")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x20000C7")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x20000C8")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x20000C9")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x20000CA")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000CB")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000CC")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x20000CD")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, IntPtr sourcestr);
	[Token(Token = "0x20000CE")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, IntPtr sourcestr);
	[Token(Token = "0x20000CF")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, IntPtr sourcestr);
	[Token(Token = "0x20000D0")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, IntPtr file, int line, IntPtr function, IntPtr str);
	[Token(Token = "0x20000D1")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x20000D2")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x20000D3")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x20000D4")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x20000D5")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x20000D6")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x20000D7")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x20000D8")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x20000D9")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x20000DA")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000DB")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x20000DC")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000DD")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000DE")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x20000DF")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x400041F")]
		UNKNOWN,
		[Token(Token = "0x4000420")]
		MIXER,
		[Token(Token = "0x4000421")]
		OSCILLATOR,
		[Token(Token = "0x4000422")]
		LOWPASS,
		[Token(Token = "0x4000423")]
		ITLOWPASS,
		[Token(Token = "0x4000424")]
		HIGHPASS,
		[Token(Token = "0x4000425")]
		ECHO,
		[Token(Token = "0x4000426")]
		FADER,
		[Token(Token = "0x4000427")]
		FLANGE,
		[Token(Token = "0x4000428")]
		DISTORTION,
		[Token(Token = "0x4000429")]
		NORMALIZE,
		[Token(Token = "0x400042A")]
		LIMITER,
		[Token(Token = "0x400042B")]
		PARAMEQ,
		[Token(Token = "0x400042C")]
		PITCHSHIFT,
		[Token(Token = "0x400042D")]
		CHORUS,
		[Token(Token = "0x400042E")]
		VSTPLUGIN,
		[Token(Token = "0x400042F")]
		WINAMPPLUGIN,
		[Token(Token = "0x4000430")]
		ITECHO,
		[Token(Token = "0x4000431")]
		COMPRESSOR,
		[Token(Token = "0x4000432")]
		SFXREVERB,
		[Token(Token = "0x4000433")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x4000434")]
		DELAY,
		[Token(Token = "0x4000435")]
		TREMOLO,
		[Token(Token = "0x4000436")]
		LADSPAPLUGIN,
		[Token(Token = "0x4000437")]
		SEND,
		[Token(Token = "0x4000438")]
		RETURN,
		[Token(Token = "0x4000439")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x400043A")]
		PAN,
		[Token(Token = "0x400043B")]
		THREE_EQ,
		[Token(Token = "0x400043C")]
		FFT,
		[Token(Token = "0x400043D")]
		LOUDNESS_METER,
		[Token(Token = "0x400043E")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x400043F")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x4000440")]
		CHANNELMIX,
		[Token(Token = "0x4000441")]
		TRANSCEIVER,
		[Token(Token = "0x4000442")]
		OBJECTPAN,
		[Token(Token = "0x4000443")]
		MULTIBAND_EQ,
		[Token(Token = "0x4000444")]
		MAX
	}
	[Token(Token = "0x20000E0")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x4000446")]
		FLOAT,
		[Token(Token = "0x4000447")]
		INT,
		[Token(Token = "0x4000448")]
		BOOL,
		[Token(Token = "0x4000449")]
		DATA,
		[Token(Token = "0x400044A")]
		MAX
	}
	[Token(Token = "0x20000E1")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x400044C")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x400044D")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x400044E")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x20000E2")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x20000E3")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x20000E4")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x20000E5")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000E6")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000E7")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000E8")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x20000E9")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] name;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] label;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x20000EA")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x400046A")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x400046B")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x400046C")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x400046D")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x400046E")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x400046F")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5,
		[Token(Token = "0x4000470")]
		DSP_PARAMETER_DATA_TYPE_ATTENUATION_RANGE = -6
	}
	[Token(Token = "0x20000EB")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x20000EC")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000ED")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000EE")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x20000EF")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x17000066")]
		public float[][] spectrum
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x17F8574", Offset = "0x17F4574", VA = "0x17F8574")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x17F86A0", Offset = "0x17F46A0", VA = "0x17F86A0")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x17F8768", Offset = "0x17F4768", VA = "0x17F8768")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public struct DSP_LOUDNESS_METER_INFO_TYPE
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float momentaryloudness;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float shorttermloudness;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float integratedloudness;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float loudness10thpercentile;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float loudness95thpercentile;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] loudnesshistogram;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxtruepeak;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxmomentaryloudness;
	}
	[Token(Token = "0x20000F1")]
	public struct DSP_LOUDNESS_METER_WEIGHTING_TYPE
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float[] channelweight;
	}
	[Token(Token = "0x20000F2")]
	public struct DSP_PARAMETER_ATTENUATION_RANGE
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;
	}
	[Token(Token = "0x20000F3")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] name;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATE_CALLBACK create;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASE_CALLBACK release;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESET_CALLBACK reset;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READ_CALLBACK read;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITION_CALLBACK setposition;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x20000F4")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x20000F5")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x20000F6")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_FREE_FUNC free;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr dft;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr pan;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DSP_LOG_FUNC log;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x20000F7")]
	public struct DSP_STATE
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x20000F8")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x20000F9")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x40004C3")]
		TYPE,
		[Token(Token = "0x40004C4")]
		RATE
	}
	[Token(Token = "0x20000FA")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x40004C6")]
		CUTOFF,
		[Token(Token = "0x40004C7")]
		RESONANCE
	}
	[Token(Token = "0x20000FB")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x40004C9")]
		CUTOFF,
		[Token(Token = "0x40004CA")]
		RESONANCE
	}
	[Token(Token = "0x20000FC")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x40004CC")]
		CUTOFF,
		[Token(Token = "0x40004CD")]
		RESONANCE
	}
	[Token(Token = "0x20000FD")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x40004CF")]
		DELAY,
		[Token(Token = "0x40004D0")]
		FEEDBACK,
		[Token(Token = "0x40004D1")]
		DRYLEVEL,
		[Token(Token = "0x40004D2")]
		WETLEVEL
	}
	[Token(Token = "0x20000FE")]
	public enum DSP_FADER
	{
		[Token(Token = "0x40004D4")]
		GAIN,
		[Token(Token = "0x40004D5")]
		OVERALL_GAIN
	}
	[Token(Token = "0x20000FF")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x40004D7")]
		CH0,
		[Token(Token = "0x40004D8")]
		CH1,
		[Token(Token = "0x40004D9")]
		CH2,
		[Token(Token = "0x40004DA")]
		CH3,
		[Token(Token = "0x40004DB")]
		CH4,
		[Token(Token = "0x40004DC")]
		CH5,
		[Token(Token = "0x40004DD")]
		CH6,
		[Token(Token = "0x40004DE")]
		CH7,
		[Token(Token = "0x40004DF")]
		CH8,
		[Token(Token = "0x40004E0")]
		CH9,
		[Token(Token = "0x40004E1")]
		CH10,
		[Token(Token = "0x40004E2")]
		CH11,
		[Token(Token = "0x40004E3")]
		CH12,
		[Token(Token = "0x40004E4")]
		CH13,
		[Token(Token = "0x40004E5")]
		CH14,
		[Token(Token = "0x40004E6")]
		CH15,
		[Token(Token = "0x40004E7")]
		MAXDELAY
	}
	[Token(Token = "0x2000100")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x40004E9")]
		MIX,
		[Token(Token = "0x40004EA")]
		DEPTH,
		[Token(Token = "0x40004EB")]
		RATE
	}
	[Token(Token = "0x2000101")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x40004ED")]
		FREQUENCY,
		[Token(Token = "0x40004EE")]
		DEPTH,
		[Token(Token = "0x40004EF")]
		SHAPE,
		[Token(Token = "0x40004F0")]
		SKEW,
		[Token(Token = "0x40004F1")]
		DUTY,
		[Token(Token = "0x40004F2")]
		SQUARE,
		[Token(Token = "0x40004F3")]
		PHASE,
		[Token(Token = "0x40004F4")]
		SPREAD
	}
	[Token(Token = "0x2000102")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x40004F6")]
		LEVEL
	}
	[Token(Token = "0x2000103")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x40004F8")]
		FADETIME,
		[Token(Token = "0x40004F9")]
		THRESHOLD,
		[Token(Token = "0x40004FA")]
		MAXAMP
	}
	[Token(Token = "0x2000104")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x40004FC")]
		RELEASETIME,
		[Token(Token = "0x40004FD")]
		CEILING,
		[Token(Token = "0x40004FE")]
		MAXIMIZERGAIN,
		[Token(Token = "0x40004FF")]
		MODE
	}
	[Token(Token = "0x2000105")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x4000501")]
		CENTER,
		[Token(Token = "0x4000502")]
		BANDWIDTH,
		[Token(Token = "0x4000503")]
		GAIN
	}
	[Token(Token = "0x2000106")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x4000505")]
		A_FILTER,
		[Token(Token = "0x4000506")]
		A_FREQUENCY,
		[Token(Token = "0x4000507")]
		A_Q,
		[Token(Token = "0x4000508")]
		A_GAIN,
		[Token(Token = "0x4000509")]
		B_FILTER,
		[Token(Token = "0x400050A")]
		B_FREQUENCY,
		[Token(Token = "0x400050B")]
		B_Q,
		[Token(Token = "0x400050C")]
		B_GAIN,
		[Token(Token = "0x400050D")]
		C_FILTER,
		[Token(Token = "0x400050E")]
		C_FREQUENCY,
		[Token(Token = "0x400050F")]
		C_Q,
		[Token(Token = "0x4000510")]
		C_GAIN,
		[Token(Token = "0x4000511")]
		D_FILTER,
		[Token(Token = "0x4000512")]
		D_FREQUENCY,
		[Token(Token = "0x4000513")]
		D_Q,
		[Token(Token = "0x4000514")]
		D_GAIN,
		[Token(Token = "0x4000515")]
		E_FILTER,
		[Token(Token = "0x4000516")]
		E_FREQUENCY,
		[Token(Token = "0x4000517")]
		E_Q,
		[Token(Token = "0x4000518")]
		E_GAIN
	}
	[Token(Token = "0x2000107")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x400051A")]
		DISABLED,
		[Token(Token = "0x400051B")]
		LOWPASS_12DB,
		[Token(Token = "0x400051C")]
		LOWPASS_24DB,
		[Token(Token = "0x400051D")]
		LOWPASS_48DB,
		[Token(Token = "0x400051E")]
		HIGHPASS_12DB,
		[Token(Token = "0x400051F")]
		HIGHPASS_24DB,
		[Token(Token = "0x4000520")]
		HIGHPASS_48DB,
		[Token(Token = "0x4000521")]
		LOWSHELF,
		[Token(Token = "0x4000522")]
		HIGHSHELF,
		[Token(Token = "0x4000523")]
		PEAKING,
		[Token(Token = "0x4000524")]
		BANDPASS,
		[Token(Token = "0x4000525")]
		NOTCH,
		[Token(Token = "0x4000526")]
		ALLPASS
	}
	[Token(Token = "0x2000108")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x4000528")]
		PITCH,
		[Token(Token = "0x4000529")]
		FFTSIZE,
		[Token(Token = "0x400052A")]
		OVERLAP,
		[Token(Token = "0x400052B")]
		MAXCHANNELS
	}
	[Token(Token = "0x2000109")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x400052D")]
		MIX,
		[Token(Token = "0x400052E")]
		RATE,
		[Token(Token = "0x400052F")]
		DEPTH
	}
	[Token(Token = "0x200010A")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x4000531")]
		WETDRYMIX,
		[Token(Token = "0x4000532")]
		FEEDBACK,
		[Token(Token = "0x4000533")]
		LEFTDELAY,
		[Token(Token = "0x4000534")]
		RIGHTDELAY,
		[Token(Token = "0x4000535")]
		PANDELAY
	}
	[Token(Token = "0x200010B")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x4000537")]
		THRESHOLD,
		[Token(Token = "0x4000538")]
		RATIO,
		[Token(Token = "0x4000539")]
		ATTACK,
		[Token(Token = "0x400053A")]
		RELEASE,
		[Token(Token = "0x400053B")]
		GAINMAKEUP,
		[Token(Token = "0x400053C")]
		USESIDECHAIN,
		[Token(Token = "0x400053D")]
		LINKED
	}
	[Token(Token = "0x200010C")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x400053F")]
		DECAYTIME,
		[Token(Token = "0x4000540")]
		EARLYDELAY,
		[Token(Token = "0x4000541")]
		LATEDELAY,
		[Token(Token = "0x4000542")]
		HFREFERENCE,
		[Token(Token = "0x4000543")]
		HFDECAYRATIO,
		[Token(Token = "0x4000544")]
		DIFFUSION,
		[Token(Token = "0x4000545")]
		DENSITY,
		[Token(Token = "0x4000546")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x4000547")]
		LOWSHELFGAIN,
		[Token(Token = "0x4000548")]
		HIGHCUT,
		[Token(Token = "0x4000549")]
		EARLYLATEMIX,
		[Token(Token = "0x400054A")]
		WETLEVEL,
		[Token(Token = "0x400054B")]
		DRYLEVEL
	}
	[Token(Token = "0x200010D")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x400054D")]
		CUTOFF
	}
	[Token(Token = "0x200010E")]
	public enum DSP_SEND
	{
		[Token(Token = "0x400054F")]
		RETURNID,
		[Token(Token = "0x4000550")]
		LEVEL
	}
	[Token(Token = "0x200010F")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x4000552")]
		ID,
		[Token(Token = "0x4000553")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x2000110")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x4000555")]
		CUTOFF
	}
	[Token(Token = "0x2000111")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x4000557")]
		DISTRIBUTED,
		[Token(Token = "0x4000558")]
		DISCRETE
	}
	[Token(Token = "0x2000112")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x400055A")]
		MONO,
		[Token(Token = "0x400055B")]
		STEREO,
		[Token(Token = "0x400055C")]
		SURROUND
	}
	[Token(Token = "0x2000113")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x400055E")]
		LINEARSQUARED,
		[Token(Token = "0x400055F")]
		LINEAR,
		[Token(Token = "0x4000560")]
		INVERSE,
		[Token(Token = "0x4000561")]
		INVERSETAPERED,
		[Token(Token = "0x4000562")]
		CUSTOM
	}
	[Token(Token = "0x2000114")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x4000564")]
		AUTO,
		[Token(Token = "0x4000565")]
		USER,
		[Token(Token = "0x4000566")]
		OFF
	}
	[Token(Token = "0x2000115")]
	public enum DSP_PAN
	{
		[Token(Token = "0x4000568")]
		MODE,
		[Token(Token = "0x4000569")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x400056A")]
		_2D_DIRECTION,
		[Token(Token = "0x400056B")]
		_2D_EXTENT,
		[Token(Token = "0x400056C")]
		_2D_ROTATION,
		[Token(Token = "0x400056D")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x400056E")]
		_2D_STEREO_MODE,
		[Token(Token = "0x400056F")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x4000570")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x4000571")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x4000572")]
		_3D_POSITION,
		[Token(Token = "0x4000573")]
		_3D_ROLLOFF,
		[Token(Token = "0x4000574")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x4000575")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x4000576")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000577")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000578")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000579")]
		_3D_PAN_BLEND,
		[Token(Token = "0x400057A")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x400057B")]
		OVERALL_GAIN,
		[Token(Token = "0x400057C")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x400057D")]
		_2D_HEIGHT_BLEND,
		[Token(Token = "0x400057E")]
		ATTENUATION_RANGE,
		[Token(Token = "0x400057F")]
		OVERRIDE_RANGE
	}
	[Token(Token = "0x2000116")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x4000581")]
		_12DB,
		[Token(Token = "0x4000582")]
		_24DB,
		[Token(Token = "0x4000583")]
		_48DB
	}
	[Token(Token = "0x2000117")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x4000585")]
		LOWGAIN,
		[Token(Token = "0x4000586")]
		MIDGAIN,
		[Token(Token = "0x4000587")]
		HIGHGAIN,
		[Token(Token = "0x4000588")]
		LOWCROSSOVER,
		[Token(Token = "0x4000589")]
		HIGHCROSSOVER,
		[Token(Token = "0x400058A")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x2000118")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x400058C")]
		RECT,
		[Token(Token = "0x400058D")]
		TRIANGLE,
		[Token(Token = "0x400058E")]
		HAMMING,
		[Token(Token = "0x400058F")]
		HANNING,
		[Token(Token = "0x4000590")]
		BLACKMAN,
		[Token(Token = "0x4000591")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x2000119")]
	public enum DSP_FFT
	{
		[Token(Token = "0x4000593")]
		WINDOWSIZE,
		[Token(Token = "0x4000594")]
		WINDOWTYPE,
		[Token(Token = "0x4000595")]
		SPECTRUMDATA,
		[Token(Token = "0x4000596")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x200011A")]
	public enum DSP_LOUDNESS_METER
	{
		[Token(Token = "0x4000598")]
		STATE,
		[Token(Token = "0x4000599")]
		WEIGHTING,
		[Token(Token = "0x400059A")]
		INFO
	}
	[Token(Token = "0x200011B")]
	public enum DSP_LOUDNESS_METER_STATE_TYPE
	{
		[Token(Token = "0x400059C")]
		RESET_INTEGRATED = -3,
		[Token(Token = "0x400059D")]
		RESET_MAXPEAK,
		[Token(Token = "0x400059E")]
		RESET_ALL,
		[Token(Token = "0x400059F")]
		PAUSED,
		[Token(Token = "0x40005A0")]
		ANALYZING
	}
	[Token(Token = "0x200011C")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x40005A2")]
		ATTACK,
		[Token(Token = "0x40005A3")]
		RELEASE,
		[Token(Token = "0x40005A4")]
		ENVELOPE,
		[Token(Token = "0x40005A5")]
		USESIDECHAIN
	}
	[Token(Token = "0x200011D")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x40005A7")]
		IR,
		[Token(Token = "0x40005A8")]
		WET,
		[Token(Token = "0x40005A9")]
		DRY,
		[Token(Token = "0x40005AA")]
		LINKED
	}
	[Token(Token = "0x200011E")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x40005AC")]
		DEFAULT,
		[Token(Token = "0x40005AD")]
		ALLMONO,
		[Token(Token = "0x40005AE")]
		ALLSTEREO,
		[Token(Token = "0x40005AF")]
		ALLQUAD,
		[Token(Token = "0x40005B0")]
		ALL5POINT1,
		[Token(Token = "0x40005B1")]
		ALL7POINT1,
		[Token(Token = "0x40005B2")]
		ALLLFE,
		[Token(Token = "0x40005B3")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x200011F")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x40005B5")]
		OUTPUTGROUPING,
		[Token(Token = "0x40005B6")]
		GAIN_CH0,
		[Token(Token = "0x40005B7")]
		GAIN_CH1,
		[Token(Token = "0x40005B8")]
		GAIN_CH2,
		[Token(Token = "0x40005B9")]
		GAIN_CH3,
		[Token(Token = "0x40005BA")]
		GAIN_CH4,
		[Token(Token = "0x40005BB")]
		GAIN_CH5,
		[Token(Token = "0x40005BC")]
		GAIN_CH6,
		[Token(Token = "0x40005BD")]
		GAIN_CH7,
		[Token(Token = "0x40005BE")]
		GAIN_CH8,
		[Token(Token = "0x40005BF")]
		GAIN_CH9,
		[Token(Token = "0x40005C0")]
		GAIN_CH10,
		[Token(Token = "0x40005C1")]
		GAIN_CH11,
		[Token(Token = "0x40005C2")]
		GAIN_CH12,
		[Token(Token = "0x40005C3")]
		GAIN_CH13,
		[Token(Token = "0x40005C4")]
		GAIN_CH14,
		[Token(Token = "0x40005C5")]
		GAIN_CH15,
		[Token(Token = "0x40005C6")]
		GAIN_CH16,
		[Token(Token = "0x40005C7")]
		GAIN_CH17,
		[Token(Token = "0x40005C8")]
		GAIN_CH18,
		[Token(Token = "0x40005C9")]
		GAIN_CH19,
		[Token(Token = "0x40005CA")]
		GAIN_CH20,
		[Token(Token = "0x40005CB")]
		GAIN_CH21,
		[Token(Token = "0x40005CC")]
		GAIN_CH22,
		[Token(Token = "0x40005CD")]
		GAIN_CH23,
		[Token(Token = "0x40005CE")]
		GAIN_CH24,
		[Token(Token = "0x40005CF")]
		GAIN_CH25,
		[Token(Token = "0x40005D0")]
		GAIN_CH26,
		[Token(Token = "0x40005D1")]
		GAIN_CH27,
		[Token(Token = "0x40005D2")]
		GAIN_CH28,
		[Token(Token = "0x40005D3")]
		GAIN_CH29,
		[Token(Token = "0x40005D4")]
		GAIN_CH30,
		[Token(Token = "0x40005D5")]
		GAIN_CH31,
		[Token(Token = "0x40005D6")]
		OUTPUT_CH0,
		[Token(Token = "0x40005D7")]
		OUTPUT_CH1,
		[Token(Token = "0x40005D8")]
		OUTPUT_CH2,
		[Token(Token = "0x40005D9")]
		OUTPUT_CH3,
		[Token(Token = "0x40005DA")]
		OUTPUT_CH4,
		[Token(Token = "0x40005DB")]
		OUTPUT_CH5,
		[Token(Token = "0x40005DC")]
		OUTPUT_CH6,
		[Token(Token = "0x40005DD")]
		OUTPUT_CH7,
		[Token(Token = "0x40005DE")]
		OUTPUT_CH8,
		[Token(Token = "0x40005DF")]
		OUTPUT_CH9,
		[Token(Token = "0x40005E0")]
		OUTPUT_CH10,
		[Token(Token = "0x40005E1")]
		OUTPUT_CH11,
		[Token(Token = "0x40005E2")]
		OUTPUT_CH12,
		[Token(Token = "0x40005E3")]
		OUTPUT_CH13,
		[Token(Token = "0x40005E4")]
		OUTPUT_CH14,
		[Token(Token = "0x40005E5")]
		OUTPUT_CH15,
		[Token(Token = "0x40005E6")]
		OUTPUT_CH16,
		[Token(Token = "0x40005E7")]
		OUTPUT_CH17,
		[Token(Token = "0x40005E8")]
		OUTPUT_CH18,
		[Token(Token = "0x40005E9")]
		OUTPUT_CH19,
		[Token(Token = "0x40005EA")]
		OUTPUT_CH20,
		[Token(Token = "0x40005EB")]
		OUTPUT_CH21,
		[Token(Token = "0x40005EC")]
		OUTPUT_CH22,
		[Token(Token = "0x40005ED")]
		OUTPUT_CH23,
		[Token(Token = "0x40005EE")]
		OUTPUT_CH24,
		[Token(Token = "0x40005EF")]
		OUTPUT_CH25,
		[Token(Token = "0x40005F0")]
		OUTPUT_CH26,
		[Token(Token = "0x40005F1")]
		OUTPUT_CH27,
		[Token(Token = "0x40005F2")]
		OUTPUT_CH28,
		[Token(Token = "0x40005F3")]
		OUTPUT_CH29,
		[Token(Token = "0x40005F4")]
		OUTPUT_CH30,
		[Token(Token = "0x40005F5")]
		OUTPUT_CH31
	}
	[Token(Token = "0x2000120")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x40005F7")]
		AUTO = -1,
		[Token(Token = "0x40005F8")]
		MONO,
		[Token(Token = "0x40005F9")]
		STEREO,
		[Token(Token = "0x40005FA")]
		SURROUND
	}
	[Token(Token = "0x2000121")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x40005FC")]
		TRANSMIT,
		[Token(Token = "0x40005FD")]
		GAIN,
		[Token(Token = "0x40005FE")]
		CHANNEL,
		[Token(Token = "0x40005FF")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x2000122")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x4000601")]
		_3D_POSITION,
		[Token(Token = "0x4000602")]
		_3D_ROLLOFF,
		[Token(Token = "0x4000603")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x4000604")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x4000605")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000606")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000607")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000608")]
		OVERALL_GAIN,
		[Token(Token = "0x4000609")]
		OUTPUTGAIN,
		[Token(Token = "0x400060A")]
		ATTENUATION_RANGE,
		[Token(Token = "0x400060B")]
		OVERRIDE_RANGE
	}
	[Token(Token = "0x2000123")]
	public class Error
	{
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x17F8848", Offset = "0x17F4848", VA = "0x17F8848")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x17F8C7C", Offset = "0x17F4C7C", VA = "0x17F8C7C")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x2000124")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x400060C")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x400060D")]
		public const string dllSuffix = "";

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x17F8C84", Offset = "0x17F4C84", VA = "0x17F8C84")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public enum STOP_MODE
	{
		[Token(Token = "0x400060F")]
		ALLOWFADEOUT,
		[Token(Token = "0x4000610")]
		IMMEDIATE
	}
	[Token(Token = "0x2000126")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x4000612")]
		UNLOADING,
		[Token(Token = "0x4000613")]
		UNLOADED,
		[Token(Token = "0x4000614")]
		LOADING,
		[Token(Token = "0x4000615")]
		LOADED,
		[Token(Token = "0x4000616")]
		ERROR
	}
	[Token(Token = "0x2000127")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x2000128")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x2000129")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x200012A")]
	public struct TIMELINE_NESTED_BEAT_PROPERTIES
	{
		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GUID eventid;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TIMELINE_BEAT_PROPERTIES properties;
	}
	[Token(Token = "0x200012B")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x200012C")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float update;
	}
	[Token(Token = "0x200012D")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x200012E")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x200012F")]
	public struct BANK_INFO
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x2000130")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x400063B")]
		PREUPDATE = 1u,
		[Token(Token = "0x400063C")]
		POSTUPDATE = 2u,
		[Token(Token = "0x400063D")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x400063E")]
		LIVEUPDATE_CONNECTED = 8u,
		[Token(Token = "0x400063F")]
		LIVEUPDATE_DISCONNECTED = 0x10u,
		[Token(Token = "0x4000640")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000131")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x2000132")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x4000642")]
		GAME_CONTROLLED,
		[Token(Token = "0x4000643")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x4000644")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x4000645")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x4000646")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x4000647")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x4000648")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x4000649")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x400064A")]
		AUTOMATIC_SPEED_ABSOLUTE,
		[Token(Token = "0x400064B")]
		AUTOMATIC_DISTANCE_NORMALIZED,
		[Token(Token = "0x400064C")]
		MAX
	}
	[Token(Token = "0x2000133")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x400064E")]
		READONLY = 1u,
		[Token(Token = "0x400064F")]
		AUTOMATIC = 2u,
		[Token(Token = "0x4000650")]
		GLOBAL = 4u,
		[Token(Token = "0x4000651")]
		DISCRETE = 8u,
		[Token(Token = "0x4000652")]
		LABELED = 0x10u
	}
	[Token(Token = "0x2000134")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x2000135")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public GUID guid;
	}
	[Token(Token = "0x2000136")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x400065E")]
		LOAD_MEMORY,
		[Token(Token = "0x400065F")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x2000137")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x4000661")]
		VALUE = 0x20
	}
	[Token(Token = "0x2000138")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x17000067")]
		public string name
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x17F8E38", Offset = "0x17F4E38", VA = "0x17F8E38")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000139")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x4000667")]
		INTEGER,
		[Token(Token = "0x4000668")]
		BOOLEAN,
		[Token(Token = "0x4000669")]
		FLOAT,
		[Token(Token = "0x400066A")]
		STRING
	}
	[Token(Token = "0x200013A")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x17F8FC4", Offset = "0x17F4FC4", VA = "0x17F8FC4")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x17F8FDC", Offset = "0x17F4FDC", VA = "0x17F8FDC")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x17F8FF8", Offset = "0x17F4FF8", VA = "0x17F8FF8")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x17F9010", Offset = "0x17F5010", VA = "0x17F9010")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x200013B")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x200013C")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000673")]
		NORMAL = 0u,
		[Token(Token = "0x4000674")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x4000675")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x4000676")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x4000677")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x4000678")]
		LOAD_FROM_UPDATE = 0x10u,
		[Token(Token = "0x4000679")]
		MEMORY_TRACKING = 0x20u
	}
	[Token(Token = "0x200013D")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x400067B")]
		NORMAL = 0u,
		[Token(Token = "0x400067C")]
		NONBLOCKING = 1u,
		[Token(Token = "0x400067D")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x400067E")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x200013E")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x4000680")]
		NORMAL = 0u,
		[Token(Token = "0x4000681")]
		FILEFLUSH = 1u,
		[Token(Token = "0x4000682")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x200013F")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x4000684")]
		NORMAL = 0u,
		[Token(Token = "0x4000685")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x4000686")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x4000687")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x2000140")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x4000689")]
		PLAYING,
		[Token(Token = "0x400068A")]
		SUSTAINING,
		[Token(Token = "0x400068B")]
		STOPPED,
		[Token(Token = "0x400068C")]
		STARTING,
		[Token(Token = "0x400068D")]
		STOPPING
	}
	[Token(Token = "0x2000141")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x400068F")]
		CHANNELPRIORITY,
		[Token(Token = "0x4000690")]
		SCHEDULE_DELAY,
		[Token(Token = "0x4000691")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x4000692")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x4000693")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x4000694")]
		COOLDOWN,
		[Token(Token = "0x4000695")]
		MAX
	}
	[Token(Token = "0x2000142")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x2000143")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000699")]
		CREATED = 1u,
		[Token(Token = "0x400069A")]
		DESTROYED = 2u,
		[Token(Token = "0x400069B")]
		STARTING = 4u,
		[Token(Token = "0x400069C")]
		STARTED = 8u,
		[Token(Token = "0x400069D")]
		RESTARTED = 0x10u,
		[Token(Token = "0x400069E")]
		STOPPED = 0x20u,
		[Token(Token = "0x400069F")]
		START_FAILED = 0x40u,
		[Token(Token = "0x40006A0")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x40006A1")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x40006A2")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x40006A3")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x40006A4")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x40006A5")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x40006A6")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x40006A7")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x40006A8")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x40006A9")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x40006AA")]
		START_EVENT_COMMAND = 0x20000u,
		[Token(Token = "0x40006AB")]
		NESTED_TIMELINE_BEAT = 0x40000u,
		[Token(Token = "0x40006AC")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000144")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, IntPtr _event, IntPtr parameters);
	[Token(Token = "0x2000145")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(IntPtr replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x2000146")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(IntPtr replay, int commandindex, GUID bankguid, IntPtr bankfilename, LOAD_BANK_FLAGS flags, out IntPtr bank, IntPtr userdata);
	[Token(Token = "0x2000147")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(IntPtr replay, int commandindex, IntPtr eventdescription, out IntPtr instance, IntPtr userdata);
	[Token(Token = "0x2000148")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x40006AE")]
		NONE,
		[Token(Token = "0x40006AF")]
		SYSTEM,
		[Token(Token = "0x40006B0")]
		EVENTDESCRIPTION,
		[Token(Token = "0x40006B1")]
		EVENTINSTANCE,
		[Token(Token = "0x40006B2")]
		PARAMETERINSTANCE,
		[Token(Token = "0x40006B3")]
		BUS,
		[Token(Token = "0x40006B4")]
		VCA,
		[Token(Token = "0x40006B5")]
		BANK,
		[Token(Token = "0x40006B6")]
		COMMANDREPLAY
	}
	[Token(Token = "0x2000149")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x200014A")]
	public struct MEMORY_USAGE
	{
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int exclusive;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int inclusive;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int sampledata;
	}
	[Token(Token = "0x200014B")]
	public struct Util
	{
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x17F97BC", Offset = "0x17F57BC", VA = "0x17F97BC")]
		public static RESULT parseID(string idString, out GUID id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x17F9924", Offset = "0x17F5924", VA = "0x17F9924")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out GUID id);
	}
	[Token(Token = "0x200014C")]
	public struct System
	{
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x17F99B0", Offset = "0x17F59B0", VA = "0x17F99B0")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x17F9A40", Offset = "0x17F5A40", VA = "0x17F9A40")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x17F9B50", Offset = "0x17F5B50", VA = "0x17F9B50")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x17F9CD4", Offset = "0x17F5CD4", VA = "0x17F9CD4")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x17F9DE4", Offset = "0x17F5DE4", VA = "0x17F9DE4")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x17F9E98", Offset = "0x17F5E98", VA = "0x17F9E98")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x17F9F1C", Offset = "0x17F5F1C", VA = "0x17F9F1C")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x17F9FA0", Offset = "0x17F5FA0", VA = "0x17F9FA0")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x17FA02C", Offset = "0x17F602C", VA = "0x17FA02C")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x17FA240", Offset = "0x17F6240", VA = "0x17FA240")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x17FA454", Offset = "0x17F6454", VA = "0x17FA454")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x17FA668", Offset = "0x17F6668", VA = "0x17FA668")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x17FA87C", Offset = "0x17F687C", VA = "0x17FA87C")]
		public RESULT getEventByID(GUID id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x17FA938", Offset = "0x17F6938", VA = "0x17FA938")]
		public RESULT getBusByID(GUID id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x17FA9F4", Offset = "0x17F69F4", VA = "0x17FA9F4")]
		public RESULT getVCAByID(GUID id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x17FAAB0", Offset = "0x17F6AB0", VA = "0x17FAAB0")]
		public RESULT getBankByID(GUID id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x17FAB6C", Offset = "0x17F6B6C", VA = "0x17FAB6C")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x17FAD80", Offset = "0x17F6D80", VA = "0x17FAD80")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x17FAF94", Offset = "0x17F6F94", VA = "0x17FAF94")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x17FB030", Offset = "0x17F7030", VA = "0x17FB030")]
		public RESULT getParameterLabelByName(string name, int labelindex, out string label)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x17FB390", Offset = "0x17F7390", VA = "0x17FB390")]
		public RESULT getParameterLabelByID(PARAMETER_ID id, int labelindex, out string label)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x17FB6C4", Offset = "0x17F76C4", VA = "0x17FB6C4")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x17FB6E0", Offset = "0x17F76E0", VA = "0x17FB6E0")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x17FB784", Offset = "0x17F7784", VA = "0x17FB784")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x17FB830", Offset = "0x17F7830", VA = "0x17FB830")]
		public RESULT setParameterByIDWithLabel(PARAMETER_ID id, string label, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x17FBA5C", Offset = "0x17F7A5C", VA = "0x17FBA5C")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x17FBB20", Offset = "0x17F7B20", VA = "0x17FBB20")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x17FBB38", Offset = "0x17F7B38", VA = "0x17FBB38")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x17FBD64", Offset = "0x17F7D64", VA = "0x17FBD64")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x17FBF98", Offset = "0x17F7F98", VA = "0x17FBF98")]
		public RESULT setParameterByNameWithLabel(string name, string label, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x17FC2DC", Offset = "0x17F82DC", VA = "0x17FC2DC")]
		public RESULT lookupID(string path, out GUID id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x17FC4F0", Offset = "0x17F84F0", VA = "0x17FC4F0")]
		public RESULT lookupPath(GUID id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x17FC7EC", Offset = "0x17F87EC", VA = "0x17FC7EC")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x17FC878", Offset = "0x17F8878", VA = "0x17FC878")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x17FC904", Offset = "0x17F8904", VA = "0x17FC904")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x17FC9AC", Offset = "0x17F89AC", VA = "0x17FC9AC")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes, out VECTOR attenuationposition)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x17FCA50", Offset = "0x17F8A50", VA = "0x17FCA50")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x17FCAF8", Offset = "0x17F8AF8", VA = "0x17FCAF8")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes, VECTOR attenuationposition)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x17FCBBC", Offset = "0x17F8BBC", VA = "0x17FCBBC")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x17FCC58", Offset = "0x17F8C58", VA = "0x17FCC58")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x17FCCF4", Offset = "0x17F8CF4", VA = "0x17FCCF4")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x17FCF20", Offset = "0x17F8F20", VA = "0x17FCF20")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x17FD058", Offset = "0x17F9058", VA = "0x17FD058")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x17FD1F0", Offset = "0x17F91F0", VA = "0x17FD1F0")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x17FD274", Offset = "0x17F9274", VA = "0x17FD274")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x17FD2F8", Offset = "0x17F92F8", VA = "0x17FD2F8")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x17FD37C", Offset = "0x17F937C", VA = "0x17FD37C")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x17FD590", Offset = "0x17F9590", VA = "0x17FD590")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x17FD614", Offset = "0x17F9614", VA = "0x17FD614")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x17FD840", Offset = "0x17F9840", VA = "0x17FD840")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x17FD8CC", Offset = "0x17F98CC", VA = "0x17FD8CC")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x17FDAB4", Offset = "0x17F9AB4", VA = "0x17FDAB4")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x17FDB40", Offset = "0x17F9B40", VA = "0x17FDB40")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x17FDD6C", Offset = "0x17F9D6C", VA = "0x17FDD6C")]
		public RESULT getCPUUsage(out CPU_USAGE usage, out FMOD.CPU_USAGE usage_core)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x17FDE08", Offset = "0x17F9E08", VA = "0x17FDE08")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x17FDE94", Offset = "0x17F9E94", VA = "0x17FDE94")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x17FDF18", Offset = "0x17F9F18", VA = "0x17FDF18")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x17FDFBC", Offset = "0x17F9FBC", VA = "0x17FDFBC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x17FE048", Offset = "0x17FA048", VA = "0x17FE048")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x17FE0D4", Offset = "0x17FA0D4", VA = "0x17FE0D4")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x17F99BC", Offset = "0x17F59BC", VA = "0x17F99BC")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x17FE160", Offset = "0x17FA160", VA = "0x17FE160")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x17F9ACC", Offset = "0x17F5ACC", VA = "0x17F9ACC")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x17F9D60", Offset = "0x17F5D60", VA = "0x17F9D60")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x17F9DEC", Offset = "0x17F5DEC", VA = "0x17F9DEC")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x17F9EA0", Offset = "0x17F5EA0", VA = "0x17F9EA0")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x17F9F24", Offset = "0x17F5F24", VA = "0x17F9F24")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x17F9FA8", Offset = "0x17F5FA8", VA = "0x17F9FA8")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x17FA1A4", Offset = "0x17F61A4", VA = "0x17FA1A4")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x17FA3B8", Offset = "0x17F63B8", VA = "0x17FA3B8")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x17FA5CC", Offset = "0x17F65CC", VA = "0x17FA5CC")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x17FA7E0", Offset = "0x17F67E0", VA = "0x17FA7E0")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x17FA8A4", Offset = "0x17F68A4", VA = "0x17FA8A4")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref GUID id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x17FA960", Offset = "0x17F6960", VA = "0x17FA960")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref GUID id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x17FAA1C", Offset = "0x17F6A1C", VA = "0x17FAA1C")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref GUID id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x17FAAD8", Offset = "0x17F6AD8", VA = "0x17FAAD8")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref GUID id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x17FACE4", Offset = "0x17F6CE4", VA = "0x17FACE4")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x17FAEF8", Offset = "0x17F6EF8", VA = "0x17FAEF8")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x17FAF9C", Offset = "0x17F6F9C", VA = "0x17FAF9C")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x17FB2D4", Offset = "0x17F72D4", VA = "0x17FB2D4")]
		private static extern RESULT FMOD_Studio_System_GetParameterLabelByName(IntPtr system, byte[] name, int labelindex, IntPtr label, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x17FB614", Offset = "0x17F7614", VA = "0x17FB614")]
		private static extern RESULT FMOD_Studio_System_GetParameterLabelByID(IntPtr system, PARAMETER_ID id, int labelindex, IntPtr label, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x17FB6E8", Offset = "0x17F76E8", VA = "0x17FB6E8")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x17FB78C", Offset = "0x17F778C", VA = "0x17FB78C")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x17FB9B8", Offset = "0x17F79B8", VA = "0x17FB9B8")]
		private static extern RESULT FMOD_Studio_System_SetParameterByIDWithLabel(IntPtr system, PARAMETER_ID id, byte[] label, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x17FBA64", Offset = "0x17F7A64", VA = "0x17FBA64")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x17FBCC0", Offset = "0x17F7CC0", VA = "0x17FBCC0")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x17FBEEC", Offset = "0x17F7EEC", VA = "0x17FBEEC")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x17FC230", Offset = "0x17F8230", VA = "0x17FC230")]
		private static extern RESULT FMOD_Studio_System_SetParameterByNameWithLabel(IntPtr system, byte[] name, byte[] label, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x17FC454", Offset = "0x17F8454", VA = "0x17FC454")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out GUID id);

		[PreserveSig]
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x17FC740", Offset = "0x17F8740", VA = "0x17FC740")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref GUID id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x17FC7F4", Offset = "0x17F87F4", VA = "0x17FC7F4")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x17FC880", Offset = "0x17F8880", VA = "0x17FC880")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x17FC910", Offset = "0x17F8910", VA = "0x17FC910")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x17FC9B4", Offset = "0x17F89B4", VA = "0x17FC9B4")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes, out VECTOR attenuationposition);

		[PreserveSig]
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x17FCA5C", Offset = "0x17F8A5C", VA = "0x17FCA5C")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x17FCB20", Offset = "0x17F8B20", VA = "0x17FCB20")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes, ref VECTOR attenuationposition);

		[PreserveSig]
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x17FCBC4", Offset = "0x17F8BC4", VA = "0x17FCBC4")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x17FCC60", Offset = "0x17F8C60", VA = "0x17FCC60")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x17FCE7C", Offset = "0x17F8E7C", VA = "0x17FCE7C")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x17FCFA4", Offset = "0x17F8FA4", VA = "0x17FCFA4")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x17FD0FC", Offset = "0x17F90FC", VA = "0x17FD0FC")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x17FD1F8", Offset = "0x17F91F8", VA = "0x17FD1F8")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x17FD27C", Offset = "0x17F927C", VA = "0x17FD27C")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x17FD300", Offset = "0x17F9300", VA = "0x17FD300")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x17FD4F4", Offset = "0x17F94F4", VA = "0x17FD4F4")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x17FD598", Offset = "0x17F9598", VA = "0x17FD598")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x17FD79C", Offset = "0x17F979C", VA = "0x17FD79C")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x17FD848", Offset = "0x17F9848", VA = "0x17FD848")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x17FDA10", Offset = "0x17F9A10", VA = "0x17FDA10")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x17FDABC", Offset = "0x17F9ABC", VA = "0x17FDABC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x17FDC20", Offset = "0x17F9C20", VA = "0x17FDC20")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x17FDD74", Offset = "0x17F9D74", VA = "0x17FDD74")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage, out FMOD.CPU_USAGE usage_core);

		[PreserveSig]
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x17FDE10", Offset = "0x17F9E10", VA = "0x17FDE10")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x17FDE9C", Offset = "0x17F9E9C", VA = "0x17FDE9C")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x17FDF20", Offset = "0x17F9F20", VA = "0x17FDF20")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x17FDFC4", Offset = "0x17F9FC4", VA = "0x17FDFC4")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x17FE050", Offset = "0x17FA050", VA = "0x17FE050")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x17FE0DC", Offset = "0x17FA0DC", VA = "0x17FE0DC")]
		private static extern RESULT FMOD_Studio_System_GetMemoryUsage(IntPtr system, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x17FE1E4", Offset = "0x17FA1E4", VA = "0x17FE1E4")]
		public System(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x17FE1EC", Offset = "0x17FA1EC", VA = "0x17FE1EC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x17FE1FC", Offset = "0x17FA1FC", VA = "0x17FE1FC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x17FE204", Offset = "0x17FA204", VA = "0x17FE204")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014D")]
	public struct EventDescription
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x17FE238", Offset = "0x17FA238", VA = "0x17FE238")]
		public RESULT getID(out GUID id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x17FE2C4", Offset = "0x17FA2C4", VA = "0x17FE2C4")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x17FE5A4", Offset = "0x17FA5A4", VA = "0x17FE5A4")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x17FE630", Offset = "0x17FA630", VA = "0x17FE630")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x17FE6CC", Offset = "0x17FA6CC", VA = "0x17FE6CC")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x17FE8E0", Offset = "0x17FA8E0", VA = "0x17FE8E0")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x17FE97C", Offset = "0x17FA97C", VA = "0x17FE97C")]
		public RESULT getParameterLabelByIndex(int index, int labelindex, out string label)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x17FECB4", Offset = "0x17FACB4", VA = "0x17FECB4")]
		public RESULT getParameterLabelByName(string name, int labelindex, out string label)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x17FF014", Offset = "0x17FB014", VA = "0x17FF014")]
		public RESULT getParameterLabelByID(PARAMETER_ID id, int labelindex, out string label)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x17FF34C", Offset = "0x17FB34C", VA = "0x17FF34C")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x17FF3D8", Offset = "0x17FB3D8", VA = "0x17FF3D8")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x17FF494", Offset = "0x17FB494", VA = "0x17FF494")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x17FF6C8", Offset = "0x17FB6C8", VA = "0x17FF6C8")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x17FF754", Offset = "0x17FB754", VA = "0x17FF754")]
		public RESULT getMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x17FF7F0", Offset = "0x17FB7F0", VA = "0x17FF7F0")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x17FF87C", Offset = "0x17FB87C", VA = "0x17FF87C")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x17FF91C", Offset = "0x17FB91C", VA = "0x17FF91C")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x17FF9BC", Offset = "0x17FB9BC", VA = "0x17FF9BC")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x17FFA5C", Offset = "0x17FBA5C", VA = "0x17FFA5C")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x17FFAFC", Offset = "0x17FBAFC", VA = "0x17FFAFC")]
		public RESULT isDopplerEnabled(out bool doppler)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x17FFB9C", Offset = "0x17FBB9C", VA = "0x17FFB9C")]
		public RESULT hasSustainPoint(out bool sustainPoint)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x17FFC3C", Offset = "0x17FBC3C", VA = "0x17FFC3C")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x17FFCC8", Offset = "0x17FBCC8", VA = "0x17FFCC8")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x17FFD54", Offset = "0x17FBD54", VA = "0x17FFD54")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x17FFF3C", Offset = "0x17FBF3C", VA = "0x17FFF3C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x17FFFC0", Offset = "0x17FBFC0", VA = "0x17FFFC0")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1800044", Offset = "0x17FC044", VA = "0x1800044")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x18000D0", Offset = "0x17FC0D0", VA = "0x18000D0")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1800154", Offset = "0x17FC154", VA = "0x1800154")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x18001F8", Offset = "0x17FC1F8", VA = "0x18001F8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1800284", Offset = "0x17FC284", VA = "0x1800284")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1800310", Offset = "0x17FC310", VA = "0x1800310")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x17FE240", Offset = "0x17FA240", VA = "0x17FE240")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out GUID id);

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x17FE508", Offset = "0x17FA508", VA = "0x17FE508")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x17FE5AC", Offset = "0x17FA5AC", VA = "0x17FE5AC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x17FE638", Offset = "0x17FA638", VA = "0x17FE638")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x17FE844", Offset = "0x17FA844", VA = "0x17FE844")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x17FE8E8", Offset = "0x17FA8E8", VA = "0x17FE8E8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x17FEC00", Offset = "0x17FAC00", VA = "0x17FEC00")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterLabelByIndex(IntPtr eventdescription, int index, int labelindex, IntPtr label, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x17FEF58", Offset = "0x17FAF58", VA = "0x17FEF58")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterLabelByName(IntPtr eventdescription, byte[] name, int labelindex, IntPtr label, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x17FF298", Offset = "0x17FB298", VA = "0x17FF298")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterLabelByID(IntPtr eventdescription, PARAMETER_ID id, int labelindex, IntPtr label, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x17FF354", Offset = "0x17FB354", VA = "0x17FF354")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x17FF3E0", Offset = "0x17FB3E0", VA = "0x17FF3E0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x17FF60C", Offset = "0x17FB60C", VA = "0x17FF60C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x17FF6D0", Offset = "0x17FB6D0", VA = "0x17FF6D0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x17FF75C", Offset = "0x17FB75C", VA = "0x17FF75C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinMaxDistance(IntPtr eventdescription, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x17FF7F8", Offset = "0x17FB7F8", VA = "0x17FF7F8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x17FF884", Offset = "0x17FB884", VA = "0x17FF884")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x17FF924", Offset = "0x17FB924", VA = "0x17FF924")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x17FF9C4", Offset = "0x17FB9C4", VA = "0x17FF9C4")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x17FFA64", Offset = "0x17FBA64", VA = "0x17FFA64")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x17FFB04", Offset = "0x17FBB04", VA = "0x17FFB04")]
		private static extern RESULT FMOD_Studio_EventDescription_IsDopplerEnabled(IntPtr eventdescription, out bool doppler);

		[PreserveSig]
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x17FFBA4", Offset = "0x17FBBA4", VA = "0x17FFBA4")]
		private static extern RESULT FMOD_Studio_EventDescription_HasSustainPoint(IntPtr eventdescription, out bool sustainPoint);

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x17FFC44", Offset = "0x17FBC44", VA = "0x17FFC44")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x17FFCD0", Offset = "0x17FBCD0", VA = "0x17FFCD0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x17FFE98", Offset = "0x17FBE98", VA = "0x17FFE98")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x17FFF44", Offset = "0x17FBF44", VA = "0x17FFF44")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x17FFFC8", Offset = "0x17FBFC8", VA = "0x17FFFC8")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x180004C", Offset = "0x17FC04C", VA = "0x180004C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x18000D8", Offset = "0x17FC0D8", VA = "0x18000D8")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x180015C", Offset = "0x17FC15C", VA = "0x180015C")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1800200", Offset = "0x17FC200", VA = "0x1800200")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x180028C", Offset = "0x17FC28C", VA = "0x180028C")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1800394", Offset = "0x17FC394", VA = "0x1800394")]
		public EventDescription(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x180039C", Offset = "0x17FC39C", VA = "0x180039C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x18003AC", Offset = "0x17FC3AC", VA = "0x18003AC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x18003B4", Offset = "0x17FC3B4", VA = "0x18003B4")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014E")]
	public struct EventInstance
	{
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x18003E8", Offset = "0x17FC3E8", VA = "0x18003E8")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1800474", Offset = "0x17FC474", VA = "0x1800474")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1800514", Offset = "0x17FC514", VA = "0x1800514")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x18005B0", Offset = "0x17FC5B0", VA = "0x18005B0")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1800644", Offset = "0x17FC644", VA = "0x1800644")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x18006E4", Offset = "0x17FC6E4", VA = "0x18006E4")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1800780", Offset = "0x17FC780", VA = "0x1800780")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1800814", Offset = "0x17FC814", VA = "0x1800814")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x18008A0", Offset = "0x17FC8A0", VA = "0x18008A0")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x180092C", Offset = "0x17FC92C", VA = "0x180092C")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x18009B8", Offset = "0x17FC9B8", VA = "0x18009B8")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1800A44", Offset = "0x17FCA44", VA = "0x1800A44")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1800AE0", Offset = "0x17FCAE0", VA = "0x1800AE0")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1800B7C", Offset = "0x17FCB7C", VA = "0x1800B7C")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1800C18", Offset = "0x17FCC18", VA = "0x1800C18")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1800CB4", Offset = "0x17FCCB4", VA = "0x1800CB4")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1800D54", Offset = "0x17FCD54", VA = "0x1800D54")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1800DE0", Offset = "0x17FCDE0", VA = "0x1800DE0")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1800E64", Offset = "0x17FCE64", VA = "0x1800E64")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1800EF0", Offset = "0x17FCEF0", VA = "0x1800EF0")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1800F7C", Offset = "0x17FCF7C", VA = "0x1800F7C")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1801008", Offset = "0x17FD008", VA = "0x1801008")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1801094", Offset = "0x17FD094", VA = "0x1801094")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1801120", Offset = "0x17FD120", VA = "0x1801120")]
		public RESULT getMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x18011BC", Offset = "0x17FD1BC", VA = "0x18011BC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1801240", Offset = "0x17FD240", VA = "0x1801240")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x18012E0", Offset = "0x17FD2E0", VA = "0x18012E0")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x18012FC", Offset = "0x17FD2FC", VA = "0x18012FC")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x18013A0", Offset = "0x17FD3A0", VA = "0x18013A0")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x180144C", Offset = "0x17FD44C", VA = "0x180144C")]
		public RESULT setParameterByIDWithLabel(PARAMETER_ID id, string label, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1801678", Offset = "0x17FD678", VA = "0x1801678")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x180173C", Offset = "0x17FD73C", VA = "0x180173C")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1801754", Offset = "0x17FD754", VA = "0x1801754")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1801980", Offset = "0x17FD980", VA = "0x1801980")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1801BB4", Offset = "0x17FDBB4", VA = "0x1801BB4")]
		public RESULT setParameterByNameWithLabel(string name, string label, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1801EF8", Offset = "0x17FDEF8", VA = "0x1801EF8")]
		public RESULT keyOff()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1801F7C", Offset = "0x17FDF7C", VA = "0x1801F7C")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1802020", Offset = "0x17FE020", VA = "0x1802020")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x18020AC", Offset = "0x17FE0AC", VA = "0x18020AC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1802138", Offset = "0x17FE138", VA = "0x1802138")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x18021D4", Offset = "0x17FE1D4", VA = "0x18021D4")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1802260", Offset = "0x17FE260", VA = "0x1802260")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x18003F0", Offset = "0x17FC3F0", VA = "0x18003F0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1800480", Offset = "0x17FC480", VA = "0x1800480")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x180051C", Offset = "0x17FC51C", VA = "0x180051C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x18005B8", Offset = "0x17FC5B8", VA = "0x18005B8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1800650", Offset = "0x17FC650", VA = "0x1800650")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x18006EC", Offset = "0x17FC6EC", VA = "0x18006EC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1800788", Offset = "0x17FC788", VA = "0x1800788")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x180081C", Offset = "0x17FC81C", VA = "0x180081C")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x18008A8", Offset = "0x17FC8A8", VA = "0x18008A8")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1800934", Offset = "0x17FC934", VA = "0x1800934")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x18009C0", Offset = "0x17FC9C0", VA = "0x18009C0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1800A4C", Offset = "0x17FCA4C", VA = "0x1800A4C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1800AE8", Offset = "0x17FCAE8", VA = "0x1800AE8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1800B84", Offset = "0x17FCB84", VA = "0x1800B84")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1800C20", Offset = "0x17FCC20", VA = "0x1800C20")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1800CBC", Offset = "0x17FCCBC", VA = "0x1800CBC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1800D5C", Offset = "0x17FCD5C", VA = "0x1800D5C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1800DE8", Offset = "0x17FCDE8", VA = "0x1800DE8")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1800E6C", Offset = "0x17FCE6C", VA = "0x1800E6C")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1800EF8", Offset = "0x17FCEF8", VA = "0x1800EF8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1800F84", Offset = "0x17FCF84", VA = "0x1800F84")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1801010", Offset = "0x17FD010", VA = "0x1801010")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x180109C", Offset = "0x17FD09C", VA = "0x180109C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1801128", Offset = "0x17FD128", VA = "0x1801128")]
		private static extern RESULT FMOD_Studio_EventInstance_GetMinMaxDistance(IntPtr _event, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x18011C4", Offset = "0x17FD1C4", VA = "0x18011C4")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1801248", Offset = "0x17FD248", VA = "0x1801248")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x18018DC", Offset = "0x17FD8DC", VA = "0x18018DC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1801B08", Offset = "0x17FDB08", VA = "0x1801B08")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1801E4C", Offset = "0x17FDE4C", VA = "0x1801E4C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByNameWithLabel(IntPtr _event, byte[] name, byte[] label, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1801304", Offset = "0x17FD304", VA = "0x1801304")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x18013A8", Offset = "0x17FD3A8", VA = "0x18013A8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x18015D4", Offset = "0x17FD5D4", VA = "0x18015D4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByIDWithLabel(IntPtr _event, PARAMETER_ID id, byte[] label, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1801680", Offset = "0x17FD680", VA = "0x1801680")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1801F00", Offset = "0x17FDF00", VA = "0x1801F00")]
		private static extern RESULT FMOD_Studio_EventInstance_KeyOff(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1801F84", Offset = "0x17FDF84", VA = "0x1801F84")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1802028", Offset = "0x17FE028", VA = "0x1802028")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x18020B4", Offset = "0x17FE0B4", VA = "0x18020B4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1802140", Offset = "0x17FE140", VA = "0x1802140")]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x18021DC", Offset = "0x17FE1DC", VA = "0x18021DC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetMemoryUsage(IntPtr _event, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x18022E4", Offset = "0x17FE2E4", VA = "0x18022E4")]
		public EventInstance(IntPtr ptr)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x18022EC", Offset = "0x17FE2EC", VA = "0x18022EC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x18022FC", Offset = "0x17FE2FC", VA = "0x18022FC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1802304", Offset = "0x17FE304", VA = "0x1802304")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014F")]
	public struct Bus
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1802338", Offset = "0x17FE338", VA = "0x1802338")]
		public RESULT getID(out GUID id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x18023C4", Offset = "0x17FE3C4", VA = "0x18023C4")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x18026A4", Offset = "0x17FE6A4", VA = "0x18026A4")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x18026C0", Offset = "0x17FE6C0", VA = "0x18026C0")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x180275C", Offset = "0x17FE75C", VA = "0x180275C")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x18027F0", Offset = "0x17FE7F0", VA = "0x18027F0")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1802890", Offset = "0x17FE890", VA = "0x1802890")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x180291C", Offset = "0x17FE91C", VA = "0x180291C")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x18029BC", Offset = "0x17FE9BC", VA = "0x18029BC")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1802A48", Offset = "0x17FEA48", VA = "0x1802A48")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1802AD4", Offset = "0x17FEAD4", VA = "0x1802AD4")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1802B58", Offset = "0x17FEB58", VA = "0x1802B58")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1802BDC", Offset = "0x17FEBDC", VA = "0x1802BDC")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1802C68", Offset = "0x17FEC68", VA = "0x1802C68")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1802D04", Offset = "0x17FED04", VA = "0x1802D04")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1802D90", Offset = "0x17FED90", VA = "0x1802D90")]
		public RESULT getPortIndex(out ulong index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1802E1C", Offset = "0x17FEE1C", VA = "0x1802E1C")]
		public RESULT setPortIndex(ulong index)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1802EA8", Offset = "0x17FEEA8", VA = "0x1802EA8")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1802340", Offset = "0x17FE340", VA = "0x1802340")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out GUID id);

		[PreserveSig]
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1802608", Offset = "0x17FE608", VA = "0x1802608")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x18026C8", Offset = "0x17FE6C8", VA = "0x18026C8")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1802764", Offset = "0x17FE764", VA = "0x1802764")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x18027F8", Offset = "0x17FE7F8", VA = "0x18027F8")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1802898", Offset = "0x17FE898", VA = "0x1802898")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1802924", Offset = "0x17FE924", VA = "0x1802924")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x18029C4", Offset = "0x17FE9C4", VA = "0x18029C4")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1802A50", Offset = "0x17FEA50", VA = "0x1802A50")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1802ADC", Offset = "0x17FEADC", VA = "0x1802ADC")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1802B60", Offset = "0x17FEB60", VA = "0x1802B60")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1802BE4", Offset = "0x17FEBE4", VA = "0x1802BE4")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1802C70", Offset = "0x17FEC70", VA = "0x1802C70")]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1802D0C", Offset = "0x17FED0C", VA = "0x1802D0C")]
		private static extern RESULT FMOD_Studio_Bus_GetMemoryUsage(IntPtr bus, out MEMORY_USAGE memoryusage);

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1802D98", Offset = "0x17FED98", VA = "0x1802D98")]
		private static extern RESULT FMOD_Studio_Bus_GetPortIndex(IntPtr bus, out ulong index);

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1802E24", Offset = "0x17FEE24", VA = "0x1802E24")]
		private static extern RESULT FMOD_Studio_Bus_SetPortIndex(IntPtr bus, ulong index);

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1802F2C", Offset = "0x17FEF2C", VA = "0x1802F2C")]
		public Bus(IntPtr ptr)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1802F34", Offset = "0x17FEF34", VA = "0x1802F34")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1802F44", Offset = "0x17FEF44", VA = "0x1802F44")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1802F4C", Offset = "0x17FEF4C", VA = "0x1802F4C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000150")]
	public struct VCA
	{
		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1802F80", Offset = "0x17FEF80", VA = "0x1802F80")]
		public RESULT getID(out GUID id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x180300C", Offset = "0x17FF00C", VA = "0x180300C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x18032EC", Offset = "0x17FF2EC", VA = "0x18032EC")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1803308", Offset = "0x17FF308", VA = "0x1803308")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x18033A4", Offset = "0x17FF3A4", VA = "0x18033A4")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1803438", Offset = "0x17FF438", VA = "0x1803438")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1802F88", Offset = "0x17FEF88", VA = "0x1802F88")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out GUID id);

		[PreserveSig]
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1803250", Offset = "0x17FF250", VA = "0x1803250")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1803310", Offset = "0x17FF310", VA = "0x1803310")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x18033AC", Offset = "0x17FF3AC", VA = "0x18033AC")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x18034BC", Offset = "0x17FF4BC", VA = "0x18034BC")]
		public VCA(IntPtr ptr)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x18034C4", Offset = "0x17FF4C4", VA = "0x18034C4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x18034D4", Offset = "0x17FF4D4", VA = "0x18034D4")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x18034DC", Offset = "0x17FF4DC", VA = "0x18034DC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000151")]
	public struct Bank
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1803510", Offset = "0x17FF510", VA = "0x1803510")]
		public RESULT getID(out GUID id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x180359C", Offset = "0x17FF59C", VA = "0x180359C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x180387C", Offset = "0x17FF87C", VA = "0x180387C")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1803900", Offset = "0x17FF900", VA = "0x1803900")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1803984", Offset = "0x17FF984", VA = "0x1803984")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1803A08", Offset = "0x17FFA08", VA = "0x1803A08")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1803A94", Offset = "0x17FFA94", VA = "0x1803A94")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1803B20", Offset = "0x17FFB20", VA = "0x1803B20")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1803BAC", Offset = "0x17FFBAC", VA = "0x1803BAC")]
		public RESULT getStringInfo(int index, out GUID id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1803EC8", Offset = "0x17FFEC8", VA = "0x1803EC8")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1803F54", Offset = "0x17FFF54", VA = "0x1803F54")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x180413C", Offset = "0x180013C", VA = "0x180413C")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x18041C8", Offset = "0x18001C8", VA = "0x18041C8")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x18043B0", Offset = "0x18003B0", VA = "0x18043B0")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x180443C", Offset = "0x180043C", VA = "0x180443C")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1804624", Offset = "0x1800624", VA = "0x1804624")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x18046B0", Offset = "0x18006B0", VA = "0x18046B0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x180473C", Offset = "0x180073C", VA = "0x180473C")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1803518", Offset = "0x17FF518", VA = "0x1803518")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out GUID id);

		[PreserveSig]
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x18037E0", Offset = "0x17FF7E0", VA = "0x18037E0")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1803884", Offset = "0x17FF884", VA = "0x1803884")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1803908", Offset = "0x17FF908", VA = "0x1803908")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x180398C", Offset = "0x17FF98C", VA = "0x180398C")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1803A10", Offset = "0x17FFA10", VA = "0x1803A10")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1803A9C", Offset = "0x17FFA9C", VA = "0x1803A9C")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1803B28", Offset = "0x17FFB28", VA = "0x1803B28")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1803E14", Offset = "0x17FFE14", VA = "0x1803E14")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out GUID id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1803ED0", Offset = "0x17FFED0", VA = "0x1803ED0")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1804098", Offset = "0x1800098", VA = "0x1804098")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1804144", Offset = "0x1800144", VA = "0x1804144")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x180430C", Offset = "0x180030C", VA = "0x180430C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x18043B8", Offset = "0x18003B8", VA = "0x18043B8")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1804580", Offset = "0x1800580", VA = "0x1804580")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x180462C", Offset = "0x180062C", VA = "0x180462C")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x18046B8", Offset = "0x18006B8", VA = "0x18046B8")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x18047C0", Offset = "0x18007C0", VA = "0x18047C0")]
		public Bank(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x18047C8", Offset = "0x18007C8", VA = "0x18047C8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x18047D8", Offset = "0x18007D8", VA = "0x18047D8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x18047E0", Offset = "0x18007E0", VA = "0x18047E0")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000152")]
	public struct CommandReplay
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1804814", Offset = "0x1800814", VA = "0x1804814")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x18048A0", Offset = "0x18008A0", VA = "0x18048A0")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x180492C", Offset = "0x180092C", VA = "0x180492C")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x18049B8", Offset = "0x18009B8", VA = "0x18049B8")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1804A54", Offset = "0x1800A54", VA = "0x1804A54")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1804D44", Offset = "0x1800D44", VA = "0x1804D44")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1804DE0", Offset = "0x1800DE0", VA = "0x1804DE0")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1804FDC", Offset = "0x1800FDC", VA = "0x1804FDC")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1805060", Offset = "0x1801060", VA = "0x1805060")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x18050E4", Offset = "0x18010E4", VA = "0x18050E4")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1805178", Offset = "0x1801178", VA = "0x1805178")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1805204", Offset = "0x1801204", VA = "0x1805204")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x18052A4", Offset = "0x18012A4", VA = "0x18052A4")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1805330", Offset = "0x1801330", VA = "0x1805330")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x18053BC", Offset = "0x18013BC", VA = "0x18053BC")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1805458", Offset = "0x1801458", VA = "0x1805458")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x18054DC", Offset = "0x18014DC", VA = "0x18054DC")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1805570", Offset = "0x1801570", VA = "0x1805570")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1805604", Offset = "0x1801604", VA = "0x1805604")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1805698", Offset = "0x1801698", VA = "0x1805698")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1805724", Offset = "0x1801724", VA = "0x1805724")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x18057B0", Offset = "0x18017B0", VA = "0x18057B0")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x180481C", Offset = "0x180081C", VA = "0x180481C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x18048A8", Offset = "0x18008A8", VA = "0x18048A8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1804934", Offset = "0x1800934", VA = "0x1804934")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x18049C0", Offset = "0x18009C0", VA = "0x18049C0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1804CA8", Offset = "0x1800CA8", VA = "0x1804CA8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1804D4C", Offset = "0x1800D4C", VA = "0x1804D4C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1804F50", Offset = "0x1800F50", VA = "0x1804F50")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1804FE4", Offset = "0x1800FE4", VA = "0x1804FE4")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1805068", Offset = "0x1801068", VA = "0x1805068")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x18050EC", Offset = "0x18010EC", VA = "0x18050EC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1805180", Offset = "0x1801180", VA = "0x1805180")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x180520C", Offset = "0x180120C", VA = "0x180520C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x18052AC", Offset = "0x18012AC", VA = "0x18052AC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1805338", Offset = "0x1801338", VA = "0x1805338")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x18053C4", Offset = "0x18013C4", VA = "0x18053C4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1805460", Offset = "0x1801460", VA = "0x1805460")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x18054E4", Offset = "0x18014E4", VA = "0x18054E4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1805578", Offset = "0x1801578", VA = "0x1805578")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x180560C", Offset = "0x180160C", VA = "0x180560C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x18056A0", Offset = "0x18016A0", VA = "0x18056A0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x180572C", Offset = "0x180172C", VA = "0x180572C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1805834", Offset = "0x1801834", VA = "0x1805834")]
		public CommandReplay(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x180583C", Offset = "0x180183C", VA = "0x180583C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x180584C", Offset = "0x180184C", VA = "0x180584C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1805854", Offset = "0x1801854", VA = "0x1805854")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
