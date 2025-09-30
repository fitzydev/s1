using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	[CreateAssetMenu(fileName = "Munchies", menuName = "Properties/Munchies Property")]
	public class Munchies : Property
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001191")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001193")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Munchies()
		{
		}
	}
}
