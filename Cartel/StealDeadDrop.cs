using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000801 RID: 2049
	[Token(Token = "0x2000801")]
	public class StealDeadDrop : CartelActivity
	{
		// Token: 0x06003825 RID: 14373 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6003825")]
		[Address(RVA = "0x7F03C0", Offset = "0x7EEDC0", VA = "0x1807F03C0", Slot = "8")]
		public override bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003826")]
		[Address(RVA = "0x7EFE20", Offset = "0x7EE820", VA = "0x1807EFE20", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x7EFFA0", Offset = "0x7EE9A0", VA = "0x1807EFFA0")]
		private static DeadDrop GetRandomDropToStealFrom(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public StealDeadDrop()
		{
		}

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		public const int MIN_TIME_SINCE_CONTENTS_CHANGED = 360;

		// Token: 0x0400271C RID: 10012
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x40")]
		public ItemDefinition[] ItemsToLeave;
	}
}
