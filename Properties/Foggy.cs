using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000320 RID: 800
	[Token(Token = "0x2000320")]
	[CreateAssetMenu(fileName = "Foggy", menuName = "Properties/Foggy Property")]
	public class Foggy : Property
	{
		// Token: 0x060011C6 RID: 4550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x594E10", Offset = "0x593810", VA = "0x180594E10", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x594E50", Offset = "0x593850", VA = "0x180594E50", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x594F60", Offset = "0x593960", VA = "0x180594F60", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x594FA0", Offset = "0x5939A0", VA = "0x180594FA0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Foggy()
		{
		}
	}
}
