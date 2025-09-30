using System;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerTasks;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CC4 RID: 3268
	[Token(Token = "0x2000CC4")]
	public class FunctionalWateringCan : Pourable
	{
		// Token: 0x06005C7F RID: 23679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0xA3E6B0", Offset = "0xA3D0B0", VA = "0x180A3E6B0")]
		public void Setup(WateringCanInstance instance)
		{
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0xA3E620", Offset = "0xA3D020", VA = "0x180A3E620", Slot = "16")]
		protected override void PourAmount(float amount)
		{
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x8737D0", Offset = "0x8721D0", VA = "0x1808737D0")]
		public FunctionalWateringCan()
		{
		}

		// Token: 0x04004334 RID: 17204
		[Token(Token = "0x4004334")]
		[FieldOffset(Offset = "0x138")]
		public WateringCanVisuals Visuals;

		// Token: 0x04004335 RID: 17205
		[Token(Token = "0x4004335")]
		[FieldOffset(Offset = "0x140")]
		private WateringCanInstance itemInstance;
	}
}
