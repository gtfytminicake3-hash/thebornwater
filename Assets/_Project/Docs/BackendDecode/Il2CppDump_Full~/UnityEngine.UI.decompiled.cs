using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.UI.Collections;
using UnityEngine.UI.CoroutineTween;
using UnityEngine.UIElements;

[assembly: AssemblyVersion("1.0.0.0")]
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
	[Address(RVA = "0x2EBBCBC", Offset = "0x2EB7CBC", VA = "0x2EBBCBC")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2EBBD78", Offset = "0x2EB7D78", VA = "0x2EBBD78")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityEngine.UI
{
	[Serializable]
	[Token(Token = "0x2000004")]
	public class AnimationTriggers
	{
		[Token(Token = "0x4000006")]
		private const string kDefaultNormalAnimName = "Normal";

		[Token(Token = "0x4000007")]
		private const string kDefaultHighlightedAnimName = "Highlighted";

		[Token(Token = "0x4000008")]
		private const string kDefaultPressedAnimName = "Pressed";

		[Token(Token = "0x4000009")]
		private const string kDefaultSelectedAnimName = "Selected";

		[Token(Token = "0x400000A")]
		private const string kDefaultDisabledAnimName = "Disabled";

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("normalTrigger")]
		private string m_NormalTrigger;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("highlightedTrigger")]
		private string m_HighlightedTrigger;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("pressedTrigger")]
		[SerializeField]
		private string m_PressedTrigger;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("m_HighlightedTrigger")]
		[SerializeField]
		private string m_SelectedTrigger;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("disabledTrigger")]
		[SerializeField]
		private string m_DisabledTrigger;

		[Token(Token = "0x17000001")]
		public string normalTrigger
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2EBBD80", Offset = "0x2EB7D80", VA = "0x2EBBD80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2EBBD88", Offset = "0x2EB7D88", VA = "0x2EBBD88")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string highlightedTrigger
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2EBBD90", Offset = "0x2EB7D90", VA = "0x2EBBD90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2EBBD98", Offset = "0x2EB7D98", VA = "0x2EBBD98")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public string pressedTrigger
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2EBBDA0", Offset = "0x2EB7DA0", VA = "0x2EBBDA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2EBBDA8", Offset = "0x2EB7DA8", VA = "0x2EBBDA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public string selectedTrigger
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2EBBDB0", Offset = "0x2EB7DB0", VA = "0x2EBBDB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2EBBDB8", Offset = "0x2EB7DB8", VA = "0x2EBBDB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string disabledTrigger
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2EBBDC0", Offset = "0x2EB7DC0", VA = "0x2EBBDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2EBBDC8", Offset = "0x2EB7DC8", VA = "0x2EBBDC8")]
			set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2EBBDD0", Offset = "0x2EB7DD0", VA = "0x2EBBDD0")]
		public AnimationTriggers()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		[Serializable]
		[Token(Token = "0x2000006")]
		public class ButtonClickedEvent : UnityEvent
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2EBBF24", Offset = "0x2EB7F24", VA = "0x2EBBF24")]
			public ButtonClickedEvent()
			{
			}
		}

		[Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class <OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x20")]
			public Button <>4__this;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x28")]
			private float <fadeTime>5__2;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x2C")]
			private float <elapsedTime>5__3;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000019")]
				[Address(RVA = "0x2EBC1E8", Offset = "0x2EB81E8", VA = "0x2EBC1E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600001B")]
				[Address(RVA = "0x2EBC228", Offset = "0x2EB8228", VA = "0x2EBC228", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2EBC0C8", Offset = "0x2EB80C8", VA = "0x2EBC0C8")]
			[DebuggerHidden]
			public <OnFinishSubmit>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2EBC0F0", Offset = "0x2EB80F0", VA = "0x2EBC0F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2EBC0F4", Offset = "0x2EB80F4", VA = "0x2EBC0F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2EBC1F0", Offset = "0x2EB81F0", VA = "0x2EBC1F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[FormerlySerializedAs("onClick")]
		private ButtonClickedEvent m_OnClick;

		[Token(Token = "0x17000006")]
		public ButtonClickedEvent onClick
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2EBBF2C", Offset = "0x2EB7F2C", VA = "0x2EBBF2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2EBBF34", Offset = "0x2EB7F34", VA = "0x2EBBF34")]
			set
			{
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2EBBE98", Offset = "0x2EB7E98", VA = "0x2EBBE98")]
		protected Button()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2EBBF3C", Offset = "0x2EB7F3C", VA = "0x2EBBF3C")]
		private void Press()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2EBBFD4", Offset = "0x2EB7FD4", VA = "0x2EBBFD4", Slot = "41")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2EBBFF0", Offset = "0x2EB7FF0", VA = "0x2EBBFF0", Slot = "42")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2EBC068", Offset = "0x2EB8068", VA = "0x2EBC068")]
		[IteratorStateMachine(typeof(<OnFinishSubmit>d__9))]
		private IEnumerator OnFinishSubmit()
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public enum CanvasUpdate
	{
		[Token(Token = "0x4000017")]
		Prelayout,
		[Token(Token = "0x4000018")]
		Layout,
		[Token(Token = "0x4000019")]
		PostLayout,
		[Token(Token = "0x400001A")]
		PreRender,
		[Token(Token = "0x400001B")]
		LatePreRender,
		[Token(Token = "0x400001C")]
		MaxUpdateValue
	}
	[Token(Token = "0x2000009")]
	public interface ICanvasElement
	{
		[Token(Token = "0x17000009")]
		Transform transform
		{
			[Token(Token = "0x600001D")]
			get;
		}

		[Token(Token = "0x600001C")]
		void Rebuild(CanvasUpdate executing);

		[Token(Token = "0x600001E")]
		void LayoutComplete();

		[Token(Token = "0x600001F")]
		void GraphicUpdateComplete();

		[Token(Token = "0x6000020")]
		bool IsDestroyed();
	}
	[Token(Token = "0x200000A")]
	public class CanvasUpdateRegistry
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		private static CanvasUpdateRegistry s_Instance;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		private bool m_PerformingLayoutUpdate;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x11")]
		private bool m_PerformingGraphicUpdate;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		private string[] m_CanvasUpdateProfilerStrings;

		[Token(Token = "0x4000021")]
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction;

		[Token(Token = "0x1700000A")]
		public static CanvasUpdateRegistry instance
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2EBC404", Offset = "0x2EB8404", VA = "0x2EBC404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2EBC230", Offset = "0x2EB8230", VA = "0x2EBC230")]
		protected CanvasUpdateRegistry()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2EBC4A4", Offset = "0x2EB84A4", VA = "0x2EBC4A4")]
		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2EBC574", Offset = "0x2EB8574", VA = "0x2EBC574")]
		private void CleanInvalidItems()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2EBC844", Offset = "0x2EB8844", VA = "0x2EBC844")]
		private void PerformUpdate()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2EBCF64", Offset = "0x2EB8F64", VA = "0x2EBCF64")]
		private static int ParentCount(Transform child)
		{
			return default(int);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2EBD020", Offset = "0x2EB9020", VA = "0x2EBD020")]
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			return default(int);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2EBD178", Offset = "0x2EB9178", VA = "0x2EBD178")]
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2EBD270", Offset = "0x2EB9270", VA = "0x2EBD270")]
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2EBD1D8", Offset = "0x2EB91D8", VA = "0x2EBD1D8")]
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2EBD2D0", Offset = "0x2EB92D0", VA = "0x2EBD2D0")]
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2EBD400", Offset = "0x2EB9400", VA = "0x2EBD400")]
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2EBD330", Offset = "0x2EB9330", VA = "0x2EBD330")]
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2EBD460", Offset = "0x2EB9460", VA = "0x2EBD460")]
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2EBD798", Offset = "0x2EB9798", VA = "0x2EBD798")]
		public static void DisableCanvasElementForRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2EBD4D0", Offset = "0x2EB94D0", VA = "0x2EBD4D0")]
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2EBD634", Offset = "0x2EB9634", VA = "0x2EBD634")]
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2EBD808", Offset = "0x2EB9808", VA = "0x2EBD808")]
		private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2EBD96C", Offset = "0x2EB996C", VA = "0x2EBD96C")]
		private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2EBDAD0", Offset = "0x2EB9AD0", VA = "0x2EBDAD0")]
		public static bool IsRebuildingLayout()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2EBDB2C", Offset = "0x2EB9B2C", VA = "0x2EBDB2C")]
		public static bool IsRebuildingGraphics()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public struct ColorBlock : IEquatable<ColorBlock>
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[FormerlySerializedAs("normalColor")]
		private Color m_NormalColor;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("highlightedColor")]
		[SerializeField]
		private Color m_HighlightedColor;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("pressedColor")]
		[SerializeField]
		private Color m_PressedColor;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("m_HighlightedColor")]
		[SerializeField]
		private Color m_SelectedColor;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("disabledColor")]
		[SerializeField]
		private Color m_DisabledColor;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x50")]
		[Range(1f, 5f)]
		[SerializeField]
		private float m_ColorMultiplier;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x54")]
		[FormerlySerializedAs("fadeDuration")]
		[SerializeField]
		private float m_FadeDuration;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		public static ColorBlock defaultColorBlock;

		[Token(Token = "0x1700000B")]
		public Color normalColor
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2EBDC1C", Offset = "0x2EB9C1C", VA = "0x2EBDC1C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2EBDC28", Offset = "0x2EB9C28", VA = "0x2EBDC28")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color highlightedColor
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2EBDC34", Offset = "0x2EB9C34", VA = "0x2EBDC34")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2EBDC40", Offset = "0x2EB9C40", VA = "0x2EBDC40")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Color pressedColor
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2EBDC4C", Offset = "0x2EB9C4C", VA = "0x2EBDC4C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2EBDC58", Offset = "0x2EB9C58", VA = "0x2EBDC58")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Color selectedColor
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2EBDC64", Offset = "0x2EB9C64", VA = "0x2EBDC64")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2EBDC70", Offset = "0x2EB9C70", VA = "0x2EBDC70")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Color disabledColor
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2EBDC7C", Offset = "0x2EB9C7C", VA = "0x2EBDC7C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2EBDC88", Offset = "0x2EB9C88", VA = "0x2EBDC88")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float colorMultiplier
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2EBDC94", Offset = "0x2EB9C94", VA = "0x2EBDC94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2EBDC9C", Offset = "0x2EB9C9C", VA = "0x2EBDC9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public float fadeDuration
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2EBDCA4", Offset = "0x2EB9CA4", VA = "0x2EBDCA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2EBDCAC", Offset = "0x2EB9CAC", VA = "0x2EBDCAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2EBDCB4", Offset = "0x2EB9CB4", VA = "0x2EBDCB4")]
		static ColorBlock()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2EBDD2C", Offset = "0x2EB9D2C", VA = "0x2EBDD2C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2EBDDEC", Offset = "0x2EB9DEC", VA = "0x2EBDDEC", Slot = "4")]
		public bool Equals(ColorBlock other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2EBDFE4", Offset = "0x2EB9FE4", VA = "0x2EBDFE4")]
		public static bool operator ==(ColorBlock point1, ColorBlock point2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2EBE068", Offset = "0x2EBA068", VA = "0x2EBE068")]
		public static bool operator !=(ColorBlock point1, ColorBlock point2)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2EBE0F0", Offset = "0x2EBA0F0", VA = "0x2EBE0F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200000C")]
	public class ClipperRegistry
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		private static ClipperRegistry s_Instance;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		private readonly IndexedSet<IClipper> m_Clippers;

		[Token(Token = "0x17000012")]
		public static ClipperRegistry instance
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2EBCDE4", Offset = "0x2EB8DE4", VA = "0x2EBCDE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2EBE15C", Offset = "0x2EBA15C", VA = "0x2EBE15C")]
		protected ClipperRegistry()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2EBCE58", Offset = "0x2EB8E58", VA = "0x2EBCE58")]
		public void Cull()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2EBE1D8", Offset = "0x2EBA1D8", VA = "0x2EBE1D8")]
		public static void Register(IClipper c)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2EBE248", Offset = "0x2EBA248", VA = "0x2EBE248")]
		public static void Unregister(IClipper c)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2EBE2A4", Offset = "0x2EBA2A4", VA = "0x2EBE2A4")]
		public static void Disable(IClipper c)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public static class Clipping
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2EBE300", Offset = "0x2EBA300", VA = "0x2EBE300")]
		public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x200000E")]
	public interface IClipper
	{
		[Token(Token = "0x6000052")]
		void PerformClipping();
	}
	[Token(Token = "0x200000F")]
	public interface IClippable
	{
		[Token(Token = "0x17000013")]
		GameObject gameObject
		{
			[Token(Token = "0x6000053")]
			get;
		}

		[Token(Token = "0x17000014")]
		RectTransform rectTransform
		{
			[Token(Token = "0x6000055")]
			get;
		}

		[Token(Token = "0x6000054")]
		void RecalculateClipping();

		[Token(Token = "0x6000056")]
		void Cull(Rect clipRect, bool validRect);

		[Token(Token = "0x6000057")]
		void SetClipRect(Rect value, bool validRect);

		[Token(Token = "0x6000058")]
		void SetClipSoftness(Vector2 clipSoftness);
	}
	[Token(Token = "0x2000010")]
	internal class RectangularVertexClipper
	{
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x10")]
		private readonly Vector3[] m_WorldCorners;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x18")]
		private readonly Vector3[] m_CanvasCorners;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2EBE4B4", Offset = "0x2EBA4B4", VA = "0x2EBE4B4")]
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			return default(Rect);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2EBE60C", Offset = "0x2EBA60C", VA = "0x2EBE60C")]
		public RectangularVertexClipper()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public static class DefaultControls
	{
		[Token(Token = "0x2000012")]
		public interface IFactoryControls
		{
			[Token(Token = "0x600006E")]
			GameObject CreateGameObject(string name, params Type[] components);
		}

		[Token(Token = "0x2000013")]
		private class DefaultRuntimeFactory : IFactoryControls
		{
			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x0")]
			public static IFactoryControls Default;

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2EC2F18", Offset = "0x2EBEF18", VA = "0x2EC2F18", Slot = "4")]
			public GameObject CreateGameObject(string name, params Type[] components)
			{
				return null;
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2EC2F84", Offset = "0x2EBEF84", VA = "0x2EC2F84")]
			public DefaultRuntimeFactory()
			{
			}
		}

		[Token(Token = "0x2000014")]
		public struct Resources
		{
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x0")]
			public Sprite standard;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x8")]
			public Sprite background;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x10")]
			public Sprite inputField;

			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x18")]
			public Sprite knob;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x20")]
			public Sprite checkmark;

			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x28")]
			public Sprite dropdown;

			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x30")]
			public Sprite mask;
		}

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		private static IFactoryControls m_CurrentFactory;

		[Token(Token = "0x4000032")]
		private const float kWidth = 160f;

		[Token(Token = "0x4000033")]
		private const float kThickHeight = 30f;

		[Token(Token = "0x4000034")]
		private const float kThinHeight = 20f;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 s_ThickElementSize;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 s_ThinElementSize;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		private static Vector2 s_ImageElementSize;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x20")]
		private static Color s_DefaultSelectableColor;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		private static Color s_PanelColor;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x40")]
		private static Color s_TextColor;

		[Token(Token = "0x17000015")]
		public static IFactoryControls factory
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2EBE67C", Offset = "0x2EBA67C", VA = "0x2EBE67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2EBE6D4", Offset = "0x2EBA6D4", VA = "0x2EBE6D4")]
		private static GameObject CreateUIElementRoot(string name, Vector2 size, params Type[] components)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2EBE834", Offset = "0x2EBA834", VA = "0x2EBE834")]
		private static GameObject CreateUIObject(string name, GameObject parent, params Type[] components)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2EBEA5C", Offset = "0x2EBAA5C", VA = "0x2EBEA5C")]
		private static void SetDefaultTextValues(Text lbl)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2EBEB38", Offset = "0x2EBAB38", VA = "0x2EBEB38")]
		private static void SetDefaultColorTransitionValues(Selectable slider)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2EBE95C", Offset = "0x2EBA95C", VA = "0x2EBE95C")]
		private static void SetParentAndAlign(GameObject child, GameObject parent)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2EBEB98", Offset = "0x2EBAB98", VA = "0x2EBEB98")]
		private static void SetLayerRecursively(GameObject go, int layer)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2EBEC7C", Offset = "0x2EBAC7C", VA = "0x2EBEC7C")]
		public static GameObject CreatePanel(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2EBF268", Offset = "0x2EBB268", VA = "0x2EBF268")]
		public static GameObject CreateButton(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2EBF65C", Offset = "0x2EBB65C", VA = "0x2EBF65C")]
		public static GameObject CreateText(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2EBF7FC", Offset = "0x2EBB7FC", VA = "0x2EBF7FC")]
		public static GameObject CreateImage(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2EBF938", Offset = "0x2EBB938", VA = "0x2EBF938")]
		public static GameObject CreateRawImage(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2EBFA74", Offset = "0x2EBBA74", VA = "0x2EBFA74")]
		public static GameObject CreateSlider(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2EC0130", Offset = "0x2EBC130", VA = "0x2EC0130")]
		public static GameObject CreateScrollbar(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2EC05AC", Offset = "0x2EBC5AC", VA = "0x2EC05AC")]
		public static GameObject CreateToggle(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2EC0B20", Offset = "0x2EBCB20", VA = "0x2EC0B20")]
		public static GameObject CreateInputField(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2EC1144", Offset = "0x2EBD144", VA = "0x2EC1144")]
		public static GameObject CreateDropdown(Resources resources)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2EC258C", Offset = "0x2EBE58C", VA = "0x2EC258C")]
		public static GameObject CreateScrollView(Resources resources)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Legacy/Dropdown", 102)]
	public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		[Token(Token = "0x2000016")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			[Token(Token = "0x4000053")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text m_Text;

			[Token(Token = "0x4000054")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image m_Image;

			[Token(Token = "0x4000055")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private RectTransform m_RectTransform;

			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Toggle m_Toggle;

			[Token(Token = "0x1700001F")]
			public Text text
			{
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0x2EC5C20", Offset = "0x2EC1C20", VA = "0x2EC5C20")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x2EC5C28", Offset = "0x2EC1C28", VA = "0x2EC5C28")]
				set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public Image image
			{
				[Token(Token = "0x60000A6")]
				[Address(RVA = "0x2EC5C30", Offset = "0x2EC1C30", VA = "0x2EC5C30")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x2EC5C38", Offset = "0x2EC1C38", VA = "0x2EC5C38")]
				set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x60000A8")]
				[Address(RVA = "0x2EC5C40", Offset = "0x2EC1C40", VA = "0x2EC5C40")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x2EC5C48", Offset = "0x2EC1C48", VA = "0x2EC5C48")]
				set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public Toggle toggle
			{
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x2EC5C50", Offset = "0x2EC1C50", VA = "0x2EC5C50")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x2EC5C58", Offset = "0x2EC1C58", VA = "0x2EC5C58")]
				set
				{
				}
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2EC5C60", Offset = "0x2EC1C60", VA = "0x2EC5C60", Slot = "6")]
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2EC5CDC", Offset = "0x2EC1CDC", VA = "0x2EC5CDC", Slot = "7")]
			public virtual void OnCancel(BaseEventData eventData)
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2EC5D88", Offset = "0x2EC1D88", VA = "0x2EC5D88")]
			public DropdownItem()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		public class OptionData
		{
			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Text;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite m_Image;

			[Token(Token = "0x17000023")]
			public string text
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x2EC5D90", Offset = "0x2EC1D90", VA = "0x2EC5D90")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x2EC5D98", Offset = "0x2EC1D98", VA = "0x2EC5D98")]
				set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public Sprite image
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x2EC5DA0", Offset = "0x2EC1DA0", VA = "0x2EC5DA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x2EC5DA8", Offset = "0x2EC1DA8", VA = "0x2EC5DA8")]
				set
				{
				}
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2EC2398", Offset = "0x2EBE398", VA = "0x2EC2398")]
			public OptionData()
			{
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2EC38D8", Offset = "0x2EBF8D8", VA = "0x2EC38D8")]
			public OptionData(string text)
			{
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2EC3A54", Offset = "0x2EBFA54", VA = "0x2EC3A54")]
			public OptionData(Sprite image)
			{
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2EC5DB0", Offset = "0x2EC1DB0", VA = "0x2EC5DB0")]
			public OptionData(string text, Sprite image)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000018")]
		public class OptionDataList
		{
			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<OptionData> m_Options;

			[Token(Token = "0x17000025")]
			public List<OptionData> options
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x2EC5DDC", Offset = "0x2EC1DDC", VA = "0x2EC5DDC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60000B8")]
				[Address(RVA = "0x2EC5DE4", Offset = "0x2EC1DE4", VA = "0x2EC5DE4")]
				set
				{
				}
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2EC32A8", Offset = "0x2EBF2A8", VA = "0x2EC32A8")]
			public OptionDataList()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000019")]
		public class DropdownEvent : UnityEvent<int>
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2EC3328", Offset = "0x2EBF328", VA = "0x2EC3328")]
			public DropdownEvent()
			{
			}
		}

		[Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class <DelayedDestroyDropdownList>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x28")]
			public Dropdown <>4__this;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x2EC5EC0", Offset = "0x2EC1EC0", VA = "0x2EC5EC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0x2EC5F00", Offset = "0x2EC1F00", VA = "0x2EC5F00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2EC5A54", Offset = "0x2EC1A54", VA = "0x2EC5A54")]
			[DebuggerHidden]
			public <DelayedDestroyDropdownList>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2EC5E10", Offset = "0x2EC1E10", VA = "0x2EC5E10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2EC5E14", Offset = "0x2EC1E14", VA = "0x2EC5E14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2EC5EC8", Offset = "0x2EC1EC8", VA = "0x2EC5EC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform m_Template;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text m_CaptionText;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Image m_CaptionImage;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x118")]
		[Space]
		[SerializeField]
		private Text m_ItemText;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image m_ItemImage;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x128")]
		[Space]
		[SerializeField]
		private int m_Value;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x130")]
		[Space]
		[SerializeField]
		private OptionDataList m_Options;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float m_AlphaFadeSpeed;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x148")]
		private GameObject m_Dropdown;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x150")]
		private GameObject m_Blocker;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x158")]
		private List<DropdownItem> m_Items;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x160")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x168")]
		private bool validTemplate;

		[Token(Token = "0x4000051")]
		private const int kHighSortingLayer = 30000;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		private static OptionData s_NoOptionData;

		[Token(Token = "0x17000016")]
		public RectTransform template
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2EC2FE8", Offset = "0x2EBEFE8", VA = "0x2EC2FE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2EC2368", Offset = "0x2EBE368", VA = "0x2EC2368")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Text captionText
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2EC2FF0", Offset = "0x2EBEFF0", VA = "0x2EC2FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2EC2370", Offset = "0x2EBE370", VA = "0x2EC2370")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Image captionImage
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2EC2FF8", Offset = "0x2EBEFF8", VA = "0x2EC2FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2EC3000", Offset = "0x2EBF000", VA = "0x2EC3000")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Text itemText
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2EC3008", Offset = "0x2EBF008", VA = "0x2EC3008")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2EC2378", Offset = "0x2EBE378", VA = "0x2EC2378")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Image itemImage
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2EC3010", Offset = "0x2EBF010", VA = "0x2EC3010")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2EC3018", Offset = "0x2EBF018", VA = "0x2EC3018")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public List<OptionData> options
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x2EC2380", Offset = "0x2EBE380", VA = "0x2EC2380")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x2EC3020", Offset = "0x2EBF020", VA = "0x2EC3020")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public DropdownEvent onValueChanged
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2EC3038", Offset = "0x2EBF038", VA = "0x2EC3038")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2EC3040", Offset = "0x2EBF040", VA = "0x2EC3040")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public float alphaFadeSpeed
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2EC3048", Offset = "0x2EBF048", VA = "0x2EC3048")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2EC3050", Offset = "0x2EBF050", VA = "0x2EC3050")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public int value
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2EC3058", Offset = "0x2EBF058", VA = "0x2EC3058")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2EC3060", Offset = "0x2EBF060", VA = "0x2EC3060")]
			set
			{
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2EC319C", Offset = "0x2EBF19C", VA = "0x2EC319C")]
		public void SetValueWithoutNotify(int input)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2EC3068", Offset = "0x2EBF068", VA = "0x2EC3068")]
		private void Set(int value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2EC31A4", Offset = "0x2EBF1A4", VA = "0x2EC31A4")]
		protected Dropdown()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2EC3370", Offset = "0x2EBF370", VA = "0x2EC3370", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2EC346C", Offset = "0x2EBF46C", VA = "0x2EC346C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2EC3508", Offset = "0x2EBF508", VA = "0x2EC3508", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2EC23A0", Offset = "0x2EBE3A0", VA = "0x2EC23A0")]
		public void RefreshShownValue()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2EC371C", Offset = "0x2EBF71C", VA = "0x2EC371C")]
		public void AddOptions(List<OptionData> options)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2EC3784", Offset = "0x2EBF784", VA = "0x2EC3784")]
		public void AddOptions(List<string> options)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2EC3900", Offset = "0x2EBF900", VA = "0x2EC3900")]
		public void AddOptions(List<Sprite> options)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2EC3A7C", Offset = "0x2EBFA7C", VA = "0x2EC3A7C")]
		public void ClearOptions()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2EC3AF4", Offset = "0x2EBFAF4", VA = "0x2EC3AF4")]
		private void SetupTemplate(Canvas rootCanvas)
		{
		}

		[Token(Token = "0x6000090")]
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2EC4194", Offset = "0x2EC0194", VA = "0x2EC4194", Slot = "42")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2EC4CFC", Offset = "0x2EC0CFC", VA = "0x2EC4CFC", Slot = "43")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2EC4D00", Offset = "0x2EC0D00", VA = "0x2EC4D00", Slot = "44")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2EC4198", Offset = "0x2EC0198", VA = "0x2EC4198")]
		public void Show()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2EC51F4", Offset = "0x2EC11F4", VA = "0x2EC51F4", Slot = "45")]
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2EC5724", Offset = "0x2EC1724", VA = "0x2EC5724", Slot = "46")]
		protected virtual void DestroyBlocker(GameObject blocker)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2EC577C", Offset = "0x2EC177C", VA = "0x2EC577C", Slot = "47")]
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2EC57E8", Offset = "0x2EC17E8", VA = "0x2EC57E8", Slot = "48")]
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2EC5840", Offset = "0x2EC1840", VA = "0x2EC5840", Slot = "49")]
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2EC58AC", Offset = "0x2EC18AC", VA = "0x2EC58AC", Slot = "50")]
		protected virtual void DestroyItem(DropdownItem item)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2EC4E08", Offset = "0x2EC0E08", VA = "0x2EC4E08")]
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2EC58B0", Offset = "0x2EC18B0", VA = "0x2EC58B0")]
		private void AlphaFadeList(float duration, float alpha)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2EC50EC", Offset = "0x2EC10EC", VA = "0x2EC50EC")]
		private void AlphaFadeList(float duration, float start, float end)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2EC5930", Offset = "0x2EC1930", VA = "0x2EC5930")]
		private void SetAlpha(float alpha)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2EC4D04", Offset = "0x2EC0D04", VA = "0x2EC4D04")]
		public void Hide()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2EC59E4", Offset = "0x2EC19E4", VA = "0x2EC59E4")]
		[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__75))]
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2EC359C", Offset = "0x2EBF59C", VA = "0x2EC359C")]
		private void ImmediateDestroyDropdownList()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2EC5A7C", Offset = "0x2EC1A7C", VA = "0x2EC5A7C")]
		private void OnSelectItem(Toggle toggle)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class FontData : ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("font")]
		[SerializeField]
		private Font m_Font;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("fontSize")]
		[SerializeField]
		private int m_FontSize;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FormerlySerializedAs("fontStyle")]
		private FontStyle m_FontStyle;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_BestFit;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_MinSize;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_MaxSize;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("alignment")]
		[SerializeField]
		private TextAnchor m_Alignment;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_AlignByGeometry;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		[FormerlySerializedAs("richText")]
		private bool m_RichText;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_LineSpacing;

		[Token(Token = "0x17000028")]
		public static FontData defaultFontData
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2EC5F08", Offset = "0x2EC1F08", VA = "0x2EC5F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public Font font
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2EC5FA0", Offset = "0x2EC1FA0", VA = "0x2EC5FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2EC5FA8", Offset = "0x2EC1FA8", VA = "0x2EC5FA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int fontSize
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2EC5FB0", Offset = "0x2EC1FB0", VA = "0x2EC5FB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2EC5FB8", Offset = "0x2EC1FB8", VA = "0x2EC5FB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2EC5FC0", Offset = "0x2EC1FC0", VA = "0x2EC5FC0")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2EC5FC8", Offset = "0x2EC1FC8", VA = "0x2EC5FC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool bestFit
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2EC5FD0", Offset = "0x2EC1FD0", VA = "0x2EC5FD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2EC5FD8", Offset = "0x2EC1FD8", VA = "0x2EC5FD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public int minSize
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2EC5FE0", Offset = "0x2EC1FE0", VA = "0x2EC5FE0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2EC5FE8", Offset = "0x2EC1FE8", VA = "0x2EC5FE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int maxSize
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2EC5FF0", Offset = "0x2EC1FF0", VA = "0x2EC5FF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2EC5FF8", Offset = "0x2EC1FF8", VA = "0x2EC5FF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public TextAnchor alignment
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2EC6000", Offset = "0x2EC2000", VA = "0x2EC6000")]
			get
			{
				return default(TextAnchor);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2EC6008", Offset = "0x2EC2008", VA = "0x2EC6008")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool alignByGeometry
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2EC6010", Offset = "0x2EC2010", VA = "0x2EC6010")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x2EC6018", Offset = "0x2EC2018", VA = "0x2EC6018")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool richText
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x2EC6020", Offset = "0x2EC2020", VA = "0x2EC6020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2EC6028", Offset = "0x2EC2028", VA = "0x2EC6028")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public HorizontalWrapMode horizontalOverflow
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2EC6030", Offset = "0x2EC2030", VA = "0x2EC6030")]
			get
			{
				return default(HorizontalWrapMode);
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2EC6038", Offset = "0x2EC2038", VA = "0x2EC6038")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public VerticalWrapMode verticalOverflow
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2EC6040", Offset = "0x2EC2040", VA = "0x2EC6040")]
			get
			{
				return default(VerticalWrapMode);
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2EC6048", Offset = "0x2EC2048", VA = "0x2EC6048")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public float lineSpacing
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2EC6050", Offset = "0x2EC2050", VA = "0x2EC6050")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2EC6058", Offset = "0x2EC2058", VA = "0x2EC6058")]
			set
			{
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2EC6060", Offset = "0x2EC2060", VA = "0x2EC6060", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2EC6064", Offset = "0x2EC2064", VA = "0x2EC6064", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2EC5F98", Offset = "0x2EC1F98", VA = "0x2EC5F98")]
		public FontData()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class FontUpdateTracker
	{
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Font, HashSet<Text>> m_Tracked;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2EC60A4", Offset = "0x2EC20A4", VA = "0x2EC60A4")]
		public static void TrackText(Text t)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2EC62EC", Offset = "0x2EC22EC", VA = "0x2EC62EC")]
		private static void RebuildForFont(Font f)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2EC6474", Offset = "0x2EC2474", VA = "0x2EC6474")]
		public static void UntrackText(Text t)
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_DefaultUI;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x8")]
		protected static Texture2D s_WhiteTexture;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("m_Mat")]
		protected Material m_Material;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color m_Color;

		[NonSerialized]
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x38")]
		protected bool m_SkipLayoutUpdate;

		[NonSerialized]
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x39")]
		protected bool m_SkipMaterialUpdate;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool m_RaycastTarget;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x3B")]
		private bool m_RaycastTargetCache;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector4 m_RaycastPadding;

		[NonSerialized]
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_RectTransform;

		[NonSerialized]
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x58")]
		private CanvasRenderer m_CanvasRenderer;

		[NonSerialized]
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x60")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x68")]
		private bool m_VertsDirty;

		[NonSerialized]
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x69")]
		private bool m_MaterialDirty;

		[NonSerialized]
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x70")]
		protected UnityAction m_OnDirtyLayoutCallback;

		[NonSerialized]
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x78")]
		protected UnityAction m_OnDirtyVertsCallback;

		[NonSerialized]
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x80")]
		protected UnityAction m_OnDirtyMaterialCallback;

		[NonSerialized]
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		protected static Mesh s_Mesh;

		[NonSerialized]
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly VertexHelper s_VertexHelper;

		[NonSerialized]
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x88")]
		protected Mesh m_CachedMesh;

		[NonSerialized]
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x90")]
		protected Vector2[] m_CachedUvs;

		[NonSerialized]
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x98")]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;

		[Token(Token = "0x17000035")]
		public static Material defaultGraphicMaterial
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2EC6708", Offset = "0x2EC2708", VA = "0x2EC6708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public virtual Color color
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2EC67E4", Offset = "0x2EC27E4", VA = "0x2EC67E4", Slot = "22")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2EC67F0", Offset = "0x2EC27F0", VA = "0x2EC67F0", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public virtual bool raycastTarget
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2EC6828", Offset = "0x2EC2828", VA = "0x2EC6828", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2EC6830", Offset = "0x2EC2830", VA = "0x2EC6830", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Vector4 raycastPadding
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2EC6CE8", Offset = "0x2EC2CE8", VA = "0x2EC6CE8")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2EC6CF4", Offset = "0x2EC2CF4", VA = "0x2EC6CF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		protected bool useLegacyMeshGeneration
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2EC6D00", Offset = "0x2EC2D00", VA = "0x2EC6D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2EC6D08", Offset = "0x2EC2D08", VA = "0x2EC6D08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public int depth
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2EC7830", Offset = "0x2EC3830", VA = "0x2EC7830")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2EC6FA8", Offset = "0x2EC2FA8", VA = "0x2EC6FA8", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Canvas canvas
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2EC690C", Offset = "0x2EC290C", VA = "0x2EC690C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public CanvasRenderer canvasRenderer
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2EC784C", Offset = "0x2EC384C", VA = "0x2EC784C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual Material defaultMaterial
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2EC78DC", Offset = "0x2EC38DC", VA = "0x2EC78DC", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual Material material
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2EC7928", Offset = "0x2EC3928", VA = "0x2EC7928", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2EC79B0", Offset = "0x2EC39B0", VA = "0x2EC79B0", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public virtual Material materialForRendering
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2EC7A48", Offset = "0x2EC3A48", VA = "0x2EC7A48", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public virtual Texture mainTexture
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2EC7C0C", Offset = "0x2EC3C0C", VA = "0x2EC7C0C", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		protected static Mesh workerMesh
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2EC8BDC", Offset = "0x2EC4BDC", VA = "0x2EC8BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2EC6D10", Offset = "0x2EC2D10", VA = "0x2EC6D10")]
		protected Graphic()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2EC6DC0", Offset = "0x2EC2DC0", VA = "0x2EC6DC0", Slot = "26")]
		public virtual void SetAllDirty()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2EC6F08", Offset = "0x2EC2F08", VA = "0x2EC6F08", Slot = "27")]
		public virtual void SetLayoutDirty()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2EC7000", Offset = "0x2EC3000", VA = "0x2EC7000", Slot = "28")]
		public virtual void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2EC7094", Offset = "0x2EC3094", VA = "0x2EC7094", Slot = "29")]
		public virtual void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2EC6E30", Offset = "0x2EC2E30", VA = "0x2EC6E30")]
		public void SetRaycastDirty()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2EC7128", Offset = "0x2EC3128", VA = "0x2EC7128", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2EC71D4", Offset = "0x2EC31D4", VA = "0x2EC71D4", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2EC7420", Offset = "0x2EC3420", VA = "0x2EC7420", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2EC74D4", Offset = "0x2EC34D4", VA = "0x2EC74D4")]
		private void CacheCanvas()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2EC7C64", Offset = "0x2EC3C64", VA = "0x2EC7C64", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2EC7D94", Offset = "0x2EC3D94", VA = "0x2EC7D94", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2EC805C", Offset = "0x2EC405C", VA = "0x2EC805C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2EC8160", Offset = "0x2EC4160", VA = "0x2EC8160", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2EC8298", Offset = "0x2EC4298", VA = "0x2EC8298", Slot = "36")]
		public virtual void OnCullingChanged()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2EC8324", Offset = "0x2EC4324", VA = "0x2EC8324", Slot = "37")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2EC8408", Offset = "0x2EC4408", VA = "0x2EC8408", Slot = "38")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2EC840C", Offset = "0x2EC440C", VA = "0x2EC840C", Slot = "39")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2EC8410", Offset = "0x2EC4410", VA = "0x2EC8410", Slot = "40")]
		protected virtual void UpdateMaterial()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2EC84C8", Offset = "0x2EC44C8", VA = "0x2EC84C8", Slot = "41")]
		protected virtual void UpdateGeometry()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2EC8840", Offset = "0x2EC4840", VA = "0x2EC8840")]
		private void DoMeshGeneration()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2EC84D8", Offset = "0x2EC44D8", VA = "0x2EC84D8")]
		private void DoLegacyMeshGeneration()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2EC8CFC", Offset = "0x2EC4CFC", VA = "0x2EC8CFC", Slot = "42")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2EC8D00", Offset = "0x2EC4D00", VA = "0x2EC8D00", Slot = "43")]
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2EC8D98", Offset = "0x2EC4D98", VA = "0x2EC8D98", Slot = "44")]
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2EC9020", Offset = "0x2EC5020", VA = "0x2EC9020", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2EC9030", Offset = "0x2EC5030", VA = "0x2EC9030", Slot = "45")]
		public virtual void SetNativeSize()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2EC9034", Offset = "0x2EC5034", VA = "0x2EC9034", Slot = "46")]
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2EC94C0", Offset = "0x2EC54C0", VA = "0x2EC94C0")]
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2EC8EF4", Offset = "0x2EC4EF4", VA = "0x2EC8EF4")]
		public Rect GetPixelAdjustedRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2EC9600", Offset = "0x2EC5600", VA = "0x2EC9600", Slot = "47")]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2EC9614", Offset = "0x2EC5614", VA = "0x2EC9614", Slot = "48")]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2EC9884", Offset = "0x2EC5884", VA = "0x2EC9884")]
		private static Color CreateColorFromAlpha(float alpha)
		{
			return default(Color);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2EC9898", Offset = "0x2EC5898", VA = "0x2EC9898", Slot = "49")]
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2EC9934", Offset = "0x2EC5934", VA = "0x2EC9934")]
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2EC99B4", Offset = "0x2EC59B4", VA = "0x2EC99B4")]
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2EC9A34", Offset = "0x2EC5A34", VA = "0x2EC9A34")]
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2EC9AB4", Offset = "0x2EC5AB4", VA = "0x2EC9AB4")]
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2EC9B34", Offset = "0x2EC5B34", VA = "0x2EC9B34")]
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2EC9BB4", Offset = "0x2EC5BB4", VA = "0x2EC9BB4")]
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2EC9CBC", Offset = "0x2EC5CBC", VA = "0x2EC9CBC", Slot = "18")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	[AddComponentMenu("Event/Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycaster : BaseRaycaster
	{
		[Token(Token = "0x2000020")]
		public enum BlockingObjects
		{
			[Token(Token = "0x400008C")]
			None,
			[Token(Token = "0x400008D")]
			TwoD,
			[Token(Token = "0x400008E")]
			ThreeD,
			[Token(Token = "0x400008F")]
			All
		}

		[Token(Token = "0x4000084")]
		protected const int kNoEventMaskSet = -1;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("ignoreReversedGraphics")]
		[SerializeField]
		private bool m_IgnoreReversedGraphics;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("blockingObjects")]
		private BlockingObjects m_BlockingObjects;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected LayerMask m_BlockingMask;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x40")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x17000043")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2EC9CC4", Offset = "0x2EC5CC4", VA = "0x2EC9CC4", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public override int renderOrderPriority
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2EC9DA0", Offset = "0x2EC5DA0", VA = "0x2EC9DA0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		public bool ignoreReversedGraphics
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2EC9DF4", Offset = "0x2EC5DF4", VA = "0x2EC9DF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2EC9DFC", Offset = "0x2EC5DFC", VA = "0x2EC9DFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public BlockingObjects blockingObjects
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2EC9E04", Offset = "0x2EC5E04", VA = "0x2EC9E04")]
			get
			{
				return default(BlockingObjects);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2EC9E0C", Offset = "0x2EC5E0C", VA = "0x2EC9E0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public LayerMask blockingMask
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2EC9E14", Offset = "0x2EC5E14", VA = "0x2EC9E14")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2EC9E1C", Offset = "0x2EC5E1C", VA = "0x2EC9E1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		private Canvas canvas
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2EC9D0C", Offset = "0x2EC5D0C", VA = "0x2EC9D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2ECAF94", Offset = "0x2EC6F94", VA = "0x2ECAF94", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2EC9E24", Offset = "0x2EC5E24", VA = "0x2EC9E24")]
		protected GraphicRaycaster()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2EC9EBC", Offset = "0x2EC5EBC", VA = "0x2EC9EBC", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2ECAA0C", Offset = "0x2EC6A0C", VA = "0x2ECAA0C")]
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class GraphicRegistry
	{
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x0")]
		private static GraphicRegistry s_Instance;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Graphic> s_EmptyList;

		[Token(Token = "0x1700004A")]
		public static GraphicRegistry instance
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2ECB33C", Offset = "0x2EC733C", VA = "0x2ECB33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2ECB194", Offset = "0x2EC7194", VA = "0x2ECB194")]
		protected GraphicRegistry()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2EC7644", Offset = "0x2EC3644", VA = "0x2EC7644")]
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2EC6AFC", Offset = "0x2EC2AFC", VA = "0x2EC6AFC")]
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2EC727C", Offset = "0x2EC327C", VA = "0x2EC727C")]
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2EC6980", Offset = "0x2EC2980", VA = "0x2EC6980")]
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2EC7EDC", Offset = "0x2EC3EDC", VA = "0x2EC7EDC")]
		public static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2ECB3DC", Offset = "0x2EC73DC", VA = "0x2ECB3DC")]
		public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2ECB55C", Offset = "0x2EC755C", VA = "0x2ECB55C")]
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2ECA950", Offset = "0x2EC6950", VA = "0x2ECA950")]
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	[Obsolete("Not supported anymore")]
	internal interface IGraphicEnabledDisabled
	{
		[Token(Token = "0x600013C")]
		void OnSiblingGraphicEnabledDisabled();
	}
	[Token(Token = "0x2000024")]
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Image", 11)]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		[Token(Token = "0x2000025")]
		public enum Type
		{
			[Token(Token = "0x40000AC")]
			Simple,
			[Token(Token = "0x40000AD")]
			Sliced,
			[Token(Token = "0x40000AE")]
			Tiled,
			[Token(Token = "0x40000AF")]
			Filled
		}

		[Token(Token = "0x2000026")]
		public enum FillMethod
		{
			[Token(Token = "0x40000B1")]
			Horizontal,
			[Token(Token = "0x40000B2")]
			Vertical,
			[Token(Token = "0x40000B3")]
			Radial90,
			[Token(Token = "0x40000B4")]
			Radial180,
			[Token(Token = "0x40000B5")]
			Radial360
		}

		[Token(Token = "0x2000027")]
		public enum OriginHorizontal
		{
			[Token(Token = "0x40000B7")]
			Left,
			[Token(Token = "0x40000B8")]
			Right
		}

		[Token(Token = "0x2000028")]
		public enum OriginVertical
		{
			[Token(Token = "0x40000BA")]
			Bottom,
			[Token(Token = "0x40000BB")]
			Top
		}

		[Token(Token = "0x2000029")]
		public enum Origin90
		{
			[Token(Token = "0x40000BD")]
			BottomLeft,
			[Token(Token = "0x40000BE")]
			TopLeft,
			[Token(Token = "0x40000BF")]
			TopRight,
			[Token(Token = "0x40000C0")]
			BottomRight
		}

		[Token(Token = "0x200002A")]
		public enum Origin180
		{
			[Token(Token = "0x40000C2")]
			Bottom,
			[Token(Token = "0x40000C3")]
			Left,
			[Token(Token = "0x40000C4")]
			Top,
			[Token(Token = "0x40000C5")]
			Right
		}

		[Token(Token = "0x200002B")]
		public enum Origin360
		{
			[Token(Token = "0x40000C7")]
			Bottom,
			[Token(Token = "0x40000C8")]
			Right,
			[Token(Token = "0x40000C9")]
			Top,
			[Token(Token = "0x40000CA")]
			Left
		}

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_ETC1DefaultUI;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[FormerlySerializedAs("m_Frame")]
		private Sprite m_Sprite;

		[NonSerialized]
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xE0")]
		private Sprite m_OverrideSprite;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Type m_Type;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private bool m_PreserveAspect;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xED")]
		[SerializeField]
		private bool m_FillCenter;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private FillMethod m_FillMethod;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_FillAmount;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_FillClockwise;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private int m_FillOrigin;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x100")]
		private float m_AlphaHitTestMinimumThreshold;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x104")]
		private bool m_Tracked;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x105")]
		[SerializeField]
		private bool m_UseSpriteMesh;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float m_PixelsPerUnitMultiplier;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x10C")]
		private float m_CachedReferencePixelsPerUnit;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2[] s_VertScratch;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2[] s_UVScratch;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector3[] s_Xy;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector3[] s_Uv;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		private static List<Image> m_TrackedTexturelessImages;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x30")]
		private static bool s_Initialized;

		[Token(Token = "0x1700004B")]
		public Sprite sprite
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2ECB6A4", Offset = "0x2EC76A4", VA = "0x2ECB6A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2EBEF38", Offset = "0x2EBAF38", VA = "0x2EBEF38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Sprite overrideSprite
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2ECB830", Offset = "0x2EC7830", VA = "0x2ECB830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2ECB8AC", Offset = "0x2EC78AC", VA = "0x2ECB8AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		private Sprite activeSprite
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2ECB834", Offset = "0x2EC7834", VA = "0x2ECB834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public Type type
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2ECB934", Offset = "0x2EC7934", VA = "0x2ECB934")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2EBF1E8", Offset = "0x2EBB1E8", VA = "0x2EBF1E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool preserveAspect
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2ECB93C", Offset = "0x2EC793C", VA = "0x2ECB93C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2ECB944", Offset = "0x2EC7944", VA = "0x2ECB944")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool fillCenter
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2ECB9C4", Offset = "0x2EC79C4", VA = "0x2ECB9C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2ECB9CC", Offset = "0x2EC79CC", VA = "0x2ECB9CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public FillMethod fillMethod
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2ECBA4C", Offset = "0x2EC7A4C", VA = "0x2ECBA4C")]
			get
			{
				return default(FillMethod);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2ECBA54", Offset = "0x2EC7A54", VA = "0x2ECBA54")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public float fillAmount
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2ECBACC", Offset = "0x2EC7ACC", VA = "0x2ECBACC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2ECBAD4", Offset = "0x2EC7AD4", VA = "0x2ECBAD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool fillClockwise
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2ECBB68", Offset = "0x2EC7B68", VA = "0x2ECBB68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2ECBB70", Offset = "0x2EC7B70", VA = "0x2ECBB70")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public int fillOrigin
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2ECBBF0", Offset = "0x2EC7BF0", VA = "0x2ECBBF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2ECBBF8", Offset = "0x2EC7BF8", VA = "0x2ECBBF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		public float eventAlphaThreshold
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2ECBC78", Offset = "0x2EC7C78", VA = "0x2ECBC78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2ECBC88", Offset = "0x2EC7C88", VA = "0x2ECBC88")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float alphaHitTestMinimumThreshold
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2ECBDD4", Offset = "0x2EC7DD4", VA = "0x2ECBDD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2ECBC94", Offset = "0x2EC7C94", VA = "0x2ECBC94")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public bool useSpriteMesh
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2ECBDDC", Offset = "0x2EC7DDC", VA = "0x2ECBDDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2ECBDE4", Offset = "0x2EC7DE4", VA = "0x2ECBDE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public static Material defaultETC1GraphicMaterial
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2ECBEA4", Offset = "0x2EC7EA4", VA = "0x2ECBEA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2ECBF80", Offset = "0x2EC7F80", VA = "0x2ECBF80", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public bool hasBorder
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2ECC0F8", Offset = "0x2EC80F8", VA = "0x2ECC0F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public float pixelsPerUnitMultiplier
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2ECC1B0", Offset = "0x2EC81B0", VA = "0x2ECC1B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2ECC1B8", Offset = "0x2EC81B8", VA = "0x2ECC1B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2ECC1DC", Offset = "0x2EC81DC", VA = "0x2ECC1DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005D")]
		protected float multipliedPixelsPerUnit
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2ECC2D0", Offset = "0x2EC82D0", VA = "0x2ECC2D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005E")]
		public override Material material
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2ECC2EC", Offset = "0x2EC82EC", VA = "0x2ECC2EC", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2ECC418", Offset = "0x2EC8418", VA = "0x2ECC418", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2ECF904", Offset = "0x2ECB904", VA = "0x2ECF904", Slot = "81")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000060")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2ECF90C", Offset = "0x2ECB90C", VA = "0x2ECF90C", Slot = "82")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000061")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2ECF9D4", Offset = "0x2ECB9D4", VA = "0x2ECF9D4", Slot = "83")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000062")]
		public virtual float minHeight
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2ECF9DC", Offset = "0x2ECB9DC", VA = "0x2ECF9DC", Slot = "84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000063")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2ECF9E4", Offset = "0x2ECB9E4", VA = "0x2ECF9E4", Slot = "85")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000064")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2ECFAAC", Offset = "0x2ECBAAC", VA = "0x2ECFAAC", Slot = "86")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2ECFAB4", Offset = "0x2ECBAB4", VA = "0x2ECFAB4", Slot = "87")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2ECB828", Offset = "0x2EC7828", VA = "0x2ECB828")]
		public void DisableSpriteOptimizations()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2ECBE64", Offset = "0x2EC7E64", VA = "0x2ECBE64")]
		protected Image()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2ECC41C", Offset = "0x2EC841C", VA = "0x2ECC41C", Slot = "77")]
		public virtual void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2ECC420", Offset = "0x2EC8420", VA = "0x2ECC420", Slot = "78")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2ECC474", Offset = "0x2EC8474", VA = "0x2ECC474")]
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2ECC510", Offset = "0x2EC8510", VA = "0x2ECC510")]
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2ECC8C8", Offset = "0x2EC88C8", VA = "0x2ECC8C8", Slot = "45")]
		public override void SetNativeSize()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2ECCA08", Offset = "0x2EC8A08", VA = "0x2ECCA08", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2ECB73C", Offset = "0x2EC773C", VA = "0x2ECB73C")]
		private void TrackSprite()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2ECED30", Offset = "0x2ECAD30", VA = "0x2ECED30", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2ECED4C", Offset = "0x2ECAD4C", VA = "0x2ECED4C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2ECEE40", Offset = "0x2ECAE40", VA = "0x2ECEE40", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2ECEF34", Offset = "0x2ECAF34", VA = "0x2ECEF34", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2ECCB48", Offset = "0x2EC8B48", VA = "0x2ECCB48")]
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2ECCDF4", Offset = "0x2EC8DF4", VA = "0x2ECCDF4")]
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2ECD0D4", Offset = "0x2EC90D4", VA = "0x2ECD0D4")]
		private void GenerateSlicedSprite(VertexHelper toFill)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2ECD614", Offset = "0x2EC9614", VA = "0x2ECD614")]
		private void GenerateTiledSprite(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2ECF30C", Offset = "0x2ECB30C", VA = "0x2ECF30C")]
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2ECF1C0", Offset = "0x2ECB1C0", VA = "0x2ECF1C0")]
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2ECF03C", Offset = "0x2ECB03C", VA = "0x2ECF03C")]
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2ECE36C", Offset = "0x2ECA36C", VA = "0x2ECE36C")]
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2ECF3E8", Offset = "0x2ECB3E8", VA = "0x2ECF3E8")]
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2ECF504", Offset = "0x2ECB504", VA = "0x2ECF504")]
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2ECF8FC", Offset = "0x2ECB8FC", VA = "0x2ECF8FC", Slot = "79")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2ECF900", Offset = "0x2ECB900", VA = "0x2ECF900", Slot = "80")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2ECFABC", Offset = "0x2ECBABC", VA = "0x2ECFABC", Slot = "88")]
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2ECFE40", Offset = "0x2ECBE40", VA = "0x2ECFE40")]
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2ED00D0", Offset = "0x2ECC0D0", VA = "0x2ED00D0")]
		private static void RebuildImage(SpriteAtlas spriteAtlas)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2ECEBD8", Offset = "0x2ECABD8", VA = "0x2ECEBD8")]
		private static void TrackImage(Image g)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2ECEDC0", Offset = "0x2ECADC0", VA = "0x2ECEDC0")]
		private static void UnTrackImage(Image g)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2ED0270", Offset = "0x2ECC270", VA = "0x2ED0270", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[Obsolete("Not supported anymore.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IMask
	{
		[Token(Token = "0x17000066")]
		RectTransform rectTransform
		{
			[Token(Token = "0x6000189")]
			get;
		}

		[Token(Token = "0x6000188")]
		bool Enabled();
	}
	[Token(Token = "0x200002D")]
	public interface IMaskable
	{
		[Token(Token = "0x600018A")]
		void RecalculateMasking();
	}
	[Token(Token = "0x200002E")]
	[AddComponentMenu("UI/Legacy/Input Field", 103)]
	public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
	{
		[Token(Token = "0x200002F")]
		public enum ContentType
		{
			[Token(Token = "0x4000104")]
			Standard,
			[Token(Token = "0x4000105")]
			Autocorrected,
			[Token(Token = "0x4000106")]
			IntegerNumber,
			[Token(Token = "0x4000107")]
			DecimalNumber,
			[Token(Token = "0x4000108")]
			Alphanumeric,
			[Token(Token = "0x4000109")]
			Name,
			[Token(Token = "0x400010A")]
			EmailAddress,
			[Token(Token = "0x400010B")]
			Password,
			[Token(Token = "0x400010C")]
			Pin,
			[Token(Token = "0x400010D")]
			Custom
		}

		[Token(Token = "0x2000030")]
		public enum InputType
		{
			[Token(Token = "0x400010F")]
			Standard,
			[Token(Token = "0x4000110")]
			AutoCorrect,
			[Token(Token = "0x4000111")]
			Password
		}

		[Token(Token = "0x2000031")]
		public enum CharacterValidation
		{
			[Token(Token = "0x4000113")]
			None,
			[Token(Token = "0x4000114")]
			Integer,
			[Token(Token = "0x4000115")]
			Decimal,
			[Token(Token = "0x4000116")]
			Alphanumeric,
			[Token(Token = "0x4000117")]
			Name,
			[Token(Token = "0x4000118")]
			EmailAddress
		}

		[Token(Token = "0x2000032")]
		public enum LineType
		{
			[Token(Token = "0x400011A")]
			SingleLine,
			[Token(Token = "0x400011B")]
			MultiLineSubmit,
			[Token(Token = "0x400011C")]
			MultiLineNewline
		}

		[Token(Token = "0x2000033")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		[Serializable]
		[Token(Token = "0x2000034")]
		public class SubmitEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x300E048", Offset = "0x300A048", VA = "0x300E048")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		public class EndEditEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x300E090", Offset = "0x300A090", VA = "0x300E090")]
			public EndEditEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x300E0D8", Offset = "0x300A0D8", VA = "0x300E0D8")]
			public OnChangeEvent()
			{
			}
		}

		[Token(Token = "0x2000037")]
		protected enum EditState
		{
			[Token(Token = "0x400011E")]
			Continue,
			[Token(Token = "0x400011F")]
			Finish
		}

		[Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <CaretBlink>d__172 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x20")]
			public InputField <>4__this;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x3017618", Offset = "0x3013618", VA = "0x3017618", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600023D")]
				[Address(RVA = "0x3017658", Offset = "0x3013658", VA = "0x3017658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x3010344", Offset = "0x300C344", VA = "0x3010344")]
			[DebuggerHidden]
			public <CaretBlink>d__172(int <>1__state)
			{
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x3017510", Offset = "0x3013510", VA = "0x3017510", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x3017514", Offset = "0x3013514", VA = "0x3017514", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x3017620", Offset = "0x3013620", VA = "0x3017620", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <MouseDragOutsideRect>d__196 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000124")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000125")]
			[FieldOffset(Offset = "0x20")]
			public PointerEventData eventData;

			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x28")]
			public InputField <>4__this;

			[Token(Token = "0x17000096")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000241")]
				[Address(RVA = "0x30178C8", Offset = "0x30138C8", VA = "0x30178C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000243")]
				[Address(RVA = "0x3017908", Offset = "0x3013908", VA = "0x3017908", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x3012CA8", Offset = "0x300ECA8", VA = "0x3012CA8")]
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__196(int <>1__state)
			{
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x3017660", Offset = "0x3013660", VA = "0x3017660", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x3017664", Offset = "0x3013664", VA = "0x3017664", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x30178D0", Offset = "0x30138D0", VA = "0x30178D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x100")]
		protected TouchScreenKeyboard m_Keyboard;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] kSeparators;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_IsQuestDeviceEvaluated;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x9")]
		private static bool s_IsQuestDevice;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x108")]
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected Graphic m_Placeholder;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ContentType m_ContentType;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[FormerlySerializedAs("inputType")]
		private InputType m_InputType;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[FormerlySerializedAs("asteriskChar")]
		private char m_AsteriskChar;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x124")]
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private LineType m_LineType;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x12C")]
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[FormerlySerializedAs("validation")]
		private CharacterValidation m_CharacterValidation;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		[FormerlySerializedAs("characterLimit")]
		private int m_CharacterLimit;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x138")]
		[FormerlySerializedAs("m_EndEdit")]
		[SerializeField]
		[FormerlySerializedAs("m_OnEndEdit")]
		[FormerlySerializedAs("onSubmit")]
		[FormerlySerializedAs("m_OnSubmit")]
		private SubmitEvent m_OnSubmit;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private EndEditEvent m_OnDidEndEdit;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x148")]
		[FormerlySerializedAs("onValueChange")]
		[SerializeField]
		[FormerlySerializedAs("m_OnValueChange")]
		private OnChangeEvent m_OnValueChanged;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[FormerlySerializedAs("onValidateInput")]
		private OnValidateInput m_OnValidateInput;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x158")]
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		private Color m_CaretColor;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private bool m_CustomCaretColor;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private Color m_SelectionColor;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x180")]
		[Multiline]
		[FormerlySerializedAs("mValue")]
		[SerializeField]
		protected string m_Text;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x188")]
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18C")]
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private bool m_ReadOnly;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x191")]
		[SerializeField]
		private bool m_ShouldActivateOnSelect;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x194")]
		protected int m_CaretPosition;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x198")]
		protected int m_CaretSelectPosition;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x1A0")]
		private RectTransform caretRectTrans;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x1A8")]
		protected UIVertex[] m_CursorVerts;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x1B0")]
		private TextGenerator m_InputTextCache;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x1B8")]
		private CanvasRenderer m_CachedInputRenderer;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x1C0")]
		private bool m_PreventFontCallback;

		[NonSerialized]
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x1C8")]
		protected Mesh m_Mesh;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x1D0")]
		private bool m_AllowInput;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x1D1")]
		private bool m_ShouldActivateNextUpdate;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x1D2")]
		private bool m_UpdateDrag;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x1D3")]
		private bool m_DragPositionOutOfBounds;

		[Token(Token = "0x40000F1")]
		private const float kHScrollSpeed = 0.05f;

		[Token(Token = "0x40000F2")]
		private const float kVScrollSpeed = 0.1f;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x1D4")]
		protected bool m_CaretVisible;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x1D8")]
		private Coroutine m_BlinkCoroutine;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x1E0")]
		private float m_BlinkStartTime;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1E4")]
		protected int m_DrawStart;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x1E8")]
		protected int m_DrawEnd;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x1F0")]
		private Coroutine m_DragCoroutine;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1F8")]
		private string m_OriginalText;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x200")]
		private bool m_WasCanceled;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x201")]
		private bool m_HasDoneFocusTransition;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x208")]
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x210")]
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x211")]
		private bool m_IsCompositionActive;

		[Token(Token = "0x40000FF")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		[Token(Token = "0x4000100")]
		private const string kOculusQuestDeviceModel = "Oculus Quest";

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x218")]
		private Event m_ProcessingEvent;

		[Token(Token = "0x4000102")]
		private const int k_MaxTextLength = 16382;

		[Token(Token = "0x17000067")]
		private BaseInput input
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x300DD08", Offset = "0x3009D08", VA = "0x300DD08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private string compositionString
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x300DE18", Offset = "0x3009E18", VA = "0x300DE18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		protected Mesh mesh
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x300E1C4", Offset = "0x300A1C4", VA = "0x300E1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		protected TextGenerator cachedInputTextGenerator
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x300E264", Offset = "0x300A264", VA = "0x300E264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool shouldHideMobileInput
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x300E320", Offset = "0x300A320", VA = "0x300E320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x300E2C8", Offset = "0x300A2C8", VA = "0x300E2C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public virtual bool shouldActivateOnSelect
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x300E3A8", Offset = "0x300A3A8", VA = "0x300E3A8", Slot = "60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x300E3A0", Offset = "0x300A3A0", VA = "0x300E3A0", Slot = "59")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public string text
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x300E418", Offset = "0x300A418", VA = "0x300E418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x300E420", Offset = "0x300A420", VA = "0x300E420")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isFocused
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x300EC84", Offset = "0x300AC84", VA = "0x300EC84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public float caretBlinkRate
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x300EC8C", Offset = "0x300AC8C", VA = "0x300EC8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x300EC94", Offset = "0x300AC94", VA = "0x300EC94")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int caretWidth
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x300ED64", Offset = "0x300AD64", VA = "0x300ED64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x300ED6C", Offset = "0x300AD6C", VA = "0x300ED6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public Text textComponent
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x300EE38", Offset = "0x300AE38", VA = "0x300EE38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x300EE40", Offset = "0x300AE40", VA = "0x300EE40")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public Graphic placeholder
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x300F0C0", Offset = "0x300B0C0", VA = "0x300F0C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x300F0C8", Offset = "0x300B0C8", VA = "0x300F0C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public Color caretColor
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x300F120", Offset = "0x300B120", VA = "0x300F120")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x300F164", Offset = "0x300B164", VA = "0x300F164")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool customCaretColor
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x300F190", Offset = "0x300B190", VA = "0x300F190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x300F198", Offset = "0x300B198", VA = "0x300F198")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public Color selectionColor
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x300F1B4", Offset = "0x300B1B4", VA = "0x300F1B4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x300F1C8", Offset = "0x300B1C8", VA = "0x300F1C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public EndEditEvent onEndEdit
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x300F1F4", Offset = "0x300B1F4", VA = "0x300F1F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x300F1FC", Offset = "0x300B1FC", VA = "0x300F1FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public SubmitEvent onSubmit
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x300F254", Offset = "0x300B254", VA = "0x300F254")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x300F25C", Offset = "0x300B25C", VA = "0x300F25C")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public OnChangeEvent onValueChange
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x300F2B4", Offset = "0x300B2B4", VA = "0x300F2B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x300F2BC", Offset = "0x300B2BC", VA = "0x300F2BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public OnChangeEvent onValueChanged
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x300F318", Offset = "0x300B318", VA = "0x300F318")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x300F2C0", Offset = "0x300B2C0", VA = "0x300F2C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public OnValidateInput onValidateInput
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x300F320", Offset = "0x300B320", VA = "0x300F320")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x300F328", Offset = "0x300B328", VA = "0x300F328")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public int characterLimit
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x300F380", Offset = "0x300B380", VA = "0x300F380")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x300F388", Offset = "0x300B388", VA = "0x300F388")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public ContentType contentType
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x300F444", Offset = "0x300B444", VA = "0x300F444")]
			get
			{
				return default(ContentType);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x300F44C", Offset = "0x300B44C", VA = "0x300F44C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public LineType lineType
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x300F5C8", Offset = "0x300B5C8", VA = "0x300F5C8")]
			get
			{
				return default(LineType);
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x300F5D0", Offset = "0x300B5D0", VA = "0x300F5D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public InputType inputType
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x300F6F8", Offset = "0x300B6F8", VA = "0x300F6F8")]
			get
			{
				return default(InputType);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x300F700", Offset = "0x300B700", VA = "0x300F700")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public TouchScreenKeyboard touchScreenKeyboard
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x300F79C", Offset = "0x300B79C", VA = "0x300F79C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public TouchScreenKeyboardType keyboardType
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x300F7A4", Offset = "0x300B7A4", VA = "0x300F7A4")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x300F7AC", Offset = "0x300B7AC", VA = "0x300F7AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public CharacterValidation characterValidation
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x300F830", Offset = "0x300B830", VA = "0x300F830")]
			get
			{
				return default(CharacterValidation);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x300F838", Offset = "0x300B838", VA = "0x300F838")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool readOnly
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x300F8BC", Offset = "0x300B8BC", VA = "0x300F8BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x300F8C4", Offset = "0x300B8C4", VA = "0x300F8C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool multiLine
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x300F8CC", Offset = "0x300B8CC", VA = "0x300F8CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public char asteriskChar
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x300F8E0", Offset = "0x300B8E0", VA = "0x300F8E0")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x300F8E8", Offset = "0x300B8E8", VA = "0x300F8E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool wasCanceled
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x300F95C", Offset = "0x300B95C", VA = "0x300F95C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		protected int caretPositionInternal
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x300F998", Offset = "0x300B998", VA = "0x300F998")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x300F9BC", Offset = "0x300B9BC", VA = "0x300F9BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		protected int caretSelectPositionInternal
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x300F9F0", Offset = "0x300B9F0", VA = "0x300F9F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x300FA14", Offset = "0x300BA14", VA = "0x300FA14")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		private bool hasSelection
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x300FA48", Offset = "0x300BA48", VA = "0x300FA48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public int caretPosition
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x300FA78", Offset = "0x300BA78", VA = "0x300FA78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x300FA9C", Offset = "0x300BA9C", VA = "0x300FA9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x300FB74", Offset = "0x300BB74", VA = "0x300FB74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x300FAC4", Offset = "0x300BAC4", VA = "0x300FAC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x300FB98", Offset = "0x300BB98", VA = "0x300FB98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x300FB1C", Offset = "0x300BB1C", VA = "0x300FB1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		private static string clipboard
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x30105C8", Offset = "0x300C5C8", VA = "0x30105C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x3010618", Offset = "0x300C618", VA = "0x3010618")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x30170E0", Offset = "0x30130E0", VA = "0x30170E0", Slot = "75")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x30170E8", Offset = "0x30130E8", VA = "0x30170E8", Slot = "76")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x3017224", Offset = "0x3013224", VA = "0x3017224", Slot = "77")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000090")]
		public virtual float minHeight
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x301722C", Offset = "0x301322C", VA = "0x301722C", Slot = "78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000091")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x3017234", Offset = "0x3013234", VA = "0x3017234", Slot = "79")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000092")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x301735C", Offset = "0x301335C", VA = "0x301735C", Slot = "80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000093")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x3017364", Offset = "0x3013364", VA = "0x3017364", Slot = "81")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x300DEAC", Offset = "0x3009EAC", VA = "0x300DEAC")]
		protected InputField()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x300E758", Offset = "0x300A758", VA = "0x300E758")]
		public void SetTextWithoutNotify(string input)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x300E428", Offset = "0x300A428", VA = "0x300E428")]
		private void SetText(string value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x300F964", Offset = "0x300B964", VA = "0x300F964")]
		protected void ClampPos(ref int pos)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x300FBBC", Offset = "0x300BBBC", VA = "0x300FBBC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x300FC7C", Offset = "0x300BC7C", VA = "0x300FC7C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x300FEDC", Offset = "0x300BEDC", VA = "0x300FEDC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x3010280", Offset = "0x300C280", VA = "0x3010280", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x30102E4", Offset = "0x300C2E4", VA = "0x30102E4")]
		[IteratorStateMachine(typeof(<CaretBlink>d__172))]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x301036C", Offset = "0x300C36C", VA = "0x301036C")]
		private void SetCaretVisible()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x300ED10", Offset = "0x300AD10", VA = "0x300ED10")]
		private void SetCaretActive()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x30103A0", Offset = "0x300C3A0", VA = "0x30103A0")]
		private void UpdateCaretMaterial()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x30104B0", Offset = "0x300C4B0", VA = "0x30104B0")]
		protected void OnFocus()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x30104B4", Offset = "0x300C4B4", VA = "0x30104B4")]
		protected void SelectAll()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x30104EC", Offset = "0x300C4EC", VA = "0x30104EC")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x301054C", Offset = "0x300C54C", VA = "0x301054C")]
		public void MoveTextStart(bool shift)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3010670", Offset = "0x300C670", VA = "0x3010670")]
		private bool TouchScreenKeyboardShouldBeUsed()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3010728", Offset = "0x300C728", VA = "0x3010728")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x3010750", Offset = "0x300C750", VA = "0x3010750")]
		private bool InPlaceEditingChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x30107D0", Offset = "0x300C7D0", VA = "0x30107D0")]
		private RangeInt GetInternalSelection()
		{
			return default(RangeInt);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x3010884", Offset = "0x300C884", VA = "0x3010884")]
		private void UpdateKeyboardCaret()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x301094C", Offset = "0x300C94C", VA = "0x301094C")]
		private void UpdateCaretFromKeyboard()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x3010A40", Offset = "0x300CA40", VA = "0x3010A40", Slot = "61")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x3011FB8", Offset = "0x300DFB8", VA = "0x3011FB8")]
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x3012354", Offset = "0x300E354", VA = "0x3012354")]
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			return default(int);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3012564", Offset = "0x300E564", VA = "0x3012564")]
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			return default(int);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x301295C", Offset = "0x300E95C", VA = "0x301295C")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3012A2C", Offset = "0x300EA2C", VA = "0x3012A2C", Slot = "62")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x3012A4C", Offset = "0x300EA4C", VA = "0x3012A4C", Slot = "63")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x3012C3C", Offset = "0x300EC3C", VA = "0x3012C3C")]
		[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__196))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x3012CD0", Offset = "0x300ECD0", VA = "0x3012CD0", Slot = "64")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x3012CEC", Offset = "0x300ECEC", VA = "0x3012CEC", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x3012EF4", Offset = "0x300EEF4", VA = "0x3012EF4")]
		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x30139F4", Offset = "0x300F9F4", VA = "0x30139F4")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x3013A64", Offset = "0x300FA64", VA = "0x3013A64")]
		public void ProcessEvent(Event e)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x3013A68", Offset = "0x300FA68", VA = "0x3013A68", Slot = "65")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x30134B8", Offset = "0x300F4B8", VA = "0x30134B8")]
		private string GetSelectedString()
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x3013BF0", Offset = "0x300FBF0", VA = "0x3013BF0")]
		private int FindtNextWordBegin()
		{
			return default(int);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x301389C", Offset = "0x300F89C", VA = "0x301389C")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x3013CAC", Offset = "0x300FCAC", VA = "0x3013CAC")]
		private int FindtPrevWordBegin()
		{
			return default(int);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x3013754", Offset = "0x300F754", VA = "0x3013754")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x3013D4C", Offset = "0x300FD4C", VA = "0x3013D4C")]
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			return default(int);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3013E5C", Offset = "0x300FE5C", VA = "0x3013E5C")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x30141B4", Offset = "0x30101B4", VA = "0x30141B4")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x30139EC", Offset = "0x300F9EC", VA = "0x30139EC")]
		private void MoveDown(bool shift)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x3014468", Offset = "0x3010468", VA = "0x3014468")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x30139E4", Offset = "0x300F9E4", VA = "0x30139E4")]
		private void MoveUp(bool shift)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x30145C8", Offset = "0x30105C8", VA = "0x30145C8")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x301355C", Offset = "0x300F55C", VA = "0x301355C")]
		private void Delete()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3013414", Offset = "0x300F414", VA = "0x3013414")]
		private void ForwardSpace()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3013304", Offset = "0x300F304", VA = "0x3013304")]
		private void Backspace()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x3014740", Offset = "0x3010740", VA = "0x3014740")]
		private void Insert(char c)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x301370C", Offset = "0x300F70C", VA = "0x301370C")]
		private void UpdateTouchKeyboardFromEditChanges()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x3011FA0", Offset = "0x300DFA0", VA = "0x3011FA0")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x300E800", Offset = "0x300A800", VA = "0x300E800")]
		private void SendOnValueChanged()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3014864", Offset = "0x3010864", VA = "0x3014864")]
		protected void SendOnEndEdit()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x301182C", Offset = "0x300D82C", VA = "0x301182C")]
		protected void SendOnSubmit()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x30148E4", Offset = "0x30108E4", VA = "0x30148E4", Slot = "66")]
		protected virtual void Append(string input)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x30149A0", Offset = "0x30109A0", VA = "0x30149A0", Slot = "67")]
		protected virtual void Append(char input)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x300E880", Offset = "0x300A880", VA = "0x300E880")]
		protected void UpdateLabel()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x3015754", Offset = "0x3011754", VA = "0x3015754")]
		private bool IsSelectionVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x30157C0", Offset = "0x30117C0", VA = "0x30157C0")]
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			return default(int);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x30127F8", Offset = "0x300E7F8", VA = "0x30127F8")]
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			return default(int);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3014C10", Offset = "0x3010C10", VA = "0x3014C10")]
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x3015910", Offset = "0x3011910", VA = "0x3015910")]
		public void ForceLabelUpdate()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x300EDE0", Offset = "0x300ADE0", VA = "0x300EDE0")]
		private void MarkGeometryAsDirty()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x3015914", Offset = "0x3011914", VA = "0x3015914", Slot = "68")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x3015D44", Offset = "0x3011D44", VA = "0x3015D44", Slot = "69")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3015D48", Offset = "0x3011D48", VA = "0x3015D48", Slot = "70")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x3015924", Offset = "0x3011924", VA = "0x3015924")]
		private void UpdateGeometry()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x301132C", Offset = "0x300D32C", VA = "0x301132C")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3015D4C", Offset = "0x3011D4C", VA = "0x3015D4C")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3015F80", Offset = "0x3011F80", VA = "0x3015F80")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3016D88", Offset = "0x3012D88", VA = "0x3016D88")]
		private void CreateCursorVerts()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x3016670", Offset = "0x3012670", VA = "0x3016670")]
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x30118AC", Offset = "0x300D8AC", VA = "0x30118AC")]
		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3016EC0", Offset = "0x3012EC0", VA = "0x3016EC0")]
		public void ActivateInputField()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x3011004", Offset = "0x300D004", VA = "0x3011004")]
		private void ActivateInputFieldInternal()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x3016FE0", Offset = "0x3012FE0", VA = "0x3016FE0", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x301701C", Offset = "0x301301C", VA = "0x301701C", Slot = "71")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x3010104", Offset = "0x300C104", VA = "0x3010104")]
		public void DeactivateInputField()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x3017038", Offset = "0x3013038", VA = "0x3017038", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x3017064", Offset = "0x3013064", VA = "0x3017064", Slot = "72")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x300F4C0", Offset = "0x300B4C0", VA = "0x300F4C0")]
		private void EnforceContentType()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x300E120", Offset = "0x300A120", VA = "0x300E120")]
		private void EnforceTextHOverflow()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x300F690", Offset = "0x300B690", VA = "0x300F690")]
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x300F784", Offset = "0x300B784", VA = "0x300F784")]
		private void SetToCustom()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x30170AC", Offset = "0x30130AC", VA = "0x30170AC", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x30170D8", Offset = "0x30130D8", VA = "0x30170D8", Slot = "73")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x30170DC", Offset = "0x30130DC", VA = "0x30170DC", Slot = "74")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x301740C", Offset = "0x301340C", VA = "0x301740C", Slot = "46")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		[Token(Token = "0x200003B")]
		public enum AspectMode
		{
			[Token(Token = "0x400012E")]
			None,
			[Token(Token = "0x400012F")]
			WidthControlsHeight,
			[Token(Token = "0x4000130")]
			HeightControlsWidth,
			[Token(Token = "0x4000131")]
			FitInParent,
			[Token(Token = "0x4000132")]
			EnvelopeParent
		}

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AspectMode m_AspectMode;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_AspectRatio;

		[NonSerialized]
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_Rect;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_DelayedSetDirty;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x31")]
		private bool m_DoesParentExist;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x32")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x17000098")]
		public AspectMode aspectMode
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x3017910", Offset = "0x3013910", VA = "0x3017910")]
			get
			{
				return default(AspectMode);
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x3017918", Offset = "0x3013918", VA = "0x3017918")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public float aspectRatio
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x3017990", Offset = "0x3013990", VA = "0x3017990")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x3017998", Offset = "0x3013998", VA = "0x3017998")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x3017A0C", Offset = "0x3013A0C", VA = "0x3017A0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x3017AA0", Offset = "0x3013AA0", VA = "0x3017AA0")]
		protected AspectRatioFitter()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3017AB0", Offset = "0x3013AB0", VA = "0x3017AB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x3017B48", Offset = "0x3013B48", VA = "0x3017B48", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x3017C8C", Offset = "0x3013C8C", VA = "0x3017C8C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x3018108", Offset = "0x3014108", VA = "0x3018108", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x30181A0", Offset = "0x30141A0", VA = "0x30181A0", Slot = "19")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x30181B4", Offset = "0x30141B4", VA = "0x30181B4", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x30181B8", Offset = "0x30141B8", VA = "0x30181B8")]
		private void UpdateRect()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x3018500", Offset = "0x3014500", VA = "0x3018500")]
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			return default(float);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3018408", Offset = "0x3014408", VA = "0x3018408")]
		private Vector2 GetParentSize()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x30185F4", Offset = "0x30145F4", VA = "0x30185F4", Slot = "20")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x30185F8", Offset = "0x30145F8", VA = "0x30185F8", Slot = "21")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x301798C", Offset = "0x301398C", VA = "0x301798C")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3017B98", Offset = "0x3013B98", VA = "0x3017B98")]
		public bool IsComponentValidOnObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3017C64", Offset = "0x3013C64", VA = "0x3017C64")]
		public bool IsAspectModeValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x30185FC", Offset = "0x30145FC", VA = "0x30185FC")]
		private bool DoesParentExists()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003C")]
	[RequireComponent(typeof(Canvas))]
	[ExecuteAlways]
	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[DisallowMultipleComponent]
	public class CanvasScaler : UIBehaviour
	{
		[Token(Token = "0x200003D")]
		public enum ScaleMode
		{
			[Token(Token = "0x4000143")]
			ConstantPixelSize,
			[Token(Token = "0x4000144")]
			ScaleWithScreenSize,
			[Token(Token = "0x4000145")]
			ConstantPhysicalSize
		}

		[Token(Token = "0x200003E")]
		public enum ScreenMatchMode
		{
			[Token(Token = "0x4000147")]
			MatchWidthOrHeight,
			[Token(Token = "0x4000148")]
			Expand,
			[Token(Token = "0x4000149")]
			Shrink
		}

		[Token(Token = "0x200003F")]
		public enum Unit
		{
			[Token(Token = "0x400014B")]
			Centimeters,
			[Token(Token = "0x400014C")]
			Millimeters,
			[Token(Token = "0x400014D")]
			Inches,
			[Token(Token = "0x400014E")]
			Points,
			[Token(Token = "0x400014F")]
			Picas
		}

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		[SerializeField]
		private ScaleMode m_UiScaleMode;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
		protected float m_ReferencePixelsPerUnit;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		protected float m_ScaleFactor;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		protected Vector2 m_ReferenceResolution;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
		[SerializeField]
		protected ScreenMatchMode m_ScreenMatchMode;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		[Range(0f, 1f)]
		protected float m_MatchWidthOrHeight;

		[Token(Token = "0x4000139")]
		private const float kLogBase = 2f;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Tooltip("The physical unit to specify positions and sizes in.")]
		protected Unit m_PhysicalUnit;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		[SerializeField]
		protected float m_FallbackScreenDPI;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
		protected float m_DefaultSpriteDPI;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		protected float m_DynamicPixelsPerUnit;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x58")]
		private float m_PrevScaleFactor;

		[NonSerialized]
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x5C")]
		private float m_PrevReferencePixelsPerUnit;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool m_PresetInfoIsWorld;

		[Token(Token = "0x1700009B")]
		public ScaleMode uiScaleMode
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x3018604", Offset = "0x3014604", VA = "0x3018604")]
			get
			{
				return default(ScaleMode);
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x301860C", Offset = "0x301460C", VA = "0x301860C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float referencePixelsPerUnit
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x3018614", Offset = "0x3014614", VA = "0x3018614")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x301861C", Offset = "0x301461C", VA = "0x301861C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public float scaleFactor
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x3018624", Offset = "0x3014624", VA = "0x3018624")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x301862C", Offset = "0x301462C", VA = "0x301862C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Vector2 referenceResolution
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x3018644", Offset = "0x3014644", VA = "0x3018644")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x301864C", Offset = "0x301464C", VA = "0x301864C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public ScreenMatchMode screenMatchMode
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x301869C", Offset = "0x301469C", VA = "0x301869C")]
			get
			{
				return default(ScreenMatchMode);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x30186A4", Offset = "0x30146A4", VA = "0x30186A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public float matchWidthOrHeight
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x30186AC", Offset = "0x30146AC", VA = "0x30186AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x30186B4", Offset = "0x30146B4", VA = "0x30186B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public Unit physicalUnit
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x30186BC", Offset = "0x30146BC", VA = "0x30186BC")]
			get
			{
				return default(Unit);
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x30186C4", Offset = "0x30146C4", VA = "0x30186C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float fallbackScreenDPI
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x30186CC", Offset = "0x30146CC", VA = "0x30186CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x30186D4", Offset = "0x30146D4", VA = "0x30186D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public float defaultSpriteDPI
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x30186DC", Offset = "0x30146DC", VA = "0x30186DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x30186E4", Offset = "0x30146E4", VA = "0x30186E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float dynamicPixelsPerUnit
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x30186F8", Offset = "0x30146F8", VA = "0x30186F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x3018700", Offset = "0x3014700", VA = "0x3018700")]
			set
			{
			}
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x3018708", Offset = "0x3014708", VA = "0x3018708")]
		protected CanvasScaler()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x3018750", Offset = "0x3014750", VA = "0x3018750", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3018814", Offset = "0x3014814", VA = "0x3018814")]
		private void Canvas_preWillRenderCanvases()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x3018824", Offset = "0x3014824", VA = "0x3018824", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x301894C", Offset = "0x301494C", VA = "0x301894C", Slot = "17")]
		protected virtual void Handle()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x3018A50", Offset = "0x3014A50", VA = "0x3018A50", Slot = "18")]
		protected virtual void HandleWorldCanvas()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x3018A70", Offset = "0x3014A70", VA = "0x3018A70", Slot = "19")]
		protected virtual void HandleConstantPixelSize()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x3018A90", Offset = "0x3014A90", VA = "0x3018A90", Slot = "20")]
		protected virtual void HandleScaleWithScreenSize()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3018CC8", Offset = "0x3014CC8", VA = "0x3018CC8", Slot = "21")]
		protected virtual void HandleConstantPhysicalSize()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x30188CC", Offset = "0x30148CC", VA = "0x30188CC")]
		protected void SetScaleFactor(float scaleFactor)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x301890C", Offset = "0x301490C", VA = "0x301890C")]
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		[Token(Token = "0x2000041")]
		public enum FitMode
		{
			[Token(Token = "0x4000155")]
			Unconstrained,
			[Token(Token = "0x4000156")]
			MinSize,
			[Token(Token = "0x4000157")]
			PreferredSize
		}

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected FitMode m_HorizontalFit;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected FitMode m_VerticalFit;

		[NonSerialized]
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_Rect;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x30")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x170000A5")]
		public FitMode horizontalFit
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x3018D30", Offset = "0x3014D30", VA = "0x3018D30")]
			get
			{
				return default(FitMode);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x3018D38", Offset = "0x3014D38", VA = "0x3018D38")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public FitMode verticalFit
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x3018E30", Offset = "0x3014E30", VA = "0x3018E30")]
			get
			{
				return default(FitMode);
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x3018E38", Offset = "0x3014E38", VA = "0x3018E38")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x3018EAC", Offset = "0x3014EAC", VA = "0x3018EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x3018F40", Offset = "0x3014F40", VA = "0x3018F40")]
		protected ContentSizeFitter()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x3018F48", Offset = "0x3014F48", VA = "0x3018F48", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x3018F64", Offset = "0x3014F64", VA = "0x3018F64", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x3018FE0", Offset = "0x3014FE0", VA = "0x3018FE0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x3018FE4", Offset = "0x3014FE4", VA = "0x3018FE4")]
		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x30190D0", Offset = "0x30150D0", VA = "0x30190D0", Slot = "19")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x30190F4", Offset = "0x30150F4", VA = "0x30190F4", Slot = "20")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x3018DAC", Offset = "0x3014DAC", VA = "0x3018DAC")]
		protected void SetDirty()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup
	{
		[Token(Token = "0x2000043")]
		public enum Corner
		{
			[Token(Token = "0x400015F")]
			UpperLeft,
			[Token(Token = "0x4000160")]
			UpperRight,
			[Token(Token = "0x4000161")]
			LowerLeft,
			[Token(Token = "0x4000162")]
			LowerRight
		}

		[Token(Token = "0x2000044")]
		public enum Axis
		{
			[Token(Token = "0x4000164")]
			Horizontal,
			[Token(Token = "0x4000165")]
			Vertical
		}

		[Token(Token = "0x2000045")]
		public enum Constraint
		{
			[Token(Token = "0x4000167")]
			Flexible,
			[Token(Token = "0x4000168")]
			FixedColumnCount,
			[Token(Token = "0x4000169")]
			FixedRowCount
		}

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Corner m_StartCorner;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected Axis m_StartAxis;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Vector2 m_CellSize;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Vector2 m_Spacing;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Constraint m_Constraint;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected int m_ConstraintCount;

		[Token(Token = "0x170000A8")]
		public Corner startCorner
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x30190FC", Offset = "0x30150FC", VA = "0x30190FC")]
			get
			{
				return default(Corner);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x3019104", Offset = "0x3015104", VA = "0x3019104")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public Axis startAxis
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x3019160", Offset = "0x3015160", VA = "0x3019160")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x3019168", Offset = "0x3015168", VA = "0x3019168")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public Vector2 cellSize
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x30191C4", Offset = "0x30151C4", VA = "0x30191C4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x30191CC", Offset = "0x30151CC", VA = "0x30191CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public Vector2 spacing
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x3019230", Offset = "0x3015230", VA = "0x3019230")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x3019238", Offset = "0x3015238", VA = "0x3019238")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public Constraint constraint
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x301929C", Offset = "0x301529C", VA = "0x301929C")]
			get
			{
				return default(Constraint);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x30192A4", Offset = "0x30152A4", VA = "0x30192A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public int constraintCount
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x3019300", Offset = "0x3015300", VA = "0x3019300")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x3019308", Offset = "0x3015308", VA = "0x3019308")]
			set
			{
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3019368", Offset = "0x3015368", VA = "0x3019368")]
		protected GridLayoutGroup()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x30194EC", Offset = "0x30154EC", VA = "0x30194EC", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x3019AE8", Offset = "0x3015AE8", VA = "0x3019AE8", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x3019D90", Offset = "0x3015D90", VA = "0x3019D90", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x301A4EC", Offset = "0x30164EC", VA = "0x301A4EC", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x3019D98", Offset = "0x3015D98", VA = "0x3019D98")]
		private void SetCellsAlongAxis(int axis)
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x301A6F4", Offset = "0x30166F4", VA = "0x301A6F4")]
		protected HorizontalLayoutGroup()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x301A70C", Offset = "0x301670C", VA = "0x301A70C", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x301A9B8", Offset = "0x30169B8", VA = "0x301A9B8", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x301A9C4", Offset = "0x30169C4", VA = "0x301A9C4", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x301AFFC", Offset = "0x3016FFC", VA = "0x301AFFC", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected float m_Spacing;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected bool m_ChildForceExpandWidth;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x65")]
		[SerializeField]
		protected bool m_ChildForceExpandHeight;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x66")]
		[SerializeField]
		protected bool m_ChildControlWidth;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x67")]
		[SerializeField]
		protected bool m_ChildControlHeight;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected bool m_ChildScaleWidth;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		protected bool m_ChildScaleHeight;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		protected bool m_ReverseArrangement;

		[Token(Token = "0x170000AE")]
		public float spacing
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x301B008", Offset = "0x3017008", VA = "0x301B008")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x301B010", Offset = "0x3017010", VA = "0x301B010")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool childForceExpandWidth
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x301B06C", Offset = "0x301706C", VA = "0x301B06C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x301B074", Offset = "0x3017074", VA = "0x301B074")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool childForceExpandHeight
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x301B0D0", Offset = "0x30170D0", VA = "0x301B0D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x301B0D8", Offset = "0x30170D8", VA = "0x301B0D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool childControlWidth
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x301B134", Offset = "0x3017134", VA = "0x301B134")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x301B13C", Offset = "0x301713C", VA = "0x301B13C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public bool childControlHeight
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x301B198", Offset = "0x3017198", VA = "0x301B198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x301B1A0", Offset = "0x30171A0", VA = "0x301B1A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool childScaleWidth
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x301B1FC", Offset = "0x30171FC", VA = "0x301B1FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x301B204", Offset = "0x3017204", VA = "0x301B204")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool childScaleHeight
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x301B260", Offset = "0x3017260", VA = "0x301B260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x301B268", Offset = "0x3017268", VA = "0x301B268")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool reverseArrangement
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x301B2C4", Offset = "0x30172C4", VA = "0x301B2C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x301B2CC", Offset = "0x30172CC", VA = "0x301B2CC")]
			set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x301A72C", Offset = "0x301672C", VA = "0x301A72C")]
		protected void CalcAlongAxis(int axis, bool isVertical)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x301A9D0", Offset = "0x30169D0", VA = "0x301A9D0")]
		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x301B328", Offset = "0x3017328", VA = "0x301B328")]
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x301A700", Offset = "0x3016700", VA = "0x301A700")]
		protected HorizontalOrVerticalLayoutGroup()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public interface ILayoutElement
	{
		[Token(Token = "0x170000B6")]
		float minWidth
		{
			[Token(Token = "0x60002B2")]
			get;
		}

		[Token(Token = "0x170000B7")]
		float preferredWidth
		{
			[Token(Token = "0x60002B3")]
			get;
		}

		[Token(Token = "0x170000B8")]
		float flexibleWidth
		{
			[Token(Token = "0x60002B4")]
			get;
		}

		[Token(Token = "0x170000B9")]
		float minHeight
		{
			[Token(Token = "0x60002B5")]
			get;
		}

		[Token(Token = "0x170000BA")]
		float preferredHeight
		{
			[Token(Token = "0x60002B6")]
			get;
		}

		[Token(Token = "0x170000BB")]
		float flexibleHeight
		{
			[Token(Token = "0x60002B7")]
			get;
		}

		[Token(Token = "0x170000BC")]
		int layoutPriority
		{
			[Token(Token = "0x60002B8")]
			get;
		}

		[Token(Token = "0x60002B0")]
		void CalculateLayoutInputHorizontal();

		[Token(Token = "0x60002B1")]
		void CalculateLayoutInputVertical();
	}
	[Token(Token = "0x2000049")]
	public interface ILayoutController
	{
		[Token(Token = "0x60002B9")]
		void SetLayoutHorizontal();

		[Token(Token = "0x60002BA")]
		void SetLayoutVertical();
	}
	[Token(Token = "0x200004A")]
	public interface ILayoutGroup : ILayoutController
	{
	}
	[Token(Token = "0x200004B")]
	public interface ILayoutSelfController : ILayoutController
	{
	}
	[Token(Token = "0x200004C")]
	public interface ILayoutIgnorer
	{
		[Token(Token = "0x170000BD")]
		bool ignoreLayout
		{
			[Token(Token = "0x60002BB")]
			get;
		}
	}
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Layout/Layout Element", 140)]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_IgnoreLayout;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_MinWidth;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MinHeight;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_PreferredWidth;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_PreferredHeight;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_FlexibleWidth;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FlexibleHeight;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_LayoutPriority;

		[Token(Token = "0x170000BE")]
		public virtual bool ignoreLayout
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x301BA24", Offset = "0x3017A24", VA = "0x301BA24", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x301BA2C", Offset = "0x3017A2C", VA = "0x301BA2C", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public virtual float minWidth
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x301BB60", Offset = "0x3017B60", VA = "0x301BB60", Slot = "31")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x301BB68", Offset = "0x3017B68", VA = "0x301BB68", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public virtual float minHeight
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x301BBDC", Offset = "0x3017BDC", VA = "0x301BBDC", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x301BBE4", Offset = "0x3017BE4", VA = "0x301BBE4", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x301BC58", Offset = "0x3017C58", VA = "0x301BC58", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x301BC60", Offset = "0x3017C60", VA = "0x301BC60", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x301BCD4", Offset = "0x3017CD4", VA = "0x301BCD4", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x301BCDC", Offset = "0x3017CDC", VA = "0x301BCDC", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x301BD50", Offset = "0x3017D50", VA = "0x301BD50", Slot = "39")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x301BD58", Offset = "0x3017D58", VA = "0x301BD58", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x301BDCC", Offset = "0x3017DCC", VA = "0x301BDCC", Slot = "41")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x301BDD4", Offset = "0x3017DD4", VA = "0x301BDD4", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x301BE48", Offset = "0x3017E48", VA = "0x301BE48", Slot = "43")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x301BE50", Offset = "0x3017E50", VA = "0x301BE50", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x301BB58", Offset = "0x3017B58", VA = "0x301BB58", Slot = "29")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x301BB5C", Offset = "0x3017B5C", VA = "0x301BB5C", Slot = "30")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x301BEC4", Offset = "0x3017EC4", VA = "0x301BEC4")]
		protected LayoutElement()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x301BEE4", Offset = "0x3017EE4", VA = "0x301BEE4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x301BF00", Offset = "0x3017F00", VA = "0x301BF00", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x301BF04", Offset = "0x3017F04", VA = "0x301BF04", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x301BF20", Offset = "0x3017F20", VA = "0x301BF20", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x301BF24", Offset = "0x3017F24", VA = "0x301BF24", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x301BAA0", Offset = "0x3017AA0", VA = "0x301BAA0")]
		protected void SetDirty()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class <DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform rectTransform;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0x301C4CC", Offset = "0x30184CC", VA = "0x301C4CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x301C50C", Offset = "0x301850C", VA = "0x301C50C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x301C414", Offset = "0x3018414", VA = "0x301C414")]
			[DebuggerHidden]
			public <DelayedSetDirty>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x301C43C", Offset = "0x301843C", VA = "0x301C43C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x301C440", Offset = "0x3018440", VA = "0x301C440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x301C4D4", Offset = "0x30184D4", VA = "0x301C4D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected RectOffset m_Padding;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		[NonSerialized]
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform m_Rect;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x38")]
		protected DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 m_TotalMinSize;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_TotalPreferredSize;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 m_TotalFlexibleSize;

		[NonSerialized]
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x58")]
		private List<RectTransform> m_RectChildren;

		[Token(Token = "0x170000C6")]
		public RectOffset padding
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x301BF28", Offset = "0x3017F28", VA = "0x301BF28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x301BF30", Offset = "0x3017F30", VA = "0x301BF30")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public TextAnchor childAlignment
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x301BF8C", Offset = "0x3017F8C", VA = "0x301BF8C")]
			get
			{
				return default(TextAnchor);
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x301BF94", Offset = "0x3017F94", VA = "0x301BF94")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x3019CFC", Offset = "0x3015CFC", VA = "0x3019CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		protected List<RectTransform> rectChildren
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x301BFF0", Offset = "0x3017FF0", VA = "0x301BFF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public virtual float minWidth
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x301BFF8", Offset = "0x3017FF8", VA = "0x301BFF8", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CB")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x301C000", Offset = "0x3018000", VA = "0x301C000", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CC")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x301C008", Offset = "0x3018008", VA = "0x301C008", Slot = "32")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CD")]
		public virtual float minHeight
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x301C010", Offset = "0x3018010", VA = "0x301C010", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CE")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x301C018", Offset = "0x3018018", VA = "0x301C018", Slot = "34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CF")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x301C020", Offset = "0x3018020", VA = "0x301C020", Slot = "35")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D0")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x301C028", Offset = "0x3018028", VA = "0x301C028", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D1")]
		private bool isRootLayoutGroup
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x301C248", Offset = "0x3018248", VA = "0x301C248")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x30196AC", Offset = "0x30156AC", VA = "0x30196AC", Slot = "28")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60002DC")]
		public abstract void CalculateLayoutInputVertical();

		[Token(Token = "0x60002E4")]
		public abstract void SetLayoutHorizontal();

		[Token(Token = "0x60002E5")]
		public abstract void SetLayoutVertical();

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x30193D0", Offset = "0x30153D0", VA = "0x30193D0")]
		protected LayoutGroup()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x301C030", Offset = "0x3018030", VA = "0x301C030", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x301C120", Offset = "0x3018120", VA = "0x301C120", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x301C19C", Offset = "0x301819C", VA = "0x301C19C", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x301B9AC", Offset = "0x30179AC", VA = "0x301B9AC")]
		protected float GetTotalMinSize(int axis)
		{
			return default(float);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x301B8D4", Offset = "0x30178D4", VA = "0x301B8D4")]
		protected float GetTotalPreferredSize(int axis)
		{
			return default(float);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x301B940", Offset = "0x3017940", VA = "0x301B940")]
		protected float GetTotalFlexibleSize(int axis)
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x301A4F4", Offset = "0x30164F4", VA = "0x301A4F4")]
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			return default(float);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x301B444", Offset = "0x3017444", VA = "0x301B444")]
		protected float GetAlignmentOnAxis(int axis)
		{
			return default(float);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x3019A64", Offset = "0x3015A64", VA = "0x3019A64")]
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x301C1A0", Offset = "0x30181A0", VA = "0x301C1A0")]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x301B6B4", Offset = "0x30176B4", VA = "0x301B6B4")]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x301A644", Offset = "0x3016644", VA = "0x301A644")]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x301B47C", Offset = "0x301747C", VA = "0x301B47C")]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x301C380", Offset = "0x3018380", VA = "0x301C380", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x301C3B0", Offset = "0x30183B0", VA = "0x301C3B0", Slot = "39")]
		protected virtual void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x60002F7")]
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x301C04C", Offset = "0x301804C", VA = "0x301C04C")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x301C3B4", Offset = "0x30183B4", VA = "0x301C3B4")]
		[IteratorStateMachine(typeof(<DelayedSetDirty>d__56))]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	public class LayoutRebuilder : ICanvasElement
	{
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform m_ToRebuild;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x18")]
		private int m_CachedHashFromTransform;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<LayoutRebuilder> s_Rebuilders;

		[Token(Token = "0x170000D4")]
		public Transform transform
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x301C784", Offset = "0x3018784", VA = "0x301C784", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x301C514", Offset = "0x3018514", VA = "0x301C514")]
		private void Initialize(RectTransform controller)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x301C548", Offset = "0x3018548", VA = "0x301C548")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x301C554", Offset = "0x3018554", VA = "0x301C554")]
		static LayoutRebuilder()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x301C730", Offset = "0x3018730", VA = "0x301C730")]
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x301C78C", Offset = "0x301878C", VA = "0x301C78C", Slot = "8")]
		public bool IsDestroyed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x301C7EC", Offset = "0x30187EC", VA = "0x301C7EC")]
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x301C8E4", Offset = "0x30188E4", VA = "0x301C8E4")]
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x301C9C0", Offset = "0x30189C0", VA = "0x301C9C0", Slot = "4")]
		public void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x301CF3C", Offset = "0x3018F3C", VA = "0x301CF3C")]
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x301CC6C", Offset = "0x3018C6C", VA = "0x301CC6C")]
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x3017D08", Offset = "0x3013D08", VA = "0x3017D08")]
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x301D304", Offset = "0x3019304", VA = "0x301D304")]
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x301D4F8", Offset = "0x30194F8", VA = "0x301D4F8")]
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x301D654", Offset = "0x3019654", VA = "0x301D654", Slot = "6")]
		public void LayoutComplete()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x301D6D4", Offset = "0x30196D4", VA = "0x301D6D4", Slot = "7")]
		public void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x301D6D8", Offset = "0x30196D8", VA = "0x301D6D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x301D6E0", Offset = "0x30196E0", VA = "0x301D6E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x301D730", Offset = "0x3019730", VA = "0x301D730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x301D79C", Offset = "0x301979C", VA = "0x301D79C")]
		public LayoutRebuilder()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public static class LayoutUtility
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x30190B8", Offset = "0x30150B8", VA = "0x30190B8")]
		public static float GetMinSize(RectTransform rect, int axis)
		{
			return default(float);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x30190C4", Offset = "0x30150C4", VA = "0x30190C4")]
		public static float GetPreferredSize(RectTransform rect, int axis)
		{
			return default(float);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x301BA18", Offset = "0x3017A18", VA = "0x301BA18")]
		public static float GetFlexibleSize(RectTransform rect, int axis)
		{
			return default(float);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x301DCDC", Offset = "0x3019CDC", VA = "0x301DCDC")]
		public static float GetMinWidth(RectTransform rect)
		{
			return default(float);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x301DF50", Offset = "0x3019F50", VA = "0x301DF50")]
		public static float GetPreferredWidth(RectTransform rect)
		{
			return default(float);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x301E1C4", Offset = "0x301A1C4", VA = "0x301E1C4")]
		public static float GetFlexibleWidth(RectTransform rect)
		{
			return default(float);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x301DBF8", Offset = "0x3019BF8", VA = "0x301DBF8")]
		public static float GetMinHeight(RectTransform rect)
		{
			return default(float);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x301DDC0", Offset = "0x3019DC0", VA = "0x301DDC0")]
		public static float GetPreferredHeight(RectTransform rect)
		{
			return default(float);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x301E0E0", Offset = "0x301A0E0", VA = "0x301E0E0")]
		public static float GetFlexibleHeight(RectTransform rect)
		{
			return default(float);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x301E2A8", Offset = "0x301A2A8", VA = "0x301E2A8")]
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x301E2BC", Offset = "0x301A2BC", VA = "0x301E2BC")]
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000054")]
	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x301EB24", Offset = "0x301AB24", VA = "0x301EB24")]
		protected VerticalLayoutGroup()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x301EB30", Offset = "0x301AB30", VA = "0x301EB30", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x301EB50", Offset = "0x301AB50", VA = "0x301EB50", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x301EB5C", Offset = "0x301AB5C", VA = "0x301EB5C", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x301EB68", Offset = "0x301AB68", VA = "0x301EB68", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AddComponentMenu("UI/Mask", 13)]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		[NonSerialized]
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_RectTransform;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_ShowMaskGraphic;

		[NonSerialized]
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x30")]
		private Graphic m_Graphic;

		[NonSerialized]
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x38")]
		private Material m_MaskMaterial;

		[NonSerialized]
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x40")]
		private Material m_UnmaskMaterial;

		[Token(Token = "0x170000D5")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x301EB74", Offset = "0x301AB74", VA = "0x301EB74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public bool showMaskGraphic
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x301EBCC", Offset = "0x301ABCC", VA = "0x301EBCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x301EBD4", Offset = "0x301ABD4", VA = "0x301EBD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public Graphic graphic
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x301EC84", Offset = "0x301AC84", VA = "0x301EC84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x301ECDC", Offset = "0x301ACDC", VA = "0x301ECDC")]
		protected Mask()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x301ECEC", Offset = "0x301ACEC", VA = "0x301ECEC", Slot = "19")]
		public virtual bool MaskEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x301ED7C", Offset = "0x301AD7C", VA = "0x301ED7C", Slot = "20")]
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x301ED80", Offset = "0x301AD80", VA = "0x301ED80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x301F14C", Offset = "0x301B14C", VA = "0x301F14C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x301F310", Offset = "0x301B310", VA = "0x301F310", Slot = "21")]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x301F3BC", Offset = "0x301B3BC", VA = "0x301F3BC", Slot = "22")]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		[Serializable]
		[Token(Token = "0x2000057")]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x302081C", Offset = "0x301C81C", VA = "0x302081C")]
			public CullStateChangedEvent()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xA1")]
		protected bool m_ShouldRecalculateStencil;

		[NonSerialized]
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xA8")]
		protected Material m_MaskMaterial;

		[NonSerialized]
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xB0")]
		private RectMask2D m_ParentMask;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool m_Maskable;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_IsMaskingGraphic;

		[NonSerialized]
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xBA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		protected bool m_IncludeForMasking;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CullStateChangedEvent m_OnCullStateChanged;

		[NonSerialized]
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xC8")]
		[Obsolete("Not used anymore", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected bool m_ShouldRecalculate;

		[NonSerialized]
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xCC")]
		protected int m_StencilValue;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Vector3[] m_Corners;

		[Token(Token = "0x170000D8")]
		public CullStateChangedEvent onCullStateChanged
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x301FA88", Offset = "0x301BA88", VA = "0x301FA88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x301FA90", Offset = "0x301BA90", VA = "0x301FA90")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool maskable
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x301FA98", Offset = "0x301BA98", VA = "0x301FA98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x301FAA0", Offset = "0x301BAA0", VA = "0x301FAA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public bool isMaskingGraphic
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x301FAD0", Offset = "0x301BAD0", VA = "0x301FAD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x301EEDC", Offset = "0x301AEDC", VA = "0x301EEDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x301FC9C", Offset = "0x301BC9C", VA = "0x301FC9C")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x301FAD8", Offset = "0x301BAD8", VA = "0x301FAD8", Slot = "58")]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x301FBD8", Offset = "0x301BBD8", VA = "0x301FBD8", Slot = "59")]
		public virtual void Cull(Rect clipRect, bool validRect)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x301FE40", Offset = "0x301BE40", VA = "0x301FE40")]
		private void UpdateCull(bool cull)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x301FF20", Offset = "0x301BF20", VA = "0x301FF20", Slot = "60")]
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x301FF90", Offset = "0x301BF90", VA = "0x301FF90", Slot = "61")]
		public virtual void SetClipSoftness(Vector2 clipSoftness)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x301FFC8", Offset = "0x301BFC8", VA = "0x301FFC8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x302016C", Offset = "0x301C16C", VA = "0x302016C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3020218", Offset = "0x301C218", VA = "0x3020218", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x3020268", Offset = "0x301C268", VA = "0x3020268", Slot = "62")]
		[Obsolete("Not used anymore.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void ParentMaskStateChanged()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x302026C", Offset = "0x301C26C", VA = "0x302026C", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x3020018", Offset = "0x301C018", VA = "0x3020018")]
		private void UpdateClipParent()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x30206DC", Offset = "0x301C6DC", VA = "0x30206DC", Slot = "63")]
		public virtual void RecalculateClipping()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x30206E0", Offset = "0x301C6E0", VA = "0x30206E0", Slot = "64")]
		public virtual void RecalculateMasking()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x302075C", Offset = "0x301C75C", VA = "0x302075C")]
		protected MaskableGraphic()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x3020864", Offset = "0x301C864", VA = "0x3020864", Slot = "50")]
		private GameObject UnityEngine.UI.IClippable.get_gameObject()
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class MaskUtilities
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x302086C", Offset = "0x301C86C", VA = "0x302086C")]
		public static void Notify2DMaskStateChanged(Component mask)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x301EEF4", Offset = "0x301AEF4", VA = "0x301EEF4")]
		public static void NotifyStencilStateChanged(Component mask)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x301F660", Offset = "0x301B660", VA = "0x301F660")]
		public static Transform FindRootSortOverrideCanvas(Transform start)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x301F800", Offset = "0x301B800", VA = "0x301F800")]
		public static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			return default(int);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x3020AC8", Offset = "0x301CAC8", VA = "0x3020AC8")]
		public static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x30202BC", Offset = "0x301C2BC", VA = "0x30202BC")]
		public static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x3020C20", Offset = "0x301CC20", VA = "0x3020C20")]
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x3020F88", Offset = "0x301CF88", VA = "0x3020F88")]
		public MaskUtilities()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public interface IMaterialModifier
	{
		[Token(Token = "0x6000361")]
		Material GetModifiedMaterial(Material baseMaterial);
	}
	[Token(Token = "0x200005A")]
	internal static class Misc
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x3020FD0", Offset = "0x301CFD0", VA = "0x3020FD0")]
		public static void Destroy(Object obj)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x30210F4", Offset = "0x301D0F4", VA = "0x30210F4")]
		public static void DestroyImmediate(Object obj)
		{
		}
	}
	[Token(Token = "0x200005B")]
	internal static class MultipleDisplayUtilities
	{
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x30211CC", Offset = "0x301D1CC", VA = "0x30211CC")]
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x3021588", Offset = "0x301D588", VA = "0x3021588")]
		internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x3021238", Offset = "0x301D238", VA = "0x3021238")]
		public static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public struct Navigation : IEquatable<Navigation>
	{
		[Token(Token = "0x200005D")]
		[Flags]
		public enum Mode
		{
			[Token(Token = "0x40001AD")]
			None = 0,
			[Token(Token = "0x40001AE")]
			Horizontal = 1,
			[Token(Token = "0x40001AF")]
			Vertical = 2,
			[Token(Token = "0x40001B0")]
			Automatic = 3,
			[Token(Token = "0x40001B1")]
			Explicit = 4
		}

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Mode m_Mode;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
		[SerializeField]
		private bool m_WrapAround;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Selectable m_SelectOnUp;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Selectable m_SelectOnDown;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Selectable m_SelectOnLeft;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Selectable m_SelectOnRight;

		[Token(Token = "0x170000DC")]
		public Mode mode
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x3021650", Offset = "0x301D650", VA = "0x3021650")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x3021658", Offset = "0x301D658", VA = "0x3021658")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public bool wrapAround
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x3021660", Offset = "0x301D660", VA = "0x3021660")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x3021668", Offset = "0x301D668", VA = "0x3021668")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public Selectable selectOnUp
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x3021670", Offset = "0x301D670", VA = "0x3021670")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x3021678", Offset = "0x301D678", VA = "0x3021678")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public Selectable selectOnDown
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x3021680", Offset = "0x301D680", VA = "0x3021680")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x3021688", Offset = "0x301D688", VA = "0x3021688")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public Selectable selectOnLeft
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x3021690", Offset = "0x301D690", VA = "0x3021690")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x3021698", Offset = "0x301D698", VA = "0x3021698")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public Selectable selectOnRight
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x30216A0", Offset = "0x301D6A0", VA = "0x30216A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x30216A8", Offset = "0x301D6A8", VA = "0x30216A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public static Navigation defaultNavigation
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x30216B0", Offset = "0x301D6B0", VA = "0x30216B0")]
			get
			{
				return default(Navigation);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x30216CC", Offset = "0x301D6CC", VA = "0x30216CC", Slot = "4")]
		public bool Equals(Navigation other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005E")]
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Raw Image", 12)]
	public class RawImage : MaskableGraphic
	{
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[FormerlySerializedAs("m_Tex")]
		private Texture m_Texture;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Rect m_UVRect;

		[Token(Token = "0x170000E3")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x302180C", Offset = "0x301D80C", VA = "0x302180C", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public Texture texture
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x3021964", Offset = "0x301D964", VA = "0x3021964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x302196C", Offset = "0x301D96C", VA = "0x302196C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public Rect uvRect
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x3021A18", Offset = "0x301DA18", VA = "0x3021A18")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x3021A24", Offset = "0x301DA24", VA = "0x3021A24")]
			set
			{
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x30217E4", Offset = "0x301D7E4", VA = "0x30217E4")]
		protected RawImage()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x3021A70", Offset = "0x301DA70", VA = "0x3021A70", Slot = "45")]
		public override void SetNativeSize()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x3021D20", Offset = "0x301DD20", VA = "0x3021D20", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x30223A4", Offset = "0x301E3A4", VA = "0x30223A4", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		[NonSerialized]
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x20")]
		private readonly RectangularVertexClipper m_VertexClipper;

		[NonSerialized]
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_RectTransform;

		[NonSerialized]
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<MaskableGraphic> m_MaskableTargets;

		[NonSerialized]
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<IClippable> m_ClipTargets;

		[NonSerialized]
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x40")]
		private bool m_ShouldRecalculateClipRects;

		[NonSerialized]
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x48")]
		private List<RectMask2D> m_Clippers;

		[NonSerialized]
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x50")]
		private Rect m_LastClipRectCanvasSpace;

		[NonSerialized]
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_ForceClip;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Vector4 m_Padding;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Vector2Int m_Softness;

		[NonSerialized]
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x80")]
		private Canvas m_Canvas;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x88")]
		private Vector3[] m_Corners;

		[Token(Token = "0x170000E6")]
		public Vector4 padding
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x30223E0", Offset = "0x301E3E0", VA = "0x30223E0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x30223EC", Offset = "0x301E3EC", VA = "0x30223EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public Vector2Int softness
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x30223FC", Offset = "0x301E3FC", VA = "0x30223FC")]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x3022404", Offset = "0x301E404", VA = "0x3022404")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		internal Canvas Canvas
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x3022424", Offset = "0x301E424", VA = "0x3022424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public Rect canvasRect
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x3022588", Offset = "0x301E588", VA = "0x3022588")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x170000EA")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x30225CC", Offset = "0x301E5CC", VA = "0x30225CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x302298C", Offset = "0x301E98C", VA = "0x302298C")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x3022624", Offset = "0x301E624", VA = "0x3022624")]
		protected RectMask2D()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x302278C", Offset = "0x301E78C", VA = "0x302278C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x30227C0", Offset = "0x301E7C0", VA = "0x30227C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x3022890", Offset = "0x301E890", VA = "0x3022890", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x30228B0", Offset = "0x301E8B0", VA = "0x30228B0", Slot = "19")]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x3022A88", Offset = "0x301EA88", VA = "0x3022A88", Slot = "20")]
		public virtual void PerformClipping()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x3023224", Offset = "0x301F224", VA = "0x3023224", Slot = "21")]
		public virtual void UpdateClipSoftness()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x3023508", Offset = "0x301F508", VA = "0x3023508")]
		public void AddClippable(IClippable clippable)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x302361C", Offset = "0x301F61C", VA = "0x302361C")]
		public void RemoveClippable(IClippable clippable)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x30237BC", Offset = "0x301F7BC", VA = "0x30237BC", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x30237E0", Offset = "0x301F7E0", VA = "0x30237E0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AddComponentMenu("UI/Scrollbar", 36)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Token(Token = "0x2000061")]
		public enum Direction
		{
			[Token(Token = "0x40001CD")]
			LeftToRight,
			[Token(Token = "0x40001CE")]
			RightToLeft,
			[Token(Token = "0x40001CF")]
			BottomToTop,
			[Token(Token = "0x40001D0")]
			TopToBottom
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		public class ScrollEvent : UnityEvent<float>
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x3023C6C", Offset = "0x301FC6C", VA = "0x3023C6C")]
			public ScrollEvent()
			{
			}
		}

		[Token(Token = "0x2000063")]
		private enum Axis
		{
			[Token(Token = "0x40001D2")]
			Horizontal,
			[Token(Token = "0x40001D3")]
			Vertical
		}

		[Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class <ClickRepeat>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x20")]
			public Scrollbar <>4__this;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 screenPosition;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x30")]
			public Camera camera;

			[Token(Token = "0x170000F5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C1")]
				[Address(RVA = "0x302581C", Offset = "0x302181C", VA = "0x302581C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C3")]
				[Address(RVA = "0x302585C", Offset = "0x302185C", VA = "0x302585C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x3024CF0", Offset = "0x3020CF0", VA = "0x3024CF0")]
			[DebuggerHidden]
			public <ClickRepeat>d__58(int <>1__state)
			{
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x30255C0", Offset = "0x30215C0", VA = "0x30255C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x30255C4", Offset = "0x30215C4", VA = "0x30255C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x3025824", Offset = "0x3021824", VA = "0x3025824", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform m_HandleRect;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Direction m_Direction;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x10C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x110")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x114")]
		[Range(0f, 11f)]
		[SerializeField]
		private int m_NumberOfSteps;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x118")]
		[Space(6f)]
		[SerializeField]
		private ScrollEvent m_OnValueChanged;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x120")]
		private RectTransform m_ContainerRect;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x128")]
		private Vector2 m_Offset;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x130")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine m_PointerDownRepeat;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x140")]
		private bool isPointerDownAndNotDragging;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x141")]
		private bool m_DelayedUpdateVisuals;

		[Token(Token = "0x170000EC")]
		public RectTransform handleRect
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x3023804", Offset = "0x301F804", VA = "0x3023804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x302380C", Offset = "0x301F80C", VA = "0x302380C")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public Direction direction
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x3023B28", Offset = "0x301FB28", VA = "0x3023B28")]
			get
			{
				return default(Direction);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x3023B30", Offset = "0x301FB30", VA = "0x3023B30")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public float value
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x3023DC4", Offset = "0x301FDC4", VA = "0x3023DC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x3023E6C", Offset = "0x301FE6C", VA = "0x3023E6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float size
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x3023F40", Offset = "0x301FF40", VA = "0x3023F40")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x3023F48", Offset = "0x301FF48", VA = "0x3023F48")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public int numberOfSteps
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x3023FD0", Offset = "0x301FFD0", VA = "0x3023FD0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x3023FD8", Offset = "0x301FFD8", VA = "0x3023FD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public ScrollEvent onValueChanged
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x302405C", Offset = "0x302005C", VA = "0x302405C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x3024064", Offset = "0x3020064", VA = "0x3024064")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		private float stepSize
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x302406C", Offset = "0x302006C", VA = "0x302406C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F3")]
		private Axis axis
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x3024520", Offset = "0x3020520", VA = "0x3024520")]
			get
			{
				return default(Axis);
			}
		}

		[Token(Token = "0x170000F4")]
		private bool reverseValue
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x3024530", Offset = "0x3020530", VA = "0x3024530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x3023BA4", Offset = "0x301FBA4", VA = "0x3023BA4")]
		protected Scrollbar()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x3023F38", Offset = "0x301FF38", VA = "0x3023F38", Slot = "47")]
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x3024098", Offset = "0x3020098", VA = "0x3024098", Slot = "48")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x302409C", Offset = "0x302009C", VA = "0x302409C", Slot = "49")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x30240A0", Offset = "0x30200A0", VA = "0x30240A0", Slot = "50")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x30240A4", Offset = "0x30200A4", VA = "0x30240A4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x302438C", Offset = "0x302038C", VA = "0x302438C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x30244D4", Offset = "0x30204D4", VA = "0x30244D4", Slot = "51")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x3023888", Offset = "0x301F888", VA = "0x3023888")]
		private void UpdateCachedReferences()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x3023E74", Offset = "0x301FE74", VA = "0x3023E74")]
		private void Set(float input, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x30244E8", Offset = "0x30204E8", VA = "0x30244E8", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x3023970", Offset = "0x301F970", VA = "0x3023970")]
		private void UpdateVisuals()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x3024544", Offset = "0x3020544", VA = "0x3024544")]
		private void UpdateDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x3024764", Offset = "0x3020764", VA = "0x3024764")]
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x30247D4", Offset = "0x30207D4", VA = "0x30247D4")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x3024838", Offset = "0x3020838", VA = "0x3024838", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x30249EC", Offset = "0x30209EC", VA = "0x30249EC", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x3024A7C", Offset = "0x3020A7C", VA = "0x3024A7C", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x3024CB0", Offset = "0x3020CB0", VA = "0x3024CB0")]
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x3024C2C", Offset = "0x3020C2C", VA = "0x3024C2C")]
		[IteratorStateMachine(typeof(<ClickRepeat>d__58))]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x3024D18", Offset = "0x3020D18", VA = "0x3024D18", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x3024D50", Offset = "0x3020D50", VA = "0x3024D50", Slot = "31")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x302502C", Offset = "0x302102C", VA = "0x302502C", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x3025128", Offset = "0x3021128", VA = "0x3025128", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x3025224", Offset = "0x3021224", VA = "0x3025224", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x3025320", Offset = "0x3021320", VA = "0x3025320", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x302541C", Offset = "0x302141C", VA = "0x302541C", Slot = "54")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x3025430", Offset = "0x3021430", VA = "0x3025430")]
		public void SetDirection(Direction direction, bool includeRectLayouts)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x30255B8", Offset = "0x30215B8", VA = "0x30255B8", Slot = "43")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	[SelectionBase]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Scroll Rect", 37)]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[Token(Token = "0x2000066")]
		public enum MovementType
		{
			[Token(Token = "0x40001FF")]
			Unrestricted,
			[Token(Token = "0x4000200")]
			Elastic,
			[Token(Token = "0x4000201")]
			Clamped
		}

		[Token(Token = "0x2000067")]
		public enum ScrollbarVisibility
		{
			[Token(Token = "0x4000203")]
			Permanent,
			[Token(Token = "0x4000204")]
			AutoHide,
			[Token(Token = "0x4000205")]
			AutoHideAndExpandViewport
		}

		[Serializable]
		[Token(Token = "0x2000068")]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x3026018", Offset = "0x3022018", VA = "0x3026018")]
			public ScrollRectEvent()
			{
			}
		}

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform m_Content;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_Horizontal;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_Vertical;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private MovementType m_MovementType;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_Elasticity;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_Inertia;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_DecelerationRate;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_ScrollSensitivity;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform m_Viewport;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollbarVisibility m_HorizontalScrollbarVisibility;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ScrollbarVisibility m_VerticalScrollbarVisibility;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ScrollRectEvent m_OnValueChanged;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_PointerStartLocalCursor;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x78")]
		protected Vector2 m_ContentStartPosition;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform m_ViewRect;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x88")]
		protected Bounds m_ContentBounds;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0xA0")]
		private Bounds m_ViewBounds;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_Velocity;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_Dragging;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_Scrolling;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0xC4")]
		private Vector2 m_PrevPosition;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xCC")]
		private Bounds m_PrevContentBounds;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xE4")]
		private Bounds m_PrevViewBounds;

		[NonSerialized]
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0xFC")]
		private bool m_HasRebuiltLayout;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0xFD")]
		private bool m_HSliderExpand;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xFE")]
		private bool m_VSliderExpand;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x100")]
		private float m_HSliderHeight;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x104")]
		private float m_VSliderWidth;

		[NonSerialized]
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x108")]
		private RectTransform m_Rect;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x110")]
		private RectTransform m_HorizontalScrollbarRect;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x118")]
		private RectTransform m_VerticalScrollbarRect;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x120")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x128")]
		private readonly Vector3[] m_Corners;

		[Token(Token = "0x170000F7")]
		public RectTransform content
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x3025864", Offset = "0x3021864", VA = "0x3025864")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x302586C", Offset = "0x302186C", VA = "0x302586C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public bool horizontal
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x3025874", Offset = "0x3021874", VA = "0x3025874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x302587C", Offset = "0x302187C", VA = "0x302587C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public bool vertical
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x3025884", Offset = "0x3021884", VA = "0x3025884")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x302588C", Offset = "0x302188C", VA = "0x302588C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public MovementType movementType
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x3025894", Offset = "0x3021894", VA = "0x3025894")]
			get
			{
				return default(MovementType);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x302589C", Offset = "0x302189C", VA = "0x302589C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public float elasticity
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x30258A4", Offset = "0x30218A4", VA = "0x30258A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x30258AC", Offset = "0x30218AC", VA = "0x30258AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public bool inertia
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x30258B4", Offset = "0x30218B4", VA = "0x30258B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x30258BC", Offset = "0x30218BC", VA = "0x30258BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float decelerationRate
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x30258C4", Offset = "0x30218C4", VA = "0x30258C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x30258CC", Offset = "0x30218CC", VA = "0x30258CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public float scrollSensitivity
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x30258D4", Offset = "0x30218D4", VA = "0x30258D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x30258DC", Offset = "0x30218DC", VA = "0x30258DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public RectTransform viewport
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x30258E4", Offset = "0x30218E4", VA = "0x30258E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x30258EC", Offset = "0x30218EC", VA = "0x30258EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public Scrollbar horizontalScrollbar
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x30259A8", Offset = "0x30219A8", VA = "0x30259A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x30259B0", Offset = "0x30219B0", VA = "0x30259B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x3025B2C", Offset = "0x3021B2C", VA = "0x3025B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x3025B34", Offset = "0x3021B34", VA = "0x3025B34")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public ScrollbarVisibility horizontalScrollbarVisibility
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x3025CB0", Offset = "0x3021CB0", VA = "0x3025CB0")]
			get
			{
				return default(ScrollbarVisibility);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x3025CB8", Offset = "0x3021CB8", VA = "0x3025CB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public ScrollbarVisibility verticalScrollbarVisibility
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x3025CC0", Offset = "0x3021CC0", VA = "0x3025CC0")]
			get
			{
				return default(ScrollbarVisibility);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x3025CC8", Offset = "0x3021CC8", VA = "0x3025CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public float horizontalScrollbarSpacing
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x3025CD0", Offset = "0x3021CD0", VA = "0x3025CD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x3025CD8", Offset = "0x3021CD8", VA = "0x3025CD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public float verticalScrollbarSpacing
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x3025D68", Offset = "0x3021D68", VA = "0x3025D68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x3025D70", Offset = "0x3021D70", VA = "0x3025D70")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public ScrollRectEvent onValueChanged
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x3025D78", Offset = "0x3021D78", VA = "0x3025D78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x3025D80", Offset = "0x3021D80", VA = "0x3025D80")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x3025D88", Offset = "0x3021D88", VA = "0x3025D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		public Vector2 velocity
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x3025E78", Offset = "0x3021E78", VA = "0x3025E78")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x3025E80", Offset = "0x3021E80", VA = "0x3025E80")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x3025E88", Offset = "0x3021E88", VA = "0x3025E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x3027AFC", Offset = "0x3023AFC", VA = "0x3027AFC")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x3027D5C", Offset = "0x3023D5C", VA = "0x3027D5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public float horizontalNormalizedPosition
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x3027B6C", Offset = "0x3023B6C", VA = "0x3027B6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x3027DA4", Offset = "0x3023DA4", VA = "0x3027DA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public float verticalNormalizedPosition
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x3027C64", Offset = "0x3023C64", VA = "0x3027C64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x3027DB8", Offset = "0x3023DB8", VA = "0x3027DB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		private bool hScrollingNeeded
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x302809C", Offset = "0x302409C", VA = "0x302809C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010E")]
		private bool vScrollingNeeded
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x3028124", Offset = "0x3024124", VA = "0x3028124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010F")]
		public virtual float minWidth
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x30281B4", Offset = "0x30241B4", VA = "0x30281B4", Slot = "52")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000110")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x30281BC", Offset = "0x30241BC", VA = "0x30281BC", Slot = "53")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000111")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x30281C4", Offset = "0x30241C4", VA = "0x30281C4", Slot = "54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000112")]
		public virtual float minHeight
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x30281CC", Offset = "0x30241CC", VA = "0x30281CC", Slot = "55")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000113")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x30281D4", Offset = "0x30241D4", VA = "0x30281D4", Slot = "56")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000114")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x30281DC", Offset = "0x30241DC", VA = "0x30281DC", Slot = "57")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000115")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x30281E4", Offset = "0x30241E4", VA = "0x30281E4", Slot = "58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x3025F1C", Offset = "0x3021F1C", VA = "0x3025F1C")]
		protected ScrollRect()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x3026060", Offset = "0x3022060", VA = "0x3026060", Slot = "38")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x30269F4", Offset = "0x30229F4", VA = "0x30269F4", Slot = "39")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x30269F8", Offset = "0x30229F8", VA = "0x30269F8", Slot = "40")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x30260E8", Offset = "0x30220E8", VA = "0x30260E8")]
		private void UpdateCachedData()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x30269FC", Offset = "0x30229FC", VA = "0x30269FC", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x3026BB8", Offset = "0x3022BB8", VA = "0x3026BB8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3026DE8", Offset = "0x3022DE8", VA = "0x3026DE8", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x3026E68", Offset = "0x3022E68", VA = "0x3026E68")]
		private void EnsureLayoutHasRebuilt()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x3026EDC", Offset = "0x3022EDC", VA = "0x3026EDC", Slot = "41")]
		public virtual void StopMovement()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3026F2C", Offset = "0x3022F2C", VA = "0x3026F2C", Slot = "42")]
		public virtual void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x30270CC", Offset = "0x30230CC", VA = "0x30270CC", Slot = "43")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x302712C", Offset = "0x302312C", VA = "0x302712C", Slot = "44")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x3027258", Offset = "0x3023258", VA = "0x3027258", Slot = "45")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x3027278", Offset = "0x3023278", VA = "0x3027278", Slot = "46")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x30274AC", Offset = "0x30234AC", VA = "0x30274AC", Slot = "47")]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x3027560", Offset = "0x3023560", VA = "0x3027560", Slot = "48")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x302691C", Offset = "0x302291C", VA = "0x302691C")]
		protected void UpdatePrevData()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x3026794", Offset = "0x3022794", VA = "0x3026794")]
		private void UpdateScrollbars(Vector2 offset)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x3027DCC", Offset = "0x3023DCC", VA = "0x3027DCC")]
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x3027DE0", Offset = "0x3023DE0", VA = "0x3027DE0")]
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x3027DF4", Offset = "0x3023DF4", VA = "0x3027DF4", Slot = "49")]
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x3027474", Offset = "0x3023474", VA = "0x3027474")]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3028098", Offset = "0x3024098", VA = "0x3028098", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x30281AC", Offset = "0x30241AC", VA = "0x30281AC", Slot = "50")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x30281B0", Offset = "0x30241B0", VA = "0x30281B0", Slot = "51")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x30281EC", Offset = "0x30241EC", VA = "0x30281EC", Slot = "59")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x30287A4", Offset = "0x30247A4", VA = "0x30287A4", Slot = "60")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x3027B2C", Offset = "0x3023B2C", VA = "0x3027B2C")]
		private void UpdateScrollbarVisibility()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3028AB8", Offset = "0x3024AB8", VA = "0x3028AB8")]
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x3028858", Offset = "0x3024858", VA = "0x3028858")]
		private void UpdateScrollbarLayout()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x3026430", Offset = "0x3022430", VA = "0x3026430")]
		protected void UpdateBounds()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x3028BD8", Offset = "0x3024BD8", VA = "0x3028BD8")]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x30286CC", Offset = "0x30246CC", VA = "0x30286CC")]
		private Bounds GetBounds()
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3028C54", Offset = "0x3024C54", VA = "0x3028C54")]
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x302709C", Offset = "0x302309C", VA = "0x302709C")]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x3028DA8", Offset = "0x3024DA8", VA = "0x3028DA8")]
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x3025CE0", Offset = "0x3021CE0", VA = "0x3025CE0")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x30258F4", Offset = "0x30218F4", VA = "0x30258F4")]
		protected void SetDirtyCaching()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x3028EEC", Offset = "0x3024EEC", VA = "0x3028EEC", Slot = "23")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Selectable", 35)]
	[DisallowMultipleComponent]
	[SelectionBase]
	public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		[Token(Token = "0x200006A")]
		public enum Transition
		{
			[Token(Token = "0x4000217")]
			None,
			[Token(Token = "0x4000218")]
			ColorTint,
			[Token(Token = "0x4000219")]
			SpriteSwap,
			[Token(Token = "0x400021A")]
			Animation
		}

		[Token(Token = "0x200006B")]
		protected enum SelectionState
		{
			[Token(Token = "0x400021C")]
			Normal,
			[Token(Token = "0x400021D")]
			Highlighted,
			[Token(Token = "0x400021E")]
			Pressed,
			[Token(Token = "0x400021F")]
			Selected,
			[Token(Token = "0x4000220")]
			Disabled
		}

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x0")]
		protected static Selectable[] s_Selectables;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x8")]
		protected static int s_SelectableCount;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x20")]
		private bool m_EnableCalled;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("navigation")]
		private Navigation m_Navigation;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("transition")]
		private Transition m_Transition;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[FormerlySerializedAs("colors")]
		private ColorBlock m_Colors;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("spriteState")]
		[SerializeField]
		private SpriteState m_SpriteState;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xD0")]
		[FormerlySerializedAs("animationTriggers")]
		[SerializeField]
		private AnimationTriggers m_AnimationTriggers;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("Can the Selectable be interacted with?")]
		[SerializeField]
		private bool m_Interactable;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[FormerlySerializedAs("m_HighlightGraphic")]
		[FormerlySerializedAs("highlightGraphic")]
		private Graphic m_TargetGraphic;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_GroupsAllowInteraction;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0xEC")]
		protected int m_CurrentIndex;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<CanvasGroup> m_CanvasGroupCache;

		[Token(Token = "0x17000116")]
		public static Selectable[] allSelectablesArray
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x3028EF4", Offset = "0x3024EF4", VA = "0x3028EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		public static int allSelectableCount
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x3028F90", Offset = "0x3024F90", VA = "0x3028F90")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000118")]
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		public static List<Selectable> allSelectables
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x3028FE8", Offset = "0x3024FE8", VA = "0x3028FE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		public Navigation navigation
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x3029140", Offset = "0x3025140", VA = "0x3029140")]
			get
			{
				return default(Navigation);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x3029158", Offset = "0x3025158", VA = "0x3029158")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public Transition transition
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x302923C", Offset = "0x302523C", VA = "0x302923C")]
			get
			{
				return default(Transition);
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x3029244", Offset = "0x3025244", VA = "0x3029244")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public ColorBlock colors
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x30292B8", Offset = "0x30252B8", VA = "0x30292B8")]
			get
			{
				return default(ColorBlock);
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x30292C8", Offset = "0x30252C8", VA = "0x30292C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public SpriteState spriteState
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x3029348", Offset = "0x3025348", VA = "0x3029348")]
			get
			{
				return default(SpriteState);
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x3029354", Offset = "0x3025354", VA = "0x3029354")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public AnimationTriggers animationTriggers
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x30293CC", Offset = "0x30253CC", VA = "0x30293CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x30293D4", Offset = "0x30253D4", VA = "0x30293D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public Graphic targetGraphic
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x3029448", Offset = "0x3025448", VA = "0x3029448")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x3029450", Offset = "0x3025450", VA = "0x3029450")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public bool interactable
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x30294C4", Offset = "0x30254C4", VA = "0x30294C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x30294CC", Offset = "0x30254CC", VA = "0x30294CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		private bool isPointerInside
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x3029638", Offset = "0x3025638", VA = "0x3029638")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x3029640", Offset = "0x3025640", VA = "0x3029640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		private bool isPointerDown
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x3029648", Offset = "0x3025648", VA = "0x3029648")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x3029650", Offset = "0x3025650", VA = "0x3029650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		private bool hasSelection
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x3029658", Offset = "0x3025658", VA = "0x3029658")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x3029660", Offset = "0x3025660", VA = "0x3029660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public Image image
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x3029668", Offset = "0x3025668", VA = "0x3029668")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x30296E4", Offset = "0x30256E4", VA = "0x30296E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public Animator animator
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x30296EC", Offset = "0x30256EC", VA = "0x30296EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		protected SelectionState currentSelectionState
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x3029988", Offset = "0x3025988", VA = "0x3029988")]
			get
			{
				return default(SelectionState);
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x3029084", Offset = "0x3025084", VA = "0x3029084")]
		public static int AllSelectablesNoAlloc(Selectable[] selectables)
		{
			return default(int);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3023CB4", Offset = "0x301FCB4", VA = "0x3023CB4")]
		protected Selectable()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x3029734", Offset = "0x3025734", VA = "0x3029734", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x30297C0", Offset = "0x30257C0", VA = "0x30297C0", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x30297F4", Offset = "0x30257F4", VA = "0x30297F4")]
		private bool ParentGroupAllowsInteraction()
		{
			return default(bool);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x302996C", Offset = "0x302596C", VA = "0x302996C", Slot = "24")]
		public virtual bool IsInteractable()
		{
			return default(bool);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x3029984", Offset = "0x3025984", VA = "0x3029984", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x30240D4", Offset = "0x30200D4", VA = "0x30240D4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x30299D8", Offset = "0x30259D8", VA = "0x30299D8", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x30291D8", Offset = "0x30251D8", VA = "0x30291D8")]
		private void OnSetProperty()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x30243AC", Offset = "0x30203AC", VA = "0x30243AC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x3029A00", Offset = "0x3025A00", VA = "0x3029A00")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x3029AA0", Offset = "0x3025AA0", VA = "0x3029AA0", Slot = "25")]
		protected virtual void InstantClearState()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x3029E40", Offset = "0x3025E40", VA = "0x3029E40", Slot = "26")]
		protected virtual void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x302A0BC", Offset = "0x30260BC", VA = "0x302A0BC")]
		public Selectable FindSelectable(Vector3 dir)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x302A558", Offset = "0x3026558", VA = "0x302A558")]
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x302A6D8", Offset = "0x30266D8", VA = "0x302A6D8")]
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x3025050", Offset = "0x3021050", VA = "0x3025050", Slot = "27")]
		public virtual Selectable FindSelectableOnLeft()
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x302514C", Offset = "0x302114C", VA = "0x302514C", Slot = "28")]
		public virtual Selectable FindSelectableOnRight()
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x3025248", Offset = "0x3021248", VA = "0x3025248", Slot = "29")]
		public virtual Selectable FindSelectableOnUp()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x3025344", Offset = "0x3021344", VA = "0x3025344", Slot = "30")]
		public virtual Selectable FindSelectableOnDown()
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x3024F94", Offset = "0x3020F94", VA = "0x3024F94", Slot = "31")]
		public virtual void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x3029B00", Offset = "0x3025B00", VA = "0x3029B00")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x3029C10", Offset = "0x3025C10", VA = "0x3029C10")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x3029CB8", Offset = "0x3025CB8", VA = "0x3029CB8")]
		private void TriggerAnimation(string triggername)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x302A790", Offset = "0x3026790", VA = "0x302A790")]
		protected bool IsHighlighted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x3029A5C", Offset = "0x3025A5C", VA = "0x3029A5C")]
		protected bool IsPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x302A7EC", Offset = "0x30267EC", VA = "0x302A7EC")]
		private void EvaluateAndTransitionToSelectionState()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x3024AFC", Offset = "0x3020AFC", VA = "0x3024AFC", Slot = "32")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x3024D30", Offset = "0x3020D30", VA = "0x3024D30", Slot = "33")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x302A884", Offset = "0x3026884", VA = "0x302A884", Slot = "34")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x302A890", Offset = "0x3026890", VA = "0x302A890", Slot = "35")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x302A898", Offset = "0x3026898", VA = "0x302A898", Slot = "36")]
		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x302A8A4", Offset = "0x30268A4", VA = "0x302A8A4", Slot = "37")]
		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x302A8AC", Offset = "0x30268AC", VA = "0x302A8AC", Slot = "38")]
		public virtual void Select()
		{
		}
	}
	[Token(Token = "0x200006C")]
	internal static class SetPropertyUtility
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x302AA24", Offset = "0x3026A24", VA = "0x302AA24")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006D")]
	[AddComponentMenu("UI/Slider", 34)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Token(Token = "0x200006E")]
		public enum Direction
		{
			[Token(Token = "0x4000232")]
			LeftToRight,
			[Token(Token = "0x4000233")]
			RightToLeft,
			[Token(Token = "0x4000234")]
			BottomToTop,
			[Token(Token = "0x4000235")]
			TopToBottom
		}

		[Serializable]
		[Token(Token = "0x200006F")]
		public class SliderEvent : UnityEvent<float>
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x302B638", Offset = "0x3027638", VA = "0x302B638")]
			public SliderEvent()
			{
			}
		}

		[Token(Token = "0x2000070")]
		private enum Axis
		{
			[Token(Token = "0x4000237")]
			Horizontal,
			[Token(Token = "0x4000238")]
			Vertical
		}

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform m_FillRect;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RectTransform m_HandleRect;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x110")]
		[Space]
		[SerializeField]
		private Direction m_Direction;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private bool m_WholeNumbers;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected float m_Value;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Space]
		private SliderEvent m_OnValueChanged;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x130")]
		private Image m_FillImage;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x138")]
		private Transform m_FillTransform;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x140")]
		private RectTransform m_FillContainerRect;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x148")]
		private Transform m_HandleTransform;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x150")]
		private RectTransform m_HandleContainerRect;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x158")]
		private Vector2 m_Offset;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x160")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x161")]
		private bool m_DelayedUpdateVisuals;

		[Token(Token = "0x17000126")]
		public RectTransform fillRect
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x302AA70", Offset = "0x3026A70", VA = "0x302AA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x302AA78", Offset = "0x3026A78", VA = "0x302AA78")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public RectTransform handleRect
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x302B080", Offset = "0x3027080", VA = "0x302B080")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x302B088", Offset = "0x3027088", VA = "0x302B088")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public Direction direction
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x302B104", Offset = "0x3027104", VA = "0x302B104")]
			get
			{
				return default(Direction);
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x302B10C", Offset = "0x302710C", VA = "0x302B10C")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public float minValue
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x302B180", Offset = "0x3027180", VA = "0x302B180")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x302B188", Offset = "0x3027188", VA = "0x302B188")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public float maxValue
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x302B218", Offset = "0x3027218", VA = "0x302B218")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x302B220", Offset = "0x3027220", VA = "0x302B220")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public bool wholeNumbers
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x302B2B0", Offset = "0x30272B0", VA = "0x302B2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x302B2B8", Offset = "0x30272B8", VA = "0x302B2B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public virtual float value
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x302B348", Offset = "0x3027348", VA = "0x302B348", Slot = "46")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x302B3E8", Offset = "0x30273E8", VA = "0x302B3E8", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public float normalizedValue
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x302B410", Offset = "0x3027410", VA = "0x302B410")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x302B4FC", Offset = "0x30274FC", VA = "0x302B4FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public SliderEvent onValueChanged
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x302B538", Offset = "0x3027538", VA = "0x302B538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x302B540", Offset = "0x3027540", VA = "0x302B540")]
			set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		private float stepSize
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x302B548", Offset = "0x3027548", VA = "0x302B548")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000130")]
		private Axis axis
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x302B9C0", Offset = "0x30279C0", VA = "0x302B9C0")]
			get
			{
				return default(Axis);
			}
		}

		[Token(Token = "0x17000131")]
		private bool reverseValue
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x302B9AC", Offset = "0x30279AC", VA = "0x302B9AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x302B3FC", Offset = "0x30273FC", VA = "0x302B3FC", Slot = "48")]
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x302B574", Offset = "0x3027574", VA = "0x302B574")]
		protected Slider()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x302B680", Offset = "0x3027680", VA = "0x302B680", Slot = "49")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x302B684", Offset = "0x3027684", VA = "0x302B684", Slot = "50")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x302B688", Offset = "0x3027688", VA = "0x302B688", Slot = "51")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x302B68C", Offset = "0x302768C", VA = "0x302B68C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x302B6C8", Offset = "0x30276C8", VA = "0x302B6C8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x302B6E8", Offset = "0x30276E8", VA = "0x302B6E8", Slot = "52")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x302B724", Offset = "0x3027724", VA = "0x302B724", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x302AAF4", Offset = "0x3026AF4", VA = "0x302AAF4")]
		private void UpdateCachedReferences()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x302B8F8", Offset = "0x30278F8", VA = "0x302B8F8")]
		private float ClampValue(float input)
		{
			return default(float);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x302B9D0", Offset = "0x30279D0", VA = "0x302B9D0", Slot = "53")]
		protected virtual void Set(float input, bool sendCallback = true)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x302BA94", Offset = "0x3027A94", VA = "0x302BA94", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x302ADA0", Offset = "0x3026DA0", VA = "0x302ADA0")]
		private void UpdateVisuals()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x302BACC", Offset = "0x3027ACC", VA = "0x302BACC")]
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x302BCCC", Offset = "0x3027CCC", VA = "0x302BCCC")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x302BD30", Offset = "0x3027D30", VA = "0x302BD30", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x302BEF8", Offset = "0x3027EF8", VA = "0x302BEF8", Slot = "54")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x302BF48", Offset = "0x3027F48", VA = "0x302BF48", Slot = "31")]
		public override void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x302C190", Offset = "0x3028190", VA = "0x302C190", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x302C1B4", Offset = "0x30281B4", VA = "0x302C1B4", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x302C1D8", Offset = "0x30281D8", VA = "0x302C1D8", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x302C1FC", Offset = "0x30281FC", VA = "0x302C1FC", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x302C220", Offset = "0x3028220", VA = "0x302C220", Slot = "55")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x302C234", Offset = "0x3028234", VA = "0x302C234")]
		public void SetDirection(Direction direction, bool includeRectLayouts)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x302C3BC", Offset = "0x30283BC", VA = "0x302C3BC", Slot = "42")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public struct SpriteState : IEquatable<SpriteState>
	{
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Sprite m_HighlightedSprite;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Sprite m_PressedSprite;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("m_HighlightedSprite")]
		[SerializeField]
		private Sprite m_SelectedSprite;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_DisabledSprite;

		[Token(Token = "0x17000132")]
		public Sprite highlightedSprite
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x302C3C4", Offset = "0x30283C4", VA = "0x302C3C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x302C3CC", Offset = "0x30283CC", VA = "0x302C3CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public Sprite pressedSprite
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x302C3D4", Offset = "0x30283D4", VA = "0x302C3D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x302C3DC", Offset = "0x30283DC", VA = "0x302C3DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public Sprite selectedSprite
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x302C3E4", Offset = "0x30283E4", VA = "0x302C3E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x302C3EC", Offset = "0x30283EC", VA = "0x302C3EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public Sprite disabledSprite
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x302C3F4", Offset = "0x30283F4", VA = "0x302C3F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x302C3FC", Offset = "0x30283FC", VA = "0x302C3FC")]
			set
			{
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x302C404", Offset = "0x3028404", VA = "0x302C404", Slot = "4")]
		public bool Equals(SpriteState other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000072")]
	public static class StencilMaterial
	{
		[Token(Token = "0x2000073")]
		private class MatEntry
		{
			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x10")]
			public Material baseMat;

			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x18")]
			public Material customMat;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x24")]
			public int stencilId;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x28")]
			public StencilOp operation;

			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x2C")]
			public CompareFunction compareFunction;

			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x30")]
			public int readMask;

			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x34")]
			public int writeMask;

			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x38")]
			public bool useAlphaClip;

			[Token(Token = "0x4000247")]
			[FieldOffset(Offset = "0x3C")]
			public ColorWriteMask colorMask;

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x302CF08", Offset = "0x3028F08", VA = "0x302CF08")]
			public MatEntry()
			{
			}
		}

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x0")]
		private static List<MatEntry> m_List;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x302C50C", Offset = "0x302850C", VA = "0x302C50C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x302C514", Offset = "0x3028514", VA = "0x302C514")]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x302CE60", Offset = "0x3028E60", VA = "0x302CE60")]
		private static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x302C5A0", Offset = "0x30285A0", VA = "0x302C5A0")]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x302CF18", Offset = "0x3028F18", VA = "0x302CF18")]
		public static void Remove(Material customMat)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x302D0D8", Offset = "0x30290D8", VA = "0x302D0D8")]
		public static void ClearAll()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Legacy/Text", 100)]
	public class Text : MaskableGraphic, ILayoutElement
	{
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private FontData m_FontData;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[TextArea(3, 10)]
		protected string m_Text;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0xE8")]
		private TextGenerator m_TextCache;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0xF0")]
		private TextGenerator m_TextCacheForLayout;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_DefaultText;

		[NonSerialized]
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0xF8")]
		protected bool m_DisableFontTextureRebuiltCallback;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x100")]
		private readonly UIVertex[] m_TempVerts;

		[Token(Token = "0x17000136")]
		public TextGenerator cachedTextGenerator
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x302D33C", Offset = "0x302933C", VA = "0x302D33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		public TextGenerator cachedTextGeneratorForLayout
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x302D3C4", Offset = "0x30293C4", VA = "0x302D3C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x302D428", Offset = "0x3029428", VA = "0x302D428", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public Font font
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x302D5D0", Offset = "0x30295D0", VA = "0x302D5D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x302D6FC", Offset = "0x30296FC", VA = "0x302D6FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public virtual string text
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x302D810", Offset = "0x3029810", VA = "0x302D810", Slot = "74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x302D818", Offset = "0x3029818", VA = "0x302D818", Slot = "75")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public bool supportRichText
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x302D8E4", Offset = "0x30298E4", VA = "0x302D8E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x302D8FC", Offset = "0x30298FC", VA = "0x302D8FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public bool resizeTextForBestFit
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x302D954", Offset = "0x3029954", VA = "0x302D954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x302D96C", Offset = "0x302996C", VA = "0x302D96C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public int resizeTextMinSize
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x302D9C4", Offset = "0x30299C4", VA = "0x302D9C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x302D9DC", Offset = "0x30299DC", VA = "0x302D9DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public int resizeTextMaxSize
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x302DA30", Offset = "0x3029A30", VA = "0x302DA30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x302DA48", Offset = "0x3029A48", VA = "0x302DA48")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public TextAnchor alignment
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x302DA9C", Offset = "0x3029A9C", VA = "0x302DA9C")]
			get
			{
				return default(TextAnchor);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x302DAB4", Offset = "0x3029AB4", VA = "0x302DAB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public bool alignByGeometry
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x302DB08", Offset = "0x3029B08", VA = "0x302DB08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x302DB20", Offset = "0x3029B20", VA = "0x302DB20")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public int fontSize
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x302DB58", Offset = "0x3029B58", VA = "0x302DB58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x302DB70", Offset = "0x3029B70", VA = "0x302DB70")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public HorizontalWrapMode horizontalOverflow
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x302DBC4", Offset = "0x3029BC4", VA = "0x302DBC4")]
			get
			{
				return default(HorizontalWrapMode);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x302DBDC", Offset = "0x3029BDC", VA = "0x302DBDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public VerticalWrapMode verticalOverflow
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x302DC30", Offset = "0x3029C30", VA = "0x302DC30")]
			get
			{
				return default(VerticalWrapMode);
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x302DC48", Offset = "0x3029C48", VA = "0x302DC48")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public float lineSpacing
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x302DC9C", Offset = "0x3029C9C", VA = "0x302DC9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x302DCB4", Offset = "0x3029CB4", VA = "0x302DCB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x302DD08", Offset = "0x3029D08", VA = "0x302DD08")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x302DD20", Offset = "0x3029D20", VA = "0x302DD20")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x302DD74", Offset = "0x3029D74", VA = "0x302DD74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000147")]
		public virtual float minWidth
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x302E9E8", Offset = "0x302A9E8", VA = "0x302E9E8", Slot = "78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000148")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x302E9F0", Offset = "0x302A9F0", VA = "0x302E9F0", Slot = "79")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000149")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x302EAB4", Offset = "0x302AAB4", VA = "0x302EAB4", Slot = "80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014A")]
		public virtual float minHeight
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x302EABC", Offset = "0x302AABC", VA = "0x302EABC", Slot = "81")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014B")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x302EAC4", Offset = "0x302AAC4", VA = "0x302EAC4", Slot = "82")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014C")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x302EB54", Offset = "0x302AB54", VA = "0x302EB54", Slot = "83")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014D")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x302EB5C", Offset = "0x302AB5C", VA = "0x302EB5C", Slot = "84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x302D2A4", Offset = "0x30292A4", VA = "0x302D2A4")]
		protected Text()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x302D5E8", Offset = "0x30295E8", VA = "0x302D5E8")]
		public void FontTextureChanged()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x302DEBC", Offset = "0x3029EBC", VA = "0x302DEBC", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x302DF38", Offset = "0x3029F38", VA = "0x302DF38", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x302DF9C", Offset = "0x3029F9C", VA = "0x302DF9C", Slot = "41")]
		protected override void UpdateGeometry()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x302E024", Offset = "0x302A024", VA = "0x302E024")]
		internal void AssignDefaultFont()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x302E094", Offset = "0x302A094", VA = "0x302E094")]
		internal void AssignDefaultFontIfNecessary()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x302E150", Offset = "0x302A150", VA = "0x302E150")]
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			return default(TextGenerationSettings);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x302E314", Offset = "0x302A314", VA = "0x302E314")]
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x302E380", Offset = "0x302A380", VA = "0x302E380", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x302E9E0", Offset = "0x302A9E0", VA = "0x302E9E0", Slot = "76")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x302E9E4", Offset = "0x302A9E4", VA = "0x302E9E4", Slot = "77")]
		public virtual void CalculateLayoutInputVertical()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AddComponentMenu("UI/Toggle", 30)]
	[RequireComponent(typeof(RectTransform))]
	public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		[Token(Token = "0x2000076")]
		public enum ToggleTransition
		{
			[Token(Token = "0x4000255")]
			None,
			[Token(Token = "0x4000256")]
			Fade
		}

		[Serializable]
		[Token(Token = "0x2000077")]
		public class ToggleEvent : UnityEvent<bool>
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x302EE18", Offset = "0x302AE18", VA = "0x302EE18")]
			public ToggleEvent()
			{
			}
		}

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x100")]
		public ToggleTransition toggleTransition;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x108")]
		public Graphic graphic;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ToggleGroup m_Group;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x118")]
		public ToggleEvent onValueChanged;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x120")]
		[Tooltip("Is the toggle currently on or off?")]
		[SerializeField]
		private bool m_IsOn;

		[Token(Token = "0x1700014E")]
		public ToggleGroup group
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x302EB64", Offset = "0x302AB64", VA = "0x302EB64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x302EB6C", Offset = "0x302AB6C", VA = "0x302EB6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public bool isOn
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x302F810", Offset = "0x302B810", VA = "0x302F810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x302F818", Offset = "0x302B818", VA = "0x302F818")]
			set
			{
			}
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x302ED8C", Offset = "0x302AD8C", VA = "0x302ED8C")]
		protected Toggle()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x302EE60", Offset = "0x302AE60", VA = "0x302EE60", Slot = "46")]
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x302EE64", Offset = "0x302AE64", VA = "0x302EE64", Slot = "47")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x302EE68", Offset = "0x302AE68", VA = "0x302EE68", Slot = "48")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x302EE6C", Offset = "0x302AE6C", VA = "0x302EE6C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x302F2A0", Offset = "0x302B2A0", VA = "0x302F2A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x302F2CC", Offset = "0x302B2CC", VA = "0x302F2CC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x302F2EC", Offset = "0x302B2EC", VA = "0x302F2EC", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x302EB8C", Offset = "0x302AB8C", VA = "0x302EB8C")]
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x302F820", Offset = "0x302B820", VA = "0x302F820")]
		public void SetIsOnWithoutNotify(bool value)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x302F410", Offset = "0x302B410", VA = "0x302F410")]
		private void Set(bool value, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x302ECC8", Offset = "0x302ACC8", VA = "0x302ECC8")]
		private void PlayEffect(bool instant)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x302F960", Offset = "0x302B960", VA = "0x302F960", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x302F968", Offset = "0x302B968", VA = "0x302F968")]
		private void InternalToggle()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x302F9BC", Offset = "0x302B9BC", VA = "0x302F9BC", Slot = "49")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x302F9D8", Offset = "0x302B9D8", VA = "0x302F9D8", Slot = "50")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x302F9DC", Offset = "0x302B9DC", VA = "0x302F9DC", Slot = "42")]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Toggle Group", 31)]
	public class ToggleGroup : UIBehaviour
	{
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AllowSwitchOff;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		protected List<Toggle> m_Toggles;

		[Token(Token = "0x17000150")]
		public bool allowSwitchOff
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x302F9E4", Offset = "0x302B9E4", VA = "0x302F9E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x302F9EC", Offset = "0x302B9EC", VA = "0x302F9EC")]
			set
			{
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x302F9F4", Offset = "0x302B9F4", VA = "0x302F9F4")]
		protected ToggleGroup()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x302FA70", Offset = "0x302BA70", VA = "0x302FA70", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x302FA8C", Offset = "0x302BA8C", VA = "0x302FA8C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x302FAA8", Offset = "0x302BAA8", VA = "0x302FAA8")]
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x302F6E4", Offset = "0x302B6E4", VA = "0x302F6E4")]
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x302F584", Offset = "0x302B584", VA = "0x302F584")]
		public void UnregisterToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x302F614", Offset = "0x302B614", VA = "0x302F614")]
		public void RegisterToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x302EEEC", Offset = "0x302AEEC", VA = "0x302EEEC")]
		public void EnsureValidState()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x302F828", Offset = "0x302B828", VA = "0x302F828")]
		public bool AnyTogglesOn()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x302FBF0", Offset = "0x302BBF0", VA = "0x302FBF0")]
		public IEnumerable<Toggle> ActiveToggles()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x302FCE4", Offset = "0x302BCE4", VA = "0x302FCE4")]
		public Toggle GetFirstActiveToggle()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x302FD6C", Offset = "0x302BD6C", VA = "0x302FD6C")]
		public void SetAllTogglesOff(bool sendCallback = true)
		{
		}
	}
	[Token(Token = "0x200007A")]
	internal class ReflectionMethodsCache
	{
		[Token(Token = "0x200007B")]
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i);

		[Token(Token = "0x200007C")]
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i);

		[Token(Token = "0x200007D")]
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i);

		[Token(Token = "0x200007E")]
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i);

		[Token(Token = "0x200007F")]
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i);

		[Token(Token = "0x2000080")]
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i);

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x10")]
		public Raycast3DCallback raycast3D;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x18")]
		public RaycastAllCallback raycast3DAll;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x20")]
		public GetRaycastNonAllocCallback getRaycastNonAlloc;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x28")]
		public Raycast2DCallback raycast2D;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x30")]
		public GetRayIntersectionAllCallback getRayIntersectionAll;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x38")]
		public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionMethodsCache s_ReflectionMethodsCache;

		[Token(Token = "0x17000151")]
		public static ReflectionMethodsCache Singleton
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x3030B04", Offset = "0x302CB04", VA = "0x3030B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x302FEF0", Offset = "0x302BEF0", VA = "0x302FEF0")]
		public ReflectionMethodsCache()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class VertexHelper : IDisposable
	{
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector3> m_Positions;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x18")]
		private List<Color32> m_Colors;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x20")]
		private List<Vector4> m_Uv0S;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x28")]
		private List<Vector4> m_Uv1S;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x30")]
		private List<Vector4> m_Uv2S;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector4> m_Uv3S;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> m_Normals;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x48")]
		private List<Vector4> m_Tangents;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_Indices;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4 s_DefaultTangent;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector3 s_DefaultNormal;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_ListsInitalized;

		[Token(Token = "0x17000152")]
		public int currentVertCount
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x3031C48", Offset = "0x302DC48", VA = "0x3031C48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000153")]
		public int currentIndexCount
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x3031C94", Offset = "0x302DC94", VA = "0x3031C94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x30316A0", Offset = "0x302D6A0", VA = "0x30316A0")]
		public VertexHelper()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x30316A8", Offset = "0x302D6A8", VA = "0x30316A8")]
		public VertexHelper(Mesh m)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x30318E4", Offset = "0x302D8E4", VA = "0x30318E4")]
		private void InitializeListIfRequired()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x3031A8C", Offset = "0x302DA8C", VA = "0x3031A8C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x3021FE8", Offset = "0x301DFE8", VA = "0x3021FE8")]
		public void Clear()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x3031CE0", Offset = "0x302DCE0", VA = "0x3031CE0")]
		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x3031E40", Offset = "0x302DE40", VA = "0x3031E40")]
		public void SetUIVertex(UIVertex vertex, int i)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x3031F9C", Offset = "0x302DF9C", VA = "0x3031F9C")]
		public void FillMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x30320FC", Offset = "0x302E0FC", VA = "0x30320FC")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x3032564", Offset = "0x302E564", VA = "0x3032564")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x3022104", Offset = "0x301E104", VA = "0x3022104")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x303267C", Offset = "0x302E67C", VA = "0x303267C")]
		public void AddVert(UIVertex v)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x3022234", Offset = "0x301E234", VA = "0x3022234")]
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x302E8D4", Offset = "0x302A8D4", VA = "0x302E8D4")]
		public void AddUIVertexQuad(UIVertex[] verts)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x3032710", Offset = "0x302E710", VA = "0x3032710")]
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x30327BC", Offset = "0x302E7BC", VA = "0x30327BC")]
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x303280C", Offset = "0x302E80C", VA = "0x303280C")]
		public void GetUIVertexStream(List<UIVertex> stream)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect
	{
		[Token(Token = "0x600052A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x30328F4", Offset = "0x302E8F4", VA = "0x30328F4")]
		protected BaseVertexEffect()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		[NonSerialized]
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x20")]
		private Graphic m_Graphic;

		[Token(Token = "0x17000154")]
		protected Graphic graphic
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x30328FC", Offset = "0x302E8FC", VA = "0x30328FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x3032990", Offset = "0x302E990", VA = "0x3032990", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x3032A38", Offset = "0x302EA38", VA = "0x3032A38", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x3032AD4", Offset = "0x302EAD4", VA = "0x3032AD4", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x3032B70", Offset = "0x302EB70", VA = "0x3032B70", Slot = "19")]
		public virtual void ModifyMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x6000531")]
		public abstract void ModifyMesh(VertexHelper vh);

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x3032CDC", Offset = "0x302ECDC", VA = "0x3032CDC")]
		protected BaseMeshEffect()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier
	{
		[Token(Token = "0x6000533")]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void ModifyVertices(List<UIVertex> verts);
	}
	[Token(Token = "0x2000085")]
	public interface IMeshModifier
	{
		[Token(Token = "0x6000534")]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);

		[Token(Token = "0x6000535")]
		void ModifyMesh(VertexHelper verts);
	}
	[Token(Token = "0x2000086")]
	[AddComponentMenu("UI/Effects/Outline", 81)]
	public class Outline : Shadow
	{
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x3032CE4", Offset = "0x302ECE4", VA = "0x3032CE4")]
		protected Outline()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x3032CEC", Offset = "0x302ECEC", VA = "0x3032CEC", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AddComponentMenu("UI/Effects/Position As UV1", 82)]
	public class PositionAsUV1 : BaseMeshEffect
	{
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x3032F2C", Offset = "0x302EF2C", VA = "0x3032F2C")]
		protected PositionAsUV1()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x3032F34", Offset = "0x302EF34", VA = "0x3032F34", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AddComponentMenu("UI/Effects/Shadow", 80)]
	public class Shadow : BaseMeshEffect
	{
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color m_EffectColor;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 m_EffectDistance;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseGraphicAlpha;

		[Token(Token = "0x4000273")]
		private const float kMaxEffectDistance = 600f;

		[Token(Token = "0x17000155")]
		public Color effectColor
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x3033018", Offset = "0x302F018", VA = "0x3033018")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x3033024", Offset = "0x302F024", VA = "0x3033024")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public Vector2 effectDistance
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x30330F8", Offset = "0x302F0F8", VA = "0x30330F8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x3033100", Offset = "0x302F100", VA = "0x3033100")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public bool useGraphicAlpha
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x3033200", Offset = "0x302F200", VA = "0x3033200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x3033208", Offset = "0x302F208", VA = "0x3033208")]
			set
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x3032FF0", Offset = "0x302EFF0", VA = "0x3032FF0")]
		protected Shadow()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x30332C0", Offset = "0x302F2C0", VA = "0x30332C0")]
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x30335A0", Offset = "0x302F5A0", VA = "0x30335A0")]
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x30335A8", Offset = "0x302F5A8", VA = "0x30335A8", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
namespace UnityEngine.UI.Collections
{
	[Token(Token = "0x2000089")]
	internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<T> m_List;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> m_Dictionary;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x0")]
		private int m_EnabledObjectCount;

		[Token(Token = "0x17000158")]
		public int Count
		{
			[Token(Token = "0x600054F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000159")]
		public int Capacity
		{
			[Token(Token = "0x6000550")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000551")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015B")]
		public T this[int index]
		{
			[Token(Token = "0x6000556")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000557")]
			set
			{
			}
		}

		[Token(Token = "0x6000544")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000545")]
		public void Add(T item, bool isActive)
		{
		}

		[Token(Token = "0x6000546")]
		public bool AddUnique(T item, bool isActive = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		public bool EnableItem(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		public bool DisableItem(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600054D")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000552")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000553")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000554")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000555")]
		private void Swap(int index1, int index2)
		{
		}

		[Token(Token = "0x6000558")]
		public void RemoveAll(Predicate<T> match)
		{
		}

		[Token(Token = "0x6000559")]
		public void Sort(Comparison<T> sortLayoutFunction)
		{
		}

		[Token(Token = "0x600055A")]
		public IndexedSet()
		{
		}
	}
}
namespace UnityEngine.UI.CoroutineTween
{
	[Token(Token = "0x200008A")]
	internal interface ITweenValue
	{
		[Token(Token = "0x1700015C")]
		bool ignoreTimeScale
		{
			[Token(Token = "0x600055C")]
			get;
		}

		[Token(Token = "0x1700015D")]
		float duration
		{
			[Token(Token = "0x600055D")]
			get;
		}

		[Token(Token = "0x600055B")]
		void TweenValue(float floatPercentage);

		[Token(Token = "0x600055E")]
		bool ValidTarget();
	}
	[Token(Token = "0x200008B")]
	internal struct ColorTween : ITweenValue
	{
		[Token(Token = "0x200008C")]
		public enum ColorTweenMode
		{
			[Token(Token = "0x400027E")]
			All,
			[Token(Token = "0x400027F")]
			RGB,
			[Token(Token = "0x4000280")]
			Alpha
		}

		[Token(Token = "0x200008D")]
		public class ColorTweenCallback : UnityEvent<Color>
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x3033898", Offset = "0x302F898", VA = "0x3033898")]
			public ColorTweenCallback()
			{
			}
		}

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x0")]
		private ColorTweenCallback m_Target;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x8")]
		private Color m_StartColor;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x18")]
		private Color m_TargetColor;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x28")]
		private ColorTweenMode m_TweenMode;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Duration;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IgnoreTimeScale;

		[Token(Token = "0x1700015E")]
		public Color startColor
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x30336C8", Offset = "0x302F6C8", VA = "0x30336C8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x30336D4", Offset = "0x302F6D4", VA = "0x30336D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public Color targetColor
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x30336E0", Offset = "0x302F6E0", VA = "0x30336E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x30336EC", Offset = "0x302F6EC", VA = "0x30336EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public ColorTweenMode tweenMode
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x30336F8", Offset = "0x302F6F8", VA = "0x30336F8")]
			get
			{
				return default(ColorTweenMode);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x3033700", Offset = "0x302F700", VA = "0x3033700")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public float duration
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x3033708", Offset = "0x302F708", VA = "0x3033708", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x3033710", Offset = "0x302F710", VA = "0x3033710")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x3033718", Offset = "0x302F718", VA = "0x3033718", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x3033720", Offset = "0x302F720", VA = "0x3033720")]
			set
			{
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x3033728", Offset = "0x302F728", VA = "0x3033728", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x3033810", Offset = "0x302F810", VA = "0x3033810")]
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x30338E0", Offset = "0x302F8E0", VA = "0x30338E0")]
		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x30338E8", Offset = "0x302F8E8", VA = "0x30338E8")]
		public float GetDuration()
		{
			return default(float);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x3033800", Offset = "0x302F800", VA = "0x3033800", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008E")]
	internal struct FloatTween : ITweenValue
	{
		[Token(Token = "0x200008F")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x3033A58", Offset = "0x302FA58", VA = "0x3033A58")]
			public FloatTweenCallback()
			{
			}
		}

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x0")]
		private FloatTweenCallback m_Target;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x8")]
		private float m_StartValue;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xC")]
		private float m_TargetValue;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x10")]
		private float m_Duration;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IgnoreTimeScale;

		[Token(Token = "0x17000163")]
		public float startValue
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x30338F0", Offset = "0x302F8F0", VA = "0x30338F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x30338F8", Offset = "0x302F8F8", VA = "0x30338F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public float targetValue
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x3033900", Offset = "0x302F900", VA = "0x3033900")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x3033908", Offset = "0x302F908", VA = "0x3033908")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public float duration
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x3033910", Offset = "0x302F910", VA = "0x3033910", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x3033918", Offset = "0x302F918", VA = "0x3033918")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x3033920", Offset = "0x302F920", VA = "0x3033920", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x3033928", Offset = "0x302F928", VA = "0x3033928")]
			set
			{
			}
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x3033930", Offset = "0x302F930", VA = "0x3033930", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x30339D0", Offset = "0x302F9D0", VA = "0x30339D0")]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x3033AA0", Offset = "0x302FAA0", VA = "0x3033AA0")]
		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x3033AA8", Offset = "0x302FAA8", VA = "0x3033AA8")]
		public float GetDuration()
		{
			return default(float);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x30339C0", Offset = "0x302F9C0", VA = "0x30339C0", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000090")]
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		[Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000289")]
			[FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400028A")]
			[FieldOffset(Offset = "0x0")]
			public T tweenInfo;

			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0x0")]
			private float <elapsedTime>5__2;

			[Token(Token = "0x17000167")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000585")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000587")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000582")]
			[DebuggerHidden]
			public <Start>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000583")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000584")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000586")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;

		[Token(Token = "0x600057D")]
		[IteratorStateMachine(typeof(TweenRunner<>.<Start>d__2))]
		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		[Token(Token = "0x600057F")]
		public void StartTween(T info)
		{
		}

		[Token(Token = "0x6000580")]
		public void StopTween()
		{
		}

		[Token(Token = "0x6000581")]
		public TweenRunner()
		{
		}
	}
}
namespace UnityEngine.UIElements
{
	[Token(Token = "0x2000092")]
	[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
	public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, UnityEngine.UIElements.IRuntimePanelComponent, IPointerClickHandler
	{
		[Token(Token = "0x2000093")]
		private enum PointerEventType
		{
			[Token(Token = "0x4000293")]
			Default,
			[Token(Token = "0x4000294")]
			Down,
			[Token(Token = "0x4000295")]
			Up
		}

		[Token(Token = "0x2000094")]
		private class PointerEvent : IPointerEvent
		{
			[Token(Token = "0x1700016E")]
			public int pointerId
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x30360F0", Offset = "0x30320F0", VA = "0x30360F0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x30360F8", Offset = "0x30320F8", VA = "0x30360F8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700016F")]
			public string pointerType
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x3036100", Offset = "0x3032100", VA = "0x3036100", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x3036108", Offset = "0x3032108", VA = "0x3036108")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000170")]
			public bool isPrimary
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x3036110", Offset = "0x3032110", VA = "0x3036110", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x3036118", Offset = "0x3032118", VA = "0x3036118")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000171")]
			public int button
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x3036120", Offset = "0x3032120", VA = "0x3036120", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005B4")]
				[Address(RVA = "0x3036128", Offset = "0x3032128", VA = "0x3036128")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000172")]
			public int pressedButtons
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x3036130", Offset = "0x3032130", VA = "0x3036130", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005B6")]
				[Address(RVA = "0x3036138", Offset = "0x3032138", VA = "0x3036138")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000173")]
			public Vector3 position
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0x3036140", Offset = "0x3032140", VA = "0x3036140", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x303614C", Offset = "0x303214C", VA = "0x303614C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000174")]
			public Vector3 localPosition
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x3036158", Offset = "0x3032158", VA = "0x3036158", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x3036164", Offset = "0x3032164", VA = "0x3036164")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000175")]
			public Vector3 deltaPosition
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x3036170", Offset = "0x3032170", VA = "0x3036170", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x303617C", Offset = "0x303217C", VA = "0x303617C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000176")]
			public float deltaTime
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x3036188", Offset = "0x3032188", VA = "0x3036188", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x3036190", Offset = "0x3032190", VA = "0x3036190")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000177")]
			public int clickCount
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x3036198", Offset = "0x3032198", VA = "0x3036198", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x30361A0", Offset = "0x30321A0", VA = "0x30361A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000178")]
			public float pressure
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x30361A8", Offset = "0x30321A8", VA = "0x30361A8", Slot = "14")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x30361B0", Offset = "0x30321B0", VA = "0x30361B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000179")]
			public float tangentialPressure
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x30361B8", Offset = "0x30321B8", VA = "0x30361B8", Slot = "15")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x30361C0", Offset = "0x30321C0", VA = "0x30361C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700017A")]
			public float altitudeAngle
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x30361C8", Offset = "0x30321C8", VA = "0x30361C8", Slot = "16")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0x30361D0", Offset = "0x30321D0", VA = "0x30361D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700017B")]
			public float azimuthAngle
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x30361D8", Offset = "0x30321D8", VA = "0x30361D8", Slot = "17")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x30361E0", Offset = "0x30321E0", VA = "0x30361E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700017C")]
			public float twist
			{
				[Token(Token = "0x60005C9")]
				[Address(RVA = "0x30361E8", Offset = "0x30321E8", VA = "0x30361E8", Slot = "18")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x30361F0", Offset = "0x30321F0", VA = "0x30361F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700017D")]
			public Vector2 tilt
			{
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x30361F8", Offset = "0x30321F8", VA = "0x30361F8", Slot = "19")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x3036200", Offset = "0x3032200", VA = "0x3036200")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700017E")]
			public PenStatus penStatus
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x3036208", Offset = "0x3032208", VA = "0x3036208", Slot = "20")]
				[CompilerGenerated]
				get
				{
					return default(PenStatus);
				}
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x3036210", Offset = "0x3032210", VA = "0x3036210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700017F")]
			public Vector2 radius
			{
				[Token(Token = "0x60005CF")]
				[Address(RVA = "0x3036218", Offset = "0x3032218", VA = "0x3036218", Slot = "21")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x60005D0")]
				[Address(RVA = "0x3036220", Offset = "0x3032220", VA = "0x3036220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000180")]
			public Vector2 radiusVariance
			{
				[Token(Token = "0x60005D1")]
				[Address(RVA = "0x3036228", Offset = "0x3032228", VA = "0x3036228", Slot = "22")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x3036230", Offset = "0x3032230", VA = "0x3036230")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000181")]
			public EventModifiers modifiers
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x3036238", Offset = "0x3032238", VA = "0x3036238", Slot = "23")]
				[CompilerGenerated]
				get
				{
					return default(EventModifiers);
				}
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x3036240", Offset = "0x3032240", VA = "0x3036240")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000182")]
			public bool shiftKey
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x3036248", Offset = "0x3032248", VA = "0x3036248", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000183")]
			public bool ctrlKey
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x3036254", Offset = "0x3032254", VA = "0x3036254", Slot = "25")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000184")]
			public bool commandKey
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x3036260", Offset = "0x3032260", VA = "0x3036260", Slot = "26")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000185")]
			public bool altKey
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x303626C", Offset = "0x303226C", VA = "0x303626C", Slot = "27")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000186")]
			public bool actionKey
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x3036278", Offset = "0x3032278", VA = "0x3036278", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x3035B78", Offset = "0x3031B78", VA = "0x3035B78")]
			public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x3036034", Offset = "0x3032034", VA = "0x3036034")]
			public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x30360E0", Offset = "0x30320E0", VA = "0x30360E0")]
			public PointerEvent()
			{
			}
		}

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		private UnityEngine.UIElements.BaseRuntimePanel m_Panel;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x28")]
		private readonly PointerEvent m_PointerEvent;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x30")]
		private float m_LastClickTime;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x34")]
		private bool m_Selecting;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x38")]
		private Event m_Event;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		private static EventModifiers s_Modifiers;

		[Token(Token = "0x17000169")]
		public IPanel panel
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x3033AB0", Offset = "0x302FAB0", VA = "0x3033AB0", Slot = "30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x3033AB8", Offset = "0x302FAB8", VA = "0x3033AB8", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		private GameObject selectableGameObject
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x3033EC4", Offset = "0x302FEC4", VA = "0x3033EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private EventSystem eventSystem
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x3033EDC", Offset = "0x302FEDC", VA = "0x3033EDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		private bool isCurrentFocusedPanel
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x3033FB0", Offset = "0x302FFB0", VA = "0x3033FB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016D")]
		private Focusable currentFocusedElement
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x3034078", Offset = "0x3030078", VA = "0x3034078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x30340B0", Offset = "0x30300B0", VA = "0x30340B0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x30340B8", Offset = "0x30300B8", VA = "0x30340B8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x3033D10", Offset = "0x302FD10", VA = "0x3033D10")]
		private void RegisterCallbacks()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x3033B5C", Offset = "0x302FB5C", VA = "0x3033B5C")]
		private void UnregisterCallbacks()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x30340C0", Offset = "0x30300C0", VA = "0x30340C0")]
		private void OnPanelDestroyed()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x30340C8", Offset = "0x30300C8", VA = "0x30340C8")]
		private void OnElementFocus(FocusEvent e)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x30341B0", Offset = "0x30301B0", VA = "0x30341B0")]
		private void OnElementBlur(BlurEvent e)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x30341B4", Offset = "0x30301B4", VA = "0x30341B4", Slot = "24")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x303422C", Offset = "0x303022C", VA = "0x303422C", Slot = "25")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x3034240", Offset = "0x3030240", VA = "0x3034240", Slot = "17")]
		public void OnPointerMove(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x303453C", Offset = "0x303053C", VA = "0x303453C", Slot = "18")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x3034704", Offset = "0x3030704", VA = "0x3034704", Slot = "19")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x3034944", Offset = "0x3030944", VA = "0x3034944", Slot = "26")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x3034C10", Offset = "0x3030C10", VA = "0x3034C10", Slot = "27")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x3034C64", Offset = "0x3030C64", VA = "0x3034C64", Slot = "29")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x3034C80", Offset = "0x3030C80", VA = "0x3034C80", Slot = "20")]
		public void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x3034F84", Offset = "0x3030F84", VA = "0x3034F84", Slot = "21")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x3035140", Offset = "0x3031140", VA = "0x3035140", Slot = "22")]
		public void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x3035328", Offset = "0x3031328", VA = "0x3035328", Slot = "23")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x30344D8", Offset = "0x30304D8", VA = "0x30344D8")]
		private void SendEvent(EventBase e, BaseEventData sourceEventData)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x30354C8", Offset = "0x30314C8", VA = "0x30354C8")]
		private void SendEvent(EventBase e, Event sourceEvent)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x30354E4", Offset = "0x30314E4", VA = "0x30354E4")]
		internal void Update()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x3035540", Offset = "0x3031540", VA = "0x3035540")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x3034E3C", Offset = "0x3030E3C", VA = "0x3034E3C")]
		private void ProcessImguiEvents(Focusable target)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x3035548", Offset = "0x3031548", VA = "0x3035548")]
		private void ProcessKeyboardEvent(Event e, Focusable target)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x30355C8", Offset = "0x30315C8", VA = "0x30355C8")]
		private void ProcessTabEvent(Event e, Focusable target)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x30359D0", Offset = "0x30319D0", VA = "0x30359D0")]
		private void SendTabEvent(Event e, NavigationMoveEvent.Direction direction, Focusable target)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x3035630", Offset = "0x3031630", VA = "0x3035630")]
		private void SendKeyUpEvent(Event e, Focusable target)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x3035800", Offset = "0x3031800", VA = "0x3035800")]
		private void SendKeyDownEvent(Event e, Focusable target)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x3034398", Offset = "0x3030398", VA = "0x3034398")]
		private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = PointerEventType.Default)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x303604C", Offset = "0x303204C", VA = "0x303604C")]
		public PanelEventHandler()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
	public class PanelRaycaster : BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
	{
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x28")]
		private UnityEngine.UIElements.BaseRuntimePanel m_Panel;

		[Token(Token = "0x17000187")]
		public IPanel panel
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x3036320", Offset = "0x3032320", VA = "0x3036320", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x3036328", Offset = "0x3032328", VA = "0x3036328", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		private GameObject selectableGameObject
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x30364F4", Offset = "0x30324F4", VA = "0x30364F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x303650C", Offset = "0x303250C", VA = "0x303650C", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018A")]
		public override int renderOrderPriority
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x3036588", Offset = "0x3032588", VA = "0x3036588", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018B")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x3036A1C", Offset = "0x3032A1C", VA = "0x3036A1C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x303645C", Offset = "0x303245C", VA = "0x303645C")]
		private void RegisterCallbacks()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x30363CC", Offset = "0x30323CC", VA = "0x30363CC")]
		private void UnregisterCallbacks()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x30364EC", Offset = "0x30324EC", VA = "0x30364EC")]
		private void OnPanelDestroyed()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x30365FC", Offset = "0x30325FC", VA = "0x30365FC", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x3036A24", Offset = "0x3032A24", VA = "0x3036A24")]
		public PanelRaycaster()
		{
		}
	}
}
namespace UnityEngine.EventSystems
{
	[Token(Token = "0x2000096")]
	public class AxisEventData : BaseEventData
	{
		[Token(Token = "0x1700018C")]
		public Vector2 moveVector
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x3036A34", Offset = "0x3032A34", VA = "0x3036A34")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x3036A3C", Offset = "0x3032A3C", VA = "0x3036A3C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public MoveDirection moveDir
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x3036A44", Offset = "0x3032A44", VA = "0x3036A44")]
			[CompilerGenerated]
			get
			{
				return default(MoveDirection);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x3036A4C", Offset = "0x3032A4C", VA = "0x3036A4C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x3036A54", Offset = "0x3032A54", VA = "0x3036A54")]
		public AxisEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x2000097")]
	public abstract class AbstractEventData
	{
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_Used;

		[Token(Token = "0x1700018E")]
		public virtual bool used
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x3036AF8", Offset = "0x3032AF8", VA = "0x3036AF8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x3036AE4", Offset = "0x3032AE4", VA = "0x3036AE4", Slot = "4")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x3036AEC", Offset = "0x3032AEC", VA = "0x3036AEC", Slot = "5")]
		public virtual void Use()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x3036B00", Offset = "0x3032B00", VA = "0x3036B00")]
		protected AbstractEventData()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class BaseEventData : AbstractEventData
	{
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x18")]
		private readonly EventSystem m_EventSystem;

		[Token(Token = "0x1700018F")]
		public BaseInputModule currentInputModule
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x3036B08", Offset = "0x3032B08", VA = "0x3036B08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		public GameObject selectedObject
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x3036B20", Offset = "0x3032B20", VA = "0x3036B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x3036B38", Offset = "0x3032B38", VA = "0x3036B38")]
			set
			{
			}
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x3036ABC", Offset = "0x3032ABC", VA = "0x3036ABC")]
		public BaseEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class PointerEventData : BaseEventData
	{
		[Token(Token = "0x200009A")]
		public enum InputButton
		{
			[Token(Token = "0x40002D2")]
			Left,
			[Token(Token = "0x40002D3")]
			Right,
			[Token(Token = "0x40002D4")]
			Middle
		}

		[Token(Token = "0x200009B")]
		public enum FramePressState
		{
			[Token(Token = "0x40002D6")]
			Pressed,
			[Token(Token = "0x40002D7")]
			Released,
			[Token(Token = "0x40002D8")]
			PressedAndReleased,
			[Token(Token = "0x40002D9")]
			NotChanged
		}

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_PointerPress;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xF0")]
		public List<GameObject> hovered;

		[Token(Token = "0x17000191")]
		public GameObject pointerEnter
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x3036D74", Offset = "0x3032D74", VA = "0x3036D74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x3036D7C", Offset = "0x3032D7C", VA = "0x3036D7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public GameObject lastPress
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x3036D84", Offset = "0x3032D84", VA = "0x3036D84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x3036D8C", Offset = "0x3032D8C", VA = "0x3036D8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public GameObject rawPointerPress
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x3036D94", Offset = "0x3032D94", VA = "0x3036D94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x3036D9C", Offset = "0x3032D9C", VA = "0x3036D9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public GameObject pointerDrag
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x3036DA4", Offset = "0x3032DA4", VA = "0x3036DA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x3036DAC", Offset = "0x3032DAC", VA = "0x3036DAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public GameObject pointerClick
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x3036DB4", Offset = "0x3032DB4", VA = "0x3036DB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x3036DBC", Offset = "0x3032DBC", VA = "0x3036DBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public RaycastResult pointerCurrentRaycast
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x3036DC4", Offset = "0x3032DC4", VA = "0x3036DC4")]
			[CompilerGenerated]
			get
			{
				return default(RaycastResult);
			}
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x3036DD4", Offset = "0x3032DD4", VA = "0x3036DD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public RaycastResult pointerPressRaycast
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x3036DE0", Offset = "0x3032DE0", VA = "0x3036DE0")]
			[CompilerGenerated]
			get
			{
				return default(RaycastResult);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x3036DF0", Offset = "0x3032DF0", VA = "0x3036DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public bool eligibleForClick
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x3036DFC", Offset = "0x3032DFC", VA = "0x3036DFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x3036E04", Offset = "0x3032E04", VA = "0x3036E04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public int displayIndex
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x3036E0C", Offset = "0x3032E0C", VA = "0x3036E0C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x3036E14", Offset = "0x3032E14", VA = "0x3036E14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public int pointerId
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x3036E1C", Offset = "0x3032E1C", VA = "0x3036E1C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x3036E24", Offset = "0x3032E24", VA = "0x3036E24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public Vector2 position
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x3036E2C", Offset = "0x3032E2C", VA = "0x3036E2C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x3036E38", Offset = "0x3032E38", VA = "0x3036E38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public Vector2 delta
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x3036E44", Offset = "0x3032E44", VA = "0x3036E44")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x3036E50", Offset = "0x3032E50", VA = "0x3036E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public Vector2 pressPosition
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x3036E5C", Offset = "0x3032E5C", VA = "0x3036E5C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x3036E68", Offset = "0x3032E68", VA = "0x3036E68")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x3036E74", Offset = "0x3032E74", VA = "0x3036E74")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x3036E84", Offset = "0x3032E84", VA = "0x3036E84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x3036E94", Offset = "0x3032E94", VA = "0x3036E94")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x3036EA4", Offset = "0x3032EA4", VA = "0x3036EA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public float clickTime
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x3036EB4", Offset = "0x3032EB4", VA = "0x3036EB4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x3036EBC", Offset = "0x3032EBC", VA = "0x3036EBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public int clickCount
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x3036EC4", Offset = "0x3032EC4", VA = "0x3036EC4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x3036ECC", Offset = "0x3032ECC", VA = "0x3036ECC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public Vector2 scrollDelta
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x3036ED4", Offset = "0x3032ED4", VA = "0x3036ED4")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x3036EE0", Offset = "0x3032EE0", VA = "0x3036EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		public bool useDragThreshold
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x3036EEC", Offset = "0x3032EEC", VA = "0x3036EEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x3036EF4", Offset = "0x3032EF4", VA = "0x3036EF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public bool dragging
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x3036EFC", Offset = "0x3032EFC", VA = "0x3036EFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x3036F04", Offset = "0x3032F04", VA = "0x3036F04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public InputButton button
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x3036F0C", Offset = "0x3032F0C", VA = "0x3036F0C")]
			[CompilerGenerated]
			get
			{
				return default(InputButton);
			}
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x3036F14", Offset = "0x3032F14", VA = "0x3036F14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A6")]
		public float pressure
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x3036F1C", Offset = "0x3032F1C", VA = "0x3036F1C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x3036F24", Offset = "0x3032F24", VA = "0x3036F24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A7")]
		public float tangentialPressure
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x3036F2C", Offset = "0x3032F2C", VA = "0x3036F2C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x3036F34", Offset = "0x3032F34", VA = "0x3036F34")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A8")]
		public float altitudeAngle
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x3036F3C", Offset = "0x3032F3C", VA = "0x3036F3C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x3036F44", Offset = "0x3032F44", VA = "0x3036F44")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		public float azimuthAngle
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x3036F4C", Offset = "0x3032F4C", VA = "0x3036F4C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x3036F54", Offset = "0x3032F54", VA = "0x3036F54")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public float twist
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x3036F5C", Offset = "0x3032F5C", VA = "0x3036F5C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x3036F64", Offset = "0x3032F64", VA = "0x3036F64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public Vector2 tilt
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x3036F6C", Offset = "0x3032F6C", VA = "0x3036F6C")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x3036F78", Offset = "0x3032F78", VA = "0x3036F78")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public PenStatus penStatus
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x3036F84", Offset = "0x3032F84", VA = "0x3036F84")]
			[CompilerGenerated]
			get
			{
				return default(PenStatus);
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x3036F8C", Offset = "0x3032F8C", VA = "0x3036F8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public Vector2 radius
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x3036F94", Offset = "0x3032F94", VA = "0x3036F94")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x3036FA0", Offset = "0x3032FA0", VA = "0x3036FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public Vector2 radiusVariance
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x3036FAC", Offset = "0x3032FAC", VA = "0x3036FAC")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x3036FB8", Offset = "0x3032FB8", VA = "0x3036FB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		public bool fullyExited
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x3036FC4", Offset = "0x3032FC4", VA = "0x3036FC4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x3036FCC", Offset = "0x3032FCC", VA = "0x3036FCC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public bool reentered
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x3036FD4", Offset = "0x3032FD4", VA = "0x3036FD4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x3036FDC", Offset = "0x3032FDC", VA = "0x3036FDC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public Camera enterEventCamera
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x303713C", Offset = "0x303313C", VA = "0x303713C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		public Camera pressEventCamera
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x30371CC", Offset = "0x30331CC", VA = "0x30371CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		public GameObject pointerPress
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x303725C", Offset = "0x303325C", VA = "0x303725C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x3037264", Offset = "0x3033264", VA = "0x3037264")]
			set
			{
			}
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x3036FE4", Offset = "0x3032FE4", VA = "0x3036FE4")]
		public PointerEventData(EventSystem eventSystem)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x30370FC", Offset = "0x30330FC", VA = "0x30370FC")]
		public bool IsPointerMoving()
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x303711C", Offset = "0x303311C", VA = "0x303711C")]
		public bool IsScrolling()
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x30372E0", Offset = "0x30332E0", VA = "0x30372E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009C")]
	[Flags]
	public enum EventHandle
	{
		[Token(Token = "0x40002DB")]
		Unused = 0,
		[Token(Token = "0x40002DC")]
		Used = 1
	}
	[Token(Token = "0x200009D")]
	public interface IEventSystemHandler
	{
	}
	[Token(Token = "0x200009E")]
	public interface IPointerMoveHandler : IEventSystemHandler
	{
		[Token(Token = "0x600063E")]
		void OnPointerMove(PointerEventData eventData);
	}
	[Token(Token = "0x200009F")]
	public interface IPointerEnterHandler : IEventSystemHandler
	{
		[Token(Token = "0x600063F")]
		void OnPointerEnter(PointerEventData eventData);
	}
	[Token(Token = "0x20000A0")]
	public interface IPointerExitHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000640")]
		void OnPointerExit(PointerEventData eventData);
	}
	[Token(Token = "0x20000A1")]
	public interface IPointerDownHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000641")]
		void OnPointerDown(PointerEventData eventData);
	}
	[Token(Token = "0x20000A2")]
	public interface IPointerUpHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000642")]
		void OnPointerUp(PointerEventData eventData);
	}
	[Token(Token = "0x20000A3")]
	public interface IPointerClickHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000643")]
		void OnPointerClick(PointerEventData eventData);
	}
	[Token(Token = "0x20000A4")]
	public interface IBeginDragHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000644")]
		void OnBeginDrag(PointerEventData eventData);
	}
	[Token(Token = "0x20000A5")]
	public interface IInitializePotentialDragHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000645")]
		void OnInitializePotentialDrag(PointerEventData eventData);
	}
	[Token(Token = "0x20000A6")]
	public interface IDragHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000646")]
		void OnDrag(PointerEventData eventData);
	}
	[Token(Token = "0x20000A7")]
	public interface IEndDragHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000647")]
		void OnEndDrag(PointerEventData eventData);
	}
	[Token(Token = "0x20000A8")]
	public interface IDropHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000648")]
		void OnDrop(PointerEventData eventData);
	}
	[Token(Token = "0x20000A9")]
	public interface IScrollHandler : IEventSystemHandler
	{
		[Token(Token = "0x6000649")]
		void OnScroll(PointerEventData eventData);
	}
	[Token(Token = "0x20000AA")]
	public interface IUpdateSelectedHandler : IEventSystemHandler
	{
		[Token(Token = "0x600064A")]
		void OnUpdateSelected(BaseEventData eventData);
	}
	[Token(Token = "0x20000AB")]
	public interface ISelectHandler : IEventSystemHandler
	{
		[Token(Token = "0x600064B")]
		void OnSelect(BaseEventData eventData);
	}
	[Token(Token = "0x20000AC")]
	public interface IDeselectHandler : IEventSystemHandler
	{
		[Token(Token = "0x600064C")]
		void OnDeselect(BaseEventData eventData);
	}
	[Token(Token = "0x20000AD")]
	public interface IMoveHandler : IEventSystemHandler
	{
		[Token(Token = "0x600064D")]
		void OnMove(AxisEventData eventData);
	}
	[Token(Token = "0x20000AE")]
	public interface ISubmitHandler : IEventSystemHandler
	{
		[Token(Token = "0x600064E")]
		void OnSubmit(BaseEventData eventData);
	}
	[Token(Token = "0x20000AF")]
	public interface ICancelHandler : IEventSystemHandler
	{
		[Token(Token = "0x600064F")]
		void OnCancel(BaseEventData eventData);
	}
	[Token(Token = "0x20000B0")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Event/Event System")]
	public class EventSystem : UIBehaviour
	{
		[Token(Token = "0x20000B1")]
		private struct UIToolkitOverrideConfig
		{
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x0")]
			public EventSystem activeEventSystem;

			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x8")]
			public bool sendEvents;

			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x9")]
			public bool createPanelGameObjectsOnStart;
		}

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x20")]
		private List<BaseInputModule> m_SystemInputModules;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x28")]
		private BaseInputModule m_CurrentInputModule;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x0")]
		private static List<EventSystem> m_EventSystems;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("m_Selected")]
		[SerializeField]
		private GameObject m_FirstSelected;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_sendNavigationEvents;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int m_DragThreshold;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_CurrentSelected;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x48")]
		private bool m_HasFocus;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x49")]
		private bool m_SelectionGuard;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x50")]
		private BaseEventData m_DummyData;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Comparison<RaycastResult> s_RaycastComparer;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x10")]
		private static UIToolkitOverrideConfig s_UIToolkitOverride;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Started;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x59")]
		private bool m_IsTrackingUIToolkitPanels;

		[Token(Token = "0x170001B4")]
		public static EventSystem current
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x3037E3C", Offset = "0x3033E3C", VA = "0x3037E3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x3037F00", Offset = "0x3033F00", VA = "0x3037F00")]
			set
			{
			}
		}

		[Token(Token = "0x170001B5")]
		public bool sendNavigationEvents
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x3038094", Offset = "0x3034094", VA = "0x3038094")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x303809C", Offset = "0x303409C", VA = "0x303809C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		public int pixelDragThreshold
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x30380A4", Offset = "0x30340A4", VA = "0x30380A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x30380AC", Offset = "0x30340AC", VA = "0x30380AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public BaseInputModule currentInputModule
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x30380B4", Offset = "0x30340B4", VA = "0x30380B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B8")]
		public GameObject firstSelectedGameObject
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x30380BC", Offset = "0x30340BC", VA = "0x30380BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x30380C4", Offset = "0x30340C4", VA = "0x30380C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public GameObject currentSelectedGameObject
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x30380CC", Offset = "0x30340CC", VA = "0x30380CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BA")]
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x30380D4", Offset = "0x30340D4", VA = "0x30380D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BB")]
		public bool isFocused
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x30380DC", Offset = "0x30340DC", VA = "0x30380DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BC")]
		public bool alreadySelecting
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x30382B8", Offset = "0x30342B8", VA = "0x30382B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BD")]
		private BaseEventData baseEventDataCache
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x30382C0", Offset = "0x30342C0", VA = "0x30382C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		private bool isUIToolkitActiveEventSystem
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x3038A68", Offset = "0x3034A68", VA = "0x3038A68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BF")]
		private bool sendUIToolkitEvents
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x3038B58", Offset = "0x3034B58", VA = "0x3038B58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C0")]
		private bool createUIToolkitPanelGameObjectsOnStart
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x3038BCC", Offset = "0x3034BCC", VA = "0x3038BCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x30380E4", Offset = "0x30340E4", VA = "0x30380E4")]
		protected EventSystem()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x3038174", Offset = "0x3034174", VA = "0x3038174")]
		public void UpdateModules()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x3036B50", Offset = "0x3032B50", VA = "0x3036B50")]
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x3034184", Offset = "0x3030184", VA = "0x3034184")]
		public void SetSelectedGameObject(GameObject selected)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x3038328", Offset = "0x3034328", VA = "0x3038328")]
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			return default(int);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x30387CC", Offset = "0x30347CC", VA = "0x30387CC")]
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x30389BC", Offset = "0x30349BC", VA = "0x30389BC")]
		public bool IsPointerOverGameObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x30389C4", Offset = "0x30349C4", VA = "0x30389C4")]
		public bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x3038C40", Offset = "0x3034C40", VA = "0x3038C40")]
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x3038DCC", Offset = "0x3034DCC", VA = "0x3038DCC")]
		private void StartTrackingUIToolkitPanels()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x3039288", Offset = "0x3035288", VA = "0x3039288")]
		private void StopTrackingUIToolkitPanels()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x3038FF0", Offset = "0x3034FF0", VA = "0x3038FF0")]
		private void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x303933C", Offset = "0x303533C", VA = "0x303933C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x303934C", Offset = "0x303534C", VA = "0x303934C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x3039470", Offset = "0x3035470", VA = "0x3039470", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x3039580", Offset = "0x3035580", VA = "0x3039580")]
		private void TickModules()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x3039680", Offset = "0x3035680", VA = "0x3039680", Slot = "17")]
		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x3039690", Offset = "0x3035690", VA = "0x3039690", Slot = "18")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x30398F8", Offset = "0x30358F8", VA = "0x30398F8")]
		private void ChangeEventModule(BaseInputModule module)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x30399F0", Offset = "0x30359F0", VA = "0x30399F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x3039EDC", Offset = "0x3035EDC", VA = "0x3039EDC")]
			public TriggerEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Entry
		{
			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x10")]
			public EventTriggerType eventID;

			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x18")]
			public TriggerEvent callback;

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x3039F24", Offset = "0x3035F24", VA = "0x3039F24")]
			public Entry()
			{
			}
		}

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("delegates")]
		[SerializeField]
		private List<Entry> m_Delegates;

		[Token(Token = "0x170001C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		public List<Entry> delegates
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x3039C98", Offset = "0x3035C98", VA = "0x3039C98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x3039D14", Offset = "0x3035D14", VA = "0x3039D14")]
			set
			{
			}
		}

		[Token(Token = "0x170001C2")]
		public List<Entry> triggers
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x3039C9C", Offset = "0x3035C9C", VA = "0x3039C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x3039D24", Offset = "0x3035D24", VA = "0x3039D24")]
			set
			{
			}
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x3039D1C", Offset = "0x3035D1C", VA = "0x3039D1C")]
		protected EventTrigger()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x3039D2C", Offset = "0x3035D2C", VA = "0x3039D2C")]
		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x3039E10", Offset = "0x3035E10", VA = "0x3039E10", Slot = "21")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x3039E1C", Offset = "0x3035E1C", VA = "0x3039E1C", Slot = "22")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x3039E28", Offset = "0x3035E28", VA = "0x3039E28", Slot = "23")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x3039E34", Offset = "0x3035E34", VA = "0x3039E34", Slot = "24")]
		public virtual void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x3039E40", Offset = "0x3035E40", VA = "0x3039E40", Slot = "25")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x3039E4C", Offset = "0x3035E4C", VA = "0x3039E4C", Slot = "26")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x3039E58", Offset = "0x3035E58", VA = "0x3039E58", Slot = "27")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x3039E64", Offset = "0x3035E64", VA = "0x3039E64", Slot = "28")]
		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x3039E70", Offset = "0x3035E70", VA = "0x3039E70", Slot = "29")]
		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x3039E7C", Offset = "0x3035E7C", VA = "0x3039E7C", Slot = "30")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x3039E88", Offset = "0x3035E88", VA = "0x3039E88", Slot = "31")]
		public virtual void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x3039E94", Offset = "0x3035E94", VA = "0x3039E94", Slot = "32")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x3039EA0", Offset = "0x3035EA0", VA = "0x3039EA0", Slot = "33")]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x3039EAC", Offset = "0x3035EAC", VA = "0x3039EAC", Slot = "34")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x3039EB8", Offset = "0x3035EB8", VA = "0x3039EB8", Slot = "35")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x3039EC4", Offset = "0x3035EC4", VA = "0x3039EC4", Slot = "36")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x3039ED0", Offset = "0x3035ED0", VA = "0x3039ED0", Slot = "37")]
		public virtual void OnCancel(BaseEventData eventData)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public enum EventTriggerType
	{
		[Token(Token = "0x40002F3")]
		PointerEnter,
		[Token(Token = "0x40002F4")]
		PointerExit,
		[Token(Token = "0x40002F5")]
		PointerDown,
		[Token(Token = "0x40002F6")]
		PointerUp,
		[Token(Token = "0x40002F7")]
		PointerClick,
		[Token(Token = "0x40002F8")]
		Drag,
		[Token(Token = "0x40002F9")]
		Drop,
		[Token(Token = "0x40002FA")]
		Scroll,
		[Token(Token = "0x40002FB")]
		UpdateSelected,
		[Token(Token = "0x40002FC")]
		Select,
		[Token(Token = "0x40002FD")]
		Deselect,
		[Token(Token = "0x40002FE")]
		Move,
		[Token(Token = "0x40002FF")]
		InitializePotentialDrag,
		[Token(Token = "0x4000300")]
		BeginDrag,
		[Token(Token = "0x4000301")]
		EndDrag,
		[Token(Token = "0x4000302")]
		Submit,
		[Token(Token = "0x4000303")]
		Cancel
	}
	[Token(Token = "0x20000B7")]
	public static class ExecuteEvents
	{
		[Token(Token = "0x20000B8")]
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EventFunction<IPointerMoveHandler> s_PointerMoveHandler;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x8")]
		private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x10")]
		private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x18")]
		private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x20")]
		private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x28")]
		private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x30")]
		private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x38")]
		private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x40")]
		private static readonly EventFunction<IDragHandler> s_DragHandler;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x48")]
		private static readonly EventFunction<IEndDragHandler> s_EndDragHandler;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x50")]
		private static readonly EventFunction<IDropHandler> s_DropHandler;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x58")]
		private static readonly EventFunction<IScrollHandler> s_ScrollHandler;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x60")]
		private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x68")]
		private static readonly EventFunction<ISelectHandler> s_SelectHandler;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x70")]
		private static readonly EventFunction<IDeselectHandler> s_DeselectHandler;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x78")]
		private static readonly EventFunction<IMoveHandler> s_MoveHandler;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x80")]
		private static readonly EventFunction<ISubmitHandler> s_SubmitHandler;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x88")]
		private static readonly EventFunction<ICancelHandler> s_CancelHandler;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x90")]
		private static readonly List<Transform> s_InternalTransformList;

		[Token(Token = "0x170001C3")]
		public static EventFunction<IPointerMoveHandler> pointerMoveHandler
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x303AF20", Offset = "0x3036F20", VA = "0x303AF20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C4")]
		public static EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x303AF78", Offset = "0x3036F78", VA = "0x303AF78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		public static EventFunction<IPointerExitHandler> pointerExitHandler
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x303AFD0", Offset = "0x3036FD0", VA = "0x303AFD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		public static EventFunction<IPointerDownHandler> pointerDownHandler
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x303B028", Offset = "0x3037028", VA = "0x303B028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		public static EventFunction<IPointerUpHandler> pointerUpHandler
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x303B080", Offset = "0x3037080", VA = "0x303B080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C8")]
		public static EventFunction<IPointerClickHandler> pointerClickHandler
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x303B0D8", Offset = "0x30370D8", VA = "0x303B0D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C9")]
		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x303B130", Offset = "0x3037130", VA = "0x303B130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CA")]
		public static EventFunction<IBeginDragHandler> beginDragHandler
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x303B188", Offset = "0x3037188", VA = "0x303B188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CB")]
		public static EventFunction<IDragHandler> dragHandler
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x303B1E0", Offset = "0x30371E0", VA = "0x303B1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CC")]
		public static EventFunction<IEndDragHandler> endDragHandler
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x303B238", Offset = "0x3037238", VA = "0x303B238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		public static EventFunction<IDropHandler> dropHandler
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x303B290", Offset = "0x3037290", VA = "0x303B290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CE")]
		public static EventFunction<IScrollHandler> scrollHandler
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x303B2E8", Offset = "0x30372E8", VA = "0x303B2E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CF")]
		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x303B340", Offset = "0x3037340", VA = "0x303B340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D0")]
		public static EventFunction<ISelectHandler> selectHandler
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x303B398", Offset = "0x3037398", VA = "0x303B398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D1")]
		public static EventFunction<IDeselectHandler> deselectHandler
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x303B3F0", Offset = "0x30373F0", VA = "0x303B3F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D2")]
		public static EventFunction<IMoveHandler> moveHandler
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x303B448", Offset = "0x3037448", VA = "0x303B448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D3")]
		public static EventFunction<ISubmitHandler> submitHandler
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x303B4A0", Offset = "0x30374A0", VA = "0x303B4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D4")]
		public static EventFunction<ICancelHandler> cancelHandler
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x303B4F8", Offset = "0x30374F8", VA = "0x303B4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000691")]
		public static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x3039F88", Offset = "0x3035F88", VA = "0x3039F88")]
		private static void Execute(IPointerMoveHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x303A07C", Offset = "0x303607C", VA = "0x303A07C")]
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x303A170", Offset = "0x3036170", VA = "0x303A170")]
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x303A264", Offset = "0x3036264", VA = "0x303A264")]
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x303A358", Offset = "0x3036358", VA = "0x303A358")]
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x303A44C", Offset = "0x303644C", VA = "0x303A44C")]
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x303A540", Offset = "0x3036540", VA = "0x303A540")]
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x303A634", Offset = "0x3036634", VA = "0x303A634")]
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x303A728", Offset = "0x3036728", VA = "0x303A728")]
		private static void Execute(IDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x303A81C", Offset = "0x303681C", VA = "0x303A81C")]
		private static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x303A910", Offset = "0x3036910", VA = "0x303A910")]
		private static void Execute(IDropHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x303AA04", Offset = "0x3036A04", VA = "0x303AA04")]
		private static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x303AAF8", Offset = "0x3036AF8", VA = "0x303AAF8")]
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x303AB9C", Offset = "0x3036B9C", VA = "0x303AB9C")]
		private static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x303AC40", Offset = "0x3036C40", VA = "0x303AC40")]
		private static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x303ACE4", Offset = "0x3036CE4", VA = "0x303ACE4")]
		private static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x303ADD8", Offset = "0x3036DD8", VA = "0x303ADD8")]
		private static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x303AE7C", Offset = "0x3036E7C", VA = "0x303AE7C")]
		private static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x303B550", Offset = "0x3037550", VA = "0x303B550")]
		private static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
		}

		[Token(Token = "0x60006B7")]
		public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor) where T : IEventSystemHandler
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		private static bool ShouldSendToComponent<T>(Component component) where T : IEventSystemHandler
		{
			return default(bool);
		}

		[Token(Token = "0x60006BA")]
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) where T : IEventSystemHandler
		{
		}

		[Token(Token = "0x60006BB")]
		public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler
		{
			return default(bool);
		}

		[Token(Token = "0x60006BC")]
		public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	public class BaseInput : UIBehaviour
	{
		[Token(Token = "0x170001D5")]
		public virtual string compositionString
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x303BD2C", Offset = "0x3037D2C", VA = "0x303BD2C", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D6")]
		public virtual IMECompositionMode imeCompositionMode
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x303BD34", Offset = "0x3037D34", VA = "0x303BD34", Slot = "18")]
			get
			{
				return default(IMECompositionMode);
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x303BD3C", Offset = "0x3037D3C", VA = "0x303BD3C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public virtual Vector2 compositionCursorPos
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x303BD48", Offset = "0x3037D48", VA = "0x303BD48", Slot = "20")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x303BD50", Offset = "0x3037D50", VA = "0x303BD50", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public virtual bool mousePresent
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x303BD58", Offset = "0x3037D58", VA = "0x303BD58", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D9")]
		public virtual Vector2 mousePosition
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x303BD84", Offset = "0x3037D84", VA = "0x303BD84", Slot = "26")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170001DA")]
		public virtual Vector2 mouseScrollDelta
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x303BD8C", Offset = "0x3037D8C", VA = "0x303BD8C", Slot = "27")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x170001DB")]
		public virtual bool touchSupported
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x303BD94", Offset = "0x3037D94", VA = "0x303BD94", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001DC")]
		public virtual int touchCount
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x303BD9C", Offset = "0x3037D9C", VA = "0x303BD9C", Slot = "29")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x303BD60", Offset = "0x3037D60", VA = "0x303BD60", Slot = "23")]
		public virtual bool GetMouseButtonDown(int button)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x303BD6C", Offset = "0x3037D6C", VA = "0x303BD6C", Slot = "24")]
		public virtual bool GetMouseButtonUp(int button)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x303BD78", Offset = "0x3037D78", VA = "0x303BD78", Slot = "25")]
		public virtual bool GetMouseButton(int button)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x303BDA4", Offset = "0x3037DA4", VA = "0x303BDA4", Slot = "30")]
		public virtual Touch GetTouch(int index)
		{
			return default(Touch);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x303BDB0", Offset = "0x3037DB0", VA = "0x303BDB0", Slot = "31")]
		public virtual float GetAxisRaw(string axisName)
		{
			return default(float);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x303BDBC", Offset = "0x3037DBC", VA = "0x303BDBC", Slot = "32")]
		public virtual bool GetButtonDown(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x303BDC8", Offset = "0x3037DC8", VA = "0x303BDC8")]
		public BaseInput()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour
	{
		[NonSerialized]
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x20")]
		protected List<RaycastResult> m_RaycastResultCache;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_SendPointerHoverToParent;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x30")]
		private AxisEventData m_AxisEventData;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x38")]
		private EventSystem m_EventSystem;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x40")]
		private BaseEventData m_BaseEventData;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x48")]
		protected BaseInput m_InputOverride;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x50")]
		private BaseInput m_DefaultInput;

		[Token(Token = "0x170001DD")]
		internal bool sendPointerHoverToParent
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x303BDD0", Offset = "0x3037DD0", VA = "0x303BDD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x303BDD8", Offset = "0x3037DD8", VA = "0x303BDD8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public BaseInput input
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x303BDE0", Offset = "0x3037DE0", VA = "0x303BDE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DF")]
		public BaseInput inputOverride
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x303BFF8", Offset = "0x3037FF8", VA = "0x303BFF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x303C000", Offset = "0x3038000", VA = "0x303C000")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		protected EventSystem eventSystem
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x303C008", Offset = "0x3038008", VA = "0x303C008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x303C010", Offset = "0x3038010", VA = "0x303C010", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x303C068", Offset = "0x3038068", VA = "0x303C068", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60006DB")]
		public abstract void Process();

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x303C07C", Offset = "0x303807C", VA = "0x303C07C")]
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			return default(RaycastResult);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x303C180", Offset = "0x3038180", VA = "0x303C180")]
		protected static MoveDirection DetermineMoveDirection(float x, float y)
		{
			return default(MoveDirection);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x303C1D4", Offset = "0x30381D4", VA = "0x303C1D4")]
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			return default(MoveDirection);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x303C224", Offset = "0x3038224", VA = "0x303C224")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x303C398", Offset = "0x3038398", VA = "0x303C398")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x303CE24", Offset = "0x3038E24", VA = "0x303CE24", Slot = "18")]
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x303CF18", Offset = "0x3038F18", VA = "0x303CF18", Slot = "19")]
		protected virtual BaseEventData GetBaseEventData()
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x303CF94", Offset = "0x3038F94", VA = "0x303CF94", Slot = "20")]
		public virtual bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x303CF9C", Offset = "0x3038F9C", VA = "0x303CF9C", Slot = "21")]
		public virtual bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x303CFDC", Offset = "0x3038FDC", VA = "0x303CFDC", Slot = "22")]
		public virtual void DeactivateModule()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x303CFE0", Offset = "0x3038FE0", VA = "0x303CFE0", Slot = "23")]
		public virtual void ActivateModule()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x303CFE4", Offset = "0x3038FE4", VA = "0x303CFE4", Slot = "24")]
		public virtual void UpdateModule()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x303CFE8", Offset = "0x3038FE8", VA = "0x303CFE8", Slot = "25")]
		public virtual bool IsModuleSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x303CFF0", Offset = "0x3038FF0", VA = "0x303CFF0", Slot = "26")]
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			return default(int);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x303D07C", Offset = "0x303907C", VA = "0x303D07C")]
		protected BaseInputModule()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public abstract class PointerInputModule : BaseInputModule
	{
		[Token(Token = "0x20000BC")]
		protected class ButtonState
		{
			[Token(Token = "0x4000324")]
			[FieldOffset(Offset = "0x10")]
			private PointerEventData.InputButton m_Button;

			[Token(Token = "0x4000325")]
			[FieldOffset(Offset = "0x18")]
			private MouseButtonEventData m_EventData;

			[Token(Token = "0x170001E1")]
			public MouseButtonEventData eventData
			{
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x303E434", Offset = "0x303A434", VA = "0x303E434")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x303E43C", Offset = "0x303A43C", VA = "0x303E43C")]
				set
				{
				}
			}

			[Token(Token = "0x170001E2")]
			public PointerEventData.InputButton button
			{
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0x303E444", Offset = "0x303A444", VA = "0x303E444")]
				get
				{
					return default(PointerEventData.InputButton);
				}
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x303E44C", Offset = "0x303A44C", VA = "0x303E44C")]
				set
				{
				}
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x303E454", Offset = "0x303A454", VA = "0x303E454")]
			public ButtonState()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		protected class MouseState
		{
			[Token(Token = "0x4000326")]
			[FieldOffset(Offset = "0x10")]
			private List<ButtonState> m_TrackedButtons;

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x303E45C", Offset = "0x303A45C", VA = "0x303E45C")]
			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x303E52C", Offset = "0x303A52C", VA = "0x303E52C")]
			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x303E604", Offset = "0x303A604", VA = "0x303E604")]
			public ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				return null;
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x303D9F8", Offset = "0x30399F8", VA = "0x303D9F8")]
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x303E3B8", Offset = "0x303A3B8", VA = "0x303E3B8")]
			public MouseState()
			{
			}
		}

		[Token(Token = "0x20000BE")]
		public class MouseButtonEventData
		{
			[Token(Token = "0x4000327")]
			[FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			[Token(Token = "0x4000328")]
			[FieldOffset(Offset = "0x18")]
			public PointerEventData buttonData;

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x303E51C", Offset = "0x303A51C", VA = "0x303E51C")]
			public bool PressedThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x303E5F0", Offset = "0x303A5F0", VA = "0x303E5F0")]
			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x303E794", Offset = "0x303A794", VA = "0x303E794")]
			public MouseButtonEventData()
			{
			}
		}

		[Token(Token = "0x400031E")]
		public const int kMouseLeftId = -1;

		[Token(Token = "0x400031F")]
		public const int kMouseRightId = -2;

		[Token(Token = "0x4000320")]
		public const int kMouseMiddleId = -3;

		[Token(Token = "0x4000321")]
		public const int kFakeTouchesId = -4;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x58")]
		protected Dictionary<int, PointerEventData> m_PointerData;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x60")]
		private readonly MouseState m_MouseState;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x303D100", Offset = "0x3039100", VA = "0x303D100")]
		protected bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x303D1EC", Offset = "0x30391EC", VA = "0x303D1EC")]
		protected void RemovePointerData(PointerEventData data)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x303D248", Offset = "0x3039248", VA = "0x303D248")]
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x303D5A8", Offset = "0x30395A8", VA = "0x303D5A8")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x303D650", Offset = "0x3039650", VA = "0x303D650")]
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			return default(PointerEventData.FramePressState);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x303D6CC", Offset = "0x30396CC", VA = "0x303D6CC", Slot = "27")]
		protected virtual MouseState GetMousePointerEventData()
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x303D6E0", Offset = "0x30396E0", VA = "0x303D6E0", Slot = "28")]
		protected virtual MouseState GetMousePointerEventData(int id)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x303DA30", Offset = "0x3039A30", VA = "0x303DA30")]
		protected PointerEventData GetLastPointerEventData(int id)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x303DA4C", Offset = "0x3039A4C", VA = "0x303DA4C")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x303DA7C", Offset = "0x3039A7C", VA = "0x303DA7C", Slot = "29")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x303DAC0", Offset = "0x3039AC0", VA = "0x303DAC0", Slot = "30")]
		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x303DD80", Offset = "0x3039D80", VA = "0x303DD80", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x303DE1C", Offset = "0x3039E1C", VA = "0x303DE1C")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x303DFC8", Offset = "0x3039FC8", VA = "0x303DFC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x303E22C", Offset = "0x303A22C", VA = "0x303E22C")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x303E318", Offset = "0x303A318", VA = "0x303E318")]
		protected PointerInputModule()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AddComponentMenu("Event/Standalone Input Module")]
	public class StandaloneInputModule : PointerInputModule
	{
		[Token(Token = "0x20000C0")]
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			[Token(Token = "0x4000339")]
			Mouse,
			[Token(Token = "0x400033A")]
			Buttons
		}

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x68")]
		private float m_PrevActionTime;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 m_LastMoveVector;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x74")]
		private int m_ConsecutiveMoveCount;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_LastMousePosition;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_MousePosition;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x88")]
		private GameObject m_CurrentFocusedGameObject;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x90")]
		private PointerEventData m_InputPointerEvent;

		[Token(Token = "0x4000330")]
		private const float doubleClickTime = 0.3f;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string m_HorizontalAxis;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string m_VerticalAxis;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string m_SubmitButton;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_CancelButton;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float m_InputActionsPerSecond;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float m_RepeatDelay;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		private bool m_ForceModuleActive;

		[Token(Token = "0x170001E3")]
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public InputMode inputMode
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x303E850", Offset = "0x303A850", VA = "0x303E850")]
			get
			{
				return default(InputMode);
			}
		}

		[Token(Token = "0x170001E4")]
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x303E858", Offset = "0x303A858", VA = "0x303E858")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x303E860", Offset = "0x303A860", VA = "0x303E860")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x303E868", Offset = "0x303A868", VA = "0x303E868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x303E870", Offset = "0x303A870", VA = "0x303E870")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x303E878", Offset = "0x303A878", VA = "0x303E878")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x303E880", Offset = "0x303A880", VA = "0x303E880")]
			set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public float repeatDelay
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x303E888", Offset = "0x303A888", VA = "0x303E888")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x303E890", Offset = "0x303A890", VA = "0x303E890")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public string horizontalAxis
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x303E898", Offset = "0x303A898", VA = "0x303E898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x303E8A0", Offset = "0x303A8A0", VA = "0x303E8A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public string verticalAxis
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x303E8A8", Offset = "0x303A8A8", VA = "0x303E8A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x303E8B0", Offset = "0x303A8B0", VA = "0x303E8B0")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public string submitButton
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x303E8B8", Offset = "0x303A8B8", VA = "0x303E8B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x303E8C0", Offset = "0x303A8C0", VA = "0x303E8C0")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public string cancelButton
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x303E8C8", Offset = "0x303A8C8", VA = "0x303E8C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x303E8D0", Offset = "0x303A8D0", VA = "0x303E8D0")]
			set
			{
			}
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x303E79C", Offset = "0x303A79C", VA = "0x303E79C")]
		protected StandaloneInputModule()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x303E8D8", Offset = "0x303A8D8", VA = "0x303E8D8")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x303E8E0", Offset = "0x303A8E0", VA = "0x303E8E0", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x303E9B0", Offset = "0x303A9B0", VA = "0x303E9B0")]
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x303ED1C", Offset = "0x303AD1C", VA = "0x303ED1C", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x303EF30", Offset = "0x303AF30", VA = "0x303EF30", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x303F030", Offset = "0x303B030", VA = "0x303F030", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x303F034", Offset = "0x303B034", VA = "0x303F034", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x303F220", Offset = "0x303B220", VA = "0x303F220")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x303F800", Offset = "0x303B800", VA = "0x303F800")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x303F5EC", Offset = "0x303B5EC", VA = "0x303F5EC")]
		protected bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x303FEA0", Offset = "0x303BEA0", VA = "0x303FEA0")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x303F38C", Offset = "0x303B38C", VA = "0x303F38C")]
		protected bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x303F384", Offset = "0x303B384", VA = "0x303F384")]
		protected void ProcessMouseEvent()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x3040254", Offset = "0x303C254", VA = "0x3040254", Slot = "31")]
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect()
		{
			return default(bool);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x303FFAC", Offset = "0x303BFAC", VA = "0x303FFAC")]
		protected void ProcessMouseEvent(int id)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x303F0D8", Offset = "0x303B0D8", VA = "0x303F0D8")]
		protected bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x304025C", Offset = "0x303C25C", VA = "0x304025C")]
		protected void ProcessMousePress(MouseButtonEventData data)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x30405DC", Offset = "0x303C5DC", VA = "0x30405DC")]
		protected GameObject GetCurrentFocusedGameObject()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	[AddComponentMenu("Event/Touch Input Module")]
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	public class TouchInputModule : PointerInputModule
	{
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_LastMousePosition;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_MousePosition;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x78")]
		private PointerEventData m_InputPointerEvent;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnStandalone")]
		private bool m_ForceModuleActive;

		[Token(Token = "0x170001EC")]
		[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnStandalone
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x30405E8", Offset = "0x303C5E8", VA = "0x30405E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x30405F0", Offset = "0x303C5F0", VA = "0x30405F0")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x30405F8", Offset = "0x303C5F8", VA = "0x30405F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x3040600", Offset = "0x303C600", VA = "0x3040600")]
			set
			{
			}
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x30405E4", Offset = "0x303C5E4", VA = "0x30405E4")]
		protected TouchInputModule()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x3040608", Offset = "0x303C608", VA = "0x3040608", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x3040758", Offset = "0x303C758", VA = "0x3040758", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x3040790", Offset = "0x303C790", VA = "0x3040790", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x304083C", Offset = "0x303C83C", VA = "0x304083C")]
		private bool UseFakeInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x304086C", Offset = "0x303C86C", VA = "0x304086C", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x3040894", Offset = "0x303C894", VA = "0x3040894")]
		private void FakeTouches()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x30409C0", Offset = "0x303C9C0", VA = "0x30409C0")]
		private void ProcessTouchEvents()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x3040B04", Offset = "0x303CB04", VA = "0x3040B04")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x3041194", Offset = "0x303D194", VA = "0x3041194", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x3041198", Offset = "0x303D198", VA = "0x3041198", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C2")]
	public enum MoveDirection
	{
		[Token(Token = "0x4000340")]
		Left,
		[Token(Token = "0x4000341")]
		Up,
		[Token(Token = "0x4000342")]
		Right,
		[Token(Token = "0x4000343")]
		Down,
		[Token(Token = "0x4000344")]
		None
	}
	[Token(Token = "0x20000C3")]
	public static class RaycasterManager
	{
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<BaseRaycaster> s_Raycasters;

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x30413D4", Offset = "0x303D3D4", VA = "0x30413D4")]
		internal static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x30414E4", Offset = "0x303D4E4", VA = "0x30414E4")]
		public static List<BaseRaycaster> GetRaycasters()
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x304153C", Offset = "0x303D53C", VA = "0x304153C")]
		internal static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public abstract class BaseRaycaster : UIBehaviour
	{
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x20")]
		private BaseRaycaster m_RootRaycaster;

		[Token(Token = "0x170001EE")]
		public abstract Camera eventCamera
		{
			[Token(Token = "0x6000740")]
			get;
		}

		[Token(Token = "0x170001EF")]
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x3041698", Offset = "0x303D698", VA = "0x3041698", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F0")]
		public virtual int sortOrderPriority
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x30416A0", Offset = "0x303D6A0", VA = "0x30416A0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F1")]
		public virtual int renderOrderPriority
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x30416A8", Offset = "0x303D6A8", VA = "0x30416A8", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F2")]
		public BaseRaycaster rootRaycaster
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x3038714", Offset = "0x3034714", VA = "0x3038714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073F")]
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x30416B0", Offset = "0x303D6B0", VA = "0x30416B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x3041878", Offset = "0x303D878", VA = "0x3041878", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x30418CC", Offset = "0x303D8CC", VA = "0x30418CC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x3041920", Offset = "0x303D920", VA = "0x3041920", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x304192C", Offset = "0x303D92C", VA = "0x304192C", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x3036A2C", Offset = "0x3032A2C", VA = "0x3036A2C")]
		protected BaseRaycaster()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AddComponentMenu("Event/Physics 2D Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x48")]
		private RaycastHit2D[] m_Hits;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x3041938", Offset = "0x303D938", VA = "0x3041938")]
		protected Physics2DRaycaster()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x3041990", Offset = "0x303D990", VA = "0x3041990", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Event/Physics Raycaster")]
	public class PhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x20000C7")]
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0x0")]
			public static RaycastHitComparer instance;

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x3042904", Offset = "0x303E904", VA = "0x3042904", Slot = "4")]
			public int Compare(RaycastHit x, RaycastHit y)
			{
				return default(int);
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x3042944", Offset = "0x303E944", VA = "0x3042944")]
			public RaycastHitComparer()
			{
			}
		}

		[Token(Token = "0x4000348")]
		protected const int kNoEventMaskSet = -1;

		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x28")]
		protected Camera m_EventCamera;

		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected LayerMask m_EventMask;

		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected int m_MaxRayIntersections;

		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x38")]
		protected int m_LastMaxRayIntersections;

		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x40")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x170001F3")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x304239C", Offset = "0x303E39C", VA = "0x304239C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F4")]
		public virtual int depth
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x304246C", Offset = "0x303E46C", VA = "0x304246C", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F5")]
		public int finalEventMask
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x30422D8", Offset = "0x303E2D8", VA = "0x30422D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F6")]
		public LayerMask eventMask
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x3042530", Offset = "0x303E530", VA = "0x3042530")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x3042538", Offset = "0x303E538", VA = "0x3042538")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		public int maxRayIntersections
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x3042540", Offset = "0x303E540", VA = "0x3042540")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x3042548", Offset = "0x303E548", VA = "0x3042548")]
			set
			{
			}
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x3041964", Offset = "0x303D964", VA = "0x3041964")]
		protected PhysicsRaycaster()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x3041FE4", Offset = "0x303DFE4", VA = "0x3041FE4")]
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x3042550", Offset = "0x303E550", VA = "0x3042550", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public struct RaycastResult
	{
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x0")]
		private GameObject m_GameObject;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x8")]
		public BaseRaycaster module;

		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x10")]
		public float distance;

		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x14")]
		public float index;

		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x18")]
		public int depth;

		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x1C")]
		public int sortingGroupID;

		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x20")]
		public int sortingGroupOrder;

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x24")]
		public int sortingLayer;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x28")]
		public int sortingOrder;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 worldPosition;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 worldNormal;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 screenPosition;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x4C")]
		public int displayIndex;

		[Token(Token = "0x170001F8")]
		public GameObject gameObject
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x30429A8", Offset = "0x303E9A8", VA = "0x30429A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x30429B0", Offset = "0x303E9B0", VA = "0x30429B0")]
			set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public bool isValid
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x30429B8", Offset = "0x303E9B8", VA = "0x30429B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x3042A50", Offset = "0x303EA50", VA = "0x3042A50")]
		public void Clear()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x3037A14", Offset = "0x3033A14", VA = "0x3037A14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C9")]
	public abstract class UIBehaviour : MonoBehaviour
	{
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x3042AF4", Offset = "0x303EAF4", VA = "0x3042AF4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x30340B4", Offset = "0x30300B4", VA = "0x30340B4", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x3039348", Offset = "0x3035348", VA = "0x3039348", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x30340BC", Offset = "0x30300BC", VA = "0x30340BC", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x3042AF8", Offset = "0x303EAF8", VA = "0x3042AF8", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x3042AFC", Offset = "0x303EAFC", VA = "0x3042AFC", Slot = "9")]
		public virtual bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x3042B04", Offset = "0x303EB04", VA = "0x3042B04", Slot = "10")]
		protected virtual void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x3042B08", Offset = "0x303EB08", VA = "0x3042B08", Slot = "11")]
		protected virtual void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x3041934", Offset = "0x303D934", VA = "0x3041934", Slot = "12")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x3042B0C", Offset = "0x303EB0C", VA = "0x3042B0C", Slot = "13")]
		protected virtual void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x3042B10", Offset = "0x303EB10", VA = "0x3042B10", Slot = "14")]
		protected virtual void OnCanvasGroupChanged()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x3041928", Offset = "0x303D928", VA = "0x3041928", Slot = "15")]
		protected virtual void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x3042B14", Offset = "0x303EB14", VA = "0x3042B14", Slot = "16")]
		public bool IsDestroyed()
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x30360E8", Offset = "0x30320E8", VA = "0x30360E8")]
		protected UIBehaviour()
		{
		}
	}
}
namespace UnityEditor.Rendering.BuiltIn.ShaderGraph
{
	[Token(Token = "0x20000CA")]
	internal static class MaterialAccess
	{
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x3042B70", Offset = "0x303EB70", VA = "0x3042B70")]
		internal static int ReadMaterialRawRenderQueue(Material mat)
		{
			return default(int);
		}
	}
}
namespace UnityEditor.Rendering.Universal
{
	[Token(Token = "0x20000CB")]
	internal static class MaterialAccess
	{
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x3042B84", Offset = "0x303EB84", VA = "0x3042B84")]
		internal static int ReadMaterialRawRenderQueue(Material mat)
		{
			return default(int);
		}
	}
}
