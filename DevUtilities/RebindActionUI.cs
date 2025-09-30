using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077A")]
		public InputActionReference actionReference
		{
			[Token(Token = "0x6003394")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003395")]
			[Address(RVA = "0x789AF0", Offset = "0x7884F0", VA = "0x180789AF0")]
			set
			{
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077B")]
		public string bindingId
		{
			[Token(Token = "0x6003396")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003397")]
			[Address(RVA = "0x789B20", Offset = "0x788520", VA = "0x180789B20")]
			set
			{
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077C")]
		public InputBinding.DisplayStringOptions displayStringOptions
		{
			[Token(Token = "0x6003398")]
			[Address(RVA = "0x47D780", Offset = "0x47C180", VA = "0x18047D780")]
			get
			{
				return (InputBinding.DisplayStringOptions)0;
			}
			[Token(Token = "0x6003399")]
			[Address(RVA = "0x789B80", Offset = "0x788580", VA = "0x180789B80")]
			set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077D")]
		public TextMeshProUGUI actionLabel
		{
			[Token(Token = "0x600339A")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			get
			{
				return null;
			}
			[Token(Token = "0x600339B")]
			[Address(RVA = "0x789AC0", Offset = "0x7884C0", VA = "0x180789AC0")]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077E")]
		public TextMeshProUGUI bindingText
		{
			[Token(Token = "0x600339C")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600339D")]
			[Address(RVA = "0x789B50", Offset = "0x788550", VA = "0x180789B50")]
			set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077F")]
		public TextMeshProUGUI rebindPrompt
		{
			[Token(Token = "0x600339E")]
			[Address(RVA = "0x486240", Offset = "0x484C40", VA = "0x180486240")]
			get
			{
				return null;
			}
			[Token(Token = "0x600339F")]
			[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
			set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000780")]
		public GameObject rebindOverlay
		{
			[Token(Token = "0x60033A0")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60033A1")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000781")]
		public RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			[Token(Token = "0x60033A2")]
			[Address(RVA = "0x789A30", Offset = "0x788430", VA = "0x180789A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000782")]
		public RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			[Token(Token = "0x60033A3")]
			[Address(RVA = "0x789910", Offset = "0x788310", VA = "0x180789910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000783")]
		public RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			[Token(Token = "0x60033A4")]
			[Address(RVA = "0x7899A0", Offset = "0x7883A0", VA = "0x1807899A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000784")]
		public InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			[Token(Token = "0x60033A5")]
			[Address(RVA = "0x4F2140", Offset = "0x4F0B40", VA = "0x1804F2140")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x60033A6")]
		[Address(RVA = "0x789040", Offset = "0x787A40", VA = "0x180789040")]
		public bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			return default(bool);
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x789710", Offset = "0x788110", VA = "0x180789710")]
		public void UpdateBindingDisplay()
		{
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x788C90", Offset = "0x787690", VA = "0x180788C90")]
		public void ResetToDefault()
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x789240", Offset = "0x787C40", VA = "0x180789240")]
		public void StartInteractiveRebind()
		{
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x7887E0", Offset = "0x7871E0", VA = "0x1807887E0")]
		private void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x788610", Offset = "0x787010", VA = "0x180788610")]
		protected void OnEnable()
		{
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x7884D0", Offset = "0x786ED0", VA = "0x1807884D0")]
		protected void OnDisable()
		{
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AD")]
		[Address(RVA = "0x788290", Offset = "0x786C90", VA = "0x180788290")]
		private static void OnActionChange(object obj, InputActionChange change)
		{
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AE")]
		[Address(RVA = "0x789650", Offset = "0x788050", VA = "0x180789650")]
		private void UpdateActionLabel()
		{
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public RebindActionUI()
		{
		}

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x20")]
		public Action onRebind;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Reference to action that is to be rebound from the UI.")]
		private InputActionReference m_Action;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_BindingId;

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputBinding.DisplayStringOptions m_DisplayStringOptions;

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Text label that will receive the name of the action. Optional. Set to None to have the rebind UI not show a label for the action.")]
		[SerializeField]
		private TextMeshProUGUI m_ActionLabel;

		// Token: 0x040023F3 RID: 9203
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Text label that will receive the current, formatted binding string.")]
		[SerializeField]
		private TextMeshProUGUI m_BindingText;

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Optional UI that will be shown while a rebind is in progress.")]
		[SerializeField]
		private GameObject m_RebindOverlay;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Optional text label that will be updated with prompt for user input.")]
		[SerializeField]
		private TextMeshProUGUI m_RebindText;

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Event that is triggered when the way the binding is display should be updated. This allows displaying bindings in custom ways, e.g. using images instead of text.")]
		[SerializeField]
		private RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Event that is triggered when an interactive rebind is being initiated. This can be used, for example, to implement custom UI behavior while a rebind is in progress. It can also be used to further customize the rebind.")]
		[SerializeField]
		private RebindActionUI.InteractiveRebindEvent m_RebindStartEvent;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Event that is triggered when an interactive rebind is complete or has been aborted.")]
		private RebindActionUI.InteractiveRebindEvent m_RebindStopEvent;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x78")]
		private InputActionRebindingExtensions.RebindingOperation m_RebindOperation;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x0")]
		private static List<RebindActionUI> s_RebindActionUIs;

		// Token: 0x0200077E RID: 1918
		[Token(Token = "0x200077E")]
		[Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
			// Token: 0x060033B1 RID: 13233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033B1")]
			[Address(RVA = "0x78D750", Offset = "0x78C150", VA = "0x18078D750")]
			public UpdateBindingUIEvent()
			{
			}
		}

		// Token: 0x0200077F RID: 1919
		[Token(Token = "0x200077F")]
		[Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
			// Token: 0x060033B2 RID: 13234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033B2")]
			[Address(RVA = "0x778FB0", Offset = "0x7779B0", VA = "0x180778FB0")]
			public InteractiveRebindEvent()
			{
			}
		}
	}
}
