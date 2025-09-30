using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.Presets;
using ScheduleOne.Management.Presets.Options.SetterScreens;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Management
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	public class PresetEditScreen : MonoBehaviour
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x17000492")]
		public bool isOpen
		{
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0x64BD80", Offset = "0x64A780", VA = "0x18064BD80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x64B240", Offset = "0x649C40", VA = "0x18064B240", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x64B5B0", Offset = "0x649FB0", VA = "0x18064B5B0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x64B7E0", Offset = "0x64A1E0", VA = "0x18064B7E0", Slot = "5")]
		public virtual void Open(Preset preset)
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DA")]
		[Address(RVA = "0x64B480", Offset = "0x649E80", VA = "0x18064B480")]
		public void Close()
		{
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x64B970", Offset = "0x64A370", VA = "0x18064B970")]
		private void RefreshIcon()
		{
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x64BA30", Offset = "0x64A430", VA = "0x18064BA30")]
		private void RefreshTransforms()
		{
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x64B6C0", Offset = "0x64A0C0", VA = "0x18064B6C0")]
		private void NameFieldChange(string newVal)
		{
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x64B6D0", Offset = "0x64A0D0", VA = "0x18064B6D0")]
		private void NameFieldDone(string piss)
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x64B630", Offset = "0x64A030", VA = "0x18064B630")]
		private bool IsNameAppropriate(string name)
		{
			return default(bool);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x64B4D0", Offset = "0x649ED0", VA = "0x18064B4D0")]
		public void DeleteButtonClicked()
		{
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x64B480", Offset = "0x649E80", VA = "0x18064B480")]
		public void ReturnButtonClicked()
		{
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PresetEditScreen()
		{
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x64BD10", Offset = "0x64A710", VA = "0x18064BD10")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Delay|13_0()
		{
			return null;
		}

		// Token: 0x0400166D RID: 5741
		[Token(Token = "0x400166D")]
		[FieldOffset(Offset = "0x20")]
		public Preset EditedPreset;

		// Token: 0x0400166E RID: 5742
		[Token(Token = "0x400166E")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform IconBackgroundRect;

		// Token: 0x0400166F RID: 5743
		[Token(Token = "0x400166F")]
		[FieldOffset(Offset = "0x30")]
		public Image IconBackground;

		// Token: 0x04001670 RID: 5744
		[Token(Token = "0x4001670")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform InputFieldRect;

		// Token: 0x04001671 RID: 5745
		[Token(Token = "0x4001671")]
		[FieldOffset(Offset = "0x40")]
		public TMP_InputField InputField;

		// Token: 0x04001672 RID: 5746
		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform EditButtonRect;

		// Token: 0x04001673 RID: 5747
		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0x50")]
		public Button ReturnButton;

		// Token: 0x04001674 RID: 5748
		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0x58")]
		public Button DeleteButton;

		// Token: 0x020004F6 RID: 1270
		[Token(Token = "0x20004F6")]
		[Serializable]
		public class OptionData
		{
			// Token: 0x060019E4 RID: 6628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public OptionData()
			{
			}

			// Token: 0x04001675 RID: 5749
			[Token(Token = "0x4001675")]
			[FieldOffset(Offset = "0x10")]
			public GameObject OptionEntryPrefab;

			// Token: 0x04001676 RID: 5750
			[Token(Token = "0x4001676")]
			[FieldOffset(Offset = "0x18")]
			public OptionSetterScreen OptionSetterScreen;
		}
	}
}
