using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A05 RID: 2565
	[Token(Token = "0x2000A05")]
	[Serializable]
	public class SlotFilter
	{
		// Token: 0x06004629 RID: 17961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x8C8ED0", Offset = "0x8C78D0", VA = "0x1808C8ED0")]
		public SlotFilter()
		{
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x600462A")]
		[Address(RVA = "0x8C8D10", Offset = "0x8C7710", VA = "0x1808C8D10")]
		public bool DoesItemMatchFilter(ItemInstance instance)
		{
			return default(bool);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x600462B")]
		[Address(RVA = "0x8C8E60", Offset = "0x8C7860", VA = "0x1808C8E60")]
		public bool IsDefault()
		{
			return default(bool);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462C")]
		[Address(RVA = "0x8C8BF0", Offset = "0x8C75F0", VA = "0x1808C8BF0")]
		public SlotFilter Clone()
		{
			return null;
		}

		// Token: 0x04003108 RID: 12552
		[Token(Token = "0x4003108")]
		[FieldOffset(Offset = "0x10")]
		public SlotFilter.EType Type;

		// Token: 0x04003109 RID: 12553
		[Token(Token = "0x4003109")]
		[FieldOffset(Offset = "0x18")]
		public List<string> ItemIDs;

		// Token: 0x0400310A RID: 12554
		[Token(Token = "0x400310A")]
		[FieldOffset(Offset = "0x20")]
		public List<EQuality> AllowedQualities;

		// Token: 0x02000A06 RID: 2566
		[Token(Token = "0x2000A06")]
		public enum EType
		{
			// Token: 0x0400310C RID: 12556
			[Token(Token = "0x400310C")]
			None,
			// Token: 0x0400310D RID: 12557
			[Token(Token = "0x400310D")]
			Whitelist,
			// Token: 0x0400310E RID: 12558
			[Token(Token = "0x400310E")]
			Blacklist
		}
	}
}
