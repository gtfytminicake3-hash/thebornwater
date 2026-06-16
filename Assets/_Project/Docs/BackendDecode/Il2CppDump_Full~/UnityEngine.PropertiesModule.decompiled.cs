using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Unity.Properties.Internal;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Unity.Properties
{
	[Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class CreatePropertyAttribute : Attribute
	{
	}
	[Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Field)]
	public class DontCreatePropertyAttribute : Attribute
	{
	}
	[Token(Token = "0x2000004")]
	public delegate TValue PropertyGetter<TContainer, out TValue>(ref TContainer container);
	[Token(Token = "0x2000005")]
	public delegate void PropertySetter<TContainer, in TValue>(ref TContainer container, TValue value);
	[Token(Token = "0x2000006")]
	public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue>
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly PropertyGetter<TContainer, TValue> m_Getter;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly PropertySetter<TContainer, TValue> m_Setter;

		[Token(Token = "0x17000001")]
		public override string Name
		{
			[Token(Token = "0x6000005")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		public DelegateProperty(string name, PropertyGetter<TContainer, TValue> getter, [Optional] PropertySetter<TContainer, TValue> setter)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public interface IProperty
	{
		[Token(Token = "0x6000007")]
		Type DeclaredValueType();
	}
	[Token(Token = "0x2000008")]
	public interface IProperty<TContainer> : IProperty
	{
	}
	[Token(Token = "0x2000009")]
	public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<Attribute> m_Attributes;

		[Token(Token = "0x17000002")]
		public abstract string Name
		{
			[Token(Token = "0x6000008")]
			get;
		}

		[Token(Token = "0x6000009")]
		public Type DeclaredValueType()
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		protected void AddAttribute(Attribute attribute)
		{
		}

		[Token(Token = "0x600000B")]
		protected void AddAttributes(IEnumerable<Attribute> attributes)
		{
		}

		[Token(Token = "0x600000C")]
		private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute)
		{
		}

		[Token(Token = "0x600000D")]
		private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes)
		{
		}

		[Token(Token = "0x600000E")]
		public bool HasAttribute<TAttribute>() where TAttribute : Attribute
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		protected Property()
		{
		}
	}
	[Token(Token = "0x200000A")]
	internal interface IMemberInfo
	{
		[Token(Token = "0x17000003")]
		string Name
		{
			[Token(Token = "0x6000010")]
			get;
		}

		[Token(Token = "0x17000004")]
		bool IsReadOnly
		{
			[Token(Token = "0x6000011")]
			get;
		}

		[Token(Token = "0x17000005")]
		Type ValueType
		{
			[Token(Token = "0x6000012")]
			get;
		}

		[Token(Token = "0x6000013")]
		IEnumerable<Attribute> GetCustomAttributes();
	}
	[Token(Token = "0x200000B")]
	internal readonly struct FieldMember : IMemberInfo
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly FieldInfo m_FieldInfo;

		[Token(Token = "0x17000006")]
		public string Name
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2E823F8", Offset = "0x2E7E3F8", VA = "0x2E823F8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2E82400", Offset = "0x2E7E400", VA = "0x2E82400", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public Type ValueType
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2E82418", Offset = "0x2E7E418", VA = "0x2E82418", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2E822E4", Offset = "0x2E7E2E4", VA = "0x2E822E4")]
		public FieldMember(FieldInfo fieldInfo)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2E82438", Offset = "0x2E7E438", VA = "0x2E82438", Slot = "7")]
		public IEnumerable<Attribute> GetCustomAttributes()
		{
			return null;
		}
	}
	[Token(Token = "0x200000C")]
	internal readonly struct PropertyMember : IMemberInfo
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly PropertyInfo m_PropertyInfo;

		[Token(Token = "0x17000009")]
		public string Name
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2E82444", Offset = "0x2E7E444", VA = "0x2E82444", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2E8244C", Offset = "0x2E7E44C", VA = "0x2E8244C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public Type ValueType
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2E8247C", Offset = "0x2E7E47C", VA = "0x2E8247C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2E8249C", Offset = "0x2E7E49C", VA = "0x2E8249C")]
		public PropertyMember(PropertyInfo propertyInfo)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2E824BC", Offset = "0x2E7E4BC", VA = "0x2E824BC", Slot = "7")]
		public IEnumerable<Attribute> GetCustomAttributes()
		{
			return null;
		}
	}
	[Token(Token = "0x200000D")]
	public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue>
	{
		[Token(Token = "0x200000E")]
		private delegate TValue GetStructValueAction(ref TContainer container);

		[Token(Token = "0x200000F")]
		private delegate void SetStructValueAction(ref TContainer container, TValue value);

		[Token(Token = "0x2000010")]
		private delegate TValue GetClassValueAction(TContainer container);

		[Token(Token = "0x2000011")]
		private delegate void SetClassValueAction(TContainer container, TValue value);

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IMemberInfo m_Info;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly bool m_IsStructContainerType;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GetStructValueAction m_GetStructValueAction;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SetStructValueAction m_SetStructValueAction;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GetClassValueAction m_GetClassValueAction;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SetClassValueAction m_SetClassValueAction;

		[Token(Token = "0x1700000C")]
		public override string Name
		{
			[Token(Token = "0x600001E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		internal ReflectedMemberProperty(IMemberInfo info, string name)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement>
	{
		[Token(Token = "0x1700000D")]
		protected override InstantiationKind InstantiationKind
		{
			[Token(Token = "0x6000028")]
			get
			{
				return default(InstantiationKind);
			}
		}

		[Token(Token = "0x6000029")]
		protected override TElement[] InstantiateWithCount(int count)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		protected override TElement[] Instantiate()
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		public ArrayPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer>
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<IProperty<TContainer>> m_PropertiesList;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash;

		[Token(Token = "0x600002C")]
		static ContainerPropertyBag()
		{
		}

		[Token(Token = "0x600002D")]
		protected void AddProperty<TValue>(Property<TContainer, TValue> property)
		{
		}

		[Token(Token = "0x600002E")]
		public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		protected ContainerPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue>
	{
		[Token(Token = "0x1700000E")]
		protected override InstantiationKind InstantiationKind
		{
			[Token(Token = "0x6000030")]
			get
			{
				return default(InstantiationKind);
			}
		}

		[Token(Token = "0x6000031")]
		protected override Dictionary<TKey, TValue> Instantiate()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		public DictionaryPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement>
	{
		[Token(Token = "0x1700000F")]
		protected override InstantiationKind InstantiationKind
		{
			[Token(Token = "0x6000033")]
			get
			{
				return default(InstantiationKind);
			}
		}

		[Token(Token = "0x6000034")]
		protected override HashSet<TElement> Instantiate()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		public HashSetPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public interface IPropertyBag
	{
		[Token(Token = "0x6000036")]
		void Accept(ITypeVisitor visitor);
	}
	[Token(Token = "0x2000017")]
	public interface IPropertyBag<TContainer> : IPropertyBag
	{
	}
	[Token(Token = "0x2000018")]
	public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IPropertyBag<TList>, IPropertyBag, IConstructorWithCount<TList>, IConstructor where TList : IList<TElement>
	{
		[Token(Token = "0x2000019")]
		private class ListElementProperty : Property<TList, TElement>
		{
			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int m_Index;

			[Token(Token = "0x17000010")]
			public int Index
			{
				[Token(Token = "0x600003A")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000011")]
			public override string Name
			{
				[Token(Token = "0x600003B")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003C")]
			public ListElementProperty()
			{
			}
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ListElementProperty m_Property;

		[Token(Token = "0x6000037")]
		private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count)
		{
			return (TList)null;
		}

		[Token(Token = "0x6000038")]
		protected virtual TList InstantiateWithCount(int count)
		{
			return (TList)null;
		}

		[Token(Token = "0x6000039")]
		public IndexedCollectionPropertyBag()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IPropertyBag<TDictionary>, IPropertyBag where TDictionary : IDictionary<TKey, TValue>
	{
		[Token(Token = "0x200001B")]
		private class KeyValuePairProperty : Property<TDictionary, KeyValuePair<TKey, TValue>>
		{
			[Token(Token = "0x17000012")]
			public override string Name
			{
				[Token(Token = "0x600003E")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			public TKey Key
			{
				[Token(Token = "0x600003F")]
				[CompilerGenerated]
				get
				{
					return (TKey)null;
				}
			}

			[Token(Token = "0x6000040")]
			public KeyValuePairProperty()
			{
			}
		}

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly KeyValuePairProperty m_KeyValuePairProperty;

		[Token(Token = "0x600003D")]
		public KeyValueCollectionPropertyBag()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>>
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty;

		[Token(Token = "0x6000041")]
		public KeyValuePairPropertyBag()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement>
	{
		[Token(Token = "0x17000014")]
		protected override InstantiationKind InstantiationKind
		{
			[Token(Token = "0x6000047")]
			get
			{
				return default(InstantiationKind);
			}
		}

		[Token(Token = "0x6000048")]
		protected override List<TElement> InstantiateWithCount(int count)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		protected override List<TElement> Instantiate()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		public ListPropertyBag()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class PropertyBag
	{
		[Token(Token = "0x600004B")]
		public static void Register<TContainer>(PropertyBag<TContainer> propertyBag)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
	{
		[Token(Token = "0x17000015")]
		private InstantiationKind Unity.Properties.IConstructor.InstantiationKind
		{
			[Token(Token = "0x600004F")]
			get
			{
				return default(InstantiationKind);
			}
		}

		[Token(Token = "0x17000016")]
		protected virtual InstantiationKind InstantiationKind
		{
			[Token(Token = "0x6000051")]
			[CompilerGenerated]
			get
			{
				return default(InstantiationKind);
			}
		}

		[Token(Token = "0x600004C")]
		static PropertyBag()
		{
		}

		[Token(Token = "0x600004D")]
		private void Unity.Properties.Internal.IPropertyBagRegister.Register()
		{
		}

		[Token(Token = "0x600004E")]
		public void Accept(ITypeVisitor visitor)
		{
		}

		[Token(Token = "0x6000050")]
		private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate()
		{
			return (TContainer)null;
		}

		[Token(Token = "0x6000052")]
		protected virtual TContainer Instantiate()
		{
			return (TContainer)null;
		}

		[Token(Token = "0x6000053")]
		protected PropertyBag()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, IPropertyBag<TSet>, IPropertyBag where TSet : ISet<TElement>
	{
		[Token(Token = "0x2000022")]
		private class SetElementProperty : Property<TSet, TElement>
		{
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TElement m_Value;

			[Token(Token = "0x17000017")]
			public override string Name
			{
				[Token(Token = "0x6000055")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000056")]
			public SetElementProperty()
			{
			}
		}

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SetElementProperty m_Property;

		[Token(Token = "0x6000054")]
		public SetPropertyBagBase()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public interface ITypeVisitor
	{
		[Token(Token = "0x6000057")]
		void Visit<TContainer>();
	}
	[Token(Token = "0x2000024")]
	public static class TypeTraits
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2E824C8", Offset = "0x2E7E4C8", VA = "0x2E824C8")]
		public static bool IsContainer(Type type)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class TypeTraits<T>
	{
		[Token(Token = "0x17000018")]
		public static bool IsValueType
		{
			[Token(Token = "0x6000059")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public static bool IsPrimitive
		{
			[Token(Token = "0x600005A")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public static bool IsInterface
		{
			[Token(Token = "0x600005B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public static bool IsAbstract
		{
			[Token(Token = "0x600005C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public static bool IsArray
		{
			[Token(Token = "0x600005D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public static bool IsEnum
		{
			[Token(Token = "0x600005E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public static bool IsNullable
		{
			[Token(Token = "0x600005F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public static bool IsObject
		{
			[Token(Token = "0x6000060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public static bool IsString
		{
			[Token(Token = "0x6000061")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public static bool IsContainer
		{
			[Token(Token = "0x6000062")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public static bool CanBeNull
		{
			[Token(Token = "0x6000063")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public static bool IsAbstractOrInterface
		{
			[Token(Token = "0x6000064")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000065")]
		static TypeTraits()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public enum InstantiationKind
	{
		[Token(Token = "0x400002F")]
		Activator,
		[Token(Token = "0x4000030")]
		PropertyBagOverride,
		[Token(Token = "0x4000031")]
		NotInstantiatable
	}
	[Token(Token = "0x2000027")]
	internal interface IConstructor
	{
		[Token(Token = "0x17000024")]
		InstantiationKind InstantiationKind
		{
			[Token(Token = "0x6000066")]
			get;
		}
	}
	[Token(Token = "0x2000028")]
	internal interface IConstructor<out T> : IConstructor
	{
		[Token(Token = "0x6000067")]
		T Instantiate();
	}
	[Token(Token = "0x2000029")]
	internal interface IConstructorWithCount<out T> : IConstructor
	{
		[Token(Token = "0x6000068")]
		T InstantiateWithCount(int count);
	}
	[Token(Token = "0x200002A")]
	public static class TypeUtility
	{
		[Token(Token = "0x200002B")]
		private interface ITypeConstructor
		{
			[Token(Token = "0x17000025")]
			bool CanBeInstantiated
			{
				[Token(Token = "0x600007E")]
				get;
			}

			[Token(Token = "0x600007F")]
			object Instantiate();
		}

		[Token(Token = "0x200002C")]
		private interface ITypeConstructor<T> : ITypeConstructor
		{
			[Token(Token = "0x6000080")]
			new T Instantiate();

			[Token(Token = "0x6000081")]
			void SetExplicitConstructor(Func<T> constructor);
		}

		[Token(Token = "0x200002D")]
		private class TypeConstructor<T> : ITypeConstructor<T>, ITypeConstructor
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Func<T> m_ExplicitConstructor;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Func<T> m_ImplicitConstructor;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IConstructor<T> m_OverrideConstructor;

			[Token(Token = "0x17000026")]
			private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
			{
				[Token(Token = "0x6000082")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000083")]
			public TypeConstructor()
			{
			}

			[Token(Token = "0x6000084")]
			private void SetImplicitConstructor()
			{
			}

			[Token(Token = "0x6000085")]
			private static T CreateValueTypeInstance()
			{
				return (T)null;
			}

			[Token(Token = "0x6000086")]
			private static T CreateScriptableObjectInstance()
			{
				return (T)null;
			}

			[Token(Token = "0x6000087")]
			private static T CreateClassInstance()
			{
				return (T)null;
			}

			[Token(Token = "0x6000088")]
			public void SetExplicitConstructor(Func<T> constructor)
			{
			}

			[Token(Token = "0x6000089")]
			private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate()
			{
				return (T)null;
			}

			[Token(Token = "0x600008A")]
			private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate()
			{
				return null;
			}
		}

		[Token(Token = "0x200002E")]
		private class NonConstructable : ITypeConstructor
		{
			[Token(Token = "0x17000027")]
			private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
			{
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x2E83DF8", Offset = "0x2E7FDF8", VA = "0x2E83DF8", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2E83E00", Offset = "0x2E7FE00", VA = "0x2E83E00", Slot = "5")]
			public object Instantiate()
			{
				return null;
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2E839FC", Offset = "0x2E7F9FC", VA = "0x2E839FC")]
			public NonConstructable()
			{
			}
		}

		[Token(Token = "0x200002F")]
		private struct Cache<T>
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ITypeConstructor<T> TypeConstructor;
		}

		[Token(Token = "0x2000030")]
		private class TypeConstructorVisitor : ITypeVisitor
		{
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ITypeConstructor TypeConstructor;

			[Token(Token = "0x600008E")]
			public void Visit<TContainer>()
			{
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2E839F4", Offset = "0x2E7F9F4", VA = "0x2E839F4")]
			public TypeConstructorVisitor()
			{
			}
		}

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ConcurrentDictionary<Type, ITypeConstructor> s_TypeConstructors;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly MethodInfo s_CreateTypeConstructor;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly ObjectPool<StringBuilder> s_Builders;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly object syncedPoolObject;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2E82608", Offset = "0x2E7E608", VA = "0x2E82608")]
		static TypeUtility()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2E82A20", Offset = "0x2E7EA20", VA = "0x2E82A20")]
		public static string GetTypeDisplayName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2E82B3C", Offset = "0x2E7EB3C", VA = "0x2E82B3C")]
		private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2E83414", Offset = "0x2E7F414", VA = "0x2E83414")]
		public static Type GetRootType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2E83540", Offset = "0x2E7F540", VA = "0x2E83540")]
		[Preserve]
		private static ITypeConstructor CreateTypeConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		private static ITypeConstructor<T> CreateTypeConstructor<T>()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2E83A04", Offset = "0x2E7FA04", VA = "0x2E83A04")]
		private static ITypeConstructor GetTypeConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		private static ITypeConstructor<T> GetTypeConstructor<T>()
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2E83ABC", Offset = "0x2E7FABC", VA = "0x2E83ABC")]
		public static bool CanBeInstantiated(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		public static bool CanBeInstantiated<T>()
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		public static void SetExplicitInstantiationMethod<T>(Func<T> constructor)
		{
		}

		[Token(Token = "0x6000074")]
		public static T Instantiate<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000075")]
		public static bool TryInstantiate<T>(out T instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		public static T Instantiate<T>(Type derivedType)
		{
			return (T)null;
		}

		[Token(Token = "0x6000077")]
		public static bool TryInstantiate<T>(Type derivedType, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		public static TArray InstantiateArray<TArray>(int count = 0)
		{
			return (TArray)null;
		}

		[Token(Token = "0x6000079")]
		public static bool TryInstantiateArray<TArray>(int count, out TArray instance)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0)
		{
			return (TArray)null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2E83B88", Offset = "0x2E7FB88", VA = "0x2E83B88")]
		private static void CheckIsAssignableFrom(Type type, Type derivedType)
		{
		}

		[Token(Token = "0x600007C")]
		private static void CheckCanBeInstantiated<T>(ITypeConstructor<T> constructor)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2E83CC8", Offset = "0x2E7FCC8", VA = "0x2E83CC8")]
		private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type)
		{
		}
	}
}
namespace Unity.Properties.Internal
{
	[Token(Token = "0x2000032")]
	internal interface IAttributes
	{
		[Token(Token = "0x6000095")]
		void AddAttribute(Attribute attribute);

		[Token(Token = "0x6000096")]
		void AddAttributes(IEnumerable<Attribute> attributes);
	}
	[Token(Token = "0x2000033")]
	internal static class DefaultPropertyBagInitializer
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2E83F64", Offset = "0x2E7FF64", VA = "0x2E83F64")]
		internal static void Initialize()
		{
		}
	}
	[Token(Token = "0x2000034")]
	internal class ColorPropertyBag : ContainerPropertyBag<Color>
	{
		[Token(Token = "0x2000035")]
		private class RProperty : Property<Color, float>
		{
			[Token(Token = "0x17000028")]
			public override string Name
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x2E850D4", Offset = "0x2E810D4", VA = "0x2E850D4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2E84FB4", Offset = "0x2E80FB4", VA = "0x2E84FB4")]
			public RProperty()
			{
			}
		}

		[Token(Token = "0x2000036")]
		private class GProperty : Property<Color, float>
		{
			[Token(Token = "0x17000029")]
			public override string Name
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x2E85114", Offset = "0x2E81114", VA = "0x2E85114", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2E84FFC", Offset = "0x2E80FFC", VA = "0x2E84FFC")]
			public GProperty()
			{
			}
		}

		[Token(Token = "0x2000037")]
		private class BProperty : Property<Color, float>
		{
			[Token(Token = "0x1700002A")]
			public override string Name
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0x2E85154", Offset = "0x2E81154", VA = "0x2E85154", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2E85044", Offset = "0x2E81044", VA = "0x2E85044")]
			public BProperty()
			{
			}
		}

		[Token(Token = "0x2000038")]
		private class AProperty : Property<Color, float>
		{
			[Token(Token = "0x1700002B")]
			public override string Name
			{
				[Token(Token = "0x600009F")]
				[Address(RVA = "0x2E85194", Offset = "0x2E81194", VA = "0x2E85194", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2E8508C", Offset = "0x2E8108C", VA = "0x2E8508C")]
			public AProperty()
			{
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2E84294", Offset = "0x2E80294", VA = "0x2E84294")]
		public ColorPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000039")]
	internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
	{
		[Token(Token = "0x200003A")]
		private class XProperty : Property<Vector2, float>
		{
			[Token(Token = "0x1700002C")]
			public override string Name
			{
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0x2E85264", Offset = "0x2E81264", VA = "0x2E85264", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2E851D4", Offset = "0x2E811D4", VA = "0x2E851D4")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x200003B")]
		private class YProperty : Property<Vector2, float>
		{
			[Token(Token = "0x1700002D")]
			public override string Name
			{
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0x2E852A4", Offset = "0x2E812A4", VA = "0x2E852A4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2E8521C", Offset = "0x2E8121C", VA = "0x2E8521C")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2E843FC", Offset = "0x2E803FC", VA = "0x2E843FC")]
		public Vector2PropertyBag()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
	{
		[Token(Token = "0x200003D")]
		private class XProperty : Property<Vector3, float>
		{
			[Token(Token = "0x1700002E")]
			public override string Name
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x2E853BC", Offset = "0x2E813BC", VA = "0x2E853BC", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2E852E4", Offset = "0x2E812E4", VA = "0x2E852E4")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x200003E")]
		private class YProperty : Property<Vector3, float>
		{
			[Token(Token = "0x1700002F")]
			public override string Name
			{
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x2E853FC", Offset = "0x2E813FC", VA = "0x2E853FC", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2E8532C", Offset = "0x2E8132C", VA = "0x2E8532C")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x200003F")]
		private class ZProperty : Property<Vector3, float>
		{
			[Token(Token = "0x17000030")]
			public override string Name
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x2E8543C", Offset = "0x2E8143C", VA = "0x2E8543C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2E85374", Offset = "0x2E81374", VA = "0x2E85374")]
			public ZProperty()
			{
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2E844EC", Offset = "0x2E804EC", VA = "0x2E844EC")]
		public Vector3PropertyBag()
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal class Vector4PropertyBag : ContainerPropertyBag<Vector4>
	{
		[Token(Token = "0x2000041")]
		private class XProperty : Property<Vector4, float>
		{
			[Token(Token = "0x17000031")]
			public override string Name
			{
				[Token(Token = "0x60000AE")]
				[Address(RVA = "0x2E8559C", Offset = "0x2E8159C", VA = "0x2E8559C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2E8547C", Offset = "0x2E8147C", VA = "0x2E8547C")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x2000042")]
		private class YProperty : Property<Vector4, float>
		{
			[Token(Token = "0x17000032")]
			public override string Name
			{
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x2E855DC", Offset = "0x2E815DC", VA = "0x2E855DC", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2E854C4", Offset = "0x2E814C4", VA = "0x2E854C4")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x2000043")]
		private class ZProperty : Property<Vector4, float>
		{
			[Token(Token = "0x17000033")]
			public override string Name
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x2E8561C", Offset = "0x2E8161C", VA = "0x2E8561C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2E8550C", Offset = "0x2E8150C", VA = "0x2E8550C")]
			public ZProperty()
			{
			}
		}

		[Token(Token = "0x2000044")]
		private class WProperty : Property<Vector4, float>
		{
			[Token(Token = "0x17000034")]
			public override string Name
			{
				[Token(Token = "0x60000B4")]
				[Address(RVA = "0x2E8565C", Offset = "0x2E8165C", VA = "0x2E8565C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2E85554", Offset = "0x2E81554", VA = "0x2E85554")]
			public WProperty()
			{
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2E84618", Offset = "0x2E80618", VA = "0x2E84618")]
		public Vector4PropertyBag()
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
	{
		[Token(Token = "0x2000046")]
		private class XProperty : Property<Vector2Int, int>
		{
			[Token(Token = "0x17000035")]
			public override string Name
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x2E8572C", Offset = "0x2E8172C", VA = "0x2E8572C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2E8569C", Offset = "0x2E8169C", VA = "0x2E8569C")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x2000047")]
		private class YProperty : Property<Vector2Int, int>
		{
			[Token(Token = "0x17000036")]
			public override string Name
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x2E8576C", Offset = "0x2E8176C", VA = "0x2E8576C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2E856E4", Offset = "0x2E816E4", VA = "0x2E856E4")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2E84780", Offset = "0x2E80780", VA = "0x2E84780")]
		public Vector2IntPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000048")]
	internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int>
	{
		[Token(Token = "0x2000049")]
		private class XProperty : Property<Vector3Int, int>
		{
			[Token(Token = "0x17000037")]
			public override string Name
			{
				[Token(Token = "0x60000BC")]
				[Address(RVA = "0x2E85884", Offset = "0x2E81884", VA = "0x2E85884", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2E857AC", Offset = "0x2E817AC", VA = "0x2E857AC")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x200004A")]
		private class YProperty : Property<Vector3Int, int>
		{
			[Token(Token = "0x17000038")]
			public override string Name
			{
				[Token(Token = "0x60000BE")]
				[Address(RVA = "0x2E858C4", Offset = "0x2E818C4", VA = "0x2E858C4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2E857F4", Offset = "0x2E817F4", VA = "0x2E857F4")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x200004B")]
		private class ZProperty : Property<Vector3Int, int>
		{
			[Token(Token = "0x17000039")]
			public override string Name
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x2E85904", Offset = "0x2E81904", VA = "0x2E85904", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2E8583C", Offset = "0x2E8183C", VA = "0x2E8583C")]
			public ZProperty()
			{
			}
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2E84870", Offset = "0x2E80870", VA = "0x2E84870")]
		public Vector3IntPropertyBag()
		{
		}
	}
	[Token(Token = "0x200004C")]
	internal class RectPropertyBag : ContainerPropertyBag<Rect>
	{
		[Token(Token = "0x200004D")]
		private class XProperty : Property<Rect, float>
		{
			[Token(Token = "0x1700003A")]
			public override string Name
			{
				[Token(Token = "0x60000C3")]
				[Address(RVA = "0x2E85A64", Offset = "0x2E81A64", VA = "0x2E85A64", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2E85944", Offset = "0x2E81944", VA = "0x2E85944")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x200004E")]
		private class YProperty : Property<Rect, float>
		{
			[Token(Token = "0x1700003B")]
			public override string Name
			{
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0x2E85AA4", Offset = "0x2E81AA4", VA = "0x2E85AA4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2E8598C", Offset = "0x2E8198C", VA = "0x2E8598C")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x200004F")]
		private class WidthProperty : Property<Rect, float>
		{
			[Token(Token = "0x1700003C")]
			public override string Name
			{
				[Token(Token = "0x60000C7")]
				[Address(RVA = "0x2E85AE4", Offset = "0x2E81AE4", VA = "0x2E85AE4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2E859D4", Offset = "0x2E819D4", VA = "0x2E859D4")]
			public WidthProperty()
			{
			}
		}

		[Token(Token = "0x2000050")]
		private class HeightProperty : Property<Rect, float>
		{
			[Token(Token = "0x1700003D")]
			public override string Name
			{
				[Token(Token = "0x60000C9")]
				[Address(RVA = "0x2E85B24", Offset = "0x2E81B24", VA = "0x2E85B24", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2E85A1C", Offset = "0x2E81A1C", VA = "0x2E85A1C")]
			public HeightProperty()
			{
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2E8499C", Offset = "0x2E8099C", VA = "0x2E8499C")]
		public RectPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000051")]
	internal class RectIntPropertyBag : ContainerPropertyBag<RectInt>
	{
		[Token(Token = "0x2000052")]
		private class XProperty : Property<RectInt, int>
		{
			[Token(Token = "0x1700003E")]
			public override string Name
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0x2E85C84", Offset = "0x2E81C84", VA = "0x2E85C84", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2E85B64", Offset = "0x2E81B64", VA = "0x2E85B64")]
			public XProperty()
			{
			}
		}

		[Token(Token = "0x2000053")]
		private class YProperty : Property<RectInt, int>
		{
			[Token(Token = "0x1700003F")]
			public override string Name
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0x2E85CC4", Offset = "0x2E81CC4", VA = "0x2E85CC4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2E85BAC", Offset = "0x2E81BAC", VA = "0x2E85BAC")]
			public YProperty()
			{
			}
		}

		[Token(Token = "0x2000054")]
		private class WidthProperty : Property<RectInt, int>
		{
			[Token(Token = "0x17000040")]
			public override string Name
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0x2E85D04", Offset = "0x2E81D04", VA = "0x2E85D04", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2E85BF4", Offset = "0x2E81BF4", VA = "0x2E85BF4")]
			public WidthProperty()
			{
			}
		}

		[Token(Token = "0x2000055")]
		private class HeightProperty : Property<RectInt, int>
		{
			[Token(Token = "0x17000041")]
			public override string Name
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0x2E85D44", Offset = "0x2E81D44", VA = "0x2E85D44", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x2E85C3C", Offset = "0x2E81C3C", VA = "0x2E85C3C")]
			public HeightProperty()
			{
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2E84B04", Offset = "0x2E80B04", VA = "0x2E84B04")]
		public RectIntPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000056")]
	internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
	{
		[Token(Token = "0x2000057")]
		private class CenterProperty : Property<Bounds, Vector3>
		{
			[Token(Token = "0x17000042")]
			public override string Name
			{
				[Token(Token = "0x60000D5")]
				[Address(RVA = "0x2E85E14", Offset = "0x2E81E14", VA = "0x2E85E14", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2E85D84", Offset = "0x2E81D84", VA = "0x2E85D84")]
			public CenterProperty()
			{
			}
		}

		[Token(Token = "0x2000058")]
		private class ExtentsProperty : Property<Bounds, Vector3>
		{
			[Token(Token = "0x17000043")]
			public override string Name
			{
				[Token(Token = "0x60000D7")]
				[Address(RVA = "0x2E85E54", Offset = "0x2E81E54", VA = "0x2E85E54", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2E85DCC", Offset = "0x2E81DCC", VA = "0x2E85DCC")]
			public ExtentsProperty()
			{
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2E84C6C", Offset = "0x2E80C6C", VA = "0x2E84C6C")]
		public BoundsPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000059")]
	internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
	{
		[Token(Token = "0x200005A")]
		private class PositionProperty : Property<BoundsInt, Vector3Int>
		{
			[Token(Token = "0x17000044")]
			public override string Name
			{
				[Token(Token = "0x60000DA")]
				[Address(RVA = "0x2E85F24", Offset = "0x2E81F24", VA = "0x2E85F24", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2E85E94", Offset = "0x2E81E94", VA = "0x2E85E94")]
			public PositionProperty()
			{
			}
		}

		[Token(Token = "0x200005B")]
		private class SizeProperty : Property<BoundsInt, Vector3Int>
		{
			[Token(Token = "0x17000045")]
			public override string Name
			{
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0x2E85F64", Offset = "0x2E81F64", VA = "0x2E85F64", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2E85EDC", Offset = "0x2E81EDC", VA = "0x2E85EDC")]
			public SizeProperty()
			{
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2E84D5C", Offset = "0x2E80D5C", VA = "0x2E84D5C")]
		public BoundsIntPropertyBag()
		{
		}
	}
	[Token(Token = "0x200005C")]
	internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
	{
		[Token(Token = "0x200005D")]
		private class MajorProperty : Property<Version, int>
		{
			[Token(Token = "0x17000046")]
			public override string Name
			{
				[Token(Token = "0x60000E0")]
				[Address(RVA = "0x2E86224", Offset = "0x2E82224", VA = "0x2E86224", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2E85FA4", Offset = "0x2E81FA4", VA = "0x2E85FA4")]
			public MajorProperty()
			{
			}
		}

		[Token(Token = "0x200005E")]
		private class MinorProperty : Property<Version, int>
		{
			[Token(Token = "0x17000047")]
			public override string Name
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x2E86264", Offset = "0x2E82264", VA = "0x2E86264", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2E86044", Offset = "0x2E82044", VA = "0x2E86044")]
			public MinorProperty()
			{
			}
		}

		[Token(Token = "0x200005F")]
		private class BuildProperty : Property<Version, int>
		{
			[Token(Token = "0x17000048")]
			public override string Name
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x2E862A4", Offset = "0x2E822A4", VA = "0x2E862A4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2E860E4", Offset = "0x2E820E4", VA = "0x2E860E4")]
			public BuildProperty()
			{
			}
		}

		[Token(Token = "0x2000060")]
		private class RevisionProperty : Property<Version, int>
		{
			[Token(Token = "0x17000049")]
			public override string Name
			{
				[Token(Token = "0x60000E6")]
				[Address(RVA = "0x2E862E4", Offset = "0x2E822E4", VA = "0x2E862E4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2E86184", Offset = "0x2E82184", VA = "0x2E86184")]
			public RevisionProperty()
			{
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2E84E4C", Offset = "0x2E80E4C", VA = "0x2E84E4C")]
		public SystemVersionPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000061")]
	internal interface IPropertyBagRegister
	{
		[Token(Token = "0x60000E7")]
		void Register();
	}
	[Token(Token = "0x2000062")]
	internal static class PropertyBagStore
	{
		[Token(Token = "0x2000063")]
		internal struct TypedStore<TContainer>
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static IPropertyBag<TContainer> PropertyBag;
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<Type> s_RegisteredTypes;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Type, IPropertyBag> NewTypeRegistered;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static ReflectedPropertyBagProvider s_PropertyBagProvider;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2E86324", Offset = "0x2E82324", VA = "0x2E86324")]
		static PropertyBagStore()
		{
		}

		[Token(Token = "0x60000E9")]
		internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag)
		{
		}

		[Token(Token = "0x60000EA")]
		internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2E837B8", Offset = "0x2E7F7B8", VA = "0x2E837B8")]
		internal static IPropertyBag GetPropertyBag(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	internal class ReflectedPropertyBagAttribute : Attribute
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2E8690C", Offset = "0x2E8290C", VA = "0x2E8690C")]
		public ReflectedPropertyBagAttribute()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ReflectedPropertyBag]
	internal class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer>
	{
		[Token(Token = "0x60000ED")]
		internal new void AddProperty<TValue>(Property<TContainer, TValue> property)
		{
		}

		[Token(Token = "0x60000EE")]
		public ReflectedPropertyBag()
		{
		}
	}
	[Token(Token = "0x2000066")]
	internal class ReflectedPropertyBagProvider
	{
		[Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MemberInfo <>2__current;

			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Type type;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type <>3__type;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IOrderedEnumerable<MemberInfo> <members>5__1;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IEnumerator<MemberInfo> <>s__2;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private MemberInfo <member>5__3;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool <hasDontCreatePropertyAttribute>5__4;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			private bool <hasCreatePropertyAttribute>5__5;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
			private bool <hasNonSerializedAttribute>5__6;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
			private bool <hasSerializedFieldAttribute>5__7;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private FieldInfo <field>5__8;

			[Token(Token = "0x1700004A")]
			private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current
			{
				[Token(Token = "0x6000106")]
				[Address(RVA = "0x2E874D0", Offset = "0x2E834D0", VA = "0x2E874D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000108")]
				[Address(RVA = "0x2E87510", Offset = "0x2E83510", VA = "0x2E87510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2E86988", Offset = "0x2E82988", VA = "0x2E86988")]
			[DebuggerHidden]
			public <GetPropertyMembers>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2E86D04", Offset = "0x2E82D04", VA = "0x2E86D04", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2E86D30", Offset = "0x2E82D30", VA = "0x2E86D30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2E87420", Offset = "0x2E83420", VA = "0x2E87420")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2E874D8", Offset = "0x2E834D8", VA = "0x2E874D8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2E87518", Offset = "0x2E83518", VA = "0x2E87518", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2E875B4", Offset = "0x2E835B4", VA = "0x2E875B4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MethodInfo m_CreatePropertyMethod;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly MethodInfo m_CreatePropertyBagMethod;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly MethodInfo m_CreateSetPropertyBagMethod;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly MethodInfo m_CreateArrayPropertyBagMethod;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly MethodInfo m_CreateListPropertyBagMethod;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly MethodInfo m_CreateHashSetPropertyBagMethod;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly MethodInfo m_CreateDictionaryPropertyBagMethod;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2E86434", Offset = "0x2E82434", VA = "0x2E86434")]
		public ReflectedPropertyBagProvider()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2E867E8", Offset = "0x2E827E8", VA = "0x2E867E8")]
		public IPropertyBag CreatePropertyBag(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		public IPropertyBag<TContainer> CreatePropertyBag<TContainer>()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Preserve]
		private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag)
		{
		}

		[Token(Token = "0x60000F3")]
		[Preserve]
		private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() where TList : IList<TElement>
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Preserve]
		private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() where TSet : ISet<TValue>
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Preserve]
		private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() where TDictionary : IDictionary<TKey, TValue>
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Preserve]
		private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>()
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Preserve]
		private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Preserve]
		private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Preserve]
		private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Preserve]
		private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2E86914", Offset = "0x2E82914", VA = "0x2E86914")]
		[IteratorStateMachine(typeof(<GetPropertyMembers>d__22))]
		private static IEnumerable<MemberInfo> GetPropertyMembers(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2E869BC", Offset = "0x2E829BC", VA = "0x2E869BC")]
		private static bool IsValidMember(MemberInfo memberInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2E86B00", Offset = "0x2E82B00", VA = "0x2E86B00")]
		private static bool IsValidPropertyType(Type type)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000069")]
	internal static class ReflectionUtilities
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2E82304", Offset = "0x2E7E304", VA = "0x2E82304")]
		public static string SanitizeMemberName(MemberInfo info)
		{
			return null;
		}
	}
}
