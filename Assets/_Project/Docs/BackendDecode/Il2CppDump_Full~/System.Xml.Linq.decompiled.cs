using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using Il2CppDummyDll;

[assembly: AssemblyVersion("4.0.0.0")]
[Token(Token = "0x2000002")]
internal static class SR
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x28B8AD4", Offset = "0x28B4AD4", VA = "0x28B8AD4")]
	internal static string Format(string resourceFormat, object p1)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x28B8B44", Offset = "0x28B4B44", VA = "0x28B8B44")]
	internal static string Format(string resourceFormat, object p1, object p2)
	{
		return null;
	}
}
namespace System.Xml.Linq
{
	[Token(Token = "0x2000003")]
	internal class BaseUriAnnotation
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		internal string baseUri;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28B8BBC", Offset = "0x28B4BBC", VA = "0x28B8BBC")]
		public BaseUriAnnotation(string baseUri)
		{
		}
	}
	[Token(Token = "0x2000004")]
	internal class LineInfoAnnotation
	{
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		internal int lineNumber;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x14")]
		internal int linePosition;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x28B8BE4", Offset = "0x28B4BE4", VA = "0x28B8BE4")]
		public LineInfoAnnotation(int lineNumber, int linePosition)
		{
		}
	}
	[Token(Token = "0x2000005")]
	internal class LineInfoEndElementAnnotation : LineInfoAnnotation
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x28B8C10", Offset = "0x28B4C10", VA = "0x28B8C10")]
		public LineInfoEndElementAnnotation(int lineNumber, int linePosition)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class XAttribute : XObject
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		internal XAttribute next;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		internal XName name;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		internal string value;

		[Token(Token = "0x17000001")]
		public bool IsNamespaceDeclaration
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x28B9378", Offset = "0x28B5378", VA = "0x28B9378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public XName Name
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x28B942C", Offset = "0x28B542C", VA = "0x28B942C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x28B9434", Offset = "0x28B5434", VA = "0x28B9434", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000004")]
		public string Value
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x28B943C", Offset = "0x28B543C", VA = "0x28B943C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x28B8C3C", Offset = "0x28B4C3C", VA = "0x28B8C3C")]
		public XAttribute(XName name, object value)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x28B9300", Offset = "0x28B5300", VA = "0x28B9300")]
		public XAttribute(XAttribute other)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x28B9444", Offset = "0x28B5444", VA = "0x28B9444", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x28B9778", Offset = "0x28B5778", VA = "0x28B9778")]
		internal string GetPrefixOfNamespace(XNamespace ns)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x28B90D0", Offset = "0x28B50D0", VA = "0x28B90D0")]
		private static void ValidateAttribute(XName name, string value)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class XCData : XText
	{
		[Token(Token = "0x17000005")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x28B9BB8", Offset = "0x28B5BB8", VA = "0x28B9BB8", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x28B9AC4", Offset = "0x28B5AC4", VA = "0x28B9AC4")]
		public XCData(string value)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x28B9B3C", Offset = "0x28B5B3C", VA = "0x28B9B3C")]
		public XCData(XCData other)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x28B9BC0", Offset = "0x28B5BC0", VA = "0x28B9BC0", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x28B9C2C", Offset = "0x28B5C2C", VA = "0x28B9C2C", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public class XComment : XNode
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		internal string value;

		[Token(Token = "0x17000006")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x28B9D78", Offset = "0x28B5D78", VA = "0x28B9D78", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000007")]
		public string Value
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x28B9D80", Offset = "0x28B5D80", VA = "0x28B9D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x28B9C84", Offset = "0x28B5C84", VA = "0x28B9C84")]
		public XComment(string value)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x28B9D00", Offset = "0x28B5D00", VA = "0x28B9D00")]
		public XComment(XComment other)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x28B9D88", Offset = "0x28B5D88", VA = "0x28B9D88", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x28B9DF4", Offset = "0x28B5DF4", VA = "0x28B9DF4", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public abstract class XContainer : XNode
	{
		[Token(Token = "0x200000A")]
		private sealed class ContentReader
		{
			[Token(Token = "0x4000009")]
			[FieldOffset(Offset = "0x10")]
			private readonly NamespaceCache _eCache;

			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x20")]
			private readonly NamespaceCache _aCache;

			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x30")]
			private readonly IXmlLineInfo _lineInfo;

			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x38")]
			private XContainer _currentContainer;

			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x40")]
			private string _baseUri;

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x28BB54C", Offset = "0x28B754C", VA = "0x28BB54C")]
			public ContentReader(XContainer rootContainer)
			{
			}

			[Token(Token = "0x6000032")]
			[Address(RVA = "0x28BBC8C", Offset = "0x28B7C8C", VA = "0x28BBC8C")]
			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x28BB574", Offset = "0x28B7574", VA = "0x28BB574")]
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r)
			{
				return default(bool);
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x28BBD34", Offset = "0x28B7D34", VA = "0x28BBD34")]
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class <Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x18")]
			private XNode <>2__current;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x28")]
			public XContainer <>4__this;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x30")]
			private XNode <n>5__2;

			[Token(Token = "0x17000009")]
			private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current
			{
				[Token(Token = "0x6000038")]
				[Address(RVA = "0x28BD140", Offset = "0x28B9140", VA = "0x28BD140", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x28BD180", Offset = "0x28B9180", VA = "0x28BD180", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x28BAD5C", Offset = "0x28B6D5C", VA = "0x28BAD5C")]
			[DebuggerHidden]
			public <Nodes>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x28BD0AC", Offset = "0x28B90AC", VA = "0x28BD0AC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x28BD0B0", Offset = "0x28B90B0", VA = "0x28BD0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x28BD148", Offset = "0x28B9148", VA = "0x28BD148", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x28BD188", Offset = "0x28B9188", VA = "0x28BD188", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x28BD224", Offset = "0x28B9224", VA = "0x28BD224", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		internal object content;

		[Token(Token = "0x17000008")]
		public XNode LastNode
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x28BA048", Offset = "0x28B6048", VA = "0x28BA048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x28B9E4C", Offset = "0x28B5E4C", VA = "0x28B9E4C")]
		internal XContainer()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x28B9E54", Offset = "0x28B5E54", VA = "0x28B9E54")]
		internal XContainer(XContainer other)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x28BA184", Offset = "0x28B6184", VA = "0x28BA184")]
		public void Add(object content)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x28BACE8", Offset = "0x28B6CE8", VA = "0x28BACE8")]
		[IteratorStateMachine(typeof(<Nodes>d__18))]
		public IEnumerable<XNode> Nodes()
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x28BAD90", Offset = "0x28B6D90", VA = "0x28BAD90", Slot = "11")]
		internal virtual void AddAttribute(XAttribute a)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x28BAD94", Offset = "0x28B6D94", VA = "0x28BAD94", Slot = "12")]
		internal virtual void AddAttributeSkipNotify(XAttribute a)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x28BA5DC", Offset = "0x28B65DC", VA = "0x28BA5DC")]
		internal void AddContentSkipNotify(object content)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x28BA99C", Offset = "0x28B699C", VA = "0x28BA99C")]
		internal void AddNode(XNode n)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x28BAD98", Offset = "0x28B6D98", VA = "0x28BAD98")]
		internal void AddNodeSkipNotify(XNode n)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x28BAA1C", Offset = "0x28B6A1C", VA = "0x28BAA1C")]
		internal void AddString(string s)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x28BAE18", Offset = "0x28B6E18", VA = "0x28BAE18")]
		internal void AddStringSkipNotify(string s)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x28BB014", Offset = "0x28B7014", VA = "0x28BB014")]
		internal void AppendNode(XNode n)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x28B9F88", Offset = "0x28B5F88", VA = "0x28B9F88")]
		internal void AppendNodeSkipNotify(XNode n)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x28BB370", Offset = "0x28B7370", VA = "0x28BB370", Slot = "9")]
		internal override void AppendText(StringBuilder sb)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x28BAF68", Offset = "0x28B6F68", VA = "0x28BAF68")]
		internal void ConvertTextToNode()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x28B8D04", Offset = "0x28B4D04", VA = "0x28B8D04")]
		internal static string GetStringValue(object value)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x28BB458", Offset = "0x28B7458", VA = "0x28BB458")]
		internal void ReadContentFrom(XmlReader r)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x28BBB64", Offset = "0x28B7B64", VA = "0x28BBB64")]
		internal void ReadContentFrom(XmlReader r, LoadOptions o)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x28BC948", Offset = "0x28B8948", VA = "0x28BC948")]
		internal void RemoveNode(XNode n)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x28BCAE4", Offset = "0x28B8AE4", VA = "0x28BCAE4", Slot = "13")]
		internal virtual void ValidateNode(XNode node, XNode previous)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x28BCAE8", Offset = "0x28B8AE8", VA = "0x28BCAE8", Slot = "14")]
		internal virtual void ValidateString(string s)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x28BCAEC", Offset = "0x28B8AEC", VA = "0x28BCAEC")]
		internal void WriteContentTo(XmlWriter writer)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class XDeclaration
	{
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		private string _version;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		private string _encoding;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		private string _standalone;

		[Token(Token = "0x1700000B")]
		public string Encoding
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x28BD2E4", Offset = "0x28B92E4", VA = "0x28BD2E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public string Standalone
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x28BD2EC", Offset = "0x28B92EC", VA = "0x28BD2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public string Version
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x28BD2F4", Offset = "0x28B92F4", VA = "0x28BD2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x28BD228", Offset = "0x28B9228", VA = "0x28BD228")]
		public XDeclaration(string version, string encoding, string standalone)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x28BD264", Offset = "0x28B9264", VA = "0x28BD264")]
		public XDeclaration(XDeclaration other)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x28BD2FC", Offset = "0x28B92FC", VA = "0x28BD2FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200000D")]
	public class XDocument : XContainer
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		private XDeclaration _declaration;

		[Token(Token = "0x1700000E")]
		public XDeclaration Declaration
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x28BD5E4", Offset = "0x28B95E4", VA = "0x28BD5E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x28BD5EC", Offset = "0x28B95EC", VA = "0x28BD5EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x28BD5F4", Offset = "0x28B95F4", VA = "0x28BD5F4", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000010")]
		public XElement Root
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x28BD5FC", Offset = "0x28B95FC", VA = "0x28BD5FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x28BD564", Offset = "0x28B9564", VA = "0x28BD564")]
		public XDocument()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x28BD56C", Offset = "0x28B956C", VA = "0x28BD56C")]
		public XDocument(XDocument other)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x28BD644", Offset = "0x28B9644", VA = "0x28BD644", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x28BD770", Offset = "0x28B9770", VA = "0x28BD770", Slot = "11")]
		internal override void AddAttribute(XAttribute a)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x28BD7BC", Offset = "0x28B97BC", VA = "0x28BD7BC", Slot = "12")]
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x28BD808", Offset = "0x28B9808", VA = "0x28BD808", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		private T GetFirstNode<T>() where T : XNode
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x28BD860", Offset = "0x28B9860", VA = "0x28BD860")]
		internal static bool IsWhitespace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x28BD8EC", Offset = "0x28B98EC", VA = "0x28BD8EC", Slot = "13")]
		internal override void ValidateNode(XNode node, XNode previous)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x28BDA9C", Offset = "0x28B9A9C", VA = "0x28BDA9C")]
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x28BDBBC", Offset = "0x28B9BBC", VA = "0x28BDBBC", Slot = "14")]
		internal override void ValidateString(string s)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class XDocumentType : XNode
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x28")]
		private string _name;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x30")]
		private string _publicId;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x38")]
		private string _systemId;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x40")]
		private string _internalSubset;

		[Token(Token = "0x17000011")]
		public string InternalSubset
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x28BDC9C", Offset = "0x28B9C9C", VA = "0x28BDC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public string Name
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x28BDCA4", Offset = "0x28B9CA4", VA = "0x28BDCA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x28BDCAC", Offset = "0x28B9CAC", VA = "0x28BDCAC", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000014")]
		public string PublicId
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x28BDCB4", Offset = "0x28B9CB4", VA = "0x28BDCB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public string SystemId
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x28BDCBC", Offset = "0x28B9CBC", VA = "0x28BDCBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x28BCDF0", Offset = "0x28B8DF0", VA = "0x28BCDF0")]
		public XDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x28BDC1C", Offset = "0x28B9C1C", VA = "0x28BDC1C")]
		public XDocumentType(XDocumentType other)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x28BDCC4", Offset = "0x28B9CC4", VA = "0x28BDCC4", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x28BDD30", Offset = "0x28B9D30", VA = "0x28BDD30", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	[XmlSchemaProvider(null, IsAny = true)]
	[System.Xml.Serialization.XmlTypeConvertor("ConvertForAssignment")]
	public class XElement : XContainer, IXmlSerializable
	{
		[Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class <GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x18")]
			private XAttribute <>2__current;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x28")]
			public XElement <>4__this;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x30")]
			private XName name;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x38")]
			public XName <>3__name;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x40")]
			private XAttribute <a>5__2;

			[Token(Token = "0x1700001B")]
			private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0x28BF1F8", Offset = "0x28BB1F8", VA = "0x28BF1F8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x28BF238", Offset = "0x28BB238", VA = "0x28BF238", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x28BE878", Offset = "0x28BA878", VA = "0x28BE878")]
			[DebuggerHidden]
			public <GetAttributes>d__116(int <>1__state)
			{
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x28BF14C", Offset = "0x28BB14C", VA = "0x28BF14C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x28BF150", Offset = "0x28BB150", VA = "0x28BF150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x28BF200", Offset = "0x28BB200", VA = "0x28BF200", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x28BF240", Offset = "0x28BB240", VA = "0x28BF240", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x28BF2E4", Offset = "0x28BB2E4", VA = "0x28BF2E4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		internal XName name;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		internal XAttribute lastAttr;

		[Token(Token = "0x17000016")]
		public bool HasAttributes
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x28BDE44", Offset = "0x28B9E44", VA = "0x28BDE44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool IsEmpty
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x28BDE54", Offset = "0x28B9E54", VA = "0x28BDE54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public XName Name
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x28BDE64", Offset = "0x28B9E64", VA = "0x28BDE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x28BDE6C", Offset = "0x28B9E6C", VA = "0x28BDE6C", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x1700001A")]
		public string Value
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x28BDE74", Offset = "0x28B9E74", VA = "0x28BDE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x28BCCC8", Offset = "0x28B8CC8", VA = "0x28BCCC8")]
		public XElement(XName name)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x28BDD88", Offset = "0x28B9D88", VA = "0x28BDD88")]
		public XElement(XElement other)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x28BAC6C", Offset = "0x28B6C6C", VA = "0x28BAC6C")]
		public XElement(XStreamingElement other)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x28BDF04", Offset = "0x28B9F04", VA = "0x28BDF04")]
		public XAttribute Attribute(XName name)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x28BDF40", Offset = "0x28B9F40", VA = "0x28BDF40")]
		public IEnumerable<XAttribute> Attributes()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x28B98B0", Offset = "0x28B58B0", VA = "0x28B98B0")]
		public string GetPrefixOfNamespace(XNamespace ns)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x28BE0C8", Offset = "0x28BA0C8", VA = "0x28BE0C8", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x28BE2E8", Offset = "0x28BA2E8", VA = "0x28BE2E8", Slot = "15")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x28BE2F0", Offset = "0x28BA2F0", VA = "0x28BE2F0", Slot = "16")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x28BE4FC", Offset = "0x28BA4FC", VA = "0x28BE4FC", Slot = "17")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x28BE508", Offset = "0x28BA508", VA = "0x28BE508", Slot = "11")]
		internal override void AddAttribute(XAttribute a)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x28BE718", Offset = "0x28BA718", VA = "0x28BE718", Slot = "12")]
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x28BE5F0", Offset = "0x28BA5F0", VA = "0x28BE5F0")]
		internal void AppendAttribute(XAttribute a)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x28BCD3C", Offset = "0x28B8D3C", VA = "0x28BCD3C")]
		internal void AppendAttributeSkipNotify(XAttribute a)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x28BE820", Offset = "0x28BA820", VA = "0x28BE820", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x28BDF48", Offset = "0x28B9F48", VA = "0x28BDF48")]
		[IteratorStateMachine(typeof(<GetAttributes>d__116))]
		private IEnumerable<XAttribute> GetAttributes(XName name)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x28BDFD4", Offset = "0x28B9FD4", VA = "0x28BDFD4")]
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x28BE484", Offset = "0x28BA484", VA = "0x28BE484")]
		private void ReadElementFrom(XmlReader r, LoadOptions o)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x28BE8AC", Offset = "0x28BA8AC", VA = "0x28BE8AC")]
		private void ReadElementFromImpl(XmlReader r, LoadOptions o)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x28BCF5C", Offset = "0x28B8F5C", VA = "0x28BCF5C")]
		internal void SetEndElementLineInfo(int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x28BF018", Offset = "0x28BB018", VA = "0x28BF018", Slot = "13")]
		internal override void ValidateNode(XNode node, XNode previous)
		{
		}
	}
	[Token(Token = "0x2000011")]
	internal sealed class XHashtable<TValue>
	{
		[Token(Token = "0x2000012")]
		public delegate string ExtractKeyDelegate(TValue value);

		[Token(Token = "0x2000013")]
		private sealed class XHashtableState
		{
			[Token(Token = "0x2000014")]
			private struct Entry
			{
				[Token(Token = "0x4000029")]
				[FieldOffset(Offset = "0x0")]
				public TValue Value;

				[Token(Token = "0x400002A")]
				[FieldOffset(Offset = "0x0")]
				public int HashCode;

				[Token(Token = "0x400002B")]
				[FieldOffset(Offset = "0x0")]
				public int Next;
			}

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x0")]
			private int[] _buckets;

			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			private Entry[] _entries;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x0")]
			private int _numEntries;

			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x0")]
			private ExtractKeyDelegate _extractKey;

			[Token(Token = "0x6000082")]
			public XHashtableState(ExtractKeyDelegate extractKey, int capacity)
			{
			}

			[Token(Token = "0x6000083")]
			public XHashtableState Resize()
			{
				return null;
			}

			[Token(Token = "0x6000084")]
			public bool TryGetValue(string key, int index, int count, out TValue value)
			{
				return default(bool);
			}

			[Token(Token = "0x6000085")]
			public bool TryAdd(TValue value, out TValue newValue)
			{
				return default(bool);
			}

			[Token(Token = "0x6000086")]
			private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex)
			{
				return default(bool);
			}

			[Token(Token = "0x6000087")]
			private static int ComputeHashCode(string key, int index, int count)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private XHashtableState _state;

		[Token(Token = "0x600007D")]
		public XHashtable(ExtractKeyDelegate extractKey, int capacity)
		{
		}

		[Token(Token = "0x600007E")]
		public bool TryGetValue(string key, int index, int count, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		public TValue Add(TValue value)
		{
			return (TValue)null;
		}
	}
	[Token(Token = "0x2000015")]
	internal struct NamespaceCache
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		private XNamespace _ns;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x8")]
		private string _namespaceName;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x28BCC38", Offset = "0x28B8C38", VA = "0x28BCC38")]
		public XNamespace Get(string namespaceName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	internal struct ElementWriter
	{
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private XmlWriter _writer;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x8")]
		private NamespaceResolver _resolver;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x28BE140", Offset = "0x28BA140", VA = "0x28BE140")]
		public ElementWriter(XmlWriter writer)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x28BE14C", Offset = "0x28BA14C", VA = "0x28BE14C")]
		public void WriteElement(XElement e)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x28BF5BC", Offset = "0x28BB5BC", VA = "0x28BF5BC")]
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x28BF2E8", Offset = "0x28BB2E8", VA = "0x28BF2E8")]
		private void PushAncestors(XElement e)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x28BF82C", Offset = "0x28BB82C", VA = "0x28BF82C")]
		private void PushElement(XElement e)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x28BF564", Offset = "0x28BB564", VA = "0x28BF564")]
		private void WriteEndElement()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x28BF590", Offset = "0x28BB590", VA = "0x28BF590")]
		private void WriteFullEndElement()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x28BF404", Offset = "0x28BB404", VA = "0x28BF404")]
		private void WriteStartElement(XElement e)
		{
		}
	}
	[Token(Token = "0x2000017")]
	internal struct NamespaceResolver
	{
		[Token(Token = "0x2000018")]
		private class NamespaceDeclaration
		{
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x10")]
			public string prefix;

			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x18")]
			public XNamespace ns;

			[Token(Token = "0x4000035")]
			[FieldOffset(Offset = "0x20")]
			public int scope;

			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x28")]
			public NamespaceDeclaration prev;

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x28BFA10", Offset = "0x28BBA10", VA = "0x28BFA10")]
			public NamespaceDeclaration()
			{
			}
		}

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private int _scope;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		private NamespaceDeclaration _declaration;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		private NamespaceDeclaration _rover;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x28BF900", Offset = "0x28BB900", VA = "0x28BF900")]
		public void PushScope()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x28BF9AC", Offset = "0x28BB9AC", VA = "0x28BF9AC")]
		public void PopScope()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x28BF910", Offset = "0x28BB910", VA = "0x28BF910")]
		public void Add(string prefix, XNamespace ns)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x28BF794", Offset = "0x28BB794", VA = "0x28BF794")]
		public void AddFirst(string prefix, XNamespace ns)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x28BF6B8", Offset = "0x28BB6B8", VA = "0x28BF6B8")]
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public enum XObjectChange
	{
		[Token(Token = "0x4000038")]
		Add,
		[Token(Token = "0x4000039")]
		Remove,
		[Token(Token = "0x400003A")]
		Name,
		[Token(Token = "0x400003B")]
		Value
	}
	[Token(Token = "0x200001A")]
	[Flags]
	public enum LoadOptions
	{
		[Token(Token = "0x400003D")]
		None = 0,
		[Token(Token = "0x400003E")]
		PreserveWhitespace = 1,
		[Token(Token = "0x400003F")]
		SetBaseUri = 2,
		[Token(Token = "0x4000040")]
		SetLineInfo = 4
	}
	[Token(Token = "0x200001B")]
	[Flags]
	public enum SaveOptions
	{
		[Token(Token = "0x4000042")]
		None = 0,
		[Token(Token = "0x4000043")]
		DisableFormatting = 1,
		[Token(Token = "0x4000044")]
		OmitDuplicateNamespaces = 2
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x10")]
		private XNamespace _ns;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x18")]
		private string _localName;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x20")]
		private int _hashCode;

		[Token(Token = "0x1700001D")]
		public string LocalName
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x28BFAD0", Offset = "0x28BBAD0", VA = "0x28BFAD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public XNamespace Namespace
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x28BFAD8", Offset = "0x28BBAD8", VA = "0x28BFAD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public string NamespaceName
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x28B9414", Offset = "0x28B5414", VA = "0x28B9414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x28BFA18", Offset = "0x28BBA18", VA = "0x28BFA18")]
		internal XName(XNamespace ns, string localName)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x28BFAE0", Offset = "0x28BBAE0", VA = "0x28BFAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x28BFB70", Offset = "0x28BBB70", VA = "0x28BFB70")]
		public static XName Get(string expandedName)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x28C0120", Offset = "0x28BC120", VA = "0x28C0120")]
		public static XName Get(string localName, string namespaceName)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x28C0144", Offset = "0x28BC144", VA = "0x28C0144")]
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x28C0150", Offset = "0x28BC150", VA = "0x28C0150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x28C015C", Offset = "0x28BC15C", VA = "0x28C015C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x28B8CF8", Offset = "0x28B4CF8", VA = "0x28B8CF8")]
		public static bool operator ==(XName left, XName right)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x28C0164", Offset = "0x28BC164", VA = "0x28C0164", Slot = "4")]
		private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x28C0170", Offset = "0x28BC170", VA = "0x28C0170", Slot = "5")]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x28C01A8", Offset = "0x28BC1A8", VA = "0x28C01A8")]
		internal XName()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public sealed class XNamespace
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private static XHashtable<WeakReference> s_namespaces;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		private static WeakReference s_refNone;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		private static WeakReference s_refXml;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		private static WeakReference s_refXmlns;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x10")]
		private string _namespaceName;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x18")]
		private int _hashCode;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x20")]
		private XHashtable<XName> _names;

		[Token(Token = "0x17000020")]
		public string NamespaceName
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x28C02DC", Offset = "0x28BC2DC", VA = "0x28C02DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public static XNamespace None
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x28C00B8", Offset = "0x28BC0B8", VA = "0x28C00B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public static XNamespace Xml
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x28C03CC", Offset = "0x28BC3CC", VA = "0x28C03CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public static XNamespace Xmlns
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x28C042C", Offset = "0x28BC42C", VA = "0x28C042C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x28C01E0", Offset = "0x28BC1E0", VA = "0x28C01E0")]
		internal XNamespace(string namespaceName)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x28BCC6C", Offset = "0x28B8C6C", VA = "0x28BCC6C")]
		public XName GetName(string localName)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x28C02E4", Offset = "0x28BC2E4", VA = "0x28C02E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x28BEDAC", Offset = "0x28BADAC", VA = "0x28BEDAC")]
		public static XNamespace Get(string namespaceName)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x28C048C", Offset = "0x28BC48C", VA = "0x28C048C")]
		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x28C0498", Offset = "0x28BC498", VA = "0x28C0498", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x28C04A4", Offset = "0x28BC4A4", VA = "0x28C04A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x28BDFC8", Offset = "0x28B9FC8", VA = "0x28BDFC8")]
		public static bool operator ==(XNamespace left, XNamespace right)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x28C04AC", Offset = "0x28BC4AC", VA = "0x28C04AC")]
		public static bool operator !=(XNamespace left, XNamespace right)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x28BFFB0", Offset = "0x28BBFB0", VA = "0x28BFFB0")]
		internal XName GetName(string localName, int index, int count)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x28BFCB8", Offset = "0x28BBCB8", VA = "0x28BFCB8")]
		internal static XNamespace Get(string namespaceName, int index, int count)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x28C04B8", Offset = "0x28BC4B8", VA = "0x28C04B8")]
		private static string ExtractLocalName(XName n)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x28C04CC", Offset = "0x28BC4CC", VA = "0x28C04CC")]
		private static string ExtractNamespace(WeakReference r)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x28C02EC", Offset = "0x28BC2EC", VA = "0x28C02EC")]
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName)
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	public abstract class XNode : XObject
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		internal XNode next;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x28B9CF8", Offset = "0x28B5CF8", VA = "0x28B9CF8")]
		internal XNode()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x28C0544", Offset = "0x28BC544", VA = "0x28C0544")]
		public void Remove()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x28C05A0", Offset = "0x28BC5A0", VA = "0x28C05A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		public abstract void WriteTo(XmlWriter writer);

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x28C0A60", Offset = "0x28BCA60", VA = "0x28C0A60", Slot = "9")]
		internal virtual void AppendText(StringBuilder sb)
		{
		}

		[Token(Token = "0x60000BC")]
		internal abstract XNode CloneNode();

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x28C069C", Offset = "0x28BC69C", VA = "0x28C069C")]
		private string GetXmlString(SaveOptions o)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public abstract class XObject : IXmlLineInfo
	{
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		internal XContainer parent;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		internal object annotations;

		[Token(Token = "0x17000024")]
		public string BaseUri
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x28BD020", Offset = "0x28B9020", VA = "0x28BD020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public abstract XmlNodeType NodeType
		{
			[Token(Token = "0x60000C0")]
			get;
		}

		[Token(Token = "0x17000026")]
		public XElement Parent
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x28C0A64", Offset = "0x28BCA64", VA = "0x28C0A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private int System.Xml.IXmlLineInfo.LineNumber
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x28C0C80", Offset = "0x28BCC80", VA = "0x28C0C80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		private int System.Xml.IXmlLineInfo.LinePosition
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x28C0CD4", Offset = "0x28BCCD4", VA = "0x28C0CD4", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		internal bool HasBaseUri
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x28BCFCC", Offset = "0x28B8FCC", VA = "0x28BCFCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x28B8CF0", Offset = "0x28B4CF0", VA = "0x28B8CF0")]
		internal XObject()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x28BEE08", Offset = "0x28BAE08", VA = "0x28BEE08")]
		public void AddAnnotation(object annotation)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x28C0AE0", Offset = "0x28BCAE0", VA = "0x28C0AE0")]
		private object AnnotationForSealedType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x28C0C2C", Offset = "0x28BCC2C", VA = "0x28C0C2C", Slot = "4")]
		private bool System.Xml.IXmlLineInfo.HasLineInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x28BB1D4", Offset = "0x28B71D4", VA = "0x28BB1D4")]
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x28BB128", Offset = "0x28B7128", VA = "0x28BB128")]
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x28BCE80", Offset = "0x28B8E80", VA = "0x28BCE80")]
		internal void SetBaseUri(string baseUri)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x28BCEEC", Offset = "0x28B8EEC", VA = "0x28BCEEC")]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x28BA56C", Offset = "0x28B656C", VA = "0x28BA56C")]
		internal bool SkipNotify()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x28C05BC", Offset = "0x28BC5BC", VA = "0x28C05BC")]
		internal SaveOptions GetSaveOptionsFromAnnotations()
		{
			return default(SaveOptions);
		}
	}
	[Token(Token = "0x2000020")]
	internal class XObjectChangeAnnotation
	{
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x10")]
		internal EventHandler<XObjectChangeEventArgs> changing;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		internal EventHandler<XObjectChangeEventArgs> changed;
	}
	[Token(Token = "0x2000021")]
	public class XObjectChangeEventArgs : EventArgs
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		private XObjectChange _objectChange;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x0")]
		public static readonly XObjectChangeEventArgs Add;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x8")]
		public static readonly XObjectChangeEventArgs Remove;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x10")]
		public static readonly XObjectChangeEventArgs Name;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x18")]
		public static readonly XObjectChangeEventArgs Value;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x28C0D28", Offset = "0x28BCD28", VA = "0x28C0D28")]
		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class XProcessingInstruction : XNode
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x28")]
		internal string target;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x30")]
		internal string data;

		[Token(Token = "0x1700002A")]
		public string Data
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x28C0F98", Offset = "0x28BCF98", VA = "0x28C0F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x28C0FA0", Offset = "0x28BCFA0", VA = "0x28C0FA0", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x1700002C")]
		public string Target
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x28C0FA8", Offset = "0x28BCFA8", VA = "0x28C0FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x28BCD70", Offset = "0x28B8D70", VA = "0x28BCD70")]
		public XProcessingInstruction(string target, string data)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x28C0F20", Offset = "0x28BCF20", VA = "0x28C0F20")]
		public XProcessingInstruction(XProcessingInstruction other)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x28C0FB0", Offset = "0x28BCFB0", VA = "0x28C0FB0", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x28C101C", Offset = "0x28BD01C", VA = "0x28C101C", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x28C0E48", Offset = "0x28BCE48", VA = "0x28C0E48")]
		private static void ValidateName(string name)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class XStreamingElement
	{
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		internal XName name;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		internal object content;
	}
	[Token(Token = "0x2000024")]
	public class XText : XNode
	{
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x28")]
		internal string text;

		[Token(Token = "0x1700002D")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x28C1074", Offset = "0x28BD074", VA = "0x28C1074", Slot = "7")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x1700002E")]
		public string Value
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x28C107C", Offset = "0x28BD07C", VA = "0x28C107C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x28BB280", Offset = "0x28B7280", VA = "0x28BB280")]
			set
			{
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x28B9AC8", Offset = "0x28B5AC8", VA = "0x28B9AC8")]
		public XText(string value)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x28B9B40", Offset = "0x28B5B40", VA = "0x28B9B40")]
		public XText(XText other)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x28C1084", Offset = "0x28BD084", VA = "0x28C1084", Slot = "8")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x28C1170", Offset = "0x28BD170", VA = "0x28C1170", Slot = "9")]
		internal override void AppendText(StringBuilder sb)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x28C1190", Offset = "0x28BD190", VA = "0x28C1190", Slot = "10")]
		internal override XNode CloneNode()
		{
			return null;
		}
	}
}
namespace System.Text
{
	[Token(Token = "0x2000025")]
	internal static class StringBuilderCache
	{
		[Token(Token = "0x400005E")]
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x28BD468", Offset = "0x28B9468", VA = "0x28BD468")]
		public static StringBuilder Acquire(int capacity = 16)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x28C11E8", Offset = "0x28BD1E8", VA = "0x28C11E8")]
		public static void Release(StringBuilder sb)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x28BD528", Offset = "0x28B9528", VA = "0x28BD528")]
		public static string GetStringAndRelease(StringBuilder sb)
		{
			return null;
		}
	}
}
namespace Unity
{
	[Token(Token = "0x2000026")]
	internal sealed class ThrowStub : ObjectDisposedException
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x28C1260", Offset = "0x28BD260", VA = "0x28C1260")]
		public static void ThrowNotSupportedException()
		{
		}
	}
}
