using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	[CreateAssetMenu(fileName = "AntiGravity", menuName = "Properties/AntiGravity Property")]
	public class AntiGravity : Property
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x58D6C0", Offset = "0x58C0C0", VA = "0x18058D6C0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x58D720", Offset = "0x58C120", VA = "0x18058D720", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x58D780", Offset = "0x58C180", VA = "0x18058D780", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x58D7E0", Offset = "0x58C1E0", VA = "0x18058D7E0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public AntiGravity()
		{
		}

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		public const float GravityMultiplier = 0.3f;
	}
}
