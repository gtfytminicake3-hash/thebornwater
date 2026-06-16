using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	internal sealed class AssetFileNameExtensionAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2E87650", Offset = "0x2E83650", VA = "0x2E87650")]
		public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions)
		{
		}
	}
	[Token(Token = "0x2000003")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	internal class ThreadAndSerializationSafeAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2E8767C", Offset = "0x2E8367C", VA = "0x2E8767C")]
		public ThreadAndSerializationSafeAttribute()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal class WritableAttribute : Attribute
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2E87684", Offset = "0x2E83684", VA = "0x2E87684")]
		public WritableAttribute()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class)]
	internal class RejectDragAndDropMaterial : Attribute
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2E8768C", Offset = "0x2E8368C", VA = "0x2E8768C")]
		public RejectDragAndDropMaterial()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Assembly)]
	[VisibleToOtherModules]
	internal class UnityEngineModuleAssembly : Attribute
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2E87694", Offset = "0x2E83694", VA = "0x2E87694")]
		public UnityEngineModuleAssembly()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	[VisibleToOtherModules]
	internal sealed class NativeClassAttribute : Attribute
	{
		[Token(Token = "0x17000001")]
		private string QualifiedNativeName
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2E8769C", Offset = "0x2E8369C", VA = "0x2E8769C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		private string Declaration
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2E876A4", Offset = "0x2E836A4", VA = "0x2E876A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2E876AC", Offset = "0x2E836AC", VA = "0x2E876AC")]
		public NativeClassAttribute(string qualifiedCppName)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2E8771C", Offset = "0x2E8371C", VA = "0x2E8771C")]
		public NativeClassAttribute(string qualifiedCppName, string declaration)
		{
		}
	}
	[Token(Token = "0x2000008")]
	[VisibleToOtherModules]
	internal sealed class UnityString
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2E87748", Offset = "0x2E83748", VA = "0x2E87748")]
		public static string Format(string fmt, params object[] args)
		{
			return null;
		}
	}
}
namespace UnityEngine.Bindings
{
	[Token(Token = "0x2000009")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	internal class VisibleToOtherModulesAttribute : Attribute
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2E877D0", Offset = "0x2E837D0", VA = "0x2E877D0")]
		public VisibleToOtherModulesAttribute()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2E877D8", Offset = "0x2E837D8", VA = "0x2E877D8")]
		public VisibleToOtherModulesAttribute(params string[] modules)
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeConditionalAttribute : Attribute
	{
		[Token(Token = "0x17000003")]
		public string Condition
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2E877E0", Offset = "0x2E837E0", VA = "0x2E877E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public string StubReturnStatement
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2E877E8", Offset = "0x2E837E8", VA = "0x2E877E8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool Enabled
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2E877F0", Offset = "0x2E837F0", VA = "0x2E877F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2E877F8", Offset = "0x2E837F8", VA = "0x2E877F8")]
		public NativeConditionalAttribute(string condition)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2E87828", Offset = "0x2E83828", VA = "0x2E87828")]
		public NativeConditionalAttribute(string condition, string stubReturnStatement)
		{
		}
	}
	[Token(Token = "0x200000B")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	internal class NativeHeaderAttribute : Attribute
	{
		[Token(Token = "0x17000006")]
		public string Header
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2E8785C", Offset = "0x2E8385C", VA = "0x2E8785C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E87864", Offset = "0x2E83864", VA = "0x2E87864")]
		public NativeHeaderAttribute(string header)
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	[VisibleToOtherModules]
	internal class NativeNameAttribute : Attribute
	{
		[Token(Token = "0x17000007")]
		public string Name
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2E87960", Offset = "0x2E83960", VA = "0x2E87960", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2E87968", Offset = "0x2E83968", VA = "0x2E87968")]
		public NativeNameAttribute(string name)
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal sealed class NativeWritableSelfAttribute : Attribute
	{
		[Token(Token = "0x17000008")]
		public bool WritableSelf
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2E87A64", Offset = "0x2E83A64", VA = "0x2E87A64", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2E87A6C", Offset = "0x2E83A6C", VA = "0x2E87A6C")]
		public NativeWritableSelfAttribute()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	internal class NativeMethodAttribute : Attribute
	{
		[Token(Token = "0x17000009")]
		public string Name
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2E87A8C", Offset = "0x2E83A8C", VA = "0x2E87A8C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool IsThreadSafe
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2E87A94", Offset = "0x2E83A94", VA = "0x2E87A94", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool IsFreeFunction
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2E87A9C", Offset = "0x2E83A9C", VA = "0x2E87A9C", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public bool ThrowsException
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2E87AA4", Offset = "0x2E83AA4", VA = "0x2E87AA4", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool HasExplicitThis
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2E87AAC", Offset = "0x2E83AAC", VA = "0x2E87AAC", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2E87AB4", Offset = "0x2E83AB4", VA = "0x2E87AB4")]
		public NativeMethodAttribute()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2E87ABC", Offset = "0x2E83ABC", VA = "0x2E87ABC")]
		public NativeMethodAttribute(string name)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2E87BB8", Offset = "0x2E83BB8", VA = "0x2E87BB8")]
		public NativeMethodAttribute(string name, bool isFreeFunction)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2E87BDC", Offset = "0x2E83BDC", VA = "0x2E87BDC")]
		public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
		{
		}
	}
	[Token(Token = "0x200000F")]
	[VisibleToOtherModules]
	internal enum TargetType
	{
		[Token(Token = "0x4000011")]
		Function,
		[Token(Token = "0x4000012")]
		Field
	}
	[Token(Token = "0x2000010")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Property)]
	internal class NativePropertyAttribute : NativeMethodAttribute
	{
		[Token(Token = "0x1700000E")]
		public TargetType TargetType
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2E87C08", Offset = "0x2E83C08", VA = "0x2E87C08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2E87C10", Offset = "0x2E83C10", VA = "0x2E87C10")]
		public NativePropertyAttribute()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2E87C18", Offset = "0x2E83C18", VA = "0x2E87C18")]
		public NativePropertyAttribute(string name)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2E87C1C", Offset = "0x2E83C1C", VA = "0x2E87C1C")]
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2E87C48", Offset = "0x2E83C48", VA = "0x2E87C48")]
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe)
		{
		}
	}
	[Token(Token = "0x2000011")]
	[VisibleToOtherModules]
	internal enum CodegenOptions
	{
		[Token(Token = "0x4000015")]
		Auto,
		[Token(Token = "0x4000016")]
		Custom,
		[Token(Token = "0x4000017")]
		Force
	}
	[Token(Token = "0x2000012")]
	[AttributeUsage(AttributeTargets.Class)]
	[VisibleToOtherModules]
	internal class NativeAsStructAttribute : Attribute
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2E87C84", Offset = "0x2E83C84", VA = "0x2E87C84")]
		public NativeAsStructAttribute()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	[VisibleToOtherModules]
	internal class NativeTypeAttribute : Attribute
	{
		[Token(Token = "0x1700000F")]
		public string Header
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2E87C8C", Offset = "0x2E83C8C", VA = "0x2E87C8C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string IntermediateScriptingStructName
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2E87C94", Offset = "0x2E83C94", VA = "0x2E87C94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public CodegenOptions CodegenOptions
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2E87C9C", Offset = "0x2E83C9C", VA = "0x2E87C9C", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2E87CA4", Offset = "0x2E83CA4", VA = "0x2E87CA4")]
		public NativeTypeAttribute()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2E87CC0", Offset = "0x2E83CC0", VA = "0x2E87CC0")]
		public NativeTypeAttribute(CodegenOptions codegenOptions)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2E87CE8", Offset = "0x2E83CE8", VA = "0x2E87CE8")]
		public NativeTypeAttribute(string header)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2E87DE8", Offset = "0x2E83DE8", VA = "0x2E87DE8")]
		public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
		{
		}
	}
	[Token(Token = "0x2000014")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal class NotNullAttribute : Attribute
	{
		[Token(Token = "0x17000012")]
		public string Exception
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2E87E18", Offset = "0x2E83E18", VA = "0x2E87E18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2E87E20", Offset = "0x2E83E20", VA = "0x2E87E20")]
		public NotNullAttribute(string exception = "ArgumentNullException")
		{
		}
	}
	[Token(Token = "0x2000015")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal class UnmarshalledAttribute : Attribute
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2E87E48", Offset = "0x2E83E48", VA = "0x2E87E48")]
		public UnmarshalledAttribute()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal class FreeFunctionAttribute : NativeMethodAttribute
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2E87E50", Offset = "0x2E83E50", VA = "0x2E87E50")]
		public FreeFunctionAttribute()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2E87E70", Offset = "0x2E83E70", VA = "0x2E87E70")]
		public FreeFunctionAttribute(string name)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2E87E8C", Offset = "0x2E83E8C", VA = "0x2E87E8C")]
		public FreeFunctionAttribute(string name, bool isThreadSafe)
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal class ThreadSafeAttribute : NativeMethodAttribute
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2E87EB8", Offset = "0x2E83EB8", VA = "0x2E87EB8")]
		public ThreadSafeAttribute()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[VisibleToOtherModules]
	internal enum StaticAccessorType
	{
		[Token(Token = "0x400001D")]
		Dot,
		[Token(Token = "0x400001E")]
		Arrow,
		[Token(Token = "0x400001F")]
		DoubleColon,
		[Token(Token = "0x4000020")]
		ArrowWithDefaultReturnIfNull
	}
	[Token(Token = "0x2000019")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	internal class StaticAccessorAttribute : Attribute
	{
		[Token(Token = "0x17000013")]
		public string Name
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2E87ED8", Offset = "0x2E83ED8", VA = "0x2E87ED8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public StaticAccessorType Type
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2E87EE0", Offset = "0x2E83EE0", VA = "0x2E87EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2E87EE8", Offset = "0x2E83EE8", VA = "0x2E87EE8")]
		[VisibleToOtherModules]
		internal StaticAccessorAttribute(string name)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2E87F10", Offset = "0x2E83F10", VA = "0x2E87F10")]
		public StaticAccessorAttribute(string name, StaticAccessorType type)
		{
		}
	}
	[Token(Token = "0x200001A")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	internal class NativeThrowsAttribute : Attribute
	{
		[Token(Token = "0x17000015")]
		public bool ThrowsException
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2E87F40", Offset = "0x2E83F40", VA = "0x2E87F40", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E87F48", Offset = "0x2E83F48", VA = "0x2E87F48")]
		public NativeThrowsAttribute()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Field)]
	[VisibleToOtherModules]
	internal class IgnoreAttribute : Attribute
	{
		[Token(Token = "0x17000016")]
		public bool DoesNotContributeToSize
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2E87F68", Offset = "0x2E83F68", VA = "0x2E87F68")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2E87F70", Offset = "0x2E83F70", VA = "0x2E87F70")]
		public IgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	internal class PreventReadOnlyInstanceModificationAttribute : Attribute
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E87F78", Offset = "0x2E83F78", VA = "0x2E87F78")]
		public PreventReadOnlyInstanceModificationAttribute()
		{
		}
	}
}
namespace UnityEngine.Scripting
{
	[Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[VisibleToOtherModules]
	internal class UsedByNativeCodeAttribute : Attribute
	{
		[Token(Token = "0x17000017")]
		public string Name
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2E87FB0", Offset = "0x2E83FB0", VA = "0x2E87FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2E87F80", Offset = "0x2E83F80", VA = "0x2E87F80")]
		public UsedByNativeCodeAttribute()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2E87F88", Offset = "0x2E83F88", VA = "0x2E87F88")]
		public UsedByNativeCodeAttribute(string name)
		{
		}
	}
	[Token(Token = "0x200001E")]
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	internal class RequiredByNativeCodeAttribute : Attribute
	{
		[Token(Token = "0x17000018")]
		public string Name
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2E87FE8", Offset = "0x2E83FE8", VA = "0x2E87FE8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool Optional
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2E87FF0", Offset = "0x2E83FF0", VA = "0x2E87FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool GenerateProxy
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2E87FF8", Offset = "0x2E83FF8", VA = "0x2E87FF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2E87FB8", Offset = "0x2E83FB8", VA = "0x2E87FB8")]
		public RequiredByNativeCodeAttribute()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2E87FC0", Offset = "0x2E83FC0", VA = "0x2E87FC0")]
		public RequiredByNativeCodeAttribute(string name)
		{
		}
	}
}
