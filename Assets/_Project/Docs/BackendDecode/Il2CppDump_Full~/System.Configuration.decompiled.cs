using System;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using Il2CppDummyDll;

[assembly: AssemblyVersion("4.0.0.0")]
namespace System.Configuration
{
	[Token(Token = "0x2000002")]
	[DefaultMember("Item")]
	public abstract class ConfigurationElement
	{
		[Token(Token = "0x17000001")]
		protected internal virtual ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x271C754", Offset = "0x2718754", VA = "0x271C754", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x271C78C", Offset = "0x271878C", VA = "0x271C78C", Slot = "5")]
		protected internal virtual bool IsModified()
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x271C7C4", Offset = "0x27187C4", VA = "0x271C7C4", Slot = "6")]
		protected internal virtual void Reset(ConfigurationElement parentElement)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x271C7FC", Offset = "0x27187FC", VA = "0x271C7FC", Slot = "7")]
		protected internal virtual void ResetModified()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public abstract class ConfigurationSection : ConfigurationElement
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x271C834", Offset = "0x2718834", VA = "0x271C834", Slot = "8")]
		protected internal virtual void DeserializeSection(XmlReader reader)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x271C86C", Offset = "0x271886C", VA = "0x271C86C", Slot = "5")]
		protected internal override bool IsModified()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x271C8A4", Offset = "0x27188A4", VA = "0x271C8A4", Slot = "7")]
		protected internal override void ResetModified()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x271C8DC", Offset = "0x27188DC", VA = "0x271C8DC", Slot = "9")]
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			return null;
		}
	}
	[Token(Token = "0x2000004")]
	public enum ConfigurationSaveMode
	{
		[Token(Token = "0x4000002")]
		Full = 2,
		[Token(Token = "0x4000003")]
		Minimal = 1,
		[Token(Token = "0x4000004")]
		Modified = 0
	}
	[Token(Token = "0x2000005")]
	[DefaultMember("Item")]
	public class ConfigurationPropertyCollection
	{
	}
	[Token(Token = "0x2000006")]
	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement
	{
	}
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class ConfigurationCollectionAttribute : Attribute
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x271C914", Offset = "0x2718914", VA = "0x271C914")]
		public ConfigurationCollectionAttribute(Type itemType)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class ConfigurationSectionGroup
	{
	}
	[Token(Token = "0x2000009")]
	public sealed class IgnoreSection : ConfigurationSection
	{
		[Token(Token = "0x17000002")]
		protected internal override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x271C950", Offset = "0x2718950", VA = "0x271C950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x271C918", Offset = "0x2718918", VA = "0x271C918")]
		public IgnoreSection()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x271C988", Offset = "0x2718988", VA = "0x271C988", Slot = "8")]
		protected internal override void DeserializeSection(XmlReader xmlReader)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x271C9C0", Offset = "0x27189C0", VA = "0x271C9C0", Slot = "5")]
		protected internal override bool IsModified()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x271C9F8", Offset = "0x27189F8", VA = "0x271C9F8", Slot = "6")]
		protected internal override void Reset(ConfigurationElement parentSection)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x271CA30", Offset = "0x2718A30", VA = "0x271CA30", Slot = "7")]
		protected internal override void ResetModified()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x271CA68", Offset = "0x2718A68", VA = "0x271CA68", Slot = "9")]
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode)
		{
			return null;
		}
	}
}
namespace Unity
{
	[Token(Token = "0x200000A")]
	internal sealed class ThrowStub : ObjectDisposedException
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x271CAA0", Offset = "0x2718AA0", VA = "0x271CAA0")]
		public static void ThrowNotSupportedException()
		{
		}
	}
}
