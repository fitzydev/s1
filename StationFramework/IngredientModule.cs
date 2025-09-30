using System;
using Il2CppDummyDll;

namespace ScheduleOne.StationFramework
{
	// Token: 0x0200096E RID: 2414
	[Token(Token = "0x200096E")]
	public class IngredientModule : ItemModule
	{
		// Token: 0x0600423C RID: 16956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600423C")]
		[Address(RVA = "0x87C040", Offset = "0x87AA40", VA = "0x18087C040", Slot = "4")]
		public override void ActivateModule(StationItem item)
		{
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600423D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public IngredientModule()
		{
		}

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x30")]
		public IngredientPiece[] Pieces;
	}
}
