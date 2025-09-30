using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000B13 RID: 2835
	[Token(Token = "0x2000B13")]
	public class VehicleModMenu : Singleton<VehicleModMenu>
	{
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x00013CF8 File Offset: 0x00011EF8
		// (set) Token: 0x06004CE9 RID: 19689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD0")]
		public bool IsOpen
		{
			[Token(Token = "0x6004CE8")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CE9")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x940260", Offset = "0x93EC60", VA = "0x180940260", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x940900", Offset = "0x93F300", VA = "0x180940900", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x9405F0", Offset = "0x93EFF0", VA = "0x1809405F0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x9410B0", Offset = "0x93FAB0", VA = "0x1809410B0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x940650", Offset = "0x93F050", VA = "0x180940650")]
		public void Open(LandVehicle vehicle)
		{
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x940310", Offset = "0x93ED10", VA = "0x180940310")]
		public void Close()
		{
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x940400", Offset = "0x93EE00", VA = "0x180940400")]
		public void ColorClicked(EVehicleColor col)
		{
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x940FB0", Offset = "0x93F9B0", VA = "0x180940FB0")]
		private void UpdateConfirmButton()
		{
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x9407F0", Offset = "0x93F1F0", VA = "0x1809407F0")]
		private void RefreshSelectionIndicator()
		{
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x940450", Offset = "0x93EE50", VA = "0x180940450")]
		public void ConfirmButtonClicked()
		{
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x941100", Offset = "0x93FB00", VA = "0x180941100")]
		public VehicleModMenu()
		{
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x940F40", Offset = "0x93F940", VA = "0x180940F40")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Close|24_0()
		{
			return null;
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x940ED0", Offset = "0x93F8D0", VA = "0x180940ED0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|25_0()
		{
			return null;
		}

		// Token: 0x040037BE RID: 14270
		[Token(Token = "0x40037BE")]
		[FieldOffset(Offset = "0x0")]
		public static float repaintCost;

		// Token: 0x040037C0 RID: 14272
		[Token(Token = "0x40037C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("UI References")]
		protected Canvas canvas;

		// Token: 0x040037C1 RID: 14273
		[Token(Token = "0x40037C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x040037C2 RID: 14274
		[Token(Token = "0x40037C2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected RectTransform tempIndicator;

		// Token: 0x040037C3 RID: 14275
		[Token(Token = "0x40037C3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected RectTransform permIndicator;

		// Token: 0x040037C4 RID: 14276
		[Token(Token = "0x40037C4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Button confirmButton_Online;

		// Token: 0x040037C5 RID: 14277
		[Token(Token = "0x40037C5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected TextMeshProUGUI confirmText_Online;

		// Token: 0x040037C6 RID: 14278
		[Token(Token = "0x40037C6")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x040037C7 RID: 14279
		[Token(Token = "0x40037C7")]
		[FieldOffset(Offset = "0x68")]
		public Transform VehiclePosition;

		// Token: 0x040037C8 RID: 14280
		[Token(Token = "0x40037C8")]
		[FieldOffset(Offset = "0x70")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		// Token: 0x040037C9 RID: 14281
		[Token(Token = "0x40037C9")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onPaintPurchased;

		// Token: 0x040037CA RID: 14282
		[Token(Token = "0x40037CA")]
		[FieldOffset(Offset = "0x80")]
		protected LandVehicle currentVehicle;

		// Token: 0x040037CB RID: 14283
		[Token(Token = "0x40037CB")]
		[FieldOffset(Offset = "0x88")]
		protected List<RectTransform> colorButtons;

		// Token: 0x040037CC RID: 14284
		[Token(Token = "0x40037CC")]
		[FieldOffset(Offset = "0x90")]
		protected Dictionary<EVehicleColor, RectTransform> colorToButton;

		// Token: 0x040037CD RID: 14285
		[Token(Token = "0x40037CD")]
		[FieldOffset(Offset = "0x98")]
		protected EVehicleColor selectedColor;

		// Token: 0x040037CE RID: 14286
		[Token(Token = "0x40037CE")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine openCloseRoutine;
	}
}
