using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	[CreateAssetMenu(fileName = "Glowie", menuName = "Properties/Glowie Property")]
	public class Glowie : Property
	{
		// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x595360", Offset = "0x593D60", VA = "0x180595360", Slot = "4")]
		public override void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x5953B0", Offset = "0x593DB0", VA = "0x1805953B0", Slot = "6")]
		public override void ApplyToPlayer(Player player)
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x595400", Offset = "0x593E00", VA = "0x180595400", Slot = "5")]
		public override void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x595440", Offset = "0x593E40", VA = "0x180595440", Slot = "7")]
		public override void ClearFromPlayer(Player player)
		{
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x58E520", Offset = "0x58CF20", VA = "0x18058E520")]
		public Glowie()
		{
		}

		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x4001147")]
		[FieldOffset(Offset = "0x78")]
		[ColorUsage(true, true)]
		[SerializeField]
		public Color GlowColor;
	}
}
