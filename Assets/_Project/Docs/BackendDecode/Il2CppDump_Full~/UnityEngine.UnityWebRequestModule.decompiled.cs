using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngineInternal
{
	[Token(Token = "0x2000002")]
	internal static class WebRequestUtils
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Regex domainRegex;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x3044844", Offset = "0x3040844", VA = "0x3044844")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal static string RedirectTo(string baseUri, string redirectUri)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3044930", Offset = "0x3040930", VA = "0x3044930")]
		internal static string MakeInitialUrl(string targetUrl, string localUrl)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3044CA0", Offset = "0x3040CA0", VA = "0x3044CA0")]
		internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3045080", Offset = "0x3041080", VA = "0x3045080")]
		private static string URLDecode(string encoded)
		{
			return null;
		}
	}
}
namespace UnityEngine
{
	[Token(Token = "0x2000003")]
	public class WWWForm
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte[] dDash;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static byte[] crlf;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static byte[] contentTypeHeader;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static byte[] dispositionHeader;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static byte[] endQuote;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static byte[] fileNameField;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static byte[] ampersand;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static byte[] equal;

		[Token(Token = "0x17000001")]
		internal static Encoding DefaultEncoding
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x3045218", Offset = "0x3041218", VA = "0x3045218")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000004")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEngine.UnityWebRequestWWWModule" })]
	internal class WWWTranscoder
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte[] ucHexChars;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static byte[] lcHexChars;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static byte urlEscapeChar;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static byte[] urlSpace;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static byte[] dataSpace;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static byte[] urlForbidden;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static byte qpEscapeChar;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static byte[] qpSpace;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static byte[] qpForbidden;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3045458", Offset = "0x3041458", VA = "0x3045458")]
		private static byte Hex2Byte(byte[] b, int offset)
		{
			return default(byte);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3045124", Offset = "0x3041124", VA = "0x3045124")]
		public static byte[] URLDecode(byte[] toEncode)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x30457EC", Offset = "0x30417EC", VA = "0x30457EC")]
		private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3045514", Offset = "0x3041514", VA = "0x3045514")]
		public static byte[] Decode(byte[] input, byte escapeChar, byte[] space)
		{
			return null;
		}
	}
}
namespace UnityEngine.Networking
{
	[StructLayout(0)]
	[Token(Token = "0x2000005")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
	public class CertificateHandler
	{
		[NonSerialized]
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[MethodImpl(4096)]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3045A9C", Offset = "0x3041A9C", VA = "0x3045A9C")]
		[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
		private extern void Release();

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3045AD8", Offset = "0x3041AD8", VA = "0x3045AD8", Slot = "4")]
		protected virtual bool ValidateCertificate(byte[] certificateData)
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3045AE0", Offset = "0x3041AE0", VA = "0x3045AE0")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		internal bool ValidateCertificateNative(byte[] certificateData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3045AEC", Offset = "0x3041AEC", VA = "0x3045AEC", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000006")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
	public class DownloadHandler : IDisposable
	{
		[NonSerialized]
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[UnityEngine.Bindings.VisibleToOtherModules]
		internal IntPtr m_Ptr;

		[Token(Token = "0x17000002")]
		public byte[] data
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x3045C6C", Offset = "0x3041C6C", VA = "0x3045C6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public string text
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x3045C78", Offset = "0x3041C78", VA = "0x3045C78")]
			get
			{
				return null;
			}
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3045B44", Offset = "0x3041B44", VA = "0x3045B44")]
		[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
		private extern void Release();

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3045B80", Offset = "0x3041B80", VA = "0x3045B80")]
		[UnityEngine.Bindings.VisibleToOtherModules]
		internal DownloadHandler()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3045B88", Offset = "0x3041B88", VA = "0x3045B88", Slot = "1")]
		~DownloadHandler()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3045C14", Offset = "0x3041C14", VA = "0x3045C14", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3045C84", Offset = "0x3041C84", VA = "0x3045C84", Slot = "6")]
		protected virtual NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3045C90", Offset = "0x3041C90", VA = "0x3045C90", Slot = "7")]
		protected virtual byte[] GetData()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3045D14", Offset = "0x3041D14", VA = "0x3045D14", Slot = "8")]
		protected virtual string GetText()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3045DD4", Offset = "0x3041DD4", VA = "0x3045DD4")]
		private Encoding GetTextEncoder()
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3046044", Offset = "0x3042044", VA = "0x3046044")]
		private extern string GetContentType();

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3046080", Offset = "0x3042080", VA = "0x3046080", Slot = "9")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		protected virtual bool ReceiveData(byte[] data, int dataLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3046088", Offset = "0x3042088", VA = "0x3046088", Slot = "10")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		protected virtual void ReceiveContentLengthHeader(ulong contentLength)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3046094", Offset = "0x3042094", VA = "0x3046094", Slot = "11")]
		[Obsolete("Use ReceiveContentLengthHeader")]
		protected virtual void ReceiveContentLength(int contentLength)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3046098", Offset = "0x3042098", VA = "0x3046098", Slot = "12")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		protected virtual void CompleteContent()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x304609C", Offset = "0x304209C", VA = "0x304609C", Slot = "13")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		protected virtual float GetProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000021")]
		protected static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x30460A4", Offset = "0x30420A4", VA = "0x30460A4")]
		[UnityEngine.Bindings.NativeThrows]
		[UnityEngine.Bindings.VisibleToOtherModules]
		internal unsafe static extern byte* InternalGetByteArray(DownloadHandler dh, out int length);

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3045C94", Offset = "0x3041C94", VA = "0x3045C94")]
		internal static byte[] InternalGetByteArray(DownloadHandler dh)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30460E8", Offset = "0x30420E8", VA = "0x30460E8")]
		internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray)
		{
			return default(NativeArray<byte>);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30461CC", Offset = "0x30421CC", VA = "0x30461CC")]
		internal static void DisposeNativeArray(ref NativeArray<byte> data)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3046210", Offset = "0x3042210", VA = "0x3046210")]
		internal unsafe static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length)
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000007")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
	public sealed class DownloadHandlerBuffer : DownloadHandler
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private NativeArray<byte> m_NativeData;

		[MethodImpl(4096)]
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3046278", Offset = "0x3042278", VA = "0x3046278")]
		private static extern IntPtr Create(DownloadHandlerBuffer obj);

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x30462B4", Offset = "0x30422B4", VA = "0x30462B4")]
		private void InternalCreateBuffer()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x30462F8", Offset = "0x30422F8", VA = "0x30462F8")]
		public DownloadHandlerBuffer()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3046344", Offset = "0x3042344", VA = "0x3046344", Slot = "6")]
		protected override NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x304634C", Offset = "0x304234C", VA = "0x304634C", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000008")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
	[UnityEngine.Bindings.NativeHeader("UnityWebRequestScriptingClasses.h")]
	[UnityEngine.Scripting.UsedByNativeCode]
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		[Token(Token = "0x17000004")]
		public UnityWebRequest webRequest
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x3046394", Offset = "0x3042394", VA = "0x3046394")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x304639C", Offset = "0x304239C", VA = "0x304639C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x30463A4", Offset = "0x30423A4", VA = "0x30463A4")]
		public UnityWebRequestAsyncOperation()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000009")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
	public class UnityWebRequest : IDisposable
	{
		[Token(Token = "0x200000A")]
		internal enum UnityWebRequestMethod
		{
			[Token(Token = "0x4000020")]
			Get,
			[Token(Token = "0x4000021")]
			Post,
			[Token(Token = "0x4000022")]
			Put,
			[Token(Token = "0x4000023")]
			Head,
			[Token(Token = "0x4000024")]
			Custom
		}

		[Token(Token = "0x200000B")]
		internal enum UnityWebRequestError
		{
			[Token(Token = "0x4000026")]
			OK,
			[Token(Token = "0x4000027")]
			OKCached,
			[Token(Token = "0x4000028")]
			Unknown,
			[Token(Token = "0x4000029")]
			SDKError,
			[Token(Token = "0x400002A")]
			UnsupportedProtocol,
			[Token(Token = "0x400002B")]
			MalformattedUrl,
			[Token(Token = "0x400002C")]
			CannotResolveProxy,
			[Token(Token = "0x400002D")]
			CannotResolveHost,
			[Token(Token = "0x400002E")]
			CannotConnectToHost,
			[Token(Token = "0x400002F")]
			AccessDenied,
			[Token(Token = "0x4000030")]
			GenericHttpError,
			[Token(Token = "0x4000031")]
			WriteError,
			[Token(Token = "0x4000032")]
			ReadError,
			[Token(Token = "0x4000033")]
			OutOfMemory,
			[Token(Token = "0x4000034")]
			Timeout,
			[Token(Token = "0x4000035")]
			HTTPPostError,
			[Token(Token = "0x4000036")]
			SSLCannotConnect,
			[Token(Token = "0x4000037")]
			Aborted,
			[Token(Token = "0x4000038")]
			TooManyRedirects,
			[Token(Token = "0x4000039")]
			ReceivedNoData,
			[Token(Token = "0x400003A")]
			SSLNotSupported,
			[Token(Token = "0x400003B")]
			FailedToSendData,
			[Token(Token = "0x400003C")]
			FailedToReceiveData,
			[Token(Token = "0x400003D")]
			SSLCertificateError,
			[Token(Token = "0x400003E")]
			SSLCipherNotAvailable,
			[Token(Token = "0x400003F")]
			SSLCACertError,
			[Token(Token = "0x4000040")]
			UnrecognizedContentEncoding,
			[Token(Token = "0x4000041")]
			LoginFailed,
			[Token(Token = "0x4000042")]
			SSLShutdownFailed,
			[Token(Token = "0x4000043")]
			RedirectLimitInvalid,
			[Token(Token = "0x4000044")]
			InvalidRedirect,
			[Token(Token = "0x4000045")]
			CannotModifyRequest,
			[Token(Token = "0x4000046")]
			HeaderNameContainsInvalidCharacters,
			[Token(Token = "0x4000047")]
			HeaderValueContainsInvalidCharacters,
			[Token(Token = "0x4000048")]
			CannotOverrideSystemHeaders,
			[Token(Token = "0x4000049")]
			AlreadySent,
			[Token(Token = "0x400004A")]
			InvalidMethod,
			[Token(Token = "0x400004B")]
			NotImplemented,
			[Token(Token = "0x400004C")]
			NoInternetConnection,
			[Token(Token = "0x400004D")]
			DataProcessingError,
			[Token(Token = "0x400004E")]
			InsecureConnectionNotAllowed
		}

		[Token(Token = "0x200000C")]
		public enum Result
		{
			[Token(Token = "0x4000050")]
			InProgress,
			[Token(Token = "0x4000051")]
			Success,
			[Token(Token = "0x4000052")]
			ConnectionError,
			[Token(Token = "0x4000053")]
			ProtocolError,
			[Token(Token = "0x4000054")]
			DataProcessingError
		}

		[NonSerialized]
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[NonSerialized]
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal DownloadHandler m_DownloadHandler;

		[NonSerialized]
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal UploadHandler m_UploadHandler;

		[NonSerialized]
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal CertificateHandler m_CertificateHandler;

		[NonSerialized]
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Uri m_Uri;

		[Token(Token = "0x17000005")]
		public bool disposeCertificateHandlerOnDispose
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x3046424", Offset = "0x3042424", VA = "0x3046424")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x304642C", Offset = "0x304242C", VA = "0x304642C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool disposeDownloadHandlerOnDispose
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x3046434", Offset = "0x3042434", VA = "0x3046434")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x304643C", Offset = "0x304243C", VA = "0x304643C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool disposeUploadHandlerOnDispose
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x3046444", Offset = "0x3042444", VA = "0x3046444")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x304644C", Offset = "0x304244C", VA = "0x304644C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public string method
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x30466E8", Offset = "0x30426E8", VA = "0x30466E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string error
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x3047008", Offset = "0x3043008", VA = "0x3047008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public string url
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x3047224", Offset = "0x3043224", VA = "0x3047224")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x30465E8", Offset = "0x30425E8", VA = "0x30465E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public extern long responseCode
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x30471E8", Offset = "0x30431E8", VA = "0x30471E8")]
			get;
		}

		[Token(Token = "0x1700000C")]
		public extern bool isModifiable
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x3046E4C", Offset = "0x3042E4C", VA = "0x3046E4C")]
			[UnityEngine.Bindings.NativeMethod("IsModifiable")]
			get;
		}

		[Token(Token = "0x1700000D")]
		public bool isDone
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x30473E0", Offset = "0x30433E0", VA = "0x30473E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public extern Result result
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x30471AC", Offset = "0x30431AC", VA = "0x30471AC")]
			[UnityEngine.Bindings.NativeMethod("GetResult")]
			get;
		}

		[Token(Token = "0x1700000F")]
		public UploadHandler uploadHandler
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x3046C74", Offset = "0x3042C74", VA = "0x3046C74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x3046A14", Offset = "0x3042A14", VA = "0x3046A14")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public DownloadHandler downloadHandler
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x3046C6C", Offset = "0x3042C6C", VA = "0x3046C6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x3046910", Offset = "0x3042910", VA = "0x3046910")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public CertificateHandler certificateHandler
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x3046C7C", Offset = "0x3042C7C", VA = "0x3046C7C")]
			get
			{
				return null;
			}
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x30463AC", Offset = "0x30423AC", VA = "0x30463AC")]
		[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
		[UnityEngine.Bindings.NativeConditional("ENABLE_UNITYWEBREQUEST")]
		private static extern string GetWebErrorString(UnityWebRequestError err);

		[MethodImpl(4096)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x30463E8", Offset = "0x30423E8", VA = "0x30463E8")]
		[UnityEngine.Bindings.VisibleToOtherModules]
		internal static extern string GetHTTPStatusString(long responseCode);

		[MethodImpl(4096)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3046454", Offset = "0x3042454", VA = "0x3046454")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern IntPtr Create();

		[MethodImpl(4096)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x304647C", Offset = "0x304247C", VA = "0x304647C")]
		[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
		private extern void Release();

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x30464B8", Offset = "0x30424B8", VA = "0x30464B8")]
		internal void InternalDestroy()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3046574", Offset = "0x3042574", VA = "0x3046574")]
		private void InternalSetDefaults()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3046588", Offset = "0x3042588", VA = "0x3046588")]
		public UnityWebRequest(string url)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3046670", Offset = "0x3042670", VA = "0x3046670")]
		public UnityWebRequest(string url, string method)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3046870", Offset = "0x3042870", VA = "0x3046870")]
		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3046B18", Offset = "0x3042B18", VA = "0x3046B18", Slot = "1")]
		~UnityWebRequest()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3046C04", Offset = "0x3042C04", VA = "0x3046C04", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3046BA4", Offset = "0x3042BA4", VA = "0x3046BA4")]
		private void DisposeHandlers()
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3046C84", Offset = "0x3042C84", VA = "0x3046C84")]
		[UnityEngine.Bindings.NativeThrows]
		internal extern UnityWebRequestAsyncOperation BeginWebRequest();

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3046CC0", Offset = "0x3042CC0", VA = "0x3046CC0")]
		public UnityWebRequestAsyncOperation SendWebRequest()
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3046538", Offset = "0x3042538", VA = "0x3046538")]
		[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
		public extern void Abort();

		[MethodImpl(4096)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3046D08", Offset = "0x3042D08", VA = "0x3046D08")]
		private extern UnityWebRequestError SetMethod(UnityWebRequestMethod methodType);

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3046D4C", Offset = "0x3042D4C", VA = "0x3046D4C")]
		internal void InternalSetMethod(UnityWebRequestMethod methodType)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3046E88", Offset = "0x3042E88", VA = "0x3046E88")]
		private extern UnityWebRequestError SetCustomMethod(string customMethodName);

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3046ECC", Offset = "0x3042ECC", VA = "0x3046ECC")]
		internal void InternalSetCustomMethod(string customMethodName)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3046FCC", Offset = "0x3042FCC", VA = "0x3046FCC")]
		private extern UnityWebRequestError GetError();

		[MethodImpl(4096)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3047260", Offset = "0x3043260", VA = "0x3047260")]
		private extern string GetUrl();

		[MethodImpl(4096)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x304739C", Offset = "0x304339C", VA = "0x304739C")]
		private extern UnityWebRequestError SetUrl(string url);

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x304729C", Offset = "0x304329C", VA = "0x304729C")]
		private void InternalSetUrl(string url)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3047428", Offset = "0x3043428", VA = "0x3047428")]
		[UnityEngine.Bindings.NativeMethod("SetRequestHeader")]
		internal extern UnityWebRequestError InternalSetRequestHeader(string name, string value);

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x304747C", Offset = "0x304347C", VA = "0x304747C")]
		public void SetRequestHeader(string name, string value)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x30475F4", Offset = "0x30435F4", VA = "0x30475F4")]
		private extern UnityWebRequestError SetUploadHandler(UploadHandler uh);

		[MethodImpl(4096)]
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3047638", Offset = "0x3043638", VA = "0x3047638")]
		private extern UnityWebRequestError SetDownloadHandler(DownloadHandler dh);

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x304767C", Offset = "0x304367C", VA = "0x304767C")]
		public static UnityWebRequest Get(string uri)
		{
			return null;
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x200000D")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
	public class UploadHandler : IDisposable
	{
		[NonSerialized]
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		[Token(Token = "0x17000012")]
		public string contentType
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x3047848", Offset = "0x3043848", VA = "0x3047848")]
			set
			{
			}
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3047720", Offset = "0x3043720", VA = "0x3047720")]
		[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
		private extern void Release();

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x304775C", Offset = "0x304375C", VA = "0x304775C")]
		internal UploadHandler()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3047764", Offset = "0x3043764", VA = "0x3047764", Slot = "1")]
		~UploadHandler()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x30477F0", Offset = "0x30437F0", VA = "0x30477F0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3047854", Offset = "0x3043854", VA = "0x3047854", Slot = "6")]
		internal virtual void SetContentType(string newContentType)
		{
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3047898", Offset = "0x3043898", VA = "0x3047898")]
		[UnityEngine.Bindings.NativeMethod("SetContentType")]
		private extern void InternalSetContentType(string newContentType);
	}
	[StructLayout(0)]
	[Token(Token = "0x200000E")]
	[UnityEngine.Bindings.NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
	public sealed class UploadHandlerRaw : UploadHandler
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private NativeArray<byte> m_Payload;

		[MethodImpl(4096)]
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x30478DC", Offset = "0x30438DC", VA = "0x30478DC")]
		private unsafe static extern IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength);

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3047930", Offset = "0x3043930", VA = "0x3047930")]
		public UploadHandlerRaw(byte[] data)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x30479BC", Offset = "0x30439BC", VA = "0x30479BC")]
		public UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3047AB0", Offset = "0x3043AB0", VA = "0x3047AB0", Slot = "5")]
		public override void Dispose()
		{
		}
	}
}
