using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	[CreateAssetMenu(fileName = "Zombifying", menuName = "Properties/Zombifying Property")]
	public class Zombifying : Property
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x5A7D90", Offset = "0x5A6790", VA = "0x1805A7D90", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x5A7E50", Offset = "0x5A6850", VA = "0x1805A7E50", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x5A7E90", Offset = "0x5A6890", VA = "0x1805A7E90", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x5A7F20", Offset = "0x5A6920", VA = "0x1805A7F20", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Zombifying()
		{
		}

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x78")]
		public VODatabase zombieVODatabase;
	}
}
