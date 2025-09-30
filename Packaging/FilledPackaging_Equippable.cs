using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000932 RID: 2354
	[Token(Token = "0x2000932")]
	public class FilledPackaging_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600405B RID: 16475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405B")]
		[Address(RVA = "0x8603B0", Offset = "0x85EDB0", VA = "0x1808603B0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405C")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public FilledPackaging_Equippable()
		{
		}

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x68")]
		public FilledPackagingVisuals Visuals;
	}
}
