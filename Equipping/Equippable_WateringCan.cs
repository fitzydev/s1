using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C5 RID: 2501
	[Token(Token = "0x20009C5")]
	public class Equippable_WateringCan : Equippable_Pourable
	{
		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004456 RID: 17494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700097F")]
		public override string InteractionLabel
		{
			[Token(Token = "0x6004455")]
			[Address(RVA = "0x506BA0", Offset = "0x5055A0", VA = "0x180506BA0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004456")]
			[Address(RVA = "0x592AE0", Offset = "0x5914E0", VA = "0x180592AE0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004457")]
		[Address(RVA = "0x8BE760", Offset = "0x8BD160", VA = "0x1808BE760", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x8BE9D0", Offset = "0x8BD3D0", VA = "0x1808BE9D0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004459")]
		[Address(RVA = "0x8BEAF0", Offset = "0x8BD4F0", VA = "0x1808BEAF0")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x8BE5B0", Offset = "0x8BCFB0", VA = "0x1808BE5B0", Slot = "14")]
		protected override bool CanPour(Pot pot, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x8BE960", Offset = "0x8BD360", VA = "0x1808BE960", Slot = "13")]
		protected override void StartPourTask(Pot pot)
		{
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x8BEB50", Offset = "0x8BD550", VA = "0x1808BEB50")]
		public Equippable_WateringCan()
		{
		}

		// Token: 0x04002FD9 RID: 12249
		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x88")]
		public WateringCanVisuals Visuals;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x90")]
		private WateringCanInstance WCInstance;
	}
}
