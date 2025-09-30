using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	[CreateAssetMenu(fileName = "Focused", menuName = "Properties/Focused Property")]
	public class Focused : Property
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Focused()
		{
		}
	}
}
