using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	// Token: 0x02000826 RID: 2086
	[Token(Token = "0x2000826")]
	public class BuildStart_Surface : BuildStart_Base
	{
		// Token: 0x06003958 RID: 14680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x7F82E0", Offset = "0x7F6CE0", VA = "0x1807F82E0", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003959")]
		[Address(RVA = "0x7F7F80", Offset = "0x7F6980", VA = "0x1807F7F80", Slot = "5")]
		protected virtual SurfaceItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395A")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BuildStart_Surface()
		{
		}
	}
}
