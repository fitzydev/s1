using System;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Employees
{
	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	public class NPCResponses_Employee : NPCResponses
	{
		// Token: 0x0600234B RID: 9035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x6CDD50", Offset = "0x6CC750", VA = "0x1806CDD50", Slot = "20")]
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x6CDD80", Offset = "0x6CC780", VA = "0x1806CDD80", Slot = "22")]
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x6CDDB0", Offset = "0x6CC7B0", VA = "0x1806CDDB0", Slot = "21")]
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x6CDBE0", Offset = "0x6CC5E0", VA = "0x1806CDBE0")]
		private void Ow(Player perpetrator)
		{
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x6CDDE0", Offset = "0x6CC7E0", VA = "0x1806CDDE0")]
		public NPCResponses_Employee()
		{
		}
	}
}
