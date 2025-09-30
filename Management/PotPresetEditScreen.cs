using System;
using Il2CppDummyDll;
using ScheduleOne.Management.Presets;
using ScheduleOne.Management.Presets.Options;

namespace ScheduleOne.Management
{
	// Token: 0x020004F4 RID: 1268
	[Token(Token = "0x20004F4")]
	public class PotPresetEditScreen : PresetEditScreen
	{
		// Token: 0x060019CF RID: 6607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x64A6F0", Offset = "0x6490F0", VA = "0x18064A6F0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x64AAB0", Offset = "0x6494B0", VA = "0x18064AAB0", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x64A800", Offset = "0x649200", VA = "0x18064A800", Slot = "5")]
		public override void Open(Preset preset)
		{
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x64A9E0", Offset = "0x6493E0", VA = "0x18064A9E0")]
		private void UpdateUI()
		{
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x64A8E0", Offset = "0x6492E0", VA = "0x18064A8E0")]
		public void SeedsUIClicked()
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x64A5F0", Offset = "0x648FF0", VA = "0x18064A5F0")]
		public void AdditivesUIClicked()
		{
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PotPresetEditScreen()
		{
		}

		// Token: 0x0400166A RID: 5738
		[Token(Token = "0x400166A")]
		[FieldOffset(Offset = "0x60")]
		public GenericOptionUI SeedsUI;

		// Token: 0x0400166B RID: 5739
		[Token(Token = "0x400166B")]
		[FieldOffset(Offset = "0x68")]
		public GenericOptionUI AdditivesUI;

		// Token: 0x0400166C RID: 5740
		[Token(Token = "0x400166C")]
		[FieldOffset(Offset = "0x70")]
		private PotPreset castedPreset;
	}
}
