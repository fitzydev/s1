using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009C7 RID: 2503
	[Token(Token = "0x20009C7")]
	public class Equippable_Additive : Equippable_Pourable
	{
		// Token: 0x06004460 RID: 17504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004460")]
		[Address(RVA = "0x8B7B00", Offset = "0x8B6500", VA = "0x1808B7B00", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x8B7C40", Offset = "0x8B6640", VA = "0x1808B7C40", Slot = "13")]
		protected override void StartPourTask(Pot pot)
		{
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x6004462")]
		[Address(RVA = "0x8B7930", Offset = "0x8B6330", VA = "0x1808B7930", Slot = "14")]
		protected override bool CanPour(Pot pot, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004463")]
		[Address(RVA = "0x8B7CB0", Offset = "0x8B66B0", VA = "0x1808B7CB0")]
		public Equippable_Additive()
		{
		}

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x80")]
		private AdditiveDefinition additiveDef;
	}
}
