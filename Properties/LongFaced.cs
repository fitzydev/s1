using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	[CreateAssetMenu(fileName = "LongFaced", menuName = "Properties/LongFaced Property")]
	public class LongFaced : Property
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x598A00", Offset = "0x597400", VA = "0x180598A00", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x598A40", Offset = "0x597440", VA = "0x180598A40", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x598B40", Offset = "0x597540", VA = "0x180598B40", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x598B80", Offset = "0x597580", VA = "0x180598B80", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x58D840", Offset = "0x58C240", VA = "0x18058D840")]
		public LongFaced()
		{
		}
	}
}
