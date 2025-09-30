using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	// Token: 0x02000823 RID: 2083
	[Token(Token = "0x2000823")]
	public class BuildStart_Grid : BuildStart_Base
	{
		// Token: 0x0600394F RID: 14671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394F")]
		[Address(RVA = "0x7F7040", Offset = "0x7F5A40", VA = "0x1807F7040", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003950")]
		[Address(RVA = "0x7F6B90", Offset = "0x7F5590", VA = "0x1807F6B90", Slot = "5")]
		protected virtual GridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003951")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BuildStart_Grid()
		{
		}
	}
}
