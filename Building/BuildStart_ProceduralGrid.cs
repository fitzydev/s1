using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	public class BuildStart_ProceduralGrid : BuildStart_Base
	{
		// Token: 0x06003952 RID: 14674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003952")]
		[Address(RVA = "0x7F76E0", Offset = "0x7F60E0", VA = "0x1807F76E0", Slot = "4")]
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003953")]
		[Address(RVA = "0x7F7440", Offset = "0x7F5E40", VA = "0x1807F7440", Slot = "5")]
		protected virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003954")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BuildStart_ProceduralGrid()
		{
		}
	}
}
