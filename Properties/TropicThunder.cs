using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	[CreateAssetMenu(fileName = "TropicThunder", menuName = "Properties/TropicThunder Property")]
	public class TropicThunder : Property
	{
		// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x5A62A0", Offset = "0x5A4CA0", VA = "0x1805A62A0", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x5A62E0", Offset = "0x5A4CE0", VA = "0x1805A62E0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x5A6320", Offset = "0x5A4D20", VA = "0x1805A6320", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x5A6360", Offset = "0x5A4D60", VA = "0x1805A6360", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public TropicThunder()
		{
		}
	}
}
