using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	public class Meth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x0600574F RID: 22351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574F")]
		[Address(RVA = "0xA1D180", Offset = "0xA1BB80", VA = "0x180A1D180", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005750")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public Meth_Equippable()
		{
		}

		// Token: 0x04004097 RID: 16535
		[Token(Token = "0x4004097")]
		[FieldOffset(Offset = "0x68")]
		public MethVisuals Visuals;
	}
}
