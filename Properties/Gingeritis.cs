using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	[CreateAssetMenu(fileName = "Gingeritis", menuName = "Properties/Gingeritis Property")]
	public class Gingeritis : Property
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x595090", Offset = "0x593A90", VA = "0x180595090", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x595190", Offset = "0x593B90", VA = "0x180595190", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x595290", Offset = "0x593C90", VA = "0x180595290", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x5952D0", Offset = "0x593CD0", VA = "0x1805952D0", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public Gingeritis()
		{
		}

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 Color;
	}
}
