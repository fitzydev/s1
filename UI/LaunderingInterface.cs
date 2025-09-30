using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts.Cash;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000ABC RID: 2748
	[Token(Token = "0x2000ABC")]
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x17000A79")]
		protected int maxLaunderAmount
		{
			[Token(Token = "0x6004A96")]
			[Address(RVA = "0x91EBA0", Offset = "0x91D5A0", VA = "0x18091EBA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A98 RID: 19096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7A")]
		public Business business
		{
			[Token(Token = "0x6004A97")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A98")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x17000A7B")]
		public bool isOpen
		{
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x91EB00", Offset = "0x91D500", VA = "0x18091EB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x91C440", Offset = "0x91AE40", VA = "0x18091C440")]
		public void Initialize(Business bus)
		{
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x91CED0", Offset = "0x91B8D0", VA = "0x18091CED0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9C")]
		[Address(RVA = "0x91CE40", Offset = "0x91B840", VA = "0x18091CE40", Slot = "4")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9D")]
		[Address(RVA = "0x91C2B0", Offset = "0x91ACB0", VA = "0x18091C2B0")]
		protected void Exit(ExitAction exit)
		{
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x91E2C0", Offset = "0x91CCC0", VA = "0x18091E2C0")]
		protected void UpdateTimeline()
		{
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9F")]
		[Address(RVA = "0x91DE10", Offset = "0x91C810", VA = "0x18091DE10")]
		protected void UpdateCurrentTotal()
		{
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA0")]
		[Address(RVA = "0x91C020", Offset = "0x91AA20", VA = "0x18091C020")]
		private void CreateEntry(LaunderingOperation op)
		{
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA1")]
		[Address(RVA = "0x91DA00", Offset = "0x91C400", VA = "0x18091DA00")]
		private void RemoveEntry(LaunderingOperation op)
		{
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA2")]
		[Address(RVA = "0x91DE70", Offset = "0x91C870", VA = "0x18091DE70")]
		private void UpdateEntryTimes()
		{
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA3")]
		[Address(RVA = "0x91DD10", Offset = "0x91C710", VA = "0x18091DD10")]
		private void UpdateCashStacks(LaunderingOperation op)
		{
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA4")]
		[Address(RVA = "0x91D7B0", Offset = "0x91C1B0", VA = "0x18091D7B0")]
		private void RefreshLaunderButton()
		{
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x91D2D0", Offset = "0x91BCD0", VA = "0x18091D2D0")]
		public void OpenAmountSelector()
		{
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x91BA80", Offset = "0x91A480", VA = "0x18091BA80")]
		public void CloseAmountSelector()
		{
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA7")]
		[Address(RVA = "0x91BDB0", Offset = "0x91A7B0", VA = "0x18091BDB0")]
		public void ConfirmAmount()
		{
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x91DB80", Offset = "0x91C580", VA = "0x18091DB80")]
		public void SliderValueChanged()
		{
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x91CD40", Offset = "0x91B740", VA = "0x18091CD40")]
		public void InputValueChanged()
		{
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x91C380", Offset = "0x91AD80", VA = "0x18091C380")]
		public void Hovered()
		{
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x91CDF0", Offset = "0x91B7F0", VA = "0x18091CDF0")]
		public void Interacted()
		{
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x91D3C0", Offset = "0x91BDC0", VA = "0x18091D3C0", Slot = "5")]
		public virtual void Open()
		{
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x91BAB0", Offset = "0x91A4B0", VA = "0x18091BAB0", Slot = "6")]
		public virtual void Close()
		{
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x91E9F0", Offset = "0x91D3F0", VA = "0x18091E9F0")]
		public LaunderingInterface()
		{
		}

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		protected const float fovOverride = 65f;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		protected const float lerpTime = 0.15f;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		protected const int minLaunderAmount = 10;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected Transform cameraPosition;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04003582 RID: 13698
		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Button launderButton;

		// Token: 0x04003583 RID: 13699
		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject amountSelectorScreen;

		// Token: 0x04003584 RID: 13700
		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Slider amountSlider;

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected TMP_InputField amountInputField;

		// Token: 0x04003586 RID: 13702
		[Token(Token = "0x4003586")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected RectTransform notchContainer;

		// Token: 0x04003587 RID: 13703
		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TextMeshProUGUI currentTotalAmountLabel;

		// Token: 0x04003588 RID: 13704
		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected TextMeshProUGUI launderCapacityLabel;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected TextMeshProUGUI insufficientCashLabel;

		// Token: 0x0400358A RID: 13706
		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected RectTransform entryContainer;

		// Token: 0x0400358B RID: 13707
		[Token(Token = "0x400358B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected RectTransform noEntries;

		// Token: 0x0400358C RID: 13708
		[Token(Token = "0x400358C")]
		[FieldOffset(Offset = "0x88")]
		public CashStackVisuals[] CashStacks;

		// Token: 0x0400358D RID: 13709
		[Token(Token = "0x400358D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Header("Prefabs")]
		protected GameObject timelineNotchPrefab;

		// Token: 0x0400358E RID: 13710
		[Token(Token = "0x400358E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected GameObject entryPrefab;

		// Token: 0x0400358F RID: 13711
		[Token(Token = "0x400358F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Header("UI references")]
		protected Canvas canvas;

		// Token: 0x04003590 RID: 13712
		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0xA8")]
		private int selectedAmountToLaunder;

		// Token: 0x04003591 RID: 13713
		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<LaunderingOperation, RectTransform> operationToNotch;

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0xB8")]
		private List<RectTransform> notches;

		// Token: 0x04003593 RID: 13715
		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0xC0")]
		private bool ignoreSliderChange;

		// Token: 0x04003594 RID: 13716
		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<LaunderingOperation, RectTransform> operationToEntry;
	}
}
