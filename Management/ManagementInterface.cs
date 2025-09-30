using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.UI;
using ScheduleOne.Tools;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000495")]
		public ManagementClipboard_Equippable EquippedClipboard
		{
			[Token(Token = "0x60019EF")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F0")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x63F350", Offset = "0x63DD50", VA = "0x18063F350")]
		public void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x63ECE0", Offset = "0x63D6E0", VA = "0x18063ECE0")]
		public void Close(bool preserveState = false)
		{
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x63F670", Offset = "0x63E070", VA = "0x18063F670")]
		private void UpdateMainLabels()
		{
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x63EFC0", Offset = "0x63D9C0", VA = "0x18063EFC0")]
		private void InitializeConfigPanel()
		{
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x63EE30", Offset = "0x63D830", VA = "0x18063EE30")]
		private void DestroyConfigPanel()
		{
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x63EEF0", Offset = "0x63D8F0", VA = "0x18063EEF0")]
		public ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			return null;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x63F700", Offset = "0x63E100", VA = "0x18063F700")]
		public ManagementInterface()
		{
		}

		// Token: 0x0400167B RID: 5755
		[Token(Token = "0x400167B")]
		public const float PANEL_SLIDE_TIME = 0.1f;

		// Token: 0x0400167D RID: 5757
		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public TextMeshProUGUI NothingSelectedLabel;

		// Token: 0x0400167E RID: 5758
		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI DifferentTypesSelectedLabel;

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform PanelContainer;

		// Token: 0x04001680 RID: 5760
		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x48")]
		public ClipboardScreen MainScreen;

		// Token: 0x04001681 RID: 5761
		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0x50")]
		public ItemSelector ItemSelectorScreen;

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0x58")]
		public NPCSelector NPCSelector;

		// Token: 0x04001683 RID: 5763
		[Token(Token = "0x4001683")]
		[FieldOffset(Offset = "0x60")]
		public ScheduleOne.UI.Management.ObjectSelector ObjectSelector;

		// Token: 0x04001684 RID: 5764
		[Token(Token = "0x4001684")]
		[FieldOffset(Offset = "0x68")]
		public RecipeSelector RecipeSelectorScreen;

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x70")]
		public TransitEntitySelector TransitEntitySelector;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected ManagementInterface.ConfigurableTypePanel[] ConfigPanelPrefabs;

		// Token: 0x04001687 RID: 5767
		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0x80")]
		public List<IConfigurable> Configurables;

		// Token: 0x04001688 RID: 5768
		[Token(Token = "0x4001688")]
		[FieldOffset(Offset = "0x88")]
		private bool areConfigurablesUniform;

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0x90")]
		private ConfigPanel loadedPanel;

		// Token: 0x020004FA RID: 1274
		[Token(Token = "0x20004FA")]
		[Serializable]
		public class ConfigurableTypePanel
		{
			// Token: 0x060019F9 RID: 6649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ConfigurableTypePanel()
			{
			}

			// Token: 0x0400168A RID: 5770
			[Token(Token = "0x400168A")]
			[FieldOffset(Offset = "0x10")]
			public EConfigurableType Type;

			// Token: 0x0400168B RID: 5771
			[Token(Token = "0x400168B")]
			[FieldOffset(Offset = "0x18")]
			public ConfigPanel Panel;
		}
	}
}
