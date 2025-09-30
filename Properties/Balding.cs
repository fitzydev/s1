using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	[CreateAssetMenu(fileName = "Balding", menuName = "Properties/Balding Property")]
	public class Balding : Property
	{
		// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119E")]
		[Address(RVA = "0x58E540", Offset = "0x58CF40", VA = "0x18058E540", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x58E580", Offset = "0x58CF80", VA = "0x18058E580", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x58E5C0", Offset = "0x58CFC0", VA = "0x18058E5C0", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x58E600", Offset = "0x58D000", VA = "0x18058E600", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Balding()
		{
		}
	}
}
